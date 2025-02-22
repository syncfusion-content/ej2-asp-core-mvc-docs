---
layout: post
title: Resolve the large entity size issue of the HTTP request in ##Platform_Name## Spreadsheet control | Syncfusion
description: Learn here all about how to resolve the large entity size issue of the HTTP request in Syncfusion ##Platform_Name## Spreadsheet control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Spreadsheet
publishingplatform: ##Platform_Name##
documentation: ug
---

## Resolve the large entity size issue of the HTTP request in ##Platform_Name## Spreadsheet control

To resolve the issue of large entity size in HTTP requests when receiving large amounts of data, you can use the shared code below. Add these codes in Startup.cs within the ConfigureServices method, and also update the web.config file in your server project accordingly. These steps will enable your server to handle large amounts of data in HTTP requests.

web.config:
```csharp
<configuration>
    <system.webServer>
        <security>
            <requestFiltering>
                <requestLimits maxAllowedContentLength="104857600" />
                <!-- Set to 100 MB or any value that suits your needs -->
            </requestFiltering>
        </security>
        <directoryBrowse enabled="true" />
    </system.webServer>
</configuration>
```

Startup.cs:
```csharp
public void ConfigureServices(IServiceCollection services)
{
    services.Configure<FormOptions>(x =>
    {
        x.MultipartBodyLengthLimit = int.MaxValue;
        x.ValueLengthLimit = int.MaxValue;
    });
}
```
