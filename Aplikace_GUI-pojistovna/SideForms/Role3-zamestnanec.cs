using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikace_GUI_pojistovna.SideForms
{
    public partial class role3_zamestnanec : UserControl
    {
        public role3_zamestnanec()
        {
            InitializeComponent();
        }

        private void r3profil_Click(object sender, EventArgs e)
        {
            var mainForm = this.FindForm() as Form1;
            if (mainForm != null)
            {
                // Zavolej metodu pro zobrazení UserProfil
                mainForm.ShowUserProfile();
            }
        }

        private void r3klienti_Click(object sender, EventArgs e)
        {
            var mainForm = this.FindForm() as Form1;
            if (mainForm != null)
            {
                // Zavolej metodu pro zobrazení VypisKlienty
                mainForm.ShowVypisKlienty();
            }
        }

        private void r3pojistky_Click(object sender, EventArgs e)
        {
            var mainForm = this.FindForm() as Form1;
            if (mainForm != null)
            {
                // Zavolej metodu pro zobrazení VypisPojistky
                mainForm.ShowVypisPojistky();
            }
        }

        private void r3newpojistka_Click(object sender, EventArgs e)
        {
            var mainForm = this.FindForm() as Form1;
            if (mainForm != null)
            {
                // Zavolej metodu pro zobrazení VytoritPojistku
                mainForm.ShowVytvoritPojistku();
            }
        }
    }
}
