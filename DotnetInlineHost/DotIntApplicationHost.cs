using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Library;

internal class DotIntApplicationHost
{
    private readonly IDictionary<string, string?>? _configurationData;

    public DotIntApplicationHost(IDictionary<string, string?>? configurationData = default) => _configurationData = configurationData;

    public IHost Build(Action<HostBuilderContext, IServiceCollection>? serviceConfiguration = default)
    {
        var host = Host.CreateDefaultBuilder().ConfigureAppConfiguration(builder => builder.AddDotIntConfiguration(_configurationData));
        if (serviceConfiguration is not null)
            host.ConfigureServices(serviceConfiguration);

        return host.Build();
    }
}
