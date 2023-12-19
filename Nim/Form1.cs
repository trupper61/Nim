namespace Nim
{
    public partial class Form1 : Form
    {

        Form2 frm2;
        public static bool hardModeF2;  //Variablen weitergegebn für das Spiel
        public static bool easyModeF2;

        public Form1()
        {
            InitializeComponent();
            gameStart.Enabled = false; //Start button gesperrt
            frm2 = new Form2(this);
        }

        private void gameStart_Click(object sender, EventArgs e) //Event, versteckt dieses Fenster und öffnet Nim-Spiel
        {
            frm2.Show();
            this.Hide();
        }

        void btnEasy_Click(object sender, EventArgs e) //Auswahl von Schwierigkeitsgrad
        {
            bool hardMode = false;      
            bool easyMode = true;

            gameStart.Enabled = true;
            easyModeF2 = easyMode;

        }

        private void btnHard_Click(object sender, EventArgs e) //Auswahl von Schwierigkeitsgrad
        {
            bool hardMode = true;
            bool easyMode = false;

            gameStart.Enabled = true;
            hardModeF2 = hardMode;
        }
    }
}
