using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teameeting.Domain.Model
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Password { get; set; }
        public int AdminId { get; set; }

        public virtual ICollection<Meet> Meets { get; set; }

        public virtual ICollection<MemberTeam> MemberTeams { get; set; }

    }
}
