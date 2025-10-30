namespace Haizzzzzzz
{
    partial class ucRegistrationManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.gridDichVu = new Sunny.UI.UIDataGridView();
            this.colTenCudan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaCH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayDK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaHan = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colHuy = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnCuDan = new Sunny.UI.UISymbolButton();
            this.cboCuDan = new Sunny.UI.UIComboBox();
            this.cboCanHo = new Sunny.UI.UIComboBox();
            this.uiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDichVu)).BeginInit();
            this.SuspendLayout();
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.cboCanHo);
            this.uiPanel1.Controls.Add(this.cboCuDan);
            this.uiPanel1.Controls.Add(this.btnCuDan);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel1.FillColor = System.Drawing.Color.Transparent;
            this.uiPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(10, 10);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Radius = 40;
            this.uiPanel1.RectColor = System.Drawing.Color.Black;
            this.uiPanel1.Size = new System.Drawing.Size(1245, 166);
            this.uiPanel1.TabIndex = 0;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gridDichVu
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.gridDichVu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.gridDichVu.BackgroundColor = System.Drawing.Color.White;
            this.gridDichVu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDichVu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gridDichVu.ColumnHeadersHeight = 32;
            this.gridDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTenCudan,
            this.colMaCH,
            this.colDV,
            this.colNgayDK,
            this.colNgayHH,
            this.colTrangThai,
            this.colGiaHan,
            this.colHuy});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridDichVu.DefaultCellStyle = dataGridViewCellStyle8;
            this.gridDichVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDichVu.EnableHeadersVisualStyles = false;
            this.gridDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gridDichVu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.gridDichVu.Location = new System.Drawing.Point(10, 176);
            this.gridDichVu.Name = "gridDichVu";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDichVu.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.gridDichVu.RowHeadersWidth = 45;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gridDichVu.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.gridDichVu.SelectedIndex = -1;
            this.gridDichVu.Size = new System.Drawing.Size(1245, 496);
            this.gridDichVu.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.gridDichVu.TabIndex = 1;
            // 
            // colTenCudan
            // 
            this.colTenCudan.HeaderText = "Tên Cư Dân";
            this.colTenCudan.MinimumWidth = 6;
            this.colTenCudan.Name = "colTenCudan";
            this.colTenCudan.Width = 160;
            // 
            // colMaCH
            // 
            this.colMaCH.HeaderText = "Căn Hộ";
            this.colMaCH.MinimumWidth = 6;
            this.colMaCH.Name = "colMaCH";
            this.colMaCH.Width = 160;
            // 
            // colDV
            // 
            this.colDV.HeaderText = "Tên Dịch Vụ";
            this.colDV.MinimumWidth = 6;
            this.colDV.Name = "colDV";
            this.colDV.Width = 160;
            // 
            // colNgayDK
            // 
            this.colNgayDK.HeaderText = "Ngày Đăng Ký";
            this.colNgayDK.MinimumWidth = 6;
            this.colNgayDK.Name = "colNgayDK";
            this.colNgayDK.Width = 160;
            // 
            // colNgayHH
            // 
            this.colNgayHH.HeaderText = "Ngày Hết Hạn";
            this.colNgayHH.MinimumWidth = 6;
            this.colNgayHH.Name = "colNgayHH";
            this.colNgayHH.Width = 160;
            // 
            // colTrangThai
            // 
            this.colTrangThai.HeaderText = "Trạng Thái";
            this.colTrangThai.MinimumWidth = 6;
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.Width = 160;
            // 
            // colGiaHan
            // 
            this.colGiaHan.HeaderText = "Gia Hạn";
            this.colGiaHan.MinimumWidth = 6;
            this.colGiaHan.Name = "colGiaHan";
            this.colGiaHan.Width = 110;
            // 
            // colHuy
            // 
            this.colHuy.HeaderText = "Hủy";
            this.colHuy.MinimumWidth = 6;
            this.colHuy.Name = "colHuy";
            this.colHuy.Width = 110;
            // 
            // btnCuDan
            // 
            this.btnCuDan.BackColor = System.Drawing.Color.Transparent;
            this.btnCuDan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCuDan.FillColor = System.Drawing.Color.Gray;
            this.btnCuDan.FillHoverColor = System.Drawing.Color.Silver;
            this.btnCuDan.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCuDan.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCuDan.Font = new System.Drawing.Font("Times New Roman", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuDan.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCuDan.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCuDan.Location = new System.Drawing.Point(141, 50);
            this.btnCuDan.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCuDan.Name = "btnCuDan";
            this.btnCuDan.Radius = 50;
            this.btnCuDan.RectColor = System.Drawing.Color.Transparent;
            this.btnCuDan.RectHoverColor = System.Drawing.Color.Transparent;
            this.btnCuDan.RectPressColor = System.Drawing.Color.Transparent;
            this.btnCuDan.RectSelectedColor = System.Drawing.Color.Transparent;
            this.btnCuDan.Size = new System.Drawing.Size(257, 63);
            this.btnCuDan.Symbol = 61525;
            this.btnCuDan.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnCuDan.SymbolSize = 30;
            this.btnCuDan.TabIndex = 3;
            this.btnCuDan.Text = "Thêm đăng ký mới";
            this.btnCuDan.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnCuDan.Click += new System.EventHandler(this.btnCuDan_Click);
            // 
            // cboCuDan
            // 
            this.cboCuDan.DataSource = null;
            this.cboCuDan.FillColor = System.Drawing.Color.White;
            this.cboCuDan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboCuDan.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cboCuDan.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cboCuDan.Location = new System.Drawing.Point(488, 50);
            this.cboCuDan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboCuDan.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboCuDan.Name = "cboCuDan";
            this.cboCuDan.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cboCuDan.Radius = 50;
            this.cboCuDan.RectColor = System.Drawing.Color.Black;
            this.cboCuDan.Size = new System.Drawing.Size(257, 62);
            this.cboCuDan.SymbolSize = 24;
            this.cboCuDan.TabIndex = 4;
            this.cboCuDan.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cboCuDan.Watermark = "Lọc theo cư dân...";
            // 
            // cboCanHo
            // 
            this.cboCanHo.DataSource = null;
            this.cboCanHo.FillColor = System.Drawing.Color.White;
            this.cboCanHo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboCanHo.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cboCanHo.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cboCanHo.Location = new System.Drawing.Point(835, 49);
            this.cboCanHo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboCanHo.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboCanHo.Name = "cboCanHo";
            this.cboCanHo.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cboCanHo.Radius = 50;
            this.cboCanHo.RectColor = System.Drawing.Color.Black;
            this.cboCanHo.Size = new System.Drawing.Size(257, 63);
            this.cboCanHo.SymbolSize = 24;
            this.cboCanHo.TabIndex = 5;
            this.cboCanHo.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cboCanHo.Watermark = "Lọc theo căn hộ...";
            // 
            // ucRegistrationManagement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.gridDichVu);
            this.Controls.Add(this.uiPanel1);
            this.FillColor = System.Drawing.Color.DarkGray;
            this.Name = "ucRegistrationManagement";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Radius = 40;
            this.RectColor = System.Drawing.Color.Transparent;
            this.Size = new System.Drawing.Size(1265, 682);
            this.Load += new System.EventHandler(this.ucRegistrationManagement_Load);
            this.uiPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDichVu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIDataGridView gridDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenCudan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaCH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayDK;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.DataGridViewButtonColumn colGiaHan;
        private System.Windows.Forms.DataGridViewButtonColumn colHuy;
        private Sunny.UI.UIComboBox cboCanHo;
        private Sunny.UI.UIComboBox cboCuDan;
        private Sunny.UI.UISymbolButton btnCuDan;
    }
}
