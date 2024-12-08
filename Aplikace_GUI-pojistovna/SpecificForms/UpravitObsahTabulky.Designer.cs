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
            newButton3 = new NewButton();
            newButton2 = new NewButton();
            newButton1 = new NewButton();
            newButton11 = new NewButton();
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
            tableLayoutPanel2.Controls.Add(newButton3, 2, 0);
            tableLayoutPanel2.Controls.Add(newButton2, 1, 0);
            tableLayoutPanel2.Controls.Add(newButton1, 0, 0);
            tableLayoutPanel2.Controls.Add(newButton11, 3, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(273, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(624, 72);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // newButton3
            // 
            newButton3.BackColor = Color.MediumSlateBlue;
            newButton3.BackgroundColor = Color.MediumSlateBlue;
            newButton3.BorderColor = Color.PaleVioletRed;
            newButton3.BorderRadius = 0;
            newButton3.BorderSize = 0;
            newButton3.Dock = DockStyle.Fill;
            newButton3.FlatAppearance.BorderSize = 0;
            newButton3.FlatStyle = FlatStyle.Flat;
            newButton3.ForeColor = Color.White;
            newButton3.Location = new Point(315, 3);
            newButton3.Name = "newButton3";
            newButton3.Size = new Size(150, 66);
            newButton3.TabIndex = 3;
            newButton3.Text = "Hiercharii Zamestnancu";
            newButton3.TextColor = Color.White;
            newButton3.UseVisualStyleBackColor = false;
            newButton3.Click += newButton3_Click;
            // 
            // newButton2
            // 
            newButton2.BackColor = Color.MediumSlateBlue;
            newButton2.BackgroundColor = Color.MediumSlateBlue;
            newButton2.BorderColor = Color.PaleVioletRed;
            newButton2.BorderRadius = 0;
            newButton2.BorderSize = 0;
            newButton2.Dock = DockStyle.Fill;
            newButton2.FlatAppearance.BorderSize = 0;
            newButton2.FlatStyle = FlatStyle.Flat;
            newButton2.ForeColor = Color.White;
            newButton2.Location = new Point(159, 3);
            newButton2.Name = "newButton2";
            newButton2.Size = new Size(150, 66);
            newButton2.TabIndex = 2;
            newButton2.Text = "Systémovový Katalog";
            newButton2.TextColor = Color.White;
            newButton2.UseVisualStyleBackColor = false;
            newButton2.Click += newButton2_Click;
            // 
            // newButton1
            // 
            newButton1.BackColor = Color.MediumSlateBlue;
            newButton1.BackgroundColor = Color.MediumSlateBlue;
            newButton1.BorderColor = Color.PaleVioletRed;
            newButton1.BorderRadius = 0;
            newButton1.BorderSize = 0;
            newButton1.Dock = DockStyle.Fill;
            newButton1.FlatAppearance.BorderSize = 0;
            newButton1.FlatStyle = FlatStyle.Flat;
            newButton1.ForeColor = Color.White;
            newButton1.Location = new Point(3, 3);
            newButton1.Name = "newButton1";
            newButton1.Size = new Size(150, 66);
            newButton1.TabIndex = 1;
            newButton1.Text = "wip";
            newButton1.TextColor = Color.White;
            newButton1.UseVisualStyleBackColor = false;
            // 
            // newButton11
            // 
            newButton11.BackColor = Color.MediumSlateBlue;
            newButton11.BackgroundColor = Color.MediumSlateBlue;
            newButton11.BorderColor = Color.PaleVioletRed;
            newButton11.BorderRadius = 0;
            newButton11.BorderSize = 0;
            newButton11.Dock = DockStyle.Fill;
            newButton11.FlatAppearance.BorderSize = 0;
            newButton11.FlatStyle = FlatStyle.Flat;
            newButton11.ForeColor = Color.White;
            newButton11.Location = new Point(471, 3);
            newButton11.Name = "newButton11";
            newButton11.Size = new Size(150, 66);
            newButton11.TabIndex = 0;
            newButton11.Text = "Zobrazit LOG";
            newButton11.TextColor = Color.White;
            newButton11.UseVisualStyleBackColor = false;
            newButton11.Click += newButton11_Click;
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
        private NewButton newButtonCommit;
        private NewButton newButton3;
        private NewButton newButton2;
        private NewButton newButton1;
        private NewButton newButton11;
    }
}
