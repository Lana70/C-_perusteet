using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ikä_tehtävä
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string num = textBox1.Text;
            if (num != "")
            {
                textBox2.Text = $"Olet {num} vuotta";

            }
            else
            {
                textBox2.Text = "";
            }
        }


    }
}
