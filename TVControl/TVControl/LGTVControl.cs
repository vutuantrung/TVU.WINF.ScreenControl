using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVControl
{
    public class LGTVControl : AbstractTVControlClass
    {
        JObject _jsonFile;
        RS232Class _comRS232 = null;
        RJ45Class _comRJ45 = null;
        string _tvID = string.Empty;
        string _communicationType = string.Empty;

        public LGTVControl(string communicationType, RS232Class rs232, RJ45Class rj45, JObject jsonFile, string tvID)
        {
            _comRS232 = rs232;
            _comRJ45 = rj45;
            _communicationType = communicationType;
            _jsonFile = jsonFile;
            _tvID = tvID;
        }

        public override void On()
        {
            if (_communicationType == "RS232 MDC")
            {
                _comRS232.OpenConnection();
            }
        }

        public override void Off()
        {
            if (_communicationType == "RS232 MDC")
            {
                _comRS232.CloseConnection();
            }
        }

        public override string GetPowerStatus(string pct)
        {
            byte[] pctBytes = GetCommandBytes(pct);
            string response = string.Empty;

            foreach(byte b in pctBytes)
            {
                response += b.ToString();
            }

            if (_communicationType == "RS232 MDC")
            {
                response = _comRS232.ExecuteCommand(pctBytes);
            }
            else
            {
                byte[] serverResponse = _comRJ45.ExecuteCommand(pctBytes);
                response = System.Text.Encoding.ASCII.GetString(serverResponse);
            }

            bool success = response.Contains("OK");
            if (success)
            {
                int k = response.IndexOf('O') + 2;
                if (response.Substring(k, response.IndexOf('x') - k) == "01")
                {
                    return "On";
                }
                return "Off";
            }
            return "Error";
        }

        public override string SetPowerOn(string pct)
        {
            byte[] pctBytes = GetCommandBytes(pct);
            string response = string.Empty;

            if (_communicationType == "RS232 MDC")
            {
                response = _comRS232.ExecuteCommand(pctBytes);
            }
            else
            {
                byte[] serverResponse = _comRJ45.ExecuteCommand(pctBytes);
                response = System.Text.Encoding.ASCII.GetString(serverResponse);
            }

            bool success = response.Contains("OK");
            if (success)
            {
                return "Success";
            }
            return "Error";
        }

        public override string SetPowerOff(string pct)
        {
            byte[] pctBytes = GetCommandBytes(pct);
            string response = string.Empty;
            if (_communicationType == "RS232 MDC")
            {
                response = _comRS232.ExecuteCommand(pctBytes);
            }
            else
            {
                byte[] serverResponse = _comRJ45.ExecuteCommand(pctBytes);
                response = System.Text.Encoding.ASCII.GetString(serverResponse);
            }

            bool success = response.Contains("OK");
            if (success)
            {
                return "Success";
            }
            return "Error";
        }

        public override string GetVolMuteStatus(string pct)
        {
            byte[] pctBytes = GetCommandBytes(pct);
            string response = string.Empty;

            if (_communicationType == "RS232 MDC")
            {
                response = _comRS232.ExecuteCommand(pctBytes);
            }
            else
            {
                byte[] serverResponse = _comRJ45.ExecuteCommand(pctBytes);
                response = System.Text.Encoding.ASCII.GetString(serverResponse);
            }

            bool success = response.Contains("OK");
            if (success)
            {
                int k = response.IndexOf('O') + 2;

                if (response.Substring(k, response.IndexOf('x') - k) == "31")
                {
                    return "On";
                }
                return "Off";
            }
            return "Error";
        }

        public override string SetVolMuteOn(string pct)
        {
            byte[] pctBytes = GetCommandBytes(pct);
            string response = string.Empty;

            if (_communicationType == "RS232 MDC")
            {
                response = _comRS232.ExecuteCommand(pctBytes);
            }
            else
            {
                byte[] serverResponse = _comRJ45.ExecuteCommand(pctBytes);
                response = System.Text.Encoding.ASCII.GetString(serverResponse);
            }

            bool success = response.Contains("OK");
            if (success)
            {
                return "Success";
            }
            return "Error";
        }

        public override string SetVolMuteOff(string pct)
        {
            byte[] pctBytes = GetCommandBytes(pct);
            string response = string.Empty;

            if (_communicationType == "RS232 MDC")
            {
                response = _comRS232.ExecuteCommand(pctBytes);
            }
            else
            {
                byte[] serverResponse = _comRJ45.ExecuteCommand(pctBytes);
                response = System.Text.Encoding.ASCII.GetString(serverResponse);
            }

            bool success = response.Contains("OK");
            if (success)
            {
                return "Success";
            }
            return "Error";
        }

        public override string GetVolValue(string pct)
        {
            byte[] pctBytes = GetCommandBytes(pct);
            string response = string.Empty;

            if (_communicationType == "RS232 MDC")
            {
                response = _comRS232.ExecuteCommand(pctBytes);
            }
            else
            {
                byte[] serverResponse = _comRJ45.ExecuteCommand(pctBytes);
                response = System.Text.Encoding.ASCII.GetString(serverResponse);
            }
            if(response != "notresponse")
            {
                bool success = response.Contains("OK");
                if (success)
                {
                    int k = response.IndexOf('O') + 2;
                    string volHexCode = response.Substring(k, response.IndexOf('x') - k);
                    return ParseHexString(volHexCode);
                }
            }
            return "Error";
        }

        public override string SetVolValue(int volValue, string pct)
        {
            string volHexCode = GetVolumeHexCode(volValue);

            byte[] pctBytes = GetCommandBytes(pct);
            string response = string.Empty;

            if (_communicationType == "RS232 MDC")
            {
                response = _comRS232.ExecuteCommand(pctBytes);
            }
            else
            {
                byte[] serverResponse = _comRJ45.ExecuteCommand(pctBytes);
                response = System.Text.Encoding.ASCII.GetString(serverResponse);
            }

            bool success = response.Contains("OK");
            if (success)
            {
                return "Success";
            }
            return "Error";
        }

        private string GetVolumeHexCode(int volValue)
        {
            string hexValue = volValue.ToString("X");
            if (hexValue.Length == 1)
            {
                hexValue = "0" + hexValue;
            }

            string tmps = string.Empty;
            foreach (char _eachChar in hexValue)
            {
                int value = Convert.ToInt32(_eachChar);
                tmps += "-" + String.Format("{0:X}", value);
            }
            return tmps.Remove(0, 1);
        }

        private byte[] GetCommandBytes(string data)
        {
            return data.Split('-').Select(s => Convert.ToByte(s, 16)).ToArray();
        }

        private string ParseHexString(string hexNumber)
        {
            hexNumber = hexNumber.Replace("x", string.Empty);
            long result = 0;
            long.TryParse(hexNumber, System.Globalization.NumberStyles.HexNumber, null, out result);
            return result.ToString();
        }
    }
}
