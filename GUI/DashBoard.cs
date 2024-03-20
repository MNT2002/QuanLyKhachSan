﻿using System;
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
            btnAddroom.PerformClick();
        }

        private void btnAddroom_Click(object sender, EventArgs e)
        {
            MovingPanel.Left = btnAddroom.Left ;
            uC_AddRoom1.Visible = true;
            uC_AddRoom1.BringToFront();
        }


        private void btnCustomerRes_Click(object sender, EventArgs e)
        {
            MovingPanel.Left = btnAddroom.Left + 320;
            uC_CustomerRes1.Visible = true;
            uC_CustomerRes1.BringToFront();
        }

        private void uC_CustomerRes1_Load(object sender, EventArgs e)
        {

        }
    }
}
