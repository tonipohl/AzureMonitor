# AzureMonitor

This repository includes various samples and information how to use Azure Monitoring services and more. This collection will be extended from time to time.

## Why monitoring

Azure is huge!
Discover services that are unsafe, costs, or debug issues. Every service is for a specific purpose. Here´s a list of services that can help to get insights from your services running in Azure or in hybrid scenarios.

[![link](./images/azuremonitor.jpg)](./images/azuremonitor.jpg "Click to enlarge")

- **App Insights:** is a feature of Azure Monitor to monitor a SINGLE desktop or a web app
- **App Center:** Test apps and monitor and distribute a SINGLE app
- **Network Watcher:** troubleshoot VPN, inspect packages and more
- **Azure Monitor:** overall monitoring system = multiple apps
- **Security Center:** monitors all svc & suggests security improvements
- **Azure Advisor:** monitors all svc : security, but also performance, costs
- **Azure Sentinel:** like security center, but goes further
- **Resource Graph:** get current data from Azure Resource Manager
- **Graph Security Center:** get insights and reports from M365
- of course, there´s more...

## Samples

- **AppCenter-WinForm** a simple Win form app using App Center logging in a legacy app (WinForm, full .net framework)
- **AppInsights-AzureFunction** a sample how to use AppInsights in an Azure Function >=2.x (.NET Core)

## Links

### App Insights

- https://docs.microsoft.com/en-us/dotnet/api/microsoft.applicationinsights.extensibility.telemetryconfiguration.createdefault?view=azure-dotnet
- https://docs.microsoft.com/en-us/azure/azure-monitor/app/console
- https://docs.microsoft.com/en-us/azure/azure-monitor/app/javascript
- Using Azure Application Insights In PowerShell: https://www.c-sharpcorner.com/article/using-azure-application-insights-in-powershell/

### Azure Monitor

- Azure Monitor log query examples: https://docs.microsoft.com/en-us/azure/azure-monitor/logs/examples
- Check out the latest news at https://techcommunity.microsoft.com/t5/azure-monitor/azure-monitor-connections-video-mar-16-2021/m-p/2214845

### Network Watcher

- Monitor, diagnose, view metrics, and enable or disable logs for resources in an Azure virtual network
- https://docs.microsoft.com/en-us/azure/network-watcher/network-watcher-monitoring-overview
- Step by step guide thru: https://docs.microsoft.com/en-us/azure/network-watcher/diagnose-vm-network-traffic-filtering-problem
- Azure Network Watcher resources: When you *create or update a virtual network* in your subscription, Network Watcher will be enabled automatically in your Virtual Network's region. When you enable Network Watcher using the portal, the name of the Network Watcher instance is automatically set to NetworkWatcher_region_name where region_name corresponds to the Azure region where the instance is enabled. For example, a Network Watcher enabled in the West Central US region is named NetworkWatcher_westcentralus. The Network Watcher instance is automatically created in a resource group named NetworkWatcherRG. The resource group is created if it does not already exist. If you wish to customize the name of a Network Watcher instance and the resource group it's placed into, you can use PowerShell, the Azure CLI, the REST API, or ARMClient methods. See more at https://docs.microsoft.com/en-us/answers/questions/147292/azure-network-watcher-resources-not-visible-while.html

### Azure Sentinel

- Microsoft Azure Sentinel is a scalable, cloud-native, security information event management (SIEM) and security orchestration automated response (SOAR) solution: https://docs.microsoft.com/en-us/azure/sentinel/overview
- Use Jupyter Notebook to hunt for security threats: https://docs.microsoft.com/en-us/azure/sentinel/notebooks

### App Center

- App Center: https://appcenter.ms/apps
- https://docs.microsoft.com/en-us/appcenter/sdk/getting-started/wpf-winforms
- Security:
    - Multi-Tenant, Hosted in the US
    - App Center Test hosted in US+Denmark
    - CDNs 
    - TLS 1.2
    - Encryption at rest (incl. Azure Storage, Azure SQL and Cosmos DB)
    - See details at https://docs.microsoft.com/en-us/appcenter/general/app-center-security

### Misc

- Azure Friday, Azure Barry video: https://www.youtube.com/watch?v=Zr7LcSr6Ooo
- When to use what Azure monitoring service: https://blog.atwork.at/post/Monitor-overview-of-Azure-services

...more to come
