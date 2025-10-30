namespace Haizzzzzzz
{
    partial class FrmInvoiceDetail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.gridInvoiceItems = new Sunny.UI.UIDataGridView();
            this.PanelBottom = new Sunny.UI.UIPanel();
            this.uiTextBox1 = new Sunny.UI.UITextBox();
            this.btnDong = new Sunny.UI.UIButton();
            this.colTenDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uiGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridInvoiceItems)).BeginInit();
            this.PanelBottom.SuspendLayout();
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
            this.uiLabel1.Size = new System.Drawing.Size(720, 80);
            this.uiLabel1.TabIndex = 2;
            this.uiLabel1.Text = "Chi Tiết Hóa Đơn";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // uiPanel1
            // 
            this.uiPanel1.BackColor = System.Drawing.Color.Transparent;
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel1.FillColor = System.Drawing.Color.Transparent;
            this.uiPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel1.Location = new System.Drawing.Point(10, 90);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Padding = new System.Windows.Forms.Padding(15, 10, 15, 15);
            this.uiPanel1.Radius = 50;
            this.uiPanel1.RectColor = System.Drawing.Color.Black;
            this.uiPanel1.Size = new System.Drawing.Size(720, 148);
            this.uiPanel1.TabIndex = 3;
            this.uiPanel1.Text = "Thông tin chung";
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.gridInvoiceItems);
            this.uiGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiGroupBox1.FillColor = System.Drawing.Color.Transparent;
            this.uiGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiGroupBox1.Location = new System.Drawing.Point(10, 238);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(32);
            this.uiGroupBox1.Radius = 50;
            this.uiGroupBox1.RectColor = System.Drawing.Color.Black;
            this.uiGroupBox1.Size = new System.Drawing.Size(720, 348);
            this.uiGroupBox1.TabIndex = 4;
            this.uiGroupBox1.Text = "Các khoản phí chi tiết";
            this.uiGroupBox1.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gridInvoiceItems
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.gridInvoiceItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridInvoiceItems.BackgroundColor = System.Drawing.Color.DimGray;
            this.gridInvoiceItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridInvoiceItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridInvoiceItems.ColumnHeadersHeight = 32;
            this.gridInvoiceItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridInvoiceItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTenDV,
            this.colMota,
            this.colThanhTien});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridInvoiceItems.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridInvoiceItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridInvoiceItems.EnableHeadersVisualStyles = false;
            this.gridInvoiceItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gridInvoiceItems.GridColor = System.Drawing.Color.Silver;
            this.gridInvoiceItems.Location = new System.Drawing.Point(32, 32);
            this.gridInvoiceItems.Name = "gridInvoiceItems";
            this.gridInvoiceItems.RectColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridInvoiceItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridInvoiceItems.RowHeadersWidth = 45;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gridInvoiceItems.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gridInvoiceItems.SelectedIndex = -1;
            this.gridInvoiceItems.Size = new System.Drawing.Size(656, 284);
            this.gridInvoiceItems.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.gridInvoiceItems.TabIndex = 0;
            // 
            // PanelBottom
            // 
            this.PanelBottom.Controls.Add(this.btnDong);
            this.PanelBottom.Controls.Add(this.uiTextBox1);
            this.PanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelBottom.FillColor = System.Drawing.Color.Transparent;
            this.PanelBottom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PanelBottom.Location = new System.Drawing.Point(10, 610);
            this.PanelBottom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PanelBottom.MinimumSize = new System.Drawing.Size(1, 1);
            this.PanelBottom.Name = "PanelBottom";
            this.PanelBottom.Radius = 50;
            this.PanelBottom.RectColor = System.Drawing.Color.Black;
            this.PanelBottom.Size = new System.Drawing.Size(720, 180);
            this.PanelBottom.TabIndex = 5;
            this.PanelBottom.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiTextBox1
            // 
            this.uiTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox1.FillColor = System.Drawing.Color.LightGray;
            this.uiTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiTextBox1.Location = new System.Drawing.Point(34, 49);
            this.uiTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox1.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox1.Name = "uiTextBox1";
            this.uiTextBox1.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox1.Radius = 50;
            this.uiTextBox1.RectColor = System.Drawing.Color.Transparent;
            this.uiTextBox1.ShowText = false;
            this.uiTextBox1.Size = new System.Drawing.Size(252, 69);
            this.uiTextBox1.TabIndex = 0;
            this.uiTextBox1.Text = "Tổng cộng:";
            this.uiTextBox1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.uiTextBox1.Watermark = "";
            // 
            // btnDong
            // 
            this.btnDong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDong.FillColor = System.Drawing.Color.LightGray;
            this.btnDong.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnDong.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnDong.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.ForeColor = System.Drawing.Color.Black;
            this.btnDong.Location = new System.Drawing.Point(487, 47);
            this.btnDong.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnDong.Name = "btnDong";
            this.btnDong.Radius = 50;
            this.btnDong.RectColor = System.Drawing.Color.Transparent;
            this.btnDong.RectHoverColor = System.Drawing.Color.Transparent;
            this.btnDong.RectPressColor = System.Drawing.Color.Transparent;
            this.btnDong.RectSelectedColor = System.Drawing.Color.Transparent;
            this.btnDong.Size = new System.Drawing.Size(155, 71);
            this.btnDong.TabIndex = 1;
            this.btnDong.Text = "Đóng";
            this.btnDong.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // colTenDV
            // 
            this.colTenDV.HeaderText = "Tên Dịch Vụ";
            this.colTenDV.MinimumWidth = 6;
            this.colTenDV.Name = "colTenDV";
            this.colTenDV.Width = 200;
            // 
            // colMota
            // 
            this.colMota.HeaderText = "Mô Tả";
            this.colMota.MinimumWidth = 6;
            this.colMota.Name = "colMota";
            this.colMota.Width = 200;
            // 
            // colThanhTien
            // 
            this.colThanhTien.HeaderText = "Thành Tiền";
            this.colThanhTien.MinimumWidth = 6;
            this.colThanhTien.Name = "colThanhTien";
            this.colThanhTien.Width = 200;
            // 
            // FrmInvoiceDetail
            // 
            this.AllowShowTitle = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(740, 800);
            this.Controls.Add(this.PanelBottom);
            this.Controls.Add(this.uiGroupBox1);
            this.Controls.Add(this.uiPanel1);
            this.Controls.Add(this.uiLabel1);
            this.Name = "FrmInvoiceDetail";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.RectColor = System.Drawing.Color.Transparent;
            this.ShowTitle = false;
            this.Text = "FrmInvoiceDetail";
            this.TitleColor = System.Drawing.Color.Transparent;
            this.ZoomScaleRect = new System.Drawing.Rectangle(17, 17, 800, 450);
            this.Load += new System.EventHandler(this.FrmInvoiceDetail_Load);
            this.uiGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridInvoiceItems)).EndInit();
            this.PanelBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UIDataGridView gridInvoiceItems;
        private Sunny.UI.UIPanel PanelBottom;
        private Sunny.UI.UIButton btnDong;
        private Sunny.UI.UITextBox uiTextBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMota;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
    }
}