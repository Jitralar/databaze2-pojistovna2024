using Aplikace_GUI_pojistovna.MainForms;
using Aplikace_GUI_pojistovna.SideForms;
using Aplikace_GUI_pojistovna.SpecificForms;

namespace Aplikace_GUI_pojistovna
{
    public partial class Form1 : Form
    {
        NavigationControl navigationControl1;
        NavigationControl navigationControl2;

        public Form1()
        {
            InitializeComponent();
            InitializeNavigationControl();
        }


        private void InitializeNavigationControl()
        {

            List<UserControl> mainControlList = new List<UserControl>()
            { 
                new UserRegister(), new Role2_main(), new Role3_main(), new role4_main(), new Role5_main(), new Role6_main(), new UserProfil(), 
                new PridelitKlientaZamestnanci(), new StatistikyKlientu(), new StatistikyPobocek(), new StatistikyPojistek(), new StatistikyZamestnancu(), new UpravitObsahTabulky(), new UzivatelVypisPojistek(), new VypisKlienty(), new VypisPojistky(), new VypisZamestnance(), new VytvoritPojistku(), new ZobrazitLog()
            }; //FIXME: add další jak budu pøidávat


            navigationControl1 = new NavigationControl(mainPanel, mainControlList);

            //-----------------Display the first user control-----------------

            //1 - userRegister.cs
            //2 - role2main.cs
            //3 - role3main.cs
            //4 - role4main.cs
            //5 - role5main.cs
            //6 - role6main.cs
            //7 - userProfil.cs
            //8 - pridelitKlientaZamestnanci.cs
            //9 - statistikyKlientu.cs
            //10 - statistikyPobocek.cs
            //11 - statistikyPojistek.cs
            //12 - statistikyZamestnancu.cs
            //13 - upravitObsahTabulky.cs
            //14 - uzivatelVypisPojistek.cs
            //15 - vypisKlienty.cs
            //16 - vypisPojistky.cs
            //17 - vypisZamestnance.cs
            //18 - vytvoritPojistku.cs
            //19 - zobrazitLog.cs

            // more to be addded, even if you never use them
            // idk it could be someday usefull...
            //----------------------------------------------------------------

            List<UserControl> sideControlList = new List<UserControl>()
            { new Login(), new Role1_registrovanyUser(), new role3_zamestnanec(), new Role4_analytik(), new Role5_supervisor(), new Role6_admin()};
            navigationControl2 = new NavigationControl(sidePanel, sideControlList);

            
            ShowInitial();

        }

        public void ShowInitial() {

            navigationControl2.Display(0); // sidePanel
            navigationControl1.Display(0); // mainPanel //FIXME: change to 0

        }

        public void ShowMainScreenRoleBased(int role) {

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

        public void ShowUserProfile()
        {
            // Pøedpokládáme, že UserProfil je na indexu 7 v seznamu mainControlList
            // používá se k zobrazení Panelu profilu uživatele
            // Zavolá se pøi kliknutí na tlaèítko r2profil, r3profil, r4profil, r5profil, r6profil

            //nutne predelavat pro daneho uzivatele, vsichni sdily stejny form

            navigationControl1.Display(7);
        }

        public void ShowUzivatelVypisPojistky()
        {
            // Pøedpokládáme, že UzivatelVypisPojistky je na indexu 14 v seznamu mainControlList
            // používá se k zobrazení Panelu výpisu pojištìk uživatele
            // Zavolá se pøi kliknutí na tlaèítko r2mojePojistky
            navigationControl1.Display(14);
        }

        public void ShowVypisKlienty()
        {
            // Pøedpokládáme, že VypisKlienty je na indexu 15 v seznamu mainControlList
            // používá se k zobrazení Panelu výpisu klientù
            // Zavolá se pøi kliknutí na tlaèítko r3klienti
            navigationControl1.Display(15);
        }

        public void ShowVypisPojistky()
        {
            // Pøedpokládáme, že VypisPojistky je na indexu 16 v seznamu mainControlList
            // používá se k zobrazení Panelu výpisu pojištìk
            // Zavolá se pøi kliknutí na tlaèítko r3pojistky
            navigationControl1.Display(16);
        }

        public void ShowVytvoritPojistku()
        {
            // Pøedpokládáme, že VytvoritPojistku je na indexu 18 v seznamu mainControlList
            // používá se k zobrazení Panelu vytvoøení pojištìní
            // Zavolá se pøi kliknutí na tlaèítko r3newpojistka
            navigationControl1.Display(18);
        }

        public void ShowStatistikyKlientu()
        {
            // Pøedpokládáme, že StatistikyKlientu je na indexu 9 v seznamu mainControlList
            // používá se k zobrazení Panelu statistiky klientù
            // Zavolá se pøi kliknutí na tlaèítko r4statsklienti, r5statsklienti
            navigationControl1.Display(9);
        }

        public void ShowStatistikyZamestnancu()
        {
            // Pøedpokládáme, že StatistikyZamestnancu je na indexu 12 v seznamu mainControlList
            // používá se k zobrazení Panelu statistiky zamìstnancù
            // Zavolá se pøi kliknutí na tlaèítko r4statszamestnanci, r5statszamestnanci
            navigationControl1.Display(12);
        }

        public void ShowStatistikyPojistek()
        {
            // Pøedpokládáme, že StatistikyPojistek je na indexu 11 v seznamu mainControlList
            // používá se k zobrazení Panelu statistiky pojištìk
            // Zavolá se pøi kliknutí na tlaèítko r4statspojistky
            navigationControl1.Display(11);
        }

        public void ShowStatistikyPobocek()
        {
            // Pøedpokládáme, že StatistikyPobocek je na indexu 10 v seznamu mainControlList
            // používá se k zobrazení Panelu statistiky poboèek
            // Zavolá se pøi kliknutí na tlaèítko r4statistikypobocek
            navigationControl1.Display(10);
        }

        public void ShowVypisZamestnance()
        {
            // Pøedpokládáme, že VypisZamestnance je na indexu 17 v seznamu mainControlList
            // používá se k zobrazení Panelu výpisu zamìstnancù
            // Zavolá se pøi kliknutí na tlaèítko r5zamestnanci
            navigationControl1.Display(17);
        }

        public void ShowPridelitKlientaZamestnanci()
        {
            // Pøedpokládáme, že PridelitKlientaZamestnanci je na indexu 8 v seznamu mainControlList
            // používá se k zobrazení Panelu pøidìlení klienta zamìstnanci
            // Zavolá se pøi kliknutí na tlaèítko r5delegate
            navigationControl1.Display(8);
        }

        public void ShowUpravitObsahTabulek()
        {
            // Pøedpokládáme, že UpravitObsahTabulky je na indexu 13 v seznamu mainControlList
            // používá se k zobrazení Panelu úpravy obsahu tabulky
            // Zavolá se pøi kliknutí na tlaèítko r6modeifyTabulky
            navigationControl1.Display(13);
        }

        public void ShowLog()
        {
            // Pøedpokládáme, že ZobrazitLog je na indexu 19 v seznamu mainControlList
            // používá se k zobrazení Panelu logu
            // Zavolá se pøi kliknutí na tlaèítko r6log
            navigationControl1.Display(19);
        }

        public void EmulaceRole(int role)
        {
            // Emulace role uživatele
            // Zavolá se pøi kliknutí na tlaèítko newButtonEMULACE_r2, newButtonEMULACE_r3, newButtonEMULACE_r4, newButtonEMULACE_r5
            if (role > 6) {
                navigationControl2.Display(6);
                MessageBox.Show("Role " + role + " je vìtší než poèet permisí a nebyla optimalizována ve FORM1", "Není optimalizováno", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
            navigationControl2.Display(role);

            }
                 
        }






    }

}
