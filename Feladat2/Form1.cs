namespace Feladat2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<Elem> list = new List<Elem>();


            for (int i = 0; i < 10; i++)
            {
                //Button b = new Button();
                //b.Top = i * 30;
                //b.Text = Fibonacci(i).ToString();
                //Controls.Add(b);
                Elem elem = new Elem();
                elem.Sorszám = i;
                elem.Érték = Fibonacci(i);
                list.Add(elem);

            }
            gridView.DataSource = list;




        }
        private int Fibonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
        class Elem
        {
            public int Sorszám { get; set; }
            public long Érték { get; set; }

        }

    }
}