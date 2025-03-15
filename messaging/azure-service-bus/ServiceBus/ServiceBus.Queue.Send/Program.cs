using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Azure.Messaging.ServiceBus;

namespace ServiceBusDemo
{
    class Program
    {
        public static string connectionString = "<connection-string>";
        public static string queueName = "my-queue";

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
            await using (ServiceBusClient client = new ServiceBusClient(connectionString))
            {
                // create a sender for the queue 
                ServiceBusSender sender = client.CreateSender(queueName);

                // create a message that we can send
                ServiceBusMessage message = new ServiceBusMessage("Test Message");

                // send the message
                await sender.SendMessageAsync(message);
                Console.WriteLine($"Sent a single message to the queue: {queueName}");
            }
        }
    }
}