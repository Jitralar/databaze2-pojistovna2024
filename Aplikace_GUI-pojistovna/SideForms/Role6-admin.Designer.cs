namespace Aplikace_GUI_pojistovna.SideForms
{
    partial class Role6_admin
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
            r6label = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            r6statspobocek = new NewButton();
            r6statspojistek = new NewButton();
            r6statszamestnancu = new NewButton();
            r6log = new NewButton();
            tableLayoutPanel2 = new TableLayoutPanel();
            r6logout = new NewButton();
            r6profil = new NewButton();
            r6modeifyTabulky = new NewButton();
            r6statsklient = new NewButton();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // r6label
            // 
            r6label.AutoSize = true;
            r6label.Location = new Point(3, 336);
            r6label.Name = "r6label";
            r6label.Padding = new Padding(3);
            r6label.Size = new Size(164, 46);
            r6label.TabIndex = 4;
            r6label.Text = "Přihlášen jako uživatel:\r\n*jmeno*";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(r6statspobocek, 0, 5);
            tableLayoutPanel1.Controls.Add(r6statspojistek, 0, 4);
            tableLayoutPanel1.Controls.Add(r6statszamestnancu, 0, 3);
            tableLayoutPanel1.Controls.Add(r6log, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 7);
            tableLayoutPanel1.Controls.Add(r6label, 0, 6);
            tableLayoutPanel1.Controls.Add(r6modeifyTabulky, 0, 0);
            tableLayoutPanel1.Controls.Add(r6statsklient, 0, 2);
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
            tableLayoutPanel1.TabIndex = 2;
            // 
            // r6statspobocek
            // 
            r6statspobocek.BackColor = Color.MediumSlateBlue;
            r6statspobocek.BackgroundColor = Color.MediumSlateBlue;
            r6statspobocek.BorderColor = Color.PaleVioletRed;
            r6statspobocek.BorderRadius = 0;
            r6statspobocek.BorderSize = 0;
            r6statspobocek.Dock = DockStyle.Fill;
            r6statspobocek.FlatAppearance.BorderSize = 0;
            r6statspobocek.FlatStyle = FlatStyle.Flat;
            r6statspobocek.ForeColor = Color.White;
            r6statspobocek.Location = new Point(3, 283);
            r6statspobocek.Name = "r6statspobocek";
            r6statspobocek.Size = new Size(206, 50);
            r6statspobocek.TabIndex = 10;
            r6statspobocek.Text = "Statistiky Poboček";
            r6statspobocek.TextColor = Color.White;
            r6statspobocek.UseVisualStyleBackColor = false;
            r6statspobocek.Click += r6statspobocek_Click;
            // 
            // r6statspojistek
            // 
            r6statspojistek.BackColor = Color.MediumSlateBlue;
            r6statspojistek.BackgroundColor = Color.MediumSlateBlue;
            r6statspojistek.BorderColor = Color.PaleVioletRed;
            r6statspojistek.BorderRadius = 0;
            r6statspojistek.BorderSize = 0;
            r6statspojistek.Dock = DockStyle.Fill;
            r6statspojistek.FlatAppearance.BorderSize = 0;
            r6statspojistek.FlatStyle = FlatStyle.Flat;
            r6statspojistek.ForeColor = Color.White;
            r6statspojistek.Location = new Point(3, 227);
            r6statspojistek.Name = "r6statspojistek";
            r6statspojistek.Size = new Size(206, 50);
            r6statspojistek.TabIndex = 9;
            r6statspojistek.Text = "Statistiky Pojistek";
            r6statspojistek.TextColor = Color.White;
            r6statspojistek.UseVisualStyleBackColor = false;
            r6statspojistek.Click += r6statspojistek_Click;
            // 
            // r6statszamestnancu
            // 
            r6statszamestnancu.BackColor = Color.MediumSlateBlue;
            r6statszamestnancu.BackgroundColor = Color.MediumSlateBlue;
            r6statszamestnancu.BorderColor = Color.PaleVioletRed;
            r6statszamestnancu.BorderRadius = 0;
            r6statszamestnancu.BorderSize = 0;
            r6statszamestnancu.Dock = DockStyle.Fill;
            r6statszamestnancu.FlatAppearance.BorderSize = 0;
            r6statszamestnancu.FlatStyle = FlatStyle.Flat;
            r6statszamestnancu.ForeColor = Color.White;
            r6statszamestnancu.Location = new Point(3, 171);
            r6statszamestnancu.Name = "r6statszamestnancu";
            r6statszamestnancu.Size = new Size(206, 50);
            r6statszamestnancu.TabIndex = 8;
            r6statszamestnancu.Text = "Statistiky Zaměstnanců";
            r6statszamestnancu.TextColor = Color.White;
            r6statszamestnancu.UseVisualStyleBackColor = false;
            r6statszamestnancu.Click += r6statszamestnancu_Click;
            // 
            // r6log
            // 
            r6log.BackColor = Color.MediumAquamarine;
            r6log.BackgroundColor = Color.MediumAquamarine;
            r6log.BorderColor = Color.PaleVioletRed;
            r6log.BorderRadius = 0;
            r6log.BorderSize = 0;
            r6log.Dock = DockStyle.Fill;
            r6log.FlatAppearance.BorderSize = 0;
            r6log.FlatStyle = FlatStyle.Flat;
            r6log.ForeColor = Color.White;
            r6log.Location = new Point(3, 59);
            r6log.Name = "r6log";
            r6log.Size = new Size(206, 50);
            r6log.TabIndex = 6;
            r6log.Text = "Zobrazit log úprav";
            r6log.TextColor = Color.White;
            r6log.UseVisualStyleBackColor = false;
            r6log.Click += r6log_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(r6logout, 1, 0);
            tableLayoutPanel2.Controls.Add(r6profil, 0, 0);
            tableLayoutPanel2.Location = new Point(3, 395);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(206, 55);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // r6logout
            // 
            r6logout.BackColor = Color.IndianRed;
            r6logout.BackgroundColor = Color.IndianRed;
            r6logout.BorderColor = Color.PaleVioletRed;
            r6logout.BorderRadius = 0;
            r6logout.BorderSize = 0;
            r6logout.FlatAppearance.BorderSize = 0;
            r6logout.FlatStyle = FlatStyle.Flat;
            r6logout.ForeColor = Color.White;
            r6logout.Location = new Point(106, 3);
            r6logout.Name = "r6logout";
            r6logout.Size = new Size(97, 49);
            r6logout.TabIndex = 0;
            r6logout.Text = "logout";
            r6logout.TextColor = Color.White;
            r6logout.UseVisualStyleBackColor = false;
            // 
            // r6profil
            // 
            r6profil.BackColor = Color.LemonChiffon;
            r6profil.BackgroundColor = Color.LemonChiffon;
            r6profil.BorderColor = Color.PaleVioletRed;
            r6profil.BorderRadius = 0;
            r6profil.BorderSize = 0;
            r6profil.FlatAppearance.BorderSize = 0;
            r6profil.FlatStyle = FlatStyle.Flat;
            r6profil.ForeColor = Color.Black;
            r6profil.Location = new Point(3, 3);
            r6profil.Name = "r6profil";
            r6profil.Size = new Size(97, 49);
            r6profil.TabIndex = 1;
            r6profil.Text = "profil";
            r6profil.TextColor = Color.Black;
            r6profil.UseVisualStyleBackColor = false;
            r6profil.Click += r6profil_Click;
            // 
            // r6modeifyTabulky
            // 
            r6modeifyTabulky.BackColor = Color.MediumAquamarine;
            r6modeifyTabulky.BackgroundColor = Color.MediumAquamarine;
            r6modeifyTabulky.BorderColor = Color.PaleVioletRed;
            r6modeifyTabulky.BorderRadius = 0;
            r6modeifyTabulky.BorderSize = 0;
            r6modeifyTabulky.Dock = DockStyle.Fill;
            r6modeifyTabulky.FlatAppearance.BorderSize = 0;
            r6modeifyTabulky.FlatStyle = FlatStyle.Flat;
            r6modeifyTabulky.ForeColor = Color.White;
            r6modeifyTabulky.Location = new Point(3, 3);
            r6modeifyTabulky.Name = "r6modeifyTabulky";
            r6modeifyTabulky.Size = new Size(206, 50);
            r6modeifyTabulky.TabIndex = 5;
            r6modeifyTabulky.Text = "Upravit obsah tabulky";
            r6modeifyTabulky.TextColor = Color.White;
            r6modeifyTabulky.UseVisualStyleBackColor = false;
            r6modeifyTabulky.Click += r6modeifyTabulky_Click;
            // 
            // r6statsklient
            // 
            r6statsklient.BackColor = Color.MediumSlateBlue;
            r6statsklient.BackgroundColor = Color.MediumSlateBlue;
            r6statsklient.BorderColor = Color.PaleVioletRed;
            r6statsklient.BorderRadius = 0;
            r6statsklient.BorderSize = 0;
            r6statsklient.Dock = DockStyle.Fill;
            r6statsklient.FlatAppearance.BorderSize = 0;
            r6statsklient.FlatStyle = FlatStyle.Flat;
            r6statsklient.ForeColor = Color.White;
            r6statsklient.Location = new Point(3, 115);
            r6statsklient.Name = "r6statsklient";
            r6statsklient.Size = new Size(206, 50);
            r6statsklient.TabIndex = 7;
            r6statsklient.Text = "Statistiky Klientů";
            r6statsklient.TextColor = Color.White;
            r6statsklient.UseVisualStyleBackColor = false;
            r6statsklient.Click += r6statsklient_Click;
            // 
            // Role6_admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            Controls.Add(tableLayoutPanel1);
            Name = "Role6_admin";
            Size = new Size(212, 453);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label r6label;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private NewButton r6logout;
        private NewButton r6profil;
        private NewButton r6modeifyTabulky;
        private NewButton r6statspobocek;
        private NewButton r6statspojistek;
        private NewButton r6statszamestnancu;
        private NewButton r6log;
        private NewButton r6statsklient;
    }
}
