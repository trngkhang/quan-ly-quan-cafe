
namespace QL_CAFE
{
    partial class form_NhanSu
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
            this.but_Them = new System.Windows.Forms.Button();
            this.but_Xoa = new System.Windows.Forms.Button();
            this.but_Sua = new System.Windows.Forms.Button();
            this.dataGridView_NhanSu = new System.Windows.Forms.DataGridView();
            this.but_Qve = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_MaNV = new System.Windows.Forms.TextBox();
            this.textBox_HoTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_ChucVu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_MatKhau = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NhanSu)).BeginInit();
            this.SuspendLayout();
            // 
            // but_Them
            // 
            this.but_Them.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_Them.Location = new System.Drawing.Point(411, 136);
            this.but_Them.Margin = new System.Windows.Forms.Padding(4);
            this.but_Them.Name = "but_Them";
            this.but_Them.Size = new System.Drawing.Size(106, 44);
            this.but_Them.TabIndex = 1;
            this.but_Them.Text = "Thêm";
            this.but_Them.UseVisualStyleBackColor = true;
            this.but_Them.Click += new System.EventHandler(this.but_Them_Click);
            // 
            // but_Xoa
            // 
            this.but_Xoa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_Xoa.Location = new System.Drawing.Point(527, 136);
            this.but_Xoa.Margin = new System.Windows.Forms.Padding(4);
            this.but_Xoa.Name = "but_Xoa";
            this.but_Xoa.Size = new System.Drawing.Size(106, 44);
            this.but_Xoa.TabIndex = 2;
            this.but_Xoa.Text = "Xoá";
            this.but_Xoa.UseVisualStyleBackColor = true;
            this.but_Xoa.Click += new System.EventHandler(this.but_Xoa_Click);
            // 
            // but_Sua
            // 
            this.but_Sua.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_Sua.Location = new System.Drawing.Point(642, 136);
            this.but_Sua.Margin = new System.Windows.Forms.Padding(4);
            this.but_Sua.Name = "but_Sua";
            this.but_Sua.Size = new System.Drawing.Size(106, 44);
            this.but_Sua.TabIndex = 3;
            this.but_Sua.Text = "Sửa";
            this.but_Sua.UseVisualStyleBackColor = true;
            this.but_Sua.Click += new System.EventHandler(this.but_Sua_Click);
            // 
            // dataGridView_NhanSu
            // 
            this.dataGridView_NhanSu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_NhanSu.Location = new System.Drawing.Point(12, 216);
            this.dataGridView_NhanSu.Name = "dataGridView_NhanSu";
            this.dataGridView_NhanSu.RowHeadersWidth = 62;
            this.dataGridView_NhanSu.RowTemplate.Height = 28;
            this.dataGridView_NhanSu.Size = new System.Drawing.Size(762, 389);
            this.dataGridView_NhanSu.TabIndex = 4;
            this.dataGridView_NhanSu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_NhanSu_CellContentClick);
            // 
            // but_Qve
            // 
            this.but_Qve.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_Qve.Location = new System.Drawing.Point(12, 165);
            this.but_Qve.Margin = new System.Windows.Forms.Padding(4);
            this.but_Qve.Name = "but_Qve";
            this.but_Qve.Size = new System.Drawing.Size(106, 44);
            this.but_Qve.TabIndex = 5;
            this.but_Qve.Text = "Trở về";
            this.but_Qve.UseVisualStyleBackColor = true;
            this.but_Qve.Click += new System.EventHandler(this.but_Qve_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã nhân viên";
            // 
            // textBox_MaNV
            // 
            this.textBox_MaNV.Location = new System.Drawing.Point(137, 19);
            this.textBox_MaNV.Name = "textBox_MaNV";
            this.textBox_MaNV.Size = new System.Drawing.Size(193, 26);
            this.textBox_MaNV.TabIndex = 7;
            // 
            // textBox_HoTen
            // 
            this.textBox_HoTen.Location = new System.Drawing.Point(479, 22);
            this.textBox_HoTen.Name = "textBox_HoTen";
            this.textBox_HoTen.Size = new System.Drawing.Size(212, 26);
            this.textBox_HoTen.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Họ tên";
            // 
            // textBox_ChucVu
            // 
            this.textBox_ChucVu.Location = new System.Drawing.Point(479, 75);
            this.textBox_ChucVu.Name = "textBox_ChucVu";
            this.textBox_ChucVu.Size = new System.Drawing.Size(212, 26);
            this.textBox_ChucVu.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(388, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Chức vụ";
            // 
            // textBox_MatKhau
            // 
            this.textBox_MatKhau.Location = new System.Drawing.Point(137, 75);
            this.textBox_MatKhau.Name = "textBox_MatKhau";
            this.textBox_MatKhau.Size = new System.Drawing.Size(193, 26);
            this.textBox_MatKhau.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Mật khẩu";
            // 
            // form_NhanSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 630);
            this.Controls.Add(this.textBox_MatKhau);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_ChucVu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_HoTen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_MaNV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.but_Qve);
            this.Controls.Add(this.dataGridView_NhanSu);
            this.Controls.Add(this.but_Sua);
            this.Controls.Add(this.but_Xoa);
            this.Controls.Add(this.but_Them);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form_NhanSu";
            this.Text = "Nhân sự";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.form_NhanSu_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NhanSu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button but_Them;
        private System.Windows.Forms.Button but_Xoa;
        private System.Windows.Forms.Button but_Sua;
        private System.Windows.Forms.DataGridView dataGridView_NhanSu;
        private System.Windows.Forms.Button but_Qve;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_MaNV;
        private System.Windows.Forms.TextBox textBox_HoTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_ChucVu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_MatKhau;
        private System.Windows.Forms.Label label5;
    }
}