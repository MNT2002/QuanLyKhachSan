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
            uC_AddRoom1.UC_AddRoom_Load(sender,e);
            uC_AddRoom1.Visible = true;
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
            uC_CheckOut1.UC_CheckOut_Load(sender,e);
            uC_CheckOut1.Visible = true;
            uC_CheckOut1.BringToFront();
        }

        private void logout_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn đăng xuất!", "Thông báo",  MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
                Login login = new Login();
                login.ShowDialog();
            }
        }

        private void btnCustomerDetail_Click(object sender, EventArgs e)
        {
            MovingPanel.Left = btnCustomerDetail.Left - 25;
            //uC_CustomerDetail1.(sender, e);
            uC_CustomerDetail1.Visible = true;
            uC_CustomerDetail1.BringToFront();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            MovingPanel.Left = btnEmployee.Left - 25;
            //uC_EmployeeDetail1.(sender, e);
            uC_EmployeeDetail1.Visible = true;
            uC_EmployeeDetail1.BringToFront();
        }
    }
}
