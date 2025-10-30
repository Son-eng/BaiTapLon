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
    public partial class ucApartmentManagement : UIUserControl
    {
        public ucApartmentManagement()
        {
            InitializeComponent();
        }

        private void ucApartmentManagement_Load(object sender, EventArgs e)
        {

        }

        private void ucApartmentManagement_Click(object sender, EventArgs e)
        {

        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            // 1. Tạo Form pop-up
            FrmApartmentDetail popup = new FrmApartmentDetail();

            // 2. Hiển thị nó
            popup.ShowDialog();

            // 3. (Sau khi pop-up đóng) Tải lại dữ liệu cho lưới
            // LoadApartmentData();
        }
    }
}
