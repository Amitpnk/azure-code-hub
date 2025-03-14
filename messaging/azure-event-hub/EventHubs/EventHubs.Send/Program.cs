using System;
using System.Text;
using System.Threading.Tasks;
using Azure.Storage.Blobs;
using Azure.Messaging.EventHubs;
using Azure.Messaging.EventHubs.Consumer;
using Azure.Messaging.EventHubs.Processor;

namespace EventHubs.Receive
{
    class Program
    {
        private const string ehubNamespaceConnectionString = "<connection-string>";
        private const string eventHubName = "my-event-hub";

        static async Task Main(string[] args)
        {
            string consumerGroup = EventHubConsumerClient.DefaultConsumerGroupName;

            var consumer = new EventHubConsumerClient(consumerGroup, ehubNamespaceConnectionString, eventHubName);

            Console.WriteLine("Waiting for messages...");

            while (true)
            {
                await foreach (PartitionEvent partitionEvent in consumer.ReadEventsAsync())
                {
                    Console.WriteLine($"Message Received: {Encoding.Default.GetString(partitionEvent.Data.Body.Span)}");
                }
            }
        }
    }
}