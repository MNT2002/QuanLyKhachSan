using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace BLL
{
    public class BLL_Room
    {
    QuanLyKhachSanDataContext DB = new QuanLyKhachSanDataContext();
        
       

        //Hàm truy vấn tất cả, trả về 1 List Room --> List<Room>
        public List<room> LoadRoom()
        {
            return DB.rooms.ToList();
        }
        public void AddRoom(string RoomNo, string RoomType, string Bed, Int64 Price)
        {
            room r = new room();
            r.roomNo = RoomNo;
            r.roomType = RoomType;
            r.bed = Bed;
            r.price = Price;

            try
            {
                DB.rooms.InsertOnSubmit(r);
                DB.SubmitChanges();
            }
            catch
            {
            }
        }
        public List<room> GetListRoom(string RoomType,string RoomBed)
        {
            var room = DB.rooms.Where(r => r.roomType == RoomType&&r.bed==RoomBed).ToList();
            return room;
        }
    }
}
