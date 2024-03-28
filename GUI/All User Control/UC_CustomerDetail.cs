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
using DAL;

namespace GUI.All_User_Control
{
    public partial class UC_CustomerDetail : UserControl
    {
        BLL_customer bLL_Customer = new BLL_customer();
        BLL_Room bll_room = new BLL_Room();
        public UC_CustomerDetail()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void cb_search_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_search.SelectedIndex == 0) //get all Customer
            {
                dgv_customer.DataSource = bLL_Customer.getAllCustomer();
            }
            else if (cb_search.SelectedIndex == 1) //get Customer in hotel
            {
                dgv_customer.DataSource = bLL_Customer.LoadCustomer();
            }
            else if (cb_search.SelectedIndex == 2) //get Customer checkout
            {
                dgv_customer.DataSource = bLL_Customer.getCustomerCheckout();
            }
        }

        private void UC_CustomerDetail_Load(object sender, EventArgs e)
        {
            cb_search.SelectedIndex = 0;
        }
        public void setCombobox(String roomType, string bedType, ComboBox combo)
        {
            var listroom = bll_room.GetListRoom(roomType, bedType);
            if (listroom != null)
            {
                combo.Enabled = true;
                for (int i = 0; i < listroom.Count; i++)
                {
                    combo.Items.Add(listroom[i].roomNo.ToString());
                }
            } else
            {
                combo.Items.Add("1");
            }
        }
        string currentIdProof;
        string currentRoomNo;
        private void dgv_customer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowchon = e.RowIndex;
            if (rowchon == -1) return;

            txt_id_edit.Text = dgv_customer.Rows[rowchon].Cells[0].Value.ToString();
            txt_name_edit.Text = dgv_customer.Rows[rowchon].Cells[1].Value.ToString();
            txt_mobile_edit.Text = dgv_customer.Rows[rowchon].Cells[2].Value.ToString();
            txt_nationality_edit.Text = dgv_customer.Rows[rowchon].Cells[3].Value.ToString();
            txt_gender_edit.Text = dgv_customer.Rows[rowchon].Cells[4].Value.ToString();
            txt_dob_edit.Text = dgv_customer.Rows[rowchon].Cells[5].Value.ToString();
            txt_idproof_edit.Text = dgv_customer.Rows[rowchon].Cells[6].Value.ToString();
            currentIdProof = dgv_customer.Rows[rowchon].Cells[6].Value.ToString();
            txt_address_edit.Text = dgv_customer.Rows[rowchon].Cells[7].Value.ToString();

            txt_bed_type_edit.Text = dgv_customer.Rows[rowchon].Cells[11].Value.ToString();
            txt_room_type_edit.Text = dgv_customer.Rows[rowchon].Cells[10].Value.ToString();
            txt_room_no_edit.Items.Clear();
            txt_room_no_edit.Items.Add(dgv_customer.Rows[rowchon].Cells[9].Value.ToString());
            currentRoomNo = dgv_customer.Rows[rowchon].Cells[9].Value.ToString();
            txt_room_no_edit.Text = dgv_customer.Rows[rowchon].Cells[9].Value.ToString();

            txt_id_delete.Text = dgv_customer.Rows[rowchon].Cells[0].Value.ToString();
        }

        private void txt_room_type_edit_Click(object sender, EventArgs e)
        {

        }
        private void txt_bed_type_edit_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_room_type_edit.SelectedIndex = -1;
            txt_room_no_edit.Items.Clear();
        }

        private void txt_room_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_room_no_edit.Items.Clear();
            setCombobox(txt_room_type_edit.Text, txt_bed_type_edit.Text, txt_room_no_edit);

        }

        public void clear()
        {
            txt_id_edit.Text="";
            txt_name_edit.Clear();
            txt_mobile_edit.Clear();
            txt_nationality_edit.Clear();
            txt_gender_edit.SelectedIndex = -1;
            txt_address_edit.Clear();
            txt_dob_edit.Clear();
            txt_idproof_edit.Clear();
            txt_bed_type_edit.SelectedIndex = -1;
            txt_room_type_edit.SelectedIndex = -1;
            txt_room_no_edit.SelectedIndex = -1;

            txt_id_delete.Clear();
            cb_search.SelectedIndex = 0;
        }
        private void btn_edit_customer_Click(object sender, EventArgs e)
        {
            if (txt_name_edit.Text == "" || txt_nationality_edit.Text == "" || txt_mobile_edit.Text == "" || txt_gender_edit.Text == "" || txt_idproof_edit.Text == ""
                || txt_dob_edit.Text == "" || txt_room_no_edit.Text == "")
            {
                MessageBox.Show("Thiếu thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Kiểm tra trùng idproof
            if (txt_idproof_edit.Text != currentIdProof)
            {
                foreach (DataGridViewRow dr in dgv_customer.Rows)
                {
                    if (bLL_Customer.GetCustomerByIDProof(txt_idproof_edit.Text) != null)
                    {
                        MessageBox.Show("Mã khách hàng đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txt_idproof_edit.Focus();
                        return;
                    }
                }
            }

            if (MessageBox.Show("Bạn muốn sửa thông tin khách hàng :  " + txt_name_edit.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                int CusId = Convert.ToInt32(txt_id_edit.Text);
                string Name = txt_name_edit.Text;
                int Mobile = Convert.ToInt32(txt_mobile_edit.Text);
                string Nationality = txt_nationality_edit.Text;
                string Gender = txt_gender_edit.Text;
                string Dob = txt_dob_edit.Text;
                string Idproof = txt_idproof_edit.Text;
                string Address = txt_address_edit.Text;
                int RoomId = Convert.ToInt32(bll_room.GetRoomByRoomNo(txt_room_no_edit.Text).roomid);

                bLL_Customer.UpdateCustomer(CusId, Name, Mobile, Nationality, Gender, Dob, Idproof, Address, RoomId);

                room getRoomNo = bll_room.GetRoomByRoomNo(txt_room_no_edit.Text);
                if (getRoomNo != null && getRoomNo.roomNo != currentRoomNo)
                {
                    bll_room.SetRoomState(currentRoomNo);
                    bll_room.SetRoomState(txt_room_no_edit.Text);
                }
                MessageBox.Show("Sửa Khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Load lại dagtagridview
                cb_search_SelectedIndexChanged(sender, e);
                clear();
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            customer cus = bLL_Customer.GetCustomerByID(int.Parse(txt_id_delete.Text));
            if (cus != null)
            {
                if (MessageBox.Show("Bạn có muốn xóa Khách hàng " + cus.cname.ToString(), "Thông báo", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    bLL_Customer.DeleteCustomer(int.Parse(txt_id_delete.Text));
                    MessageBox.Show("Xóa Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cb_search_SelectedIndexChanged(sender, e);
                    clear();
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Khách hàng không tồn tại trong hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
