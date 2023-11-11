using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IStaffRepository
    {
        List<Staff> GetStaff();
        Staff CheckLogin(string email, string password);
        Staff GetStaffById(int id);
        List<Staff> GetStaffByNameList(string name);
        List<Staff> GetStaffByEmailList(string email);
        Staff GetStaffByName(string name);
        void RemoveStaff(Staff staff);
    }
}
