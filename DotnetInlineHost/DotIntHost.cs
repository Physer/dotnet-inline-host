using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Library;

public static class DotIntHost
{
    public static IHost Build(IDictionary<string, string?>? configurationData = default, Action<HostBuilderContext, IServiceCollection>? serviceConfiguration = default) => new DotIntApplicationHost(configurationData).Build(serviceConfiguration);
}
