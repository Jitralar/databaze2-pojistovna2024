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


## Tabulky v databázi:


### `adresa`
| Column                 | Type           | Constraints | Comment                                  |
|------------------------|----------------|-------------|------------------------------------------|
| `id_adresa`            | NUMBER         | NOT NULL    | Primary key, unique ID of the address    |
| `ulice`                | VARCHAR2(32)   | NOT NULL    | Street name                              |
| `cislo_orientacni`     | VARCHAR2(32)   |             | Orientation number                       |
| `cislo_popisne`        | VARCHAR2(32)   | NOT NULL    | Descriptive number                       |
| `mesto`                | VARCHAR2(32)   | NOT NULL    | City                                     |
| `psc`                  | CHAR(5)        | NOT NULL    | Postal code                              |
| `patro`                | NUMBER         |             | Floor                                    |
| `kraj_id_kraj`         | NUMBER         |             | Foreign key to `kraj` table              |

### `banka`
| Column                 | Type           | Constraints | Comment                                  |
|------------------------|----------------|-------------|------------------------------------------|
| `id_banka`             | NUMBER         | NOT NULL    | Primary key, unique ID of the bank       |
| `nazev`                | VARCHAR2(32)   | NOT NULL    | Bank name                                |
| `adresa_id_adresa`     | NUMBER         | NOT NULL    | Foreign key to `adresa` table            |
| `kontakt_id_kontakt`   | NUMBER         |             | Foreign key to `kontakt` table           |
| `telefon`              | CHAR(9)        |             | Bank contact phone number                |
| `klient_id_klient`     | NUMBER         |             | Foreign key to `klient` table            |

### `fotodokumentace`
| Column                         | Type           | Constraints | Comment                                  |
|--------------------------------|----------------|-------------|------------------------------------------|
| `id_fotodokumentace`           | NUMBER         | NOT NULL    | Primary key, unique ID of the photo      |
| `fotografie`                   | BLOB           | NOT NULL    | Photo file                               |
| `pojistka_poj_id_pojisteni`    | NUMBER         | NOT NULL    | Foreign key to `pojistka` table          |

### `kategorie_majetek`
| Column                         | Type           | Constraints | Comment                                  |
|--------------------------------|----------------|-------------|------------------------------------------|
| `id_kategorie_majetku`         | NUMBER         | NOT NULL    | Primary key, unique ID of the category   |
| `nazev_kategorie`              | VARCHAR2(255)  | NOT NULL    | Category name                            |

### `klient`
| Column                         | Type           | Constraints | Comment                                  |
|--------------------------------|----------------|-------------|------------------------------------------|
| `id_klient`                    | NUMBER         | NOT NULL    | Primary key, unique ID of the client     |
| `jmeno`                        | VARCHAR2(32)   | NOT NULL    | Client's first name                      |
| `druhe_jmeno`                  | VARCHAR2(32)   |             | Client's middle name                     |
| `prijmeni`                     | VARCHAR2(32)   | NOT NULL    | Client's last name                       |
| `datum_narozeni`               | DATE           | NOT NULL    | Client's birth date                      |
| `prijem`                       | NUMBER         | NOT NULL    | Client's income                          |
| `adresa_id_adresa`             | NUMBER         |             | Foreign key to `adresa` table            |
| `kontakt_id_kontakt`           | NUMBER         |             | Foreign key to `kontakt` table           |
| `banka_id_banka`               | NUMBER         |             | Foreign key to `banka` table             |
| `id_kontakt`                   | NUMBER         |             | Duplicate foreign key to `kontakt`       |

### `kontakt`
| Column                         | Type           | Constraints | Comment                                  |
|--------------------------------|----------------|-------------|------------------------------------------|
| `id_kontakt`                   | NUMBER         | NOT NULL    | Primary key, unique ID of the contact    |
| `telefon`                      | CHAR(9)        |             | Landline phone number                    |
| `mobil`                        | CHAR(9)        |             | Mobile phone number                      |
| `email`                        | VARCHAR2(64)   |             | Contact email address                    |

### `kraj`
| Column                         | Type           | Constraints | Comment                                  |
|--------------------------------|----------------|-------------|------------------------------------------|
| `id_kraj`                      | NUMBER         | NOT NULL    | Primary key, unique ID of the region     |
| `nazev_kraje`                  | VARCHAR2(255)  | NOT NULL    | Region name                              |
| `krajske_mesto`                | VARCHAR2(255)  | NOT NULL    | Capital city of the region               |

### `majetkove_pojisteni`
| Column                         | Type           | Constraints | Comment                                  |
|--------------------------------|----------------|-------------|------------------------------------------|
| `id_poj_pojisteni`             | NUMBER         | NOT NULL    | Primary key, unique ID of insurance      |
| `maj_id_majetek`               | NUMBER         | NOT NULL    | Property ID covered by insurance         |
| `maj_popis`                    | VARCHAR2(255)  | NOT NULL    | Description of insured property          |
| `maj_vyrobeno_v_roce`          | DATE           |             | Year property was manufactured           |
| `kategorie_majetek_id_kat_majetku` | NUMBER     |             | Foreign key to `kategorie_majetek`       |

### `pobocka`
| Column                         | Type           | Constraints | Comment                                  |
|--------------------------------|----------------|-------------|------------------------------------------|
| `id_pobocka`                   | NUMBER         | NOT NULL    | Primary key, unique ID of branch         |
| `pocet_zamestnancu`            | NUMBER         |             | Number of employees                      |
| `nazev`                        | VARCHAR2(32)   | NOT NULL    | Branch name                              |
| `adresa_id_adresa`             | NUMBER         |             | Foreign key to `adresa` table            |

### `pohledavka`
| Column                         | Type           | Constraints | Comment                                  |
|--------------------------------|----------------|-------------|------------------------------------------|
| `id_pov_povinosti`             | NUMBER         | NOT NULL    | Obligation ID                            |
| `poh_id_pohledavka`            | NUMBER         | NOT NULL    | Primary key, unique ID of claim          |
| `poh_popis`                    | VARCHAR2(255)  |             | Claim description                        |

### `pojistka`
| Column                         | Type           | Constraints | Comment                                  |
|--------------------------------|----------------|-------------|------------------------------------------|
| `poj_id_pojisteni`             | NUMBER         | NOT NULL    | Primary key, unique ID of policy         |
| `poj_datum_sjednani`           | DATE           | NOT NULL    | Policy agreement date                    |
| `poj_poznamka`                 | VARCHAR2(255)  |             | Policy note                              |
| `poj_pojisteno_do_hodnoty`     | VARCHAR2(4000) |             | Insured amount                           |
| `poj_cena_mesicne`             | VARCHAR2(4000) |             | Monthly premium                          |
| `povinosti_id_pov_povinosti`   | NUMBER         | NOT NULL    | Foreign key to `povinosti` table         |
| `poj_id_arc`                   | CHAR(1)        | NOT NULL    | Arc discriminator for policy type        |

### `pojistka_klient`
| Column                         | Type           | Constraints | Comment                                  |
|--------------------------------|----------------|-------------|------------------------------------------|
| `poj_id_pojisteni`             | NUMBER         | NOT NULL    | Foreign key to `pojistka` table          |
| `kli_id_klient`                | NUMBER         | NOT NULL    | Foreign key to `klient` table            |
| `id_st_poj_kli`                | NUMBER         | NOT NULL    | Link ID between `pojistka` and `klient`  |

### `povinosti`
| Column                         | Type           | Constraints | Comment                                  |
|--------------------------------|----------------|-------------|------------------------------------------|
| `pov_id_povinosti`             | NUMBER         | NOT NULL    | Primary key, unique ID of obligation     |
| `pov_datum_vytvoreni`          | DATE           | NOT NULL    | Date of obligation creation              |
| `pov_datum_zplatnosti`         | DATE           |             | Due date                                 |
| `pov_id_arc`                   | CHAR(1)        | NOT NULL    | Arc discriminator for obligation type    |

### `pozice`
| Column                         | Type           | Constraints | Comment                                  |
|--------------------------------|----------------|-------------|------------------------------------------|
| `id_pozice`                    | NUMBER         | NOT NULL    | Primary key, unique ID of position       |
| `nazev`                        | VARCHAR2(32)   | NOT NULL    | Position name                            |
| `popis`                        | VARCHAR2(255)  |             | Position description                     |
| `plat`                         | NUMBER         | NOT NULL    | Salary                                   |

### `pripojisteni`
| Column                         | Type           | Constraints | Comment                                  |
|--------------------------------|----------------|-------------|------------------------------------------|
| `id_poj_pojisteni`             | NUMBER         | NOT NULL    | Foreign key to `pojistka` table          |
| `pri_id_pripojisteni`          | NUMBER         | NOT NULL    | Primary key, unique ID of add-on policy  |
| `pri_druh`                     | VARCHAR2(255)  |             | Type of add-on policy                    |
| `pri_plati_pouze_ve_statech`   | VARCHAR2(255)  |             | Only valid in certain states             |
| `pri_cena_pripojisteni`        | VARCHAR2(4000) | NOT NULL    | Add-on policy premium                    |

### `secret`
| Column                         | Type           | Constraints | Comment                                  |
|--------------------------------|----------------|-------------|------------------------------------------|
| `id_secret`                    | NUMBER         | NOT NULL    | Primary key, unique ID of secret entry   |
| `token`                        | VARCHAR2(255)  | NOT NULL    | Encrypted 2FA token                      |
| `kontakt_id_kontakt`           | NUMBER         | NOT NULL    | Foreign key to `kontakt` table           |

### `urazove_pojisteni`
| Column                         | Type           | Constraints | Comment                                  |
|--------------------------------|----------------|-------------|------------------------------------------|
| `id_poj_pojisteni`             | NUMBER         | NOT NULL    | Foreign key to `pojistka` table          |
| `ura_id_uraz`                  | NUMBER         | NOT NULL    | Unique ID of injury                      |
| `ura_druh_urazu`               | VARCHAR2(255)  |             | Type of injury                           |
| `ura_datum_narozeni`           | DATE           |             | Birth date of the insured person         |
| `ura_alergie`                  | VARCHAR2(255)  |             | Known allergies                          |

### `zamestnanec`
| Column                         | Type           | Constraints | Comment                                  |
|--------------------------------|----------------|-------------|------------------------------------------|
| `id_zam`                       | NUMBER         | NOT NULL    | Primary key, unique ID of employee       |
| `jmeno`                        | VARCHAR2(32)   | NOT NULL    | First name                               |
| `druhe_jmeno`                  | VARCHAR2(32)   |             | Middle name                              |
| `prijmeni`                     | VARCHAR2(32)   | NOT NULL    | Last name                                |
| `adresa_id_adresa`             | NUMBER         |             | Foreign key to `adresa` table            |
| `pozice_id_pozice`             | NUMBER         | NOT NULL    | Foreign key to `pozice` table            |
| `kontakt_id_kontakt`           | NUMBER         |             | Foreign key to `kontakt` table           |

### `zamestnanec_pobocka`
| Column                         | Type           | Constraints | Comment                                  |
|--------------------------------|----------------|-------------|------------------------------------------|
| `zam_id_zam`                   | NUMBER         | NOT NULL    | Foreign key to `zamestnanec` table       |
| `pob_id_pobocka`               | NUMBER         | NOT NULL    | Foreign key to `pobocka` table           |
| `id_st_zam_pob`                | NUMBER         | NOT NULL    | Unique link ID                           |

### `zamestnanec_pojistka`
| Column                         | Type           | Constraints | Comment                                  |
|--------------------------------|----------------|-------------|------------------------------------------|
| `zam_id_zam`                   | NUMBER         | NOT NULL    | Foreign key to `zamestnanec` table       |
| `poj_id_pojisteni`             | NUMBER         | NOT NULL    | Foreign key to `pojistka` table          |
| `id_st_zam_poj`                | NUMBER         | NOT NULL    | Unique link ID                           |

### `zavazek`
| Column                         | Type           | Constraints | Comment                                  |
|--------------------------------|----------------|-------------|------------------------------------------|
| `id_pov_povinosti`             | NUMBER         | NOT NULL    | Foreign key to `povinosti` table         |
| `zav_id_zavazek`               | NUMBER         | NOT NULL    | Primary key, unique ID of obligation     |
| `zav_popis`                    | VARCHAR2(255)  | NOT NULL    | Description of obligation                |





