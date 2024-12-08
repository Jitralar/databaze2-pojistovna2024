namespace Aplikace_GUI_pojistovna.SpecificForms
{
    partial class StatistikyPojistek
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
            panelStats_klientiRokSjednani = new Panel();
            dataGridView_stats_pocet_klientu_rok_sjednani = new DataGridView();
            panelStats_klientiPodlePojisteni = new Panel();
            dataGridView_stats_pocet_klientu_typ_pojistky = new DataGridView();
            tableLayoutPanel5 = new TableLayoutPanel();
            label3 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            label2 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            panelStats_klientiPodleKraje = new Panel();
            dataGridView_stats_rozdeleni_klientu_kraj = new DataGridView();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            panelStats_klientiRokSjednani.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_stats_pocet_klientu_rok_sjednani).BeginInit();
            panelStats_klientiPodlePojisteni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_stats_pocet_klientu_typ_pojistky).BeginInit();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panelStats_klientiPodleKraje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_stats_rozdeleni_klientu_kraj).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(panelStats_klientiRokSjednani, 2, 1);
            tableLayoutPanel1.Controls.Add(panelStats_klientiPodlePojisteni, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 2, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(panelStats_klientiPodleKraje, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 54.5454559F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.181818F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.181818F));
            tableLayoutPanel1.Size = new Size(900, 523);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panelStats_klientiRokSjednani
            // 
            panelStats_klientiRokSjednani.Controls.Add(dataGridView_stats_pocet_klientu_rok_sjednani);
            panelStats_klientiRokSjednani.Dock = DockStyle.Fill;
            panelStats_klientiRokSjednani.Location = new Point(602, 50);
            panelStats_klientiRokSjednani.Name = "panelStats_klientiRokSjednani";
            panelStats_klientiRokSjednani.Size = new Size(295, 279);
            panelStats_klientiRokSjednani.TabIndex = 5;
            // 
            // dataGridView_stats_pocet_klientu_rok_sjednani
            // 
            dataGridView_stats_pocet_klientu_rok_sjednani.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_stats_pocet_klientu_rok_sjednani.Dock = DockStyle.Fill;
            dataGridView_stats_pocet_klientu_rok_sjednani.Location = new Point(0, 0);
            dataGridView_stats_pocet_klientu_rok_sjednani.Name = "dataGridView_stats_pocet_klientu_rok_sjednani";
            dataGridView_stats_pocet_klientu_rok_sjednani.RowHeadersWidth = 51;
            dataGridView_stats_pocet_klientu_rok_sjednani.Size = new Size(295, 279);
            dataGridView_stats_pocet_klientu_rok_sjednani.TabIndex = 1;
            // 
            // panelStats_klientiPodlePojisteni
            // 
            panelStats_klientiPodlePojisteni.Controls.Add(dataGridView_stats_pocet_klientu_typ_pojistky);
            panelStats_klientiPodlePojisteni.Dock = DockStyle.Fill;
            panelStats_klientiPodlePojisteni.Location = new Point(302, 50);
            panelStats_klientiPodlePojisteni.Name = "panelStats_klientiPodlePojisteni";
            panelStats_klientiPodlePojisteni.Size = new Size(294, 279);
            panelStats_klientiPodlePojisteni.TabIndex = 4;
            // 
            // dataGridView_stats_pocet_klientu_typ_pojistky
            // 
            dataGridView_stats_pocet_klientu_typ_pojistky.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_stats_pocet_klientu_typ_pojistky.Dock = DockStyle.Fill;
            dataGridView_stats_pocet_klientu_typ_pojistky.Location = new Point(0, 0);
            dataGridView_stats_pocet_klientu_typ_pojistky.Name = "dataGridView_stats_pocet_klientu_typ_pojistky";
            dataGridView_stats_pocet_klientu_typ_pojistky.RowHeadersWidth = 51;
            dataGridView_stats_pocet_klientu_typ_pojistky.Size = new Size(294, 279);
            dataGridView_stats_pocet_klientu_typ_pojistky.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.BackColor = SystemColors.ControlLight;
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(label3, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(602, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(295, 41);
            tableLayoutPanel5.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(289, 41);
            label3.TabIndex = 1;
            label3.Text = "Počet pojištění \r\n";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.BackColor = SystemColors.ControlLight;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(label2, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(302, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(294, 41);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(288, 41);
            label2.TabIndex = 1;
            label2.Text = "Pruměrná ceny pojištění";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = SystemColors.ControlLight;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(293, 41);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(287, 41);
            label1.TabIndex = 0;
            label1.Text = "Pojistky s klienty";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panelStats_klientiPodleKraje
            // 
            panelStats_klientiPodleKraje.Controls.Add(dataGridView_stats_rozdeleni_klientu_kraj);
            panelStats_klientiPodleKraje.Dock = DockStyle.Fill;
            panelStats_klientiPodleKraje.Location = new Point(3, 50);
            panelStats_klientiPodleKraje.Name = "panelStats_klientiPodleKraje";
            panelStats_klientiPodleKraje.Size = new Size(293, 279);
            panelStats_klientiPodleKraje.TabIndex = 3;
            // 
            // dataGridView_stats_rozdeleni_klientu_kraj
            // 
            dataGridView_stats_rozdeleni_klientu_kraj.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_stats_rozdeleni_klientu_kraj.Dock = DockStyle.Fill;
            dataGridView_stats_rozdeleni_klientu_kraj.Location = new Point(0, 0);
            dataGridView_stats_rozdeleni_klientu_kraj.Name = "dataGridView_stats_rozdeleni_klientu_kraj";
            dataGridView_stats_rozdeleni_klientu_kraj.RowHeadersWidth = 51;
            dataGridView_stats_rozdeleni_klientu_kraj.Size = new Size(293, 279);
            dataGridView_stats_rozdeleni_klientu_kraj.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = SystemColors.ControlLight;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(900, 523);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // StatistikyPojistek
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel3);
            Name = "StatistikyPojistek";
            Size = new Size(900, 523);
            tableLayoutPanel1.ResumeLayout(false);
            panelStats_klientiRokSjednani.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_stats_pocet_klientu_rok_sjednani).EndInit();
            panelStats_klientiPodlePojisteni.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_stats_pocet_klientu_typ_pojistky).EndInit();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panelStats_klientiPodleKraje.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_stats_rozdeleni_klientu_kraj).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelStats_klientiRokSjednani;
        private DataGridView dataGridView_stats_pocet_klientu_rok_sjednani;
        private Panel panelStats_klientiPodlePojisteni;
        private DataGridView dataGridView_stats_pocet_klientu_typ_pojistky;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Panel panelStats_klientiPodleKraje;
        private DataGridView dataGridView_stats_rozdeleni_klientu_kraj;
        private TableLayoutPanel tableLayoutPanel3;
    }
}
