using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormWarden.Domain.Entities
{
    public class Identity
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string Username { get; set; } = null!;
        public string EncryptedPassword { get; set; } = null!;
        public string? Uri { get; set; }
        public string? Note { get; set; }
        public Guid OwnerId { get; set; }

        public virtual User Owner { get; set; } = null!;
    }
}
