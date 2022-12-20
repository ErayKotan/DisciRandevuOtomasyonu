using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisciRandevuOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMusteriKayit_Click(object sender, EventArgs e)
        {
            musterikayit form2 = new musterikayit();
            form2.Show(); 
            this.Hide();
        }

        private void btnRandevuKayit_Click(object sender, EventArgs e)
        {
            randevukayit form3 = new randevukayit();
            form3.Show();
            this.Hide();
        }

        private void btnrandevu_Click(object sender, EventArgs e)
        {
            randevubilgi form4 = new randevubilgi();
            form4.Show();
            this.Hide();
        }
    }
}
