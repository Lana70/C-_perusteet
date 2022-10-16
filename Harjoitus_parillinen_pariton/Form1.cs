using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parillinen_pariton
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
            string parilliset = "Parilliset: ", parittomat = "Parittomat: "; 
            if (textBox1.Text != "")
            {
                try
                {
                    number = Convert.ToInt32(textBox1.Text);
                    if (number < 999)
                    {
                        
                        for (int i = 1; i <= number; i++)
                        {
                            if (i % 2 == 0)
                            {
                                parilliset = parilliset + Convert.ToString(i) + ", ";
                            } else
                            {
                                parittomat = parittomat + Convert.ToString(i) + ", ";
                            }
                        }
                        textBox2.Text = parilliset + Environment.NewLine + Environment.NewLine + parittomat;
                    }
                    else
                    {
                        MessageBox.Show("Liian iso luku");
                        textBox1.Text = "";

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
}
