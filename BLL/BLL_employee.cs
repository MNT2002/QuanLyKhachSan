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
        public List<employee> LoadEmployee()
        {
            return DB.employees.ToList();
        }
        public void AddEmployee(string username, string password, string email, string fullname, string dob , string address)
        {
            employee e=new employee();
            e.username= username;
            e.password = password;
            e.email = email;
            e.fullname = fullname;
            e.date_of_birth = dob;
            e.address= address;

            try
            {
                DB.employees.InsertOnSubmit(e);
                DB.SubmitChanges();
            }
            catch
            {
            }
        }
        public void UpdateGetEmployee(string ID,string username, string password,string role, string email, string fullname, string dob, string address)
        {
            employee e = GetemployeebyID(Convert.ToInt32(ID));
            e.username = username;
            e.password= password;
            e.email= email;
            e.fullname = fullname;
            e.date_of_birth = dob;
            e.address = address;
            e.role = Convert.ToInt32(role);
            DB.SubmitChanges();
        }
        public employee GetemployeebyID(int ID)
        {
            return DB.employees.Where(r => r.nvid == ID).FirstOrDefault();
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
