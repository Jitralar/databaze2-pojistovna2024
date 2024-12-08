namespace Aplikace_GUI_pojistovna.SpecificForms
{
    partial class StatistikyPobocek
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
            tableLayoutPanel1.SuspendLayout();
            panelStats_klientiRokSjednani.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_stats_pocet_klientu_rok_sjednani).BeginInit();
            panelStats_klientiPodlePojisteni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_stats_pocet_klientu_typ_pojistky).BeginInit();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
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
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(200, 100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panelStats_klientiRokSjednani
            // 
            panelStats_klientiRokSjednani.Controls.Add(dataGridView_stats_pocet_klientu_rok_sjednani);
            panelStats_klientiRokSjednani.Dock = DockStyle.Fill;
            panelStats_klientiRokSjednani.Location = new Point(135, 23);
            panelStats_klientiRokSjednani.Name = "panelStats_klientiRokSjednani";
            panelStats_klientiRokSjednani.Size = new Size(62, 74);
            panelStats_klientiRokSjednani.TabIndex = 5;
            // 
            // dataGridView_stats_pocet_klientu_rok_sjednani
            // 
            dataGridView_stats_pocet_klientu_rok_sjednani.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_stats_pocet_klientu_rok_sjednani.Dock = DockStyle.Fill;
            dataGridView_stats_pocet_klientu_rok_sjednani.Location = new Point(0, 0);
            dataGridView_stats_pocet_klientu_rok_sjednani.Name = "dataGridView_stats_pocet_klientu_rok_sjednani";
            dataGridView_stats_pocet_klientu_rok_sjednani.RowHeadersWidth = 51;
            dataGridView_stats_pocet_klientu_rok_sjednani.Size = new Size(62, 74);
            dataGridView_stats_pocet_klientu_rok_sjednani.TabIndex = 1;
            // 
            // panelStats_klientiPodlePojisteni
            // 
            panelStats_klientiPodlePojisteni.Controls.Add(dataGridView_stats_pocet_klientu_typ_pojistky);
            panelStats_klientiPodlePojisteni.Dock = DockStyle.Fill;
            panelStats_klientiPodlePojisteni.Location = new Point(69, 23);
            panelStats_klientiPodlePojisteni.Name = "panelStats_klientiPodlePojisteni";
            panelStats_klientiPodlePojisteni.Size = new Size(60, 74);
            panelStats_klientiPodlePojisteni.TabIndex = 4;
            // 
            // dataGridView_stats_pocet_klientu_typ_pojistky
            // 
            dataGridView_stats_pocet_klientu_typ_pojistky.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_stats_pocet_klientu_typ_pojistky.Dock = DockStyle.Fill;
            dataGridView_stats_pocet_klientu_typ_pojistky.Location = new Point(0, 0);
            dataGridView_stats_pocet_klientu_typ_pojistky.Name = "dataGridView_stats_pocet_klientu_typ_pojistky";
            dataGridView_stats_pocet_klientu_typ_pojistky.RowHeadersWidth = 51;
            dataGridView_stats_pocet_klientu_typ_pojistky.Size = new Size(60, 74);
            dataGridView_stats_pocet_klientu_typ_pojistky.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.BackColor = SystemColors.ControlLight;
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(label3, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(135, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(62, 14);
            tableLayoutPanel5.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(56, 14);
            label3.TabIndex = 1;
            label3.Text = "Počet klientů podle roku sjednání smlouvy";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.BackColor = SystemColors.ControlLight;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(label2, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(69, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(60, 14);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(54, 14);
            label2.TabIndex = 1;
            label2.Text = "Počet klientů podle typu pojištění";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = SystemColors.ControlLight;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.Size = new Size(200, 100);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(194, 100);
            label1.TabIndex = 0;
            label1.Text = "Rozdělení klientů podle kraje";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // StatistikyPobocek
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Name = "StatistikyPobocek";
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
    }
}
