using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVControl
{
    public interface ICableCommunication
    {
        void OpenConnection();

        void CloseConnection();

        byte[] ExecuteCommandRJ45(byte[] bytes);

        string ExecuteCommandRS232(byte[] bytes);
    }
}
