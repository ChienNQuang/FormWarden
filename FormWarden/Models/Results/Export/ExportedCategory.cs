using FormWarden.Constants;
using FormWarden.Domain.Entities;
using FormWarden.Helpers;
using System.Text.Json.Serialization;

namespace FormWarden.Models.Results.Export;

public class ExportedCategory
{
    [JsonPropertyName("id")]
    public Guid Id { get; set; }
    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;

    public static ExportedCategory FromEntity(Category category) => new()
    {
        Id = category.Id,
        Name = category.Name,
    };

    public static ExportedCategory FromEntityEncrypted(Category category) => new()
    {
        Id = category.Id,
        Name = SecurityHelper.Encrypt(category.Name, Settings.PassPhrase),
    };
}
