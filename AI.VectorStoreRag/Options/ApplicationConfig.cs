using Microsoft.Extensions.Configuration;

namespace AI.VectorStoreRag.Options;

/// <summary>
/// Helper class to load all configuration settings for the VectorStoreRAG project.
/// </summary>
internal sealed class ApplicationConfig
{
    public RagConfig RagConfig { get; } = new();
    public RedisConfig RedisConfig { get; } = new();
    
    public ApplicationConfig(ConfigurationManager configurationManager)
    {

        configurationManager
            .GetRequiredSection(RagConfig.ConfigSectionName)
            .Bind(RagConfig);
        configurationManager
            .GetRequiredSection($"VectorStores:{RedisConfig.ConfigSectionName}")
            .Bind(RedisConfig);
    }
}
