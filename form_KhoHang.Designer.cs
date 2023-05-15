
namespace QL_CAFE
{
    partial class form_KhoHang
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
            this.dtgv_KhoHang = new System.Windows.Forms.DataGridView();
            this.but_ThayDoi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.but_Qve = new System.Windows.Forms.Button();
            this.numericUpDown_SoLuong = new System.Windows.Forms.NumericUpDown();
            this.comboBox_TenMon = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_KhoHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_KhoHang
            // 
            this.dtgv_KhoHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_KhoHang.Location = new System.Drawing.Point(255, 17);
            this.dtgv_KhoHang.Margin = new System.Windows.Forms.Padding(4);
            this.dtgv_KhoHang.MultiSelect = false;
            this.dtgv_KhoHang.Name = "dtgv_KhoHang";
            this.dtgv_KhoHang.RowHeadersWidth = 62;
            this.dtgv_KhoHang.Size = new System.Drawing.Size(609, 367);
            this.dtgv_KhoHang.TabIndex = 0;
            this.dtgv_KhoHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_KhoHang_CellContentClick);
            // 
            // but_ThayDoi
            // 
            this.but_ThayDoi.Location = new System.Drawing.Point(73, 126);
            this.but_ThayDoi.Margin = new System.Windows.Forms.Padding(4);
            this.but_ThayDoi.Name = "but_ThayDoi";
            this.but_ThayDoi.Size = new System.Drawing.Size(105, 49);
            this.but_ThayDoi.TabIndex = 3;
            this.but_ThayDoi.Text = "Thay đổi";
            this.but_ThayDoi.UseVisualStyleBackColor = true;
            this.but_ThayDoi.Click += new System.EventHandler(this.but_ThayDoi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(18, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên món";
            // 
            // but_Qve
            // 
            this.but_Qve.Location = new System.Drawing.Point(129, 335);
            this.but_Qve.Margin = new System.Windows.Forms.Padding(4);
            this.but_Qve.Name = "but_Qve";
            this.but_Qve.Size = new System.Drawing.Size(105, 49);
            this.but_Qve.TabIndex = 4;
            this.but_Qve.Text = "trở về";
            this.but_Qve.UseVisualStyleBackColor = true;
            this.but_Qve.Click += new System.EventHandler(this.but_Qve_Click);
            // 
            // numericUpDown_SoLuong
            // 
            this.numericUpDown_SoLuong.Location = new System.Drawing.Point(129, 77);
            this.numericUpDown_SoLuong.Name = "numericUpDown_SoLuong";
            this.numericUpDown_SoLuong.Size = new System.Drawing.Size(117, 26);
            this.numericUpDown_SoLuong.TabIndex = 5;
            // 
            // comboBox_TenMon
            // 
            this.comboBox_TenMon.FormattingEnabled = true;
            this.comboBox_TenMon.Items.AddRange(new object[] {
            "Cafe sữa",
            "Cafe đen",
            "Trà đào",
            "Trà vải",
            "Trà chanh",
            "Trà tắc",
            "Sinh tố cà rốt",
            "Sinh tố xoài",
            "Sinh tố bơ",
            "Sinh tố dâu",
            "Bánh bông lan",
            "Bánh flan",
            "Bánh donut",
            "Kem vani",
            "Kem socola",
            "Bạc xỉu",
            "Cookie đá xay",
            "Ca cao",
            "Sinh tố cam",
            "Kem 2 màu"});
            this.comboBox_TenMon.Location = new System.Drawing.Point(111, 31);
            this.comboBox_TenMon.Name = "comboBox_TenMon";
            this.comboBox_TenMon.Size = new System.Drawing.Size(135, 28);
            this.comboBox_TenMon.TabIndex = 6;
            // 
            // form_KhoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 401);
            this.Controls.Add(this.comboBox_TenMon);
            this.Controls.Add(this.numericUpDown_SoLuong);
            this.Controls.Add(this.but_Qve);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.but_ThayDoi);
            this.Controls.Add(this.dtgv_KhoHang);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form_KhoHang";
            this.Text = "KhoHang";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.form_KhoHang_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_KhoHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_KhoHang;
        private System.Windows.Forms.Button but_ThayDoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button but_Qve;
        private System.Windows.Forms.NumericUpDown numericUpDown_SoLuong;
        private System.Windows.Forms.ComboBox comboBox_TenMon;
    }
}