using BusinessObject;
using DataAccessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class StaffRepository : IStaffRepository
    {
        public List<Staff> GetStaff() => StaffDAO.Instance.GetStaff();
        public Staff CheckLogin(string email, string password) => StaffDAO.Instance.CheckLogin(email, password);
        public Staff GetStaffById(int id) => StaffDAO.Instance.GetStaffById(id);
        public List<Staff> GetStaffByNameList(string name) => StaffDAO.Instance.GetStaffByNameList(name);
        public List<Staff> GetStaffByEmailList(string email) => StaffDAO.Instance.GetStaffByEmailList(email);
        public Staff GetStaffByName(string name) => StaffDAO.Instance.GetStaffByName(name);
        public void RemoveStaff(Staff staff) => StaffDAO.Instance.RemoveStaff(staff);
    }
}
