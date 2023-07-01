using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Library.Interfaces;

public interface IApplicationBuilder
{
    IHost Build(Action<HostBuilderContext, IServiceCollection>? serviceConfiguration = default);
}
