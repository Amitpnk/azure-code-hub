using Azure.Messaging.ServiceBus;

class Program
{
    private const string connectionString = "<Your-Connection-String>";
    private const string topicName = "<Your-Topic-Name>";
    private const string subscriptionName = "<Your-Subscription-Name>";

    static async Task Main()
    {
        await ReceiveMessagesFromSubscriptionAsync();
    }

    static async Task ReceiveMessagesFromSubscriptionAsync()
    {
        await using var client = new ServiceBusClient(connectionString);
        ServiceBusProcessor processor = client.CreateProcessor(topicName, subscriptionName, new ServiceBusProcessorOptions());

        processor.ProcessMessageAsync += async args =>
        {
            string body = args.Message.Body.ToString();
            Console.WriteLine($"Received message from topic: {body}");

            // Complete the message so it's removed from the subscription
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