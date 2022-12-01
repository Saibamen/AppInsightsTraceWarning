# AppInsightsTraceWarning

Repro app for Azure bug with Trace warning:

`AI: TelemetryChannel found a telemetry item without an InstrumentationKey. This is a required field and must be set in either your config file or at application startup.`

See: https://github.com/microsoft/ApplicationInsights-dotnet/issues/2070

Steps:
1. Change `ConnectionString` in `appsettings.json`
2. Build Docker image
3. Deploy new App Service with Docker image on Azure
4. Every ~15 minutes you will see trace warning in you App Insights
