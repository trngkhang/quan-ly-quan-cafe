using QL_CAFE.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QL_CAFE
{
    public partial class form_NhanSu : Form
    {

        public form_NhanSu()
        {
            InitializeComponent();
            loadNhanSuList();
        }
        void loadNhanSuList()
        {
            string query = "select MaNV as [Mã nhân viên],MatKhau as [Mật khẩu] ,HoTen as [Họ tên],ChucVu as [Chức vụ] from NHANVIEN";
            DataProvider provider = new DataProvider();
            dataGridView_NhanSu.DataSource = provider.ExcuteQuery(query);
        }

        private void but_Qve_Click(object sender, EventArgs e)
        {
            form_main f = new form_main();
            f.Show();
            this.Hide();
        }

        private void form_NhanSu_FormClosed(object sender, FormClosedEventArgs e)
        {
            form_main f = new form_main();
            f.Show();
            this.Hide();
        }

        private void dataGridView_NhanSu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView_NhanSu.CurrentRow.Index;
            textBox_MaNV.Text = dataGridView_NhanSu.Rows[i].Cells[0].Value.ToString();
            textBox_MatKhau.Text = dataGridView_NhanSu.Rows[i].Cells[1].Value.ToString();
            textBox_HoTen.Text = dataGridView_NhanSu.Rows[i].Cells[2].Value.ToString();
            textBox_ChucVu.Text = dataGridView_NhanSu.Rows[i].Cells[3].Value.ToString();
        }
        bool checkEmptyTextBox()
        {
            if (textBox_MaNV.Text == "" || textBox_MatKhau.Text == "" || textBox_HoTen.Text == "" || textBox_ChucVu.Text == "")
            {
                return true;
            }
            return false;
        }

        private void but_Them_Click(object sender, EventArgs e)
        {
            if (checkEmptyTextBox())
            {
                MessageBox.Show("Chưa nhập hoặc dữ liệu chưa chính xác!");
            }
            else
            {
                string query = "insert into NHANVIEN values('"+ textBox_MaNV.Text.ToString() + "','"+ textBox_MatKhau.Text.ToString() + "'," +
                    "N'"+ textBox_HoTen.Text.ToString() + "',N'"+ textBox_ChucVu.Text.ToString() + "')";
                DataProvider.RunSQL(query);
                loadNhanSuList();
            }
        }

        private void but_Xoa_Click(object sender, EventArgs e)
        {
            if (checkEmptyTextBox())
            {
                MessageBox.Show("Chưa nhập hoặc dữ liệu chưa chính xác!");
            }
            else
            {
                string query = "delete from NHANVIEN where MaNV='"+ textBox_MaNV.Text.ToString() + "'";
                DataProvider.RunSQL(query);
                loadNhanSuList();
            }
        }

        private void but_Sua_Click(object sender, EventArgs e)
        {
            if (checkEmptyTextBox())
            {
                MessageBox.Show("Chưa nhập hoặc dữ liệu chưa chính xác!");
            }
            else
            {
                string query = "update NHANVIEN set MatKhau = '" + textBox_MatKhau.Text.ToString() + "',HoTen=N'"+textBox_HoTen.Text.ToString()+ "',ChucVu=N'"+textBox_ChucVu.Text.ToString()+"' where MaNV = '" + textBox_MaNV.Text.ToString() + "'";
                DataProvider.RunSQL(query);
                loadNhanSuList();
            }
        }
    }
}
