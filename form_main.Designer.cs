
namespace QL_CAFE
{
    partial class form_main
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
            this.label1 = new System.Windows.Forms.Label();
            this.But_Sale = new System.Windows.Forms.Button();
            this.But_Staff = new System.Windows.Forms.Button();
            this.But_Store = new System.Windows.Forms.Button();
            this.But_DangXuat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(281, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Coffee Shop Management\r\n";
            // 
            // But_Sale
            // 
            this.But_Sale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.But_Sale.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.But_Sale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.But_Sale.Location = new System.Drawing.Point(344, 100);
            this.But_Sale.Name = "But_Sale";
            this.But_Sale.Size = new System.Drawing.Size(200, 50);
            this.But_Sale.TabIndex = 1;
            this.But_Sale.Text = "Bán Hàng";
            this.But_Sale.UseVisualStyleBackColor = false;
            this.But_Sale.Click += new System.EventHandler(this.But_Sale_Click);
            // 
            // But_Staff
            // 
            this.But_Staff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.But_Staff.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.But_Staff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.But_Staff.Location = new System.Drawing.Point(344, 156);
            this.But_Staff.Name = "But_Staff";
            this.But_Staff.Size = new System.Drawing.Size(200, 50);
            this.But_Staff.TabIndex = 2;
            this.But_Staff.Text = "Nhân Sự";
            this.But_Staff.UseVisualStyleBackColor = false;
            this.But_Staff.Click += new System.EventHandler(this.But_Staff_Click);
            // 
            // But_Store
            // 
            this.But_Store.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.But_Store.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.But_Store.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.But_Store.Location = new System.Drawing.Point(344, 212);
            this.But_Store.Name = "But_Store";
            this.But_Store.Size = new System.Drawing.Size(200, 50);
            this.But_Store.TabIndex = 3;
            this.But_Store.Text = "Kho Hàng";
            this.But_Store.UseVisualStyleBackColor = false;
            this.But_Store.Click += new System.EventHandler(this.But_Store_Click);
            // 
            // But_DangXuat
            // 
            this.But_DangXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.But_DangXuat.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.But_DangXuat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.But_DangXuat.Location = new System.Drawing.Point(344, 268);
            this.But_DangXuat.Name = "But_DangXuat";
            this.But_DangXuat.Size = new System.Drawing.Size(200, 50);
            this.But_DangXuat.TabIndex = 4;
            this.But_DangXuat.Text = "Đăng Xuất";
            this.But_DangXuat.UseVisualStyleBackColor = false;
            this.But_DangXuat.Click += new System.EventHandler(this.But_DangXuat_Click);
            // 
            // form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.But_DangXuat);
            this.Controls.Add(this.But_Store);
            this.Controls.Add(this.But_Staff);
            this.Controls.Add(this.But_Sale);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Name = "form_main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.form_main_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button But_Sale;
        private System.Windows.Forms.Button But_Staff;
        private System.Windows.Forms.Button But_Store;
        private System.Windows.Forms.Button But_DangXuat;
    }
}