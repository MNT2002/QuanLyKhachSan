using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BLL_customer
    {
        QuanLyKhachSanDataContext DB = new QuanLyKhachSanDataContext();

        public void AddCustomer(string Name, int PhoneNumber, string Nationality, string Gender, string Dob, string Id, string Address, string Checkin, int RoomId)
        {
            customer cus = new customer();
            cus.cname = Name;
            cus.mobile = PhoneNumber;
            cus.nationality = Nationality;
            cus.gender = Gender;
            cus.dob = Dob;
            cus.idproof = Id;
            cus.address = Address;
            cus.checkin = Checkin;
            cus.roomid = RoomId;

            try
            {
                DB.customers.InsertOnSubmit(cus);
                DB.SubmitChanges();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
