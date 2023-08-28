using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Experience
    {
        public int Id { get; set; }
        public string? JobTitle { get; set; }
        public string? Company { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; } // Bu nullable, devam eden bir iş deneyimi olabilir.
        public string? Description { get; set; }

        // Her deneyim bir kullanıcıya aittir.
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }

}
