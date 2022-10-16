using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tulosta_luvut
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number;
            textBox2.Text = "";
            try
            {
                number = Convert.ToInt32(textBox1.Text);
                if (number < 500)
                {
                    for (int i = 1; i <= number; i++)
                    {
                        textBox2.Text = textBox2.Text + Convert.ToString(i) + ",";
                    }
                } else
                {
                    MessageBox.Show("Käytä pitnempiä lukuja! Muuten for-loop kestää");
                }
            } 
            catch (Exception err)
            {
                MessageBox.Show("Vain lukuja! " + err.Message);
                textBox1.Text = "";
            }
        }
    }
}
