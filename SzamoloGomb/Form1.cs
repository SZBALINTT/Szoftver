using System.Text.Json.Serialization;

namespace SzamoloGomb
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
                for (int j = 1; j < 11; j++)
                {
                        SzamoloGomb uj = new SzamoloGomb();
                    uj.Width = 100;
                    uj.Height = 50;
                        uj.Top = i*50;
                        uj.Left = j*100;
                    Controls.Add(uj);
                }
            }
        }
    }
}