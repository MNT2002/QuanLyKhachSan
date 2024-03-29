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
        public object GetCustomerByRoomNo(string RoomNo)
        {
            var query = from customer in DB.customers
                        join room in DB.rooms
                        on customer.roomid equals room.roomid
                        where room.roomNo.Contains(RoomNo)
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
        public object GetAllCustomerByName(string CName, string Type)
        {
            if (Type == "staying_in_hotel")
            {
                return DB.customers.Where(cus => cus.cname.Contains(CName) && cus.checkout == "NO").ToList();
            } else
            {
                return DB.booked_histories.Where(cus => cus.cname.Contains(CName)).ToList();
            }
        }
        public customer GetCustomerByID(int ID)
        {
            return DB.customers.Where(cus => cus.cid == ID).FirstOrDefault();
        }  
        public customer GetCustomerByIDProof(string IDProof)
        {
            return DB.customers.Where(cus => cus.idproof == IDProof).FirstOrDefault();
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

        public object getAllCustomer()
        {
            var query = from customer in DB.customers
                        join room in DB.rooms
                        on customer.roomid equals room.roomid

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
        public object getCustomerCheckout()
        {
            var query = from customer in DB.customers
                        join room in DB.rooms
                        on customer.roomid equals room.roomid
                        where customer.chekout == "YES"
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
                            price = room.price,
                            checkout = customer.checkout,
                        };

            return query.ToList();
        }
        public void DeleteCustomer(int cusID)
        {
            customer cus = GetCustomerByID(cusID);
            DB.customers.DeleteOnSubmit(cus);
            DB.SubmitChanges();

        }
        public void UpdateCustomer(int cusID, string Name, int Mobile, string Nationality, string Gender, string Dob, string Idproof, string Address, int Roomid)
        {
            customer cus = GetCustomerByID(cusID);
            cus.cname = Name;
            cus.mobile = Mobile;
            cus.nationality = Nationality;
            cus.gender = Gender;
            cus.dob = Dob;
            cus.idproof = Idproof;
            cus.address = Address;
            cus.roomid = Roomid;
            DB.SubmitChanges();
        }
    }
}
