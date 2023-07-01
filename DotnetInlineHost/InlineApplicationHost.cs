using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DotnetInlineHost;

internal class InlineApplicationHost
{
    private readonly IDictionary<string, string?>? _configurationData;

    public InlineApplicationHost(IDictionary<string, string?>? configurationData = default) => _configurationData = configurationData;

    public IHost Build(Action<HostBuilderContext, IServiceCollection>? serviceConfiguration = default)
    {
        var host = Host.CreateDefaultBuilder().ConfigureAppConfiguration(builder => builder.AddInlineConfiguration(_configurationData));
        if (serviceConfiguration is not null)
            host.ConfigureServices(serviceConfiguration);

        return host.Build();
    }
}
