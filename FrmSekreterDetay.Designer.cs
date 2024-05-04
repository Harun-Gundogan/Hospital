namespace Hastane_Otomasyonu
{
    partial class FrmSekreterDetay
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.rtxtDuyuru = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnAnamenu = new System.Windows.Forms.Button();
            this.btnDuyuru = new System.Windows.Forms.Button();
            this.btnRandevuListele = new System.Windows.Forms.Button();
            this.btnBransPaneli = new System.Windows.Forms.Button();
            this.btnDoktorPaneli = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.txtTarih = new System.Windows.Forms.DateTimePicker();
            this.cmbDoktor = new System.Windows.Forms.ComboBox();
            this.cmbBrans = new System.Windows.Forms.ComboBox();
            this.mtxtSaat = new System.Windows.Forms.MaskedTextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataBrans = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dataDoktor = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBrans)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDoktor)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblTC);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(276, 178);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sekreter Bilgi";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(128, 120);
            this.lblAd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(59, 24);
            this.lblAd.TabIndex = 3;
            this.lblAd.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ad Soyad:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Location = new System.Drawing.Point(128, 51);
            this.lblTC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(120, 24);
            this.lblTC.TabIndex = 1;
            this.lblTC.Text = "00000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC Kimlik No:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnOlustur);
            this.groupBox2.Controls.Add(this.rtxtDuyuru);
            this.groupBox2.Location = new System.Drawing.Point(10, 206);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(276, 267);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Duyuru Oluştur";
            // 
            // btnOlustur
            // 
            this.btnOlustur.Location = new System.Drawing.Point(179, 224);
            this.btnOlustur.Margin = new System.Windows.Forms.Padding(4);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(88, 32);
            this.btnOlustur.TabIndex = 2;
            this.btnOlustur.Text = "Oluştur";
            this.btnOlustur.UseVisualStyleBackColor = true;
            this.btnOlustur.Click += new System.EventHandler(this.BtnOlustur_Click);
            // 
            // rtxtDuyuru
            // 
            this.rtxtDuyuru.Location = new System.Drawing.Point(8, 32);
            this.rtxtDuyuru.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtDuyuru.Name = "rtxtDuyuru";
            this.rtxtDuyuru.Size = new System.Drawing.Size(260, 184);
            this.rtxtDuyuru.TabIndex = 1;
            this.rtxtDuyuru.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCikis);
            this.groupBox3.Controls.Add(this.btnAnamenu);
            this.groupBox3.Controls.Add(this.btnDuyuru);
            this.groupBox3.Controls.Add(this.btnRandevuListele);
            this.groupBox3.Controls.Add(this.btnBransPaneli);
            this.groupBox3.Controls.Add(this.btnDoktorPaneli);
            this.groupBox3.Location = new System.Drawing.Point(10, 482);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(554, 160);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hızlı Erişim";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(271, 94);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(4);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(108, 56);
            this.btnCikis.TabIndex = 8;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
            // 
            // btnAnamenu
            // 
            this.btnAnamenu.Location = new System.Drawing.Point(271, 30);
            this.btnAnamenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnamenu.Name = "btnAnamenu";
            this.btnAnamenu.Size = new System.Drawing.Size(108, 56);
            this.btnAnamenu.TabIndex = 7;
            this.btnAnamenu.Text = "Ana Menü";
            this.btnAnamenu.UseVisualStyleBackColor = true;
            this.btnAnamenu.Click += new System.EventHandler(this.BtnAnamenu_Click);
            // 
            // btnDuyuru
            // 
            this.btnDuyuru.Location = new System.Drawing.Point(139, 94);
            this.btnDuyuru.Margin = new System.Windows.Forms.Padding(4);
            this.btnDuyuru.Name = "btnDuyuru";
            this.btnDuyuru.Size = new System.Drawing.Size(108, 56);
            this.btnDuyuru.TabIndex = 6;
            this.btnDuyuru.Text = "Duyurular";
            this.btnDuyuru.UseVisualStyleBackColor = true;
            this.btnDuyuru.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRandevuListele
            // 
            this.btnRandevuListele.Location = new System.Drawing.Point(139, 30);
            this.btnRandevuListele.Margin = new System.Windows.Forms.Padding(4);
            this.btnRandevuListele.Name = "btnRandevuListele";
            this.btnRandevuListele.Size = new System.Drawing.Size(108, 56);
            this.btnRandevuListele.TabIndex = 5;
            this.btnRandevuListele.Text = "Randevu Listele";
            this.btnRandevuListele.UseVisualStyleBackColor = true;
            this.btnRandevuListele.Click += new System.EventHandler(this.BtnRandevuListele_Click);
            // 
            // btnBransPaneli
            // 
            this.btnBransPaneli.Location = new System.Drawing.Point(12, 94);
            this.btnBransPaneli.Margin = new System.Windows.Forms.Padding(4);
            this.btnBransPaneli.Name = "btnBransPaneli";
            this.btnBransPaneli.Size = new System.Drawing.Size(108, 56);
            this.btnBransPaneli.TabIndex = 4;
            this.btnBransPaneli.Text = "Branş Paneli";
            this.btnBransPaneli.UseVisualStyleBackColor = true;
            this.btnBransPaneli.Click += new System.EventHandler(this.BtnBransPaneli_Click);
            // 
            // btnDoktorPaneli
            // 
            this.btnDoktorPaneli.Location = new System.Drawing.Point(12, 30);
            this.btnDoktorPaneli.Margin = new System.Windows.Forms.Padding(4);
            this.btnDoktorPaneli.Name = "btnDoktorPaneli";
            this.btnDoktorPaneli.Size = new System.Drawing.Size(108, 56);
            this.btnDoktorPaneli.TabIndex = 3;
            this.btnDoktorPaneli.Text = "Doktor Paneli";
            this.btnDoktorPaneli.UseVisualStyleBackColor = true;
            this.btnDoktorPaneli.Click += new System.EventHandler(this.BtnDoktorPaneli_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblInfo);
            this.groupBox4.Controls.Add(this.txtTarih);
            this.groupBox4.Controls.Add(this.cmbDoktor);
            this.groupBox4.Controls.Add(this.cmbBrans);
            this.groupBox4.Controls.Add(this.mtxtSaat);
            this.groupBox4.Controls.Add(this.btnKaydet);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(294, 18);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(270, 455);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Randevu Paneli";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(82, 239);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(64, 24);
            this.lblInfo.TabIndex = 14;
            this.lblInfo.Text = "lblInfo";
            this.lblInfo.Visible = false;
            // 
            // txtTarih
            // 
            this.txtTarih.Location = new System.Drawing.Point(86, 45);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Size = new System.Drawing.Size(166, 32);
            this.txtTarih.TabIndex = 9;
            // 
            // cmbDoktor
            // 
            this.cmbDoktor.FormattingEnabled = true;
            this.cmbDoktor.Location = new System.Drawing.Point(86, 195);
            this.cmbDoktor.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDoktor.Name = "cmbDoktor";
            this.cmbDoktor.Size = new System.Drawing.Size(166, 32);
            this.cmbDoktor.TabIndex = 12;
            this.cmbDoktor.SelectedIndexChanged += new System.EventHandler(this.CmbDoktor_SelectedIndexChanged);
            // 
            // cmbBrans
            // 
            this.cmbBrans.FormattingEnabled = true;
            this.cmbBrans.Location = new System.Drawing.Point(86, 146);
            this.cmbBrans.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBrans.Name = "cmbBrans";
            this.cmbBrans.Size = new System.Drawing.Size(166, 32);
            this.cmbBrans.TabIndex = 11;
            this.cmbBrans.SelectedIndexChanged += new System.EventHandler(this.CmbBrans_SelectedIndexChanged);
            // 
            // mtxtSaat
            // 
            this.mtxtSaat.Location = new System.Drawing.Point(86, 95);
            this.mtxtSaat.Margin = new System.Windows.Forms.Padding(4);
            this.mtxtSaat.Mask = "00:00";
            this.mtxtSaat.Name = "mtxtSaat";
            this.mtxtSaat.Size = new System.Drawing.Size(166, 32);
            this.mtxtSaat.TabIndex = 10;
            this.mtxtSaat.ValidatingType = typeof(System.DateTime);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(164, 239);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(88, 32);
            this.btnKaydet.TabIndex = 13;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 203);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 24);
            this.label10.TabIndex = 4;
            this.label10.Text = "Doktor:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 154);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 24);
            this.label9.TabIndex = 3;
            this.label9.Text = "Branş:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 103);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 24);
            this.label8.TabIndex = 2;
            this.label8.Text = "Saat:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 51);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tarih:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataBrans);
            this.groupBox5.Location = new System.Drawing.Point(572, 18);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(412, 214);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Branşlar";
            // 
            // dataBrans
            // 
            this.dataBrans.AllowUserToAddRows = false;
            this.dataBrans.AllowUserToDeleteRows = false;
            this.dataBrans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataBrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBrans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataBrans.Location = new System.Drawing.Point(4, 29);
            this.dataBrans.Margin = new System.Windows.Forms.Padding(4);
            this.dataBrans.Name = "dataBrans";
            this.dataBrans.ReadOnly = true;
            this.dataBrans.RowHeadersWidth = 51;
            this.dataBrans.RowTemplate.Height = 24;
            this.dataBrans.Size = new System.Drawing.Size(404, 181);
            this.dataBrans.TabIndex = 14;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dataDoktor);
            this.groupBox6.Location = new System.Drawing.Point(572, 242);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(412, 416);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Doktorlar";
            // 
            // dataDoktor
            // 
            this.dataDoktor.AllowUserToAddRows = false;
            this.dataDoktor.AllowUserToDeleteRows = false;
            this.dataDoktor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataDoktor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDoktor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataDoktor.Location = new System.Drawing.Point(4, 29);
            this.dataDoktor.Margin = new System.Windows.Forms.Padding(4);
            this.dataDoktor.Name = "dataDoktor";
            this.dataDoktor.ReadOnly = true;
            this.dataDoktor.RowHeadersWidth = 51;
            this.dataDoktor.RowTemplate.Height = 24;
            this.dataDoktor.Size = new System.Drawing.Size(404, 383);
            this.dataDoktor.TabIndex = 15;
            // 
            // FrmSekreterDetay
            // 
            this.AcceptButton = this.btnAnamenu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1000, 675);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmSekreterDetay";
            this.Text = "FrmSekreterDetay";
            this.Load += new System.EventHandler(this.FrmSekreterDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataBrans)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataDoktor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.RichTextBox rtxtDuyuru;
        private System.Windows.Forms.Button btnRandevuListele;
        private System.Windows.Forms.Button btnBransPaneli;
        private System.Windows.Forms.Button btnDoktorPaneli;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mtxtSaat;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DataGridView dataBrans;
        private System.Windows.Forms.DataGridView dataDoktor;
        private System.Windows.Forms.ComboBox cmbDoktor;
        private System.Windows.Forms.ComboBox cmbBrans;
        private System.Windows.Forms.Button btnDuyuru;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnAnamenu;
        private System.Windows.Forms.DateTimePicker txtTarih;
        private System.Windows.Forms.Label lblInfo;
    }
}