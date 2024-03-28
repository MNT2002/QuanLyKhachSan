using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_booked_history
    {
        QuanLyKhachSanDataContext DB = new QuanLyKhachSanDataContext();

        public void AddCusHis(int CusID, string cusName,string Mobile, string Nationality, string gender, string dob, string idproof, string address, string checkin, string checkout, string checkout_status, int roomID)
        {
            booked_history e = new booked_history();
            e.cid = CusID;
            e.cname = cusName;
            e.mobile = Convert.ToInt64(Mobile);
            e.nationality = Nationality;
            e.gender = gender;
            e.dob = dob;
            e.idproof = idproof;
            e.address = address;
            e.checkin = checkin;
            e.checkout_status = checkout_status;
            e.checkout = checkout;
            e.roomid = roomID;
            try
            {
                DB.booked_histories.InsertOnSubmit(e);
                DB.SubmitChanges();
            }
            catch
            {
            }
        }
        
        public List<booked_history> LoadBookedHistories()
        {
            return DB.booked_histories.ToList();
        }
    }
}
