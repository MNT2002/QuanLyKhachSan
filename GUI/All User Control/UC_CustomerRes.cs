using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.All_User_Control
{
    public partial class UC_CustomerRes : UserControl
    {
        BLL_Room room = new BLL_Room();
        //function fn = new function();
        string query;
        
        public UC_CustomerRes()
        {
            InitializeComponent();
        }
        public void setCombobox(String query1,string query2, ComboBox combo)
        {
           var listroom= room.GetListRoom(query1, query2);
            if (listroom != null)
            {
                for (int i = 0; i < listroom.Count; i++)
                {
                    combo.Items.Add(listroom[i].roomNo.ToString());
                }
            }
            if (listroom.Count==0)
            {
                combo.Items.Add("Không có phòng phù hợp").ToString();
                Console.WriteLine("Không có phòng");
            }
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txt_bed_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_room.SelectedIndex = -1;
            txt_room_no.Items.Clear();
            txt_price.Clear();
        }

        private void txt_room_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_room_no.Items.Clear();
            setCombobox(txt_room.Text, txt_bed_type.Text, txt_room_no);

        }

        private void txt_room_no_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
