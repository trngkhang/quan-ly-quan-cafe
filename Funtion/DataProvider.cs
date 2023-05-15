using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;

namespace QL_CAFE.DAO
{
    public class DataProvider
    {
        private static string connectionStr = "Data Source=.\\KHANG;Initial Catalog=SQL_QLCafe;Integrated Security=True";

        //tra ve bang gia tri
        public DataTable ExcuteQuery(string query)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }

        //Hàm thực hiện câu lệnh SQl
        public static void RunSQL(string sql)
        {         
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();
                SqlCommand cmd;
                cmd = new SqlCommand();
                cmd.Connection = connection;   //Gán kết nối
                cmd.CommandText = sql;  //Gán lệnh SQL
                cmd.ExecuteNonQuery(); // thuc hien truy van
                connection.Close();
            }
        }
    }
}
