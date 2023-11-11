using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;

namespace Korexio.Prototype;

internal static class Program
{
  private static async Task<int> Main(string[] args)
  {
    try
    {
      using var host = Host
        .CreateDefaultBuilder(args)
        .UseMainService()
        .Build();

      await host.RunAsync().ConfigureAwait(false);

      return 0;
    }
#pragma warning disable CA1031 // Do not catch general exception types
    catch (Exception exception)
#pragma warning restore CA1031 // Do not catch general exception types
    {
      Console.WriteLine(exception);
      return -1;
    }
  }
}
