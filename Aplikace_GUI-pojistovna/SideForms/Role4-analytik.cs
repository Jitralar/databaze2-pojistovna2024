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
    public partial class Role4_analytik : UserControl
    {
        public Role4_analytik()
        {
            InitializeComponent();
        }

        private void r4profil_Click(object sender, EventArgs e)
        {
            var mainForm = this.FindForm() as Form1;
            if (mainForm != null)
            {
                // Zavolej metodu pro zobrazení UserProfil
                mainForm.ShowUserProfile();
            }
        }

        private void r4statsklienti_Click(object sender, EventArgs e)
        {
            var mainForm = this.FindForm() as Form1;
            if (mainForm != null)
            {
                // Zavolej metodu pro zobrazení StatistikyKlientu
                mainForm.ShowStatistikyKlientu();
            }
        }

        private void r4statszamestnanci_Click(object sender, EventArgs e)
        {
            var mainForm = this.FindForm() as Form1;
            if (mainForm != null)
            {
                // Zavolej metodu pro zobrazení StatistikyZamestnancu
                mainForm.ShowStatistikyZamestnancu();
            }
        }

        private void r4statspojistky_Click(object sender, EventArgs e)
        {
            var mainForm = this.FindForm() as Form1;
            if (mainForm != null)
            {
                // Zavolej metodu pro zobrazení StatistikyPojistek
                mainForm.ShowStatistikyPojistek();
            }
        }

        private void r4statistikypobocek_Click(object sender, EventArgs e)
        {
            var mainForm = this.FindForm() as Form1;
            if (mainForm != null)
            {
                // Zavolej metodu pro zobrazení StatistikyPobocek
                mainForm.ShowStatistikyPobocek();
            }
        }

        private void r4logout_Click(object sender, EventArgs e)
        {
            var mainForm = this.FindForm() as Form1;
            if (mainForm != null)
            {
                // Přepnutí na přihlašovací obrazovku
                mainForm.ShowMainScreenRoleBased(0); // Hlavní panel na přihlašovací obrazovku
                mainForm.ShowSideScreenRoleBased(0); // Vedlejší panel na přihlašovací obrazovku

                var loginControl = mainForm.Controls.OfType<Login>().FirstOrDefault();
                if (loginControl != null)
                {
                    loginControl.ClearLoginFields();
                }
            }
        }
    }
}
