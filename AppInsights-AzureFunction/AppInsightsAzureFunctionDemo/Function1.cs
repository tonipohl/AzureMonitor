using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

// Sample how to use AppInsights in an Azure Function >=2.x (.NET Core)
// atwork.at, Toni Pohl Jan 2021, Andi Lillich Feb 2021 - Just a demo using App Insights.
// See more details here:
// https://docs.microsoft.com/en-us/dotnet/api/microsoft.applicationinsights.extensibility.telemetryconfiguration.createdefault?view=azure-dotnet
// https://docs.microsoft.com/en-us/azure/azure-monitor/app/console
// Sample-kusto-queries.md

namespace AppInsightsAzureFunctionDemo
{
    public class Function1
    {
        private readonly ITelemetryProvider _provider;
        public Function1(ITelemetryProvider provider)
        {
            this._provider = provider;
        }

        [FunctionName("AppInsightsAzureFunctionDemo")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation($"AppInsightsAzureFunctionDemo Start: {DateTime.Now}");

            var timer = System.Diagnostics.Stopwatch.StartNew();

            // Add custom data to the event
            // customEvents | where timestamp > ago(7d) | order by timestamp desc
            // https://microsoft.github.io/AzureTipsAndTricks/blog/tip195.html
            var dictionary = new Dictionary<string, string>();
            dictionary.Add("Function", "My AppInsightsAzureFunctionDemo");
            dictionary.Add("Caller", "Toni Pohl");
            dictionary.Add("Description", "This is the Azure function using App Insights description");
            _provider.TrackEvent($"Event: Start {DateTime.Now}", dictionary);

            // track a numeric value
            // customMetrics | order by timestamp desc
            _provider.TrackMetric("Metric: Ticks based on current time", DateTime.Now.Ticks);

            // track an exception
            // exceptions | order by timestamp desc
            _provider.TrackException(new Exception($"Exception: at {DateTime.Now}"));

            // track long running external service call
            // dependencies | order by timestamp desc
            _provider.TrackDependency("myDependency", "MyType", "myCall 1", DateTime.Now, timer.Elapsed, true);

            // Done
            _provider.TrackEvent($"Event: End {DateTime.Now}");

            string responseMessage = $"AppInsightsAzureFunctionDemo End: {DateTime.Now}";
            log.LogInformation(responseMessage);

            return new OkObjectResult(responseMessage);
        }
    }
}
