using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
[assembly: FunctionsStartup(typeof(AppInsightsAzureFunctionDemo.Startup))]

namespace AppInsightsAzureFunctionDemo
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            // create the registration for the TelemetryProvider
            builder.Services.AddSingleton<ITelemetryProvider>((s) =>
            {
                return new TelemetryProvider();
            });

            builder.Services.AddApplicationInsightsTelemetry();
        }
    }
}
