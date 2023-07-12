using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormWarden.Domain.Entities
{
    public class Category
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public Guid OwnerId { get; set; }

        public virtual User Owner { get; set; } = null!;
        public virtual ICollection<Identity> Identities { get; set; } = new List<Identity>();
    }
}
