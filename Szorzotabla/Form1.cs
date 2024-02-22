namespace Szorzotabla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();





        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 11; i++)
            {
                for (int y = 1; y < 11; y++)
                {
                    Button b = new Button();
                    b.Text = (i*y).ToString();
                    b.Left = 100*i;
                    b.Top = 100*y;

                    Controls.Add(b);
                }
            }


            




        }
    }
}