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
                txt_room_no.Clear();
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
            BLL_Room Bll_room = new BLL_Room();
            var roomsearch = Bll_room.GetRoomByRoomID(idroom);
            txt_roomno_Sua.Text = roomsearch.roomNo;
            txt_room_type_Sua.Text = roomsearch.roomType;
            txt_bed_Sua.Text = roomsearch.bed;
            txt_price_Sua.Text = roomsearch.price.ToString();
        }

        private void dgv_rooms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                    room.XoaRoom(int.Parse(txt_Xoa.Text));
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

            if (MessageBox.Show("Bạn muốn sửa thông tin phòng :  " + txt_room_no.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                string RoomNo = txt_roomno_Sua.Text;
                string LoaiPhong = txt_room_type_Sua.Text;
                string LoaiGiuong = txt_bed_Sua.Text;
                string Price = txt_price_Sua.Text;
                room.Update(RoomNo, LoaiPhong,LoaiGiuong, int.Parse(Price));
                MessageBox.Show("Sửa Phòng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Load lại dagtagridview NhanVien
                dgv_rooms.DataSource = room.LoadRoom();
                txt_roomno_Sua.Clear();
                txt_room_type_Sua.Items.Clear();
                txt_bed_Sua.Items.Clear();
                txt_price_Sua.Clear() ;
                txt_Xoa.Clear();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
