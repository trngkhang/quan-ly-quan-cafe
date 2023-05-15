
namespace QL_CAFE
{
    partial class form_login
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
            this.But_DangNhap = new System.Windows.Forms.Button();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Pass = new System.Windows.Forms.TextBox();
            this.But_Thoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // But_DangNhap
            // 
            this.But_DangNhap.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.But_DangNhap.Location = new System.Drawing.Point(154, 150);
            this.But_DangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.But_DangNhap.Name = "But_DangNhap";
            this.But_DangNhap.Size = new System.Drawing.Size(135, 50);
            this.But_DangNhap.TabIndex = 3;
            this.But_DangNhap.Text = "Đăng Nhập";
            this.But_DangNhap.UseVisualStyleBackColor = true;
            this.But_DangNhap.Click += new System.EventHandler(this.But_DangNhap_Click);
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(154, 59);
            this.tb_Name.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(328, 35);
            this.tb_Name.TabIndex = 1;
            // 
            // tb_Pass
            // 
            this.tb_Pass.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Pass.Location = new System.Drawing.Point(154, 104);
            this.tb_Pass.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Pass.Name = "tb_Pass";
            this.tb_Pass.Size = new System.Drawing.Size(328, 35);
            this.tb_Pass.TabIndex = 2;
            this.tb_Pass.UseSystemPasswordChar = true;
            // 
            // But_Thoat
            // 
            this.But_Thoat.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.But_Thoat.Location = new System.Drawing.Point(350, 150);
            this.But_Thoat.Margin = new System.Windows.Forms.Padding(4);
            this.But_Thoat.Name = "But_Thoat";
            this.But_Thoat.Size = new System.Drawing.Size(135, 50);
            this.But_Thoat.TabIndex = 4;
            this.But_Thoat.Text = "Thoát";
            this.But_Thoat.UseVisualStyleBackColor = true;
            this.But_Thoat.Click += new System.EventHandler(this.But_Thoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu\r\n";
            // 
            // form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 257);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.But_Thoat);
            this.Controls.Add(this.tb_Pass);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.But_DangNhap);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button But_DangNhap;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_Pass;
        private System.Windows.Forms.Button But_Thoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}