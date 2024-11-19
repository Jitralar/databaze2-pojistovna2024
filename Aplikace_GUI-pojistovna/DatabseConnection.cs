using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace Aplikace_GUI_pojistovna
{
    public class DatabaseConnection
    {

        private static OracleConnection instance;
        private static readonly object lockObject = new object();

        public OracleConnection GetConnection()
        {
            if (instance == null)
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        //FIXME, pomocí github secrets
                        string user = "st67053";
                        string password = "abcde";
                        string databasehost = "fei-sql3.upceucebny.cz";
                        string port = "1521";
                        string sid = "BDAS";

                        string oradb = "User Id=" + user + ";Password=" + password +";Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST="+ databasehost + ")(PORT=" + port + "))(CONNECT_DATA=(SID=" + sid + ")(SERVER=DEDICATED)))";
                        instance = new OracleConnection(oradb);
                    }
                }
            }
            return instance;
        }
    }
}


