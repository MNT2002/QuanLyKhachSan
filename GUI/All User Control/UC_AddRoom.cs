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

namespace BLL.All_User_Control
{
    public partial class UC_AddRoom : UserControl
    {
        BLL_Room room = new BLL_Room();
        string currentRoom = "";
        public UC_AddRoom()
        {
            InitializeComponent();
        }

        public void UC_AddRoom_Load(object sender, EventArgs e)
        {
            dgv_rooms.DataSource = room.LoadRoom();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void SelectNewlyAddedRow(DataGridView dataGridView)
        {
            // Ensure there is at least one row in the DataGridView
            if (dataGridView.Rows.Count > 0)
            {
                // Select the last row, assuming it's the newly added row
                dataGridView.CurrentCell = dataGridView.Rows[dataGridView.Rows.Count - 1].Cells[0];
            }
        }

        private void btn_add_room_Click(object sender, EventArgs e)
        {
            if (txt_room_no.Text == "" || txt_room_type.Text == "" || txt_bed.Text == "" || txt_price.Text == "")
            {
                //Hiển thị bảng: Thiếu thông tin
                MessageBox.Show("Thiếu thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (room.GetRoomByRoomNo(txt_room_no.Text) != null)
            {
                MessageBox.Show("Số phòng đã tồn tại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_room_no.Focus();
                return;
            }


            string roomNo = txt_room_no.Text;
            string roomType = txt_room_type.Text;
            string bed = txt_bed.Text;
            Int64 price = Convert.ToInt64(txt_price.Text);

            room.AddRoom(roomNo, roomType, bed, price);
            MessageBox.Show("Thêm phòng mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txt_room_no.Clear();
            txt_price.Clear();
            txt_Xoa.Clear();
            txt_roomno_Sua.Clear();
            txt_room_type.SelectedIndex=-1;
            txt_bed.SelectedIndex=-1;
            txt_price.Clear();
            txt_price_Sua.Clear();
            txt_bed_Sua.SelectedIndex = -1;
            txt_room_type_Sua.SelectedIndex = -1;
            //Load lại dagtagridview NhanVien
            dgv_rooms.DataSource = room.LoadRoom();
            /*DeselectAllRows(dgv_rooms);*/

            SelectNewlyAddedRow(dgv_rooms);
           
           

        }
        private void DeselectAllRows(DataGridView dataGridView)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                row.Selected = false;
            }
        }
        private void UC_AddRoom_Leave(object sender, EventArgs e)
        {
            txt_room_no.Clear();
            txt_price.Clear();
            txt_Xoa.Clear();
            txt_roomno_Sua.Clear();
            txt_bed_Sua.SelectedIndex=-1;
            txt_room_type_Sua.SelectedIndex=-1;
            txt_price.Clear();
            txt_room_type.Items.Clear();
            txt_bed.Items.Clear();
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
            room roomcanxoa = room.GetRoomByRoomID(int.Parse(txt_Xoa.Text));
            if (roomcanxoa != null)
            {
                if (MessageBox.Show("Bạn có muốn xóa Phòng " + roomcanxoa.roomNo.ToString(), "Thông báo", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    room.DeleteRoom(int.Parse(txt_Xoa.Text));
                    MessageBox.Show("Xóa Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgv_rooms.DataSource = room.LoadRoom();
                    txt_Xoa.Clear();
                    txt_roomno_Sua.Clear();
                    txt_room_type_Sua.Items.Clear();
                    txt_room_type_Sua.Items.Clear();
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Không có phòng trên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
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
                    if (room.GetRoomByRoomNo(txt_roomno_Sua.Text) != null)
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
                room.UpdateRoom(RoomId,RoomNo, LoaiPhong,LoaiGiuong, int.Parse(Price));
                MessageBox.Show("Sửa Phòng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Load lại dagtagridview NhanVien
                dgv_rooms.DataSource = room.LoadRoom();
                txt_roomno_Sua.Clear();
                txt_room_type_Sua.SelectedIndex = -1;
                txt_bed_Sua.SelectedIndex = -1;
                txt_price_Sua.Clear() ;
                txt_Xoa.Clear();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_roomno_Sua_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void dgv_rooms_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
