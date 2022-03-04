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
    class SatisDAL
    {
        SqlCommand cmd = null;
        SqlDataReader dr = null;
        string querySentence = string.Empty;


        public List<Satislar> GetAll()
        {
            querySentence = "SELECT * FROM tblSatislar";
            List<Satislar> satisListesi = new List<Satislar>();
            try
            {
                using (cmd=new SqlCommand(querySentence,ConnectionDAL.Adress))
                {
                    ConnectionDAL.open();
                    using (dr=cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Satislar satislar = new Satislar
                            {
                                ID = Convert.ToInt32(dr["ID"]),
                                SatisTarihi=Convert.ToDateTime(dr["Satistarihi"]),
                                UrunID=Convert.ToInt32(dr["UrunID"]),
                                SatisAdedi=Convert.ToInt32(dr["SatisAdedi"])
                            };
                            satisListesi.Add(satislar);
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
        public bool Insert(Satislar satislar)
        {
            querySentence = "INSERT INTO tblSatislar VALUES " +
                "(@P1,@P2,@P3) ";
            try
            {
                using (cmd=new SqlCommand(querySentence,ConnectionDAL.Adress))
                {
                    ConnectionDAL.open();
                    cmd.Parameters.AddWithValue("@P1",satislar.SatisTarihi.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@P2",satislar.UrunID);
                    cmd.Parameters.AddWithValue("@P3",satislar.SatisAdedi);
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
