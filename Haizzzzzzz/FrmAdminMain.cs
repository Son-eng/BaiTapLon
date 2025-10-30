using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Haizzzzzzz
{
    public partial class FrmAdminMain : Form
    {
        public FrmAdminMain()
        {
            InitializeComponent();
        }

        private void uiNavMenu1_MenuItemClick(TreeNode node, Sunny.UI.NavMenuItem item, int pageIndex)
        {

        }

        private void uiNavMenu1_MenuItemClick_1(TreeNode node, Sunny.UI.NavMenuItem item, int pageIndex)
        {

        }

        private void PanelHeader_Click(object sender, EventArgs e)
        {

        }

        private void uiSymbolButton10_Click(object sender, EventArgs e)
        {

        }

        private void uiSymbolButton9_Click(object sender, EventArgs e)
        {

        }

        private void uiSymbolButton8_Click(object sender, EventArgs e)
        {

        }

        private void uiSymbolButton7_Click(object sender, EventArgs e)
        {

        }

        private void uiSymbolButton6_Click(object sender, EventArgs e)
        {
            // 1. Ẩn cái Dashboard (tên là ucDaskboard) đi
            ucDaskboard.Hide();

            // 2. (Phòng hờ) Xóa các UserControl "Cư dân" cũ nếu có
            // Dùng vòng lặp để tránh lỗi
            foreach (Control ctrl in PanelMainArea.Controls)
            {
                if (ctrl is ucResidentManagement) // Kiểm tra xem có phải control "Cư dân" không
                {
                    PanelMainArea.Controls.Remove(ctrl); // Xóa khỏi panel
                    ctrl.Dispose(); // Hủy đối tượng
                }
            }

            // 3. Tạo UserControl "Cư dân" MỚI (Vì đây là 1 class riêng)
            ucResidentManagement residentScreen = new ucResidentManagement();
            residentScreen.Dock = DockStyle.Fill;

            // 4. Thêm nó vào panelMainArea
            PanelMainArea.Controls.Add(residentScreen);

            // 5. (Quan trọng) Đảm bảo nó nằm đè lên trên ucDaskboard (đang bị ẩn)
            residentScreen.BringToFront();
        }

        private void FrmAdminMain_Load(object sender, EventArgs e)
        {
            
            this.PanelMenu.Style = Sunny.UI.UIStyle.Custom;
            this.PanelMenu.FillColor = Color.FromArgb(50, Color.Silver);

            this.btnCuDan.Style = Sunny.UI.UIStyle.Custom;
            this.btnCuDan.FillColor = Color.FromArgb(100, Color.LightYellow);

            this.SbtnCH.Style = Sunny.UI.UIStyle.Custom;
            this.SbtnCH.FillColor = Color.FromArgb(100, Color.LightYellow);

            this.SbtnDV.Style = Sunny.UI.UIStyle.Custom;
            this.SbtnDV.FillColor = Color.FromArgb(100, Color.LightYellow);

            this.SbtnDK.Style = Sunny.UI.UIStyle.Custom;
            this.SbtnDK.FillColor = Color.FromArgb(100, Color.LightYellow);

            this.SbtnHD.Style = Sunny.UI.UIStyle.Custom;
            this.SbtnHD.FillColor = Color.FromArgb(100, Color.LightYellow);

            this.PanelHeader.Style = Sunny.UI.UIStyle.Custom;
            this.PanelHeader.FillColor = Color.FromArgb(50, Color.WhiteSmoke);

            ucDaskboard.Style = Sunny.UI.UIStyle.Custom;
            ucDaskboard.FillColor = Color.FromArgb(50, Color.Silver);

        }

        private void uiAvatar1_Click(object sender, EventArgs e)
        {

        }

        private void Chart_Click(object sender, EventArgs e)
        {

        }

        private void uiSymbolLabel2_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            // 1. Xóa control "cư dân" đi
            foreach (Control ctrl in PanelMainArea.Controls)
            {
                if (ctrl is ucResidentManagement)
                {
                    PanelMainArea.Controls.Remove(ctrl);
                    ctrl.Dispose();
                }
            }

            // 2. Hiển thị lại cái Dashboard (cái đã có sẵn)
            ucDaskboard.Show();
        }

        private void ucDaskboard_Click(object sender, EventArgs e)
        {

        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            // 1. Ẩn cái Dashboard (tên là ucDaskboard) đi
            ucDaskboard.Hide();

            // 2. (Phòng hờ) Xóa các UserControl "Cư dân" cũ nếu có
            // Dùng vòng lặp để tránh lỗi
            foreach (Control ctrl in PanelMainArea.Controls)
            {
                if (ctrl is ucApartmentManagement) // Kiểm tra xem có phải control "Căn Hộ" không
                {
                    PanelMainArea.Controls.Remove(ctrl); // Xóa khỏi panel
                    ctrl.Dispose(); // Hủy đối tượng
                }
            }

            // 3. Tạo UserControl "Căn Hộ" MỚI (Vì đây là 1 class riêng)
            ucApartmentManagement apartmentScreen = new ucApartmentManagement();
            apartmentScreen.Dock = DockStyle.Fill;

            // 4. Thêm nó vào panelMainArea
            PanelMainArea.Controls.Add(apartmentScreen);

            // 5. (Quan trọng) Đảm bảo nó nằm đè lên trên ucDaskboard (đang bị ẩn)
            apartmentScreen.BringToFront();
        }

        private void SbtnDV_Click(object sender, EventArgs e)
        {
            // 1. Ẩn cái Dashboard (tên là ucDaskboard) đi
            ucDaskboard.Hide();

            // 2. (Phòng hờ) Xóa các UserControl "Cư dân" cũ nếu có
            // Dùng vòng lặp để tránh lỗi
            foreach (Control ctrl in PanelMainArea.Controls)
            {
                if (ctrl is ucServiceManagement) // Kiểm tra xem có phải control "Căn Hộ" không
                {
                    PanelMainArea.Controls.Remove(ctrl); // Xóa khỏi panel
                    ctrl.Dispose(); // Hủy đối tượng
                }
            }

            // 3. Tạo UserControl "Căn Hộ" MỚI (Vì đây là 1 class riêng)
            ucServiceManagement serviceScreen = new ucServiceManagement();
            serviceScreen.Dock = DockStyle.Fill;

            // 4. Thêm nó vào panelMainArea
            PanelMainArea.Controls.Add(serviceScreen);

            // 5. (Quan trọng) Đảm bảo nó nằm đè lên trên ucDaskboard (đang bị ẩn)
            serviceScreen.BringToFront();
        }

        private void SbtnDK_Click(object sender, EventArgs e)
        {
            // 1. Ẩn cái Dashboard (tên là ucDaskboard) đi
            ucDaskboard.Hide();

            // 2. (Phòng hờ) Xóa các UserControl "Cư dân" cũ nếu có
            // Dùng vòng lặp để tránh lỗi
            foreach (Control ctrl in PanelMainArea.Controls)
            {
                if (ctrl is ucRegistrationManagement) // Kiểm tra xem có phải control "Căn Hộ" không
                {
                    PanelMainArea.Controls.Remove(ctrl); // Xóa khỏi panel
                    ctrl.Dispose(); // Hủy đối tượng
                }
            }

            // 3. Tạo UserControl "Căn Hộ" MỚI (Vì đây là 1 class riêng)
            ucRegistrationManagement registrationScreen = new ucRegistrationManagement();
            registrationScreen.Dock = DockStyle.Fill;

            // 4. Thêm nó vào panelMainArea
            PanelMainArea.Controls.Add(registrationScreen);

            // 5. (Quan trọng) Đảm bảo nó nằm đè lên trên ucDaskboard (đang bị ẩn)
            registrationScreen.BringToFront();
        }

        private void SbtnHD_Click(object sender, EventArgs e)
        {
            // 1. Ẩn cái Dashboard (tên là ucDaskboard) đi
            ucDaskboard.Hide();

            // 2. (Phòng hờ) Xóa các UserControl "Cư dân" cũ nếu có
            // Dùng vòng lặp để tránh lỗi
            foreach (Control ctrl in PanelMainArea.Controls)
            {
                if (ctrl is ucBillingManagement) // Kiểm tra xem có phải control "Căn Hộ" không
                {
                    PanelMainArea.Controls.Remove(ctrl); // Xóa khỏi panel
                    ctrl.Dispose(); // Hủy đối tượng
                }
            }

            // 3. Tạo UserControl "Căn Hộ" MỚI (Vì đây là 1 class riêng)
            ucBillingManagement billingScreen = new ucBillingManagement();
            billingScreen.Dock = DockStyle.Fill;

            // 4. Thêm nó vào panelMainArea
            PanelMainArea.Controls.Add(billingScreen);

            // 5. (Quan trọng) Đảm bảo nó nằm đè lên trên ucDaskboard (đang bị ẩn)
            billingScreen.BringToFront();
        }

        private void uiSymbolButton5_Click(object sender, EventArgs e)
        {

        }
    }
}
