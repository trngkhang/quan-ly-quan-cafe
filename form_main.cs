using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_CAFE
{
    public partial class form_main : Form
    {
        public form_main()
        {
            InitializeComponent();
        }
        //dang xuat
        bool IsThoat = true;
        private void But_DangXuat_Click(object sender, EventArgs e)
        {
            IsThoat = false;
            this.Close();
            form_login f = new form_login();
            f.Show();
        }

        private void form_main_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (IsThoat)
                Application.Exit();
        }
        //ban hang
        private void But_Sale_Click(object sender, EventArgs e)
        {
            form_menu f = new form_menu();
            f.Show();
            this.Hide();
        }
        //nhan su
        private void But_Staff_Click(object sender, EventArgs e)
        {
            form_NhanSu f = new form_NhanSu();
            f.Show();
            this.Hide();
        }
        //kho hang
        private void But_Store_Click(object sender, EventArgs e)
        {
            form_KhoHang f = new form_KhoHang();
            f.Show();
            this.Hide();
        }
    }
}
