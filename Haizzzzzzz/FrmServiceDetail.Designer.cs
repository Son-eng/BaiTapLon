namespace Haizzzzzzz
{
    partial class FrmServiceDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.cboDonVi = new Sunny.UI.UIComboBox();
            this.uiNumPadTextBox1 = new Sunny.UI.UINumPadTextBox();
            this.uiGroupBox2 = new Sunny.UI.UIGroupBox();
            this.txtMoTaDV = new Sunny.UI.UITextBox();
            this.txtTenDV = new Sunny.UI.UITextBox();
            this.PanelFooter = new Sunny.UI.UIPanel();
            this.btnThemMoi = new Sunny.UI.UIButton();
            this.btnLuu = new Sunny.UI.UIButton();
            this.btnHuy = new Sunny.UI.UIButton();
            this.uiGroupBox1.SuspendLayout();
            this.uiGroupBox2.SuspendLayout();
            this.PanelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiLabel1
            // 
            this.uiLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.73585F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(10, 10);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(720, 44);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "Chi Tiết Dịch Vụ";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(13, 90);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(135, 31);
            this.uiLabel2.TabIndex = 1;
            this.uiLabel2.Text = "Tên dịch vụ:";
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.uiNumPadTextBox1);
            this.uiGroupBox1.Controls.Add(this.cboDonVi);
            this.uiGroupBox1.Controls.Add(this.uiLabel4);
            this.uiGroupBox1.Controls.Add(this.uiLabel3);
            this.uiGroupBox1.FillColor = System.Drawing.Color.Transparent;
            this.uiGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiGroupBox1.Location = new System.Drawing.Point(18, 162);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.RectColor = System.Drawing.Color.Black;
            this.uiGroupBox1.Size = new System.Drawing.Size(708, 180);
            this.uiGroupBox1.TabIndex = 3;
            this.uiGroupBox1.Text = "Chi tiết đơn giá";
            this.uiGroupBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel3.Location = new System.Drawing.Point(41, 76);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(169, 31);
            this.uiLabel3.TabIndex = 1;
            this.uiLabel3.Text = "Đơn giá ( VNĐ ):";
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel4.Location = new System.Drawing.Point(365, 76);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(169, 31);
            this.uiLabel4.TabIndex = 1;
            this.uiLabel4.Text = "Đơn vị tính:";
            // 
            // cboDonVi
            // 
            this.cboDonVi.DataSource = null;
            this.cboDonVi.FillColor = System.Drawing.Color.White;
            this.cboDonVi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboDonVi.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cboDonVi.Items.AddRange(new object[] {
            "VNĐ/Tháng",
            "VNĐ/Năm",
            "VNĐ/Lần",
            "VNĐ/Người"});
            this.cboDonVi.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cboDonVi.Location = new System.Drawing.Point(355, 111);
            this.cboDonVi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboDonVi.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboDonVi.Name = "cboDonVi";
            this.cboDonVi.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cboDonVi.Radius = 29;
            this.cboDonVi.RectColor = System.Drawing.Color.Black;
            this.cboDonVi.Size = new System.Drawing.Size(273, 40);
            this.cboDonVi.SymbolSize = 24;
            this.cboDonVi.TabIndex = 3;
            this.cboDonVi.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.cboDonVi.Watermark = "";
            // 
            // uiNumPadTextBox1
            // 
            this.uiNumPadTextBox1.FillColor = System.Drawing.Color.White;
            this.uiNumPadTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiNumPadTextBox1.Location = new System.Drawing.Point(31, 111);
            this.uiNumPadTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiNumPadTextBox1.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiNumPadTextBox1.Name = "uiNumPadTextBox1";
            this.uiNumPadTextBox1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiNumPadTextBox1.Radius = 29;
            this.uiNumPadTextBox1.RectColor = System.Drawing.Color.Black;
            this.uiNumPadTextBox1.Size = new System.Drawing.Size(273, 40);
            this.uiNumPadTextBox1.SymbolSize = 24;
            this.uiNumPadTextBox1.TabIndex = 4;
            this.uiNumPadTextBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiNumPadTextBox1.Watermark = "";
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.Controls.Add(this.txtMoTaDV);
            this.uiGroupBox2.FillColor = System.Drawing.Color.Transparent;
            this.uiGroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiGroupBox2.Location = new System.Drawing.Point(26, 368);
            this.uiGroupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox2.RectColor = System.Drawing.Color.Black;
            this.uiGroupBox2.Size = new System.Drawing.Size(699, 287);
            this.uiGroupBox2.TabIndex = 4;
            this.uiGroupBox2.Text = "Mô tả dịch vụ";
            this.uiGroupBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMoTaDV
            // 
            this.txtMoTaDV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMoTaDV.FillColor = System.Drawing.Color.Silver;
            this.txtMoTaDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMoTaDV.Location = new System.Drawing.Point(11, 29);
            this.txtMoTaDV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMoTaDV.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtMoTaDV.Name = "txtMoTaDV";
            this.txtMoTaDV.Padding = new System.Windows.Forms.Padding(5);
            this.txtMoTaDV.RectColor = System.Drawing.Color.Black;
            this.txtMoTaDV.ShowText = false;
            this.txtMoTaDV.Size = new System.Drawing.Size(677, 244);
            this.txtMoTaDV.TabIndex = 0;
            this.txtMoTaDV.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.txtMoTaDV.Watermark = "";
            // 
            // txtTenDV
            // 
            this.txtTenDV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenDV.FillColor = System.Drawing.Color.LightGray;
            this.txtTenDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTenDV.Location = new System.Drawing.Point(155, 82);
            this.txtTenDV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenDV.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtTenDV.Name = "txtTenDV";
            this.txtTenDV.Padding = new System.Windows.Forms.Padding(5);
            this.txtTenDV.Radius = 43;
            this.txtTenDV.RectColor = System.Drawing.Color.Transparent;
            this.txtTenDV.ShowText = false;
            this.txtTenDV.Size = new System.Drawing.Size(406, 43);
            this.txtTenDV.TabIndex = 5;
            this.txtTenDV.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtTenDV.Watermark = "";
            // 
            // PanelFooter
            // 
            this.PanelFooter.BackColor = System.Drawing.Color.Transparent;
            this.PanelFooter.Controls.Add(this.btnHuy);
            this.PanelFooter.Controls.Add(this.btnLuu);
            this.PanelFooter.Controls.Add(this.btnThemMoi);
            this.PanelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelFooter.FillColor = System.Drawing.Color.Transparent;
            this.PanelFooter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PanelFooter.Location = new System.Drawing.Point(10, 665);
            this.PanelFooter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PanelFooter.MinimumSize = new System.Drawing.Size(1, 1);
            this.PanelFooter.Name = "PanelFooter";
            this.PanelFooter.Radius = 50;
            this.PanelFooter.RectColor = System.Drawing.Color.Black;
            this.PanelFooter.Size = new System.Drawing.Size(720, 125);
            this.PanelFooter.TabIndex = 6;
            this.PanelFooter.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.BackColor = System.Drawing.Color.Transparent;
            this.btnThemMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemMoi.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThemMoi.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnThemMoi.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnThemMoi.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnThemMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnThemMoi.Location = new System.Drawing.Point(39, 33);
            this.btnThemMoi.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Radius = 44;
            this.btnThemMoi.RectColor = System.Drawing.Color.Transparent;
            this.btnThemMoi.RectHoverColor = System.Drawing.Color.Transparent;
            this.btnThemMoi.RectPressColor = System.Drawing.Color.Transparent;
            this.btnThemMoi.Size = new System.Drawing.Size(190, 54);
            this.btnThemMoi.TabIndex = 15;
            this.btnThemMoi.Text = "Làm Mới";
            this.btnThemMoi.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLuu.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnLuu.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnLuu.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnLuu.Location = new System.Drawing.Point(266, 33);
            this.btnLuu.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Radius = 44;
            this.btnLuu.RectColor = System.Drawing.Color.Transparent;
            this.btnLuu.RectHoverColor = System.Drawing.Color.Transparent;
            this.btnLuu.RectPressColor = System.Drawing.Color.Transparent;
            this.btnLuu.Size = new System.Drawing.Size(190, 54);
            this.btnLuu.TabIndex = 16;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // btnHuy
            // 
            this.btnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuy.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHuy.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnHuy.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnHuy.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnHuy.Location = new System.Drawing.Point(489, 33);
            this.btnHuy.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Radius = 44;
            this.btnHuy.RectColor = System.Drawing.Color.Transparent;
            this.btnHuy.RectHoverColor = System.Drawing.Color.Transparent;
            this.btnHuy.RectPressColor = System.Drawing.Color.Transparent;
            this.btnHuy.Size = new System.Drawing.Size(190, 54);
            this.btnHuy.TabIndex = 17;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // FrmServiceDetail
            // 
            this.AllowShowTitle = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(740, 800);
            this.Controls.Add(this.PanelFooter);
            this.Controls.Add(this.txtTenDV);
            this.Controls.Add(this.uiGroupBox2);
            this.Controls.Add(this.uiGroupBox1);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.Name = "FrmServiceDetail";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.RectColor = System.Drawing.Color.Transparent;
            this.ShowTitle = false;
            this.Text = "Chi tiết dịch vụ";
            this.TitleForeColor = System.Drawing.Color.Black;
            this.ZoomScaleRect = new System.Drawing.Rectangle(17, 17, 800, 450);
            this.Load += new System.EventHandler(this.FrmServiceDetail_Load);
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox2.ResumeLayout(false);
            this.PanelFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UINumPadTextBox uiNumPadTextBox1;
        private Sunny.UI.UIComboBox cboDonVi;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UIGroupBox uiGroupBox2;
        private Sunny.UI.UITextBox txtMoTaDV;
        private Sunny.UI.UITextBox txtTenDV;
        private Sunny.UI.UIPanel PanelFooter;
        private Sunny.UI.UIButton btnThemMoi;
        private Sunny.UI.UIButton btnHuy;
        private Sunny.UI.UIButton btnLuu;
    }
}