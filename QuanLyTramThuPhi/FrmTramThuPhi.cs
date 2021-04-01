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
    public partial class FrmTramThuPhi : Form
    {
        public FrmTramThuPhi()
        {
            InitializeComponent();
        }


        KetNoi ketnoi = new KetNoi();

        public void Load_DuLieu_TramThuPhi()
        {
            DataTable dta = new DataTable();
            dta = ketnoi.Lay_Dulieu("Select * From TramThuPhi");
            dataGridTram.DataSource = dta;
            Hienthi_Dulieu();
        }

        private void FrmTramThuPhi_Load(object sender, EventArgs e)
        {
            Load_DuLieu_TramThuPhi();
            Hienthi_Dulieu();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            txtMaTram.Text = "";
            txtTenTram.Text = "";
            txtDiaChi.Text = "";
        }

        private void btnChen_Click(object sender, EventArgs e)
        {
            string sql1 = "Insert into TramThuPhi Values('" + txtMaTram.Text + "' , '" + txtTenTram.Text + "', '" + txtDiaChi.Text + "')";
            ketnoi.Execute(sql1);
            Load_DuLieu_TramThuPhi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql2 = "Update TramThuPhi Set matram ='" + txtMaTram.Text + "'";
            sql2 = sql2 + ", tentram ='" + txtTenTram.Text + "', diachi = '" + txtDiaChi.Text + "' where matram = '" + txtMaTram.Text + "'";
            ketnoi.Execute(sql2);
            Load_DuLieu_TramThuPhi();
        }

        private void Hienthi_Dulieu()
        {
            txtMaTram.DataBindings.Clear();
            txtMaTram.DataBindings.Add("Text", dataGridTram.DataSource, "matram");

            txtTenTram.DataBindings.Clear();
            txtTenTram.DataBindings.Add("Text", dataGridTram.DataSource, "tentram");

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dataGridTram.DataSource, "diachi");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ketnoi.Execute("Delete Xe Where bienso = '" + txtMaTram.Text + "'");
            Load_DuLieu_TramThuPhi();
        }
    }
}
