using BusinessObject;
using DataAccessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class MemberRepository : IMemberRepository
    {
        public List<MemberAccount> GetMembers() => MemberDAO.Instance.GetMembers();
        public MemberAccount CheckLogin(string email, string password)
            => MemberDAO.Instance.CheckLogin(email, password);
        public MemberAccount GetMemberById(int id) => MemberDAO.Instance.GetMemberById(id);
        public List<MemberAccount> GetMemberByNameList(string name) => MemberDAO.Instance.GetMemberByNameList(name);
        public List<MemberAccount> GetMemberByEmailList(string email) => MemberDAO.Instance.GetMemberByEmailList(email);
        public MemberAccount GetMemberByName(string name) => MemberDAO.Instance.GetMemberByName(name);
        public void Register(MemberAccount member) => MemberDAO.Instance.Register(member);
        public void RemoveMember(MemberAccount member) => MemberDAO.Instance.RemoveMember(member);
    }
}
