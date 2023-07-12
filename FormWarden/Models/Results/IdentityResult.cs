using FormWarden.Constants;
using FormWarden.Domain.Entities;
using FormWarden.Helpers;
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
        public string? Category { get; set; }
        public string Name { get; set; } = null!;
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string? Notes { get; set; }
        public string? Uri { get; set; }

        public static IdentityResult FromEntity(Identity entity)
            => new()
            {
                Id = entity.Id,
                Category = entity.Category is null ? "" : entity.Category.Name,
                Name = entity.Name,
                Uri = entity.Uri,
                Username = entity.Username,
                Password = SecurityHelper.Decrypt(entity.EncryptedPassword, Settings.PassPhrase),
                Notes = entity.Note,
            };
    }
}
