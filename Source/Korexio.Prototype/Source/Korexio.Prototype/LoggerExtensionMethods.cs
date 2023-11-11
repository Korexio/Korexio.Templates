using Microsoft.Extensions.Logging;

namespace Korexio.Prototype;

internal static partial class LoggerExtensionMethods
{
  [LoggerMessage(EventId = 100, Message = "'{Name}' started.")]
  public static partial void LogStarted(this ILogger logger, string name, LogLevel level = LogLevel.Information);

  [LoggerMessage(EventId = 200, Message = "'{Name}' stopped.")]
  public static partial void LogStopped(this ILogger logger, string name, LogLevel level = LogLevel.Warning);

  [LoggerMessage(EventId = 300, Message = "Using configuration value '{Name}' = '{Value}'.")]
  public static partial void LogUsingConfigurationValue(this ILogger logger, string name, object value, LogLevel level = LogLevel.Debug);
}
