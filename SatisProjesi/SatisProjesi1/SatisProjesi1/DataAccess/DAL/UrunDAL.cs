using SatisProjesi1.DataAccess.BaglantiDAL;
using SatisProjesi1.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatisProjesi1.DataAccess.DAL
{
    class UrunDAL
    {
        SqlCommand cmd = null;
        SqlDataReader dr = null;
        string querySentence = string.Empty;
        

        public List<Urunler> GetAll()
        {
            querySentence = "SELECT * FROM tblUrunler";
            List<Urunler> satisListesi = new List<Urunler>();
            try
            {
                using (cmd = new SqlCommand(querySentence, ConnectionDAL.Adress))
                {
                    ConnectionDAL.open();
                    using (dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Urunler urunler = new Urunler
                            {
                                ID=Convert.ToInt32(dr["ID"]),
                                UrunAd=dr["UrunAd"].ToString(),
                                StokMiktari=Convert.ToInt32( dr["StokMiktari"])
                            };
                            satisListesi.Add(urunler);
                        }
                    }
                }
                return satisListesi;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return null;
            }
        }
        public bool StockUpdate(Satislar satislar)
        {
            querySentence = "UPDATE tblUrunler SET StokMiktari=(StokMiktari-@P1) " +
                "WHERE ID=@P2 ";
            try
            {
                using (cmd=new SqlCommand(querySentence,ConnectionDAL.Adress))
                {
                    ConnectionDAL.open();
                    cmd.Parameters.AddWithValue("@P1", satislar.SatisAdedi);
                    cmd.Parameters.AddWithValue("@P2", satislar.UrunID);
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                ConnectionDAL.close();
            }
        }



    }
}
