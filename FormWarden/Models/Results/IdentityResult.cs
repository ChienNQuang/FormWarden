using FormWarden.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormWarden.Models.Results
{
    public class IdentityResult
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string? Notes { get; set; }
        public string? Uri { get; set; }

        public static IdentityResult FromEntity(Identity entity)
            => new()
            {
                Id = entity.Id,
                Name = entity.Name,
                Uri = entity.Uri,
                Username = entity.Username,
                Password = entity.EncryptedPassword,
                Notes = entity.Note,
            };
    }
}
