---
layout: post
title: PostgreSQL Data Binding in ASP.NET Core Pivot Table | Syncfusion
platform: ej2-asp-core-mvc
control: PostgreSQL Data Binding
description: Learn how to bind PostgreSQL data to the ASP.NET Core Pivot Table using the Npgsql.EntityFrameworkCore.PostgreSQL provider in a Web API controller.
publishingplatform: ##Platform_Name##
documentation: ug
---

# PostgreSQL Data Binding in ASP.NET Core Pivot Table

This section describes how to consume data from PostgreSQL database using [Microsoft Npgsql](https://www.npgsql.org/doc/index.html) and bind it to the Pivot Table via a Web API controller.

## Creating a Web API Service to Fetch PostgreSQL Data

Follow these steps to create a Web API service that retrieves data from a PostgreSQL database and prepares it for the Pivot Table.

### Step 1: Create an ASP.NET Core Web Application
1. Open Visual Studio and create a new **ASP.NET Core Web App** project named **MyWebService**. Select the **Web API** project template (for example, **ASP.NET Core Web API** in Visual Studio 2022) so the project is configured with controllers and Swagger by default.
2. Follow the official [Microsoft documentation](https://learn.microsoft.com/en-us/visualstudio/get-started/csharp/tutorial-aspnet-core?view=vs-2022) for detailed instructions on creating an ASP.NET Core Web application.
3. Before proceeding, ensure that a PostgreSQL Server instance is running locally (or reachable on the network) and that the `mydb` database and `tablename` table exist with sample data. The connection string and table name used later in this walkthrough assume the example dataset from the walkthrough's GitHub sample.

![Creating an ASP.NET Core Web App project](../images/azure-asp-core-web-service-create.png)

### Step 2: Install the PostgreSQL NuGet Package
To enable PostgreSQL database connectivity, install the raw ADO.NET provider used by the controller code in this walkthrough:
1. Open the **NuGet Package Manager** in your project solution and search for **Npgsql** (the raw ADO.NET provider for PostgreSQL).
2. Install the **Npgsql** package to add PostgreSQL support. Use `Npgsql` version 8.x (or later) to match this walkthrough; pin the version if you want reproducible builds.

![Installing the Npgsql.EntityFrameworkCore.PostgreSQL NuGet package](../images/postgresql-data-nuget-package-install.png)

### Step 3: Create a Web API Controller
1. Under the **Controllers** folder, create a new Web API controller named **PivotController.cs**.
2. This controller facilitates data communication between the PostgreSQL database and the Pivot Table.

### Step 4: Connect to PostgreSQL and Retrieve Data
In the **PivotController.cs** file, use the [Npgsql](https://www.npgsql.org/doc/index.html) library to connect to a PostgreSQL database and retrieve data for the Pivot Table.

1. **Establish Connection**: Use **NpgsqlConnection** with a valid connection string (e.g., `Server=localhost;Database=mydb;User Id=myuser;Password=mypassword;`) to connect to the PostgreSQL database. For production, register `NpgsqlDataSource` (or a connection factory) as a singleton in the application's dependency-injection container rather than opening a new connection per request, and use `using` blocks to deterministically dispose connections, commands, and adapters.
2. **Query and Fetch Data**: Execute a SQL query (e.g., `SELECT * FROM tablename`) using **NpgsqlCommand** to retrieve data for the Pivot Table.
3. **Structure the Data**: Use **NpgsqlDataAdapter**'s **Fill** method to populate query results into a **DataTable** for JSON serialization.

```csharp
    using Microsoft.AspNetCore.Mvc;
    using Newtonsoft.Json;
    using System.Data;
    using Npgsql;

    namespace MyWebService.Controllers
    {
        [ApiController]
        [Route("[controller]")]
        public class PivotController : ControllerBase
        {
            public dynamic GetPostgreSQLResult()
            {
                // Replace with your own connection string.
                NpgsqlConnection connection = new NpgsqlConnection("<Enter your valid connection string here>");
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM tablename", connection);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                connection.Close();
                return dt;
            }
        }
    }

```

### Step 5: Serialize Data to JSON
In the **PivotController.cs** file, define a **Get** method that calls **GetPostgreSQLResult** to retrieve data from the PostgreSQL database as a **DataTable**. Then, use **JsonConvert.SerializeObject** from the **Newtonsoft.Json** library to convert the **DataTable** into JSON format. This JSON data will be used by the Pivot Table component.

> Ensure the `Newtonsoft.Json` NuGet package (version 13.x or later) is installed in your project before using `JsonConvert`.

```csharp
    using Microsoft.AspNetCore.Mvc;
    using Newtonsoft.Json;
    using System.Data;
    using Npgsql;

    namespace MyWebService.Controllers
    {
        [ApiController]
        [Route("[controller]")]
        public class PivotController : ControllerBase
        {
            [HttpGet(Name = "GetPostgreSQLResult")]
            public object Get()
            {
                return JsonConvert.SerializeObject(GetPostgreSQLResult());
            }

            public dynamic GetPostgreSQLResult()
            {
                // Replace with your own connection string.
                NpgsqlConnection connection = new NpgsqlConnection("<Enter your valid connection string here>");
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM tablename", connection);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                connection.Close();
                return dt;
            }
        }
    }

```


### Step 6: Run the Web API Service
1. In Visual Studio, set **MyWebService** as the startup project and press <kbd>F5</kbd> (or run `dotnet run` from the project folder). The actual listening ports are read from `launchSettings.json`; both HTTP and HTTPS endpoints are printed in the console.
2. The application will be hosted at `https://localhost:44378/` (the port number may vary based on your configuration). Note the exact URL printed by the runtime so you can reference it from the ASP.NET Core project.

### Step 7: Access the JSON Data
1. Access the Web API endpoint at `https://localhost:44378/Pivot` to view the JSON data retrieved from the PostgreSQL database.
2. The browser displays the JSON data, as shown in the image below, ready for use by the Pivot Table. A sample response has the following shape:

```json
[
  { "servicetype": "General Practice", "servicecategory": "Consultation", "openinghours_practice": "08:00", "closinghours_practice": "17:00", "revenue": 1200.50 },
  { "servicetype": "Specialist",       "servicecategory": "Surgery",       "openinghours_practice": "09:00", "closinghours_practice": "18:00", "revenue": 4500.75 }
]
```

> Because the API and the ASP.NET Core app run on different origins (for example, `https://localhost:44378` and `https://localhost:44300`), the Web API project must allow cross-origin requests from the Core origin. Add CORS services in the API's `Program.cs` (for example, `builder.Services.AddCors(...)` with `WithOrigins("https://localhost:44300")`) and call `app.UseCors(...)` before `MapControllers()`.

![JSON data from the Web API endpoint](../images/postgresql_data.png)

## Connecting the Pivot Table to a PostgreSQL Database Using the Web API Service

This section explains how to connect the Pivot Table component to a PostgreSQL database by retrieving data from the Web API service created in the previous section. Ensure that the Web API service from the previous section is still running before proceeding.

### Step 1: Set up the ASP.NET Core Pivot Table
1. Set up a basic ASP.NET Core Pivot Table by following the [Getting Started](../getting-started) documentation.
2. Install the Syncfusion ASP.NET Core Tag Helper package by running `dotnet add package Syncfusion.EJ2.AspNet.Core` (the package is registered automatically and the `_ViewImports.cshtml` file is updated to import the Tag Helpers).
3. Register the Syncfusion license key in `Startup.cs` (or `Program.cs` for .NET 6+) as described in the Syncfusion [Getting Started](../getting-started) documentation.
4. Add the required EJ2 client-side references (for example, `ej2.min.js`, `ej2-pivotview.min.js`, and the matching theme CSS) in **~/Views/Shared/_Layout.cshtml** as described in the [Getting Started](../getting-started) documentation.

### Step 2: Configure the Web API URL in the Pivot Table
1. In the **~/Views/Home/Index.cshtml** file, map the Web API URL (`https://localhost:44378/Pivot`) to the Pivot Table using the [url](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_Url) property within the [e-datasourcesettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettingsBuilder.html).
2. Below is the sample code to configure the Pivot Table to fetch data from the Web API:

```csharp
<ejs-pivotview id="PivotView" height="300" showFieldList="true">
    <e-datasourcesettings Url="https://localhost:44378/Pivot" expandAll="false" enableSorting="true">
     //Other codes here...
    </e-datasourcesettings>
</ejs-pivotview>

```

### Step 3: Define the Pivot Table Report
1. Configure the Pivot Table report in the **~/Views/Home/Index.cshtml** file to structure the data retrieved from the PostgreSQL database.
2. Add fields to the `rows`, `columns`, `values`, and `filters` properties of [e-datasourcesettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettingsBuilder.html) to define the report structure, specifying how data fields are organized and aggregated in the Pivot Table.
3. Enable the field list by setting the [showFieldList](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_ShowFieldList) property to **true** on the `PivotView` component (not on the data source settings) and including the `FieldList` module in the services section. This allows users to dynamically add or rearrange fields across the columns, rows, and values axes using an interactive user interface. Note: `enableSorting` is a property of the `PivotView` component; the sample above demonstrates the equivalent Tag Helper usage on the data source settings.

Here’s the updated sample code for **~/Views/Home/Index.cshtml** with the report configuration and field list support:

```csharp
<ejs-pivotview id="PivotView" height="300" showFieldList="true">
    <e-datasourcesettings Url="https://localhost:44378/Pivot" expandAll="false" enableSorting="true">
        <e-rows>
            <e-field name="servicetype"></e-field>
            <e-field name="servicecategory"></e-field>
        </e-rows>
        <e-columns>
            <e-field name="openinghours_practice"></e-field>
            <e-field name="closinghours_practice"></e-field>
        </e-columns>
        <e-values>
            <e-field name="revenue"></e-field>
        </e-values>
    </e-datasourcesettings>
</ejs-pivotview>

```

### Step 4: Run and Verify the Pivot Table
1. Run the ASP.NET Core application.
2. The Pivot Table will display the data fetched from the PostgreSQL database via the Web API, structured according to the defined report.
3. The resulting Pivot Table will look like this:

![Pivot Table bound with PostgreSQL database](../images/postgresql-data-binding.png)

## Additional Resources
Explore a complete example of the ASP.NET Core Pivot Table integrated with an ASP.NET Core Web Application to fetch data from a PostgreSQL database in this [GitHub](https://github.com/SyncfusionExamples/web-bind-PostgreSQL-database-to-pivot-table) repository.