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
    public partial class FrmNhanVien : Form
    {
        public FrmNhanVien()
        {
            InitializeComponent();
        }

        KetNoi ketnoi = new KetNoi();

        public void Load_DuLieu_NV()
        {
            DataTable dta = new DataTable();
            dta = ketnoi.Lay_Dulieu("Select * From NhanVien");
            dataGridNV.DataSource = dta;
            Hienthi_Dulieu();
        }

        public void Load_DuLieu_PhongBan()
        {
            DataTable dta = new DataTable();
            dta = ketnoi.Lay_Dulieu("Select * From PhongBan");
            cboMaPB.DataSource = dta;
            cboMaPB.DisplayMember = "mapb";
            cboMaPB.ValueMember = "mapb";
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            Load_DuLieu_NV();
            Load_DuLieu_PhongBan();
            Hienthi_Dulieu();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            txtDOB.Text = "";
        }

        private void btnChen_Click(object sender, EventArgs e)
        {
            string sql1 = "Insert into NhanVien Values('" + txtMaNV.Text + "', '" + txtTenNV.Text + "', '" + txtDOB.Text + "', '" + cboMaPB.Text + "')";
            ketnoi.Execute(sql1);
            Load_DuLieu_NV();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql2 = "Update NhanVien Set manv ='" + txtMaNV.Text + "'";
            sql2 = sql2 + ", tennv ='" + txtTenNV.Text + "', ngaysinh = '" + txtDOB.Text + "', mapb = '" + cboMaPB.Text + "' where manv = '" + txtMaNV.Text + "'";
            ketnoi.Execute(sql2);
            Load_DuLieu_NV();
        }

        private void Hienthi_Dulieu()
        {
            txtMaNV.DataBindings.Clear();
            txtMaNV.DataBindings.Add("Text", dataGridNV.DataSource, "manv");

            txtTenNV.DataBindings.Clear();
            txtTenNV.DataBindings.Add("Text", dataGridNV.DataSource, "tennv");

            txtDOB.DataBindings.Clear();
            txtDOB.DataBindings.Add("Text", dataGridNV.DataSource, "ngaysinh");

            cboMaPB.DataBindings.Clear();
            cboMaPB.DataBindings.Add("Text", dataGridNV.DataSource, "mapb");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ketnoi.Execute("Delete NhanVien Where manv = '" + txtMaNV.Text + "'");
            Load_DuLieu_NV();
        }
    }
}
