using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Korexio.Prototype;

internal static class MainServiceExtensionMethods
{
  public static IHostBuilder UseMainService(this IHostBuilder hostBuilder)
  {
    ArgumentNullException.ThrowIfNull(hostBuilder);

    return hostBuilder.ConfigureServices((hostBuilderContext, serviceCollection) => {
      _ = serviceCollection.AddHostedService<MainService>();

      _ = serviceCollection
            .AddOptions<MainServiceConfiguration>()
            .BindConfiguration("Korexio.Prototype:MainServiceConfiguration")
            .ValidateDataAnnotations();
    });
  }
}
