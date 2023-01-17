using AppInsightsTraceWarning.Controllers;
using Microsoft.ApplicationInsights.Channel;
using Microsoft.ApplicationInsights.DataContracts;
using Microsoft.ApplicationInsights.Extensibility;

namespace AppInsightsTraceWarning.Telemetry;

/// <summary>
/// Don't log <see cref="ConfigurationController.Version">api/version</see> request in AppInsights
/// </summary>
public class ApiVersionFilter : ITelemetryProcessor
{
    private ITelemetryProcessor Next { get; }

    public ApiVersionFilter(ITelemetryProcessor next)
    {
        Next = next;
    }

    public void Process(ITelemetry item)
    {
        if (item is RequestTelemetry requestTelemetry)
        {
            if (requestTelemetry.Url.AbsolutePath.Contains("api/version"))
            {
                return;
            }
        }

        Next.Process(item);
    }
}
