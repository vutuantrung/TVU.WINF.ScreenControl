using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVControl
{
    public class SAMSUNGTVControl : AbstractTVControlClass
    {
        JObject _jsonFile;
        RS232Class _comRS232 = null;
        RJ45Class _comRJ45 = null;
        string _tvID = string.Empty;
        string _communicationType = string.Empty;

        public SAMSUNGTVControl(string communicationType, RS232Class rs232, RJ45Class rj45, JObject jsonFile, string tvID)
        {
            _comRS232 = rs232;
            _comRJ45 = rj45;
            _communicationType = communicationType;
            _jsonFile = jsonFile;
            _tvID = tvID;
            if(_tvID.Length == 1)
            {
                _tvID = "0" + _tvID;
            }
        }

        public override void On()
        {
            if(_communicationType == "RS232 MDC")
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

        public override string GetPowerStatus()
        {
            string pct = _jsonFile["Power"]["status"].ToString().Replace("XX", _tvID);
            pct = GetSum(pct);
            byte[] pctBytes = GetCommandBytes(pct);
            bool success = false;

            if (_communicationType == "RS232 MDC")
            {
                string serverResponse = _comRS232.ExecuteCommand(pctBytes);
            }
            else
            {
                byte[] serverResponse = _comRJ45.ExecuteCommand(pctBytes);
                success = serverResponse.Contains((byte)65);
                if (success)
                {
                    if (serverResponse[Array.IndexOf(serverResponse, (byte)17) + 1] == (byte)1)
                    {
                        return "On";
                    }
                    return "Off";
                }
            }
            return "Error";
        }

        public override string SetPowerOn()
        {
            string pct = _jsonFile["Power"]["on"].ToString().Replace("XX", _tvID);
            pct = GetSum(pct);
            byte[] pctBytes = GetCommandBytes(pct);
            bool success = false;

            if (_communicationType == "RS232 MDC")
            {
                string serverResponse = _comRS232.ExecuteCommand(pctBytes);
            }
            else
            {
                byte[] serverResponse = _comRJ45.ExecuteCommand(pctBytes);
                success = serverResponse.Contains((byte)65);
                if (success)
                {
                    return "Success";
                }
            }
            return "Error";
        }

        public override string SetPowerOff()
        {
            string pct = _jsonFile["Power"]["off"].ToString().Replace("XX", _tvID);
            pct = GetSum(pct);
            byte[] pctBytes = GetCommandBytes(pct);
            bool success = false;

            if (_communicationType == "RS232 MDC")
            {
                string serverResponse = _comRS232.ExecuteCommand(pctBytes);
            }
            else
            {
                byte[] serverResponse = _comRJ45.ExecuteCommand(pctBytes);
                success = serverResponse.Contains((byte)65);
                if (success)
                {
                    return "Success";
                }
            }
            return "Error";
        }

        public override string GetVolMuteStatus()
        {
            string pct = _jsonFile["Volume"]["mute"]["status"].ToString().Replace("XX", _tvID);
            pct = GetSum(pct);
            byte[] pctBytes = GetCommandBytes(pct);
            bool success;

            if (_communicationType == "RS232 MDC")
            {
                string serverResponse = _comRS232.ExecuteCommand(pctBytes);
            }
            else
            {
                byte[] serverResponse = _comRJ45.ExecuteCommand(pctBytes);
                success = serverResponse.Contains((byte)65);
                if (success)
                {
                    if (serverResponse[Array.IndexOf(serverResponse, (byte)19)] == (byte)0)
                    {
                        return "On";
                    }
                    return "Off";
                }
            }
            return "Error";
        }

        public override string SetVolMuteOn()
        {
            string pct = _jsonFile["Volume"]["mute"]["on"].ToString().Replace("XX", _tvID);
            pct = GetSum(pct);
            byte[] pctBytes = GetCommandBytes(pct);
            bool success = false;

            if (_communicationType == "RS232 MDC")
            {
                string serverResponse = _comRS232.ExecuteCommand(pctBytes);
            }
            else
            {
                byte[] serverResponse = _comRJ45.ExecuteCommand(pctBytes);
                success = serverResponse.Contains((byte)65);
                if (success)
                {
                    return "Success";
                }
            }
            return "Error";
        }

        public override string SetVolMuteOff()
        {
            string pct = _jsonFile["Volume"]["mute"]["off"].ToString().Replace("XX", _tvID);
            pct = GetSum(pct);
            byte[] pctBytes = GetCommandBytes(pct);
            bool success = false;

            if (_communicationType == "RS232 MDC")
            {
                string serverResponse = _comRS232.ExecuteCommand(pctBytes);
            }
            else
            {
                byte[] serverResponse = _comRJ45.ExecuteCommand(pctBytes);
                success = serverResponse.Contains((byte)65);
                if (success)
                {
                    return "Success";
                }
            }
            return "Error";
        }

        public override string GetVolValue()
        {
            string pct = _jsonFile["Volume"]["control"]["status"].ToString().Replace("XX", _tvID);
            pct = GetSum(pct);
            byte[] pctBytes = GetCommandBytes(pct);
            bool success = false;

            if (_communicationType == "RS232 MDC")
            {
                string serverResponse = _comRS232.ExecuteCommand(pctBytes);
            }
            else
            {
                byte[] serverResponse = _comRJ45.ExecuteCommand(pctBytes);
                success = serverResponse.Contains((byte)65);
                if (success)
                {
                    return serverResponse[Array.IndexOf(serverResponse, (byte)18) + 1].ToString();
                }
            }
            return "Error";
        }

        public override string SetVolValue(int volValue)
        {
            bool success = false;
            string volume = volValue.ToString();
            string pct = _jsonFile["Volume"]["control"]["setvalue"].ToString().Replace("XX", _tvID);
            
            if(volValue < 10)
            {
                volume = "0" + volume;
            }
            byte[] pctBytes = GetCommandBytes(pct);
            int length = pctBytes.Length;
            byte[] newPCTBytes = new byte[length + 2];
            int sum = 0;
            for(int i = 1; i <= length - 1; i++)
            {
                sum += pctBytes[i];
            }
            sum += volValue;
            for(int i = 0; i < length; i++)
            {
                newPCTBytes[i] = pctBytes[i];
            }
            newPCTBytes[length] = Convert.ToByte(volValue);
            newPCTBytes[length + 1] = Convert.ToByte(sum);
            /*List<string> test = pct.Split('-').ToList();
            test.RemoveAt(0);

            Int32 Sum = 0;
            foreach (string s in test)
            {
                Sum += Convert.ToByte(s, 16);
            }
            string sum1 = Sum.ToString("X");*/
            /*
            Sum = volValue + int.Parse(sum1);
            string sum2 = Sum.ToString();

            if(sum2.Length == 3)
            {
                sum2.Remove(0, 1);
            }
            int decimalSum = int.Parse(sum2);*/
            /*string sumString = Sum.ToString("X");
            string valueReturn = string.Empty;
            if (sumString.Length > 2)
            {
                valueReturn = sumString[sumString.Length - 2].ToString() + sumString[sumString.Length - 1].ToString();
            }
            else if (sumString.Length == 1)
            {
                valueReturn = "0" + sumString;
            }
            else
            {
                valueReturn = sumString;
            }
            //output: (string)Sum(not containt volValue and their Sum)*/

            /*byte[] pctBytes = GetCommandBytes(pct);
            int length = pctBytes.Length;
            byte[] pctBytesTotal = new byte[GetCommandBytes(pct).Length + 2];
            pctBytesTotal[length] = Convert.ToByte(volValue);
            pctBytesTotal[length + 1] = Convert.ToByte(decimalSum);*/

            if (_communicationType == "RS232 MDC")
            {
                string serverResponse = _comRS232.ExecuteCommand(newPCTBytes);
            }
            else
            {
                byte[] serverResponse = _comRJ45.ExecuteCommand(newPCTBytes);
                success = serverResponse.Contains((byte)65);
                if (success)
                {
                    return serverResponse[Array.IndexOf(serverResponse, (byte)18) + 1].ToString();
                }
            }
            return "Error";
        }

        private byte[] GetCommandBytes(string data)
        {
            return data.Split('-').Select(s => Convert.ToByte(s, 16)).ToArray();
        }

        private string GetSum(string data)
        {
            string d = data;
            List<string> test = data.Split('-').ToList();
            test.RemoveAt(0);
            test.RemoveAt(test.Count - 1);
            Int32 Sum = 0;
            foreach (string s in test)
            {
                Sum += Convert.ToByte(s, 16);
            }
            string sumString = Sum.ToString("X");
            string valueReturn = string.Empty;
            if (sumString.Length > 2)
            {
                valueReturn = sumString[sumString.Length - 2].ToString() + sumString[sumString.Length - 1].ToString();
            }
            else if (sumString.Length == 1)
            {
                valueReturn = "0" + sumString;
            }
            else
            {
                valueReturn = sumString;
            }
            return d.Replace("SS", valueReturn);
        }

    }
}
