namespace RandomGombok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        Random rnd = new Random();


        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 101; i++)
            {
                Button uj = new Button();
                uj.Left = rnd.Next(ClientRectangle.Width);
                uj.Top = rnd.Next(ClientRectangle.Height);
                uj.Width = rnd.Next(ClientRectangle.Width);
                uj.Height = rnd.Next(ClientRectangle.Height);
                uj.BackColor = Color.FromArgb(rnd.Next(256),rnd.Next(256),rnd.Next(256));
                Controls.Add(uj);
            }
        }
    }
}