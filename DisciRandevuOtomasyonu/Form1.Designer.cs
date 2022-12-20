namespace DisciRandevuOtomasyonu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnmusteri = new System.Windows.Forms.Button();
            this.btnrandevu = new System.Windows.Forms.Button();
            this.btnRandevuKayit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMusteriKayit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnmusteri
            // 
            this.btnmusteri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnmusteri.BackgroundImage")));
            this.btnmusteri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnmusteri.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnmusteri.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmusteri.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnmusteri.Location = new System.Drawing.Point(91, 304);
            this.btnmusteri.Name = "btnmusteri";
            this.btnmusteri.Size = new System.Drawing.Size(344, 72);
            this.btnmusteri.TabIndex = 0;
            this.btnmusteri.Text = "MÜŞTERİ BİLGİLERİ";
            this.btnmusteri.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmusteri.UseVisualStyleBackColor = true;
            // 
            // btnrandevu
            // 
            this.btnrandevu.BackgroundImage = global::DisciRandevuOtomasyonu.Properties.Resources.disci2;
            this.btnrandevu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnrandevu.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnrandevu.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrandevu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnrandevu.Location = new System.Drawing.Point(91, 226);
            this.btnrandevu.Name = "btnrandevu";
            this.btnrandevu.Size = new System.Drawing.Size(344, 72);
            this.btnrandevu.TabIndex = 1;
            this.btnrandevu.Text = "RANDEVU BİLGİLERİ";
            this.btnrandevu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnrandevu.UseVisualStyleBackColor = true;
            this.btnrandevu.Click += new System.EventHandler(this.btnrandevu_Click);
            // 
            // btnRandevuKayit
            // 
            this.btnRandevuKayit.BackgroundImage = global::DisciRandevuOtomasyonu.Properties.Resources.disci2;
            this.btnRandevuKayit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRandevuKayit.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnRandevuKayit.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnRandevuKayit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRandevuKayit.Location = new System.Drawing.Point(91, 148);
            this.btnRandevuKayit.Name = "btnRandevuKayit";
            this.btnRandevuKayit.Size = new System.Drawing.Size(344, 72);
            this.btnRandevuKayit.TabIndex = 2;
            this.btnRandevuKayit.Text = "RANDEVU KAYIT";
            this.btnRandevuKayit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRandevuKayit.UseVisualStyleBackColor = true;
            this.btnRandevuKayit.Click += new System.EventHandler(this.btnRandevuKayit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(333, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "DİŞÇİ OTOMASYONU";
            // 
            // btnMusteriKayit
            // 
            this.btnMusteriKayit.BackgroundImage = global::DisciRandevuOtomasyonu.Properties.Resources.disci2;
            this.btnMusteriKayit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMusteriKayit.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnMusteriKayit.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnMusteriKayit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMusteriKayit.Location = new System.Drawing.Point(91, 70);
            this.btnMusteriKayit.Name = "btnMusteriKayit";
            this.btnMusteriKayit.Size = new System.Drawing.Size(344, 72);
            this.btnMusteriKayit.TabIndex = 4;
            this.btnMusteriKayit.Text = "MÜŞTERİ KAYIT";
            this.btnMusteriKayit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMusteriKayit.UseVisualStyleBackColor = true;
            this.btnMusteriKayit.Click += new System.EventHandler(this.btnMusteriKayit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(844, 419);
            this.Controls.Add(this.btnMusteriKayit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRandevuKayit);
            this.Controls.Add(this.btnrandevu);
            this.Controls.Add(this.btnmusteri);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ANASAYFA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnmusteri;
        private System.Windows.Forms.Button btnrandevu;
        private System.Windows.Forms.Button btnRandevuKayit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMusteriKayit;
    }
}

