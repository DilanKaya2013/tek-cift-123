using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tek_cift_123
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {

            int toplam = 0;


            int sayi1 = Convert.ToInt32(txtSayi1.Text);
            int sayi2 = Convert.ToInt32(txtSayi2.Text);


            for (int i = sayi1; i <= sayi2; i++)
            {
                if (chkTek.Checked == true && chkCift.Checked == false)
                {
                    if (i % 2 == 1)
                    {
                        toplam += i;
                    }
                }
                else if (chkCift.Checked == true && chkTek.Checked == false)
                {
                    if (i % 2 == 0)
                    {
                        toplam += i;
                    }
                }
                else if (chkTek.Checked == true && chkCift.Checked == true)
                {
                    toplam += i;
                }
                else
                {
                    toplam = 0;
                }

            }

            txtToplam.Text = toplam.ToString();

        }

        private void txtToplam_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void chkCift_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkTek_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtSayi2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSayi1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
