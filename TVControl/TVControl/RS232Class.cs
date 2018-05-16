using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVControl
{
    public class RS232Class
    {
        public string _portCOM;
        public int _baudRate;
        public Parity _parity;
        public int _databits;
        public StopBits _stopbits;
        public System.IO.Ports.SerialPort _serialPortRS232;

        public RS232Class(string portCom, string baudRate, string parity, string databits, string stopbits)
        {
            _portCOM = portCom;
            _baudRate = Convert.ToInt32(baudRate);
            _parity = (Parity)Enum.Parse(typeof(Parity), parity);
            _databits = Convert.ToInt32(databits);
            _stopbits = (StopBits)Enum.Parse(typeof(StopBits), stopbits);

            _serialPortRS232 = new SerialPort(_portCOM, _baudRate, _parity, _databits, _stopbits);
        }

        public void CloseConnection()
        {
            if (_serialPortRS232.IsOpen)
            {
                _serialPortRS232.Close();
            }
        }

        public void OpenConnection()
        {
            try
            {
                _serialPortRS232.Open();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public string ExecuteCommand(byte[] bytes)
        {
            string response = "notresponse";
            _serialPortRS232.Write(bytes, 0, bytes.Length);
            Thread.Sleep(5000);
            response = _serialPortRS232.ReadExisting();
            return response;
        }
    }
}
