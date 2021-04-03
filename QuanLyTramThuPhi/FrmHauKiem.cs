using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyTramThuPhi
{
    public partial class FrmHauKiem : Form
    {
        public FrmHauKiem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = GetNgay().Tables[0];
            // dataGridView1.DataMember = "HauKiem";
        }
        DataSet GetNgay()
        {
            DataSet data = new DataSet();
            string query = "select Ve.giatien, Xe.bienso, Xe.tenloai, Ve.ngayinve from Ve, Xe where Xe.bienso = Ve.bienso and Ve.ngayinve = '" + txtNgay.Text + "'";
            using (SqlConnection connection = new SqlConnection(KetNoi.connectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                adapter.Fill(data);

                connection.Close();
            }
            return data;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetAllTramThuPhi().Tables[0];
        }

        DataSet GetAllTramThuPhi()
        {
            DataSet data = new DataSet();

            string query = "select * from TramThuPhi where diachi = '" + txtHK.Text + "'";
            using (SqlConnection connection = new SqlConnection(KetNoi.connectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                adapter.Fill(data);

                connection.Close();
            }
            return data;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = GetTongTien().Tables[0];
        }
        DataSet GetTongTien()
        {
            DataSet data = new DataSet();

            string query = "select SUM(giatien) as TongTien from Ve";
            using (SqlConnection connection = new SqlConnection(KetNoi.connectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                adapter.Fill(data);

                connection.Close();
            }
            return data;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = GetTongSoXe().Tables[0];
        }
        DataSet GetTongSoXe()
        {
            DataSet data = new DataSet();

            string query = "select COUNT(bienso) AS TongSoXe from Xe";
            using (SqlConnection connection = new SqlConnection(KetNoi.connectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                adapter.Fill(data);

                connection.Close();
            }
            return data;
        }
    }
}
