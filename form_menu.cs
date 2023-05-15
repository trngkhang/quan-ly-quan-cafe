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
    public partial class form_menu : Form
    {
        public form_menu()
        {
            InitializeComponent();
            
        }

        public double Cost_of_items()
        {
            double sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);
            }
            return sum;
        }
        void resetAll()
        {
            lbl_SubTotal.Text = "";
            lbl_tax.Text = "";
            lbl_Total.Text = "";
            lbl_cash.Text = "0";
            lbl_change.Text = "";

            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            cbo_payment.Text = "";
        }
//tinh tong sp
        private void AddCost()
        {
            double tax, q;
            tax = 1.5;
            if (dataGridView1.Rows.Count > 0)
            {
                
                lbl_tax.Text = Convert.ToString(((Cost_of_items() * tax) / 100));
                lbl_SubTotal.Text = Convert.ToString(Cost_of_items());
                q = (Cost_of_items() * tax) / 100;
                lbl_Total.Text = Convert.ToString(Cost_of_items() + q);
            }
        }
//tien thua
        private void Change()
        {
            double tax, q, c;
            tax = 1.5;
            if (dataGridView1.Rows.Count > 0)
            {
                q = ((Cost_of_items() * tax) / 100) + Cost_of_items();
                c = Convert.ToInt32(lbl_cash.Text);
                lbl_change.Text = Convert.ToString(c - q);

            }
        }

        Bitmap bitmap;
//button in bill
        private void bt_print_Click(object sender, EventArgs e)
        {
            try
            {
                int height = dataGridView1.Height;
                dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
                bitmap = new Bitmap(dataGridView1.Width, dataGridView1.Height);
                dataGridView1.DrawToBitmap(bitmap, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
                printPreviewDialog1.PrintPreviewControl.Zoom = 1;
                printPreviewDialog1.ShowDialog();
                dataGridView1.Height = height;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                e.Graphics.DrawImage(bitmap, 0, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
//button reset
        private void bt_Reset_Click(object sender, EventArgs e)
        {
            resetAll();
        }

        private void form_menu_Load(object sender, EventArgs e)
        {
            cbo_payment.Items.Add("Cash");
            cbo_payment.Items.Add("Visa Card");
            cbo_payment.Items.Add("Master Card");
        }
//cac nut number
        private void NumberSOnly(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (lbl_cash.Text == "0")
            {
                lbl_cash.Text = "";
                lbl_cash.Text = b.Text;
            }
            else if (b.Text == ".")
            {
                if (!lbl_cash.Text.Contains("."))
                {
                    lbl_cash.Text += b.Text;
                }
            }
            else
                lbl_cash.Text += b.Text;
        }

        private void bt_C_Click(object sender, EventArgs e)
        {
            lbl_cash.Text = "0";
        }
//button Thanh toan
        private void bt_Pay_Click(object sender, EventArgs e)
        {
            bool checkPay=false;
            if ((cbo_payment.Text == "Cash") && (Convert.ToInt32(lbl_cash.Text) >= Convert.ToInt32(lbl_Total.Text)))
            {
                Change();
                checkPay= true;

            }
            else if (cbo_payment.Text == "Visa Card" || cbo_payment.Text == "Master Card")
            {
                lbl_change.Text = "0";
                lbl_cash.Text = "0";
                checkPay= true;
            }
            else
                MessageBox.Show("Không thể thanh toán");
            if (checkPay)
            {
                //resetAll();
            }

        }
//button remove item
        private void bt_Remove_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
            AddCost();
            
        }
        //cafe sua
        private void bt_CafeSua_Click(object sender, EventArgs e)
        {
            double ItemCost = 20000;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Ca Phe Sua"))
                {
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = double.Parse((string)row.Cells[2].Value) * ItemCost;
                }
            }
            dataGridView1.Rows.Add("Ca Phe Sua", "1", ItemCost);
            AddCost();
        }
        //cafe den
        private void bt_CafeDen_Click(object sender, EventArgs e)
        {
            double ItemCost = 18000;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Ca Phe Den"))
                {
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = double.Parse((string)row.Cells[2].Value) * ItemCost;
                }
            }
            dataGridView1.Rows.Add("Ca Phe Den", "1", ItemCost);
            AddCost();
        }
        //Bac Xiu
        private void bt_BacXiu_Click(object sender, EventArgs e)
        {
            double ItemCost = 25000;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Bac xiu"))
                {
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = double.Parse((string)row.Cells[2].Value) * ItemCost;
                }
            }
            dataGridView1.Rows.Add("Bac xiu", "1", ItemCost);
            AddCost();
        }
        //cookie da xay
        private void bt_CookieDX_Click(object sender, EventArgs e)
        {
            double ItemCost = 30000;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Cookie da xay"))
                {
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = double.Parse((string)row.Cells[2].Value) * ItemCost;
                }
            }
            dataGridView1.Rows.Add("Cookie da xay", "1", ItemCost);
            AddCost();
        }
        //ca cao
        private void bt_Cacao_Click(object sender, EventArgs e)
        {
            double ItemCost = 33000;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Ca cao"))
                {
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = double.Parse((string)row.Cells[2].Value) * ItemCost;
                }
            }
            dataGridView1.Rows.Add("Ca cao", "1", ItemCost);
            AddCost();
        }
        //ST_Bo
        private void bt_STBo_Click(object sender, EventArgs e)
        {
            double ItemCost = 25000;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Sinh to Bo"))
                {
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = double.Parse((string)row.Cells[2].Value) * ItemCost;
                }
            }
            dataGridView1.Rows.Add("Sinh to Bo", "1", ItemCost);
            AddCost();
        }
        //ST_Dau
        private void bt_STDau_Click(object sender, EventArgs e)
        {
            double ItemCost = 25000;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Sinh to Dau"))
                {
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = double.Parse((string)row.Cells[2].Value) * ItemCost;
                }
            }
            dataGridView1.Rows.Add("Sinh to Dau", "1", ItemCost);
            AddCost();
        }
        //ST_Xoai
        private void bt_STXoai_Click(object sender, EventArgs e)
        {
            double ItemCost = 25000;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Sinh to Xoai"))
                {
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = double.Parse((string)row.Cells[2].Value) * ItemCost;
                }
            }
            dataGridView1.Rows.Add("Sinh to Xoai", "1", ItemCost);
            AddCost();
        }
        //ST_Carot
        private void bt_STCarot_Click(object sender, EventArgs e)
        {
            double ItemCost = 25000;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Sinh to Ca rot"))
                {
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = double.Parse((string)row.Cells[2].Value) * ItemCost;
                }
            }
            dataGridView1.Rows.Add("Sinh to Ca rot", "1", ItemCost);
            AddCost();
        }
        //ST_cam
        private void bt_STCam_Click(object sender, EventArgs e)
        {
            double ItemCost = 25000;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Sinh to Cam"))
                {
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = double.Parse((string)row.Cells[2].Value) * ItemCost;
                }
            }
            dataGridView1.Rows.Add("Sinh to Cam", "1", ItemCost);
            AddCost();
        }
        //Tra Chanh
        private void bt_TraChanh_Click(object sender, EventArgs e)
        {
            double ItemCost = 18000;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Tra Chanh"))
                {
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = double.Parse((string)row.Cells[2].Value) * ItemCost;
                }
            }
            dataGridView1.Rows.Add("Tra Chanh", "1", ItemCost);
            AddCost();
        }
        //Tra Vai
        private void bt_TraVai_Click(object sender, EventArgs e)
        {
            double ItemCost = 18000;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Tra Vai"))
                {
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = double.Parse((string)row.Cells[2].Value) * ItemCost;
                }
            }
            dataGridView1.Rows.Add("Tra Vai", "1", ItemCost);
            AddCost();
        }
        //Tra Dao
        private void bt_TraDao_Click(object sender, EventArgs e)
        {
            double ItemCost = 20000;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Tra Dao"))
                {
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = double.Parse((string)row.Cells[2].Value) * ItemCost;
                }
            }
            dataGridView1.Rows.Add("Tra Dao", "1", ItemCost);
            AddCost();
        }
        //Tra Tac
        private void bt_TraTac_Click(object sender, EventArgs e)
        {
            double ItemCost = 18000;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Tra Tac"))
                {
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = double.Parse((string)row.Cells[2].Value) * ItemCost;
                }
            }
            dataGridView1.Rows.Add("Tra Tac", "1", ItemCost);
            AddCost();
        }
        //Banh Flan
        private void bt_BFlan_Click(object sender, EventArgs e)
        {
            double ItemCost = 15000;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Banh Flan"))
                {
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = double.Parse((string)row.Cells[2].Value) * ItemCost;
                }
            }
            dataGridView1.Rows.Add("Banh Flan", "1", ItemCost);
            AddCost();
        }
        //Banh Donut
        private void bt_BDonut_Click(object sender, EventArgs e)
        {
            double ItemCost = 22000;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Banh Donut"))
                {
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = double.Parse((string)row.Cells[2].Value) * ItemCost;
                }
            }
            dataGridView1.Rows.Add("Banh Donut", "1", ItemCost);
            AddCost();
        }
        //Banh Bong Lan
        private void bt_BLan_Click(object sender, EventArgs e)
        {
            double ItemCost = 25000;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Banh Bong Lan"))
                {
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = double.Parse((string)row.Cells[2].Value) * ItemCost;
                }
            }
            dataGridView1.Rows.Add("Banh Bong Lan", "1", ItemCost);
            AddCost();
        }
        //Kem Vani
        private void bt_KemVani_Click(object sender, EventArgs e)
        {
            double ItemCost = 3000;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Kem Vanila"))
                {
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = double.Parse((string)row.Cells[2].Value) * ItemCost;
                }
            }
            dataGridView1.Rows.Add("Kem Vanila", "1", ItemCost);
            AddCost();
        }

        private void bt_KemSoco_Click(object sender, EventArgs e)
        {
            double ItemCost = 3000;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Kem Socola"))
                {
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = double.Parse((string)row.Cells[2].Value) * ItemCost;
                }
            }
            dataGridView1.Rows.Add("Kem Socola", "1", ItemCost);
            AddCost();
        }

        private void bt_Kem2mau_Click(object sender, EventArgs e)
        {
            double ItemCost = 3000;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Kem 2 mau"))
                {
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = double.Parse((string)row.Cells[2].Value) * ItemCost;
                }
            }
            dataGridView1.Rows.Add("Kem 2 mau", "1", ItemCost);
            AddCost();
        }

        private void but_Qve_Click(object sender, EventArgs e)
        {
            form_main f = new form_main();
            f.Show();
            this.Hide();
        }

        private void form_menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            form_main f = new form_main();
            f.Show();
            this.Hide();
        }
    }
}
