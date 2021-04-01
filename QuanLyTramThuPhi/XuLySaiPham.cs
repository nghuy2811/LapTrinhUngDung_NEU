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
    public partial class XuLySaiPham : Form
    {
        public XuLySaiPham()
        {
            InitializeComponent();
        }

        KetNoi ketnoi = new KetNoi();

        public void Load_DuLieu_XLSP()
        {
            DataTable dta = new DataTable();
            dta = ketnoi.Lay_Dulieu("Select * From XuLySaiPham");
            dataGridViPham.DataSource = dta;
            Hienthi_Dulieu();
        }

        public void Load_DuLieu_Ve()
        {
            DataTable dta = new DataTable();
            dta = ketnoi.Lay_Dulieu("Select * From Ve");
            cboMaVe.DataSource = dta;
            cboMaVe.DisplayMember = "mave";
            cboMaVe.ValueMember = "mave";
        }

        public void Load_DuLieu_Xe()
        {
            DataTable dta = new DataTable();
            dta = ketnoi.Lay_Dulieu("Select * From Xe");
            cboBienSo.DataSource = dta;
            cboBienSo.DisplayMember = "bienso";
            cboBienSo.ValueMember = "bienso";
        }

        private void XuLySaiPham_Load(object sender, EventArgs e)
        {
            Load_DuLieu_XLSP();
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
            txtMaLoi.Text = "";
            txtTenLoi.Text = "";
            txtMucPhat.Text = "";
        }

        private void btnChen_Click(object sender, EventArgs e)
        {
            string sql1 = "Insert into XuLySaiPham Values('" + txtMaLoi.Text + "', '" + txtTenLoi.Text + "', '" + txtMucPhat.Text + "', '" + cboMaVe.Text + "', '" + cboBienSo.Text + "')";
            ketnoi.Execute(sql1);
            Load_DuLieu_XLSP();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql2 = "Update XuLySaiPham Set maloi ='" + txtMaLoi.Text + "'";
            sql2 = sql2 + ", tenloi ='" + txtTenLoi.Text + "', mucphat = '" + txtMucPhat.Text + "', mave = '" + cboMaVe.Text + "', bienso = '" + cboBienSo.Text + "' where maloi = '" + txtMaLoi.Text + "'";
            ketnoi.Execute(sql2);
            Load_DuLieu_XLSP();
        }

        private void Hienthi_Dulieu()
        {
            txtMaLoi.DataBindings.Clear();
            txtMaLoi.DataBindings.Add("Text", dataGridViPham.DataSource, "maloi");

            txtTenLoi.DataBindings.Clear();
            txtTenLoi.DataBindings.Add("Text", dataGridViPham.DataSource, "tenloi");

            txtMucPhat.DataBindings.Clear();
            txtMucPhat.DataBindings.Add("Text", dataGridViPham.DataSource, "mucphat");

            cboMaVe.DataBindings.Clear();
            cboMaVe.DataBindings.Add("Text", dataGridViPham.DataSource, "mave");

            cboBienSo.DataBindings.Clear();
            cboBienSo.DataBindings.Add("Text", dataGridViPham.DataSource, "bienso");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ketnoi.Execute("Delete XuLySaiPham Where manv = '" + txtMaLoi.Text + "'");
            Load_DuLieu_XLSP();
        }
    }
}
