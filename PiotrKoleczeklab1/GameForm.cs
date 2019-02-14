using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiotrKoleczeklab1
{
    /// <summary>
    /// Jest to klasa 
    /// </summary>
    public partial class GameForm : Form
    {
        // komunikat wyświetlany tuż przed uruchomieniem okna gry gdy wybraliśmy nację jako ZSRR
        static string zsrrText = "Wygląda na to, że III Rzesza zaatakowała na dobre! Potężne oddziały " +
            "składające się z wielu oddziałów piechoty, czołgów PanzerKampfwagen V Panther, PanzerKampfwagen VI Tiger " +
            "oraz floty morskiej nacierają w Twoją stronę. Tylko uważaj! Może się zdarzyć, że wróg może zaatakować " +
            "w stylu 'Blitzkrieg', czyli zostaną zmobilizowane wszystkie jednostki wroga i z pełną siłą zaczną niszczyć " +
            "Twoje jednostki. Wróg posiada także możliwość ostrzału artyleryjskiego, ostrzału z floty morskiej, a także " +
            "wezwania posiłków podniebnych w postaci myśliwców i bombowców. Powodzenia!";

        // komunikat wyświetlany tuż przed uruchomieniem okna gry gdy wybraliśmy nację jako III Rzesza
        static string reichText = "Najwyższa pora rozprawić się z ZSRR! Ruszamy w bój! Musimy się przedrzeć do przodu " +
            "i zniszczyć wszystkie obiekty wroga. Co prawda mamy skończoną liczbę jednostek, ale mając flotę morską " +
            "dobrze uzbrojone czołgi oraz możliwość wezwania bombowców powinniśmy dać sobie radę!";

        // zmienne licznikowe, które służą do generowania w późniejszym czasie tzw. "katastrofy"
        int yourSeconds, enemySeconds;
        // zmienna służąca do zliczenia ile razy wezwane zostały już posiłki
        int callResources;
        // zmienna służąca do zliczenia ile razy wezwana została już artyleria
        int callArtillery;
        // zmienne przechowujące liczbę jednostek oraz czołgów dla gracza i wroga
        int yourHumanResources, enemyHumanResources;
        int yourTanks, enemyTanks;
        // deklaracja zmiennej typu Rand w celu pseudolosowej zmiany zasobów gracza i przeciwnika
        Random rand;

        /// <summary>
        /// Wszystkie TextBoxy ustawiamy tylko do odczytu, żeby użytkownik
        /// nie mógł wprowadzać własnych liczb
        /// </summary>
        public GameForm()
        {
            InitializeComponent();
            textBoxYourHuman.ReadOnly = true;
            textBoxYourTanks.ReadOnly = true;
            textBoxEnemyHuman.ReadOnly = true;
            textBoxEnemyTanks.ReadOnly = true;
        }

        /// <summary>
        /// Metoda ustawiająca łatwy poziom gry
        /// </summary>
        private void SetEasyMode()
        {
            yourHumanResources = 10000;
            yourTanks = 7400;

            enemyHumanResources = 6500;
            enemyTanks = 2200;

            textBoxYourHuman.Text = yourHumanResources + "";
            textBoxYourTanks.Text = yourTanks + "";
            textBoxEnemyHuman.Text = enemyHumanResources + "";
            textBoxEnemyTanks.Text = enemyTanks + "";
            timerDecreaseYourResources.Interval = 1000;
            timerDecreaseEnemyResources.Interval = 800;
        }

        /// <summary>
        /// Metoda ustawiająca średni poziom gry
        /// </summary>
        private void SetMediumMode()
        {
            yourHumanResources = 8000;
            yourTanks = 6000;

            enemyHumanResources = 7500;
            enemyTanks = 3800;

            textBoxYourHuman.Text = yourHumanResources + "";
            textBoxYourTanks.Text = yourTanks + "";
            textBoxEnemyHuman.Text = enemyHumanResources + "";
            textBoxEnemyTanks.Text = enemyTanks + "";
            timerDecreaseYourResources.Interval = 850;
            timerDecreaseEnemyResources.Interval = 900;
        }

        /// <summary>
        /// Metoda ustawiająca trudny poziom gry
        /// </summary>
        private void SetHardMode()
        {
            yourHumanResources = 4000;
            yourTanks = 1400;

            enemyHumanResources = 8000;
            enemyTanks = 4900;

            textBoxYourHuman.Text = yourHumanResources + "";
            textBoxYourTanks.Text = yourTanks + "";
            textBoxEnemyHuman.Text = enemyHumanResources + "";
            textBoxEnemyTanks.Text = enemyTanks + "";
            timerDecreaseYourResources.Interval = 700;
            timerDecreaseEnemyResources.Interval = 950;
        }

        /// <summary>
        /// Metoda ustawiająca ekstremalny poziom gry
        /// </summary>
        private void SetExtremeMode()
        {
            yourHumanResources = 2500;
            yourTanks = 930;

            enemyHumanResources = 10000;
            enemyTanks = 5800;

            textBoxYourHuman.Text = yourHumanResources + "";
            textBoxYourTanks.Text = yourTanks + "";
            textBoxEnemyHuman.Text = enemyHumanResources + "";
            textBoxEnemyTanks.Text = enemyTanks + "";
            timerDecreaseYourResources.Interval = 500;
            timerDecreaseEnemyResources.Interval = 950;
        }

        /// <summary>
        /// Metoda odpowiedzialna za wyświetlenie w messageboxie informację w przypadku wyboru nacji jako ZSRR
        /// </summary>
        private void ShowZSRRMessage()
        {
            MessageBox.Show(zsrrText);
        }

        /// <summary>
        /// Metoda odpowiedzialna za wyświetlenie w messageboxie informację w przypadku wyboru nacji jako III Rzesza
        /// </summary>
        private void ShowReichText()
        {
            MessageBox.Show(reichText);
        }

        /// <summary>
        /// Inicjalizacja generatora liczb pseudolosowych, ustawienie poziomu trudności
        /// i koloru tła
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameForm_Load(object sender, EventArgs e)
        {
            rand = new Random();
            if (FormMain.GetNation() == "reich") MessageBox.Show(reichText);
            else MessageBox.Show(zsrrText);
            this.BackColor = Color.Silver;
            if (FormMain.GetDifficulty() == "easy") SetEasyMode();
            else if (FormMain.GetDifficulty() == "medium") SetMediumMode();
            else if (FormMain.GetDifficulty() == "hard") SetHardMode();
            else SetExtremeMode();
        }

        /// <summary>
        /// W tej metodzie wraz z cyklem czasomierza dochodzi do pewnych zdarzeń dla zasobów użytkownika.
        /// Są one pomniejszane
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerDecreaseYourResources_Tick(object sender, EventArgs e)
        {
            if (yourHumanResources <= 0)
            {
                textBoxYourHuman.Text = "0";
                timerDecreaseYourResources.Stop();
                timerDecreaseEnemyResources.Stop();
                MessageBox.Show("Twoje wszystkie jednostki piechoty zostały zabite, a czołgom skończyła się amunicja! " +
                    "Przegrałeś!");
                this.Close();
            }
            else
            {
                yourSeconds++;
                if (yourSeconds == 30)
                {
                    if (FormMain.GetNation() == "zsrr")
                    {
                        MessageBox.Show("O nie! III Rzesza zmobilizowała wszystkie swoje oddziały " +
                            "i wykonali 'Szybką Wojnę'! Straty w Twoich jednostkach są ogromne.");
                        yourHumanResources -= rand.Next(1000, 1900);
                        yourTanks -= rand.Next(300, 500);
                    }
                    else if (FormMain.GetNation() == "reich")
                    {
                        MessageBox.Show("ZSRR wezwało wsparcie artyleryjskie oraz przybywają bombowce. " +
                            "Straty w Twoich jednostkach są wielkie!");
                        yourHumanResources -= rand.Next(1000, 1900);
                        yourTanks -= rand.Next(300, 500);
                    }

                }
                yourHumanResources -= rand.Next(30, 100);
                yourTanks -= rand.Next(10, 20);
                textBoxYourHuman.Text = yourHumanResources + "";
                textBoxYourTanks.Text = yourTanks + "";
            }
        }

        /// <summary>
        /// Metoda uruchamiająca czasomierze gdy klikniemy przycisk "Zacznij grę!"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            timerDecreaseYourResources.Start();
            timerDecreaseEnemyResources.Start();
        }

        /// <summary>
        /// Metoda odpowiedzialna za wezwanie posiłków.
        /// Zasoby ludzkie i czołgi zostają uzupełnione u gracza.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCallSupport_Click(object sender, EventArgs e)
        {
            callResources++;
            if (callResources <= 3)
            {
                MessageBox.Show("Posiłki są w drodze! Wnet Twoje straty w jednostkach zostaną uzupełnione");
                yourHumanResources += 1500;
                yourTanks += 700;
            }
            else
            {
                MessageBox.Show("Niestety, ale wykorzystałeś wszystkie swoje posiłki, które mogłeś wezwać.");
            }

        }

        /// <summary>
        /// Metoda wzywająca ostrzał artyleryjski na wroga.
        /// Zasoby przeciwnika zostają pomniejszone.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCallArtillery_Click(object sender, EventArgs e)
        {
            callArtillery++;
            if (callArtillery <= 3)
            {
                MessageBox.Show("Operatorowi radiostacji udało się nawiązać kontakt ze wsparciem artyleryjskim! " +
                    "Pociski celnie trafiają w cel i zadają spore straty u wroga!");
                enemyHumanResources -= 1500;
                enemyTanks -= 500;
            }
            else
            {
                MessageBox.Show("Ojoj! Radiooperatorowi nawaliła radiostacja! Nie wezwiemy już wsparcia artyleryjskiego!");
            }
        }

        /// <summary>
        /// Metoda, która wraz z każdym kolejnym cyklem czasomierza wywołuje pewne, korzystne dla wroga zdarzenia,
        /// pomniejsza zasoby swoich wojsk
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerDecreaseEnemyResources_Tick(object sender, EventArgs e)
        {
            if (enemyHumanResources <= 0)
            {
                textBoxEnemyHuman.Text = "0";
                timerDecreaseYourResources.Stop();
                timerDecreaseEnemyResources.Stop();
                MessageBox.Show("Zabiłeś wszystkie jednostki wroga, a wrogim czołgom skończyła się amunicja! " +
                    "Wygrałeś!");
                this.Close();
            }
            else
            {
                enemySeconds++;
                if (enemySeconds >= 40)
                {
                    MessageBox.Show("Wrogowi udało się częściowo uzupełnić straty w jednostkach!");
                    enemyHumanResources += rand.Next(150, 450);
                    enemyTanks += rand.Next(50, 150);
                }
                enemyHumanResources -= rand.Next(100, 500);
                enemyTanks -= rand.Next(12, 190);
                textBoxEnemyHuman.Text = enemyHumanResources + "";
                textBoxEnemyTanks.Text = enemyTanks + "";
            }

        }
    }
}
