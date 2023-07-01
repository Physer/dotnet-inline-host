using Microsoft.Extensions.Configuration;

namespace Library;

internal static class DotIntConfigurationExtensions
{
    public static IConfigurationBuilder AddDotIntConfiguration(this IConfigurationBuilder builder, IDictionary<string, string?>? configurationData)
        => builder.Add(new DotIntConfigurationSource(configurationData));
}

internal class DotIntConfigurationSource : IConfigurationSource
{
    private readonly IDictionary<string, string?>? _configurationData;

    public DotIntConfigurationSource(IDictionary<string, string?>? configurationData) => _configurationData = configurationData;

    public IConfigurationProvider Build(IConfigurationBuilder builder) => new DotIntConfigurationProvider(_configurationData);
}

internal class DotIntConfigurationProvider : ConfigurationProvider
{
    private readonly IDictionary<string, string?>? _configurationData;

    public DotIntConfigurationProvider(IDictionary<string, string?>? configurationData) => _configurationData = configurationData;

    public override void Load() => Data = _configurationData ?? new Dictionary<string, string?>();
}
