namespace Pascalharomszog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for (int sor = 0; sor < 10; sor++)
            {
                for (int oszlop = 0; oszlop <= 10; oszlop++)
                {
                    Button b = new Button();


                    b.Left = ClientRectangle.Width + oszlop * 60 - sor * 30;     
                    b.Top = sor * 60;
                    
                    b.Height = 60;
                    b.Width = 60;
                    if (oszlop<=sor)
                    {
                        this.Controls.Add(b);
                        int p = Faktorialis(sor) / (Faktorialis(oszlop) * (Faktorialis(sor - oszlop)));
                        b.Text = p.ToString();
                    }
                    
                }
            }
        }

        int Faktorialis(int n)
        {
            int eredmeny = 1;
            for (int i = 1; i <= n; i++) eredmeny *= i;

            return eredmeny;
        }



    
    }
}