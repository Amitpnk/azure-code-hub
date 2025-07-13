using Azure.Messaging.ServiceBus;

namespace ServiceBus.Topic.Receive;
public class Program
{
    private const string ConnectionString = "<Your-Connection-String>";
    private const string TopicName = "<Your-Topic-Name>";
    private const string SubscriptionName = "<Your-Subscription-Name>";

    static async Task Main()
    {
        await ReceiveMessagesFromSubscriptionAsync();
    }

    static async Task ReceiveMessagesFromSubscriptionAsync()
    {
        await using var client = new ServiceBusClient(ConnectionString);
        ServiceBusProcessor processor = client.CreateProcessor(TopicName, SubscriptionName, new ServiceBusProcessorOptions());

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