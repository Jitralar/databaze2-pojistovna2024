using System;
using System.Collections.Generic;
using System.Data;
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

                        string oradb = "User Id=" + user + ";Password=" + password + ";Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=" + databasehost + ")(PORT=" + port + "))(CONNECT_DATA=(SID=" + sid + ")(SERVER=DEDICATED)))";
                        instance = new OracleConnection(oradb);
                    }
                }
            }
            return instance;
        }


        private string connectionString = "User Id=st67053;Password=abcde;Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=fei-sql3.upceucebny.cz)(PORT=1521))(CONNECT_DATA=(SID=BDAS)(SERVER=DEDICATED)))";

        public async Task<bool> TestConnectionAsync()
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    await connection.OpenAsync();
                    Console.WriteLine("Connection is OK");
                    return true;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
        }


    public DataTable GetDataFromView(string viewName)
    {
        using (var connection = new OracleConnection(connectionString))
        {
            connection.Open();
            string query = $"SELECT * FROM {viewName}";

            using (var command = new OracleCommand(query, connection))
            {
                using (var adapter = new OracleDataAdapter(command))
                {
                    var dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                    }
                }
        }
        }

        // Get filtered data from POJISTKA table
        public DataTable GetPojistky(string filterColumn, string filterValue)
        {
            using (var connection = new OracleConnection(connectionString))
            {
                connection.Open();
                string query = $"SELECT * FROM POJISTKA WHERE {filterColumn} LIKE :filterValue";

                using (var command = new OracleCommand(query, connection))
                {
                    command.Parameters.Add(":filterValue", OracleDbType.Varchar2).Value = $"%{filterValue}%";

                    using (var adapter = new OracleDataAdapter(command))
                    {
                        var dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }



    }
}


