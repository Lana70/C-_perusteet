using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arvosanat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int number;

            try {
                if (textBox1.Text != "")
                {
                    number = Convert.ToInt16(textBox1.Text);
                    switch (number)
                    {
                        case 4:
                            textBox2.Text = "heikko";
                            break;
                        case 5:
                            textBox2.Text = "tyydyttävä";
                            break;
                        case 6:
                            textBox2.Text = "tyydyttävä";
                            break;
                        case 7:
                            textBox2.Text = "hyvää";
                            break;
                        case 8:
                            textBox2.Text = "hyvää";
                            break;
                        case 9:
                            textBox2.Text = "kiitettävä";
                            break;
                        case 10:
                            textBox2.Text = "erinomainen";
                            break;
                        default:
                            textBox2.Text = "Ei läpi";
                            break;
                    }
                } else
                {
                    textBox2.Text = "";
                }
               
            } 
            catch (Exception err)
            {
                MessageBox.Show("Syötä vain numerot, " + err.Message);
                textBox1.Text = "";
            }
        }
    }
}
