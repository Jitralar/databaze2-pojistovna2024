using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace Aplikace_GUI_pojistovna.SideForms
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        private void newButton2_Click(object sender, EventArgs e)
        {
            //login to dba
            //připojí se přes database connection na server fei-sql3.upceucebny.cz
            //pokud se nepodaří připojit, vypíše chybu
            //pokud se podaří připojit, zavře se login form a otevře se form podle role (z main form)

            //připojení k databázi za využití DatabaseConection.cs
            //DatabaseConnection databaseConnection = new DatabaseConnection();
            //OracleConnection connection = databaseConnection.GetConnection();
            //connection.Open();






        }
    }
}
