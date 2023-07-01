using Microsoft.Extensions.Configuration;

namespace Library;

internal static class ApplicationConfigurationExtensions
{
    public static IConfigurationBuilder AddApplicationConfiguration(this IConfigurationBuilder builder, IDictionary<string, string?>? configurationData)
        => builder.Add(new ApplicationConfigurationSource(configurationData));
}

internal class ApplicationConfigurationSource : IConfigurationSource
{
    private readonly IDictionary<string, string?>? _configurationData;

    public ApplicationConfigurationSource(IDictionary<string, string?>? configurationData) => _configurationData = configurationData;

    public IConfigurationProvider Build(IConfigurationBuilder builder) => new ApplicationConfigurationProvider(_configurationData);
}

internal class ApplicationConfigurationProvider : ConfigurationProvider
{
    private readonly IDictionary<string, string?>? _configurationData;

    public ApplicationConfigurationProvider(IDictionary<string, string?>? configurationData) => _configurationData = configurationData;

    public override void Load() => Data = _configurationData ?? new Dictionary<string, string?>();
}
