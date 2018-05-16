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
            string[] TVTypes = new string[] { "SAMSUNG", "LG" };
            ddbTV.Items.AddRange(TVTypes);
            ddbTV.SelectedIndex = 0;

            string[] CommTypes = new string[] { "RS232 MDC", "RJ45 MDC" };
            ddbCommType.Items.AddRange(CommTypes);
            ddbCommType.SelectedIndex = 0;

            string[] PortCOMRS232 = new string[] { "COM1", "COM2" };
            ddbPorts.Items.AddRange(PortCOMRS232);
            ddbPorts.SelectedIndex = 0;

            string[] BaudRate = new string[] { "1200", "2400", "9600", "14400" };
            ddbBaudRate.Items.AddRange(BaudRate);
            ddbBaudRate.SelectedIndex = 0;

            string[] Parity = new string[] { "Even", "Odd", "None", "Mark", "Space" };
            ddbParity.Items.AddRange(Parity);
            ddbParity.SelectedIndex = 0;

            string[] Databits = new string[] { "4", "5", "6", "7", "8" };
            ddbDataBits.Items.AddRange(Databits);
            ddbDataBits.SelectedIndex = 0;

            string[] Stopbits = new string[] { "None", "One", "OnePointFive", "Two" };
            ddbStopbits.Items.AddRange(Stopbits);
            ddbStopbits.SelectedIndex = 0;

            gBoxRS232.Enabled = true;
            gBoxRJ45.Enabled = false;

            btnDisconnect.Enabled = false;

            gbPower.Enabled = false;
            gbVolume.Enabled = false;

            progConnect.Maximum = 5;
            progConnect.Step = 1;
            progConnect.Value = 0;
        }
        
        private void ddbTV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] models;
            string getValue = (string)ddbTV.SelectedItem;
            ddbModel.Items.Clear();
            switch (getValue)
            {
                case "SAMSUNG":
                    models = new string[] { "400MX-3", "460MX-3", "400FP-3", "460FP-3", "820DX", "570DX", "400DX", "460DX", "320DX", "46TX" };
                    break;
                case "LG":
                    models = new string[] { "M3203C", "M3703C"};
                    break;
                default:
                    models = new string[] { };
                    break;
            }
            ddbModel.Items.AddRange(models);
            ddbModel.SelectedIndex = 0;
        }

        private void btnPowerOn_Click(object sender, EventArgs e)
        {
            string result = _tvControl.SetPowerOn();
            Thread.Sleep(5000);
            if (result == "Success")
            {
                _volumeTV = int.Parse(_tvControl.GetVolValue());
                txtVolInfo.Text = _volumeTV.ToString();
            }

            btnPowerOff.Enabled = true;
            btnPowerOn.Enabled = false;
            gbVolume.Enabled = true;
            SetEnableVolButton(_volumeTV);
        }

        private void btnPowerOff_Click(object sender, EventArgs e)
        {
            string result = _tvControl.SetPowerOff();

            if (result == "Success")
            {
                btnPowerOff.Enabled = false;
                btnPowerOn.Enabled = true;
                gbVolume.Enabled = false;
                txtVolInfo.Text = "0";
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string tvSelected = ddbTV.SelectedItem.ToString();
            string tvModelSelected = ddbModel.SelectedItem.ToString();
            string commTypeSelected = ddbCommType.SelectedItem.ToString();
            string tvIDSelected = txtTVID.Text;
            string tvIDSAMSUNG = string.Empty;
            string tvIDLG = string.Empty;

            string TVModel = ddbTV.SelectedItem.ToString() + "_" + ddbModel.SelectedItem.ToString();
            string path = string.Format(@"Z:\VU TUAN TRUNG\TestConsole\TVControl\TVControl\TVControl\HexCode\{0}.json", TVModel);
            _jsonFile = JObject.Parse(File.ReadAllText(path));
            progConnect.PerformStep();

            if (IsValidTVID(tvIDSelected))
            {
                string tmps = string.Empty;
                foreach (char _eachChar in tvIDSelected)
                {
                    int value = Convert.ToInt32(_eachChar);
                    tmps += "-" + String.Format("{0:X}", value);
                }
                tvIDLG = tmps.Remove(0, 1);
                tvIDSAMSUNG = tvIDSelected;
                progConnect.PerformStep();
            }
            else
            {
                MessageBox.Show("Invalid TV ID");
            }

            if(commTypeSelected == "RJ45 MDC")
            {
                if (!ValidateIPv4(txtIPAddr.Text))
                {
                    MessageBox.Show("Invalid IP Address !");
                }
                if (!IsPortValid(txtPort.Text))
                {
                    MessageBox.Show("Invalid Port number !");
                }

                if (ValidateIPv4(txtIPAddr.Text) && IsPortValid(txtPort.Text))
                {
                    _rs232Class = null;
                    _rj45Class = new RJ45Class(txtIPAddr.Text, int.Parse(txtPort.Text));
                }
            }
            else
            {
                string portComSelected = ddbPorts.SelectedItem.ToString();
                string baudRateSelected = ddbBaudRate.SelectedItem.ToString();
                string paritySelected = ddbParity.SelectedItem.ToString();
                string databitsSelected = ddbDataBits.SelectedItem.ToString();
                string stopbitsSelected = ddbStopbits.SelectedItem.ToString();

                _rs232Class = new RS232Class(portComSelected, baudRateSelected, paritySelected, databitsSelected, stopbitsSelected);
                _rj45Class = null;
            }
            progConnect.PerformStep();

            switch (tvSelected)
            {
                case "SAMSUNG":
                    _tvControl = new SAMSUNGTVControl(commTypeSelected, _rs232Class, _rj45Class, _jsonFile, tvIDSAMSUNG);
                    break;
                case "LG":
                    _tvControl = new LGTVControl(commTypeSelected, _rs232Class, _rj45Class, _jsonFile, tvIDLG);
                    break;
            }
            progConnect.PerformStep();
            //Turn TV control on
            
            _tvControl.On();
            string powerStatus = _tvControl.GetPowerStatus();

            if(!(powerStatus == "Error"))
            {
                if (powerStatus == "On")
                {
                    _volumeTV = int.Parse(_tvControl.GetVolValue());

                    txtVolInfo.Text = _volumeTV.ToString();
                    btnPowerOn.Enabled = false;
                    btnPowerOff.Enabled = true;
                    gbVolume.Enabled = true;

                    SetEnableVolButton(_volumeTV);
                }
                else
                {
                    btnPowerOn.Enabled = true;
                    btnPowerOff.Enabled = false;
                    gbVolume.Enabled = false;
                }

                btnDisconnect.Enabled = true;
                btnConnect.Enabled = false;
                gbPower.Enabled = true;
                txtIPAddr.Enabled = false;
                txtPort.Enabled = false;

                ddbTV.Enabled = false;
                txtTVID.Enabled = false;
                ddbModel.Enabled = false;
                ddbCommType.Enabled = false;
                
                progConnect.PerformStep();
            }
            else
            {
                MessageBox.Show("Connection failed!");
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            gbPower.Enabled = false;
            txtVolInfo.Text = "0";
            gbVolume.Enabled = false;
            txtIPAddr.Enabled = true;
            txtPort.Enabled = true;
            progConnect.Value = 0;

            ddbTV.Enabled = true;
            txtTVID.Enabled = true;
            ddbModel.Enabled = true;
            ddbCommType.Enabled = true;


            _tvControl.Off();
        }

        private void btnVolUp_Click(object sender, EventArgs e)
        {
            _volumeTV++;
            txtVolInfo.Text = _volumeTV.ToString();
            SetEnableVolButton(_volumeTV);
        }

        private void btnVolDown_Click(object sender, EventArgs e)
        {
            _volumeTV--;
            txtVolInfo.Text = _volumeTV.ToString();
            SetEnableVolButton(_volumeTV);
        }

        private void btnSetVolValue_Click(object sender, EventArgs e)
        {
            _tvControl.SetVolValue(_volumeTV);
        }

        private void btnVolMute_Click(object sender, EventArgs e)
        {
        }

        private void btnVolNotMute_Click(object sender, EventArgs e)
        {
        }

        private byte[] GetCommandBytes(string data)
        {
            return data.Split('-').Select(s => Convert.ToByte(s, 16)).ToArray();
        }

        private void SetEnableVolButton(int vol)
        {
            if(vol == 100)
            {
                btnVolUp.Enabled = false;
                btnVolDown.Enabled = true;
            }
            else if(vol == 0)
            {
                btnVolUp.Enabled = true;
                btnVolDown.Enabled = false;
            }
            else
            {
                btnVolUp.Enabled = true;
                btnVolDown.Enabled = true;
            }
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

        private void ddbCommType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string commTypeSelected = ddbCommType.SelectedItem.ToString();
            if (commTypeSelected == "RS232 MDC")
            {
                gBoxRS232.Enabled = true;
                gBoxRJ45.Enabled = false;
            }
            else
            {
                gBoxRS232.Enabled = false;
                gBoxRJ45.Enabled = true;
            }
        }
    }
}
