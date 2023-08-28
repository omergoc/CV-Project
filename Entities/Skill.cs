using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Skill
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Proficiency { get; set; }  // Örneğin 1-100 arası bir değer, yeterlilik seviyesini belirtir.

        // Her yetenek bir kullanıcıya aittir.
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }

}
