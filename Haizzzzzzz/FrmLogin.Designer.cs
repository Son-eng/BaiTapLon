namespace Haizzzzzzz
{
    partial class FrmLogin
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
            this.PanelDN = new Sunny.UI.UIPanel();
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.optResident = new Sunny.UI.UIRadioButton();
            this.optAdmin = new Sunny.UI.UIRadioButton();
            this.uiButton2 = new Sunny.UI.UIButton();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.uiLinkLabel1 = new Sunny.UI.UILinkLabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.txtPass = new Sunny.UI.UITextBox();
            this.uiSymbolButton2 = new Sunny.UI.UISymbolButton();
            this.txtUser = new Sunny.UI.UITextBox();
            this.uiSymbolButton1 = new Sunny.UI.UISymbolButton();
            this.PanelDN.SuspendLayout();
            this.uiGroupBox1.SuspendLayout();
            this.txtPass.SuspendLayout();
            this.txtUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiLabel1
            // 
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Font = new System.Drawing.Font("Script MT Bold", 48.22641F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.ForeColor = System.Drawing.Color.Silver;
            this.uiLabel1.Location = new System.Drawing.Point(96, 10);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(205, 99);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "Login";
            this.uiLabel1.Click += new System.EventHandler(this.uiLabel1_Click);
            // 
            // PanelDN
            // 
            this.PanelDN.BackColor = System.Drawing.Color.Transparent;
            this.PanelDN.Controls.Add(this.uiGroupBox1);
            this.PanelDN.Controls.Add(this.uiButton2);
            this.PanelDN.Controls.Add(this.uiButton1);
            this.PanelDN.Controls.Add(this.uiLinkLabel1);
            this.PanelDN.Controls.Add(this.uiLabel3);
            this.PanelDN.Controls.Add(this.uiLabel2);
            this.PanelDN.Controls.Add(this.txtPass);
            this.PanelDN.Controls.Add(this.txtUser);
            this.PanelDN.Controls.Add(this.uiLabel1);
            this.PanelDN.FillColor = System.Drawing.Color.White;
            this.PanelDN.FillColor2 = System.Drawing.Color.Silver;
            this.PanelDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PanelDN.Location = new System.Drawing.Point(146, 113);
            this.PanelDN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PanelDN.MinimumSize = new System.Drawing.Size(1, 1);
            this.PanelDN.Name = "PanelDN";
            this.PanelDN.Radius = 40;
            this.PanelDN.RectColor = System.Drawing.Color.Transparent;
            this.PanelDN.Size = new System.Drawing.Size(391, 550);
            this.PanelDN.TabIndex = 1;
            this.PanelDN.Text = null;
            this.PanelDN.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.PanelDN.Click += new System.EventHandler(this.PanelDN_Click);
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.optResident);
            this.uiGroupBox1.Controls.Add(this.optAdmin);
            this.uiGroupBox1.FillColor = System.Drawing.Color.Transparent;
            this.uiGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiGroupBox1.Location = new System.Drawing.Point(61, 108);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.RectColor = System.Drawing.Color.Transparent;
            this.uiGroupBox1.Size = new System.Drawing.Size(279, 64);
            this.uiGroupBox1.TabIndex = 5;
            this.uiGroupBox1.Text = null;
            this.uiGroupBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // optResident
            // 
            this.optResident.Cursor = System.Windows.Forms.Cursors.Hand;
            this.optResident.Font = new System.Drawing.Font("Script MT Bold", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optResident.Location = new System.Drawing.Point(141, 25);
            this.optResident.MinimumSize = new System.Drawing.Size(1, 1);
            this.optResident.Name = "optResident";
            this.optResident.RadioButtonColor = System.Drawing.Color.Black;
            this.optResident.Size = new System.Drawing.Size(106, 29);
            this.optResident.TabIndex = 1;
            this.optResident.Text = "Resident";
            // 
            // optAdmin
            // 
            this.optAdmin.Checked = true;
            this.optAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.optAdmin.Font = new System.Drawing.Font("Script MT Bold", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optAdmin.Location = new System.Drawing.Point(23, 25);
            this.optAdmin.MinimumSize = new System.Drawing.Size(1, 1);
            this.optAdmin.Name = "optAdmin";
            this.optAdmin.RadioButtonColor = System.Drawing.Color.Black;
            this.optAdmin.Size = new System.Drawing.Size(88, 29);
            this.optAdmin.TabIndex = 0;
            this.optAdmin.Text = "Admin";
            // 
            // uiButton2
            // 
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.FillColor = System.Drawing.Color.Silver;
            this.uiButton2.FillHoverColor = System.Drawing.Color.LightGray;
            this.uiButton2.FillPressColor = System.Drawing.Color.Gainsboro;
            this.uiButton2.FillSelectedColor = System.Drawing.Color.Transparent;
            this.uiButton2.Font = new System.Drawing.Font("Script MT Bold", 12.22642F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiButton2.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.uiButton2.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.uiButton2.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.uiButton2.Location = new System.Drawing.Point(114, 442);
            this.uiButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.Radius = 40;
            this.uiButton2.RectColor = System.Drawing.Color.Transparent;
            this.uiButton2.RectHoverColor = System.Drawing.Color.Transparent;
            this.uiButton2.RectPressColor = System.Drawing.Color.Transparent;
            this.uiButton2.RectSelectedColor = System.Drawing.Color.Transparent;
            this.uiButton2.Size = new System.Drawing.Size(157, 42);
            this.uiButton2.TabIndex = 4;
            this.uiButton2.Text = "Exit";
            this.uiButton2.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.uiButton2.Click += new System.EventHandler(this.uiButton2_Click);
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.FillColor = System.Drawing.Color.Silver;
            this.uiButton1.FillHoverColor = System.Drawing.Color.LightGray;
            this.uiButton1.FillPressColor = System.Drawing.Color.Gainsboro;
            this.uiButton1.FillSelectedColor = System.Drawing.Color.Transparent;
            this.uiButton1.Font = new System.Drawing.Font("Script MT Bold", 12.22642F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiButton1.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.uiButton1.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.uiButton1.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.uiButton1.Location = new System.Drawing.Point(114, 394);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Radius = 40;
            this.uiButton1.RectColor = System.Drawing.Color.Transparent;
            this.uiButton1.RectHoverColor = System.Drawing.Color.Transparent;
            this.uiButton1.RectPressColor = System.Drawing.Color.Transparent;
            this.uiButton1.RectSelectedColor = System.Drawing.Color.Transparent;
            this.uiButton1.Size = new System.Drawing.Size(157, 42);
            this.uiButton1.TabIndex = 4;
            this.uiButton1.Text = "Login";
            this.uiButton1.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // uiLinkLabel1
            // 
            this.uiLinkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiLinkLabel1.Font = new System.Drawing.Font("Script MT Bold", 12.22642F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLinkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.uiLinkLabel1.Location = new System.Drawing.Point(198, 338);
            this.uiLinkLabel1.Name = "uiLinkLabel1";
            this.uiLinkLabel1.Size = new System.Drawing.Size(150, 21);
            this.uiLinkLabel1.TabIndex = 3;
            this.uiLinkLabel1.TabStop = true;
            this.uiLinkLabel1.Text = "Forget Password ?";
            this.uiLinkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("Script MT Bold", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel3.Location = new System.Drawing.Point(69, 265);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(117, 24);
            this.uiLabel3.TabIndex = 2;
            this.uiLabel3.Text = "Password";
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("Script MT Bold", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(69, 183);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(117, 24);
            this.uiLabel2.TabIndex = 2;
            this.uiLabel2.Text = "Username";
            // 
            // txtPass
            // 
            this.txtPass.Controls.Add(this.uiSymbolButton2);
            this.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass.FillColor = System.Drawing.Color.LightGray;
            this.txtPass.Font = new System.Drawing.Font("Script MT Bold", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(53, 289);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPass.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtPass.Name = "txtPass";
            this.txtPass.Padding = new System.Windows.Forms.Padding(5);
            this.txtPass.Radius = 33;
            this.txtPass.RectColor = System.Drawing.Color.Transparent;
            this.txtPass.ShowText = false;
            this.txtPass.Size = new System.Drawing.Size(296, 47);
            this.txtPass.TabIndex = 1;
            this.txtPass.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPass.Watermark = "";
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            // 
            // uiSymbolButton2
            // 
            this.uiSymbolButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton2.FillColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiSymbolButton2.Location = new System.Drawing.Point(256, 12);
            this.uiSymbolButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton2.Name = "uiSymbolButton2";
            this.uiSymbolButton2.RectColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton2.Size = new System.Drawing.Size(29, 27);
            this.uiSymbolButton2.Symbol = 61475;
            this.uiSymbolButton2.SymbolColor = System.Drawing.Color.Black;
            this.uiSymbolButton2.TabIndex = 5;
            this.uiSymbolButton2.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // txtUser
            // 
            this.txtUser.Controls.Add(this.uiSymbolButton1);
            this.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUser.FillColor = System.Drawing.Color.LightGray;
            this.txtUser.Font = new System.Drawing.Font("Script MT Bold", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(53, 207);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUser.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtUser.Name = "txtUser";
            this.txtUser.Padding = new System.Windows.Forms.Padding(5);
            this.txtUser.Radius = 33;
            this.txtUser.RectColor = System.Drawing.Color.Transparent;
            this.txtUser.ShowText = false;
            this.txtUser.Size = new System.Drawing.Size(296, 47);
            this.txtUser.TabIndex = 1;
            this.txtUser.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtUser.Watermark = "";
            // 
            // uiSymbolButton1
            // 
            this.uiSymbolButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton1.FillColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiSymbolButton1.Location = new System.Drawing.Point(256, 8);
            this.uiSymbolButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton1.Name = "uiSymbolButton1";
            this.uiSymbolButton1.RectColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton1.Size = new System.Drawing.Size(32, 35);
            this.uiSymbolButton1.Symbol = 61447;
            this.uiSymbolButton1.SymbolColor = System.Drawing.Color.Black;
            this.uiSymbolButton1.TabIndex = 5;
            this.uiSymbolButton1.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // FrmLogin
            // 
            this.AllowShowTitle = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::Haizzzzzzz.Properties.Resources._194edcf41770ea6cdd3b7aa51efb02d4;
            this.ClientSize = new System.Drawing.Size(656, 849);
            this.ControlBox = false;
            this.Controls.Add(this.PanelDN);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.RectColor = System.Drawing.Color.Transparent;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ShowTitle = false;
            this.Text = "FrmLogin";
            this.ZoomScaleRect = new System.Drawing.Rectangle(17, 17, 656, 849);
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.PanelDN.ResumeLayout(false);
            this.uiGroupBox1.ResumeLayout(false);
            this.txtPass.ResumeLayout(false);
            this.txtUser.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIPanel PanelDN;
        private Sunny.UI.UITextBox txtPass;
        private Sunny.UI.UITextBox txtUser;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILinkLabel uiLinkLabel1;
        private Sunny.UI.UIButton uiButton2;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UISymbolButton uiSymbolButton2;
        private Sunny.UI.UISymbolButton uiSymbolButton1;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UIRadioButton optAdmin;
        private Sunny.UI.UIRadioButton optResident;
    }
}