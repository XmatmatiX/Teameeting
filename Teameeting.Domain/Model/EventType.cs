using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teameeting.Domain.Model
{
    public class EventType
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Meet> Meets { get; set; }
    }
}
