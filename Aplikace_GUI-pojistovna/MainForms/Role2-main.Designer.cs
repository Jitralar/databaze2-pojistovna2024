namespace Aplikace_GUI_pojistovna.MainForms
{
    partial class Role2_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Role2_main));
            tableLayoutPanel1 = new TableLayoutPanel();
            urText = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            r2AktualitaTEXT = new Label();
            r2AktualitaNADPIS = new Label();
            panel1 = new Panel();
            label1 = new Label();
            newButton3 = new NewButton();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            label2 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
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
            tableLayoutPanel1.TabIndex = 0;
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
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = SystemColors.ControlDark;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(r2AktualitaTEXT, 0, 1);
            tableLayoutPanel2.Controls.Add(r2AktualitaNADPIS, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(588, 55);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel2.Size = new Size(309, 465);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // r2AktualitaTEXT
            // 
            r2AktualitaTEXT.AutoSize = true;
            r2AktualitaTEXT.Location = new Point(3, 46);
            r2AktualitaTEXT.Name = "r2AktualitaTEXT";
            r2AktualitaTEXT.Size = new Size(303, 400);
            r2AktualitaTEXT.TabIndex = 0;
            r2AktualitaTEXT.Text = resources.GetString("r2AktualitaTEXT.Text");
            // 
            // r2AktualitaNADPIS
            // 
            r2AktualitaNADPIS.AutoSize = true;
            r2AktualitaNADPIS.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            r2AktualitaNADPIS.Location = new Point(3, 0);
            r2AktualitaNADPIS.Name = "r2AktualitaNADPIS";
            r2AktualitaNADPIS.Size = new Size(273, 40);
            r2AktualitaNADPIS.TabIndex = 1;
            r2AktualitaNADPIS.Text = "Bezpečnost na internetu: Chraňte své údaje i finance";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(232, 40);
            label1.TabIndex = 0;
            label1.Text = "Aktuálně u vás evidujeme celkem **null** pojistek";
            // 
            // newButton3
            // 
            newButton3.BackColor = Color.LightGreen;
            newButton3.BackgroundColor = Color.LightGreen;
            newButton3.BorderColor = Color.PaleVioletRed;
            newButton3.BorderRadius = 0;
            newButton3.BorderSize = 0;
            newButton3.Dock = DockStyle.Fill;
            newButton3.FlatAppearance.BorderSize = 0;
            newButton3.FlatStyle = FlatStyle.Flat;
            newButton3.ForeColor = Color.Black;
            newButton3.Location = new Point(3, 225);
            newButton3.Margin = new Padding(3, 3, 0, 3);
            newButton3.Name = "newButton3";
            newButton3.Size = new Size(276, 216);
            newButton3.TabIndex = 4;
            newButton3.Text = "Série tutoriálů: Jak používat systém OASIS";
            newButton3.TextColor = Color.Black;
            newButton3.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(newButton3, 0, 1);
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Controls.Add(panel1, 1, 1);
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
            // Role2_main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "Role2_main";
            Size = new Size(900, 523);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label urText;
        private TableLayoutPanel tableLayoutPanel2;
        private Label r2AktualitaTEXT;
        private Label r2AktualitaNADPIS;
        private TableLayoutPanel tableLayoutPanel3;
        private NewButton newButton3;
        private Label label1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label2;
    }
}
