using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DoAnQLKaraokeDAO
{
    class DataProvider
    {
        static string strKetNoi = @"Data Source =DESKTOP-20TAQ02\SQLEXPRESS; Initial Catalog = csdl; Integrated Security = true;";

        public static SqlConnection TaoKetNoi()
        {
            SqlConnection con = new SqlConnection(strKetNoi);
            con.Open();
            return con;
        }
        public static SqlDataReader TruyVanDuLieu(string strTruyVan, SqlConnection conn)
        {
            SqlCommand com = new SqlCommand(strTruyVan, conn);
            return com.ExecuteReader();
        }

        public static SqlDataReader TruyVanDuLieu(string strTruyVan,SqlParameter[] param, SqlConnection conn) //trường hợp có parammeter
        {
            SqlCommand com = new SqlCommand(strTruyVan, conn);
            com.Parameters.AddRange(param);
            return com.ExecuteReader();
        }
    
    }
}
