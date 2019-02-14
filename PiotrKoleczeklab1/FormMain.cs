using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiotrKoleczeklab1
{
    /// <summary>
    /// Jest to klasa, która opisuje główne menu (okno dialogowe)
    /// </summary>
    public partial class FormMain : Form
    {
        // zmienne logiczne, które są potrzebne do inicjalizacji poziomu trudności gry
        static bool easyChosen, mediumChosen, hardChosen, extremeChosen;
        // instrukcja gry
        static string aboutGame = "ZASADY GRY:\n\n" +
            "Gra 'Obrona Sewastopola' jest prostą, taktyczną grą okienkową" +
            ", w której gracz toczy wojnę między III Rzeszą, a ZSRR" +
            " (w zależności od wyboru nacji). Celem gracza jest unicestwienie wszystkich " +
            "jednostek wroga (czołgi, jednostki piechoty). Gracz ma możliwość uzupełniania " +
            "strat w swoich zasobach (w sposób ograniczony). W grze mogą występować losowe (negatywne) " +
            "zjawiska w postaci nalotu artyleryjskiego wezwanego przez wroga, bombardowanie bombowcami czy " +
            "ciężki ostrzał z floty morskiej.";
        // zmienna, która będzie wyświetlana w MessageBoxie, gdy nie zostały kliknięte niezbędne
        // przyciski, które definiują nową rozgrywkę (np. nie wybrano nacji)
        string notChosenDifficulty = "Nie wybrałeś któregoś z parametru definiującego nową rozgrywkę!";
        // zmienne logiczne niezbędne do określenia którą nacją gracz chce zagrać
        static bool reichChosen, zsrrChosen;

        /// <summary>
        /// Gdy klikniemy przycisk "Średni" zmienione zostanie podświetlenie przycisku i ustawione
        /// atrybuty do inicjalizacji poziomu średniego gry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMedium_Click(object sender, EventArgs e)
        {
            mediumChosen = true;
            ChangeDifficultyColorButton(buttonMedium);
            easyChosen = hardChosen = extremeChosen = false;
            UncheckDifficultyButton(buttonEasy, buttonHard, buttonExtreme);
        }

        /// <summary>
        /// Statyczna metoda, która służy do uzyskania nacji, którą zamierzamy grać
        /// </summary>
        /// <returns></returns>
        public static string GetNation()
        {
            if (reichChosen) return "reich";
            else return "zsrr";
        }

        /// <summary>
        /// Statyczna metoda, która służy do uzyskania poziomu trudności
        /// </summary>
        /// <returns></returns>
        public static string GetDifficulty()
        {
            if (easyChosen) return "easy";
            else if (mediumChosen) return "medium";
            else if (hardChosen) return "hard";
            else return "extreme";
        }

        /// <summary>
        /// Gdy klikniemy przycisk "Trudny" zmienione zostanie podświetlenie przycisku i ustawione
        /// atrybuty do inicjalizacji poziomu trudnego gry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHard_Click(object sender, EventArgs e)
        {
            hardChosen = true;
            ChangeDifficultyColorButton(buttonHard);
            mediumChosen = easyChosen = extremeChosen = false;
            UncheckDifficultyButton(buttonMedium, buttonEasy, buttonExtreme);
        }

        /// <summary>
        /// Gdy klikniemy przycisk "Ekstremalny" zmienione zostanie podświetlenie przycisku i ustawione
        /// atrybuty do inicjalizacji poziomu ekstremalnego gry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExtreme_Click(object sender, EventArgs e)
        {
            extremeChosen = true;
            ChangeDifficultyColorButton(buttonExtreme);
            mediumChosen = hardChosen = easyChosen = false;
            UncheckDifficultyButton(buttonMedium, buttonHard, buttonEasy);
        }

        /// <summary>
        /// Konstruktor klasy FormMain, w którym ustawiam domyślne wartości zmiennych
        /// logicznych, które odpowiadają za wybór trudności i nacji
        /// </summary>
        public FormMain()
        {
            easyChosen = mediumChosen = hardChosen = extremeChosen = false;
            reichChosen = zsrrChosen = false;
            InitializeComponent();
        }

        /// <summary>
        /// Tło okna ustawiam na srebrne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }

        /// <summary>
        /// Gdy zostanie kliknięty przycisk "About..." zostaną wyświetlone informacje o autorze
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHowToPlay_Click(object sender, EventArgs e)
        {
            MessageBox.Show(aboutGame);
        }

        /// <summary>
        /// Metoda wyświetlająca MessageBoxa po kliknięciu przycisku "About..."
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Projekt został wykonany jako pierwsze zadanie domowe " +
                "z pierwszych laboratoriów kursu C# Koła Naukowego 'Kredek'\n" +
                "Program wykonany przez: Piotr Kołeczek");
        }

        /// <summary>
        /// Gdy klikniemy przycisk "Łatwy" zmienione zostanie podświetlenie przycisku i ustawione
        /// atrybuty do inicjalizacji poziomu łatwego gry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEasy_Click(object sender, EventArgs e)
        {
            easyChosen = true;
            ChangeDifficultyColorButton(buttonEasy);
            mediumChosen = hardChosen = extremeChosen = false;
            UncheckDifficultyButton(buttonMedium, buttonHard, buttonExtreme);
        }

        /// <summary>
        /// Metoda, która służy do wybrania nacji, którą zamierzamy grać
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReich_Click(object sender, EventArgs e)
        {
            reichChosen = true;
            zsrrChosen = false;
            UncheckNation(buttonZSRR);
            SelectNation(buttonReich);
        }

        /// <summary>
        /// Metoda, która służy do wybrania nacji, którą zamierzamy grać
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonZSRR_Click(object sender, EventArgs e)
        {
            reichChosen = false;
            zsrrChosen = true;
            UncheckNation(buttonReich);
            SelectNation(buttonZSRR);
        }

        /// <summary>
        /// Gdy klikniemy na przycisk "Wyjdź z gry" kończymy działanie programu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Metoda, która inicjuje nowe okno dialogowe gry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStart_Click(object sender, EventArgs e)
        {
            if ((reichChosen == false && zsrrChosen == false) || (easyChosen == false && mediumChosen == false && hardChosen == false && extremeChosen == false))
            {
                MessageBox.Show(notChosenDifficulty);
            }
            else
            {
                GameForm gameForm = new GameForm();
                gameForm.Show(this);
            }
        }

        /// <summary>
        /// Gdy kliknęliśmy na jakiś przycisk wyboru trudności to automatycznie
        /// odznaczamy wybór innych przycisków
        /// </summary>
        /// <param name="button1"></param>
        /// <param name="button2"></param>
        /// <param name="button3"></param>
        private void UncheckDifficultyButton(Button button1, Button button2, Button button3)
        {
            button1.BackColor = button2.BackColor = button3.BackColor = Color.Transparent;

        }

        /// <summary>
        /// Ustawienie koloru w przypadku kliknięcia na przycisk wyboru trudności
        /// </summary>
        /// <param name="button"></param>
        private void ChangeDifficultyColorButton(Button button)
        {
            button.BackColor = Color.Moccasin;
        }

        /// <summary>
        /// Ustawienie koloru w przypadku kliknięcia na przycisk wyboru nacji
        /// </summary>
        /// <param name="button"></param>
        private void SelectNation(Button button)
        {
            button.BackColor = Color.Moccasin;
        }

        /// <summary>
        /// Gdy kliknęliśmy na jakiś przycisk wyboru nacji to automatycznie
        /// odznaczamy wybór innych przycisków
        /// </summary>
        /// <param name="button"></param>
        private void UncheckNation(Button button)
        {
            button.BackColor = Color.Transparent;
        }
    }
}
