﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bensa_laskuri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void SetOletus()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            int matka = Convert.ToInt32(textBox1.Text);
            double kulutus = Convert.ToDouble(textBox2.Text.Replace(".",","));
            double hinta = Convert.ToDouble(textBox3.Text.Replace(".", ","));
            
            double kustannukset = matka / 100 * kulutus * hinta;
            textBox4.Text = kustannukset.ToString() + " euroa";
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message );
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetOletus();
        }
    }
}
