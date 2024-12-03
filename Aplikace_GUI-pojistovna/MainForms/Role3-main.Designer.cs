namespace Aplikace_GUI_pojistovna.MainForms
{
    partial class Role3_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Role3_main));
            urText = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            r3TUTORIAL = new NewButton();
            label1 = new Label();
            panel1 = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            r3AktualitaTEXT = new Label();
            r3AktualitaNADPIS = new Label();
            label3 = new Label();
            tableLayoutPanel3.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // urText
            // 
            urText.AutoSize = true;
            urText.Dock = DockStyle.Bottom;
            urText.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 238);
            urText.ForeColor = Color.DarkOrange;
            urText.Location = new Point(3, 6);
            urText.Name = "urText";
            urText.Size = new Size(579, 46);
            urText.TabIndex = 1;
            urText.Text = "Vítej zpět v OASIS";
            urText.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(r3TUTORIAL, 0, 1);
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Controls.Add(panel1, 1, 1);
            tableLayoutPanel3.Controls.Add(label3, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 55);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(579, 465);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // r3TUTORIAL
            // 
            r3TUTORIAL.BackColor = Color.LightGreen;
            r3TUTORIAL.BackgroundColor = Color.LightGreen;
            r3TUTORIAL.BorderColor = Color.PaleVioletRed;
            r3TUTORIAL.BorderRadius = 0;
            r3TUTORIAL.BorderSize = 0;
            r3TUTORIAL.Dock = DockStyle.Fill;
            r3TUTORIAL.FlatAppearance.BorderSize = 0;
            r3TUTORIAL.FlatStyle = FlatStyle.Flat;
            r3TUTORIAL.ForeColor = Color.Black;
            r3TUTORIAL.Location = new Point(3, 225);
            r3TUTORIAL.Margin = new Padding(3, 3, 0, 3);
            r3TUTORIAL.Name = "r3TUTORIAL";
            r3TUTORIAL.Size = new Size(276, 216);
            r3TUTORIAL.TabIndex = 4;
            r3TUTORIAL.Text = "Série tutoriálů: Jak používat systém OASIS";
            r3TUTORIAL.TextColor = Color.Black;
            r3TUTORIAL.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(232, 40);
            label1.TabIndex = 0;
            label1.Text = "Aktuálně u vás evidujeme celkem **null** pojistek";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(tableLayoutPanel4);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(279, 225);
            panel1.Margin = new Padding(0, 3, 3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(276, 216);
            panel1.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(label2, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(276, 216);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(267, 180);
            label2.TabIndex = 0;
            label2.Text = resources.GetString("label2.Text");
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.Controls.Add(urText, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel1.Size = new Size(900, 523);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = SystemColors.ControlDark;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(r3AktualitaTEXT, 0, 1);
            tableLayoutPanel2.Controls.Add(r3AktualitaNADPIS, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(588, 55);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel2.Size = new Size(309, 465);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // r3AktualitaTEXT
            // 
            r3AktualitaTEXT.AutoSize = true;
            r3AktualitaTEXT.Location = new Point(3, 46);
            r3AktualitaTEXT.Name = "r3AktualitaTEXT";
            r3AktualitaTEXT.Size = new Size(303, 400);
            r3AktualitaTEXT.TabIndex = 0;
            r3AktualitaTEXT.Text = resources.GetString("r3AktualitaTEXT.Text");
            // 
            // r3AktualitaNADPIS
            // 
            r3AktualitaNADPIS.AutoSize = true;
            r3AktualitaNADPIS.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            r3AktualitaNADPIS.Location = new Point(3, 0);
            r3AktualitaNADPIS.Name = "r3AktualitaNADPIS";
            r3AktualitaNADPIS.Size = new Size(273, 40);
            r3AktualitaNADPIS.TabIndex = 1;
            r3AktualitaNADPIS.Text = "Bezpečnost na internetu: Chraňte své údaje i finance";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(282, 0);
            label3.Name = "label3";
            label3.Size = new Size(232, 40);
            label3.TabIndex = 5;
            label3.Text = "Aktuálně u vás evidujeme celkem **null** klientů";
            // 
            // Role3_main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "Role3_main";
            Size = new Size(900, 523);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            panel1.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label urText;
        private TableLayoutPanel tableLayoutPanel3;
        private NewButton r3TUTORIAL;
        private Label label1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label r3AktualitaTEXT;
        private Label r3AktualitaNADPIS;
        private Label label3;
    }
}
