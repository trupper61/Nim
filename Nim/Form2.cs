using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nim
{
    public partial class Form2 : Form
    {
        List<Button> listButton = new List<Button>();
        const int WIDTH = 25;
        const int HEIGHT = 50;
        int anzahlStreichhoelzer = 15;
        int anzahlClicks = 0;
        public Form2()
        {
            InitializeComponent();
            streichhoelzerListe();
        }


        private void streichhoelzerListe()
        {
            for (int i = 1; i <= anzahlStreichhoelzer; i++)
            {
                Button streichholzNeu = new Button();
                streichholzNeu.Name = "streichholz" + i.ToString();
                streichholzNeu.Width = WIDTH;
                streichholzNeu.Height = HEIGHT;
                listButton.Add(streichholzNeu);

                streichholzNeu.Top = 15;
                streichholzNeu.Left = 30 * i;
                this.Controls.Add(streichholzNeu);
            }
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnNim_Click(object sender, EventArgs e)
        {
            turnSwitch.Enabled = true;
            if (listButton.Count > 1 && anzahlClicks < 3)
            {
                anzahlClicks++;
                Button lastButton = listButton[listButton.Count - 1];
                listButton.RemoveAt(listButton.Count - 1);

                this.Controls.Remove(lastButton);

            }
            else if (listButton.Count == 1)
            {
                MessageBox.Show("Du hast verloren");
                return;
            }
            else
            {
                MessageBox.Show("Du hast keine Züge mehr");
            }
            
        }


        private void computer()
        {
            Random rand = new Random();
            int comClicks = rand.Next(1, 3);

            while (comClicks >= 0)
            {
                Button lastButton = listButton[listButton.Count - 1];
                listButton.RemoveAt(listButton.Count - 1);

                this.Controls.Remove(lastButton);
                comClicks--;
            }
            if (listButton.Count == 0)
            {
                MessageBox.Show("Du hast gewonnen");
                return;
            }
            else
            {
                return;
            }
        }

        private void turnSwitch_Click(object sender, EventArgs e)
        {
            turnSwitch.Enabled = false;
            computer();
            anzahlClicks = 0;
            btnNim.Enabled = true;
        }
    }
}
