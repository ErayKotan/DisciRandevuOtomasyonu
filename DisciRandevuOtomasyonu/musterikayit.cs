using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisciRandevuOtomasyonu
{
    public partial class musterikayit : Form
    {
        public musterikayit()
        {
            InitializeComponent();
        }
        SqlConnection baglanti=new SqlConnection("Server=.;Database=DB_DisHekimiRandevu;Trusted_Connection=True;");
        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
        List<KeyValuePair<int,string>>illistesi =new List<KeyValuePair<int,string>>();
        List<KeyValuePair<int, string>> ilcelistesi = new List<KeyValuePair<int, string>>();
        List<KeyValuePair<int, string>> cinsiyetlistesi = new List<KeyValuePair<int, string>>();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand hastakayıtkomutu = new SqlCommand("INSERT INTO[dbo].[Hastalar]([HastaAd],[HastaSoyad],[HastaTelefon],[HastaEposta],[HastaTCKimlik],[HastaAdres],[ilID],[ilceID],[cinsiyetID],[HastaAktifMi],[HastaAciklama],[HastaKanGrubu])" +
                "VALUES('" +txthastaad.Text + "', '" +txtHastaSoyad.Text + "', '" +txtTelefon.Text + "', '"+txtEposta.Text +"', '"+txtTCNo.Text +"', '"+txtAdres.Text +"', "+cmbil.SelectedValue+", "+cmbilce.SelectedValue+", "+cmbcinsiyet.SelectedValue+", '"+chcAktif.Checked+"', '"+txtAciklama.Text +"', '"+txtKanGrubu.Text+"')", baglanti);
            baglanti.Open();
            hastakayıtkomutu.ExecuteNonQuery();
            MessageBox.Show("Kayıt Başarılı :)");
            baglanti.Close();

        }

        private void musterikayit_Load(object sender, EventArgs e)
        {
            SqlCommand iller = new SqlCommand("select * from tbl_Il", baglanti);
            baglanti.Open();
            SqlDataReader dr = iller.ExecuteReader();
            while (dr.Read())
            {
                illistesi.Add(new KeyValuePair<int, string>((int)dr[0], (string)dr[1]));
            }
            cmbil.DataSource = illistesi.ToList();
            cmbil.ValueMember = "Key";
            cmbil.DisplayMember = "Value";
            baglanti.Close();

            ////////////////////
       

            ////////////////

            SqlCommand cinsiyet = new SqlCommand("select * from tbl_Cinsiyet", baglanti);
            baglanti.Open();
            SqlDataReader dr2 = cinsiyet.ExecuteReader();
            while (dr2.Read())
            {
                cinsiyetlistesi.Add(new KeyValuePair<int, string>((int)dr2[0], (string)dr2[1]));
            }
            cmbcinsiyet.DataSource = cinsiyetlistesi.ToList();
            cmbcinsiyet.ValueMember = "Key";
            cmbcinsiyet.DisplayMember = "Value";
            baglanti.Close();
        }

        private void cmbil_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SqlCommand ilceler = new SqlCommand("select * from tbl_Ilce where IlId=" + cmbil.SelectedValue, baglanti);
            baglanti.Open();
            SqlDataReader dr1 = ilceler.ExecuteReader();
            while (dr1.Read())
            {
                ilcelistesi.Add(new KeyValuePair<int, string>((int)dr1[0], (string)dr1[1]));
            }
            cmbilce.DataSource = ilcelistesi.ToList();
            cmbilce.ValueMember = "Key";
            cmbilce.DisplayMember = "Value";
            baglanti.Close();
        }
    }
}
