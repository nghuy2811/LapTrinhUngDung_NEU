using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTramThuPhi
{
    public partial class FrmVe : Form
    {
        public FrmVe()
        {
            InitializeComponent();
        }

        KetNoi ketnoi = new KetNoi();

        public void Load_DuLieu_Ve()
        {
            DataTable dta = new DataTable();
            dta = ketnoi.Lay_Dulieu("Select * From Ve");
            dataGridVe.DataSource = dta;
            Hienthi_Dulieu();
        }

        public void Load_DuLieu_Xe()
        {
            DataTable dta = new DataTable();
            dta = ketnoi.Lay_Dulieu("Select * From Xe");
            cboBienSo.DataSource = dta;
            cboBienSo.DisplayMember = "bienso";
            cboBienSo.ValueMember = "bienso";
        }

        private void FrmVe_Load(object sender, EventArgs e)
        {
            Load_DuLieu_Ve();
            Load_DuLieu_Xe();
            Hienthi_Dulieu();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            txtMaVe.Text = "";
            txtLoaiVe.Text = "";
            txtNgayIn.Text = "";
            txtGiaVe.Text = "";
        }

        private void btnChen_Click(object sender, EventArgs e)
        {
            string sql1 = "Insert into Ve Values('" + txtMaVe.Text + "' , '" + txtLoaiVe.Text + "', '" + txtNgayIn.Text + "', '" + txtGiaVe.Text + "', '" + cboBienSo.Text + "')";
            ketnoi.Execute(sql1);
            Load_DuLieu_Ve();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql2 = "Update Ve Set mave ='" + txtMaVe.Text + "'";
            sql2 = sql2 + ", loaive ='" + txtLoaiVe.Text + "', ngayinve = '" + txtNgayIn.Text + "', giatien = '" + txtGiaVe.Text + "', bienso = '" + cboBienSo.Text + "' where mave = '" + txtMaVe.Text + "'";
            ketnoi.Execute(sql2);
            Load_DuLieu_Ve();
        }

        private void Hienthi_Dulieu()
        {
            txtMaVe.DataBindings.Clear();
            txtMaVe.DataBindings.Add("Text", dataGridVe.DataSource, "mave");

            txtLoaiVe.DataBindings.Clear();
            txtLoaiVe.DataBindings.Add("Text", dataGridVe.DataSource, "loaive");

            txtNgayIn.DataBindings.Clear();
            txtNgayIn.DataBindings.Add("Text", dataGridVe.DataSource, "ngayinve");

            txtGiaVe.DataBindings.Clear();
            txtGiaVe.DataBindings.Add("Text", dataGridVe.DataSource, "giatien");

            cboBienSo.DataBindings.Clear();
            cboBienSo.DataBindings.Add("Text", dataGridVe.DataSource, "bienso");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ketnoi.Execute("Delete Ve Where mave = '" + txtMaVe.Text + "'");
            Load_DuLieu_Xe();
        }
    }
}
