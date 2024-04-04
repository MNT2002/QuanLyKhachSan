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
    public partial class ForgotPassword : Form
    {
        BLL_employee employ=new BLL_employee();
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void btnforgot_password_submit_Click(object sender, EventArgs e)
        {
            string from, to, pass, content;
            from = "delluna1sthotel@gmail.com".Trim();
            to = txt_forgot_mail.Text;
            pass = "rhfw loaq xvrf swdu".Trim();
            string mailname = "Khách Sạn Del Luna";
            content = "Test email function";
            MailMessage mail = new MailMessage();
            mail.To.Add(to);
            mail.From = new MailAddress(from,mailname);
            mail.Subject = "Your password";
            mail.Body = content;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            var emp = employ.GetEmployeeByMail(to);
            if (emp != null)
            {
                try
                {
                    mail.Body = "Mật khẩu tài khoản của bạn là: "+emp.password;
                    mail.BodyEncoding = Encoding.UTF8;
                    smtp.Send(mail);
                    MessageBox.Show("Email sent successfully", "Email", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    Login login = new Login();
                    login.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Tài khoản này chưa đăng ký!!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btn_return_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            this.Close();
            login.ShowDialog();
        }
    }
}
