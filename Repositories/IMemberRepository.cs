using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IMemberRepository
    {
        List<MemberAccount> GetMembers();
        MemberAccount CheckLogin(string email, string password);
        MemberAccount GetMemberById(int id);
        List<MemberAccount> GetMemberByNameList(string name);
        List<MemberAccount> GetMemberByEmailList(string email);
        MemberAccount GetMemberByName(string name);
        void Register(MemberAccount member);
        void RemoveMember(MemberAccount member);
    }
}
