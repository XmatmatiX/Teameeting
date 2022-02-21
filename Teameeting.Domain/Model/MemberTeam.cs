using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teameeting.Domain.Model
{
    public class MemberTeam
    {
        public int MemberId { get; set; }
        public Member Member { get; set; }

        public int TeamId { get; set; }
        public Team Team { get; set; }
    }
}
