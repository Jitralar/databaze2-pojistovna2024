using Aplikace_GUI_pojistovna.MainForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Aplikace_GUI_pojistovna.MainForms;
using Aplikace_GUI_pojistovna.SideForms;
using Aplikace_GUI_pojistovna.SpecificForms;

namespace Aplikace_GUI_pojistovna.SideForms
{
    public partial class Role1_registrovanyUser : UserControl
    {

        public Role1_registrovanyUser()
        {
            InitializeComponent();
        }



        private void r2profil_Click(object sender, EventArgs e)
        {
            var mainForm = this.FindForm() as Form1;
            if (mainForm != null)
            {
                // Zavolej metodu pro zobrazení UserProfil
                mainForm.ShowUserProfile();
            }

        }

        private void r2mojePojistky_Click(object sender, EventArgs e)
        {
            var mainForm = this.FindForm() as Form1;
            if (mainForm != null)
            {
                // Zavolej metodu pro zobrazení VypisPojistky
                mainForm.ShowUzivatelVypisPojistky();
            }

        }

        private void r2logout_Click(object sender, EventArgs e)
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
