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
    public partial class FrmPhongBan : Form
    {
        public FrmPhongBan()
        {
            InitializeComponent();
        }

        KetNoi ketnoi = new KetNoi();

        public void Load_DuLieu_PB()
        {
            DataTable dta = new DataTable();
            dta = ketnoi.Lay_Dulieu("Select * From PhongBan");
            dataGridPB.DataSource = dta;
            Hienthi_Dulieu();
        }

        public void Load_DuLieu_TramThuPhi()
        {
            DataTable dta = new DataTable();
            dta = ketnoi.Lay_Dulieu("Select * From TramThuPhi");
            cboMaTram.DataSource = dta;
            cboMaTram.DisplayMember = "matram";
            cboMaTram.ValueMember = "matram";
        }

        private void FrmPhongBan_Load(object sender, EventArgs e)
        {
            Load_DuLieu_PB();
            Load_DuLieu_TramThuPhi();
            Hienthi_Dulieu();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            txtMaPB.Text = "";
            txtTenPB.Text = "";
        }

        private void btnChen_Click(object sender, EventArgs e)
        {
            string sql1 = "Insert into PhongBan Values('" + txtMaPB.Text +  "', '" + txtTenPB.Text + "', '" + cboMaTram.Text + "')";
            ketnoi.Execute(sql1);
            Load_DuLieu_PB();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql2 = "Update PhongBan Set mapb ='" + txtMaPB.Text + "'";
            sql2 = sql2 + ", tenpb ='" + txtTenPB.Text + "', matram = '" + cboMaTram.Text + "' where mapb = '" + txtMaPB.Text + "'";
            ketnoi.Execute(sql2);
            Load_DuLieu_PB();
        }

        private void Hienthi_Dulieu()
        {
            txtMaPB.DataBindings.Clear();
            txtMaPB.DataBindings.Add("Text", dataGridPB.DataSource, "mapb");

            txtTenPB.DataBindings.Clear();
            txtTenPB.DataBindings.Add("Text", dataGridPB.DataSource, "tenpb");

            cboMaTram.DataBindings.Clear();
            cboMaTram.DataBindings.Add("Text", dataGridPB.DataSource, "matram");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ketnoi.Execute("Delete PhongBan Where mave = '" + txtMaPB.Text + "'");
            Load_DuLieu_PB();
        }
    }
}
