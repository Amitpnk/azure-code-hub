using Azure.Messaging.ServiceBus;

namespace ServiceBus.Queue.Send;

public class Program
{
    public static string ConnectionString = "<connection-string>";
    public static string QueueName = "my-queue";

    public static async Task Main(string[] args)
    {

        Console.WriteLine("Press ENTER key to exit after sending all the messages.");

        // Send message
        await SendMessageAsync();

        Console.Read();
    }

    static async Task SendMessageAsync()
    {
        // create a Service Bus client 
        await using (ServiceBusClient client = new ServiceBusClient(ConnectionString))
        {
            // create a sender for the queue 
            ServiceBusSender sender = client.CreateSender(QueueName);

            // create a message that we can send
            ServiceBusMessage message = new ServiceBusMessage("Test Message");

            // send the message
            await sender.SendMessageAsync(message);
            Console.WriteLine($"Sent a single message to the queue: {QueueName}");
        }
    }
}
