namespace Aplikace_GUI_pojistovna.SpecificForms
{
    partial class UpravitObsahTabulky
    {
        /// <summary> 
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód vygenerovaný pomocí Návrháře komponent

        /// <summary> 
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            dataGridView1 = new DataGridView();
            tableLayoutPanel2 = new TableLayoutPanel();
            newButtonSysCatalog = new NewButton();
            newButtonLogovacitabulka = new NewButton();
            tableLayoutPanel3 = new TableLayoutPanel();
            comboBox1 = new ComboBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.Controls.Add(dataGridView1, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tableLayoutPanel1.Size = new Size(900, 523);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(273, 81);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(624, 439);
            dataGridView1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(newButtonSysCatalog, 3, 0);
            tableLayoutPanel2.Controls.Add(newButtonLogovacitabulka, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(273, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(624, 72);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // newButtonSysCatalog
            // 
            newButtonSysCatalog.BackColor = Color.MediumSlateBlue;
            newButtonSysCatalog.BackgroundColor = Color.MediumSlateBlue;
            newButtonSysCatalog.BorderColor = Color.PaleVioletRed;
            newButtonSysCatalog.BorderRadius = 0;
            newButtonSysCatalog.BorderSize = 0;
            newButtonSysCatalog.Dock = DockStyle.Fill;
            newButtonSysCatalog.FlatAppearance.BorderSize = 0;
            newButtonSysCatalog.FlatStyle = FlatStyle.Flat;
            newButtonSysCatalog.ForeColor = Color.White;
            newButtonSysCatalog.Location = new Point(471, 3);
            newButtonSysCatalog.Name = "newButtonSysCatalog";
            newButtonSysCatalog.Size = new Size(150, 66);
            newButtonSysCatalog.TabIndex = 0;
            newButtonSysCatalog.Text = "Systemovy Katalog";
            newButtonSysCatalog.TextColor = Color.White;
            newButtonSysCatalog.UseVisualStyleBackColor = false;
            // 
            // newButtonLogovacitabulka
            // 
            newButtonLogovacitabulka.BackColor = Color.MediumSlateBlue;
            newButtonLogovacitabulka.BackgroundColor = Color.MediumSlateBlue;
            newButtonLogovacitabulka.BorderColor = Color.PaleVioletRed;
            newButtonLogovacitabulka.BorderRadius = 0;
            newButtonLogovacitabulka.BorderSize = 0;
            newButtonLogovacitabulka.Dock = DockStyle.Fill;
            newButtonLogovacitabulka.FlatAppearance.BorderSize = 0;
            newButtonLogovacitabulka.FlatStyle = FlatStyle.Flat;
            newButtonLogovacitabulka.ForeColor = Color.White;
            newButtonLogovacitabulka.Location = new Point(315, 3);
            newButtonLogovacitabulka.Name = "newButtonLogovacitabulka";
            newButtonLogovacitabulka.Size = new Size(150, 66);
            newButtonLogovacitabulka.TabIndex = 1;
            newButtonLogovacitabulka.Text = "Logovací Tabulka";
            newButtonLogovacitabulka.TextColor = Color.White;
            newButtonLogovacitabulka.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(comboBox1, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 81);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 77F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel3.Size = new Size(264, 439);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.Dock = DockStyle.Fill;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(3, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(258, 28);
            comboBox1.TabIndex = 0;
            comboBox1.Text = "Vyberte tabulku k zobrazeni a uprave";
            // 
            // UpravitObsahTabulky
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "UpravitObsahTabulky";
            Size = new Size(900, 523);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel2;
        private NewButton newButtonSysCatalog;
        private NewButton newButtonLogovacitabulka;
        private TableLayoutPanel tableLayoutPanel3;
        private ComboBox comboBox1;
    }
}
