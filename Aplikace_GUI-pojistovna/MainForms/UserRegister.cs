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
            
        }


        private void vymazatBunky()
        {

            textBox1_jmeno.Text = "";
            textBoxProstredniJmeno.Text = "";
            textBox7.Text = "";
            textBox4.Text = "";
            textBox13.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox17.Text = "";
            textBox15.Text = "";
            comboBox1.SelectedIndex = -1;
            textBox21.Text = "";
            textBox8.Text = "";

        }

        private void newButton1_Click(object sender, EventArgs e)
        {
            string jmeno = textBox1_jmeno.Text.Trim();
            string druheJmeno = textBoxProstredniJmeno.Text.Trim();
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

            DateTime datumNarozeni = dateTimePicker1.Value; // Získání data narození z DateTimePickeru
            int zakladniPrijem = 1; // Základní příjem nastaven na 1

            if (string.IsNullOrEmpty(jmeno) || string.IsNullOrEmpty(prijmeni) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(heslo) || string.IsNullOrEmpty(nazevKraje))
            {
                MessageBox.Show("Vyplňte prosím všechna povinná pole.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string hashedHeslo = heslo; // Zde můžete použít hashování

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

                        // Získání ID pro adresu
                        OracleCommand getNextIdAdresa = new OracleCommand("SELECT ADR_ID_ADRESA_SEQ.NEXTVAL FROM DUAL", connection);
                        int nextIdAdresa = Convert.ToInt32(getNextIdAdresa.ExecuteScalar());

                        // Vložení do tabulky adresa
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

                        // Získání nového ID klienta ze sekvence
                        OracleCommand getNextIdKlient = new OracleCommand("SELECT KLI_ID_KLIENT_SEQ.NEXTVAL FROM DUAL", connection);
                        int nextIdKlient = Convert.ToInt32(getNextIdKlient.ExecuteScalar());


                        // Vložení do tabulky klient
                        OracleCommand insertKlient = new OracleCommand(
                            @"INSERT INTO KLIENT (ID_KLIENT, JMENO, DRUHE_JMENO, PRIJMENI, DATUM_NAROZENI, PRIJEM, KONTAKT_ID_KONTAKT, ADRESA_ID_ADRESA) 
                            VALUES (:idKlient, :jmeno, :druheJmeno, :prijmeni, :datumNarozeni, :prijem, :idKontakt, :idAdresa)", connection);
                        insertKlient.Parameters.Add("idKlient", nextIdKlient);
                        insertKlient.Parameters.Add("jmeno", jmeno);
                        insertKlient.Parameters.Add("druheJmeno", druheJmeno);
                        insertKlient.Parameters.Add("prijmeni", prijmeni);
                        insertKlient.Parameters.Add("datumNarozeni", datumNarozeni);
                        insertKlient.Parameters.Add("prijem", zakladniPrijem);
                        insertKlient.Parameters.Add("idKontakt", idKontakt.Value);
                        insertKlient.Parameters.Add("idAdresa", nextIdAdresa);
                        insertKlient.ExecuteNonQuery();

                        // Získání nového ID secret ze sekvence
                        OracleCommand getNextIdSecret = new OracleCommand("SELECT SEC_ID_SECRET_SEQ.NEXTVAL FROM DUAL", connection);
                        int nextIdSecret = Convert.ToInt32(getNextIdSecret.ExecuteScalar());

                        // Vložení do tabulky secret s použitím ID ze sekvence
                        OracleCommand insertSecret = new OracleCommand(
                            @"INSERT INTO SECRET (ID_SECRET, PASSWORD, KONTAKT_ID_KONTAKT) 
                            VALUES (:idSecret, :password, :idKontakt)", connection);
                        insertSecret.Parameters.Add("idSecret", nextIdSecret); // ID získané ze sekvence
                        insertSecret.Parameters.Add("password", hashedHeslo); // Heslo (hashed)
                        insertSecret.Parameters.Add("idKontakt", idKontakt.Value); // ID kontaktu z předchozího kroku
                        insertSecret.ExecuteNonQuery();

                        transaction.Commit();
                        MessageBox.Show("Registrace byla úspěšná!", "Úspěch", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        vymazatBunky();
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
