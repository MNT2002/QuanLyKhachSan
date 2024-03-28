using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace GUI.All_User_Control
{
    public partial class UC_CheckOut : UserControl
    {

        BLL_customer bLL_Customer = new BLL_customer();
        BLL_Room bll_room = new BLL_Room();
        BLL_booked_history bll_booked_history =new BLL_booked_history();
        public UC_CheckOut()
        {
            InitializeComponent();
        }

        public void UC_CheckOut_Load(object sender, EventArgs e)
        {
            BLL_customer bLL_Customer = new BLL_customer();
            guna2DataGridView1.DataSource = bLL_Customer.LoadCustomer();
        }

        private void txt_search_name_TextChanged(object sender, EventArgs e)
        {
            guna2DataGridView1.DataSource = bLL_Customer.GetCustomerByName(txt_search_name.Text);
        }

        int id;
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //txt_Xoa.Text = rowchon.ToString();
            int rowchon = e.RowIndex;
            if (rowchon == -1) return;

            id = int.Parse(guna2DataGridView1.Rows[rowchon].Cells[0].Value.ToString());
            txt_name.Text = guna2DataGridView1.Rows[rowchon].Cells[1].Value.ToString();
            txt_room_no.Text = guna2DataGridView1.Rows[rowchon].Cells[9].Value.ToString();
            
        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {
            if (txt_name.Text != "")
            {
                if (MessageBox.Show("Bạn có chắc chắn không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    String cdate = txt_checkout_date.Text;
                    bLL_Customer.UpdateCustomerCheckout(id, cdate);
                    var a = bLL_Customer.GetCustomerByID(id);
                    bll_booked_history.AddCusHis(a.cid, a.cname,a.mobile.ToString(), a.nationality, a.gender, a.dob, a.idproof, a.address, a.checkin, a.chekout, a.chekout, a.roomid);
                    bll_room.SetRoomState(txt_room_no.Text);
                    MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UC_CheckOut_Load(this, null);
                    bLL_Customer.DeleteCustomer(id);
                    clearAll();
                }
            } else
            {
                MessageBox.Show("Đang không chọn khách hàng nào!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void clearAll()
        {
            txt_search_name.Clear();
            txt_name.Clear();
            txt_room_no.Clear();
            txt_checkout_date.ResetText();
        }

        private void UC_CheckOut_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
