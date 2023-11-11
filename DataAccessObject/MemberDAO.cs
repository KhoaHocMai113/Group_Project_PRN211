using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject
{
    public class MemberDAO
    {
        private static MemberDAO instance = null;
        public static readonly object Lock = new object();
        private MemberDAO() { }
        public static MemberDAO Instance
        {
            get
            {
                lock (Lock)
                {
                    if (instance == null)
                    {
                        instance = new MemberDAO();
                    }
                    return instance;
                }
            }
        }
        public List<MemberAccount> GetMembers()
        {
            using var db = new FeedbackFacilitiesDBContext();
            return db.MemberAccounts.ToList();
        }
        public MemberAccount CheckLogin(string email, string password)
        {
            using var db = new FeedbackFacilitiesDBContext();
            return db.MemberAccounts.SingleOrDefault(m => m.Email.Equals(email) && m.Password.Equals(password));
        }
        public MemberAccount GetMemberById(int id)
        {
            var tmp = GetMembers().SingleOrDefault(m => m.Id == id);
            return tmp;
        }
        public List<MemberAccount> GetMemberByNameList(string name)
        {
            var tmp = GetMembers().FindAll(m => m.Username.ToLower().Contains(name.ToLower()));
            return tmp;
        }
        public List<MemberAccount> GetMemberByEmailList(string email)
        {
            var tmp = GetMembers().FindAll(m => m.Email.ToLower().Contains(email.ToLower()));
            return tmp;
        }
        public MemberAccount GetMemberByName(string name)
        {
            var tmp = GetMembers().SingleOrDefault(m => m.Username == name);
            return tmp;
        }
        public void Register(MemberAccount member)
        {
            using var db = new FeedbackFacilitiesDBContext();
            db.MemberAccounts.Add(member);
            db.SaveChanges();
        }
        public void RemoveMember(MemberAccount member)
        {
            using var db = new FeedbackFacilitiesDBContext();
            var tmp = db.MemberAccounts.SingleOrDefault(m => m.Id == member.Id);
            db.MemberAccounts.Remove(tmp);
            db.SaveChanges();
        }
    }
}
