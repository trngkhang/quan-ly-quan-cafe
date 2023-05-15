using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QL_CAFE.DAO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QL_CAFE
{
    public partial class form_login : Form
    {
        public form_login()
        {
            InitializeComponent();
        }

        private void But_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void But_DangNhap_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\KHANG;Initial Catalog=SQL_QLCafe;Integrated Security=True");

            try
            {
                con.Open();
                string tk = tb_Name.Text.Trim().ToString();
                string mk = tb_Pass.Text.Trim().ToString();
                string sql = "Select MaNV,MatKhau from NHANVIEN WHERE MaNV ='" + tk + "' and MatKhau = '" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader dta = cmd.ExecuteReader();// thi hành lệnh - trả về đối tượng giao diện IDataReader như SqlDataReader, từ đó đọc được dữ liệu trả về
                if (dta.Read() )
                {
                    form_main f = new form_main();
                    f.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu chưa đúng");
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Lỗi kết nối");
            }

        }
    }
}
