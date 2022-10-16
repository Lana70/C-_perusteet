using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kolmion_pintaala
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PalautaNimet();
        }
        
        public static double KolmionPintaAla(double kanta, double korkeus)
        {
            // Kaava: A=ah/2
            double res;      
            res = (kanta * korkeus) / 2.0;          
            return res;
        }

        public void PalautaNimet()
        {
            label1.Text = "Kanta (a)";
            label2.Text = "Korkeus (h)";
            textBox3.Text = "Pinta-ala lasketaan kaavalla: A=ah/2" + Environment.NewLine + Environment.NewLine;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string yksikkö = textBox4.Text;
            double kanta, korkeus, A;
            kanta = Convert.ToDouble(textBox1.Text);
            korkeus = Convert.ToDouble(textBox2.Text);
            label1.Text = label1.Text + "=" + kanta.ToString() + yksikkö;
            label2.Text = label2.Text + "=" + korkeus.ToString() + yksikkö;
            A = KolmionPintaAla(kanta, korkeus);
            
            textBox3.Text = "Pinta-ala on = " + A.ToString() + " " +yksikkö +"^2";
        }



        private void textBox1_TextChanged(object sender, EventArgs e) 
        {
            PalautaNimet();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            PalautaNimet();
        }
    }
}
