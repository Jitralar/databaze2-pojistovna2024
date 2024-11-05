# databaze2-pojistovna2024
BDAS2 semestrální práce UPCE FEI 2024

Téma 2: Informační systém pojišťovny

vytvořil ![Michal Jelínek](https://github.com/jelinekmi/) a ![Jiří Král](https://github.com/jitralar/)

založeno na schématu, vytvořeno během předmětu BDAS1, jehož autorem je ![Jiří Král](https://github.com/jitralar/) 
____
### Popis projektu:
Středně velká pojišťovna z České republiky si přeje po mnoha letech provizorií přejít na nový informační systém. S ohledem na několika na sobě nezávislých důvodů si pojišťovna nemůže dovolit přejít na zcela nové in-house řešení, kvůli tomu vzniká toto technologické demo, aby si pojišťovna dokázala určit, které procesy lze zachovat, které odstranit a jakým stylem bude muset předělat postupy, smlouvy a jiné dokumenty. Systém proto bude v některých částech používat kombinaci nových a starých standardů zákazníka a počítat s tím, že během následujících 5 letech bude nahrazen finálním řešením, které plně nahradí jak toto technologické demo, tak hlavně dosavadní procesy v pojišťovně.

Celý proces, jakkoliv je dočasný, musí přes to podléhat nařízení o ohraně osobních údajů, neboli GDPR - (_Nařízení Evropského parlamentu a Rady (EU) č. 2016/679 ze dne 27. dubna 2016 o ochraně fyzických osob v souvislosti se zpracováním osobních údajů a o volném pohybu těchto údajů a o zrušení směrnice 95/46/ES obecné nařízení o ochraně osobních údajů_)

### Scénář: 
*Atributy* jsou označeny kurzívou, **Entity** jsou označeny tučným písmem.

**Pojistka** je jedna z nejdůležitějších tabulek. **Pojistka** musí identifikovat *kdy* byla sjednána, do které *hodnoty* je kryto pojistkou a o jaký *druh* pojistky se jedná. A to konkrétně: **Připojištění**, **Úrazové pojištění** anebo **Majetkové pojištění**. Kromě toho je u každé pojistky evidováno, co smí a musí dělat v rámci smlouvy, díky **Závazkům** a **Pohledávkám**. Ke každé **Pojistce** také může být přidána **Fotodokumentace**. Co si také klient přál bylo ukládání dat o tom, který zaměstnanec vykonal danou pojistku. Pro další evidenci zaměstnanců slouží i tabulka **Zaměstnanec**. O **Zaměstnanci** je mimo jména nutné ukládat i co vykonávají za **Pozici**, pod kterou **Pobočku** patří. **Klient** a **Banka** ukládají svoje standartní identifikátory jako například *název*, oproti tomu bude **Kontakt** jako svá vlastní tabulka pouze v pozici odkazu – neboli cizího klíče. Na ni je navázaná i tabulka **Secret**, která uchovává údaje pro spojení s dvojúrovňovému ověřování. Stejnou implementací je připojen **Kontakt** k **Zaměstnancovi**. K budoucímu spojení bude docházet mezi **Klientem** a **Bankou**. Ta momentálně není přidělená, protože jednotlivé Banky nedali integrovanému spojeni **KLIENT x POJISTOVNA x BANKA** zelenou. **Adresa** bude sloužit na uložení standartních údajů a hlavně města. To je kvůli následnému filtrování pomocí **Kraj** umožní dávat požadovaná anonymizovaná data analytickému a marketingovému týmu, či jiné časti **Zaměstnanců** pojišťovny. 

### Procedurálná pravidla:

- Adresa musí mít Kraj
- ID_kraj nemůže být vyšší než 14
- Zaměstnanec musí mít Pozici
- V Adresa, Patra se počítají od 0 = přízemí, 1 = první podlaží
- Datum ukončení smlouvy nesmí být před uzavřením smlouvy
- Hodnota platba_mesicne nesmí přesahovat 100% pojištěné hodnoty

### Uživatelské role:
Databáze počítá že v rámci pojišťovny je nespočetné množství pozic, nicméně pro práci v aplikaci se počítá pouze s 5 rolemy. Jak se role přidávají jednotlivím zaměstnancům, záleží na daném postopu pojišťovny a teoreticky lze být časem modifikováno.

| Id | Název role | Základní popis funkcí |
| ------------- | ------------- | ------------- |
| 1  | Neregistrovaný uživatel (klient)  | Může vyplnit základní údaje o sobě a tím si vytvořit účet v aplikaci  |
| 2  | Registrovaný uživatel (klient)  | Má přiděleného zaměstnance, který se o něj "stará". Může prohlížet své pojistky.  |
| 3  | Zaměstnanec  | Spravuje obsah pojistek. Může si přepínat mezi svými klienty a spravuje jodnotlivé pojistky.  |
| 4  | Analytik  | Může sledovat anonymizované statistiky a výstupy ze systému.  |
| 5  | Supervisor  | Má práva všech rolí (2 - 5). Přiděluje jednotlivé zaměstnance ke klientům. |

### CRUD analýza:
//todo

### Analýza smyček v databázi:
Smyček má toto řešení několik, u všech je nutné být opatrný, je nutné všude používat ID srovnání s cizími klíči.

- Klient, Kontakt, Banka
- Klient, Kontakt, Banka, Adresa
- Pojistka, Klient, Adresa, Zaměstnanec
- Zaměstnanec, Pobočka, Adresa
- Pojistka, Klient, Kontakt, Zaměstnanec

### Integritní omezení:

    IO1: Klient musí mít svoji Adresu.
    IO2: Plat zaměstnance musí být minimálně ve výši minimální mzdy.
    IO3: Pojištění Majetek musí spadat do nějaké kategorie
    IO4: Adresa nerozlišuje městské části Prahy
    IO5: Pojistka musí mít přiřazené Povinnosti a kategorii pojistky. 

## ERD (entitně vztahový model):

![Logical_page-0001](https://github.com/user-attachments/assets/b1767039-7064-4934-a57a-a74121685f58)

Oproti modelu v BDAS1, přibyli tabulky Secret - pro informace a ukládání dat nutné pro 2fa (dvoojúrovňové ověřování) a tabulka Fotodokumentace, pro ukládání binárních souborů s fotografiemi k pojistkám.

**ERDish věty:**

    Každé Povinnosti musí a patří k jedné nebo více Pojistkám
    Každé Pojistky musí mít jednu a pouze jednu Povinnost
    Každá Kategorie majetku může být u jednoho nebo více Majetkového pojištění
    Každé Majetkové pojištění může mít jednu a pouze jednu Kategorii majetku
    Každý Pojistka může být napsaná u jednoho nebo více Klientů
    Každý Klient musí využívat jednu nebo více Pojistek
    Každý Klient může mít jeden a pouze jeden Kontakt
    Každý Kontakt může mít přidělen jednoho nebo více Klientů
    Každý Klient může účtovat u jedné nebo více Bank
    Každá Banka může vést jednoho a jenom jednoho Klienta
    Každý Klient může být bydlištěm na jedné a pouze jedné Adrese
    Každý Kontakt může mít jednu nebo více Bank
    Každá Banka může mít jeden a pouze jeden Kontakt
    Každá Banka musí se nacházet na jedné a pouze jedné Adrese
    Každá Adresa může být přidělena jedné nebo více Bank
    Každý Kontakt může být přidělen jednomu nebo více Zaměstnancovy
    Každá Adresa může být u jednoho a pouze jednoho Kraje
    Každý Kraj může mít jednu nebo více Adres
    Každá Adresa může být přidělena jedné nebo více Pobočkám
    Každá Pobočka může se nacházet na jedné a pouze jedné Adrese
    Každá Adresa může být u jednoho nebo více zaměstnanců
    Každý Zaměstnanec může bydlet na jedné a pouze jedné Adrese
    Každá Pobočka může mít jednoho nebo více Zaměstnanců
    Každý Zaměstnanec musí být součástí jednoho nebo více Poboček
    Každý Zaměstnanec musí vykonávat jednu a pouze jednu Pozici
    Každá Pozice může být vykonávána jedním nebo více Zaměstnancem
    Každá Pojistka musí být zřizována jedním nebo více Zaměstnanci
    Každý Zaměstnanec může zřizovat jednu nebo více Pojistek
//todo: Fotodokumentace + Secret

### Relační model dat:

![Relational_1_page-0001](https://github.com/user-attachments/assets/3a9c8f99-9649-4085-bd10-ab911d4f3c2a)

Vytořeno pomocí Oracle SQL Developer Data Modeler 





