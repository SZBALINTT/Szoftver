﻿using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adat
{
    public partial class FormCountryData : Form
    {
        public CountryData CountryData;

        public FormCountryData()
        {
            InitializeComponent();
        }

        private void FormCountryEdit_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void FormCountryData_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = CountryData;
        }
    }
}
