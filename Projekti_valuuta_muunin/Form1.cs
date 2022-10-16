using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace valuuta_muunin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text != "") { 
            try
            {
                double euros = Convert.ToDouble(textBox6.Text);
                double GPB, JPY, SEK, RUB, USD;
                GPB = Convert.ToDouble(textBox1.Text);
                JPY = Convert.ToDouble(textBox2.Text);
                SEK = Convert.ToDouble(textBox3.Text);
                RUB = Convert.ToDouble(textBox4.Text);
                USD = Convert.ToDouble(textBox5.Text);

                textBox7.Text = Convert.ToString(euros * GPB);
                textBox8.Text = Convert.ToString(euros * JPY);
                textBox9.Text = Convert.ToString(euros * SEK);
                textBox10.Text = Convert.ToString(euros * RUB);
                textBox11.Text = Convert.ToString(euros * USD);

                } catch (FormatException)
            {
                MessageBox.Show("accept only numbers");
            }
            }
        }

    }
}
