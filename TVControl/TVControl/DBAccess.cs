using MySql.Data.MySqlClient;
using System;

namespace TVControl
{
    public class DBAccess : IDisposable
    {
        MySqlConnection _current;

        public string ConnectionString
        {
            get
            {
                string server = "192.168.1.239";
                string uid = "root";
                string password = "nAd3sH1k0";
                string port = "3306";
                string conStr = "SERVER=" + server + ";" + "DATABASE=admin;" + "UID=" + uid + ";" + "PASSWORD=" + password + ";" + "PORT=" + port + ";";
                return conStr;
            }
        }
        
        public MySqlConnection OpenedConenction
        {
            get
            {
                if(_current == null)
                {
                    _current = new MySqlConnection(ConnectionString);
                    _current.Open();
                }
                return _current;
            }
        }

        public void Dispose()
        {
            if(_current != null)
            {
                _current.Dispose();
                _current = null;
            }
        }
    }
}
