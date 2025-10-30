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
    public partial class ucRegistrationManagement : UIUserControl
    {
        public ucRegistrationManagement()
        {
            InitializeComponent();
        }

        private void ucRegistrationManagement_Load(object sender, EventArgs e)
        {

        }

        private void btnCuDan_Click(object sender, EventArgs e)
        {
            // 1. Tạo một đối tượng (instance) của Form pop-up
            FrmNewRegistration popup = new FrmNewRegistration();

            // 2. Hiển thị Form đó dưới dạng "Dialog"
            // (ShowDialog sẽ khóa Form chính ở dưới, người dùng phải thao tác xong mới quay lại được)
            popup.ShowDialog();

            // 3. (Sau khi Form pop-up đóng lại)
            // Bạn sẽ gọi code để tải lại dữ liệu cho DataGridView ở đây
            // LoadDataGrid();
        }
    }
}
