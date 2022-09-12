namespace TP3_Mat_Discreta
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);

            var fila = new FilaCircular(5);

            fila.Remove();

            fila.Insert(1);
            fila.Insert(2);
            fila.Insert(3);

            fila.display();

            fila.Remove();

            fila.display();

            Console.ReadKey();
        }
    }
}