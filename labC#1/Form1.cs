using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace labC_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Quadrangle quadrangle;

            double aab, bbc, ccd, aad;

            try
            {
                aab = Convert.ToDouble(ab.Text);
                bbc = Convert.ToDouble(bc.Text);
                ccd = Convert.ToDouble(cd.Text);
                aad = Convert.ToDouble(ad.Text);

                quadrangle = new Quadrangle(aab, bbc, ccd, aad);

                label1.Text = quadrangle.Perevirka1();

            }
            catch
            {
                MessageBox.Show("Дані введені невірно");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Quadrangle quadrangle;

            double kyt11, kyt22;

            try
            {
                kyt11 = Convert.ToDouble(kyt1.Text);
                kyt22 = Convert.ToDouble(kyt2.Text);
                quadrangle = new Quadrangle(kyt11, kyt22);

                label2.Text = quadrangle.Perevirka2();
            }
            catch
            {
                MessageBox.Show("Дані введені невірно");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Quadrangle quadrangle;

            double aab, bbc, ccd, aad;

            try
            {
             quadrangle = new Quadrangle();


                aab = quadrangle.ab;
                bbc = quadrangle.bc;
                ccd = quadrangle.cd;
                aad = quadrangle.ad;

                ab.Text = Convert.ToString(aab);
                bc.Text = Convert.ToString(bbc);
                cd.Text = Convert.ToString(ccd);
                ad.Text = Convert.ToString(aad);

                label1.Text = quadrangle.Perevirka1();
            
            }
            catch
            {
                MessageBox.Show("Дані введені невірно");
            }
        }
    }
}
