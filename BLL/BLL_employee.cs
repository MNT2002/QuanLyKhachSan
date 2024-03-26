using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_employee
    {
        QuanLyKhachSanDataContext DB = new QuanLyKhachSanDataContext();

        public employee GetEmployeeByID(int ID)
        {
            return DB.employees.Where(r => r.nvid == ID).FirstOrDefault();
        }
        public employee GetEmployeeByMail(string EName)
        {
           return DB.employees.Where(r=>r.email == EName).FirstOrDefault();
        }
        public employee GetEmployeeByUsername(string Username)
        {
            return DB.employees.Where(r=>r.username== Username).FirstOrDefault();
        }

        //public void AddCustomer(string Name, int PhoneNumber, string Nationality, string Gender, string Dob, string Id, string Address, string Checkin, int RoomId)
        //{
        //    customer cus = new customer();
        //    cus.cname = Name;
        //    cus.mobile = PhoneNumber;
        //    cus.nationality = Nationality;
        //    cus.gender = Gender;
        //    cus.dob = Dob;
        //    cus.idproof = Id;
        //    cus.address = Address;
        //    cus.checkin = Checkin;
        //    cus.roomid = RoomId;
        //    cus.chekout = "NO";
        //    cus.checkout = "NO";

        //    try
        //    {
        //        DB.customers.InsertOnSubmit(cus);
        //        DB.SubmitChanges();
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //}
        //public void UpdateCustomerCheckout(int id, string cdate)
        //{
        //    customer cus = DB.customers.Where(r => r.cid == id).FirstOrDefault();
        //    cus.chekout = "YES";
        //    cus.checkout = cdate;
        //    DB.SubmitChanges();
        //}
    }
}
