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
    public partial class ucBillingManagement : UIUserControl
    {
        public ucBillingManagement()
        {
            InitializeComponent();
        }

        private void ucBillingManagement_Load(object sender, EventArgs e)
        {

        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            // 1. Tạo một đối tượng (instance) của Form pop-up
            FrmNewInvoice popup = new FrmNewInvoice();

            // 2. Hiển thị Form đó dưới dạng "Dialog"
            // (ShowDialog sẽ khóa Form chính ở dưới, người dùng phải thao tác xong mới quay lại được)
            popup.ShowDialog();

            // 3. (Sau khi Form pop-up đóng lại)
            // Bạn sẽ gọi code để tải lại dữ liệu cho DataGridView ở đây
            // LoadDataGrid();
        }
    }
}
