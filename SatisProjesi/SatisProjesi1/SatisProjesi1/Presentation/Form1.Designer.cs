
namespace SatisProjesi1
{
    partial class Form1
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
            this.dtpUrunlerSatisTarihi = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbUrunler = new System.Windows.Forms.ComboBox();
            this.txtStokAdedi = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.dgvUrun = new System.Windows.Forms.DataGridView();
            this.dgvSatis = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatis)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpUrunlerSatisTarihi
            // 
            this.dtpUrunlerSatisTarihi.Location = new System.Drawing.Point(194, 25);
            this.dtpUrunlerSatisTarihi.Name = "dtpUrunlerSatisTarihi";
            this.dtpUrunlerSatisTarihi.Size = new System.Drawing.Size(148, 20);
            this.dtpUrunlerSatisTarihi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(37, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Satis Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(37, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürünler";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(37, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 33);
            this.label3.TabIndex = 1;
            this.label3.Text = "Stok Adedi";
            // 
            // cmbUrunler
            // 
            this.cmbUrunler.FormattingEnabled = true;
            this.cmbUrunler.Location = new System.Drawing.Point(194, 64);
            this.cmbUrunler.Name = "cmbUrunler";
            this.cmbUrunler.Size = new System.Drawing.Size(148, 21);
            this.cmbUrunler.TabIndex = 2;
            // 
            // txtStokAdedi
            // 
            this.txtStokAdedi.Location = new System.Drawing.Point(194, 104);
            this.txtStokAdedi.Name = "txtStokAdedi";
            this.txtStokAdedi.Size = new System.Drawing.Size(148, 20);
            this.txtStokAdedi.TabIndex = 3;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(373, 25);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(83, 62);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // dgvUrun
            // 
            this.dgvUrun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrun.Location = new System.Drawing.Point(21, 167);
            this.dgvUrun.Name = "dgvUrun";
            this.dgvUrun.Size = new System.Drawing.Size(321, 164);
            this.dgvUrun.TabIndex = 5;
            // 
            // dgvSatis
            // 
            this.dgvSatis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSatis.Location = new System.Drawing.Point(357, 167);
            this.dgvSatis.Name = "dgvSatis";
            this.dgvSatis.Size = new System.Drawing.Size(485, 150);
            this.dgvSatis.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 343);
            this.Controls.Add(this.dgvSatis);
            this.Controls.Add(this.dgvUrun);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtStokAdedi);
            this.Controls.Add(this.cmbUrunler);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpUrunlerSatisTarihi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpUrunlerSatisTarihi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbUrunler;
        private System.Windows.Forms.TextBox txtStokAdedi;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DataGridView dgvUrun;
        private System.Windows.Forms.DataGridView dgvSatis;
    }
}

