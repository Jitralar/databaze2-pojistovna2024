using Aplikace_GUI_pojistovna.MainForms;
using Aplikace_GUI_pojistovna.SideForms;
using Aplikace_GUI_pojistovna.SpecificForms;

namespace Aplikace_GUI_pojistovna
{
    public partial class Form1 : Form
    {
        NavigationControl navigationControl;

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
            }; //FIXME: add dal�� jak budu p�id�vat


            navigationControl = new NavigationControl(mainPanel, mainControlList);

            //-----------------Display the first user control-----------------

            //1 - role2main.cs
            //2 - role3main.cs
            //3 - userRegister.cs
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


            navigationControl.Display(3); // = disply na main panelu ve Form1.cs


            // more to be addded, even if you never use them
            // idk it could be someday usefull...
            //----------------------------------------------------------------

            List<UserControl> sideControlList = new List<UserControl>()
            { new Login(), new Role1_registrovanyUser(), new role3_zamestnanec(), new Role4_analytik(), new Role5_supervisor(), new Role6_admin()};
            navigationControl = new NavigationControl(sidePanel, sideControlList);
            navigationControl.Display(0);

            //WARNING: role1_registrovanyUser.cs je vedena jako role1, ale vzhledem k tomu, ze se to nepropsalo a nechci riskovat nefunk�nost a hrabani se v tom, tak jsem to nechal takto

        }

        public void ShowUserProfile()
        {
            // P�edpokl�d�me, �e UserProfil je na indexu 7 v seznamu mainControlList
            // pou��v� se k zobrazen� Panelu profilu u�ivatele
            // Zavol� se p�i kliknut� na tla��tko r2profil, r3profil, r4profil, r5profil, r6profil

            //nutne predelavat pro daneho uzivatele, vsichni sdily stejny form

            navigationControl.Display(7);
        }

        public void ShowUzivatelVypisPojistky()
        {
            // P�edpokl�d�me, �e UzivatelVypisPojistky je na indexu 14 v seznamu mainControlList
            // pou��v� se k zobrazen� Panelu v�pisu poji�t�k u�ivatele
            // Zavol� se p�i kliknut� na tla��tko r2mojePojistky
            navigationControl.Display(14);
        }

        public void ShowVypisKlienty()
        {
            // P�edpokl�d�me, �e VypisKlienty je na indexu 15 v seznamu mainControlList
            // pou��v� se k zobrazen� Panelu v�pisu klient�
            // Zavol� se p�i kliknut� na tla��tko r3klienti
            navigationControl.Display(15);
        }

        public void ShowVypisPojistky()
        {
            // P�edpokl�d�me, �e VypisPojistky je na indexu 16 v seznamu mainControlList
            // pou��v� se k zobrazen� Panelu v�pisu poji�t�k
            // Zavol� se p�i kliknut� na tla��tko r3pojistky
            navigationControl.Display(16);
        }

        public void ShowVytvoritPojistku()
        {
            // P�edpokl�d�me, �e VytvoritPojistku je na indexu 18 v seznamu mainControlList
            // pou��v� se k zobrazen� Panelu vytvo�en� poji�t�n�
            // Zavol� se p�i kliknut� na tla��tko r3newpojistka
            navigationControl.Display(18);
        }

        public void ShowStatistikyKlientu()
        {
            // P�edpokl�d�me, �e StatistikyKlientu je na indexu 9 v seznamu mainControlList
            // pou��v� se k zobrazen� Panelu statistiky klient�
            // Zavol� se p�i kliknut� na tla��tko r4statsklienti, r5statsklienti
            navigationControl.Display(9);
        }

        public void ShowStatistikyZamestnancu()
        {
            // P�edpokl�d�me, �e StatistikyZamestnancu je na indexu 12 v seznamu mainControlList
            // pou��v� se k zobrazen� Panelu statistiky zam�stnanc�
            // Zavol� se p�i kliknut� na tla��tko r4statszamestnanci, r5statszamestnanci
            navigationControl.Display(12);
        }

        public void ShowStatistikyPojistek()
        {
            // P�edpokl�d�me, �e StatistikyPojistek je na indexu 11 v seznamu mainControlList
            // pou��v� se k zobrazen� Panelu statistiky poji�t�k
            // Zavol� se p�i kliknut� na tla��tko r4statspojistky
            navigationControl.Display(11);
        }

        public void ShowStatistikyPobocek()
        {
            // P�edpokl�d�me, �e StatistikyPobocek je na indexu 10 v seznamu mainControlList
            // pou��v� se k zobrazen� Panelu statistiky pobo�ek
            // Zavol� se p�i kliknut� na tla��tko r4statistikypobocek
            navigationControl.Display(10);
        }

        public void ShowVypisZamestnance()
        {
            // P�edpokl�d�me, �e VypisZamestnance je na indexu 17 v seznamu mainControlList
            // pou��v� se k zobrazen� Panelu v�pisu zam�stnanc�
            // Zavol� se p�i kliknut� na tla��tko r5zamestnanci
            navigationControl.Display(17);
        }

        public void ShowPridelitKlientaZamestnanci()
        {
            // P�edpokl�d�me, �e PridelitKlientaZamestnanci je na indexu 8 v seznamu mainControlList
            // pou��v� se k zobrazen� Panelu p�id�len� klienta zam�stnanci
            // Zavol� se p�i kliknut� na tla��tko r5delegate
            navigationControl.Display(8);
        }

        public void ShowUpravitObsahTabulek()
        {
            // P�edpokl�d�me, �e UpravitObsahTabulky je na indexu 13 v seznamu mainControlList
            // pou��v� se k zobrazen� Panelu �pravy obsahu tabulky
            // Zavol� se p�i kliknut� na tla��tko r6modeifyTabulky
            navigationControl.Display(13);
        }

        public void ShowLog()
        {
            // P�edpokl�d�me, �e ZobrazitLog je na indexu 19 v seznamu mainControlList
            // pou��v� se k zobrazen� Panelu logu
            // Zavol� se p�i kliknut� na tla��tko r6log
            navigationControl.Display(19);
        }


    }

}
