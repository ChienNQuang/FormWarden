using FormWarden.Constants;
using FormWarden.Domain.Entities;
using FormWarden.Helpers;
using System.Text.Json.Serialization;

namespace FormWarden.Models.Results.Export;

public class ExportedIdentity
{
    [JsonPropertyName("id")]
    public Guid Id { get; set; }
    [JsonPropertyName("categoryId")]
    public Guid? CategoryId { get; set; }
    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;
    [JsonPropertyName("username")]
    public string Username { get; set; } = null!;
    [JsonPropertyName("password")]
    public string Password { get; set; } = null!;
    [JsonPropertyName("notes")]
    public string? Notes { get; set; }
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    public static ExportedIdentity FromEntity(Identity identity) => new()
    {
        Id = identity.Id,
        Name = identity.Name,
        Username = identity.Username,
        CategoryId = identity.CategoryId,
        Password = SecurityHelper.Decrypt(identity.EncryptedPassword, Settings.PassPhrase),
        Uri = identity.Uri,
        Notes = identity.Note,
    };

    public static ExportedIdentity FromEntityEncrypted(Identity identity) => new()
    {
        Id = identity.Id,
        Name = SecurityHelper.Encrypt(identity.Name, Settings.PassPhrase),
        Username = SecurityHelper.Encrypt(identity.Username, Settings.PassPhrase),
        CategoryId = identity.CategoryId,
        Password = identity.EncryptedPassword,
        Uri = identity.Uri is null ? null : SecurityHelper.Encrypt(identity.Uri, Settings.PassPhrase),
        Notes = identity.Note is null ? null : SecurityHelper.Encrypt(identity.Note, Settings.PassPhrase),
    };
}
