﻿namespace Hastane_Otomasyonu
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
            this.LblTC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnOlustur = new System.Windows.Forms.Button();
            this.RtxtDuyuru = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnCikis = new System.Windows.Forms.Button();
            this.BtnAnamenu = new System.Windows.Forms.Button();
            this.BtnDuyuru = new System.Windows.Forms.Button();
            this.BtnRandevuListele = new System.Windows.Forms.Button();
            this.BtnBransPaneli = new System.Windows.Forms.Button();
            this.BtnDoktorPaneli = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tarih = new System.Windows.Forms.DateTimePicker();
            this.CmbDoktor = new System.Windows.Forms.ComboBox();
            this.CmbBrans = new System.Windows.Forms.ComboBox();
            this.MtxtSaat = new System.Windows.Forms.MaskedTextBox();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.LblTC);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(276, 178);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sekreter Bilgi";
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
            // LblTC
            // 
            this.LblTC.AutoSize = true;
            this.LblTC.Location = new System.Drawing.Point(128, 51);
            this.LblTC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTC.Name = "LblTC";
            this.LblTC.Size = new System.Drawing.Size(120, 24);
            this.LblTC.TabIndex = 1;
            this.LblTC.Text = "00000000000";
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
            this.groupBox2.Controls.Add(this.BtnOlustur);
            this.groupBox2.Controls.Add(this.RtxtDuyuru);
            this.groupBox2.Location = new System.Drawing.Point(10, 206);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(276, 267);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Duyuru Oluştur";
            // 
            // BtnOlustur
            // 
            this.BtnOlustur.Location = new System.Drawing.Point(179, 224);
            this.BtnOlustur.Margin = new System.Windows.Forms.Padding(4);
            this.BtnOlustur.Name = "BtnOlustur";
            this.BtnOlustur.Size = new System.Drawing.Size(88, 32);
            this.BtnOlustur.TabIndex = 2;
            this.BtnOlustur.Text = "Oluştur";
            this.BtnOlustur.UseVisualStyleBackColor = true;
            this.BtnOlustur.Click += new System.EventHandler(this.BtnOlustur_Click);
            // 
            // RtxtDuyuru
            // 
            this.RtxtDuyuru.Location = new System.Drawing.Point(8, 32);
            this.RtxtDuyuru.Margin = new System.Windows.Forms.Padding(4);
            this.RtxtDuyuru.Name = "RtxtDuyuru";
            this.RtxtDuyuru.Size = new System.Drawing.Size(260, 184);
            this.RtxtDuyuru.TabIndex = 1;
            this.RtxtDuyuru.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnCikis);
            this.groupBox3.Controls.Add(this.BtnAnamenu);
            this.groupBox3.Controls.Add(this.BtnDuyuru);
            this.groupBox3.Controls.Add(this.BtnRandevuListele);
            this.groupBox3.Controls.Add(this.BtnBransPaneli);
            this.groupBox3.Controls.Add(this.BtnDoktorPaneli);
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
            // BtnCikis
            // 
            this.BtnCikis.Location = new System.Drawing.Point(271, 94);
            this.BtnCikis.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Size = new System.Drawing.Size(108, 56);
            this.BtnCikis.TabIndex = 8;
            this.BtnCikis.Text = "Çıkış";
            this.BtnCikis.UseVisualStyleBackColor = true;
            this.BtnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
            // 
            // BtnAnamenu
            // 
            this.BtnAnamenu.Location = new System.Drawing.Point(271, 30);
            this.BtnAnamenu.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAnamenu.Name = "BtnAnamenu";
            this.BtnAnamenu.Size = new System.Drawing.Size(108, 56);
            this.BtnAnamenu.TabIndex = 7;
            this.BtnAnamenu.Text = "Ana Menü";
            this.BtnAnamenu.UseVisualStyleBackColor = true;
            this.BtnAnamenu.Click += new System.EventHandler(this.BtnAnamenu_Click);
            // 
            // BtnDuyuru
            // 
            this.BtnDuyuru.Location = new System.Drawing.Point(139, 94);
            this.BtnDuyuru.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDuyuru.Name = "BtnDuyuru";
            this.BtnDuyuru.Size = new System.Drawing.Size(108, 56);
            this.BtnDuyuru.TabIndex = 6;
            this.BtnDuyuru.Text = "Duyurular";
            this.BtnDuyuru.UseVisualStyleBackColor = true;
            this.BtnDuyuru.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnRandevuListele
            // 
            this.BtnRandevuListele.Location = new System.Drawing.Point(139, 30);
            this.BtnRandevuListele.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRandevuListele.Name = "BtnRandevuListele";
            this.BtnRandevuListele.Size = new System.Drawing.Size(108, 56);
            this.BtnRandevuListele.TabIndex = 5;
            this.BtnRandevuListele.Text = "Randevu Listele";
            this.BtnRandevuListele.UseVisualStyleBackColor = true;
            this.BtnRandevuListele.Click += new System.EventHandler(this.BtnRandevuListele_Click);
            // 
            // BtnBransPaneli
            // 
            this.BtnBransPaneli.Location = new System.Drawing.Point(12, 94);
            this.BtnBransPaneli.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBransPaneli.Name = "BtnBransPaneli";
            this.BtnBransPaneli.Size = new System.Drawing.Size(108, 56);
            this.BtnBransPaneli.TabIndex = 4;
            this.BtnBransPaneli.Text = "Branş Paneli";
            this.BtnBransPaneli.UseVisualStyleBackColor = true;
            this.BtnBransPaneli.Click += new System.EventHandler(this.BtnBransPaneli_Click);
            // 
            // BtnDoktorPaneli
            // 
            this.BtnDoktorPaneli.Location = new System.Drawing.Point(12, 30);
            this.BtnDoktorPaneli.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDoktorPaneli.Name = "BtnDoktorPaneli";
            this.BtnDoktorPaneli.Size = new System.Drawing.Size(108, 56);
            this.BtnDoktorPaneli.TabIndex = 3;
            this.BtnDoktorPaneli.Text = "Doktor Paneli";
            this.BtnDoktorPaneli.UseVisualStyleBackColor = true;
            this.BtnDoktorPaneli.Click += new System.EventHandler(this.BtnDoktorPaneli_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.tarih);
            this.groupBox4.Controls.Add(this.CmbDoktor);
            this.groupBox4.Controls.Add(this.CmbBrans);
            this.groupBox4.Controls.Add(this.MtxtSaat);
            this.groupBox4.Controls.Add(this.BtnKaydet);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "lblInfo";
            this.label2.Visible = false;
            // 
            // tarih
            // 
            this.tarih.Location = new System.Drawing.Point(86, 45);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(166, 32);
            this.tarih.TabIndex = 9;
            // 
            // CmbDoktor
            // 
            this.CmbDoktor.FormattingEnabled = true;
            this.CmbDoktor.Location = new System.Drawing.Point(86, 195);
            this.CmbDoktor.Margin = new System.Windows.Forms.Padding(4);
            this.CmbDoktor.Name = "CmbDoktor";
            this.CmbDoktor.Size = new System.Drawing.Size(166, 32);
            this.CmbDoktor.TabIndex = 12;
            this.CmbDoktor.SelectedIndexChanged += new System.EventHandler(this.CmbDoktor_SelectedIndexChanged);
            // 
            // CmbBrans
            // 
            this.CmbBrans.FormattingEnabled = true;
            this.CmbBrans.Location = new System.Drawing.Point(86, 146);
            this.CmbBrans.Margin = new System.Windows.Forms.Padding(4);
            this.CmbBrans.Name = "CmbBrans";
            this.CmbBrans.Size = new System.Drawing.Size(166, 32);
            this.CmbBrans.TabIndex = 11;
            this.CmbBrans.SelectedIndexChanged += new System.EventHandler(this.CmbBrans_SelectedIndexChanged);
            // 
            // MtxtSaat
            // 
            this.MtxtSaat.Location = new System.Drawing.Point(86, 95);
            this.MtxtSaat.Margin = new System.Windows.Forms.Padding(4);
            this.MtxtSaat.Mask = "00:00";
            this.MtxtSaat.Name = "MtxtSaat";
            this.MtxtSaat.Size = new System.Drawing.Size(166, 32);
            this.MtxtSaat.TabIndex = 10;
            this.MtxtSaat.ValidatingType = typeof(System.DateTime);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(164, 239);
            this.BtnKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(88, 32);
            this.BtnKaydet.TabIndex = 13;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
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
            this.groupBox5.Controls.Add(this.dataGridView1);
            this.groupBox5.Location = new System.Drawing.Point(572, 18);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(412, 214);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Branşlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(4, 29);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(404, 181);
            this.dataGridView1.TabIndex = 14;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dataGridView2);
            this.groupBox6.Location = new System.Drawing.Point(572, 242);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(412, 416);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Doktorlar";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(4, 29);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(404, 383);
            this.dataGridView2.TabIndex = 15;
            // 
            // FrmSekreterDetay
            // 
            this.AcceptButton = this.BtnAnamenu;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
        private System.Windows.Forms.Label LblTC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnOlustur;
        private System.Windows.Forms.RichTextBox RtxtDuyuru;
        private System.Windows.Forms.Button BtnRandevuListele;
        private System.Windows.Forms.Button BtnBransPaneli;
        private System.Windows.Forms.Button BtnDoktorPaneli;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox MtxtSaat;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox CmbDoktor;
        private System.Windows.Forms.ComboBox CmbBrans;
        private System.Windows.Forms.Button BtnDuyuru;
        private System.Windows.Forms.Button BtnCikis;
        private System.Windows.Forms.Button BtnAnamenu;
        private System.Windows.Forms.DateTimePicker tarih;
        private System.Windows.Forms.Label label2;
    }
}