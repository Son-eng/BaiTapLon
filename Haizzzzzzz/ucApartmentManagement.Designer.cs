namespace Haizzzzzzz
{
    partial class ucApartmentManagement
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
            this.gridCanHo = new Sunny.UI.UIDataGridView();
            this.colMaCH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colToa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDienTich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colSua = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colXoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cboToa = new Sunny.UI.UIComboBox();
            this.cboMaCH = new Sunny.UI.UIComboBox();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.btnThemMoi = new Sunny.UI.UISymbolButton();
            this.uiPanel2 = new Sunny.UI.UIPanel();
            this.uiSymbolButton2 = new Sunny.UI.UISymbolButton();
            this.uiComboBox2 = new Sunny.UI.UIComboBox();
            this.uiComboBox1 = new Sunny.UI.UIComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridCanHo)).BeginInit();
            this.uiPanel1.SuspendLayout();
            this.uiPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridCanHo
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.gridCanHo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridCanHo.BackgroundColor = System.Drawing.Color.DimGray;
            this.gridCanHo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCanHo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridCanHo.ColumnHeadersHeight = 32;
            this.gridCanHo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridCanHo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaCH,
            this.colToa,
            this.colDienTich,
            this.colTrangThai,
            this.colSua,
            this.colXoa});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridCanHo.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridCanHo.EnableHeadersVisualStyles = false;
            this.gridCanHo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gridCanHo.GridColor = System.Drawing.Color.Gray;
            this.gridCanHo.Location = new System.Drawing.Point(13, 202);
            this.gridCanHo.Name = "gridCanHo";
            this.gridCanHo.RectColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCanHo.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridCanHo.RowHeadersWidth = 45;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gridCanHo.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gridCanHo.SelectedIndex = -1;
            this.gridCanHo.Size = new System.Drawing.Size(1242, 474);
            this.gridCanHo.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.gridCanHo.TabIndex = 4;
            // 
            // colMaCH
            // 
            this.colMaCH.HeaderText = "Mã CH";
            this.colMaCH.MinimumWidth = 6;
            this.colMaCH.Name = "colMaCH";
            this.colMaCH.Width = 160;
            // 
            // colToa
            // 
            this.colToa.HeaderText = "Mã Tòa";
            this.colToa.MinimumWidth = 6;
            this.colToa.Name = "colToa";
            this.colToa.Width = 160;
            // 
            // colDienTich
            // 
            this.colDienTich.HeaderText = "Diện tích";
            this.colDienTich.MinimumWidth = 6;
            this.colDienTich.Name = "colDienTich";
            this.colDienTich.Width = 160;
            // 
            // colTrangThai
            // 
            this.colTrangThai.HeaderText = "Trạng Thái";
            this.colTrangThai.MinimumWidth = 6;
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.Width = 160;
            // 
            // colSua
            // 
            this.colSua.HeaderText = "Sửa";
            this.colSua.MinimumWidth = 6;
            this.colSua.Name = "colSua";
            this.colSua.Width = 160;
            // 
            // colXoa
            // 
            this.colXoa.HeaderText = "Xóa";
            this.colXoa.MinimumWidth = 6;
            this.colXoa.Name = "colXoa";
            this.colXoa.Width = 160;
            // 
            // cboToa
            // 
            this.cboToa.DataSource = null;
            this.cboToa.FillColor = System.Drawing.Color.White;
            this.cboToa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboToa.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cboToa.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cboToa.Location = new System.Drawing.Point(261, 118);
            this.cboToa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboToa.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboToa.Name = "cboToa";
            this.cboToa.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cboToa.Radius = 50;
            this.cboToa.RectColor = System.Drawing.Color.Black;
            this.cboToa.Size = new System.Drawing.Size(235, 59);
            this.cboToa.SymbolSize = 24;
            this.cboToa.TabIndex = 3;
            this.cboToa.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cboToa.Watermark = "";
            // 
            // cboMaCH
            // 
            this.cboMaCH.DataSource = null;
            this.cboMaCH.FillColor = System.Drawing.Color.White;
            this.cboMaCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboMaCH.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cboMaCH.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cboMaCH.Location = new System.Drawing.Point(261, 49);
            this.cboMaCH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboMaCH.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboMaCH.Name = "cboMaCH";
            this.cboMaCH.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cboMaCH.Radius = 50;
            this.cboMaCH.RectColor = System.Drawing.Color.Black;
            this.cboMaCH.Size = new System.Drawing.Size(235, 59);
            this.cboMaCH.SymbolSize = 24;
            this.cboMaCH.TabIndex = 3;
            this.cboMaCH.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cboMaCH.Watermark = "";
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.btnThemMoi);
            this.uiPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel1.Location = new System.Drawing.Point(87, 21);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Radius = 40;
            this.uiPanel1.RectColor = System.Drawing.Color.Transparent;
            this.uiPanel1.Size = new System.Drawing.Size(401, 173);
            this.uiPanel1.TabIndex = 5;
            this.uiPanel1.Text = "Thêm mới căn hộ";
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemMoi.FillColor = System.Drawing.Color.Gray;
            this.btnThemMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMoi.Location = new System.Drawing.Point(111, 64);
            this.btnThemMoi.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Radius = 40;
            this.btnThemMoi.RectColor = System.Drawing.Color.Transparent;
            this.btnThemMoi.Size = new System.Drawing.Size(184, 58);
            this.btnThemMoi.Symbol = 61525;
            this.btnThemMoi.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnThemMoi.SymbolSize = 30;
            this.btnThemMoi.TabIndex = 0;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnThemMoi.Click += new System.EventHandler(this.uiSymbolButton1_Click);
            // 
            // uiPanel2
            // 
            this.uiPanel2.Controls.Add(this.uiSymbolButton2);
            this.uiPanel2.Controls.Add(this.uiComboBox2);
            this.uiPanel2.Controls.Add(this.uiComboBox1);
            this.uiPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel2.Location = new System.Drawing.Point(552, 21);
            this.uiPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.Radius = 40;
            this.uiPanel2.RectColor = System.Drawing.Color.Transparent;
            this.uiPanel2.Size = new System.Drawing.Size(610, 172);
            this.uiPanel2.TabIndex = 6;
            this.uiPanel2.Text = "Tìm kiếm căn hộ";
            this.uiPanel2.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // uiSymbolButton2
            // 
            this.uiSymbolButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton2.FillColor = System.Drawing.Color.Gray;
            this.uiSymbolButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiSymbolButton2.Location = new System.Drawing.Point(445, 77);
            this.uiSymbolButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton2.Name = "uiSymbolButton2";
            this.uiSymbolButton2.Radius = 44;
            this.uiSymbolButton2.RectColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton2.Size = new System.Drawing.Size(147, 45);
            this.uiSymbolButton2.Symbol = 61442;
            this.uiSymbolButton2.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.uiSymbolButton2.TabIndex = 1;
            this.uiSymbolButton2.Text = "Tìm kiếm";
            this.uiSymbolButton2.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // uiComboBox2
            // 
            this.uiComboBox2.DataSource = null;
            this.uiComboBox2.FillColor = System.Drawing.Color.White;
            this.uiComboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiComboBox2.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.uiComboBox2.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiComboBox2.Location = new System.Drawing.Point(249, 77);
            this.uiComboBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboBox2.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboBox2.Name = "uiComboBox2";
            this.uiComboBox2.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiComboBox2.Radius = 39;
            this.uiComboBox2.RectColor = System.Drawing.Color.Black;
            this.uiComboBox2.Size = new System.Drawing.Size(168, 45);
            this.uiComboBox2.SymbolSize = 24;
            this.uiComboBox2.TabIndex = 0;
            this.uiComboBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiComboBox2.Watermark = "Mã căn hộ...";
            // 
            // uiComboBox1
            // 
            this.uiComboBox1.DataSource = null;
            this.uiComboBox1.FillColor = System.Drawing.Color.White;
            this.uiComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiComboBox1.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.uiComboBox1.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiComboBox1.Location = new System.Drawing.Point(61, 77);
            this.uiComboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboBox1.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboBox1.Name = "uiComboBox1";
            this.uiComboBox1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiComboBox1.Radius = 39;
            this.uiComboBox1.RectColor = System.Drawing.Color.Black;
            this.uiComboBox1.Size = new System.Drawing.Size(168, 45);
            this.uiComboBox1.SymbolSize = 24;
            this.uiComboBox1.TabIndex = 0;
            this.uiComboBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiComboBox1.Watermark = "Mã tòa...";
            // 
            // ucApartmentManagement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.uiPanel2);
            this.Controls.Add(this.uiPanel1);
            this.Controls.Add(this.gridCanHo);
            this.FillColor = System.Drawing.Color.Silver;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "ucApartmentManagement";
            this.Radius = 40;
            this.RectColor = System.Drawing.Color.Transparent;
            this.Size = new System.Drawing.Size(1265, 682);
            this.Text = "";
            this.Load += new System.EventHandler(this.ucApartmentManagement_Load);
            this.Click += new System.EventHandler(this.ucApartmentManagement_Click);
            ((System.ComponentModel.ISupportInitialize)(this.gridCanHo)).EndInit();
            this.uiPanel1.ResumeLayout(false);
            this.uiPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIDataGridView gridCanHo;
        private Sunny.UI.UIComboBox cboToa;
        private Sunny.UI.UIComboBox cboMaCH;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UISymbolButton btnThemMoi;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UIComboBox uiComboBox1;
        private Sunny.UI.UISymbolButton uiSymbolButton2;
        private Sunny.UI.UIComboBox uiComboBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaCH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colToa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDienTich;
        private System.Windows.Forms.DataGridViewComboBoxColumn colTrangThai;
        private System.Windows.Forms.DataGridViewButtonColumn colSua;
        private System.Windows.Forms.DataGridViewButtonColumn colXoa;
    }
}
