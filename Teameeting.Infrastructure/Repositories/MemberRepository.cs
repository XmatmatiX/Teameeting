using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teameeting.Domain.Interface;
using Teameeting.Domain.Model;

namespace Teameeting.Infrastructure.Repositories
{
    public class MemberRepository : IMemberRepository
    {
        private readonly Context _context;
        public MemberRepository(Context context)
        {
            _context = context;
        }


        public int AddMember(Member member)
        {
            _context.Members.Add(member);
            _context.SaveChanges();
            return member.Id;
        }

        public void DeleteMember(int memberId)
        {
            var member = _context.Members.Find(memberId);
            if (member != null)
            {
                _context.Members.Remove(member);
                _context.SaveChanges();
            }
        }

        public Member GetMemberById(int memberId)
        {
            var member = _context.Members.FirstOrDefault(m => m.Id == memberId);
            return member;
        }

        public IQueryable<Team> GetAllTeams(int memberId)
        {
            var teams = _context.MemberTeam.Where(mt => mt.MemberId == memberId).Select(mt => mt.Team);
            return teams;
        }
    }
}
