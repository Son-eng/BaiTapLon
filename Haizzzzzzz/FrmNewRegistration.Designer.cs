namespace Haizzzzzzz
{
    partial class FrmNewRegistration
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
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.cboCuDan = new Sunny.UI.UIComboBox();
            this.cboDV = new Sunny.UI.UIComboBox();
            this.uiDatetimePicker1 = new Sunny.UI.UIDatetimePicker();
            this.btnLuu = new Sunny.UI.UIButton();
            this.btnHuy = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // uiLabel1
            // 
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.uiLabel1.Location = new System.Drawing.Point(119, 50);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(512, 65);
            this.uiLabel1.TabIndex = 2;
            this.uiLabel1.Text = "Thêm Đăng Ký Mới";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(46, 174);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(179, 45);
            this.uiLabel2.TabIndex = 3;
            this.uiLabel2.Text = "Chọn Cư Dân:";
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel3.Location = new System.Drawing.Point(46, 257);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(179, 45);
            this.uiLabel3.TabIndex = 3;
            this.uiLabel3.Text = "Chọn Dịch Vụ:";
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel4.Location = new System.Drawing.Point(46, 350);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(179, 45);
            this.uiLabel4.TabIndex = 3;
            this.uiLabel4.Text = "Ngày Bắt Đầu:";
            // 
            // cboCuDan
            // 
            this.cboCuDan.DataSource = null;
            this.cboCuDan.FillColor = System.Drawing.Color.White;
            this.cboCuDan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCuDan.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cboCuDan.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cboCuDan.Location = new System.Drawing.Point(232, 165);
            this.cboCuDan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboCuDan.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboCuDan.Name = "cboCuDan";
            this.cboCuDan.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cboCuDan.Radius = 42;
            this.cboCuDan.RectColor = System.Drawing.Color.Black;
            this.cboCuDan.Size = new System.Drawing.Size(320, 51);
            this.cboCuDan.SymbolSize = 24;
            this.cboCuDan.TabIndex = 4;
            this.cboCuDan.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cboCuDan.Watermark = "";
            // 
            // cboDV
            // 
            this.cboDV.DataSource = null;
            this.cboDV.FillColor = System.Drawing.Color.White;
            this.cboDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDV.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cboDV.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cboDV.Location = new System.Drawing.Point(232, 250);
            this.cboDV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboDV.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboDV.Name = "cboDV";
            this.cboDV.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cboDV.Radius = 42;
            this.cboDV.RectColor = System.Drawing.Color.Black;
            this.cboDV.Size = new System.Drawing.Size(320, 51);
            this.cboDV.SymbolSize = 24;
            this.cboDV.TabIndex = 5;
            this.cboDV.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cboDV.Watermark = "";
            // 
            // uiDatetimePicker1
            // 
            this.uiDatetimePicker1.DateFormat = "yyyy-MM-dd ";
            this.uiDatetimePicker1.FillColor = System.Drawing.Color.White;
            this.uiDatetimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiDatetimePicker1.Location = new System.Drawing.Point(232, 341);
            this.uiDatetimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiDatetimePicker1.MaxLength = 11;
            this.uiDatetimePicker1.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiDatetimePicker1.Name = "uiDatetimePicker1";
            this.uiDatetimePicker1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiDatetimePicker1.Radius = 42;
            this.uiDatetimePicker1.RectColor = System.Drawing.Color.Black;
            this.uiDatetimePicker1.Size = new System.Drawing.Size(320, 51);
            this.uiDatetimePicker1.SymbolDropDown = 61555;
            this.uiDatetimePicker1.SymbolNormal = 61555;
            this.uiDatetimePicker1.SymbolSize = 24;
            this.uiDatetimePicker1.TabIndex = 6;
            this.uiDatetimePicker1.Text = "2025-10-29 ";
            this.uiDatetimePicker1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiDatetimePicker1.Value = new System.DateTime(2025, 10, 29, 20, 57, 5, 367);
            this.uiDatetimePicker1.Watermark = "";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Transparent;
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLuu.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnLuu.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnLuu.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnLuu.Location = new System.Drawing.Point(149, 472);
            this.btnLuu.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Radius = 50;
            this.btnLuu.RectColor = System.Drawing.Color.Transparent;
            this.btnLuu.RectHoverColor = System.Drawing.Color.Transparent;
            this.btnLuu.RectPressColor = System.Drawing.Color.Transparent;
            this.btnLuu.Size = new System.Drawing.Size(190, 54);
            this.btnLuu.TabIndex = 17;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Transparent;
            this.btnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuy.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHuy.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnHuy.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnHuy.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnHuy.Location = new System.Drawing.Point(380, 473);
            this.btnHuy.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Radius = 50;
            this.btnHuy.RectColor = System.Drawing.Color.Transparent;
            this.btnHuy.RectHoverColor = System.Drawing.Color.Transparent;
            this.btnHuy.RectPressColor = System.Drawing.Color.Transparent;
            this.btnHuy.Size = new System.Drawing.Size(190, 54);
            this.btnHuy.TabIndex = 18;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // FrmNewRegistration
            // 
            this.AllowShowTitle = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(740, 800);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.uiDatetimePicker1);
            this.Controls.Add(this.cboDV);
            this.Controls.Add(this.cboCuDan);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.Name = "FrmNewRegistration";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.RectColor = System.Drawing.Color.Transparent;
            this.ShowTitle = false;
            this.Text = "FrmNewRegistration";
            this.ZoomScaleRect = new System.Drawing.Rectangle(17, 17, 800, 450);
            this.Load += new System.EventHandler(this.FrmNewRegistration_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UIComboBox cboCuDan;
        private Sunny.UI.UIComboBox cboDV;
        private Sunny.UI.UIDatetimePicker uiDatetimePicker1;
        private Sunny.UI.UIButton btnLuu;
        private Sunny.UI.UIButton btnHuy;
    }
}