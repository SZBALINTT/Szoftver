namespace Kigyo
{
    public partial class Form1 : Form
    {
        int fejX = 100;
        int fejY = 100;
        int irányX = 1;
        int irányY = 0;
        int lépésszám;
        int hossz = 3;
        Random rnd = new Random();
        List<KígyóElem> kígyó = new List<KígyóElem>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            timer3.Enabled = true;
            for (int i = 0; i < Határ.pálya; i++)
            {
                Határ határ = new Határ();
                határ.Left = i * Határ.méret;
                Controls.Add(határ);
                
            }


        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            lépésszám++;

            fejX += irányX * KígyóElem.méret;
            fejY += irányY * KígyóElem.méret;

            KígyóElem KE = new KígyóElem();
            KE.Top = fejY;
            KE.Left = fejX;

            foreach (object item in Controls)
            {
                if (item is KígyóElem)
                {
                    KígyóElem k = (KígyóElem)item;
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
            if (lépésszám % 2 != 0)
            {
                KE.BackColor = Color.Yellow;
            }
            kígyó.Add(KE);
            Controls.Add(KE);


            if (kígyó.Count > hossz)
            {
                KígyóElem levágandó = kígyó[0];
                kígyó.RemoveAt(0);
                Controls.Remove(levágandó);
            }



        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                irányY = -1;
                irányX = 0;

            }
            if (e.KeyCode == Keys.Down)
            {
                irányY = 1;
                irányX = 0;

            }
            if (e.KeyCode == Keys.Left)
            {
                irányY = 0;
                irányX = -1;

            }
            if (e.KeyCode == Keys.Right)
            {
                irányY = 0;
                irányX = 1;

            }

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            Alma alma = new Alma();
            alma.Top = rnd.Next(0,10)*KígyóElem.méret;
            alma.Left = rnd.Next(0, 10)*KígyóElem.méret;
            Controls.Add(alma);
            
        }
    }
}