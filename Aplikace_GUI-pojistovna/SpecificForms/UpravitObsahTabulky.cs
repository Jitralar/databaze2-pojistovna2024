using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikace_GUI_pojistovna.SpecificForms
{
    public partial class UpravitObsahTabulky : UserControl
    {
        DatabaseConnection dbConnection = new DatabaseConnection();

        public UpravitObsahTabulky()
        {
            InitializeComponent();
            LoadComboBox();
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter; // Povolit editaci přímo v DataGridView


        }

        private void LoadComboBox()
        {
            string[] tableNames = {
                "Kategorie_Majetek",
                "KONTAKT",
                "Majetkove_Pojisteni",
                "Permise",
                "Pohledavka",
                "Pojistka",
                "Povinnosti",
                "Pozice",
                "Pripojisteni",
                "Secret",
                "Urazove_Pojisteni",
                "Zamestnanec_Pobocka",
                "Zamestnanec_Pojistka",
                "Zavazek"
            };
            comboBox1.Items.AddRange(tableNames);
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTable = comboBox1.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedTable))
            {
                LoadDataToDataGridView(selectedTable);
            }
        }

        private void LoadDataToDataGridView(string tableName)
        {
            try
            {
                DatabaseConnection dbConnection = new DatabaseConnection();
                DataTable data = dbConnection.GetDataFromView(tableName);

                if (data != null)
                {
                    dataGridView1.DataSource = data;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Chyba při načítání dat z tabulky {tableName}: {ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string selectedTable = comboBox1.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedTable))
            {
                int rowIndex = e.RowIndex;
                int columnIndex = e.ColumnIndex;

                string columnName = dataGridView1.Columns[columnIndex].HeaderText;
                object newValue = dataGridView1.Rows[rowIndex].Cells[columnIndex].Value;
                object idValue = dataGridView1.Rows[rowIndex].Cells["ID"].Value;

                if (idValue != null)
                {
                    UpdateDatabase(selectedTable, columnName, newValue, idValue);
                }
                else
                {
                    MessageBox.Show("Chyba: Nelze aktualizovat řádek bez primárního klíče (ID).", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        private void UpdateDatabase(string tableName, string columnName, object newValue, object idValue)
        {
            try
            {
                string query = $"UPDATE {tableName} SET {columnName} = :newValue WHERE ID = :idValue";

                using (var connection = dbConnection.GetConnection())
                {
                    connection.Open();
                    using (var command = new Oracle.ManagedDataAccess.Client.OracleCommand(query, connection))
                    {
                        command.Parameters.Add(new Oracle.ManagedDataAccess.Client.OracleParameter(":newValue", newValue));
                        command.Parameters.Add(new Oracle.ManagedDataAccess.Client.OracleParameter(":idValue", idValue));
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Změna byla úspěšně uložena do databáze.", "Úspěch", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Chyba při aktualizaci databáze: {ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void newButtonCommit_Click(object sender, EventArgs e)
        {
            string selectedTable = comboBox1.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedTable))
            {
                SaveChangesToDatabase(selectedTable);
            }
            else
            {
                MessageBox.Show("Vyberte tabulku před uložením změn.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SaveChangesToDatabase(string tableName)
        {
            try
            {
                DataTable changes = ((DataTable)dataGridView1.DataSource)?.GetChanges();
                if (changes == null || changes.Rows.Count == 0)
                {
                    MessageBox.Show("Žádné změny k uložení.", "Informace", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                using (var connection = dbConnection.GetConnection())
                {
                    connection.Open();
                    foreach (DataRow row in changes.Rows)
                    {
                        var idValue = row["ID"];
                        if (idValue == null)
                        {
                            MessageBox.Show("Chyba: Řádek bez primárního klíče (ID) nelze uložit.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            continue;
                        }

                        foreach (DataColumn column in changes.Columns)
                        {
                            if (row[column, DataRowVersion.Original] != row[column, DataRowVersion.Current])
                            {
                                string query = $"UPDATE {tableName} SET {column.ColumnName} = :newValue WHERE ID = :idValue";

                                using (var command = new Oracle.ManagedDataAccess.Client.OracleCommand(query, connection))
                                {
                                    command.Parameters.Add(new Oracle.ManagedDataAccess.Client.OracleParameter(":newValue", row[column]));
                                    command.Parameters.Add(new Oracle.ManagedDataAccess.Client.OracleParameter(":idValue", idValue));
                                    command.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                }

                MessageBox.Show("Změny byly úspěšně uloženy do databáze.", "Úspěch", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ((DataTable)dataGridView1.DataSource).AcceptChanges(); // Potvrďte změny v DataTable
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Chyba při ukládání změn do databáze: {ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void newButton11_Click(object sender, EventArgs e)
        {
            string pohled = "log_via_view";
            LoadDataToDataGridView(pohled);
        }

        private void newButton3_Click(object sender, EventArgs e)
        {
            string pohled = "hierarchie";
            LoadDataToDataGridView(pohled);
        }

        private void newButton2_Click(object sender, EventArgs e)
        {
            string pohled = "SYSTEM_CATALOG";
            LoadDataToDataGridView(pohled);
        }
    }
}
