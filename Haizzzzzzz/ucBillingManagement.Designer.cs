namespace Haizzzzzzz
{
    partial class ucBillingManagement
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

        #region Component Designer generated code

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
            this.PanelHeader = new Sunny.UI.UIPanel();
            this.txtCanHo = new Sunny.UI.UITextBox();
            this.cboTrangThai = new Sunny.UI.UIComboBox();
            this.btnThemMoi = new Sunny.UI.UISymbolButton();
            this.uiDataGridView1 = new Sunny.UI.UIDataGridView();
            this.colMaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCanHo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKyHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colViewDetail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colConfirmPayment = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelHeader
            // 
            this.PanelHeader.Controls.Add(this.txtCanHo);
            this.PanelHeader.Controls.Add(this.cboTrangThai);
            this.PanelHeader.Controls.Add(this.btnThemMoi);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.FillColor = System.Drawing.Color.Transparent;
            this.PanelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PanelHeader.Location = new System.Drawing.Point(10, 10);
            this.PanelHeader.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PanelHeader.MinimumSize = new System.Drawing.Size(1, 1);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Radius = 40;
            this.PanelHeader.RectColor = System.Drawing.Color.Black;
            this.PanelHeader.Size = new System.Drawing.Size(1245, 132);
            this.PanelHeader.TabIndex = 0;
            this.PanelHeader.Text = null;
            this.PanelHeader.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCanHo
            // 
            this.txtCanHo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCanHo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCanHo.Location = new System.Drawing.Point(843, 37);
            this.txtCanHo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCanHo.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtCanHo.Name = "txtCanHo";
            this.txtCanHo.Padding = new System.Windows.Forms.Padding(5);
            this.txtCanHo.Radius = 40;
            this.txtCanHo.RectColor = System.Drawing.Color.Black;
            this.txtCanHo.ShowText = false;
            this.txtCanHo.Size = new System.Drawing.Size(293, 58);
            this.txtCanHo.TabIndex = 3;
            this.txtCanHo.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtCanHo.Watermark = "Tìm theo căn hộ...";
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.DataSource = null;
            this.cboTrangThai.FillColor = System.Drawing.Color.White;
            this.cboTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboTrangThai.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cboTrangThai.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cboTrangThai.Location = new System.Drawing.Point(463, 34);
            this.cboTrangThai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboTrangThai.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cboTrangThai.Radius = 40;
            this.cboTrangThai.RectColor = System.Drawing.Color.Black;
            this.cboTrangThai.Size = new System.Drawing.Size(293, 58);
            this.cboTrangThai.SymbolSize = 24;
            this.cboTrangThai.TabIndex = 2;
            this.cboTrangThai.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cboTrangThai.Watermark = "Lọc theo trạng thái...";
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemMoi.FillColor = System.Drawing.Color.Gray;
            this.btnThemMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMoi.Location = new System.Drawing.Point(83, 34);
            this.btnThemMoi.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Radius = 40;
            this.btnThemMoi.RectColor = System.Drawing.Color.Transparent;
            this.btnThemMoi.Size = new System.Drawing.Size(293, 58);
            this.btnThemMoi.Symbol = 61525;
            this.btnThemMoi.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnThemMoi.SymbolSize = 30;
            this.btnThemMoi.TabIndex = 1;
            this.btnThemMoi.Text = "Tạo Hóa Đơn Mới";
            this.btnThemMoi.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // uiDataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.uiDataGridView1.BackgroundColor = System.Drawing.Color.DimGray;
            this.uiDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.uiDataGridView1.ColumnHeadersHeight = 32;
            this.uiDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.uiDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHD,
            this.colCanHo,
            this.colTongTien,
            this.colKyHD,
            this.colNgayLap,
            this.colTrangThai,
            this.colViewDetail,
            this.colConfirmPayment});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.uiDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.uiDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiDataGridView1.EnableHeadersVisualStyles = false;
            this.uiDataGridView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiDataGridView1.GridColor = System.Drawing.Color.Gray;
            this.uiDataGridView1.Location = new System.Drawing.Point(10, 142);
            this.uiDataGridView1.Name = "uiDataGridView1";
            this.uiDataGridView1.RectColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.uiDataGridView1.RowHeadersWidth = 45;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.uiDataGridView1.SelectedIndex = -1;
            this.uiDataGridView1.Size = new System.Drawing.Size(1245, 530);
            this.uiDataGridView1.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.TabIndex = 1;
            // 
            // colMaHD
            // 
            this.colMaHD.HeaderText = "Mã Hóa Đơn";
            this.colMaHD.MinimumWidth = 6;
            this.colMaHD.Name = "colMaHD";
            this.colMaHD.Width = 130;
            // 
            // colCanHo
            // 
            this.colCanHo.HeaderText = "Mã Căn Hộ";
            this.colCanHo.MinimumWidth = 6;
            this.colCanHo.Name = "colCanHo";
            this.colCanHo.Width = 130;
            // 
            // colTongTien
            // 
            this.colTongTien.HeaderText = "Tổng Tiền";
            this.colTongTien.MinimumWidth = 6;
            this.colTongTien.Name = "colTongTien";
            this.colTongTien.Width = 130;
            // 
            // colKyHD
            // 
            this.colKyHD.HeaderText = "Kỳ Hóa Đơn";
            this.colKyHD.MinimumWidth = 6;
            this.colKyHD.Name = "colKyHD";
            this.colKyHD.Width = 130;
            // 
            // colNgayLap
            // 
            this.colNgayLap.HeaderText = "Ngày Lập";
            this.colNgayLap.MinimumWidth = 6;
            this.colNgayLap.Name = "colNgayLap";
            this.colNgayLap.Width = 130;
            // 
            // colTrangThai
            // 
            this.colTrangThai.HeaderText = "Trạng Thái";
            this.colTrangThai.MinimumWidth = 6;
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.Width = 130;
            // 
            // colViewDetail
            // 
            this.colViewDetail.HeaderText = "Xem chi tiết";
            this.colViewDetail.MinimumWidth = 6;
            this.colViewDetail.Name = "colViewDetail";
            this.colViewDetail.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colViewDetail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colViewDetail.Width = 130;
            // 
            // colConfirmPayment
            // 
            this.colConfirmPayment.HeaderText = "Xác nhận thanh toán";
            this.colConfirmPayment.MinimumWidth = 6;
            this.colConfirmPayment.Name = "colConfirmPayment";
            this.colConfirmPayment.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colConfirmPayment.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colConfirmPayment.Width = 200;
            // 
            // ucBillingManagement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.uiDataGridView1);
            this.Controls.Add(this.PanelHeader);
            this.FillColor = System.Drawing.Color.Silver;
            this.Name = "ucBillingManagement";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Radius = 40;
            this.RectColor = System.Drawing.Color.Transparent;
            this.Size = new System.Drawing.Size(1265, 682);
            this.Load += new System.EventHandler(this.ucBillingManagement_Load);
            this.PanelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel PanelHeader;
        private Sunny.UI.UITextBox txtCanHo;
        private Sunny.UI.UIComboBox cboTrangThai;
        private Sunny.UI.UISymbolButton btnThemMoi;
        private Sunny.UI.UIDataGridView uiDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCanHo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKyHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.DataGridViewButtonColumn colViewDetail;
        private System.Windows.Forms.DataGridViewButtonColumn colConfirmPayment;
    }
}
