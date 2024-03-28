namespace GUI
{
    partial class DashBoard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.btnExit = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2CircleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uC_EmployeeDetail1 = new GUI.All_User_Control.UC_EmployeeDetail();
            this.uC_CustomerDetail1 = new GUI.All_User_Control.UC_CustomerDetail();
            this.uC_CheckOut1 = new GUI.All_User_Control.UC_CheckOut();
            this.uC_CustomerRes1 = new GUI.All_User_Control.UC_CustomerRes();
            this.uC_AddRoom1 = new BLL.All_User_Control.UC_AddRoom();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomerDetail = new Guna.UI2.WinForms.Guna2Button();
            this.btnCheckout = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomerRes = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddroom = new Guna.UI2.WinForms.Guna2Button();
            this.MovingPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label_username = new System.Windows.Forms.Label();
            this.logout_label = new System.Windows.Forms.LinkLabel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(190)))), ((int)(((byte)(245)))));
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageSize = new System.Drawing.Size(40, 40);
            this.btnExit.Location = new System.Drawing.Point(1884, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnExit.Size = new System.Drawing.Size(38, 37);
            this.btnExit.TabIndex = 0;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnMinimize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMinimize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMinimize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMinimize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMinimize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(190)))), ((int)(((byte)(245)))));
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.ImageSize = new System.Drawing.Size(40, 40);
            this.btnMinimize.Location = new System.Drawing.Point(1884, 45);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnMinimize.Size = new System.Drawing.Size(38, 37);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.uC_EmployeeDetail1);
            this.panel1.Controls.Add(this.uC_CustomerDetail1);
            this.panel1.Controls.Add(this.uC_CheckOut1);
            this.panel1.Controls.Add(this.uC_CustomerRes1);
            this.panel1.Controls.Add(this.uC_AddRoom1);
            this.panel1.Location = new System.Drawing.Point(12, 181);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1882, 852);
            this.panel1.TabIndex = 3;
            // 
            // uC_EmployeeDetail1
            // 
            this.uC_EmployeeDetail1.BackColor = System.Drawing.Color.White;
            this.uC_EmployeeDetail1.Location = new System.Drawing.Point(-2, -1);
            this.uC_EmployeeDetail1.Name = "uC_EmployeeDetail1";
            this.uC_EmployeeDetail1.Size = new System.Drawing.Size(1882, 852);
            this.uC_EmployeeDetail1.TabIndex = 4;
            // 
            // uC_CustomerDetail1
            // 
            this.uC_CustomerDetail1.BackColor = System.Drawing.Color.White;
            this.uC_CustomerDetail1.Location = new System.Drawing.Point(-2, -1);
            this.uC_CustomerDetail1.Name = "uC_CustomerDetail1";
            this.uC_CustomerDetail1.Size = new System.Drawing.Size(1882, 852);
            this.uC_CustomerDetail1.TabIndex = 3;
            // 
            // uC_CheckOut1
            // 
            this.uC_CheckOut1.BackColor = System.Drawing.Color.White;
            this.uC_CheckOut1.Location = new System.Drawing.Point(-1, -1);
            this.uC_CheckOut1.Margin = new System.Windows.Forms.Padding(4);
            this.uC_CheckOut1.Name = "uC_CheckOut1";
            this.uC_CheckOut1.Size = new System.Drawing.Size(1882, 852);
            this.uC_CheckOut1.TabIndex = 2;
            // 
            // uC_CustomerRes1
            // 
            this.uC_CustomerRes1.BackColor = System.Drawing.Color.White;
            this.uC_CustomerRes1.Location = new System.Drawing.Point(-1, -1);
            this.uC_CustomerRes1.Margin = new System.Windows.Forms.Padding(4);
            this.uC_CustomerRes1.Name = "uC_CustomerRes1";
            this.uC_CustomerRes1.Size = new System.Drawing.Size(1882, 852);
            this.uC_CustomerRes1.TabIndex = 1;
            this.uC_CustomerRes1.Load += new System.EventHandler(this.uC_CustomerRes1_Load);
            // 
            // uC_AddRoom1
            // 
            this.uC_AddRoom1.BackColor = System.Drawing.Color.White;
            this.uC_AddRoom1.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uC_AddRoom1.ForeColor = System.Drawing.Color.Black;
            this.uC_AddRoom1.Location = new System.Drawing.Point(-2, -3);
            this.uC_AddRoom1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.uC_AddRoom1.Name = "uC_AddRoom1";
            this.uC_AddRoom1.Size = new System.Drawing.Size(4630, 1864);
            this.uC_AddRoom1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnEmployee);
            this.panel2.Controls.Add(this.btnCustomerDetail);
            this.panel2.Controls.Add(this.btnCheckout);
            this.panel2.Controls.Add(this.btnCustomerRes);
            this.panel2.Controls.Add(this.btnAddroom);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel2.Location = new System.Drawing.Point(20, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1616, 145);
            this.panel2.TabIndex = 4;
            // 
            // btnEmployee
            // 
            this.btnEmployee.BorderRadius = 18;
            this.btnEmployee.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEmployee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEmployee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEmployee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEmployee.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.Color.White;
            this.btnEmployee.Location = new System.Drawing.Point(1302, 31);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(247, 90);
            this.btnEmployee.TabIndex = 4;
            this.btnEmployee.Text = "Thông Tin Nhân Viên";
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnCustomerDetail
            // 
            this.btnCustomerDetail.BorderRadius = 18;
            this.btnCustomerDetail.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCustomerDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomerDetail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomerDetail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomerDetail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomerDetail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustomerDetail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerDetail.ForeColor = System.Drawing.Color.White;
            this.btnCustomerDetail.Location = new System.Drawing.Point(967, 31);
            this.btnCustomerDetail.Name = "btnCustomerDetail";
            this.btnCustomerDetail.Size = new System.Drawing.Size(247, 90);
            this.btnCustomerDetail.TabIndex = 3;
            this.btnCustomerDetail.Text = "Thông Tin Khách Hàng";
            this.btnCustomerDetail.Click += new System.EventHandler(this.btnCustomerDetail_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.BorderRadius = 18;
            this.btnCheckout.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCheckout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCheckout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCheckout.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.Location = new System.Drawing.Point(667, 31);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(205, 90);
            this.btnCheckout.TabIndex = 2;
            this.btnCheckout.Text = "Trả Phòng";
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnCustomerRes
            // 
            this.btnCustomerRes.BorderRadius = 18;
            this.btnCustomerRes.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCustomerRes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomerRes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomerRes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomerRes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomerRes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustomerRes.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerRes.ForeColor = System.Drawing.Color.White;
            this.btnCustomerRes.Location = new System.Drawing.Point(362, 31);
            this.btnCustomerRes.Name = "btnCustomerRes";
            this.btnCustomerRes.Size = new System.Drawing.Size(205, 90);
            this.btnCustomerRes.TabIndex = 1;
            this.btnCustomerRes.Text = "Đăng Ký Lưu Trú";
            this.btnCustomerRes.Click += new System.EventHandler(this.btnCustomerRes_Click);
            // 
            // btnAddroom
            // 
            this.btnAddroom.AnimatedGIF = true;
            this.btnAddroom.BorderRadius = 18;
            this.btnAddroom.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAddroom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddroom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddroom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddroom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddroom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddroom.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddroom.ForeColor = System.Drawing.Color.White;
            this.btnAddroom.Location = new System.Drawing.Point(55, 31);
            this.btnAddroom.Name = "btnAddroom";
            this.btnAddroom.Size = new System.Drawing.Size(207, 90);
            this.btnAddroom.TabIndex = 0;
            this.btnAddroom.Text = "Quản Lý Phòng";
            this.btnAddroom.Click += new System.EventHandler(this.btnAddroom_Click);
            // 
            // MovingPanel
            // 
            this.MovingPanel.BackColor = System.Drawing.Color.Red;
            this.MovingPanel.Location = new System.Drawing.Point(31, 163);
            this.MovingPanel.Name = "MovingPanel";
            this.MovingPanel.Size = new System.Drawing.Size(300, 7);
            this.MovingPanel.TabIndex = 6;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this;
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.Location = new System.Drawing.Point(1711, 45);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(110, 25);
            this.label_username.TabIndex = 7;
            this.label_username.Text = "Username";
            // 
            // logout_label
            // 
            this.logout_label.AutoSize = true;
            this.logout_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_label.LinkColor = System.Drawing.Color.Black;
            this.logout_label.Location = new System.Drawing.Point(1711, 87);
            this.logout_label.Name = "logout_label";
            this.logout_label.Size = new System.Drawing.Size(122, 25);
            this.logout_label.TabIndex = 8;
            this.logout_label.TabStop = true;
            this.logout_label.Text = "Đăng Xuất";
            this.logout_label.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logout_label_LinkClicked);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(1685, 45);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(29, 32);
            this.guna2PictureBox1.TabIndex = 9;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(1689, 88);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(29, 24);
            this.guna2PictureBox2.TabIndex = 10;
            this.guna2PictureBox2.TabStop = false;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.TargetControl = this;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.TargetControl = this;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(190)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1935, 894);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.logout_label);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.MovingPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleButton btnExit;
        private Guna.UI2.WinForms.Guna2CircleButton btnMinimize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnCustomerDetail;
        private Guna.UI2.WinForms.Guna2Button btnCheckout;
        private Guna.UI2.WinForms.Guna2Button btnCustomerRes;
        private Guna.UI2.WinForms.Guna2Button btnAddroom;
        private Guna.UI2.WinForms.Guna2Button btnEmployee;
        private Guna.UI2.WinForms.Guna2Panel MovingPanel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private BLL.All_User_Control.UC_AddRoom uC_AddRoom1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private All_User_Control.UC_CustomerRes uC_CustomerRes1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private All_User_Control.UC_CheckOut uC_CheckOut1;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.LinkLabel logout_label;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private All_User_Control.UC_CustomerDetail uC_CustomerDetail1;
        private All_User_Control.UC_EmployeeDetail uC_EmployeeDetail1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
    }
}