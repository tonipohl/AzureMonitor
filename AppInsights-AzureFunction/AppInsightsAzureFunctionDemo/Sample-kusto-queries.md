# Sample Kusto Queries

~~~~
requests 
| where timestamp > ago(7d)
| order by timestamp desc

customMetrics | order by timestamp desc

dependencies | order by timestamp desc

exceptions | order by timestamp desc

customEvents 
| where timestamp > ago(7d)
| order by timestamp desc

search in (customEvents) "Function"
| where tostring(customDimensions.['Function']) == "My AppInsightsAzureFunctionDemo"

~~~~

...and more. See
https://docs.microsoft.com/en-us/azure/azure-monitor/logs/examples
