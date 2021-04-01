
namespace QuanLyTramThuPhi
{
    partial class FrmTramThuPhi
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridTram = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnChen = new System.Windows.Forms.Button();
            this.btnTao = new System.Windows.Forms.Button();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenTram = new System.Windows.Forms.TextBox();
            this.txtMaTram = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTram)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label5.Location = new System.Drawing.Point(47, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 26);
            this.label5.TabIndex = 122;
            this.label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(175, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(452, 37);
            this.label4.TabIndex = 121;
            this.label4.Text = "THÔNG TIN TRẠM THU PHÍ";
            // 
            // dataGridTram
            // 
            this.dataGridTram.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTram.Location = new System.Drawing.Point(52, 273);
            this.dataGridTram.Name = "dataGridTram";
            this.dataGridTram.Size = new System.Drawing.Size(473, 165);
            this.dataGridTram.TabIndex = 120;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnThoat.Location = new System.Drawing.Point(633, 359);
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
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtDiaChi.Location = new System.Drawing.Point(165, 185);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(337, 32);
            this.txtDiaChi.TabIndex = 114;
            // 
            // txtTenTram
            // 
            this.txtTenTram.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtTenTram.Location = new System.Drawing.Point(165, 128);
            this.txtTenTram.Name = "txtTenTram";
            this.txtTenTram.Size = new System.Drawing.Size(337, 32);
            this.txtTenTram.TabIndex = 113;
            // 
            // txtMaTram
            // 
            this.txtMaTram.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtMaTram.Location = new System.Drawing.Point(165, 87);
            this.txtMaTram.Name = "txtMaTram";
            this.txtMaTram.Size = new System.Drawing.Size(337, 32);
            this.txtMaTram.TabIndex = 112;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(47, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 26);
            this.label3.TabIndex = 111;
            this.label3.Text = "Mã trạm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(47, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 26);
            this.label2.TabIndex = 110;
            this.label2.Text = "Tên trạm";
            // 
            // FrmTramThuPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridTram);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnChen);
            this.Controls.Add(this.btnTao);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtTenTram);
            this.Controls.Add(this.txtMaTram);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FrmTramThuPhi";
            this.Text = "FrmTramThuPhi";
            this.Load += new System.EventHandler(this.FrmTramThuPhi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridTram;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnChen;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenTram;
        private System.Windows.Forms.TextBox txtMaTram;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}