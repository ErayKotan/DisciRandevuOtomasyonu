using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DisciRandevuOtomasyonu
{
    public partial class randevubilgi : Form
    {
        public randevubilgi()
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
        
        private void randevubilgi_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sorgu = new SqlCommand("select r.RandevuID,h.HastaAd,h.HastaSoyad,r.RandevuTarihi,r.RandevuHastaSikayet from Randevular as r join Hastalar as h ON r.HastaID=h.HastaID", baglanti);
            SqlDataReader dr=sorgu.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem lw=new ListViewItem(dr[0].ToString());
                lw.SubItems.Add(dr[1].ToString());
                lw.SubItems.Add(dr[2].ToString());
                lw.SubItems.Add(dr[3].ToString());
                lw.SubItems.Add(dr[4].ToString());
                listView1.Items.Add(lw);

            }
            baglanti.Close();

        }

        private void btntcNOara_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand sorgu = new SqlCommand("select h.HastaID,h.HastaAd,h.HastaSoyad,r.RandevuTarihi,r.RandevuHastaSikayet from Randevular as r " +
                "join Hastalar as h ON r.HastaID=h.HastaID where HastaTCKimlik=" + txttcnoara.Text, baglanti);
            SqlDataReader dr = sorgu.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem lw = new ListViewItem(dr[0].ToString());
                lw.SubItems.Add(dr[1].ToString());
                lw.SubItems.Add(dr[2].ToString());
                lw.SubItems.Add(dr[3].ToString());
                lw.SubItems.Add(dr[4].ToString());
                listView1.Items.Add(lw);

            }
            baglanti.Close();

        }

        private void chcAktifHayir_CheckedChanged(object sender, EventArgs e)
        {
            label4.Visible = true;
            dtpsonrakirandevu.Visible = true;


        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

           

            if (chcAktif2.Checked)
            {
                baglanti.Open();
                SqlCommand bilgiekleme = new SqlCommand("update Randevular set RandevuEpikriz='"+txtepikriz.Text+"',randevurecete='"+txtrecete.Text+"',RandevuOkMi='1',RandevuAciklama='"+txtaciklama.Text+"',RandevuYapilanislem='"+txtYapilanislem.Text+"' where RandevuID='"+ listView1.SelectedItems[0].SubItems[0].Text + "'", baglanti);
                bilgiekleme.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Bilgiler Eklendi");
            }

            

            
            
        }
    }
}
