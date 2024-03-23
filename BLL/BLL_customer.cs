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

       public object LoadCustomer()
    {
        var query = from customer in DB.customers
                    join room in DB.rooms
                    on customer.roomid equals room.roomid
                    where customer.chekout == "NO"
                    select new 
                    
                    {
                        cid = customer.cid,
                        cname = customer.cname,
                        mobile = customer.mobile,
                        nationality = customer.nationality,
                        gender = customer.gender,
                        dob = customer.dob,
                        idproof = customer.idproof,
                        address = customer.address,
                        checkin = customer.checkin,
                        roomNo = room.roomNo,
                        roomType = room.roomType,
                        bed = room.bed,
                        price = room.price
                    };

        return query.ToList();
    }

        public List<customer> GetCustomerByName(string CName)
        {
            return DB.customers.Where(cus => cus.cname.Contains(CName) && cus.chekout == "NO").ToList();
        }

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
            cus.chekout = "NO";
            cus.checkout = "NO";

            try
            {
                DB.customers.InsertOnSubmit(cus);
                DB.SubmitChanges();
            }
            catch (Exception ex)
            {

            }
        }
        public void UpdateCustomerCheckout(int id, string cdate)
        {
            customer cus = DB.customers.Where(r => r.cid == id).FirstOrDefault();
            cus.chekout = "YES";
            cus.checkout = cdate;
            DB.SubmitChanges();
        }
    }
}
