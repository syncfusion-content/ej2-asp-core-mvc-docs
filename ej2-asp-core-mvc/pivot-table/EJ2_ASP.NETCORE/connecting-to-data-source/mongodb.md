---
layout: post
title: MongoDB Data Binding in ASP.NET Core Pivot Table | Syncfusion
description: Learn how to bind MongoDB data to the ASP.NET Core Pivot Table using MongoDB.Driver and MongoDB.Bson in a Web API controller exposed as JSON.
platform: ej2-asp-core-mvc
documentation: ug
---

# MongoDB Data Binding in ASP.NET Core Pivot Table

This guide explains how to retrieve data from a MongoDB database using the [MongoDB Driver](https://www.nuget.org/packages/MongoDB.Driver) and [MongoDB Bson](https://www.nuget.org/packages/MongoDB.Bson) libraries and bind it to the Pivot Table through a Web API controller.

## Creating a Web API Service to Fetch MongoDB Data

Follow these steps to create a Web API service that retrieves data from a MongoDB database and prepares it for the Pivot Table.

### Step 1: Create an ASP.NET Core Web Application
1. Open Visual Studio and create a new **ASP.NET Core Web App** project named **MyWebService**. Select the **Web API** project template (for example, **ASP.NET Core Web API** in Visual Studio 2022) so the project is configured with controllers and Swagger by default.
2. Follow the official [Microsoft documentation](https://learn.microsoft.com/en-us/visualstudio/get-started/csharp/tutorial-aspnet-core?view=vs-2022) for detailed instructions on creating an ASP.NET Core Web application.
3. Before proceeding, ensure that a MongoDB Server instance is running locally (or reachable on the network) and that the `sample_training` database and `ProductDetails` collection exist with sample documents. The connection string and database/collection names used later in this walkthrough assume the example dataset from the [MongoDB sample databases](https://www.mongodb.com/docs/atlas/sample-data/).

![Create ASP.NET Core Web App project](../images/azure-asp-core-web-service-create.png)

### Step 2: Install the MongoDB NuGet Packages
To enable MongoDB database connectivity:
1. Open the **NuGet Package Manager** in your project solution and search for the packages [MongoDB.Driver](https://www.nuget.org/packages/MongoDB.Driver) and [MongoDB.Bson](https://www.nuget.org/packages/MongoDB.Bson).
2. Install both packages to add MongoDB support. Use `MongoDB.Driver` version 2.23.x (or later 2.x) and the matching `MongoDB.Bson` version to match this walkthrough; pin the version if you want reproducible builds.

![Add the NuGet package MongoDB.Driver to the project](../images/mongodb-data-nuget-package-install.png)

### Step 3: Create a Web API Controller
1. Under the **Controllers** folder, create a new Web API controller named **PivotController.cs**.
2. This controller facilitates data communication between the MongoDB database and the Pivot Table.

### Step 4: Connect to MongoDB and Retrieve Data
In the **PivotController.cs** file, use the [MongoDB.Driver](https://www.nuget.org/packages/MongoDB.Driver) and [MongoDB.Bson](https://www.nuget.org/packages/MongoDB.Bson) libraries to connect to a MongoDB database and retrieve data for the Pivot Table.

1. **Establish Connection**: Use **MongoClient** with a valid connection string (e.g., `<Enter your valid connection string here>`) to connect to the MongoDB database.
2. **Access the Database and Collection**: Use the **GetDatabase** method to access the specified database (e.g., `sample_training`) and the **GetCollection** method to target the desired collection (e.g., `ProductDetails`).
3. **Retrieve and Structure Data**: Use the **Find** method of the **IMongoCollection** interface with an empty **BsonDocument** to retrieve all documents from the collection. The **ToList** method then converts the retrieved data into a **List** for JSON serialization.

```csharp
    using Microsoft.AspNetCore.Mvc;
    using Newtonsoft.Json;
    using MongoDB.Driver;
    using MongoDB.Bson;

    namespace MyWebService.Controllers
    {
        [ApiController]
        [Route("[controller]")]
        public class PivotController : ControllerBase
        {
            private static List<ProductDetails> FetchMongoDbResult()
            {
                // Replace with your own connection string.
                string connectionString = "<Enter your valid connection string here>";
                MongoClient client = new MongoClient(connectionString);
                IMongoDatabase database = client.GetDatabase("sample_training");
                var collection = database.GetCollection<ProductDetails>("ProductDetails");
                return collection.Find(new BsonDocument()).ToList();
            }
            public class ProductDetails
            {
                public ObjectId Id { get; set; }
                public int Sold { get; set; }
                public double Amount { get; set; }
                public string? Country { get; set; }
                public string? Products { get; set; }
                public string? Year { get; set; }
                public string? Quarter { get; set; }
            }
        }
    }

```

### Step 5: Serialize Data to JSON
In the **PivotController.cs** file, define a **Get** method that calls **FetchMongoDbResult** to retrieve data from the MongoDB database as a **List**. Then, use **JsonConvert.SerializeObject** from the **Newtonsoft.Json** library to convert the **List** into JSON format. This JSON data will be used by the Pivot Table component.

> Ensure the `Newtonsoft.Json` NuGet package (version 13.x or later) is installed in your project before using `JsonConvert`. The `Get` method serializes the `List<ProductDetails>` into a JSON string before ASP.NET Core's pipeline returns it as the response body. Note: in the example below, the `BsonId` on `ProductDetails` is serialized using the default `Newtonsoft.Json` BSON converter that is registered automatically when `MongoDB.Bson` is referenced.


```csharp
    using Microsoft.AspNetCore.Mvc;
    using Newtonsoft.Json;
    using MongoDB.Bson;
    using MongoDB.Driver;

    namespace MyWebService.Controllers
    {
        [ApiController]
        [Route("[controller]")]
        public class PivotController : ControllerBase
        {
            [HttpGet(Name = "GetMongoDbResult")]
            public object Get()
            {
                return JsonConvert.SerializeObject(FetchMongoDbResult());
            }

            private static List<ProductDetails> FetchMongoDbResult()
            {
                // Replace with your own connection string.
                string connectionString = "<Enter your valid connection string here>";
                MongoClient client = new MongoClient(connectionString);
                IMongoDatabase database = client.GetDatabase("sample_training");
                var collection = database.GetCollection<ProductDetails>("ProductDetails");
                return collection.Find(new BsonDocument()).ToList();
            }
            public class ProductDetails
            {
                public ObjectId Id { get; set; }
                public int Sold { get; set; }
                public double Amount { get; set; }
                public string? Country { get; set; }
                public string? Products { get; set; }
                public string? Year { get; set; }
                public string? Quarter { get; set; }
            }
        }
    }

```

### Step 6: Run the Web API Service
1. In Visual Studio, set **MyWebService** as the startup project and press <kbd>F5</kbd> (or run `dotnet run` from the project folder). The actual listening ports are read from `launchSettings.json`; both HTTP and HTTPS endpoints are printed in the console.
2. The application is typically hosted at `https://localhost:44346/` (the port number may vary based on your configuration). Note the exact URL printed by the runtime so you can reference it from the ASP.NET Core project.

### Step 7: Access the JSON Data
1. Access the Web API endpoint at `https://localhost:44346/Pivot` to view the JSON data retrieved from the MongoDB database.
2. The browser displays the JSON data, as shown in the image below, ready for use by the Pivot Table.

![Hosted Web API URL](../images/mongodb-data.png)

## Connecting the Pivot Table to a MongoDB Database Using the Web API Service

This section explains how to connect the Pivot Table component to a MongoDB database by retrieving data from the Web API service created in the previous section. Ensure that the Web API service from the previous section is still running before proceeding.

### Step 1: Set up the ASP.NET Core Pivot Table
1. Set up a basic ASP.NET Core Pivot Table by following the [Getting Started](../getting-started) documentation.
2. Install the Syncfusion ASP.NET Core Tag Helper package by running `dotnet add package Syncfusion.EJ2.AspNet.Core` (the package is registered automatically and the `_ViewImports.cshtml` file is updated to import the Tag Helpers).
3. Register the Syncfusion license key in `Startup.cs` (or `Program.cs` for .NET 6+) as described in the Syncfusion [Getting Started](../getting-started) documentation.
4. Add the required EJ2 client-side references (for example, `ej2.min.js`, `ej2-pivotview.min.js`, and the matching theme CSS) in **~/Views/Shared/_Layout.cshtml** as described in the [Getting Started](../getting-started) documentation.

### Step 2: Configure the Web API URL in the Pivot Table
1. In the **~/Views/Home/Index.cshtml** file, map the Web API URL (`https://localhost:44346/Pivot`) to the Pivot Table using the [url](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_Url) property within the [e-datasourcesettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettingsBuilder.html).
2. Below is the sample code to configure the Pivot Table to fetch data from the Web API:

```csharp
<ejs-pivotview id="PivotView" height="300" showFieldList="true">
    <e-datasourcesettings Url="https://localhost:44346/pivot" expandAll="false" enableSorting="true">
     //Other codes here...
    </e-datasourcesettings>
</ejs-pivotview>

```

### Step 3: Define the Pivot Table Report
1. Configure the Pivot Table report in the **~/Views/Home/Index.cshtml** file to structure the data retrieved from the MongoDB database.
2. Add fields to the `rows`, `columns`, `values`, and `filters` properties of [e-datasourcesettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettingsBuilder.html) to define the report structure, specifying how data fields are organized and aggregated in the Pivot Table.
3. Enable the field list by setting the [showFieldList](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_ShowFieldList) property to **true** on the `PivotView` component (not on the data source settings) and including the `FieldList` module in the services section. This allows users to dynamically add or rearrange fields across the columns, rows, and values axes using an interactive user interface. Note: `enableSorting` is a property of the `PivotView` component; the sample above demonstrates the equivalent Tag Helper usage on the data source settings.

Here’s the updated sample code with the report configuration and field list support:

```csharp
<ejs-pivotview id="PivotView" height="300" showFieldList="true">
    <e-datasourcesettings Url="https://localhost:44346/Pivot" expandAll="false" enableSorting="true">
        <e-rows>
            <e-field name="Country"></e-field>
            <e-field name="Products"></e-field>
        </e-rows>
        <e-columns>
            <e-field name="Year"></e-field>
        </e-columns>
        <e-values>
            <e-field name="Sold" caption="Units Sold"></e-field>
            <e-field name="Amount" caption="Sold Amount"></e-field>
        </e-values>
    </e-datasourcesettings>
</ejs-pivotview>

```

### Step 4: Run and Verify the Pivot Table
1. Run the ASP.NET Core application.
2. The Pivot Table will display the data fetched from the MongoDB database via the Web API, structured according to the defined report.
3. The resulting Pivot Table will look like this:

![Pivot Table bound with MongoDB database](../images/mongodb-data-binding.png)

## Additional Resources
Explore a complete example of the ASP.NET Core Pivot Table integrated with an ASP.NET Core Web Application to fetch data from a MongoDB database in this [GitHub](https://github.com/SyncfusionExamples/web-how-to-bind-MongoDB-to-pivot-table) repository.