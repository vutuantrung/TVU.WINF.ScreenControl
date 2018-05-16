using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVControl
{
    public partial class Form1 : Form
    {
        bool _continue = false;
        string _tvId = string.Empty;
        JObject _jsonFile;
        AbstractTVControlClass _tvControl;
        RS232Class _rs232Class;
        RJ45Class _rj45Class;
        ICableCommunication _comSetup;
        int _volumeTV = 0;

        public Form1()
        {
            InitializeComponent();

            gBoxRS232.Enabled = true;
            gBoxRJ45.Enabled = false;

            btnDisconnect.Enabled = false;

            progConnect.Maximum = 5;
            progConnect.Step = 1;
            progConnect.Value = 0;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string tvModelSelected = string.Empty;
            string tvSeriesSelected = string.Empty;
            string tvCommTypeSelected = string.Empty;
            string tvIDSelected = string.Empty;
            string tvIDSAMSUNG = string.Empty;
            string tvIDLG = string.Empty;
            string tvIPAddressSelected = string.Empty;
            string tvEthernetPortSelected = string.Empty;

            string SQLRequest = "SELECT * FROM client";

            DataTable dt = GetData(SQLRequest);

            if(dt.Rows.Count != 0)
            {
                tvModelSelected = dt.Rows[0]["tvModel"].ToString();
                tvSeriesSelected = dt.Rows[0]["tvSeries"].ToString();
                tvCommTypeSelected = dt.Rows[0]["commType"].ToString();
                tvIDSelected = dt.Rows[0]["tvID"].ToString();

                tvIPAddressSelected = dt.Rows[0]["tvIPAddress"].ToString();
                tvEthernetPortSelected = dt.Rows[0]["tvEthernetPort"].ToString();

                txtTVModel.Text = tvModelSelected;
                txtTVSeries.Text = tvSeriesSelected;
                txtTVID.Text = tvIDSelected;
                txtCommunicationType.Text = tvCommTypeSelected;

                if (tvCommTypeSelected == "RJ45 MDC")
                {
                    txtCom.Text = "";
                    txtBaudRate.Text = "";
                    txtParity.Text = "";
                    txtDatabits.Text = "";
                    txtStopbits.Text = "";

                    if (!ValidateIPv4(tvIPAddressSelected))
                    {
                        MessageBox.Show("Invalid IP Address !");
                    }
                    if (!IsPortValid(tvEthernetPortSelected))
                    {
                        MessageBox.Show("Invalid Port number !");
                    }

                    if (ValidateIPv4(tvIPAddressSelected) && IsPortValid(tvEthernetPortSelected))
                    {
                        _rs232Class = null;
                        _rj45Class = new RJ45Class(tvIPAddressSelected, int.Parse(tvEthernetPortSelected));
                    }
                }
                else
                {
                    string portComSelected = "COM1";
                    string baudRateSelected = "9600";
                    string paritySelected = "None";
                    string databitsSelected = "8";
                    string stopbitsSelected = "One";

                    txtCom.Text = portComSelected;
                    txtBaudRate.Text = baudRateSelected;
                    txtParity.Text = paritySelected;
                    txtDatabits.Text = databitsSelected;
                    txtStopbits.Text = stopbitsSelected;

                    _rs232Class = new RS232Class(portComSelected, baudRateSelected, paritySelected, databitsSelected, stopbitsSelected);
                    _rj45Class = null;
                }

                switch (tvModelSelected)
                {
                    case "SAMSUNG":
                        _tvControl = new SAMSUNGTVControl(tvCommTypeSelected, _rs232Class, _rj45Class, _jsonFile, tvIDSAMSUNG);
                        break;
                    case "LG":
                        _tvControl = new LGTVControl(tvCommTypeSelected, _rs232Class, _rj45Class, _jsonFile, tvIDLG);
                        break;
                }

                _continue = true;
                btnRunApp.Enabled = true;
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            txtIPAddr.Enabled = true;
            txtPort.Enabled = true;
            progConnect.Value = 0;

            _tvControl.Off();
            _continue = false;
            Thread.Sleep(10000);
            btnRunApp.Enabled = false;
        }

        private byte[] GetCommandBytes(string data)
        {
            return data.Split('-').Select(s => Convert.ToByte(s, 16)).ToArray();
        }

        public bool IsValidTVID(string id)
        {
            int n;
            return int.TryParse("123", out n);
        }

        public bool IsPortValid(string port)
        {
            int n;
            if (int.TryParse(port, out n))
            {
                if (n >= 0 && n <= 65535)
                {
                    return true;
                }
            }
            return false;
        }

        public bool ValidateIPv4(string ipString)
        {
            if (String.IsNullOrWhiteSpace(ipString))
            {
                return false;
            }

            string[] splitValues = ipString.Split('.');
            if (splitValues.Length != 4)
            {
                return false;
            }

            byte tempForParsing;

            return splitValues.All(r => byte.TryParse(r, out tempForParsing));
        }

        private static DataTable GetData(string SQLRequest)
        {
            DBAccess db = new DBAccess();
            MySqlCommand cmdRequest2 = new MySqlCommand(SQLRequest, db.OpenedConenction);
            MySqlDataAdapter da2 = new MySqlDataAdapter(cmdRequest2);
            DataSet dts2 = new DataSet();
            da2.Fill(dts2);
            db.Dispose();
            return dts2.Tables[0];
        }

        private void btnRunApp_Click(object sender, EventArgs e)
        {
            string SQLRequest = string.Empty;
            string commandTV = string.Empty;
            string code = string.Empty;
            int volValue = 0;

            while (_continue)
            {
                SQLRequest = "SELECT * FROM execute_cmd";
                DataTable dt = GetData(SQLRequest);

                commandTV = dt.Rows[0]["cmd_type"].ToString();
                code = dt.Rows[0]["protocol"].ToString();
                if(dt.Rows.Count != 0)
                {
                    string result = string.Empty;
                    switch (commandTV)
                    {
                        case "PowerState":
                            result = _tvControl.GetPowerState(code);
                            break;
                        case "VolState":
                            result = _tvControl.GetVolMuteState(code);
                            break;
                        case "PowerOn":
                            result = _tvControl.SetPowerOn(code);
                            break;
                        case "PowerOff":
                            result = _tvControl.SetPowerOff(code);
                            break;
                        case "VolSet":
                            result = _tvControl.SetVolValue(0, code);
                            break;
                    }
                }

                Thread.Sleep(10000);
            }
        }
    }
}
