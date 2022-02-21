using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teameeting.Domain.Model;

namespace Teameeting.Domain.Interface
{
    public interface IMemberRepository
    {
        int AddMember(Member member);
        void DeleteMember(int memberId);
        Member GetMemberById(int memberId);
        IQueryable<Team> GetAllTeams(int memberId);
    }
}
