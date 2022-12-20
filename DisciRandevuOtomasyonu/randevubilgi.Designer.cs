namespace DisciRandevuOtomasyonu
{
    partial class randevubilgi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(randevubilgi));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Soyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RandevuTarihi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sikayet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btntcNOara = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txttcnoara = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chcAktifHayir = new System.Windows.Forms.CheckBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtYapilanislem = new System.Windows.Forms.TextBox();
            this.txtaciklama = new System.Windows.Forms.TextBox();
            this.dtpsonrakirandevu = new System.Windows.Forms.DateTimePicker();
            this.txtrecete = new System.Windows.Forms.TextBox();
            this.txtepikriz = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chcAktif2 = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAnasayfa = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.Ad,
            this.Soyad,
            this.RandevuTarihi,
            this.Sikayet});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(576, 180);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // Ad
            // 
            this.Ad.Text = "Ad";
            this.Ad.Width = 113;
            // 
            // Soyad
            // 
            this.Soyad.Text = "Soyad";
            this.Soyad.Width = 102;
            // 
            // RandevuTarihi
            // 
            this.RandevuTarihi.Text = "RandevuTarihi";
            this.RandevuTarihi.Width = 145;
            // 
            // Sikayet
            // 
            this.Sikayet.Text = "Şikayet";
            this.Sikayet.Width = 152;
            // 
            // btntcNOara
            // 
            this.btntcNOara.BackColor = System.Drawing.Color.Brown;
            this.btntcNOara.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold);
            this.btntcNOara.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btntcNOara.Location = new System.Drawing.Point(235, 239);
            this.btntcNOara.Name = "btntcNOara";
            this.btntcNOara.Size = new System.Drawing.Size(100, 34);
            this.btntcNOara.TabIndex = 4;
            this.btntcNOara.Text = "ARA";
            this.btntcNOara.UseVisualStyleBackColor = false;
            this.btntcNOara.Click += new System.EventHandler(this.btntcNOara_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "TCNO GÖRE ARA:";
            // 
            // txttcnoara
            // 
            this.txttcnoara.Location = new System.Drawing.Point(222, 213);
            this.txttcnoara.Name = "txttcnoara";
            this.txttcnoara.Size = new System.Drawing.Size(128, 20);
            this.txttcnoara.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.chcAktifHayir);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.txtYapilanislem);
            this.groupBox1.Controls.Add(this.txtaciklama);
            this.groupBox1.Controls.Add(this.dtpsonrakirandevu);
            this.groupBox1.Controls.Add(this.txtrecete);
            this.groupBox1.Controls.Add(this.txtepikriz);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.chcAktif2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(26, 290);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 183);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BİLGİ";
            // 
            // chcAktifHayir
            // 
            this.chcAktifHayir.AutoSize = true;
            this.chcAktifHayir.Location = new System.Drawing.Point(338, 126);
            this.chcAktifHayir.Name = "chcAktifHayir";
            this.chcAktifHayir.Size = new System.Drawing.Size(50, 17);
            this.chcAktifHayir.TabIndex = 28;
            this.chcAktifHayir.Text = "Hayır";
            this.chcAktifHayir.UseVisualStyleBackColor = true;
            this.chcAktifHayir.CheckedChanged += new System.EventHandler(this.chcAktifHayir_CheckedChanged);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.Brown;
            this.btnKaydet.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnKaydet.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnKaydet.Location = new System.Drawing.Point(395, 135);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(100, 34);
            this.btnKaydet.TabIndex = 9;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtYapilanislem
            // 
            this.txtYapilanislem.Location = new System.Drawing.Point(386, 80);
            this.txtYapilanislem.Multiline = true;
            this.txtYapilanislem.Name = "txtYapilanislem";
            this.txtYapilanislem.Size = new System.Drawing.Size(128, 39);
            this.txtYapilanislem.TabIndex = 27;
            // 
            // txtaciklama
            // 
            this.txtaciklama.Location = new System.Drawing.Point(386, 29);
            this.txtaciklama.Multiline = true;
            this.txtaciklama.Name = "txtaciklama";
            this.txtaciklama.Size = new System.Drawing.Size(128, 44);
            this.txtaciklama.TabIndex = 26;
            // 
            // dtpsonrakirandevu
            // 
            this.dtpsonrakirandevu.Location = new System.Drawing.Point(227, 149);
            this.dtpsonrakirandevu.Name = "dtpsonrakirandevu";
            this.dtpsonrakirandevu.Size = new System.Drawing.Size(146, 20);
            this.dtpsonrakirandevu.TabIndex = 25;
            this.dtpsonrakirandevu.Visible = false;
            // 
            // txtrecete
            // 
            this.txtrecete.Location = new System.Drawing.Point(93, 79);
            this.txtrecete.Multiline = true;
            this.txtrecete.Name = "txtrecete";
            this.txtrecete.Size = new System.Drawing.Size(128, 40);
            this.txtrecete.TabIndex = 24;
            // 
            // txtepikriz
            // 
            this.txtepikriz.Location = new System.Drawing.Point(93, 30);
            this.txtepikriz.Multiline = true;
            this.txtepikriz.Name = "txtepikriz";
            this.txtepikriz.Size = new System.Drawing.Size(128, 43);
            this.txtepikriz.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Javanese Text", 9F);
            this.label6.Location = new System.Drawing.Point(277, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 27);
            this.label6.TabIndex = 23;
            this.label6.Text = "YAPILAN İŞLEM :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Javanese Text", 9F);
            this.label5.Location = new System.Drawing.Point(305, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 27);
            this.label5.TabIndex = 22;
            this.label5.Text = "AÇIKLAMA :";
            // 
            // chcAktif2
            // 
            this.chcAktif2.AutoSize = true;
            this.chcAktif2.Location = new System.Drawing.Point(284, 125);
            this.chcAktif2.Name = "chcAktif2";
            this.chcAktif2.Size = new System.Drawing.Size(48, 17);
            this.chcAktif2.TabIndex = 21;
            this.chcAktif2.Text = "Evet";
            this.chcAktif2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Javanese Text", 9F);
            this.label9.Location = new System.Drawing.Point(167, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 27);
            this.label9.TabIndex = 20;
            this.label9.Text = "TEDAVİ BİTTİ Mİ :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Javanese Text", 9F);
            this.label4.Location = new System.Drawing.Point(47, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 27);
            this.label4.TabIndex = 2;
            this.label4.Text = "SONRAKİ RANDEVU TARİHİ :";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Javanese Text", 9F);
            this.label3.Location = new System.Drawing.Point(23, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 27);
            this.label3.TabIndex = 1;
            this.label3.Text = "REÇETE :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Javanese Text", 9F);
            this.label2.Location = new System.Drawing.Point(23, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "EKİPRİZ :";
            // 
            // btnAnasayfa
            // 
            this.btnAnasayfa.BackColor = System.Drawing.Color.Brown;
            this.btnAnasayfa.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnAnasayfa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAnasayfa.Location = new System.Drawing.Point(671, 439);
            this.btnAnasayfa.Name = "btnAnasayfa";
            this.btnAnasayfa.Size = new System.Drawing.Size(187, 34);
            this.btnAnasayfa.TabIndex = 8;
            this.btnAnasayfa.Text = "ANASAYFAYA GİT";
            this.btnAnasayfa.UseVisualStyleBackColor = false;
            this.btnAnasayfa.Click += new System.EventHandler(this.btnAnasayfa_Click);
            // 
            // randevubilgi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(870, 485);
            this.Controls.Add(this.btnAnasayfa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txttcnoara);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btntcNOara);
            this.Controls.Add(this.listView1);
            this.Name = "randevubilgi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "randevubilgi";
            this.Load += new System.EventHandler(this.randevubilgi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btntcNOara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttcnoara;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAnasayfa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chcAktif2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtrecete;
        private System.Windows.Forms.TextBox txtepikriz;
        private System.Windows.Forms.TextBox txtYapilanislem;
        private System.Windows.Forms.TextBox txtaciklama;
        private System.Windows.Forms.DateTimePicker dtpsonrakirandevu;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ColumnHeader Ad;
        private System.Windows.Forms.ColumnHeader Soyad;
        private System.Windows.Forms.ColumnHeader RandevuTarihi;
        private System.Windows.Forms.ColumnHeader Sikayet;
        private System.Windows.Forms.CheckBox chcAktifHayir;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}