namespace Haizzzzzzz
{
    partial class FrmNewInvoice
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
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.txtMaHD = new Sunny.UI.UITextBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.cboCanHo = new Sunny.UI.UIComboBox();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.NumTongTien = new Sunny.UI.UINumPadTextBox();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.txtKyHD = new Sunny.UI.UITextBox();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.uiDatetimePicker1 = new Sunny.UI.UIDatetimePicker();
            this.btnTao = new Sunny.UI.UIButton();
            this.btnHuy = new Sunny.UI.UIButton();
            this.uiPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiLabel1
            // 
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.uiLabel1.Location = new System.Drawing.Point(10, 10);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(720, 78);
            this.uiLabel1.TabIndex = 3;
            this.uiLabel1.Text = "Tạo Hóa Đơn";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // uiPanel1
            // 
            this.uiPanel1.BackColor = System.Drawing.Color.Transparent;
            this.uiPanel1.Controls.Add(this.btnHuy);
            this.uiPanel1.Controls.Add(this.btnTao);
            this.uiPanel1.Controls.Add(this.uiDatetimePicker1);
            this.uiPanel1.Controls.Add(this.txtKyHD);
            this.uiPanel1.Controls.Add(this.NumTongTien);
            this.uiPanel1.Controls.Add(this.cboCanHo);
            this.uiPanel1.Controls.Add(this.txtMaHD);
            this.uiPanel1.Controls.Add(this.uiLabel6);
            this.uiPanel1.Controls.Add(this.uiLabel5);
            this.uiPanel1.Controls.Add(this.uiLabel4);
            this.uiPanel1.Controls.Add(this.uiLabel3);
            this.uiPanel1.Controls.Add(this.uiLabel2);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel1.FillColor = System.Drawing.Color.Transparent;
            this.uiPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(10, 88);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.uiPanel1.Radius = 50;
            this.uiPanel1.RectColor = System.Drawing.Color.Black;
            this.uiPanel1.Size = new System.Drawing.Size(720, 702);
            this.uiPanel1.TabIndex = 4;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(131, 63);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(140, 48);
            this.uiLabel2.TabIndex = 0;
            this.uiLabel2.Text = "Mã Hóa Đơn:";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaHD.FillColor = System.Drawing.Color.Gainsboro;
            this.txtMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHD.Location = new System.Drawing.Point(288, 48);
            this.txtMaHD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaHD.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Padding = new System.Windows.Forms.Padding(5);
            this.txtMaHD.Radius = 50;
            this.txtMaHD.RectColor = System.Drawing.Color.Black;
            this.txtMaHD.ShowText = false;
            this.txtMaHD.Size = new System.Drawing.Size(308, 55);
            this.txtMaHD.TabIndex = 1;
            this.txtMaHD.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtMaHD.Watermark = "";
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel3.Location = new System.Drawing.Point(131, 149);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(140, 48);
            this.uiLabel3.TabIndex = 0;
            this.uiLabel3.Text = "Mã Căn Hộ:";
            // 
            // cboCanHo
            // 
            this.cboCanHo.DataSource = null;
            this.cboCanHo.FillColor = System.Drawing.Color.Gainsboro;
            this.cboCanHo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCanHo.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cboCanHo.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cboCanHo.Location = new System.Drawing.Point(288, 135);
            this.cboCanHo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboCanHo.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboCanHo.Name = "cboCanHo";
            this.cboCanHo.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cboCanHo.Radius = 50;
            this.cboCanHo.RectColor = System.Drawing.Color.Black;
            this.cboCanHo.Size = new System.Drawing.Size(308, 55);
            this.cboCanHo.SymbolSize = 24;
            this.cboCanHo.TabIndex = 2;
            this.cboCanHo.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cboCanHo.Watermark = "";
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel4.Location = new System.Drawing.Point(131, 233);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(140, 48);
            this.uiLabel4.TabIndex = 0;
            this.uiLabel4.Text = "Tổng Tiền:";
            // 
            // NumTongTien
            // 
            this.NumTongTien.FillColor = System.Drawing.Color.Gainsboro;
            this.NumTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumTongTien.Location = new System.Drawing.Point(288, 219);
            this.NumTongTien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NumTongTien.MinimumSize = new System.Drawing.Size(63, 0);
            this.NumTongTien.Name = "NumTongTien";
            this.NumTongTien.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.NumTongTien.Radius = 50;
            this.NumTongTien.RectColor = System.Drawing.Color.Black;
            this.NumTongTien.Size = new System.Drawing.Size(307, 55);
            this.NumTongTien.SymbolSize = 24;
            this.NumTongTien.TabIndex = 3;
            this.NumTongTien.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.NumTongTien.Watermark = "";
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel5.Location = new System.Drawing.Point(131, 318);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(140, 48);
            this.uiLabel5.TabIndex = 0;
            this.uiLabel5.Text = "Kỳ Hóa Đơn:";
            // 
            // txtKyHD
            // 
            this.txtKyHD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKyHD.FillColor = System.Drawing.Color.Gainsboro;
            this.txtKyHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKyHD.Location = new System.Drawing.Point(288, 304);
            this.txtKyHD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKyHD.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtKyHD.Name = "txtKyHD";
            this.txtKyHD.Padding = new System.Windows.Forms.Padding(5);
            this.txtKyHD.Radius = 50;
            this.txtKyHD.RectColor = System.Drawing.Color.Black;
            this.txtKyHD.ShowText = false;
            this.txtKyHD.Size = new System.Drawing.Size(307, 55);
            this.txtKyHD.TabIndex = 4;
            this.txtKyHD.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtKyHD.Watermark = "";
            // 
            // uiLabel6
            // 
            this.uiLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel6.Location = new System.Drawing.Point(131, 398);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(140, 48);
            this.uiLabel6.TabIndex = 0;
            this.uiLabel6.Text = "Ngày Lập:";
            // 
            // uiDatetimePicker1
            // 
            this.uiDatetimePicker1.DateFormat = "yyyy-MM-dd ";
            this.uiDatetimePicker1.FillColor = System.Drawing.Color.Gainsboro;
            this.uiDatetimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiDatetimePicker1.Location = new System.Drawing.Point(288, 383);
            this.uiDatetimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiDatetimePicker1.MaxDate = new System.DateTime(3000, 1, 1, 0, 0, 0, 0);
            this.uiDatetimePicker1.MaxLength = 11;
            this.uiDatetimePicker1.MinDate = new System.DateTime(1953, 1, 1, 0, 0, 0, 0);
            this.uiDatetimePicker1.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiDatetimePicker1.Name = "uiDatetimePicker1";
            this.uiDatetimePicker1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiDatetimePicker1.Radius = 50;
            this.uiDatetimePicker1.RectColor = System.Drawing.Color.Black;
            this.uiDatetimePicker1.Size = new System.Drawing.Size(306, 55);
            this.uiDatetimePicker1.SymbolDropDown = 61555;
            this.uiDatetimePicker1.SymbolNormal = 61555;
            this.uiDatetimePicker1.SymbolSize = 24;
            this.uiDatetimePicker1.TabIndex = 5;
            this.uiDatetimePicker1.Text = "2025-10-29 ";
            this.uiDatetimePicker1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiDatetimePicker1.Value = new System.DateTime(2025, 10, 29, 0, 0, 0, 0);
            this.uiDatetimePicker1.Watermark = "";
            // 
            // btnTao
            // 
            this.btnTao.BackColor = System.Drawing.Color.Transparent;
            this.btnTao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTao.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTao.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnTao.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnTao.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnTao.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnTao.Location = new System.Drawing.Point(148, 513);
            this.btnTao.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnTao.Name = "btnTao";
            this.btnTao.Radius = 50;
            this.btnTao.RectColor = System.Drawing.Color.Transparent;
            this.btnTao.RectHoverColor = System.Drawing.Color.Transparent;
            this.btnTao.RectPressColor = System.Drawing.Color.Transparent;
            this.btnTao.RectSelectedColor = System.Drawing.Color.Transparent;
            this.btnTao.Size = new System.Drawing.Size(190, 54);
            this.btnTao.TabIndex = 18;
            this.btnTao.Text = "Tạo";
            this.btnTao.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // btnHuy
            // 
            this.btnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuy.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHuy.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnHuy.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnHuy.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnHuy.Location = new System.Drawing.Point(385, 513);
            this.btnHuy.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Radius = 50;
            this.btnHuy.RectColor = System.Drawing.Color.Transparent;
            this.btnHuy.RectHoverColor = System.Drawing.Color.Transparent;
            this.btnHuy.RectPressColor = System.Drawing.Color.Transparent;
            this.btnHuy.RectSelectedColor = System.Drawing.Color.Transparent;
            this.btnHuy.Size = new System.Drawing.Size(190, 54);
            this.btnHuy.TabIndex = 19;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // FrmNewInvoice
            // 
            this.AllowShowTitle = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(740, 800);
            this.Controls.Add(this.uiPanel1);
            this.Controls.Add(this.uiLabel1);
            this.Name = "FrmNewInvoice";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.RectColor = System.Drawing.Color.Transparent;
            this.ShowTitle = false;
            this.Text = "FrmNewInvoice";
            this.ZoomScaleRect = new System.Drawing.Rectangle(17, 17, 800, 450);
            this.Load += new System.EventHandler(this.FrmNewInvoice_Load);
            this.uiPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIComboBox cboCanHo;
        private Sunny.UI.UITextBox txtMaHD;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UINumPadTextBox NumTongTien;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UITextBox txtKyHD;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UIDatetimePicker uiDatetimePicker1;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UIButton btnHuy;
        private Sunny.UI.UIButton btnTao;
    }
}