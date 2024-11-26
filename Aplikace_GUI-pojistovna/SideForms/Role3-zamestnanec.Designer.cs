namespace Aplikace_GUI_pojistovna.SideForms
{
    partial class Role3_zamestnanec
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
            this.r3label = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            this.r3logout = new NewButton();
            r3profil = new NewButton();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // r3label
            // 
            this.r3label.AutoSize = true;
            this.r3label.Location = new Point(3, 336);
            this.r3label.Name = "r3label";
            this.r3label.Padding = new Padding(3);
            this.r3label.Size = new Size(164, 46);
            this.r3label.TabIndex = 4;
            this.r3label.Text = "Přihlášen jako uživatel:\r\n*jmeno*";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 7);
            tableLayoutPanel1.Controls.Add(this.r3label, 0, 6);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.499999F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.499999F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.499999F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.499999F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.499999F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.499999F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.499999F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.499999F));
            tableLayoutPanel1.Size = new Size(212, 453);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(this.r3logout, 1, 0);
            tableLayoutPanel2.Controls.Add(r3profil, 0, 0);
            tableLayoutPanel2.Location = new Point(3, 395);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(206, 55);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // r3logout
            // 
            this.r3logout.BackColor = Color.IndianRed;
            this.r3logout.BackgroundColor = Color.IndianRed;
            this.r3logout.BorderColor = Color.PaleVioletRed;
            this.r3logout.BorderRadius = 0;
            this.r3logout.BorderSize = 0;
            this.r3logout.FlatAppearance.BorderSize = 0;
            this.r3logout.FlatStyle = FlatStyle.Flat;
            this.r3logout.ForeColor = Color.White;
            this.r3logout.Location = new Point(106, 3);
            this.r3logout.Name = "r3logout";
            this.r3logout.Size = new Size(97, 49);
            this.r3logout.TabIndex = 0;
            this.r3logout.Text = "logout";
            this.r3logout.TextColor = Color.White;
            this.r3logout.UseVisualStyleBackColor = false;
            // 
            // r3profil
            // 
            r3profil.BackColor = Color.LemonChiffon;
            r3profil.BackgroundColor = Color.LemonChiffon;
            r3profil.BorderColor = Color.PaleVioletRed;
            r3profil.BorderRadius = 0;
            r3profil.BorderSize = 0;
            r3profil.FlatAppearance.BorderSize = 0;
            r3profil.FlatStyle = FlatStyle.Flat;
            r3profil.ForeColor = Color.Black;
            r3profil.Location = new Point(3, 3);
            r3profil.Name = "r3profil";
            r3profil.Size = new Size(97, 49);
            r3profil.TabIndex = 1;
            r3profil.Text = "profil";
            r3profil.TextColor = Color.Black;
            r3profil.UseVisualStyleBackColor = false;
            // 
            // Role3_zamestnanec
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            Controls.Add(tableLayoutPanel1);
            Name = "Role3_zamestnanec";
            Size = new Size(212, 453);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label r2label;
        private TableLayoutPanel tableLayoutPanel1;
        private NewButton r2mojePojistky;
        private TableLayoutPanel tableLayoutPanel2;
        private NewButton r2logout;
        private NewButton r3profil;
    }
}
