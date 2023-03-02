---
layout: post
title: How to use the Redis cache in ##Platform_Name## Pdfviewer Control | Syncfusion
description: Learn here all about Redis cache in Syncfusion ##Platform_Name## Pdfviewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Redis cache
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to use the Redis cache

To use Redis cache in Syncfusion PDF Viewer in ASP.NET Core, you can follow these steps:

**Step 1**:Create Redis cache refer to this [link](https://learn.microsoft.com/en-us/azure/azure-cache-for-redis/cache-dotnet-how-to-use-azure-redis-cache)

**Step 2:**  Create a PDFViewer web service application for that use the below link for reference.

[Refer to this link](https://www.syncfusion.com/kb/11063/how-to-create-pdf-viewer-web-service-in-net-core-3-0-and-above)

or you can get the sample web service from GitHub [link](https://github.com/SyncfusionExamples/EJ2-PDFViewer-WebServices).

**Step 3:**  Install Redis Cache package

You need to install the `StackExchange.Redis package` and `Microsoft.Extensions.Caching.Redis`using the NuGet Package Manager 

**Step 4:**  Configure Redis Cache

In the ConfigureServices method of the `Startup class`, you need to add the Redis Cache service using the `AddDistributedRedisCache()`

method. You also need to provide the Redis Cache connection string.

```cs

public void ConfigureServices(IServiceCollection services)
{
    // Add Redis Cache
    services.AddDistributedRedisCache(options =>
    {
        options.Configuration = redisCacheConnectionString;
    });
}

```

**Step 5:** Use the Redis cache in the PDF Viewer controller action:

To use Redis Cache in PDF Viewer, you can implement the IDistributedCache interface and use the Redis Cache service to store and 
retrieve

the PDF document bytes.

```cs
    private readonly IHostingEnvironment _hostingEnvironment;
    public IMemoryCache _cache;
    private IDistributedCache _dCache;
    private IConfiguration _configuration;
    private int _slidingTime = 0;
    string path;
    public PdfViewerController(IMemoryCache memoryCache, IHostingEnvironment hostingEnvironment, IDistributedCache cache, IConfiguration configuration)
    {
        _cache = memoryCache;
        _dCache = cache;
        _hostingEnvironment = hostingEnvironment;
        _configuration = configuration;
        path = _configuration["DOCUMENT_PATH"];
        //check the document path environment variable value and assign default data folder
        //if it is null.
        path = string.IsNullOrEmpty(path) ? Path.Combine(_hostingEnvironment.ContentRootPath, "Data") : Path.Combine(_hostingEnvironment.ContentRootPath, path);
    }       
```

[View Sample in GitHub]()