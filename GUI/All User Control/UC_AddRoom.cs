﻿using DAL;
using System;
using System.Windows.Forms;

namespace BLL.All_User_Control
{
    public partial class UC_AddRoom : UserControl
    {
        BLL_Room bLL_Room = new BLL_Room();
        string currentRoom = "";
        public UC_AddRoom()
        {
            InitializeComponent();
        }

        public void UC_AddRoom_Load(object sender, EventArgs e)
        {
            BLL_Room room = new BLL_Room();
            dgv_rooms.DataSource = room.LoadRoom();
            cb_group_by.SelectedItem = "All";
            cb_filter.SelectedItem = "All";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void SelectNewlyAddedRow(DataGridView dataGridView)
        {
            // Ensure there is at least one row in the DataGridView
            if (dataGridView.Rows.Count > 0)
            {
                // Select the last row, assuming its the newly added row
                dataGridView.CurrentCell = dataGridView.Rows[dataGridView.Rows.Count - 1].Cells[0];
            }
        }

        private void btn_add_room_Click(object sender, EventArgs e)
        {
            BLL_Room bLL_Room = new BLL_Room();
            if (txt_room_no.Text == "" || txt_room_type.Text == "" || txt_bed.Text == "" || txt_price.Text == "")
            {
                //Hiển thị bảng: Thiếu thông tin
                MessageBox.Show("Thiếu thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (bLL_Room.GetRoomByRoomNo(txt_room_no.Text) != null)
            {
                MessageBox.Show("Số phòng đã tồn tại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_room_no.Focus();
                return;
            }


            string roomNo = txt_room_no.Text;
            string roomType = txt_room_type.Text;
            string bed = txt_bed.Text;
            Int64 price = Convert.ToInt64(txt_price.Text);

            bLL_Room.AddRoom(roomNo, roomType, bed, price);
            MessageBox.Show("Thêm phòng mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txt_room_no.Clear();
            txt_price.Clear();
            txt_Xoa.Clear();
            txt_roomno_Sua.Clear();
            txt_room_type.SelectedIndex = -1;
            txt_bed.SelectedIndex = -1;
            txt_price.Clear();
            txt_price_Sua.Clear();
            txt_bed_Sua.SelectedIndex = -1;
            txt_room_type_Sua.SelectedIndex = -1;
            //Load lại dagtagridview NhanVien
            dgv_rooms.DataSource = bLL_Room.LoadRoom();
            /*DeselectAllRows(dgv_rooms);*/

            SelectNewlyAddedRow(dgv_rooms);



        }
        private void UC_AddRoom_Leave(object sender, EventArgs e)
        {
            txt_room_no.Clear();
            txt_price.Clear();
            txt_Xoa.Clear();
            txt_roomno_Sua.Clear();
            txt_bed_Sua.SelectedIndex = -1;
            txt_room_type_Sua.SelectedIndex = -1;
            txt_price.Clear();
            txt_room_type.SelectedIndex = -1;
            txt_bed.SelectedIndex = -1;
            txt_roomid_Sua.Clear();
            txt_price_Sua.Clear();
        }

        private void UC_AddRoom_Enter(object sender, EventArgs e)
        {
            UC_AddRoom_Load(this, null);
        }
        int idroom = -1;
        private void dgv_rooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //txt_Xoa.Text = rowchon.ToString();
            int rowchon = e.RowIndex;
            if (rowchon == -1) return;
            txt_Xoa.Text = dgv_rooms.Rows[rowchon].Cells[0].Value.ToString();
            //Load NhanVien theo ID nhân viên
            idroom = Convert.ToInt32(dgv_rooms.Rows[rowchon].Cells[0].Value.ToString());
            txt_roomid_Sua.Text = dgv_rooms.Rows[rowchon].Cells[0].Value.ToString();
            txt_roomno_Sua.Text = dgv_rooms.Rows[rowchon].Cells[1].Value.ToString();
            txt_room_type_Sua.Text = dgv_rooms.Rows[rowchon].Cells[2].Value.ToString();
            txt_bed_Sua.Text = dgv_rooms.Rows[rowchon].Cells[3].Value.ToString();
            txt_price_Sua.Text = dgv_rooms.Rows[rowchon].Cells[4].Value.ToString();

            currentRoom = dgv_rooms.Rows[rowchon].Cells[1].Value.ToString();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (txt_Xoa.Text != "")
            {
                BLL_Room bLL_Room = new BLL_Room();
                room roomcanxoa = bLL_Room.GetRoomByRoomID(Convert.ToInt32(txt_Xoa.Text));
                if (roomcanxoa != null)
                {
                    if (roomcanxoa.booked == "NO")
                    {

                        if (MessageBox.Show("Bạn có muốn xóa Phòng " + roomcanxoa.roomNo.ToString(), "Thông báo", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            bLL_Room.DeleteRoom(Convert.ToInt32(txt_Xoa.Text));
                            MessageBox.Show("Xóa Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dgv_rooms.DataSource = bLL_Room.LoadRoom();
                            cb_group_by.SelectedItem = "All";
                            cb_filter.SelectedItem = "All";
                            clear();
                        }
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Phòng đang được cho thuê", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Không có phòng trên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Trường xóa trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
        public void clear()
        {
            txt_roomno_Sua.Text = "";
            txt_room_type_Sua.SelectedIndex = -1;
            txt_bed_Sua.SelectedIndex = -1;
            txt_price_Sua.Clear();
            txt_Xoa.Clear();
        }
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (txt_roomno_Sua.Text == "" || txt_room_type_Sua.Text == "" || txt_price_Sua.Text == "" || txt_bed_Sua.Text == "")
            {
                MessageBox.Show("Thiếu thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Kiểm tra trùng roomno
            if (txt_roomno_Sua.Text != currentRoom)
            {
                foreach (DataGridViewRow dr in dgv_rooms.Rows)
                {
                    if (bLL_Room.GetRoomByRoomNo(txt_roomno_Sua.Text) != null)
                    {
                        MessageBox.Show("Số phòng đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txt_room_no.Focus();
                        return;
                    }
                }
            }

            if (MessageBox.Show("Bạn muốn sửa thông tin phòng :  " + txt_roomno_Sua.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                int RoomId = idroom;
                string RoomNo = txt_roomno_Sua.Text;
                string LoaiPhong = txt_room_type_Sua.Text;
                string LoaiGiuong = txt_bed_Sua.Text;
                string Price = txt_price_Sua.Text;
                bLL_Room.UpdateRoom(RoomId, RoomNo, LoaiPhong, LoaiGiuong, int.Parse(Price));
                MessageBox.Show("Sửa Phòng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Load lại dagtagridview NhanVien
                cb_group_by.SelectedItem = "All";
                cb_filter.SelectedItem = "All";
                dgv_rooms.DataSource = bLL_Room.LoadRoom();
                clear();
            }
        }

        private void txt_search_room_TextChanged(object sender, EventArgs e)
        {
            cb_group_by.SelectedItem = "All";
            cb_filter.SelectedItem = "All";
            dgv_rooms.DataSource = bLL_Room.GetAllRoomSearch(txt_search_room.Text);
        }
        private void cb_group_by_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_filter_SelectedIndexChanged(sender, e);
        }

        private void cb_filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            BLL_Room bLL_Room = new BLL_Room();
            string GroupBy = cb_group_by.Text;
            if (cb_filter.SelectedItem == "All")
            {
                dgv_rooms.DataSource = bLL_Room.GetAllRoomfilter("All", GroupBy);
            }
            else if (cb_filter.SelectedItem == "Room Type: Ac")
            {
                dgv_rooms.DataSource = bLL_Room.GetAllRoomfilter("Room Type: Ac", GroupBy);
            }
            else if (cb_filter.SelectedItem == "Room Type: Non Ac")
            {
                dgv_rooms.DataSource = bLL_Room.GetAllRoomfilter("Room Type: Non Ac", GroupBy);
            }
            else if (cb_filter.SelectedItem == "Bed Type: Don")
            {
                dgv_rooms.DataSource = bLL_Room.GetAllRoomfilter("Bed Type: Don", GroupBy);
            }
            else if (cb_filter.SelectedItem == "Bed Type: Doi")
            {
                dgv_rooms.DataSource = bLL_Room.GetAllRoomfilter("Bed Type: Doi", GroupBy);
            }
            else if (cb_filter.SelectedItem == "Bed Type: Queen")
            {
                dgv_rooms.DataSource = bLL_Room.GetAllRoomfilter("Bed Type: Queen", GroupBy);
            }
            else if (cb_filter.SelectedItem == "State: Booked")
            {
                dgv_rooms.DataSource = bLL_Room.GetAllRoomfilter("State: Booked", GroupBy);
            }
            else if (cb_filter.SelectedItem == "State: Empty")
            {
                dgv_rooms.DataSource = bLL_Room.GetAllRoomfilter("State: Empty", GroupBy);
            }

        }
    }
}
