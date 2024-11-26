namespace Aplikace_GUI_pojistovna.SideForms
{
    partial class Role5_supervisor
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
            r5label = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            r5logout = new NewButton();
            r5profil = new NewButton();
            r5zamestnanci = new NewButton();
            r5statsklienti = new NewButton();
            r5statszamestnanci = new NewButton();
            r5statspojistek = new NewButton();
            r5statspobocek = new NewButton();
            r5delegate = new NewButton();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // r5label
            // 
            r5label.AutoSize = true;
            r5label.Location = new Point(3, 336);
            r5label.Name = "r5label";
            r5label.Padding = new Padding(3);
            r5label.Size = new Size(164, 46);
            r5label.TabIndex = 4;
            r5label.Text = "Přihlášen jako uživatel:\r\n*jmeno*";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(r5delegate, 0, 5);
            tableLayoutPanel1.Controls.Add(r5statspobocek, 0, 4);
            tableLayoutPanel1.Controls.Add(r5statspojistek, 0, 3);
            tableLayoutPanel1.Controls.Add(r5statszamestnanci, 0, 2);
            tableLayoutPanel1.Controls.Add(r5statsklienti, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 7);
            tableLayoutPanel1.Controls.Add(r5label, 0, 6);
            tableLayoutPanel1.Controls.Add(r5zamestnanci, 0, 0);
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
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(r5logout, 1, 0);
            tableLayoutPanel2.Controls.Add(r5profil, 0, 0);
            tableLayoutPanel2.Location = new Point(3, 395);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(206, 55);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // r5logout
            // 
            r5logout.BackColor = Color.IndianRed;
            r5logout.BackgroundColor = Color.IndianRed;
            r5logout.BorderColor = Color.PaleVioletRed;
            r5logout.BorderRadius = 0;
            r5logout.BorderSize = 0;
            r5logout.FlatAppearance.BorderSize = 0;
            r5logout.FlatStyle = FlatStyle.Flat;
            r5logout.ForeColor = Color.White;
            r5logout.Location = new Point(106, 3);
            r5logout.Name = "r5logout";
            r5logout.Size = new Size(97, 49);
            r5logout.TabIndex = 0;
            r5logout.Text = "logout";
            r5logout.TextColor = Color.White;
            r5logout.UseVisualStyleBackColor = false;
            // 
            // r5profil
            // 
            r5profil.BackColor = Color.LemonChiffon;
            r5profil.BackgroundColor = Color.LemonChiffon;
            r5profil.BorderColor = Color.PaleVioletRed;
            r5profil.BorderRadius = 0;
            r5profil.BorderSize = 0;
            r5profil.FlatAppearance.BorderSize = 0;
            r5profil.FlatStyle = FlatStyle.Flat;
            r5profil.ForeColor = Color.Black;
            r5profil.Location = new Point(3, 3);
            r5profil.Name = "r5profil";
            r5profil.Size = new Size(97, 49);
            r5profil.TabIndex = 1;
            r5profil.Text = "profil";
            r5profil.TextColor = Color.Black;
            r5profil.UseVisualStyleBackColor = false;
            // 
            // r5zamestnanci
            // 
            r5zamestnanci.BackColor = Color.MediumSlateBlue;
            r5zamestnanci.BackgroundColor = Color.MediumSlateBlue;
            r5zamestnanci.BorderColor = Color.PaleVioletRed;
            r5zamestnanci.BorderRadius = 0;
            r5zamestnanci.BorderSize = 0;
            r5zamestnanci.Dock = DockStyle.Fill;
            r5zamestnanci.FlatAppearance.BorderSize = 0;
            r5zamestnanci.FlatStyle = FlatStyle.Flat;
            r5zamestnanci.ForeColor = Color.White;
            r5zamestnanci.Location = new Point(3, 3);
            r5zamestnanci.Name = "r5zamestnanci";
            r5zamestnanci.Size = new Size(206, 50);
            r5zamestnanci.TabIndex = 5;
            r5zamestnanci.Text = "Moji Zaměstnanci";
            r5zamestnanci.TextColor = Color.White;
            r5zamestnanci.UseVisualStyleBackColor = false;
            // 
            // r5statsklienti
            // 
            r5statsklienti.BackColor = Color.MediumSlateBlue;
            r5statsklienti.BackgroundColor = Color.MediumSlateBlue;
            r5statsklienti.BorderColor = Color.PaleVioletRed;
            r5statsklienti.BorderRadius = 0;
            r5statsklienti.BorderSize = 0;
            r5statsklienti.Dock = DockStyle.Fill;
            r5statsklienti.FlatAppearance.BorderSize = 0;
            r5statsklienti.FlatStyle = FlatStyle.Flat;
            r5statsklienti.ForeColor = Color.White;
            r5statsklienti.Location = new Point(3, 59);
            r5statsklienti.Name = "r5statsklienti";
            r5statsklienti.Size = new Size(206, 50);
            r5statsklienti.TabIndex = 6;
            r5statsklienti.Text = "Statistiky Klientů";
            r5statsklienti.TextColor = Color.White;
            r5statsklienti.UseVisualStyleBackColor = false;
            // 
            // r5statszamestnanci
            // 
            r5statszamestnanci.BackColor = Color.MediumSlateBlue;
            r5statszamestnanci.BackgroundColor = Color.MediumSlateBlue;
            r5statszamestnanci.BorderColor = Color.PaleVioletRed;
            r5statszamestnanci.BorderRadius = 0;
            r5statszamestnanci.BorderSize = 0;
            r5statszamestnanci.Dock = DockStyle.Fill;
            r5statszamestnanci.FlatAppearance.BorderSize = 0;
            r5statszamestnanci.FlatStyle = FlatStyle.Flat;
            r5statszamestnanci.ForeColor = Color.White;
            r5statszamestnanci.Location = new Point(3, 115);
            r5statszamestnanci.Name = "r5statszamestnanci";
            r5statszamestnanci.Size = new Size(206, 50);
            r5statszamestnanci.TabIndex = 7;
            r5statszamestnanci.Text = "Statistiky Zaměstnanců";
            r5statszamestnanci.TextColor = Color.White;
            r5statszamestnanci.UseVisualStyleBackColor = false;
            // 
            // r5statspojistek
            // 
            r5statspojistek.BackColor = Color.MediumSlateBlue;
            r5statspojistek.BackgroundColor = Color.MediumSlateBlue;
            r5statspojistek.BorderColor = Color.PaleVioletRed;
            r5statspojistek.BorderRadius = 0;
            r5statspojistek.BorderSize = 0;
            r5statspojistek.Dock = DockStyle.Fill;
            r5statspojistek.FlatAppearance.BorderSize = 0;
            r5statspojistek.FlatStyle = FlatStyle.Flat;
            r5statspojistek.ForeColor = Color.White;
            r5statspojistek.Location = new Point(3, 171);
            r5statspojistek.Name = "r5statspojistek";
            r5statspojistek.Size = new Size(206, 50);
            r5statspojistek.TabIndex = 8;
            r5statspojistek.Text = "Statistiky Pojistek";
            r5statspojistek.TextColor = Color.White;
            r5statspojistek.UseVisualStyleBackColor = false;
            // 
            // r5statspobocek
            // 
            r5statspobocek.BackColor = Color.MediumSlateBlue;
            r5statspobocek.BackgroundColor = Color.MediumSlateBlue;
            r5statspobocek.BorderColor = Color.PaleVioletRed;
            r5statspobocek.BorderRadius = 0;
            r5statspobocek.BorderSize = 0;
            r5statspobocek.Dock = DockStyle.Fill;
            r5statspobocek.FlatAppearance.BorderSize = 0;
            r5statspobocek.FlatStyle = FlatStyle.Flat;
            r5statspobocek.ForeColor = Color.White;
            r5statspobocek.Location = new Point(3, 227);
            r5statspobocek.Name = "r5statspobocek";
            r5statspobocek.Size = new Size(206, 50);
            r5statspobocek.TabIndex = 9;
            r5statspobocek.Text = "Statistiky Poboček";
            r5statspobocek.TextColor = Color.White;
            r5statspobocek.UseVisualStyleBackColor = false;
            // 
            // r5delegate
            // 
            r5delegate.BackColor = Color.MediumAquamarine;
            r5delegate.BackgroundColor = Color.MediumAquamarine;
            r5delegate.BorderColor = Color.PaleVioletRed;
            r5delegate.BorderRadius = 0;
            r5delegate.BorderSize = 0;
            r5delegate.Dock = DockStyle.Fill;
            r5delegate.FlatAppearance.BorderSize = 0;
            r5delegate.FlatStyle = FlatStyle.Flat;
            r5delegate.ForeColor = Color.White;
            r5delegate.Location = new Point(3, 283);
            r5delegate.Name = "r5delegate";
            r5delegate.Size = new Size(206, 50);
            r5delegate.TabIndex = 10;
            r5delegate.Text = "Přidělit Klienta Zaměstnanci";
            r5delegate.TextColor = Color.White;
            r5delegate.UseVisualStyleBackColor = false;
            // 
            // Role5_supervisor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            Controls.Add(tableLayoutPanel1);
            Name = "Role5_supervisor";
            Size = new Size(212, 453);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label r5label;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private NewButton r5logout;
        private NewButton r5profil;
        private NewButton r5zamestnanci;
        private NewButton r5statspojistek;
        private NewButton r5statszamestnanci;
        private NewButton r5statsklienti;
        private NewButton r5statspobocek;
        private NewButton r5delegate;
    }
}
