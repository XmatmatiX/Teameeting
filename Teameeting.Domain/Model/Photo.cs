using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teameeting.Domain.Model
{
    public class Photo
    {
        public int Id { get; set; }
        public string Description { get; set; }
        [NotMapped]
        public Image Image { get; set; }

        public int MeetId { get; set; }
        public virtual Meet Meet { get; set; }
    }
}
