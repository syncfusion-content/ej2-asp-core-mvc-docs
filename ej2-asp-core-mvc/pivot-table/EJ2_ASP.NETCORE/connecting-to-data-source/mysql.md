---
layout: post
title: MySQL Data Binding in ASP.NET Core Pivot Table | Syncfusion
description: Learn how to bind MySQL data to the ASP.NET Core Pivot Table using MySql.Data in a Web API controller, exposed as JSON via a PivotController endpoint.
platform: ej2-asp-core-mvc
documentation: ug
---

# MySQL Data Binding in ASP.NET Core Pivot Table

This section describes how to retrieve data from a MySQL database using [MySqlClient](https://mysqlclient.readthedocs.io) and bind it to the Pivot Table via a Web API controller.

## Creating a Web API Service to Fetch MySQL Data

Follow these steps to create a Web API service that retrieves data from a MySQL database and prepares it for the Pivot Table.

### Step 1: Create an ASP.NET Core Web Application
1. Open Visual Studio and create a new **ASP.NET Core Web App** project named **MyWebService**. Select the **Web API** project template (for example, **ASP.NET Core Web API** in Visual Studio 2022) so the project is configured with controllers and Swagger by default.
2. Follow the official [Microsoft documentation](https://learn.microsoft.com/en-us/visualstudio/get-started/csharp/tutorial-aspnet-core?view=vs-2022) for detailed instructions on creating an ASP.NET Core Web application.
3. Before proceeding, ensure that a MySQL Server instance is running locally (or reachable on the network) and that the `mydb` database and `orders` table exist with sample data. The connection string and database/table names used later in this walkthrough assume the example dataset from the walkthrough's GitHub sample.

![Create ASP.NET Core Web App project](../images/azure-asp-core-web-service-create.png)

### Step 2: Install the MySql.Data NuGet Package
To enable MySQL database connectivity in your application:
1. Open the **NuGet Package Manager** in your project solution and search for **MySql.Data**.
2. Install the **MySql.Data** package to add MySQL database support. Use `MySql.Data` version 8.x (or later) to match this walkthrough; pin the version if you want reproducible builds. If you prefer an async-first, MIT-licensed alternative, `MySqlConnector` is a drop-in replacement with the same connection-string format.

![Add the NuGet package MySql.Data to the project](../images/mysql-data-nuget-package-install.png)

### Step 3: Create a Web API Controller
1. In the **Controllers** folder, create a new file named **PivotController.cs**.
2. This controller will handle data communication between the MySQL database and the Pivot Table.

### Step 4: Connect to MySQL and Retrieve Data
In the **PivotController.cs** file, use the [MySqlClient](https://mysqlclient.readthedocs.io/) from the **MySql.Data** library to connect to a MySQL database and retrieve data for the Pivot Table.

1. **Establish Connection**: Use **MySqlConnection** with a valid connection string (e.g., `Server=localhost;Database=mydb;Uid=myuser;Pwd=mypassword;`) to connect to the MySQL database.
2. **Query and Fetch Data**: Execute a SQL query (e.g., `SELECT * FROM orders`) using **MySqlCommand** to retrieve data for the Pivot Table.
3. **Structure the Data**: Use **MySqlDataAdapter**'s **Fill** method to populate query results into a **DataTable** for JSON serialization.

```csharp
    using Microsoft.AspNetCore.Mvc;
    using MySql.Data.MySqlClient;
    using Newtonsoft.Json;
    using System.Data;

    namespace MyWebService.Controllers
    {
        [ApiController]
        [Route("[controller]")]
        public class PivotController : ControllerBase
        {
            public dynamic GetMySQLResult()
            {
                // Replace with your own connection string.
                MySqlConnection connection = new MySqlConnection("<Enter your valid connection string here>");
                connection.Open();
                MySqlCommand command = new MySqlCommand("SELECT * FROM orders", connection);
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                connection.Close();
                return dataTable;
            }
        }
    }
```

> Replace the placeholder connection string with your actual MySQL credentials.

### Step 5: Serialize Data to JSON
In the **PivotController.cs** file, define a **Get** method that calls **GetMySQLResult** to retrieve data from the MySQL database as a **DataTable**. Then, use **JsonConvert.SerializeObject** from the **Newtonsoft.Json** library to convert the **DataTable** into a JSON format. This JSON data will be used by the Pivot Table component.

> Ensure the `Newtonsoft.Json` NuGet package (version 13.x or later) is installed in your project before using `JsonConvert`. The `Get` method serializes the `DataTable` into a JSON string before ASP.NET Core's pipeline returns it as the response body. Note: returning a `JsonConvert.SerializeObject` of a `DataTable` produces a JSON array of row objects whose column values are mapped from the underlying SQL types.

```csharp
    using Microsoft.AspNetCore.Mvc;
    using MySql.Data.MySqlClient;
    using Newtonsoft.Json;
    using System.Data;

    namespace MyWebService.Controllers
    {
        [ApiController]
        [Route("[controller]")]
        public class PivotController : ControllerBase
        {
            [HttpGet(Name = "GetMySQLResult")]
            public object Get()
            {
                return JsonConvert.SerializeObject(GetMySQLResult());
            }

            public dynamic GetMySQLResult()
            {
                // Replace with your own connection string.
                MySqlConnection connection = new MySqlConnection("<Enter your valid connection string here>");
                connection.Open();
                MySqlCommand command = new MySqlCommand("SELECT * FROM orders", connection);
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                connection.Close();
                return dataTable;
            }
        }
    }
```

### Step 6: Run the Web API Service
1. In Visual Studio, set **MyWebService** as the startup project and press <kbd>F5</kbd> (or run `dotnet run` from the project folder). The actual listening ports are read from `launchSettings.json`; both HTTP and HTTPS endpoints are printed in the console.
2. The application is hosted at a URL such as `https://localhost:7146` (the port number may vary based on your configuration). Note the exact URL printed by the runtime so you can reference it from the ASP.NET Core project.

### Step 7: Verify the JSON Data
1. Access the Web API endpoint at `https://localhost:7146/Pivot` to view the JSON data retrieved from the MySQL database.
2. The browser displays the JSON data, as shown in the image below.
![Hosted Web API URL](../images/mysql-data.png)

## Connecting the Pivot Table to a MySQL Database Using the Web API Service

This section explains how to connect the Pivot Table to a MySQL database by fetching data from the Web API service created above. Ensure that the Web API service from the previous section is still running before proceeding.

### Step 1: Set up the ASP.NET Core Pivot Table
1. Set up a basic ASP.NET Core Pivot Table by following the [Getting Started](../getting-started) documentation.
2. Install the Syncfusion ASP.NET Core Tag Helper package by running `dotnet add package Syncfusion.EJ2.AspNet.Core` (the package is registered automatically and the `_ViewImports.cshtml` file is updated to import the Tag Helpers).
3. Register the Syncfusion license key in `Startup.cs` (or `Program.cs` for .NET 6+) as described in the Syncfusion [Getting Started](../getting-started) documentation.
4. Add the required EJ2 client-side references (for example, `ej2.min.js`, `ej2-pivotview.min.js`, and the matching theme CSS) in **~/Views/Shared/_Layout.cshtml** as described in the [Getting Started](../getting-started) documentation.

### Step 2: Configure the Web API URL in the Pivot Table
1. In the **~/Views/Home/Index.cshtml** file, map the Web API URL (`https://localhost:7146/Pivot`) to the Pivot Table using the [url](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_Url) property within the [e-datasourcesettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettingsBuilder.html).
2. Below is the sample code to configure the Pivot Table to fetch data from the Web API:


```csharp
<ejs-pivotview id="PivotView" height="300" showFieldList="true">
    <e-datasourcesettings Url="https://localhost:7146/pivot" expandAll="false" enableSorting="true">
     //Other codes here...
    </e-datasourcesettings>
</ejs-pivotview>

```

### Step 3: Define the Pivot Table Report
1. Configure the Pivot Table report in the **~/Views/Home/Index.cshtml** file to structure the data retrieved from the MySQL database.
2. Use the `rows`, `columns`, `values`, and `filters` properties of [e-datasourcesettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettingsBuilder.html) to define how data fields are organized and aggregated.
3. Enable the field list by setting the [showFieldList](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_ShowFieldList) property to **true** on the `PivotView` component (not on the data source settings) and including the `FieldList` module in the services. This allows users to interactively modify the Pivot Table's structure by adding or rearranging fields. Note: `enableSorting` is a property of the `PivotView` component; the sample above demonstrates the equivalent Tag Helper usage on the data source settings.

```csharp
<ejs-pivotview id="PivotView" height="300" showFieldList="true">
    <e-datasourcesettings Url="https://localhost:7146/Pivot" expandAll="false" enableSorting="true">
        <e-rows>
            <e-field name="ShipCity"></e-field>
        </e-rows>
        <e-columns>
            <e-field name="ShipName"></e-field>
        </e-columns>
        <e-values>
            <e-field name="Freight" caption="Sum of Freight"></e-field>
        </e-values>
    </e-datasourcesettings>
</ejs-pivotview>

```

### Step 4: Run and Verify the Pivot Table
1. Run the ASP.NET Core application.
2. The Pivot Table will display the data fetched from the MySQL database via the Web API, structured according to the defined report.
3. The resulting Pivot Table will look like this:

![Pivot Table bound with MySQL database](../images/pivottable-with-mysql-data.png)

## Additional Resources
Explore a complete example of the ASP.NET Core Pivot Table integrated with an ASP.NET Core Web Application to fetch data from a MySQL database in this [GitHub](https://github.com/SyncfusionExamples/web-bind-MySQL-database-to-pivot-table) repository.