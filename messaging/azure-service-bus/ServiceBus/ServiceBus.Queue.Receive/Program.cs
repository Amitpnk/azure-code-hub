using Azure.Messaging.ServiceBus;

class Program
{
    private const string ConnectionString = "<Your-Connection-String>";
    private const string QueueName = "<Your-Queue-Name>";

    static async Task Main()
    {
        await ReceiveMessagesFromQueueAsync();
    }

    static async Task ReceiveMessagesFromQueueAsync()
    {
        await using var client = new ServiceBusClient(ConnectionString);
        ServiceBusProcessor processor = client.CreateProcessor(QueueName, new ServiceBusProcessorOptions());

        processor.ProcessMessageAsync += async args =>
        {
            string body = args.Message.Body.ToString();
            Console.WriteLine($"Received message: {body}");

            // Complete the message so it's removed from the queue
            await args.CompleteMessageAsync(args.Message);
        };

        processor.ProcessErrorAsync += args =>
        {
            Console.WriteLine($"Error: {args.Exception.Message}");
            return Task.CompletedTask;
        };

        await processor.StartProcessingAsync();
        Console.WriteLine("Press any key to stop...");
        Console.ReadKey();

        await processor.StopProcessingAsync();
        await processor.DisposeAsync();
    }

   
}
