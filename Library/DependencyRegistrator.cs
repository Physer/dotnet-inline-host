using Library.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Library;

public static class DependencyRegistrator
{
    public static void RegisterDotInt(this IServiceCollection services) => services.AddScoped<IApplicationBuilder, DefaultApplicationBuilder>();
}
