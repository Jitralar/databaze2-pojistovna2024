﻿namespace Aplikace_GUI_pojistovna.SpecificForms
{
    partial class UzivatelVypisPojistek
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
            components = new System.ComponentModel.Container();
            databaseConnectionBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)databaseConnectionBindingSource).BeginInit();
            SuspendLayout();
            // 
            // databaseConnectionBindingSource
            // 
            databaseConnectionBindingSource.DataSource = typeof(DatabaseConnection);
            // 
            // UzivatelVypisPojistek
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Name = "UzivatelVypisPojistek";
            Size = new Size(900, 523);
            ((System.ComponentModel.ISupportInitialize)databaseConnectionBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource databaseConnectionBindingSource;
    }
}
