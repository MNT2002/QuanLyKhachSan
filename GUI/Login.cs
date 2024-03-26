using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using BLL;
namespace GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            BLL_employee emp = new BLL_employee();
            var employ = emp.GetEmployeeByUsername(txtUsername.Text);
            if (employ != null) 
            {
                if(employ.username.Trim()==txtUsername.Text&&employ.password.Trim()==txtPassword.Text)
                {
                    MessageBox.Show(" Đăng nhập thành công.","Đăng nhập",MessageBoxButtons.OK,MessageBoxIcon.Information)  ;
                    DashBoard ds = new DashBoard();
                    
                    this.Hide();
                    ds.ReceivedData(txtUsername.Text);
                    ds.Show();
                    
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng.", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Clear();
                    txtPassword.Focus();
                    labelError.Visible = true;
                    forgot_pass.Visible = true;
                    return;
                }
            }
            else
            {
                labelError.Visible = true;
                forgot_pass.Visible = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                this.guna2Button1_Click(sender, e);
            }
            
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                this.guna2Button1_Click(sender, e);
            }
        }

        private void forgot_pass_Click(object sender, EventArgs e)
        {
            this.Hide();
            ForgotPassword forgotPassword = new ForgotPassword();
            forgotPassword.Show();
        }
    }
    }
