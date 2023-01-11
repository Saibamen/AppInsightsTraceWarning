# AppInsightsTraceWarning

Repro app for Azure bug with Trace warning:

`AI: TelemetryChannel found a telemetry item without an InstrumentationKey. This is a required field and must be set in either your config file or at application startup.`

See: https://github.com/microsoft/ApplicationInsights-dotnet/issues/2070

Steps:

1. Change `ConnectionString` in `appsettings.json`
2. Build Docker image: `docker build --pull -t appinsightstracewarning -f .\AppInsightsTraceWarning\Dockerfile .`
3. Tag and push your Docker image:
    1. `docker tag appinsightstracewarning your_container_registry.azurecr.io/appinsightstracewarning`
    2. `docker push your_container_registry.azurecr.io/appinsightstracewarning`
4. Deploy new App Service with Docker image on Azure
5. Every ~15 minutes you will see trace warning in your App Insights
