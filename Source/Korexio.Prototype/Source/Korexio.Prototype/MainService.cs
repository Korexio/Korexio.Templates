using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Korexio.Prototype;

internal sealed class MainService : BackgroundService
{
  private readonly IHost _Host;
  private readonly MainServiceConfiguration _Configuration;
  private readonly ILoggerFactory _LoggerFactory;

  public MainService(IHost host, IOptions<MainServiceConfiguration> options, ILoggerFactory loggerFactory)
  {
    _Host = host ?? throw new ArgumentNullException(nameof(host));
    _Configuration = (options != null) ? options.Value : throw new ArgumentNullException(nameof(options));
    _LoggerFactory = loggerFactory ?? throw new ArgumentNullException(nameof(loggerFactory));
  }

  protected override async Task ExecuteAsync(CancellationToken stoppingToken)
  {
    var logger = _LoggerFactory.CreateLogger<MainService>();
    logger.LogStarted("Main Service");

    logger.LogUsingConfigurationValue(nameof(_Configuration.Delay), _Configuration.Delay);
    await Task.Delay(_Configuration.Delay, stoppingToken).ConfigureAwait(false);

    logger.LogStopped("Main Service");

    await _Host.StopAsync(stoppingToken).ConfigureAwait(false);
  }
}
