namespace GUI
{
    partial class ForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_forgot_mail = new System.Windows.Forms.TextBox();
            this.btnforgot_password_submit = new System.Windows.Forms.Button();
            this.btn_return_login = new System.Windows.Forms.LinkLabel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(268, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quên Mật Khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(208, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(381, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hãy nhập địa chỉ email của bạn.";
            // 
            // txt_forgot_mail
            // 
            this.txt_forgot_mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_forgot_mail.Location = new System.Drawing.Point(199, 147);
            this.txt_forgot_mail.Name = "txt_forgot_mail";
            this.txt_forgot_mail.Size = new System.Drawing.Size(390, 31);
            this.txt_forgot_mail.TabIndex = 2;
            // 
            // btnforgot_password_submit
            // 
            this.btnforgot_password_submit.Location = new System.Drawing.Point(338, 221);
            this.btnforgot_password_submit.Name = "btnforgot_password_submit";
            this.btnforgot_password_submit.Size = new System.Drawing.Size(80, 40);
            this.btnforgot_password_submit.TabIndex = 3;
            this.btnforgot_password_submit.Text = "Gửi";
            this.btnforgot_password_submit.UseVisualStyleBackColor = true;
            this.btnforgot_password_submit.Click += new System.EventHandler(this.btnforgot_password_submit_Click);
            // 
            // btn_return_login
            // 
            this.btn_return_login.AutoSize = true;
            this.btn_return_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_return_login.Location = new System.Drawing.Point(313, 293);
            this.btn_return_login.Name = "btn_return_login";
            this.btn_return_login.Size = new System.Drawing.Size(122, 24);
            this.btn_return_login.TabIndex = 4;
            this.btn_return_login.TabStop = true;
            this.btn_return_login.Text = "ĐĂNG NHẬP";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(595, 4);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(200, 200);
            this.guna2PictureBox1.TabIndex = 5;
            this.guna2PictureBox1.TabStop = false;
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.btn_return_login);
            this.Controls.Add(this.btnforgot_password_submit);
            this.Controls.Add(this.txt_forgot_mail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forgot Password";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_forgot_mail;
        private System.Windows.Forms.Button btnforgot_password_submit;
        private System.Windows.Forms.LinkLabel btn_return_login;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}