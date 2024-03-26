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
        public room GetRoomByRoomID(int roomID)
        {
            return DB.rooms.Where(r => r.roomid == roomID).FirstOrDefault();
        }
        public void DeleteRoom(int roomID)
        {
            room room = DB.rooms.Where(mh => mh.roomid == roomID).FirstOrDefault();
            DB.rooms.DeleteOnSubmit(room);
            DB.SubmitChanges();

        }
        public void UpdateRoom(int roomId, string roomNo, string roomType,string bed, Int64 Price)
        {
            room room = GetRoomByRoomID(roomId);
            room.roomNo=roomNo;
            room.roomType=roomType;
            room.bed=bed;
            room.price = Price;
            DB.SubmitChanges();
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
