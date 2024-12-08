using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

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


        

        public int GetUserRole(string email)
        {
            using (var connection = new OracleConnection(connectionString))
            {
                connection.Open();

                string query = @"
            SELECT p.id_permise
            FROM permise p
            JOIN kontakt k ON p.id_permise = k.permise_id_permise
            WHERE k.email = :email";

                using (var command = new OracleCommand(query, connection))
                {
                    command.Parameters.Add(":email", OracleDbType.Varchar2).Value = email;

                    object result = command.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int role))
                    {
                        return role;
                    }
                    else
                    {
                        throw new Exception("Role nebyla nalezena.");
                    }
                }
            }
        }

        public DataTable GetKlientDetails(int klientId)
        {
            using (var connection = new OracleConnection(connectionString))
            {
                connection.Open();
                string query = @"SELECT * FROM klient WHERE id_klient = :klientId";
                using (var command = new OracleCommand(query, connection))
                {
                    command.Parameters.Add(":klientId", OracleDbType.Int32).Value = klientId;
                    using (var adapter = new OracleDataAdapter(command))
                    {
                        var dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }

        public DataTable GetZamestnanecDetails(int zamestnanecId)
        {
            using (var connection = new OracleConnection(connectionString))
            {
                connection.Open();
                string query = @"SELECT * FROM zamestnanec WHERE id_zam = :zamestnanecId";
                using (var command = new OracleCommand(query, connection))
                {
                    command.Parameters.Add(":zamestnanecId", OracleDbType.Int32).Value = zamestnanecId;
                    using (var adapter = new OracleDataAdapter(command))
                    {
                        var dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }

        public int GetUserPermission(string email)
        {
            using (var connection = new OracleConnection(connectionString))
            {
                connection.Open();
                string query = @"
            SELECT p.id_permise
            FROM permise p
            JOIN kontakt k ON p.id_permise = k.permise_id_permise
            WHERE k.email = :email";

                using (var command = new OracleCommand(query, connection))
                {
                    command.Parameters.Add(":email", OracleDbType.Varchar2).Value = email;

                    object result = command.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int role))
                    {
                        return role;
                    }
                    else
                    {
                        throw new Exception("Permission not found for the provided email.");
                    }
                }
            }
        }

        public DataTable GetUserProfile(string email, int role)
        {
            using (var connection = new OracleConnection(connectionString))
            {
                connection.Open();
                string query = role == 2 // Role klienta
                    ? @"SELECT 
                k.JMENO,
                k.DRUHE_JMENO,
                k.PRIJMENI,
                k.DATUM_NAROZENI,
                k.PRIJEM,
                a.ULICE,
                a.MESTO,
                a.PSC,
                kr.NAZEV_KRAJE AS KRAJ,
                ko.TELEFON,
                ko.MOBIL,
                ko.EMAIL,
                s.PASSWORD,
                s.TOKEN
            FROM KLIENT k
            JOIN ADRESA a ON k.ADRESA_ID_ADRESA = a.ID_ADRESA
            JOIN KONTAKT ko ON k.KONTAKT_ID_KONTAKT = ko.ID_KONTAKT
            LEFT JOIN KRAJ kr ON a.KRAJ_ID_KRAJ = kr.ID_KRAJ
            LEFT JOIN SECRET s ON ko.ID_KONTAKT = s.KONTAKT_ID_KONTAKT
            WHERE ko.EMAIL = :email"
                    : @"SELECT 
                z.JMENO,
                z.DRUHE_JMENO,
                z.PRIJMENI,
                a.ULICE,
                a.MESTO,
                a.PSC,
                kr.NAZEV_KRAJE AS KRAJ,
                ko.TELEFON,
                ko.MOBIL,
                ko.EMAIL,
                s.PASSWORD,
                s.TOKEN
            FROM ZAMESTNANEC z
            JOIN ADRESA a ON z.ADRESA_ID_ADRESA = a.ID_ADRESA
            JOIN KONTAKT ko ON z.KONTAKT_ID_KONTAKT = ko.ID_KONTAKT
            LEFT JOIN KRAJ kr ON a.KRAJ_ID_KRAJ = kr.ID_KRAJ
            LEFT JOIN SECRET s ON ko.ID_KONTAKT = s.KONTAKT_ID_KONTAKT
            WHERE ko.EMAIL = :email";


                using (var command = new OracleCommand(query, connection))
                {
                    command.Parameters.Add(":email", OracleDbType.Varchar2).Value = email;

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


