using CsvHelper;
using System.ComponentModel;
using System.Globalization;

namespace Adat
{
    public partial class Form1 : Form
    {
        BindingList<CountryData> countryList = new();

        public Form1()
        {
            InitializeComponent();
            countryDataBindingSource.DataSource = countryList;
            dataGridView1.DataSource = countryDataBindingSource;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("euCountries.csv");
            var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
            var tömb = csv.GetRecords<CountryData>();
            foreach (var item in tömb)
            {
                countryList.Add(item);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            countryDataBindingSource.RemoveCurrent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormCountryData fce = new FormCountryData();
            fce.CountryData = countryDataBindingSource.Current as CountryData;
            fce.Show();

        }

        private void countryDataBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}