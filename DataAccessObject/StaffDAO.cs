using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject
{
    public class StaffDAO
    {
        private static StaffDAO instance = null;
        public static readonly object Lock = new object();
        private StaffDAO() { }
        public static StaffDAO Instance
        {
            get
            {
                lock (Lock)
                {
                    if (instance == null)
                    {
                        instance = new StaffDAO();
                    }
                    return instance;
                }
            }
        }
        public List<Staff> GetStaff()
        {
            using var db = new FeedbackFacilitiesDBContext();
            return db.Staffs.ToList();
        }
        public Staff CheckLogin(string email, string password)
        {
            using var db = new FeedbackFacilitiesDBContext();
            return db.Staffs.SingleOrDefault(m => m.Email.Equals(email) && m.Password.Equals(password));
        }
        public Staff GetStaffById(int id)
        {
            var tmp = GetStaff().SingleOrDefault(m => m.Id == id);
            return tmp;
        }
        public List<Staff> GetStaffByNameList(string name)
        {
            var tmp = GetStaff().FindAll(m => m.Username.ToLower().Contains(name.ToLower()));
            return tmp;
        }
        public List<Staff> GetStaffByEmailList(string email)
        {
            var tmp = GetStaff().FindAll(m => m.Email.ToLower().Contains(email.ToLower()));
            return tmp;
        }
        public Staff GetStaffByName(string name)
        {
            var tmp = GetStaff().SingleOrDefault(m => m.Username == name);
            return tmp;
        }
        public void RemoveStaff(Staff staff)
        {
            using var db = new FeedbackFacilitiesDBContext();
            var tmp = db.Staffs.SingleOrDefault(m => m.Id == staff.Id);
            db.Staffs.Remove(tmp);
            db.SaveChanges();
        }
    }
}
