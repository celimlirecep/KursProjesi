using KursProjesii.DataAccess.BaglantiDAL;
using KursProjesii.DataAccess.DAL;
using KursProjesii.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursProjesii
{
    public partial class panelKurs : Form
    {
        EgitimDal egitimDal = new EgitimDal();
        Kurs forUpdate = null;
        
        public panelKurs()
        {
            InitializeComponent();
        }//************INITIALIZE

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshTable();
            Transfer();
        }//*********LOAD
        void RefreshTable()
        {
            dgvKurs.DataSource = egitimDal.GetAll();
        }// tabloyu yeniler

        private void Transfer()
        {
            try
            {
                lblID.Text = dgvKurs.SelectedRows[0].Cells[0].Value.ToString();
                txtAd.Text = dgvKurs.SelectedRows[0].Cells[1].Value.ToString();
                txtSorumlu.Text = dgvKurs.SelectedRows[0].Cells[2].Value.ToString();
                dtpBaslangıcTarihi.Value = Convert.ToDateTime(dgvKurs.SelectedRows[0].Cells[3].Value);
                txtSure.Text = dgvKurs.SelectedRows[0].Cells[4].Value.ToString();
                 forUpdate = new Kurs
                {
                    ID = Convert.ToInt32(lblID.Text),
                    Ad = txtAd.Text,
                    Sorumlu=txtSorumlu.Text,
                    BaslangicTarihi=dtpBaslangıcTarihi.Value,
                    Sure= Convert.ToInt32(txtSure.Text)
                };
            }
            catch (Exception){ }
            
        }//*****************************VERİLERİ panelKurslara aktarma

        private void dgvKurs_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Transfer();
            }
            catch (Exception) { }
        }//***DGV CELL ENTER

        private void Clean()
        {
            foreach (Control control in panelKurslar.Controls)
            {
                if (control.GetType()!=typeof(DateTimePicker))
                {
                    control.Text = string.Empty;
                }
            }
            dtpBaslangıcTarihi.CustomFormat = " ";
            dtpBaslangıcTarihi.Format = DateTimePickerFormat.Custom;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Clean();
        }//tüm textleri temizle

        private void dtpBaslangıcTarihi_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                dtpBaslangıcTarihi.Format = DateTimePickerFormat.Long;
            }
            catch (Exception) { }
        }//tarih formatına geri getir

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (!IsFillEverything())
            {
                try
                {
                    egitimDal.Delete(lblID.Text);
                    RefreshTable();
                    MessageBox.Show("Silme İşlemi Basarili...");
                }
                catch (Exception) { }

            }
            
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            try
            {
                if (!IsFillEverything())
                {
                    Kurs kurs = new Kurs
                    {
                        Ad = txtAd.Text,
                        Sorumlu = txtSorumlu.Text,
                        Sure = Convert.ToInt32(txtSure.Text),
                        BaslangicTarihi = dtpBaslangıcTarihi.Value
                    };
                    egitimDal.Insert(kurs);
                    RefreshTable();
                    MessageBox.Show("Kaydetme İşlemi Başarılı");
                }
                
                
            }
            catch (Exception) { }
            
            
        }
        /// <summary>
        /// Tüm alanlar dolu ise False döndürür
        /// </summary>
        /// <returns></returns>
        private bool IsFillEverything()
        {
            foreach (Control control in panelKurslar.Controls)
            {
                if (control.GetType()!=typeof(Label))
                {
                    if (control.Text == string.Empty || control.Text == " ")
                    {
                        MessageBox.Show("Lütfen tüm alanları doldurunuz...");
                        return true;
                    }
                }
                
            }
            return false;
            
        }
        //boşken güncelletirme!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        private void btnGuncelle_Click(object sender, EventArgs e)//??????? sadece değişeni güncellesin
        {
            if (!IsFillEverything())
            {
                Kurs guncel = new Kurs
                {
                    ID = Convert.ToInt32(lblID.Text),
                    Ad = txtAd.Text,
                    Sorumlu = txtSorumlu.Text,
                    BaslangicTarihi = dtpBaslangıcTarihi.Value,
                    Sure = Convert.ToInt32(txtSure.Text),

                };
                egitimDal.Update(guncel);
                RefreshTable();
            }
            
          
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            List<string> SearchList = new List<string>();
            try
            {
                foreach (Control control in panelKurslar.Controls)
                {
                    if (control.Text!=string.Empty && control.Text!=" ")
                    {
                        SearchList.Add(control.Tag+" = '"+control.Text+"'");
                    }
                }
                egitimDal.Search(SearchList);

                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
