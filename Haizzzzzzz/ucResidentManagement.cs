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
    public partial class ucResidentManagement : UIUserControl
    {
        public ucResidentManagement()
        {
            InitializeComponent();
        }

        KetNoi kn = new KetNoi();

        private void ucResidentManagement_Load(object sender, EventArgs e)
        {
            gridResidents.AutoGenerateColumns = false;

            // 2. Viết câu lệnh SQL (JOIN 2 bảng)
            string query = "SELECT HoTen, GioiTinh, SoDT, NgaySinh, Email, CanHo.TenHienThi FROM CuDan JOIN CanHo ON CuDan.MaCanHo_ID = CanHo.MaCanHo_ID";

            // 3. Gọi hàm 'Lay_Dulieu'
            DataTable dt = kn.Lay_Dulieu(query);

            // 4. Gán nguồn
            gridResidents.DataSource = dt;

            // 5. Ánh xạ cột (Rất quan trọng)
            // Tên bên trái = (Name) của cột trên DataGridView
            // Tên bên phải = Tên cột trong câu lệnh SQL
            gridResidents.Columns["colHoTen"].DataPropertyName = "HoTen";
            gridResidents.Columns["colGioiTinh"].DataPropertyName = "GioiTinh";
            gridResidents.Columns["colSoDT"].DataPropertyName = "SoDT";
            gridResidents.Columns["colNgaySinh"].DataPropertyName = "NgaySinh";
            gridResidents.Columns["colCanHo"].DataPropertyName = "TenHienThi";
            gridResidents.Columns["colEmail"].DataPropertyName = "Email";
        }

        private void GridResidents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCuDan_Click(object sender, EventArgs e)
        {
            // 1. Tạo một đối tượng (instance) của Form pop-up
            FrmResidentDetail popup = new FrmResidentDetail();

            // 2. Hiển thị Form đó dưới dạng "Dialog"
            // (ShowDialog sẽ khóa Form chính ở dưới, người dùng phải thao tác xong mới quay lại được)
            popup.ShowDialog();

            // 3. (Sau khi Form pop-up đóng lại)
            // Bạn sẽ gọi code để tải lại dữ liệu cho DataGridView ở đây
            // LoadDataGrid();
        }

        private void ucResidentManagement_Click(object sender, EventArgs e)
        {

        }
    }
}
