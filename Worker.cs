using Microsoft.Extensions.Hosting;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Test
{
    public class WorkerService : BackgroundService
    {
        private const int generalDelay = 1 * 1000; // 10 seconds

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                await Task.Delay(generalDelay, stoppingToken);
                await DoBackupAsync();
            }
        }

        private static Task DoBackupAsync()
        {
            // Generate the B2B File

            if (true)
            {
                Console.WriteLine("Executing background task");
            }

            return Task.FromResult("Done");
        }
    }
}
