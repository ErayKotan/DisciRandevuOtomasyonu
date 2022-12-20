using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisciRandevuOtomasyonu
{
    public partial class randevukayit : Form
    {
        public randevukayit()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Server=.;Database=DB_DisHekimiRandevu;Trusted_Connection=True;");
        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void BTNKAYDET_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand hastaid = new SqlCommand(" select HastaID from Hastalar where HastaTCKimlik=" + txthastatcno.Text, baglanti);
            string hasta = hastaid.ExecuteScalar().ToString();
            baglanti.Close();

            baglanti.Open();
            SqlCommand randevuekleme = new SqlCommand("INSERT INTO [dbo].[Randevular]([HastaID],[RandevuTarihi],[RandevuHastaSikayet],[RandevuAktifMi]) " +
                "VALUES (" + hasta + ",'" + dtptarih.Value.ToString("MM/dd/yyyy HH:mm:ss") + "','" + txtsikayet.Text + "','" + chcAktif2.Checked + "')", baglanti);

            randevuekleme.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Randevu Eklendi");
        }
    }
}
