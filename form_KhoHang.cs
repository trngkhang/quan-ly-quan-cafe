using QL_CAFE;
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
    public partial class form_KhoHang : Form
    {
        public form_KhoHang()
        {
            InitializeComponent();
            loadKhoList();
        }

        void loadKhoList()
        {
            string query = "select TenSP as [Tên sản phẩm], SoLuong as [Số Lượng], DonVi as [Đơn vị] from KHOHANG";
            DataProvider provider = new DataProvider();
            dtgv_KhoHang.DataSource = provider.ExcuteQuery(query);
        }

        private void but_Qve_Click(object sender, EventArgs e)
        {
            form_main f = new form_main();
            f.Show();
            this.Hide();
        }

        private void form_KhoHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            form_main f = new form_main();
            f.Show();
            this.Hide();
        }

        private void dtgv_KhoHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dtgv_KhoHang.CurrentRow.Index;
            comboBox_TenMon.Text = dtgv_KhoHang.Rows[i].Cells[0].Value.ToString();
            numericUpDown_SoLuong.Text = dtgv_KhoHang.Rows[i].Cells[1].Value.ToString();
        }

        private void but_ThayDoi_Click(object sender, EventArgs e)
        {
            if (comboBox_TenMon.Text=="" || numericUpDown_SoLuong.Value.ToString() == "")
            {
                MessageBox.Show("Chưa nhập hoặc dữ liệu chưa chính xác!");
            }
            else
            {
                string query = "update KHOHANG set SoLuong = '"+ numericUpDown_SoLuong.Value.ToString() + "' where TenSP = N'"+ comboBox_TenMon.Text.ToString() + "'";
                DataProvider.RunSQL(query);
                loadKhoList();
            }
        }
    }
}
