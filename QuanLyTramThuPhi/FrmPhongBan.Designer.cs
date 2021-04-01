
namespace QuanLyTramThuPhi
{
    partial class FrmPhongBan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboMaTram = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridPB = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnChen = new System.Windows.Forms.Button();
            this.btnTao = new System.Windows.Forms.Button();
            this.txtTenPB = new System.Windows.Forms.TextBox();
            this.txtMaPB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPB)).BeginInit();
            this.SuspendLayout();
            // 
            // cboMaTram
            // 
            this.cboMaTram.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaTram.FormattingEnabled = true;
            this.cboMaTram.Location = new System.Drawing.Point(203, 140);
            this.cboMaTram.Name = "cboMaTram";
            this.cboMaTram.Size = new System.Drawing.Size(337, 33);
            this.cboMaTram.TabIndex = 125;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(226, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(370, 37);
            this.label4.TabIndex = 121;
            this.label4.Text = "CHI TIẾT PHÒNG BAN";
            // 
            // dataGridPB
            // 
            this.dataGridPB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPB.Location = new System.Drawing.Point(52, 273);
            this.dataGridPB.Name = "dataGridPB";
            this.dataGridPB.Size = new System.Drawing.Size(473, 165);
            this.dataGridPB.TabIndex = 120;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnThoat.Location = new System.Drawing.Point(633, 368);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(120, 70);
            this.btnThoat.TabIndex = 119;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnXoa.Location = new System.Drawing.Point(633, 283);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(120, 70);
            this.btnXoa.TabIndex = 118;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnSua.Location = new System.Drawing.Point(633, 205);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(120, 70);
            this.btnSua.TabIndex = 117;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnChen
            // 
            this.btnChen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnChen.Location = new System.Drawing.Point(633, 128);
            this.btnChen.Name = "btnChen";
            this.btnChen.Size = new System.Drawing.Size(120, 70);
            this.btnChen.TabIndex = 116;
            this.btnChen.Text = "Chèn";
            this.btnChen.UseVisualStyleBackColor = true;
            this.btnChen.Click += new System.EventHandler(this.btnChen_Click);
            // 
            // btnTao
            // 
            this.btnTao.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnTao.Location = new System.Drawing.Point(633, 52);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(120, 70);
            this.btnTao.TabIndex = 115;
            this.btnTao.Text = "Tạo mới";
            this.btnTao.UseVisualStyleBackColor = true;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // txtTenPB
            // 
            this.txtTenPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtTenPB.Location = new System.Drawing.Point(203, 90);
            this.txtTenPB.Name = "txtTenPB";
            this.txtTenPB.Size = new System.Drawing.Size(337, 32);
            this.txtTenPB.TabIndex = 113;
            // 
            // txtMaPB
            // 
            this.txtMaPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtMaPB.Location = new System.Drawing.Point(203, 55);
            this.txtMaPB.Name = "txtMaPB";
            this.txtMaPB.Size = new System.Drawing.Size(337, 32);
            this.txtMaPB.TabIndex = 112;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(47, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 26);
            this.label3.TabIndex = 111;
            this.label3.Text = "Mã phòng ban";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(47, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 26);
            this.label2.TabIndex = 110;
            this.label2.Text = "Tên phòng ban";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(47, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 26);
            this.label1.TabIndex = 109;
            this.label1.Text = "Mã trạm";
            // 
            // FrmPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboMaTram);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridPB);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnChen);
            this.Controls.Add(this.btnTao);
            this.Controls.Add(this.txtTenPB);
            this.Controls.Add(this.txtMaPB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmPhongBan";
            this.Text = "PhongBan";
            this.Load += new System.EventHandler(this.FrmPhongBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboMaTram;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridPB;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnChen;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.TextBox txtTenPB;
        private System.Windows.Forms.TextBox txtMaPB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}