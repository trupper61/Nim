namespace Nim
{
    public partial class Form1 : Form
    {
        Form2 view;


        public Form1()
        {
            InitializeComponent();
            view = new Form2();
        }

        private void gameStart_Click(object sender, EventArgs e)
        {
            view.Show();
            this.Hide();
        }
    }
}
