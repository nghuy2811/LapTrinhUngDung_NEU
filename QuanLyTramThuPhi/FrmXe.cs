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
    public partial class FrmXe : Form
    {
        public FrmXe()
        {
            InitializeComponent();
        }

        KetNoi ketnoi = new KetNoi();

        public void Load_DuLieu_Xe()
        {
            DataTable dta = new DataTable();
            dta = ketnoi.Lay_Dulieu("Select * From Xe");
            dataGridXe.DataSource = dta;
            Hienthi_Dulieu();
        }

        private void FrmXe_Load(object sender, EventArgs e)
        {
            Load_DuLieu_Xe();
            Hienthi_Dulieu();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            txtBienSoXe.Text = "";
            txtLoaiXe.Text = "";
            txtTrongTai.Text = "";
        }

        private void btnChen_Click(object sender, EventArgs e)
        {
            string sql1 = "Insert into Xe Values('" + txtBienSoXe.Text + "' , '" + txtLoaiXe.Text + "', '" + txtTrongTai.Text + "')";
            ketnoi.Execute(sql1);
            Load_DuLieu_Xe();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql2 = "Update Xe Set bienso ='" + txtBienSoXe.Text + "'";
            sql2 = sql2 + ", tenloai ='" + txtLoaiXe.Text + "', trongtai = '" + txtTrongTai.Text + "' where bienso = '" + txtBienSoXe.Text + "'";
            ketnoi.Execute(sql2);
            Load_DuLieu_Xe();
        }

        private void Hienthi_Dulieu()
        {
            txtBienSoXe.DataBindings.Clear();
            txtBienSoXe.DataBindings.Add("Text", dataGridXe.DataSource, "bienso");

            txtLoaiXe.DataBindings.Clear();
            txtLoaiXe.DataBindings.Add("Text", dataGridXe.DataSource, "tenloai");

            txtTrongTai.DataBindings.Clear();
            txtTrongTai.DataBindings.Add("Text", dataGridXe.DataSource, "trongtai");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ketnoi.Execute("Delete Xe Where bienso = '" + txtBienSoXe.Text + "'");
            Load_DuLieu_Xe();
        }
    }
}
