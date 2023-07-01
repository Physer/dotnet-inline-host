using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DotnetInlineHost;

public static class InlineHost
{
    public static IHost Build(IDictionary<string, string?>? configurationData = default, Action<HostBuilderContext, IServiceCollection>? serviceConfiguration = default) => new InlineApplicationHost(configurationData).Build(serviceConfiguration);
}
