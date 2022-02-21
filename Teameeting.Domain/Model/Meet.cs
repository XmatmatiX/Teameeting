using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teameeting.Domain.Model
{
    public class Meet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Place { get; set; }
        public DateTime EventDate { get; set; }

        public int TeamId { get; set; }
        public virtual Team Team { get; set; }

        public int EventTypeId { get; set; }
        public virtual EventType EventType { get; set; }

        public virtual ICollection<Photo> Photos { get; set; }

    }
}
