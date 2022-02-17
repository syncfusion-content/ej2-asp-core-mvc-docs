---
layout: post
title: Load Balancing Environment in ##Platform_Name## Pdfviewer Component
description: Learn here all about Load Balancing Environment in Syncfusion ##Platform_Name## Pdfviewer component and more.
platform: ej2-asp-core-mvc
control: Load Balancing Environment
publishingplatform: ##Platform_Name##
documentation: ug
---


# Achieve Load balancing environment in MVC framework

The PDF Viewer server library allows you to achieve a Load balancing environment in the MVC framework using the .NET 4.5 framework with the help of **StackExchange Redis package V1.2.6**.

>Note : We have considered the support from the .NET framework 4.5 version and it won’t work in the lower .NET framework version.

## Steps to achieve load balancing environment in the MVC framework

**Step 1**: Install the [StackExchange.Redis.StrongName](https://www.nuget.org/packages/StackExchange.Redis.StrongName) NuGet in the web-service sample.

![Image](../../images/load-balancing.jpeg)

**Step 2:** Create a new class in the web-service project (Example: CacheManager.cs) and implement the **Syncfusion.EJ2.PdfViewer.ICacheManager** interface in the class.

```cs

public class CacheManager:{{'**ICacheManager**'| markdownify }}{}

```

**Step 3:** Connect the Redis database in the constructor by using the **redisconnectionstring** as provided in the below code.

```cs

private IDatabase m_redisDatabase = null;
private int m_slidingExpiration = 0;
public CacheManager(string redisConnectionstring = null, int slidingExpiration = 0)
{
    if (!string.IsNullOrEmpty(redisConnectionstring))
    {
       ConnectionMultiplexer connection = new Lazy&lt;ConnectionMultiplexer&gt;(() =>
        {
            return ConnectionMultiplexer.Connect(redisConnectionstring);
        }).Value;
        if (connection != null)
        {
            m_redisDatabase = connection.GetDatabase();
            m_slidingExpiration = slidingExpiration;
        }
    }
}

```

**Step 4:** Override the **ICacheManager** interface methods into the newly created class for adding, retrieving, and deleting the data from the Redis cache.

```cs

//Adding the data in the redis database.
public void AddCache(string key, byte[] data)
{
    if (m_redisDatabase != null)
    {
        TimeSpan time = m_slidingExpiration > 0 ? new TimeSpan(0, m_slidingExpiration, 0) : new TimeSpan(24, 0, 0); // Provided the sliding expiration time
        m_redisDatabase.StringSet(key, data, time);
    }
}
//Retrieve the data in the redis database.
public byte[] GetCache(string key)
{
    byte[] documentContent = null;
    if (m_redisDatabase != null)
    {
        documentContent =  m_redisDatabase.StringGet(key);
    }
    return documentContent;
}
//Delete the data in the redis database.
public void DeleteCache(string key)
{
    if (m_redisDatabase != null)
    {
        m_redisDatabase.KeyDelete("PDF_CONTENT" + key);
        m_redisDatabase.KeyDelete("PDF_INFO" + key);
    }
}

```

**Step 5:** In the controller, create a new object by passing the **redisconnectionstring** and the sliding expiration time.

```cs

 pdfviewer.CacheManager = new CacheManager(redisconnectonstring, slidingexpiration);

{{'**Note: The sliding expiration is the time in which the data has to be stored in the cache for a specific minutes. If 0 then it will store for 24 hours.**'| markdownify }}

```

**Step 6:** Set the newly created object to **CacheManager** property by using the below code-snippet.

```cs

    PdfRenderer pdfviewer = new PdfRenderer();
    pdfviewer.CacheManager = new CacheManager(redisconnectonstring, 0);

```

**Step 7:** Use this code in all our controller methods (Load, RenderPdfPage).

```cs

  public string {{'**redisconnectonstring**' | markdownify }} = "xxxx, {{'**ssl=True,abortConnect=False,syncTimeout=100000**'| markdownify }}";

    [System.Web.Mvc.HttpPost]
    public object Load(Dictionary&lt;string, string&gt; jsonObject)
    {
        PdfRenderer pdfviewer = new PdfRenderer();
        MemoryStream stream = new MemoryStream();
        object jsonResult = new object();
        if (jsonObject != null && jsonObject.ContainsKey("document"))
        {
            if (bool.Parse(jsonObject["isFileName"]))
            {
                string documentPath = GetDocumentPath(jsonObject["document"]);
                if (!string.IsNullOrEmpty(documentPath))
                {
                    byte[] bytes = System.IO.File.ReadAllBytes(documentPath);
                    stream = new MemoryStream(bytes);
                }
                else
                {
                    return (jsonObject["document"] + " is not found");
                }
            }
            else
            {
                byte[] bytes = Convert.FromBase64String(jsonObject["document"]);
                stream = new MemoryStream(bytes);
            }
        }
        {{'**pdfviewer.CacheManager = new CacheManager(redisconnectonstring, 0);**'| markdownify }}
        jsonResult = pdfviewer.Load(stream, jsonObject);
        return (JsonConvert.SerializeObject(jsonResult));
    }

{{'**Note: Please add the bold lines in all the controller methods.**'| markdownify }}

```

Find the Web-service sample and Nuget package below:
* [Web service](https://www.syncfusion.com/downloads/support/directtrac/general/ze/PdfViewer_WebAPI_Service_(3)1568224382.zip)
* [Nuget](https://www.syncfusion.com/downloads/support/directtrac/general/ze/Syncfusion.EJ2.PdfViewer.AspNet.Mvc5.19.1.0.59-1399631455.zip)