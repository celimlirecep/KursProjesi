using KursProjesii.DataAccess.BaglantiDAL;
using KursProjesii.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursProjesii.DataAccess.DAL
{
    class EgitimDal
    {
        
        //CRUD İŞLEMLERİ
        
        string queryString = string.Empty;
        SqlCommand cmd=null;

        public List<Kurs> GetAll(string myQuery="")
        {
           
            List<Kurs> kurslar = new List<Kurs>();
            Kurs kurs = null;
            try
            {
                using (cmd=new SqlCommand($"SELECT * FROM tblEgitimler {myQuery}",Baglanti.BaglantiNesnesi))
                {
                    Baglanti.Ac();
                    using (SqlDataReader dr=cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            kurs = new Kurs
                            {
                                ID=Convert.ToInt32(dr["ID"]),
                                Ad = dr["Ad"].ToString(),
                                Sorumlu=dr["Sorumlusu"].ToString(),
                                BaslangicTarihi=Convert.ToDateTime(dr["BaslangicTarihi"]),
                                Sure=Convert.ToInt32(dr["Sure"])
                            };
                            kurslar.Add(kurs);
                        }
                        


                    }

                }

                return kurslar;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
             //   throw;
            }
            finally
            {
                Baglanti.Kapat();
            }


        }
        public void Delete(string id)
        {
            queryString = "DELETE FROM tblEgitimler WHERE ID=@P1";
            try
            {
                using (cmd=new SqlCommand(queryString,Baglanti.BaglantiNesnesi))
                {
                    Baglanti.Ac();
                    cmd.Parameters.AddWithValue("@P1", id);
                    cmd.ExecuteNonQuery();
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                Baglanti.Kapat();
            }
        }
        public void Insert(Kurs kurs)
        {
            queryString = "INSERT INTO tblEgitimler VALUES" +
                "(@P1,@P2,@P3,@P4)";
            using (cmd=new SqlCommand(queryString,Baglanti.BaglantiNesnesi))
            {
                Baglanti.Ac();
                cmd.Parameters.AddWithValue("@p1",kurs.Ad);
                cmd.Parameters.AddWithValue("@p2",kurs.Sorumlu);
                cmd.Parameters.AddWithValue("@p3",kurs.BaslangicTarihi);
                cmd.Parameters.AddWithValue("@p4",kurs.Sure);
                cmd.ExecuteNonQuery();
            }
        }
        public void Update(Kurs kurs)
        {
            queryString = "UPDATE tblEgitimler SET " +
                "Ad=@p1,Sorumlusu=@p2,BaslangicTarihi=@p3,Sure=@p4 " +
                "WHERE ID=@P5";
            try
            {
                using (cmd=new SqlCommand(queryString,Baglanti.BaglantiNesnesi))
                {
                    Baglanti.Ac();
                    cmd.Parameters.AddWithValue("@p5", kurs.ID);
                    cmd.Parameters.AddWithValue("@p1",kurs.Ad );
                    cmd.Parameters.AddWithValue("@p2",kurs.Sorumlu );
                    cmd.Parameters.AddWithValue("@p3", kurs.BaslangicTarihi.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@p4", kurs.Sure);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message);}
            finally
            {
                Baglanti.Kapat();
            }
                
        }
        public void Search(List<string> searchList)
        {
            try
            {
                string parametre = string.Empty;
                List<string> SearchParametre = new List<string>();
                for (int i = 0; i < searchList.Count; i++)
                {
                    parametre = $" @p{i} ";
                    SearchParametre.Add(parametre);
                }
                queryString = "SELECT * FROM tblEgitimler WHERE " +
                    $"{string.Join(",", SearchParametre)}";
                using (cmd = new SqlCommand(queryString, Baglanti.BaglantiNesnesi))
                {
                    Baglanti.Ac();
                    for (int i = 0; i < searchList.Count; i++)
                    {
                        cmd.Parameters.Add($@"{SearchParametre[{i}]}", searchList[i]);
                    }
                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
