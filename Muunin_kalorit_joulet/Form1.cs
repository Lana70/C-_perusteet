using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalorit_jouleiksi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.LaskeKalorit();
            this.LaskeJoulet();
        }
        private void LaskeKalorit()
        {
            double joulet = 0;
            try
            {
                joulet = Convert.ToDouble(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("Vain numerot");
                textBox2.Text = 0.ToString();
            }
            if (joulet > 0)
            {
                double res = joulet * 0.2390;
                textBox4.Text = res.ToString() + " kcal";
            }
        }
        private void LaskeJoulet()
        {
            double kalorit = 0;
            try
            {
                kalorit = Convert.ToDouble(textBox1.Text);
            } catch 
            {
                MessageBox.Show("Vain numerot");
                textBox1.Text = 0.ToString();
            }
            if (kalorit>0)
            {
                double res = kalorit * 4.184;
                textBox3.Text = res.ToString() + " J";
            }
        }
    }
}
