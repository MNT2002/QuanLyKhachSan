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
    public partial class UC_CustomerRes : UserControl
    {
        BLL_Room room = new BLL_Room();
        BLL_customer bll_customer = new BLL_customer();
        //function fn = new function();
        string query;

        public UC_CustomerRes()
        {
            InitializeComponent();
        }
        public void setCombobox(String query1, string query2, ComboBox combo)
        {
            var listroom = room.GetListRoom(query1, query2);
            if (listroom != null)
            {
                for (int i = 0; i < listroom.Count; i++)
                {
                    combo.Items.Add(listroom[i].roomNo.ToString());
                }
            }
            if (listroom.Count == 0)
            {
                combo.Items.Add("Không có phòng phù hợp").ToString();
                
            }
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txt_bed_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_room_type.SelectedIndex = -1;
            txt_room_no.Items.Clear();
            txt_price.Clear();
        }

        private void txt_room_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_room_no.Items.Clear();
            setCombobox(txt_room_type.Text, txt_bed_type.Text, txt_room_no);

        }
        int roomId;
            

        private void txt_room_no_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (room.GetRoomByRoomNo(txt_room_no.Text) != null)
            {
                txt_price.Text = room.GetRoomByRoomNo(txt_room_no.Text).price.ToString();
                roomId = room.GetRoomByRoomNo(txt_room_no.Text).roomid;
            } else
            {
                txt_price.Text = "";
            }
        }

        private void btn_add_customer_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "" || txt_phone_number.Text == "" || txt_nationality.Text == "" || txt_gender.SelectedItem == null || 
                txt_dob.Text == "" || txt_id.Text == "" || txt_address.Text == "" || txt_checkin.Text == "" || txt_price.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } else
            {
                String name = txt_name.Text;
                int phoneNumber = Convert.ToInt32(txt_phone_number.Text);
                String nationality = txt_nationality.Text;
                String gender = txt_gender.SelectedItem.ToString();
                String dob = txt_dob.Text;
                String id = txt_id.Text;
                String address = txt_address.Text;
                String checkin = txt_checkin.Text;


                bll_customer.AddCustomer(name, phoneNumber, nationality, gender, dob, id, address, checkin, roomId);
                MessageBox.Show("Đăng kí khách hàng thành công tại số phòng " + txt_room_no.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearAllText();
            }

        }
        public void clearAllText()
        {
            txt_name.Clear();
            txt_nationality.Clear();
            txt_phone_number.Clear();
            txt_id.Clear();
            txt_gender.SelectedItem = -1;
            txt_dob.ResetText();
            txt_address.Clear();
            txt_checkin.ResetText();
            txt_bed_type.SelectedIndex = -1;
            txt_room_type.SelectedIndex = -1;
            txt_room_no.Items.Clear();
            txt_price.Clear();
        }
    }
}
