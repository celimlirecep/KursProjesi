
namespace KursProjesii
{
    partial class panelKurs
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvKurs = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSorumlu = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.dtpBaslangıcTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtSure = new System.Windows.Forms.TextBox();
            this.panelKurslar = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnHepsiniSil = new System.Windows.Forms.Button();
            this.btnBul = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnGetir = new System.Windows.Forms.Button();
            this.rdbIlkHarf = new System.Windows.Forms.RadioButton();
            this.rdbIcındeGecen = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKurs)).BeginInit();
            this.panelKurslar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvKurs
            // 
            this.dgvKurs.AllowUserToAddRows = false;
            this.dgvKurs.AllowUserToDeleteRows = false;
            this.dgvKurs.AllowUserToResizeColumns = false;
            this.dgvKurs.AllowUserToResizeRows = false;
            this.dgvKurs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKurs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKurs.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvKurs.Location = new System.Drawing.Point(364, 67);
            this.dgvKurs.MultiSelect = false;
            this.dgvKurs.Name = "dgvKurs";
            this.dgvKurs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKurs.Size = new System.Drawing.Size(559, 263);
            this.dgvKurs.TabIndex = 14;
            this.dgvKurs.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKurs_CellEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "AD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "SORUMLU";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "BAŞLANGIÇ TARİHİ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "SÜRE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "ID ";
            // 
            // txtSorumlu
            // 
            this.txtSorumlu.Location = new System.Drawing.Point(7, 54);
            this.txtSorumlu.Name = "txtSorumlu";
            this.txtSorumlu.Size = new System.Drawing.Size(150, 20);
            this.txtSorumlu.TabIndex = 1;
            this.txtSorumlu.Tag = "Sorumlusu";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblID.Location = new System.Drawing.Point(65, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(45, 16);
            this.lblID.TabIndex = 1;
            this.lblID.Tag = "ID";
            this.lblID.Text = "label1";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(7, 26);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(150, 20);
            this.txtAd.TabIndex = 0;
            this.txtAd.Tag = "Ad";
            // 
            // dtpBaslangıcTarihi
            // 
            this.dtpBaslangıcTarihi.Location = new System.Drawing.Point(7, 82);
            this.dtpBaslangıcTarihi.Name = "dtpBaslangıcTarihi";
            this.dtpBaslangıcTarihi.Size = new System.Drawing.Size(150, 20);
            this.dtpBaslangıcTarihi.TabIndex = 2;
            this.dtpBaslangıcTarihi.Tag = "BaslangicTarihi";
            this.dtpBaslangıcTarihi.ValueChanged += new System.EventHandler(this.dtpBaslangıcTarihi_ValueChanged);
            // 
            // txtSure
            // 
            this.txtSure.Location = new System.Drawing.Point(7, 110);
            this.txtSure.Name = "txtSure";
            this.txtSure.Size = new System.Drawing.Size(150, 20);
            this.txtSure.TabIndex = 3;
            this.txtSure.Tag = "Sure";
            // 
            // panelKurslar
            // 
            this.panelKurslar.Controls.Add(this.dtpBaslangıcTarihi);
            this.panelKurslar.Controls.Add(this.txtAd);
            this.panelKurslar.Controls.Add(this.txtSure);
            this.panelKurslar.Controls.Add(this.txtSorumlu);
            this.panelKurslar.Controls.Add(this.lblID);
            this.panelKurslar.Location = new System.Drawing.Point(157, 76);
            this.panelKurslar.Name = "panelKurslar";
            this.panelKurslar.Size = new System.Drawing.Size(169, 141);
            this.panelKurslar.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.SlateGray;
            this.label6.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(15, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(908, 35);
            this.label6.TabIndex = 15;
            this.label6.Text = "< KURSLAR >\r\n";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(15, 228);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(100, 32);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(120, 228);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(100, 32);
            this.btnSil.TabIndex = 5;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(225, 228);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(100, 32);
            this.btnGuncelle.TabIndex = 6;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnHepsiniSil
            // 
            this.btnHepsiniSil.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnHepsiniSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHepsiniSil.Location = new System.Drawing.Point(15, 266);
            this.btnHepsiniSil.Name = "btnHepsiniSil";
            this.btnHepsiniSil.Size = new System.Drawing.Size(100, 32);
            this.btnHepsiniSil.TabIndex = 7;
            this.btnHepsiniSil.Text = "HEPSİNİ SİL";
            this.btnHepsiniSil.UseVisualStyleBackColor = false;
            // 
            // btnBul
            // 
            this.btnBul.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnBul.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBul.Location = new System.Drawing.Point(120, 266);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(100, 32);
            this.btnBul.TabIndex = 8;
            this.btnBul.Text = "BUL";
            this.btnBul.UseVisualStyleBackColor = false;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Location = new System.Drawing.Point(225, 266);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(100, 32);
            this.btnTemizle.TabIndex = 9;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnGetir
            // 
            this.btnGetir.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnGetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGetir.Location = new System.Drawing.Point(12, 304);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(100, 32);
            this.btnGetir.TabIndex = 10;
            this.btnGetir.Text = "GETİR";
            this.btnGetir.UseVisualStyleBackColor = false;
            // 
            // rdbIlkHarf
            // 
            this.rdbIlkHarf.AutoSize = true;
            this.rdbIlkHarf.Checked = true;
            this.rdbIlkHarf.Location = new System.Drawing.Point(121, 313);
            this.rdbIlkHarf.Name = "rdbIlkHarf";
            this.rdbIlkHarf.Size = new System.Drawing.Size(73, 17);
            this.rdbIlkHarf.TabIndex = 11;
            this.rdbIlkHarf.TabStop = true;
            this.rdbIlkHarf.Text = "İLK HARF";
            this.rdbIlkHarf.UseVisualStyleBackColor = true;
            // 
            // rdbIcındeGecen
            // 
            this.rdbIcındeGecen.AutoSize = true;
            this.rdbIcındeGecen.Location = new System.Drawing.Point(225, 313);
            this.rdbIcındeGecen.Name = "rdbIcındeGecen";
            this.rdbIcındeGecen.Size = new System.Drawing.Size(101, 17);
            this.rdbIcındeGecen.TabIndex = 12;
            this.rdbIcındeGecen.Text = "İÇİNDE GEÇEN";
            this.rdbIcındeGecen.UseVisualStyleBackColor = true;
            // 
            // panelKurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(935, 337);
            this.Controls.Add(this.rdbIcındeGecen);
            this.Controls.Add(this.rdbIlkHarf);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGetir);
            this.Controls.Add(this.btnHepsiniSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.panelKurslar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvKurs);
            this.Name = "panelKurs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKurs)).EndInit();
            this.panelKurslar.ResumeLayout(false);
            this.panelKurslar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKurs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSorumlu;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.DateTimePicker dtpBaslangıcTarihi;
        private System.Windows.Forms.TextBox txtSure;
        private System.Windows.Forms.Panel panelKurslar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnHepsiniSil;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.RadioButton rdbIcındeGecen;
        private System.Windows.Forms.RadioButton rdbIlkHarf;
    }
}

