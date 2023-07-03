---
layout: post
title: "Elasticsearch Data Binding in ASP.NET Core Pivotview component | Syncfusion"
platform: ej2-asp-core-mvc
description: "Learn how to bind data from a Elasticsearch database in the Syncfusion ASP.NET Core Pivot Table of Syncfusion Essential JS 2 and more."
---

# Elasticsearch in EJ2 ASP.NET Core Pivotview Component

This section describes how to retrieve data from Elasticsearch database using [Nest](https://www.nuget.org/packages/Nest) library and bind it to the Pivot Table via a Web API controller.

## Create a Web API service to fetch Elasticsearch data

**1.** Open Visual Studio and create an ASP.NET Core Web App project type, naming it **MyWebService**. To create an ASP.NET Core Web application, follow the document [link](https://learn.microsoft.com/en-us/visualstudio/get-started/csharp/tutorial-aspnet-core?view=vs-2022).

![Create ASP.NET Core Web App project](../images/azure-asp-core-web-service-create.png)

**2.** To connect a Elasticsearch Server using the **NEST** in our application, we need to install the [NEST](https://www.nuget.org/packages/NEST/) NuGet package. To do so, open the NuGet package manager of the project solution, search for the package **NEST** and install it.

![Add the NuGet package "NEST" to the project](../images/next-nuget-package-install.png)

**3.** Create a Web API controller (aka, PivotController.cs) file under **Controllers** folder that helps to establish data communication with the Pivot Table.

**4.** In the Web API controller (aka, PivotController), **ElasticClient** helps to connect the Elasticsearch database. Next, using **Search** method you can query your Elasticsearch index and retrieve results from the database.

**5.** In the **Get()** method of the **PivotController.cs** file, the **FetchElasticsearchData** method is used to retrieve the Elasticsearch data, which is then serialized into JSON using **JsonConvert.SerializeObject()**.

```csharp
    using Microsoft.AspNetCore.Mvc;
    using Nest;
    using Newtonsoft.Json;

    namespace MyWebService.Controllers
    {
        [ApiController]
        [Route("[controller]")]
        public class PivotController : ControllerBase
        {
            [HttpGet(Name = "GetElasticSearchData")]
            public object Get()
            {
                return JsonConvert.SerializeObject(FetchElasticsearchData());
            }

            private static object FetchElasticsearchData()
            {
                // Replace with your own connection string.
                var connectionString = "<Enter your valid connection string here>";
                var uri = new Uri(connectionString);
                var connectionSettings = new ConnectionSettings(uri);
                var client = new ElasticClient(connectionSettings);
                var searchResponse = client.Search<object>(s => s
                    .Index("product")
                    .Size(1000)
                );
                return searchResponse.Documents;
            }
        }
    }

```

**6.** Run the web application and it will be hosted within the URL `https://localhost:44323`.

**7.** Finally, the retrieved data from Elasticsearch database which is in the form of JSON can be found in the Web API controller available in the URL link `https://localhost:44323/Pivot`, as shown in the browser page below.

![Hosted Web API URL](../images/elasticsearch-data.png)

## Connecting the Pivot Table to a Elasticsearch database using the Web API service

**1.** Create a simple ASP.NET Core Pivot Table by following the **"Getting Started"** documentation [link](../getting-started).

**2.** Map the hosted Web API's URL link `https://localhost:44323/Pivot` to the Pivot Table component in **~/Views/Home/Index.cshtml** by using the [Url](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_Url) under [PivotViewDataSourceSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettingsBuilder.html) property.

```csharp
<ejs-pivotview id="PivotView" height="300" showFieldList="true">
    <e-datasourcesettings Url="https://localhost:44323/pivot" expandAll="false" enableSorting="true">
     //Other codes here...
    </e-datasourcesettings>
</ejs-pivotview>

```

**3.** Frame and set the report based on the data retrieved from the Elasticsearch database.

```csharp
<ejs-pivotview id="PivotView" height="300" showFieldList="true">
    <e-datasourcesettings Url="https://localhost:44323/pivot" expandAll="false" enableSorting="true">
        <e-formatsettings>
            <e-field name="Amount" format="C0"></e-field>
        </e-formatsettings>
        <e-rows>
            <e-field name="Country"></e-field>
            <e-field name="State"></e-field>
        </e-rows>
        <e-columns>
            <e-field name="Product"></e-field>
        </e-columns>
        <e-values>
            <e-field name="Quantity"></e-field>
            <e-field name="Amount" caption="Sold Amount"></e-field>
        </e-values>
    </e-datasourcesettings>
</ejs-pivotview>

```

When you run the sample, the resulting pivot table will look like this:

![PivotTable bound with Elasticsearch database](../images/elasticsearch-data-binding.png)

> Explore our ASP.NET Core Pivot Table sample and ASP.NET Core Web Application to extract data from a Elasticsearch database and bind to the Pivot Table in [this](https://github.com/SyncfusionExamples/how-to-bind-Elasticsearch-database-to-pivot-table) GitHub repository.