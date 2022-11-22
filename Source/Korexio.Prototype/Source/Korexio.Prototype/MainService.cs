using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Korexio.Prototype;

public sealed class MainService : BackgroundService
{
  private readonly MainServiceConfiguration _configuration;
  private readonly ILogger _logger;

  public MainService(IOptions<MainServiceConfiguration> options, ILogger<MainService> logger)
  {
    if (options == null)
    {
      throw new ArgumentNullException(nameof(options));
    }

    _configuration = options.Value;
    _logger = logger;
  }

  protected override async Task ExecuteAsync(CancellationToken stoppingToken)
  {
    _logger.LogStarted("Main Service");

    _logger.LogUsingConfigurationValue(nameof(_configuration.Delay), _configuration.Delay);
    await Task.Delay(_configuration.Delay, stoppingToken).ConfigureAwait(false);

    _logger.LogStopped("Main Service");
  }
}
