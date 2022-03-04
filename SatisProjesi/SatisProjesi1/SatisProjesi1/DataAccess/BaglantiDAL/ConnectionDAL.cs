using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatisProjesi1.DataAccess.BaglantiDAL
{
    public static class ConnectionDAL
    {

        private static SqlConnection adress;

        public static SqlConnection Adress
        {
            get
            {
                if (adress==null)
                {
                    adress = new SqlConnection(ConfigurationManager.ConnectionStrings["SatisProjesi"].ConnectionString);
                }
                return adress;
            }
            set { adress = value; }
        }

        public static void open()
        {
            if (adress.State==ConnectionState.Closed)
            {
                adress.Open();
            }
        }
        public static void close()
        {
            if (adress.State==ConnectionState.Open)
            {
                adress.Close();
            }
        }




    }
}
