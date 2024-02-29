namespace HaromszogGombok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 11; i++)
            {
                for(int j = 0; j < 11; j++)
                {
                    Button uj = new Button();
                    uj.Width = 20;
                    uj.Height = 20;
                    uj.Top = i*20;
                    //uj.Left = j * 20;
                    //^Háromszöges gombok fent, "karácsonyfa lent" \/
                    uj.Left = ClientRectangle.Width/2 - i * 10 + j * 20+20;
                    if (i>j)
                    {
                        Controls.Add(uj);
                    }
                    
                }
            }
        }
    }
}