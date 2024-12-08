using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikace_GUI_pojistovna.MainForms
{
    public partial class UserRegister : UserControl
    {
        public UserRegister()
        {
            InitializeComponent();
            PopulateComboboxKraje();
        }

        private void PopulateComboboxKraje()
        {
            try
            {
                DatabaseConnection databaseConnection = new DatabaseConnection();
                OracleConnection connection = databaseConnection.GetConnection();

                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                string query = "SELECT nazev_kraje FROM kraj";
                OracleCommand command = new OracleCommand(query, connection);
                OracleDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    comboBox1.Items.Add(reader.GetString(0));
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Chyba při načítání krajů: {ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void newButtonRegister_Click(object sender, EventArgs e)
        {
            string jmeno = textBox1_jmeno.Text.Trim();
            string prostredniJmeno = textBoxProstredniJmeno.Text.Trim();
            string prijmeni = textBox7.Text.Trim();
            string heslo = textBox4.Text.Trim();

            string ulice = textBox13.Text.Trim();
            string cisloPopisne = textBox2.Text.Trim();
            string cisloOrientacni = textBox3.Text.Trim();
            string mesto = textBox17.Text.Trim();
            string psc = textBox15.Text.Trim();
            string nazevKraje = comboBox1.SelectedItem?.ToString();

            string email = textBox21.Text.Trim();
            string telefon = textBox8.Text.Trim();

            if (string.IsNullOrEmpty(jmeno) || string.IsNullOrEmpty(prijmeni) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(heslo) || string.IsNullOrEmpty(nazevKraje))
            {
                MessageBox.Show("Vyplňte prosím všechna povinná pole.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string hashedHeslo = heslo;

            try
            {
                DatabaseConnection databaseConnection = new DatabaseConnection();
                OracleConnection connection = databaseConnection.GetConnection();

                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Načtení ID kraje
                        OracleCommand getKrajId = new OracleCommand(
                            @"SELECT ID_KRAJ FROM KRAJ WHERE NAZEV_KRAJE = :nazevKraje", connection);
                        getKrajId.Parameters.Add("nazevKraje", nazevKraje);
                        int krajId = Convert.ToInt32(getKrajId.ExecuteScalar());

                        // Vložení do tabulky adresa
                        OracleCommand getNextId = new OracleCommand("SELECT ADR_ID_ADRESA_SEQ.NEXTVAL FROM DUAL", connection);
                        int nextIdAdresa = Convert.ToInt32(getNextId.ExecuteScalar());

                        // Použití ID v příkazu INSERT
                        OracleCommand insertAdresa = new OracleCommand(
                            @"INSERT INTO ADRESA (ID_ADRESA, ULICE, CISLO_POPISNE, CISLO_ORIENTACNI, MESTO, PSC, KRAJ_ID_KRAJ) 
                        VALUES (:idAdresa, :ulice, :cisloPopisne, :cisloOrientacni, :mesto, :psc, :krajId)", connection);
                        insertAdresa.Parameters.Add("idAdresa", nextIdAdresa);
                        insertAdresa.Parameters.Add("ulice", ulice);
                        insertAdresa.Parameters.Add("cisloPopisne", cisloPopisne);
                        insertAdresa.Parameters.Add("cisloOrientacni", cisloOrientacni);
                        insertAdresa.Parameters.Add("mesto", mesto);
                        insertAdresa.Parameters.Add("psc", psc);
                        insertAdresa.Parameters.Add("krajId", krajId);
                        insertAdresa.ExecuteNonQuery();


                        // Vložení do tabulky kontakt
                        OracleCommand insertKontakt = new OracleCommand(
                            @"INSERT INTO KONTAKT (EMAIL, TELEFON, PERMISE_ID_PERMISE) 
                      VALUES (:email, :telefon, :permiseId) 
                      RETURNING ID_KONTAKT INTO :idKontakt", connection);
                        insertKontakt.Parameters.Add("email", email);
                        insertKontakt.Parameters.Add("telefon", telefon);
                        insertKontakt.Parameters.Add("permiseId", OracleDbType.Int32).Value = 2;
                        var idKontakt = new OracleParameter("idKontakt", OracleDbType.Int32, ParameterDirection.Output);
                        insertKontakt.Parameters.Add(idKontakt);
                        insertKontakt.ExecuteNonQuery();

                        // Vložení do tabulky klient
                        OracleCommand insertKlient = new OracleCommand(
                            @"INSERT INTO KLIENT (JMENO, PROSTREDNI_JMENO, PRIJMENI, HESLO, KONTAKT_ID_KONTAKT, ADRESA_ID_ADRESA) 
                      VALUES (:jmeno, :prostredniJmeno, :prijmeni, :heslo, :idKontakt, :idAdresa)", connection);
                        insertKlient.Parameters.Add("jmeno", jmeno);
                        insertKlient.Parameters.Add("prostredniJmeno", prostredniJmeno);
                        insertKlient.Parameters.Add("prijmeni", prijmeni);
                        insertKlient.Parameters.Add("heslo", hashedHeslo);
                        insertKlient.Parameters.Add("idKontakt", idKontakt.Value);
                        insertKlient.Parameters.Add("idAdresa", nextIdAdresa);
                        insertKlient.ExecuteNonQuery();

                        transaction.Commit();
                        MessageBox.Show("Registrace byla úspěšná!", "Úspěch", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Chyba při registraci: {ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Chyba při připojení k databázi: {ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}
