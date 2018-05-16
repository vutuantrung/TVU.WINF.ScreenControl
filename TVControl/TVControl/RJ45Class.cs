using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVControl
{
    public class RJ45Class
    {
        string _ipAddress = string.Empty;
        int _port = 0;

        public RJ45Class(string ipAddress, int port)
        {
            _ipAddress = ipAddress;
            _port = port;
        }

        public byte[] ExecuteCommand(byte[] value)
        {
            byte[] dataReturn = null;
            try
            {
                TcpClient client = new TcpClient(_ipAddress, _port);
                NetworkStream stream = client.GetStream();
                
                stream.Write(value, 0, value.Length);

                dataReturn = new Byte[20];
                stream.Read(dataReturn, 0, dataReturn.Length);
                
                stream.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return dataReturn;
        }
    }
}
