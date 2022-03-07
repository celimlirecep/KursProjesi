using SatisProjesi1.DataAccess.DAL;
using SatisProjesi1.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SatisProjesi1
{
    public partial class Form1 : Form
    {
        UrunDAL urunDAL = new UrunDAL();
        SatisDAL satisDAL = new SatisDAL();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Satislar satislar = new Satislar
            {
                SatisTarihi = dtpUrunlerSatisTarihi.Value,
                UrunID =Convert.ToInt32( cmbUrunler.SelectedValue),
                SatisAdedi = Convert.ToInt32(txtStokAdedi.Text)
            };
            satisDAL.Insert(satislar);
             urunDAL.StockUpdate(satislar);
            dgvUrun.DataSource = urunDAL.GetAll();
            dgvSatis.DataSource = satisDAL.GetAll();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbUrunler.DataSource = urunDAL.GetAll();
            cmbUrunler.DisplayMember = "UrunAd";
            cmbUrunler.ValueMember = "ID";
            dgvUrun.DataSource = urunDAL.GetAll();
            dgvSatis.DataSource = satisDAL.GetAll();
           

        }
    }
}
