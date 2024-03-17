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

namespace BLL.All_User_Control
{
    public partial class UC_AddRoom : UserControl
    {
        BLL_Room room = new BLL_Room();
        public UC_AddRoom()
        {
            InitializeComponent();
        }

        private void UC_AddRoom_Load(object sender, EventArgs e)
        {
            dgv_rooms.DataSource = room.LoadRoom();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void resetText()
        {
            txt_room_no.Clear();
            txt_room_type.SelectedIndex = -1;
            txt_bed.SelectedIndex = -1;
            txt_price.Clear();
        }

        private void btn_add_room_Click(object sender, EventArgs e)
        {
            if (txt_room_no.Text == "" || txt_room_type.Text == "" || txt_bed.Text == "" || txt_price.Text == "")
            {
                //Hiển thị bảng: Thiếu thông tin
                MessageBox.Show("Thiếu thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string roomNo = txt_room_no.Text;
            string roomType = txt_room_type.Text;
            string bed = txt_bed.Text;
            Int64 price = Convert.ToInt64(txt_price.Text);

            room.AddRoom(roomNo, roomType, bed, price);
            MessageBox.Show("Thêm phòng mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Load lại dagtagridview NhanVien
            dgv_rooms.DataSource = room.LoadRoom();
            resetText();
        }

        private void UC_AddRoom_Leave(object sender, EventArgs e)
        {
            resetText();
        }

        private void UC_AddRoom_Enter(object sender, EventArgs e)
        {
            UC_AddRoom_Load(this, null);
        }
    }
}
