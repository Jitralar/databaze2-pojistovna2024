namespace Aplikace_GUI_pojistovna.SideForms
{
    partial class Role1_registrovanyUser
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
            r2mojePojistky = new NewButton();
            tableLayoutPanel2 = new TableLayoutPanel();
            r2logout = new NewButton();
            r2profil = new NewButton();
            r2label = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(r2mojePojistky, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 7);
            tableLayoutPanel1.Controls.Add(r2label, 0, 6);
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
            tableLayoutPanel1.TabIndex = 0;
            // 
            // r2mojePojistky
            // 
            r2mojePojistky.BackColor = Color.MediumSlateBlue;
            r2mojePojistky.BackgroundColor = Color.MediumSlateBlue;
            r2mojePojistky.BorderColor = Color.PaleVioletRed;
            r2mojePojistky.BorderRadius = 0;
            r2mojePojistky.BorderSize = 0;
            r2mojePojistky.Dock = DockStyle.Fill;
            r2mojePojistky.FlatAppearance.BorderSize = 0;
            r2mojePojistky.FlatStyle = FlatStyle.Flat;
            r2mojePojistky.ForeColor = Color.White;
            r2mojePojistky.Location = new Point(3, 3);
            r2mojePojistky.Name = "r2mojePojistky";
            r2mojePojistky.Size = new Size(206, 50);
            r2mojePojistky.TabIndex = 0;
            r2mojePojistky.Text = "Moje pojistky";
            r2mojePojistky.TextColor = Color.White;
            r2mojePojistky.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(r2logout, 1, 0);
            tableLayoutPanel2.Controls.Add(r2profil, 0, 0);
            tableLayoutPanel2.Location = new Point(3, 395);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(206, 55);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // r2logout
            // 
            r2logout.BackColor = Color.IndianRed;
            r2logout.BackgroundColor = Color.IndianRed;
            r2logout.BorderColor = Color.PaleVioletRed;
            r2logout.BorderRadius = 0;
            r2logout.BorderSize = 0;
            r2logout.FlatAppearance.BorderSize = 0;
            r2logout.FlatStyle = FlatStyle.Flat;
            r2logout.ForeColor = Color.White;
            r2logout.Location = new Point(106, 3);
            r2logout.Name = "r2logout";
            r2logout.Size = new Size(97, 49);
            r2logout.TabIndex = 0;
            r2logout.Text = "logout";
            r2logout.TextColor = Color.White;
            r2logout.UseVisualStyleBackColor = false;
            // 
            // r2profil
            // 
            r2profil.BackColor = Color.LemonChiffon;
            r2profil.BackgroundColor = Color.LemonChiffon;
            r2profil.BorderColor = Color.PaleVioletRed;
            r2profil.BorderRadius = 0;
            r2profil.BorderSize = 0;
            r2profil.FlatAppearance.BorderSize = 0;
            r2profil.FlatStyle = FlatStyle.Flat;
            r2profil.ForeColor = Color.Black;
            r2profil.Location = new Point(3, 3);
            r2profil.Name = "r2profil";
            r2profil.Size = new Size(97, 49);
            r2profil.TabIndex = 1;
            r2profil.Text = "profil";
            r2profil.TextColor = Color.Black;
            r2profil.UseVisualStyleBackColor = false;
            r2profil.Click += r2profil_Click;
            // 
            // r2label
            // 
            r2label.AutoSize = true;
            r2label.Location = new Point(3, 336);
            r2label.Name = "r2label";
            r2label.Padding = new Padding(3);
            r2label.Size = new Size(164, 46);
            r2label.TabIndex = 4;
            r2label.Text = "Přihlášen jako uživatel:\r\n*jmeno*";
            // 
            // Role1_registrovanyUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            Controls.Add(tableLayoutPanel1);
            Name = "Role1_registrovanyUser";
            Size = new Size(212, 453);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private NewButton r2mojePojistky;
        private TableLayoutPanel tableLayoutPanel2;
        private NewButton r2logout;
        private NewButton r2profil;
        private Label r2label;
    }
}
