using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Haizzzzzzz
{
    internal class KetNoi
    {
        //Data Source=HONGSON\SQL;Initial Catalog=BaiTapLon;Integrated Security=True;Trust Server Certificate=True
        
        private string connectionString = @"Data Source=HONGSON\SQL;Initial Catalog=BaiTapLon;Integrated Security=True";

        // 2. Hàm LẤY DỮ LIỆU 
        public DataTable Lay_Dulieu(string strSQL)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(strSQL, cnn);
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    ada.Fill(dataTable);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
            return dataTable;
        }

        // 3. Hàm THỰC THI 
        public void Thuc_Thi(string strSQL)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    cnn.Open(); 
                    SqlCommand cmd = new SqlCommand(strSQL, cnn);
                    cmd.ExecuteNonQuery(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thực thi lệnh: " + ex.Message);
            }
        }

    }
}
