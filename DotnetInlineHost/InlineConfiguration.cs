using Microsoft.Extensions.Configuration;

namespace DotnetInlineHost;

internal static class InlineConfigurationExtensions
{
    public static IConfigurationBuilder AddInlineConfiguration(this IConfigurationBuilder builder, IDictionary<string, string?>? configurationData)
        => builder.Add(new InlineConfigurationSource(configurationData));
}

internal class InlineConfigurationSource : IConfigurationSource
{
    private readonly IDictionary<string, string?>? _configurationData;

    public InlineConfigurationSource(IDictionary<string, string?>? configurationData) => _configurationData = configurationData;

    public IConfigurationProvider Build(IConfigurationBuilder builder) => new InlineConfigurationProvider(_configurationData);
}

internal class InlineConfigurationProvider : ConfigurationProvider
{
    private readonly IDictionary<string, string?>? _configurationData;

    public InlineConfigurationProvider(IDictionary<string, string?>? configurationData) => _configurationData = configurationData;

    public override void Load() => Data = _configurationData ?? new Dictionary<string, string?>();
}
