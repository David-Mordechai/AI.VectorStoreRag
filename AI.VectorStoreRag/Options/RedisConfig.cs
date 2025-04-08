using System.ComponentModel.DataAnnotations;

namespace AI.VectorStoreRag.Options;

/// <summary>
/// Redis service settings.
/// </summary>
internal sealed class RedisConfig
{
    public const string ConfigSectionName = "Redis";

    [Required]
    public string ConnectionConfiguration { get; set; } = string.Empty;
}
