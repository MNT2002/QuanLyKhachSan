using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
            
        }
        public void ReceivedData(string receivedData)
        {
            label_username.Text = receivedData;
        }
        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void DashBoard_Load(object sender, EventArgs e)
        {
            uC_AddRoom1.Visible = false;
            uC_CustomerRes1.Visible = false;
            uC_CheckOut1.Visible = false;
            btnAddroom.PerformClick();
        }

        private void btnAddroom_Click(object sender, EventArgs e)
        {
            MovingPanel.Left = btnAddroom.Left - 25;
            uC_AddRoom1.Visible = true;
            uC_AddRoom1.UC_AddRoom_Load(sender,e);
            uC_AddRoom1.BringToFront();
        }


        private void btnCustomerRes_Click(object sender, EventArgs e)
        {
            MovingPanel.Left = btnCustomerRes.Left - 25;
            uC_CustomerRes1.Visible = true;
            uC_CustomerRes1.BringToFront();
        }

        private void uC_CustomerRes1_Load(object sender, EventArgs e)
        {

        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            MovingPanel.Left = btnCheckout.Left - 25;
            uC_CheckOut1.Visible = true;
            uC_CheckOut1.BringToFront();
        }

        private void logout_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Login login = new Login();
            MessageBox.Show("Đăng Xuất Thành Công", "Đăng xuất");
            login.ShowDialog();
        }
    }
}
