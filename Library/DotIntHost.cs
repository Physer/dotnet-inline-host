using Microsoft.Extensions.Hosting;

namespace Library;

public static class DotIntHost
{
    public static IHost CreateDotIntHost(IDictionary<string, string?>? configurationData) => new DefaultApplicationHost(configurationData).Build();
}
