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
    public partial class ucServiceManagement : UIUserControl
    {
        public ucServiceManagement()
        {
            InitializeComponent();
        }

        private void ucServiceManagement_Load(object sender, EventArgs e)
        {

        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            // 1. Tạo một đối tượng (instance) của Form pop-up
            FrmServiceDetail popup = new FrmServiceDetail();

            // 2. Hiển thị Form đó dưới dạng "Dialog" (khóa Form cha)
            popup.ShowDialog();

            // 3. (Sau khi Form pop-up đóng lại)
            // Sau này bạn sẽ gọi code Tải lại dữ liệu (Reload) ở đây
            // LoadServiceCards(); 
        }
    }
    
}
