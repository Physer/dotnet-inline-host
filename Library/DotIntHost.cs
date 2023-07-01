using Microsoft.Extensions.Hosting;

namespace Library;

public static class DotIntHost
{
    public static IHost BuildDotIntHost(IDictionary<string, string?>? configurationData = default) => new DotIntApplicationHost(configurationData).Build();
}
