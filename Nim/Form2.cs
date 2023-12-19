using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nim
{
    public partial class Form2 : Form
    {
        List<PictureBox> streichholzListe = new List<PictureBox>(); //Liste für Anzahl der Streichhölzer
        const int WIDTH = 60;   //Konstanten für Höhe und Weite
        const int HEIGHT = 160;//der Streichhölzer

        int anzahlStreichhoelzer = 15; //Variable für Anzahl der Streichhölzer
        int anzahlClicks = 0;  

        public static bool hardMode = Form1.hardModeF2; //Variablen genommen von der vorherigen Form
        public static bool easyMode = Form1.easyModeF2; //um den Spielmodus zu bestimmen

        string player = "Spieler 1"; //Namen von den Spieler
        string enemy = "";          //Namen von dem Gegner

        Form1 frmMain;
        public Form2(Form1 view)
        {
            InitializeComponent();
            streichhoelzerListe();
            this.frmMain = view;
        }

        //Methode um die gesammten Streichhölzer in die Liste, anzupassen und zu zeigen
        private void streichhoelzerListe() 
        {
            for (int i = 1; i <= anzahlStreichhoelzer; i++)
            {
                PictureBox streichholzNeu = new PictureBox();
                streichholzNeu.Image = Image.FromFile(@"../../../assets/streichholz.png"); //Pixelbild für Streichhölzer

                streichholzNeu.Name = "streichholz" + i.ToString(); 
                streichholzNeu.Width = WIDTH;
                streichholzNeu.Height = HEIGHT;
                streichholzListe.Add(streichholzNeu);

                streichholzNeu.Top = 150;       //Formatierung der 
                streichholzNeu.Left = 100 * i; //Streichhölzer auf Form
                this.Controls.Add(streichholzNeu);  //letzendliche zeigen des Streichholz               
            }
            turnSwitch.Enabled = false; //Button deaktiviert, dass der Gegner dran ist
        }
        //Event für den Klick um Streichhölzer zu nehmen
        private void btnNim_Click(object sender, EventArgs e)
        {
            turnSwitch.Enabled = true;  //Gegner wieder erlaubt zu aktivieren
            labTurn.Text = player + " ist am Zug";  //Ausgabe: Wer hat den Zug

            if (streichholzListe.Count >= 1 && anzahlClicks < 3) //Filtert wie lange man spielen darf
            {
                if (streichholzListe.Count == 1) //Falls man verloren hat
                {
                    labelLoose.Show();
                    retry.Show();
                    btnLeave.Show();
                    btnNim.Hide();
                    turnSwitch.Hide();
                    labTurn.Hide();
                }

            anzahlClicks++;
            PictureBox letztesStreichholz = streichholzListe[streichholzListe.Count - 1]; //letztes aus Liste wir gespeichert
            streichholzListe.RemoveAt(streichholzListe.Count - 1);                        //aus Liste genommen
        
            this.Controls.Remove(letztesStreichholz); //und aus der Form
            }
            else if (anzahlClicks == 3) //falls man 3 geklickt hat
            {
                btnNim.Enabled = false;
            }
            else
            {
                return;
            }
        }
        //Button wechselt vom Spieler zum Gegner
        private void turnSwitch_Click(object sender, EventArgs e)
        {
            turnSwitch.Enabled = false; 
            computer(); //Methode für den Schwierigkeit
            if (streichholzListe.Count == 0) //Falls der Computer verloren hat
            {
                labelWon.Show();
                retry.Show();
                btnLeave.Show();
                btnNim.Hide();
                turnSwitch.Hide();
                labTurn.Hide();
            }         
            anzahlClicks = 0;
            btnNim.Enabled = true;
        }
        //Schaut welcher Schwierigkeitsgrad genommen wurde und gibt diesen weiter
        public void computer()
        {
            if (hardMode)
            {
                CompHard();
            }
            else if (easyMode)
            {
                CompEasy();
            }
            else
            {
                return;
            }
        }
        //Event für den Retrybutton, gibt Methode Retry()
        private void retry_Click(object sender, EventArgs e)
        {
            Retry();
        }
        //Methode Retry setzt alle Werte zurück
        private void Retry()
        {
            anzahlStreichhoelzer = 15;
            anzahlClicks = 0;
            btnNim.Enabled = true;
            streichhoelzerListe();

            labelLoose.Hide();
            retry.Hide();
            btnLeave.Hide();
            labelWon.Hide();

            turnSwitch.Show();
            btnNim.Show();

            labTurn.Text = "";
            labTurn.Show();
        }
        //Methode für den unmöglichen Gegner. 
        private void CompHard()
        {
            enemy = "Dolphin";
            labTurn.Text = enemy + " ist am Zug";
            int hoelzerToRemove = (streichholzListe.Count - 1) % 4; //Speichert den Rest aus der Division, so bleibt er immer im 4 Bereich

            if (streichholzListe.Count == 4) //Bedingungen um zu 100% zu Gewinnen
            {
                hoelzerToRemove = 3;
            }
            else if (streichholzListe.Count == 3)
            {
                hoelzerToRemove = 2;
            }
            else if (streichholzListe.Count == 2)
            {
                hoelzerToRemove = 1;
            }
            for (int i = hoelzerToRemove; i > 0; i--) //Schleife um die Liste und Objekte zu kürzen
            {
                PictureBox letztesStreichholz = streichholzListe[streichholzListe.Count - 1];
                streichholzListe.RemoveAt(streichholzListe.Count - 1);

                this.Controls.Remove(letztesStreichholz);
            }
        }
        //Methode für den "Einfachen" Gegner. Nimm nur Random bis auf das Ende wo er schlauere Züge macht
        private void CompEasy()
        {
            enemy = "Timmy";
            labTurn.Text = enemy + " ist am Zug";

            Random rand = new Random();
            int comClicks = rand.Next(1, 3); //Random Wert von 1 - 3
            if (streichholzListe.Count == 2) //Bedingungen für schlaueres Handeln
            {
                comClicks = rand.Next(1, 2);
            }
            else if (streichholzListe.Count == 1)
            {
                comClicks = 1;
            }
            while (comClicks > 0) //Schleife für die Liste und Hölzer
            {
                PictureBox letztesStreichholz = streichholzListe[streichholzListe.Count - 1];
                streichholzListe.RemoveAt(streichholzListe.Count - 1);

                this.Controls.Remove(letztesStreichholz);
                comClicks--;
            }
        }
        //Event, wenn man Verlassen-Button drückt
        private void btnLeave_Click(object sender, EventArgs e)
        {
            frmMain.Close(); //Schließt alle Forms
            this.Close();
        }
    }
}
