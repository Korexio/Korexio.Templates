using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Korexio.Prototype;

public static class MainServiceExtensionMethods
{
  public static IHostBuilder UseMainService(this IHostBuilder hostBuilder)
  {
    if (hostBuilder == null)
    {
      throw new ArgumentNullException(nameof(hostBuilder));
    }

    return hostBuilder.ConfigureServices((hostBuilderContext, serviceCollection) => {
      _ = serviceCollection.AddHostedService<MainService>();

      _ = serviceCollection
            .AddOptions<MainServiceConfiguration>()
            .BindConfiguration("Korexio.Prototype:MainServiceConfiguration")
            .ValidateDataAnnotations();
    });
  }
}
