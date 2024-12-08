using Aplikace_GUI_pojistovna.MainForms;
using Aplikace_GUI_pojistovna.SideForms;
using Aplikace_GUI_pojistovna.SpecificForms;
using static Aplikace_GUI_pojistovna.User;

using System.Data;

namespace Aplikace_GUI_pojistovna
{
    public partial class Form1 : Form
    {
        NavigationControl navigationControl1;
        NavigationControl navigationControl2;
        private VypisKlienty vypisKlienty1;
        private VypisZamestnance vypisZamestnance1;

        private string _currentUserEmail; // Uložený e-mail pøihlášeného uživatele

        public void SetCurrentUserEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Chyba: E-mail je prázdný.", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _currentUserEmail = email;
            //MessageBox.Show($"Email byl nastaven na: {_currentUserEmail}", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public string GetCurrentUserEmail()
        {
            return _currentUserEmail;
        }

        public Form1()
        {
            InitializeComponent();
            InitializeNavigationControl();
            InitializeVypisKlienty();
            InitializeVypisZamestnance();
        }
        private void InitializeVypisKlienty()
        {
            // Inicializace instance UserControl
            vypisKlienty1 = new VypisKlienty();
        }
        private void InitializeVypisZamestnance()
        {
            // Inicializace instance UserControl
            vypisZamestnance1 = new VypisZamestnance();
        }

        private void InitializeNavigationControl()
        {

            List<UserControl> mainControlList = new List<UserControl>()
{
                new UserRegister(),                 //0 - userRegister.cs
                new Role2_main(),                   //1 - role2main.cs
                new Role3_main(),                   //2 - role3main.cs
                new role4_main(),                   //3 - role4main.cs
                new Role5_main(),                   //4 - role5main.cs
                new Role6_main(),                   //5 - role6main.cs
                new UserProfil(),                   //6 - userProfil.cs
                new PridelitKlientaZamestnanci(),   //7 - pridelitKlientaZamestnanci.cs
                new StatistikyKlientu(),            //8 - statistikyKlientu.cs
                new StatistikyPobocek(),            //9 - statistikyPobocek.cs
                new StatistikyPojistek(),           //10 - statistikyPojistek.cs
                new StatistikyZamestnancu(),        //11 - statistikyZamestnancu.cs
                new UpravitObsahTabulky(),          //12 - upravitObsahTabulky.cs
                new UzivatelVypisPojistek(),        //13 - uzivatelVypisPojistek.cs
                new VypisKlienty(),                 //14 - vypisKlienty.cs
                new VypisPojistky(),                //15 - vypisPojistky.cs
                new VypisZamestnance(),             //16 - vypisZamestnance.cs
                new VytvoritPojistku(),             //17 - vytvoritPojistku.cs
                new ZobrazitLog()                   //18 - zobrazitLog.cs
            };

            navigationControl1 = new NavigationControl(mainPanel, mainControlList);

            List<UserControl> sideControlList = new List<UserControl>()
            { new Login(), new Role1_registrovanyUser(), new role3_zamestnanec(), new Role4_analytik(), new Role5_supervisor(), new Role6_admin()};
            navigationControl2 = new NavigationControl(sidePanel, sideControlList);

            ShowInitial();

        }

        public void ShowInitial()
        {

            navigationControl2.Display(0); // sidePanel
            navigationControl1.Display(0); // mainPanel //FIXME: change to 0

        }

        public void ShowMainScreenRoleBased(int role)
        {

            //ukaze to mainPanel domovskou obrazovku danou roli
            //dostava hodnotu 2-6 podle permise uzivatele
            //je potreba nekde pri loginu zaznamenat roli uzivatele a podle ni zavolat tuto metodu
            navigationControl1.Display(role);
        }

        public void ShowSideScreenRoleBased(int role)
        {

            //ukaze to sidePanel domovskou obrazovku danou roli
            //dostava hodnotu 1-6 podle permise uzivatele
            //je potreba nekde pri loginu zaznamenat roli uzivatele a podle ni zavolat tuto metodu
            navigationControl2.Display(role);
        }



        //---------------Methods for showing user controls-----------------
        // každá metoda zobrazí jiný panel, který je v seznamu mainControlList, se zobrazuje po kliknuti
        // danenoho tlaèítka v panelu roleÈÍSLO_NÁZEV.cs na sidePanelu

        public void ShowUserProfile(string email = null)
        {
            string userEmail = GetCurrentUserEmail();

            if (string.IsNullOrEmpty(userEmail))
            {
                MessageBox.Show("E-mail uživatele není dostupný.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //MessageBox.Show($"Naèítání profilu uživatele pro: {userEmail}", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);


            UserProfil userProfil = new UserProfil();
            navigationControl1.Display(6);
            userProfil.LoadUserData(userEmail); // Naètení dat uživatele
        }




        public void ShowUzivatelVypisPojistky()
        {
            // Pøedpokládáme, že UzivatelVypisPojistky je na indexu 15 v seznamu mainControlList
            // používá se k zobrazení Panelu výpisu pojištìk uživatele
            // Zavolá se pøi kliknutí na tlaèítko r2mojePojistky
            navigationControl1.Display(15);
        }

        public void ShowVypisKlienty()
        {

            navigationControl1.Display(14);  // Zobrazení panelu výpisu klientù
        }

        public void ShowVypisPojistky()
        {
            // Pøedpokládáme, že VypisPojistky je na indexu 16 v seznamu mainControlList
            // používá se k zobrazení Panelu výpisu pojištìk
            // Zavolá se pøi kliknutí na tlaèítko r3pojistky
            navigationControl1.Display(15);
        }

        public void ShowVytvoritPojistku()
        {
            // Pøedpokládáme, že VytvoritPojistku je na indexu 18 v seznamu mainControlList
            // používá se k zobrazení Panelu vytvoøení pojištìní
            // Zavolá se pøi kliknutí na tlaèítko r3newpojistka
            navigationControl1.Display(17);
        }

        public void ShowStatistikyKlientu()
        {
            // Pøedpokládáme, že StatistikyKlientu je na indexu 8 v seznamu mainControlList
            // používá se k zobrazení Panelu statistiky klientù
            // Zavolá se pøi kliknutí na tlaèítko r4statsklienti, r5statsklienti
            navigationControl1.Display(8);
        }

        public void ShowStatistikyZamestnancu()
        {
            // Pøedpokládáme, že StatistikyZamestnancu je na indexu 12 v seznamu mainControlList
            // používá se k zobrazení Panelu statistiky zamìstnancù
            // Zavolá se pøi kliknutí na tlaèítko r4statszamestnanci, r5statszamestnanci
            navigationControl1.Display(11);
        }

        public void ShowStatistikyPojistek()
        {
            // Pøedpokládáme, že StatistikyPojistek je na indexu 11 v seznamu mainControlList
            // používá se k zobrazení Panelu statistiky pojištìk
            // Zavolá se pøi kliknutí na tlaèítko r4statspojistky
            navigationControl1.Display(10);
        }

        public void ShowStatistikyPobocek()
        {
            // Pøedpokládáme, že StatistikyPobocek je na indexu 10 v seznamu mainControlList
            // používá se k zobrazení Panelu statistiky poboèek
            // Zavolá se pøi kliknutí na tlaèítko r4statistikypobocek
            navigationControl1.Display(9);
        }

        public void ShowVypisZamestnance()
        {
            navigationControl1.Display(16);
        }

        public void ShowPridelitKlientaZamestnanci()
        {
            // Pøedpokládáme, že PridelitKlientaZamestnanci je na indexu 8 v seznamu mainControlList
            // používá se k zobrazení Panelu pøidìlení klienta zamìstnanci
            // Zavolá se pøi kliknutí na tlaèítko r5delegate
            navigationControl1.Display(7);
        }

        public void ShowUpravitObsahTabulek()
        {
            // Pøedpokládáme, že UpravitObsahTabulky je na indexu 12 v seznamu mainControlList
            // používá se k zobrazení Panelu úpravy obsahu tabulky
            // Zavolá se pøi kliknutí na tlaèítko r6modeifyTabulky
            navigationControl1.Display(12);
        }

        public void ShowLog()
        {
            // Pøedpokládáme, že ZobrazitLog je na indexu 19 v seznamu mainControlList
            // používá se k zobrazení Panelu logu
            // Zavolá se pøi kliknutí na tlaèítko r6log
            navigationControl1.Display(18);
        }

        public void EmulaceRole(int role)
        {
            // Emulace role uživatele
            // Zavolá se pøi kliknutí na tlaèítko newButtonEMULACE_r2, newButtonEMULACE_r3, newButtonEMULACE_r4, newButtonEMULACE_r5
            if (role > 6)
            {
                navigationControl2.Display(5);
                MessageBox.Show("Role " + role + " je vìtší než poèet permisí a nebyla optimalizována ve FORM1", "Není optimalizováno", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                navigationControl2.Display(role);

            }

        }
        public static User currentUser;
        private void f1HOME_Click(object sender, EventArgs e)
        {
            if (CurrentUser.Role == 0)
            {
                MessageBox.Show("Uživatel není pøihlášen!", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var mainForm = this.FindForm() as Form1;
            if (mainForm != null)
            {
                switch (CurrentUser.Role)
                {
                    case 2:
                        mainForm.ShowMainScreenRoleBased(1);
                        mainForm.ShowSideScreenRoleBased(1);
                        break;
                    case 3:
                        mainForm.ShowMainScreenRoleBased(2);
                        mainForm.ShowSideScreenRoleBased(2);
                        break;
                    case 4:
                        mainForm.ShowMainScreenRoleBased(3);
                        mainForm.ShowSideScreenRoleBased(3);
                        break;
                    case 5:
                        mainForm.ShowMainScreenRoleBased(4);
                        mainForm.ShowSideScreenRoleBased(4);
                        break;
                    case 6:
                        mainForm.ShowMainScreenRoleBased(5);
                        mainForm.ShowSideScreenRoleBased(5);
                        break;
                    default:
                        MessageBox.Show("Neznámá role uživatele.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                }
            }
        }

    }
}


