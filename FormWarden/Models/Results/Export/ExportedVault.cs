using System.Text.Json.Serialization;

namespace FormWarden.Models.Results.Export;

public class ExportedVault
{
    [JsonPropertyName("encrypted")]
    public bool Encrypted { get; set; }
    [JsonPropertyName("categories")]
    public List<ExportedCategory> Categories { get; set; } = new List<ExportedCategory>();
    [JsonPropertyName("items")]
    public List<ExportedIdentity> Items { get; set; } = new List<ExportedIdentity>();
}
