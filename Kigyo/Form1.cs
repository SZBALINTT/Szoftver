namespace Kigyo
{
    public partial class Form1 : Form
    {
        int fejX = 100;
        int fejY = 100;
        int ir�nyX = 1;
        int ir�nyY = 0;
        int l�p�ssz�m;
        int hossz = 3;
        Random rnd = new Random();
        List<K�gy�Elem> k�gy� = new List<K�gy�Elem>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            timer3.Enabled = true;
            for (int i = 0; i < Hat�r.p�lya; i++)
            {
                Hat�r hat�r = new Hat�r();
                hat�r.Left = i * Hat�r.m�ret;
                Controls.Add(hat�r);
                
            }


        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            l�p�ssz�m++;

            fejX += ir�nyX * K�gy�Elem.m�ret;
            fejY += ir�nyY * K�gy�Elem.m�ret;

            K�gy�Elem KE = new K�gy�Elem();
            KE.Top = fejY;
            KE.Left = fejX;

            foreach (object item in Controls)
            {
                if (item is K�gy�Elem)
                {
                    K�gy�Elem k = (K�gy�Elem)item;
                    if (k.Top == fejY && k.Left == fejX)
                    {
                        timer2.Enabled = false;
                        timer3.Enabled = false;
                        return;
                    }
                }
                
                    if (item is Alma)
                    {
                        Alma a = (Alma)item;
                        if (a.Top == fejY && a.Left == fejX)
                        {
                        hossz++;
                        Controls.Remove(a);
                        }
                    }
                


            }
            if (l�p�ssz�m % 2 != 0)
            {
                KE.BackColor = Color.Yellow;
            }
            k�gy�.Add(KE);
            Controls.Add(KE);


            if (k�gy�.Count > hossz)
            {
                K�gy�Elem lev�gand� = k�gy�[0];
                k�gy�.RemoveAt(0);
                Controls.Remove(lev�gand�);
            }



        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                ir�nyY = -1;
                ir�nyX = 0;

            }
            if (e.KeyCode == Keys.Down)
            {
                ir�nyY = 1;
                ir�nyX = 0;

            }
            if (e.KeyCode == Keys.Left)
            {
                ir�nyY = 0;
                ir�nyX = -1;

            }
            if (e.KeyCode == Keys.Right)
            {
                ir�nyY = 0;
                ir�nyX = 1;

            }

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            Alma alma = new Alma();
            alma.Top = rnd.Next(0,10)*K�gy�Elem.m�ret;
            alma.Left = rnd.Next(0, 10)*K�gy�Elem.m�ret;
            Controls.Add(alma);
            
        }
    }
}