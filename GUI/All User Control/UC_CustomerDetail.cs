using BLL;
using DAL;
using System;
using System.Windows.Forms;

namespace GUI.All_User_Control
{
    public partial class UC_CustomerDetail : UserControl
    {
        BLL_customer bLL_Customer = new BLL_customer();
        BLL_Room bll_room = new BLL_Room();
        BLL_booked_history bLL_Booked_History = new BLL_booked_history();
        public UC_CustomerDetail()
        {
            InitializeComponent();
        }
        private void cb_search_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_search_name.Text = "";
            if (cb_search.SelectedIndex == 0) //get Customer in hotel
            {
                clear();
                gb_edit_customer.Visible = true;
                gb_delete_customer.Visible = true;
                dgv_customer.Height = 241;
                dgv_customer.DataSource = bLL_Customer.LoadCustomer();
            }
            else if (cb_search.SelectedIndex == 1) //get Customer checkout
            {
                gb_edit_customer.Visible = false;
                gb_delete_customer.Visible = false;
                dgv_customer.Height = 510;
                dgv_customer.DataSource = bLL_Booked_History.LoadBookedHistories();
            }
        }

        public void UC_CustomerDetail_Load(object sender, EventArgs e)
        {
            cb_search.SelectedIndex = 0;
            cb_search_SelectedIndexChanged(sender, e);
        }
        public void setCombobox(String roomType, string bedType, ComboBox combo)
        {
            var listroom = bll_room.GetListRoom(roomType, bedType);
            if (listroom != null)
            {
                for (int i = 0; i < listroom.Count; i++)
                {
                    combo.Items.Add(listroom[i].roomNo.ToString());
                }
            }
        }
        string currentIdProof;
        string currentRoomNo;
        private void dgv_customer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowchon = e.RowIndex;
            if (cb_search.SelectedItem == "Checkout") return;
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
            setCombobox(txt_room_type_edit.Text, txt_bed_type_edit.Text, txt_room_no_edit);
            txt_room_no_edit.Items.Add(dgv_customer.Rows[rowchon].Cells[9].Value.ToString());
            txt_room_no_edit.Text = dgv_customer.Rows[rowchon].Cells[9].Value.ToString();
            currentRoomNo = dgv_customer.Rows[rowchon].Cells[9].Value.ToString();

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
            txt_id_edit.Text = "";
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

            txt_id_delete.Text = "";
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
                BLL_customer bLL_Customer = new BLL_customer();
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
                BLL_customer bLL_Customer = new BLL_customer();
                BLL_Room bll_room = new BLL_Room();
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
            BLL_customer bLL_Customer = new BLL_customer();
            BLL_Room bll_room = new BLL_Room();
            customer cus = bLL_Customer.GetCustomerByID(int.Parse(txt_id_delete.Text));
            if (cus != null)
            {
                if (MessageBox.Show("Bạn có muốn xóa khách hàng " + cus.cname.ToString(), "Thông báo", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    bLL_Customer.DeleteCustomer(int.Parse(txt_id_delete.Text));
                    MessageBox.Show("Xóa Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    room getRoomNo = bll_room.GetRoomByRoomNo(txt_room_no_edit.Text);
                    if (getRoomNo != null)
                    {
                        bll_room.SetRoomState(currentRoomNo);
                    }
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

        private void txt_search_name_TextChanged(object sender, EventArgs e)
        {
            if (cb_search.SelectedIndex == 0) //get Customer in hotel
            {
                dgv_customer.DataSource = bLL_Customer.GetAllCustomerByName(txt_search_name.Text, "staying_in_hotel");
            }
            else if (cb_search.SelectedIndex == 1) //get Customer checkout
            {
                dgv_customer.DataSource = bLL_Customer.GetAllCustomerByName(txt_search_name.Text, "");
            }
        }
    }
}
