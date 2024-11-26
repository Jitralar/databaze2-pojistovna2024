namespace Aplikace_GUI_pojistovna.SideForms
{
    partial class Login
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
            textBox3 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            linkLabel1 = new LinkLabel();
            textBox4 = new TextBox();
            newButton1 = new NewButton();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(textBox4, 0, 5);
            tableLayoutPanel1.Controls.Add(textBox3, 0, 3);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(textBox1, 0, 2);
            tableLayoutPanel1.Controls.Add(linkLabel1, 0, 4);
            tableLayoutPanel1.Controls.Add(newButton1, 0, 6);
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
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(212, 453);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.None;
            textBox3.Location = new Point(11, 182);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.PlaceholderText = "Heslo";
            textBox3.Size = new Size(189, 27);
            textBox3.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(3, 56);
            label1.Name = "label1";
            label1.Size = new Size(206, 56);
            label1.TabIndex = 0;
            label1.Text = "Vítejte zpět!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(11, 126);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Uživatelské jméno";
            textBox1.Size = new Size(189, 27);
            textBox1.TabIndex = 1;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Dock = DockStyle.Fill;
            linkLabel1.Location = new Point(3, 224);
            linkLabel1.MaximumSize = new Size(210, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Padding = new Padding(3);
            linkLabel1.Size = new Size(206, 56);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Zažádat o obnovení přístupu";
            linkLabel1.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.None;
            textBox4.Location = new Point(11, 294);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Dvoufaktorová autorizace*";
            textBox4.Size = new Size(189, 27);
            textBox4.TabIndex = 6;
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
            newButton1.Location = new Point(3, 339);
            newButton1.Name = "newButton1";
            newButton1.Size = new Size(206, 50);
            newButton1.TabIndex = 7;
            newButton1.Text = "Log In";
            newButton1.TextColor = Color.White;
            newButton1.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            Controls.Add(tableLayoutPanel1);
            Name = "Login";
            Size = new Size(212, 453);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox3;
        private LinkLabel linkLabel1;
        private TextBox textBox4;
        private NewButton newButton1;
    }
}
