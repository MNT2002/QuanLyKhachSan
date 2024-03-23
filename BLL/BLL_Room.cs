using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            r.booked = "NO";

            try
            {
                DB.rooms.InsertOnSubmit(r);
                DB.SubmitChanges();
            }
            catch
            {
            }
        }
        public List<room> GetListRoom(string RoomType, string RoomBed)
        {
            var room = DB.rooms.Where(r => r.roomType == RoomType && r.bed == RoomBed && r.booked == "NO").ToList();
            return room;
        }
        public room GetRoomByRoomNo(string RoomNo)
        {
            return DB.rooms.Where(r => r.roomNo == RoomNo).FirstOrDefault();
        }
        public void SetRoomState(string RoomNo)
        {
            room room = DB.rooms.Where(r => r.roomNo == RoomNo).FirstOrDefault();
            if (room.booked == "NO")
            {
                room.booked = "YES";
            } else
            {
                room.booked = "NO";
            }
            DB.SubmitChanges();
        }
    }
}
