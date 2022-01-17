using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace csharpguitardevops
{
    public static class servicebus
    {
        [FunctionName("servicebus")]
        public static void Run([ServiceBusTrigger("csharpguitar", Connection = "SERVICE_BUS_QUEUE_CONNECTION")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# ServiceBus queue trigger function processed message: {myQueueItem}");
        }
    }
}
