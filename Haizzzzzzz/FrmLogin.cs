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
    public partial class FrmLogin : UIForm
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void uiLabel1_Click(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            //Cái này để làm mờ nền PanelDN
            this.PanelDN.Style = Sunny.UI.UIStyle.Custom;
            this.PanelDN.FillColor = Color.FromArgb(100, 255, 255, 255);

            this.txtUser.Style = Sunny.UI.UIStyle.Custom;
            // Dùng Color.White (tương đương Alpha=255)
            this.txtUser.FillColor = Color.LightGray;
            // Hoặc dùng màu xám nhạt ĐẶC:
            // this.uiText_Username.FillColor = Color.FromArgb(255, 245, 245, 245);

            // Làm tương tự cho ô mật khẩu
            this.txtPass.Style = Sunny.UI.UIStyle.Custom;
            this.txtPass.FillColor = Color.LightGray;
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void PanelDN_Click(object sender, EventArgs e)
        {

        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
