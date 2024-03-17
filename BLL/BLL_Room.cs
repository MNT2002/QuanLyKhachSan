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

            try
            {
                DB.rooms.InsertOnSubmit(r);
                DB.SubmitChanges();
            }
            catch
            {

            }
        }
    }
}
