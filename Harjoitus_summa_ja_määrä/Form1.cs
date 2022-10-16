using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checkbox_maara_summa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sum = 0;
            int counter = 0;
          
            foreach (Control check in this.Controls)
            {
                if (check.GetType() == typeof(CheckBox) && ((CheckBox)check).Checked)
                {
                    counter += 1;
                    sum += Convert.ToDouble(check.Text);
                }
            }
            textBox2.Text = sum.ToString();
            textBox1.Text = Convert.ToString(counter);

        }
    }
}
