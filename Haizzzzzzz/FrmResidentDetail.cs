using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;

namespace Haizzzzzzz
{
    public partial class FrmResidentDetail : UIForm
    {
        public FrmResidentDetail()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();

        private void FrmResidentDetail_Load(object sender, EventArgs e)
        {

        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text;
            string sdt = txtSDT.Text;
            // ...

            string query = $"INSERT INTO CuDan (HoTen, SoDT) VALUES (N'{hoTen}', '{sdt}')";

            // 2. Gọi hàm Thuc_Thi từ đối tượng 'kn'
            kn.Thuc_Thi(query);

            MessageBox.Show("Thêm cư dân thành công!");
            this.Close();
        }
    }
}
