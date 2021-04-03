using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace QuanLyTramThuPhi
{
    class KetNoi
    {
        public SqlConnection cnn;
        public SqlCommand cmd;
        public DataTable dta;
        public SqlDataAdapter ada;


        public void KetNoi_Dulieu()
        {
            string strKetNoi = @"Data Source=DESKTOP-NLUEJAK\SQLEXPRESS;Initial Catalog=QuanLyTramThuPhi;Integrated Security=True";
            cnn = new SqlConnection(strKetNoi);
            cnn.Open();
        }
        public void HuyKetNoi()
        {
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
        }

        public DataTable Lay_Dulieu(string Sql)
        {
            KetNoi_Dulieu();
            ada = new SqlDataAdapter(Sql, cnn);
            dta = new DataTable();
            ada.Fill(dta);
            return dta;
        }

        public void Execute(string sql)
        {
            KetNoi_Dulieu();
            cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            HuyKetNoi();
        }
        public static string connectionString = @"Data Source=DESKTOP-NLUEJAK\SQLEXPRESS;Initial Catalog=QuanLyTramThuPhi;Integrated Security=True";
    }
}
