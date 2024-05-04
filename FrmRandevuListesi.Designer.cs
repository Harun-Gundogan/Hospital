namespace Hastane_Otomasyonu
{
    partial class FrmRandevuListesi
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rtxtSikayet = new System.Windows.Forms.RichTextBox();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.mtxtSaat = new System.Windows.Forms.MaskedTextBox();
            this.cmbBrans = new System.Windows.Forms.ComboBox();
            this.cmbDoktor = new System.Windows.Forms.ComboBox();
            this.cmcRandevu = new System.Windows.Forms.ComboBox();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.rndID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 11);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(994, 462);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(65, 533);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(4);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(96, 32);
            this.btnCikis.TabIndex = 3;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(13, 493);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(96, 32);
            this.btnGuncelle.TabIndex = 1;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click_1);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(117, 493);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(96, 32);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.BtnSil_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(240, 691);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "TC Kimlik No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(199, 729);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Randevu Durumu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 610);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Branş:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 577);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Saat:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 539);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tarih:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 653);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Doktor:";
            // 
            // rtxtSikayet
            // 
            this.rtxtSikayet.Location = new System.Drawing.Point(629, 493);
            this.rtxtSikayet.Name = "rtxtSikayet";
            this.rtxtSikayet.Size = new System.Drawing.Size(378, 260);
            this.rtxtSikayet.TabIndex = 18;
            this.rtxtSikayet.Text = "";
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(367, 531);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(200, 32);
            this.dateTime.TabIndex = 7;
            // 
            // mtxtSaat
            // 
            this.mtxtSaat.Location = new System.Drawing.Point(367, 569);
            this.mtxtSaat.Mask = "00:00";
            this.mtxtSaat.Name = "mtxtSaat";
            this.mtxtSaat.Size = new System.Drawing.Size(200, 32);
            this.mtxtSaat.TabIndex = 9;
            this.mtxtSaat.ValidatingType = typeof(System.DateTime);
            // 
            // cmbBrans
            // 
            this.cmbBrans.FormattingEnabled = true;
            this.cmbBrans.Location = new System.Drawing.Point(367, 607);
            this.cmbBrans.Name = "cmbBrans";
            this.cmbBrans.Size = new System.Drawing.Size(200, 32);
            this.cmbBrans.TabIndex = 11;
            this.cmbBrans.SelectedIndexChanged += new System.EventHandler(this.cmbBrans_SelectedIndexChanged);
            // 
            // cmbDoktor
            // 
            this.cmbDoktor.FormattingEnabled = true;
            this.cmbDoktor.Location = new System.Drawing.Point(367, 645);
            this.cmbDoktor.Name = "cmbDoktor";
            this.cmbDoktor.Size = new System.Drawing.Size(200, 32);
            this.cmbDoktor.TabIndex = 13;
            // 
            // cmcRandevu
            // 
            this.cmcRandevu.FormattingEnabled = true;
            this.cmcRandevu.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cmcRandevu.Location = new System.Drawing.Point(366, 721);
            this.cmcRandevu.Name = "cmcRandevu";
            this.cmcRandevu.Size = new System.Drawing.Size(200, 32);
            this.cmcRandevu.TabIndex = 17;
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(367, 683);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(200, 32);
            this.txtTC.TabIndex = 15;
            // 
            // rndID
            // 
            this.rndID.Enabled = false;
            this.rndID.Location = new System.Drawing.Point(367, 493);
            this.rndID.Name = "rndID";
            this.rndID.Size = new System.Drawing.Size(100, 32);
            this.rndID.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(250, 501);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 24);
            this.label7.TabIndex = 4;
            this.label7.Text = "Randevu ID:";
            // 
            // FrmRandevuListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1024, 776);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rndID);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.cmcRandevu);
            this.Controls.Add(this.cmbDoktor);
            this.Controls.Add(this.cmbBrans);
            this.Controls.Add(this.mtxtSaat);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.rtxtSikayet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmRandevuListesi";
            this.Text = "FrmRandevuListesi";
            this.Load += new System.EventHandler(this.FrmRandevuListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtxtSikayet;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.MaskedTextBox mtxtSaat;
        private System.Windows.Forms.ComboBox cmbBrans;
        private System.Windows.Forms.ComboBox cmbDoktor;
        private System.Windows.Forms.ComboBox cmcRandevu;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.TextBox rndID;
        private System.Windows.Forms.Label label7;
    }
}