using System;
using System.Collections.Generic;
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
        public List<room> GetAllRoomSearch(string RoomNo)
        {
            return DB.rooms.Where(r => r.roomNo.Contains(RoomNo)).ToList();
        }
        public List<room> GetAllRoomfilter(string Filter, string GroupBy)
        {
            switch (Filter)
            {
                case "All":
                    if (GroupBy == "Room Type") return DB.rooms.OrderBy(r => r.roomType).ToList();
                    else if (GroupBy == "Bed Type") return DB.rooms.OrderBy(r => r.bed).ToList();
                    else if (GroupBy == "State") return DB.rooms.OrderBy(r => r.booked).ToList();
                    return DB.rooms.ToList();

                case "Room Type: Ac":
                    if (GroupBy == "Room Type") return DB.rooms.Where(r => r.roomType == "Ac").OrderBy(r => r.roomType).ToList();
                    else if (GroupBy == "Bed Type") return DB.rooms.Where(r => r.roomType == "Ac").OrderBy(r => r.bed).ToList();
                    else if (GroupBy == "State") return DB.rooms.Where(r => r.roomType == "Ac").OrderBy(r => r.booked).ToList();
                    return DB.rooms.Where(r => r.roomType == "Ac").ToList();

                case "Room Type: Non Ac":
                    if (GroupBy == "Room Type") return DB.rooms.Where(r => r.roomType == "Non Ac").OrderBy(r => r.roomType).ToList();
                    else if (GroupBy == "Bed Type") return DB.rooms.Where(r => r.roomType == "Non Ac").OrderBy(r => r.bed).ToList();
                    else if (GroupBy == "State") return DB.rooms.Where(r => r.roomType == "Non Ac").OrderBy(r => r.booked).ToList();
                    return DB.rooms.Where(r => r.roomType == "Non Ac").ToList();

                case "Bed Type: Don":
                    if (GroupBy == "Room Type") return DB.rooms.Where(r => r.bed == "Don").OrderBy(r => r.roomType).ToList();
                    else if (GroupBy == "Bed Type") return DB.rooms.Where(r => r.bed == "Don").OrderBy(r => r.bed).ToList();
                    else if (GroupBy == "State") return DB.rooms.Where(r => r.bed == "Don").OrderBy(r => r.booked).ToList();
                    return DB.rooms.Where(r => r.bed == "Don").ToList();

                case "Bed Type: Doi":
                    if (GroupBy == "Room Type") return DB.rooms.Where(r => r.bed == "Doi").OrderBy(r => r.roomType).ToList();
                    else if (GroupBy == "Bed Type") return DB.rooms.Where(r => r.bed == "Doi").OrderBy(r => r.bed).ToList();
                    else if (GroupBy == "State") return DB.rooms.Where(r => r.bed == "Doi").OrderBy(r => r.booked).ToList();
                    return DB.rooms.Where(r => r.bed == "Doi").ToList();

                case "Bed Type: Queen":
                    if (GroupBy == "Room Type") return DB.rooms.Where(r => r.bed == "Queen").OrderBy(r => r.roomType).ToList();
                    else if (GroupBy == "Bed Type") return DB.rooms.Where(r => r.bed == "Queen").OrderBy(r => r.bed).ToList();
                    else if (GroupBy == "State") return DB.rooms.Where(r => r.bed == "Queen").OrderBy(r => r.booked).ToList();
                    return DB.rooms.Where(r => r.bed == "Queen").ToList();

                case "State: Booked":
                    if (GroupBy == "Room Type") return DB.rooms.Where(r => r.booked == "YES").OrderBy(r => r.roomType).ToList();
                    else if (GroupBy == "Bed Type") return DB.rooms.Where(r => r.booked == "YES").OrderBy(r => r.bed).ToList();
                    else if (GroupBy == "State") return DB.rooms.Where(r => r.booked == "YES").OrderBy(r => r.booked).ToList();
                    return DB.rooms.Where(r => r.booked == "YES").ToList();

                case "State: Empty":
                    if (GroupBy == "Room Type") return DB.rooms.Where(r => r.booked == "NO").OrderBy(r => r.roomType).ToList();
                    else if (GroupBy == "Bed Type") return DB.rooms.Where(r => r.booked == "NO").OrderBy(r => r.bed).ToList();
                    else if (GroupBy == "State") return DB.rooms.Where(r => r.booked == "NO").OrderBy(r => r.booked).ToList();
                    return DB.rooms.Where(r => r.booked == "NO").ToList();

                default:
                    return DB.rooms.ToList();
            }
            
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
            try
            {
            room room = DB.rooms.Where(mh => mh.roomid == roomID).FirstOrDefault();
            DB.rooms.DeleteOnSubmit(room);

            DB.SubmitChanges();
            }
            catch
            {
                MessageBox.Show("Không thể xóa phòng!");
            }

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
        public List<room> GetRoomByRoomNoexcept(string RoomNo,string RoomType,String Bed)
        {
          return DB.rooms.Where(r=>r.roomNo!=RoomNo&&r.roomType==RoomType&&r.bed==Bed).ToList();
        }
    }
}
