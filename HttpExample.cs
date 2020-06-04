using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace Example.Functions
{
    public static class HttpExample
    {
        static List<Item> items = CreateItems();

        [FunctionName("GetItems")]
        public static IActionResult GetItems([HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "item")] HttpRequest req, ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a GET request.");
            log.LogInformation(items.ToString());

            return new OkObjectResult(items);
        }

        [FunctionName("GetItemById")]
        public static IActionResult GetItemById([HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "item/{id}")] HttpRequest req, ILogger log, string id)
        {
            log.LogInformation("C# HTTP trigger function processed a GET request.");
            
            var item = items.FirstOrDefault(t => t.Id == id);
            if (item == null)
            {
                return new NotFoundResult();
            }

            return new OkObjectResult(item);
        }

        private static List<Item> CreateItems()
        {
            List<Item> items = new List<Item>();

            for (int i = 0; i < 10; i++)
            {
                items.Add(
                    new Item(i.ToString())
                );
            }

            return items;
        }
    }
}
