---
layout: post
title: Bind SQLite Server Data in Syncfusion ##Platform_Name## Grid
description: Learn how to consume data from SQLite Server, bind it to Syncfusion ##Platform_Name## Grid, and perform CRUD operations.
control: grid
platform: ej2-asp-core-mvc
documentation: ug
domainurl: ##DomainURL##
---

# Connecting SQLite Server data to Syncfusion ASP.NET MVC  Grid

This section describes how to connect and retrieve data from a SQLite Server database using [Microsoft.Data.Sqlite](https://www.nuget.org/packages/Microsoft.Data.Sqlite/) and bind it to the Syncfusion ASP.NET MVC  Grid.

SQLite Server database can be bound to the Grid in different ways (i.e.) using [DataSource](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_DataSource) property, custom adaptor and remote data binding using various adaptors. In this documentation, two approaches will be examined to connect a SQLite Server database to a Grid. Both the approaches have capability to handle data and CRUD operations with built-in methods as well as can be customized as per your own.

**1. Using UrlAdaptor**

The [UrlAdaptor](https://ej2.syncfusion.com/aspnetmvc/documentation/grid/connecting-to-adaptors/url-adaptor) serves as the base adaptor for facilitating communication between remote data services and an UI component. It enables the remote binding of data to the Syncfusion ASP.NET MVC Grid by connecting to an existing pre-configured API service linked to the Microsoft SQL Server database. While the Grid supports various adaptors to fulfill this requirement, including [Web API](https://ej2.syncfusion.com/aspnetmvc/documentation/grid/connecting-to-adaptors/web-api-adaptor), [ODataV4](https://ej2.syncfusion.com/aspnetmvc/documentation/grid/connecting-to-adaptors/odatav4-adaptor), [UrlAdaptor](https://ej2.syncfusion.com/aspnetmvc/documentation/grid/connecting-to-adaptors/url-adaptor), [Web Method](https://ej2.syncfusion.com/aspnetmvc/documentation/grid/connecting-to-adaptors/web-method-adaptor), and `GraphQL`, the `UrlAdaptor` is particularly useful for the scenarios where a custom API service with unique logic for handling data and CRUD operations is in place. This approach allows for custom handling of data and CRUD operations, and the resultant data returned in the `result` and `count` format for display in the Grid.

**2. Using CustomAdaptor**

The [CustomAdaptor](https://ej2.syncfusion.com/aspnetmvc/documentation/grid/connecting-to-adaptors/custom-adaptor) serves as a mediator between the UI component and the database for data binding. While the data source from the database can be directly bound to the Syncfusion ASP.NET MVC Grid locally using the `DataSource` property, the `CustomAdaptor` approach is preferred as it allows for customization of both data operations and CRUD operations according to specific requirements. In this approach, for every action in the Grid, a corresponding request with action details is sent to the `CustomAdaptor`. The Grid provides predefined methods to perform data operations such as **searching**, **filtering**, **sorting**, **aggregation**, **paging** and **grouping**. Alternatively, your own custom methods can be employed to execute operations and return the data in the `result` and `count` format for displaying in the Grid. Additionally, for CRUD operations, predefined methods can be overridden to provide custom functionality. Further details on this can be found in the latter part of the documentation.

## Binding data from SQLite Server using an API service

This section describes step by step process how to retrieve data from a SQLite Server using an API service and bind it to the Grid.

### Creating an API service

**1.** Open Visual Studio and create an ASP.NET MVC project named **Grid_SQLite**. To create an ASP.NET MVC application, follow the documentation [link](https://learn.microsoft.com/en-us/aspnet/mvc/overview/getting-started/introduction/getting-started#create-your-first-app) for detailed steps.

**2.** To connect a SQLite Server database using the SQLite driver in your application, you need to install the [Microsoft.Data.Sqlite](https://www.nuget.org/packages/Microsoft.Data.Sqlite/) NuGet package. To add **Microsoft.Data.Sqlite** in the app, open the NuGet package manager in Visual Studio (Tools → NuGet Package Manager → Manage NuGet Packages for Solution), search and install it.

**3.** Create an API controller (aka, GridController.cs) file under **Controllers** folder that helps to establish data communication with the Grid.

**4.** In an API controller (aka, GridController), connect to SQLite Server. In the **GetOrderData()** method **SqliteConnection** helps to connect the SQLite Server database. Next, the **SqliteCommand** is used to retrieve the desired collection from the database. Then populate the data collection from the **SqliteCommand** into a list using the **Read** method of **SqliteDataReader** as shown in the following code snippet.

{% tabs %}
{% highlight cs tabtitle="GridController.cs" %}

using Microsoft.Data.Sqlite;
using Syncfusion.EJ2.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web.Mvc;

namespace Grid_Sqlite.Controllers
{
  public class GridController : Controller
    {
        private readonly string ConnectionString = "<Enter a valid connection string>";

        /// <summary>
        /// Processes the DataManager request to perform searching, filtering, sorting, and paging operations.
        /// </summary>
        /// <param name="DataManagerRequest">Contains the details of the data operation requested.</param>
        /// <returns>Returns a JSON object along with the total record count.</returns>
        [HttpPost]
        public object UrlDataSource()
        {
            // Retrieve data from the database.
            IQueryable<Orders> dataSource = GetOrderData().AsQueryable();

            // Get the total count of records.
            int totalRecordsCount = dataSource.Count();

            // Return the data and total record count as a JSON response.
            return Ok(new { result = dataSource, count = totalRecordsCount });
        }

        /// <summary>
        /// Retrieves the order data from the database.
        /// </summary>
        /// <returns>Returns a list of orders fetched from the database.</returns>
        [HttpGet]
        public List<Orders> GetOrderData()
        {
            // SQL query to fetch all records from the Orders table and sort them by OrderID.
            string queryStr = "SELECT * FROM Orders ORDER BY OrderID.";

            // Create a list to store retrieved orders from the database.
            List<Orders> dataSource = new List<Orders>();

            // Establish a connection to the SQLite database using the provided connection string.
            using (SqliteConnection connection = new SqliteConnection(ConnectionString))
            {
                // Open the database connection to enable SQL queries.
                connection.Open();

                // Create a command to execute the SQL query.
                using (SqliteCommand command = new SqliteCommand(queryStr, connection))
                {
                    // Execute the command and retrieve data using SqliteDataReader.
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Orders order = new Orders
                            {
                                OrderID = reader.GetInt32(reader.GetOrdinal("OrderID")),
                                CustomerID = reader.GetString(reader.GetOrdinal("CustomerID")),
                                EmployeeID = reader.GetInt32(reader.GetOrdinal("EmployeeID")),
                                ShipCity = reader.GetString(reader.GetOrdinal("ShipCity")),
                                Freight = reader.GetDecimal(reader.GetOrdinal("Freight"))
                            };
                            dataSource.Add(order);
                        }
                    }
                }
            }
            return dataSource;
        }

        /// Represents an order entity with relevant fields.
        public class Orders
        {
            [Key]
            public int? OrderID { get; set; }
            public string? CustomerID { get; set; }
            public int? EmployeeID { get; set; }
            public decimal? Freight { get; set; }
            public string? ShipCity { get; set; }
        }
    }
}

{% endhighlight %}
{% endtabs %}

**5.** Run the application and it will be hosted within the URL `https://localhost:xxxx`.

**6.** Finally, the retrieved data from SQLite Server database which is in the form of list can be found in an API controller available in the URL link `https://localhost:xxxx/Grid/UrlDataSource`, as shown in the browser page below.

![Hosted API URL](../images/database/db-data.png)

### Connecting Syncfusion ASP.NET MVC Grid to an API Service

To integrate the Syncfusion Grid into your ASP.NET MVC project using Visual Studio, follow these steps:

**Step 1:** Install the Syncfusion ASP.NET MVC Package:

To add `ASP.NET MVC` in the application, open the NuGet package manager in Visual Studio (Tools → NuGet Package Manager → Manage NuGet Packages for Solution), search for [Syncfusion.EJ2.MVC5](https://www.nuget.org/packages/Syncfusion.EJ2.MVC5) and install it.
Alternatively, you can install it using the following Package Manager Console command:

{% tabs %}
{% highlight C# tabtitle="Package Manager" %}

Install-Package Syncfusion.EJ2.MVC5 -Version {{ site.releaseversion }}

{% endhighlight %}
{% endtabs %}

**Step 2:** Add Syncfusion ASP.NET MVC namespace

Add `Syncfusion.EJ2` namespace reference in `Web.config` under `Views` folder.

```cs
<namespaces>
    <add namespace="Syncfusion.EJ2"/>
</namespaces>
```

**Step 3:** Add stylesheet and script resources

To include the required styles and scripts, add the following references inside the `<head>` of `~/Pages/Shared/_Layout.cshtml` file:
{% tabs %}
{% highlight cshtml tabtitle="~/_Layout.cshtml" %}

<head>
    ...
    <!-- Syncfusion ASP.NET MVC control styles -->
    <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/bootstrap5.css" />
    <!-- Syncfusion ASP.NET MVC control scripts -->
    <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/dist/ej2.min.js"></script>
    <!-- Include the necessary CSS files to style the Syncfusion ASP.NET MVC controls: -->
    <link href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/styles/bootstrap5.css" rel="stylesheet" />
    <link href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-grids/styles/bootstrap5.css" rel="stylesheet" />
    <link href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-buttons/styles/bootstrap5.css" rel="stylesheet" />
    <link href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-popups/styles/bootstrap5.css" rel="stylesheet" />
    <link href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-richtexteditor/styles/bootstrap5.css" rel="stylesheet" />
    <link href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-navigations/styles/bootstrap5.css" rel="stylesheet" />
    <link href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-dropdowns/styles/bootstrap5.css" rel="stylesheet" />
    <link href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-lists/styles/bootstrap5.css" rel="stylesheet" />
    <link href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-inputs/styles/bootstrap5.css" rel="stylesheet" />
    <link href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-calendars/styles/bootstrap5.css" rel="stylesheet" />
    <link href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-notifications/styles/bootstrap5.css" rel="stylesheet" />
    <link href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-splitbuttons/styles/bootstrap5.css" rel="stylesheet" />
    <script src="https://cdnjs.cloudflare.com/ajax/libs/systemjs/0.19.38/system.js"></script>
    <script src="https://cdn.syncfusion.com/ej2/syncfusion-helper.js" type="text/javascript"></script>
</head>

{% endhighlight %}
{% endtabs %}

**Step 4:** Register Syncfusion Script Manager

To ensure proper script execution, register the Syncfusion Script Manager `EJS().ScriptManager()` at the end of `<body>` in the `~/Pages/Shared/_Layout.cshtml` file as follows.

{% tabs %}
{% highlight cshtml tabtitle="~/_Layout.cshtml" %}

<body>
...
    <!-- Syncfusion ASP.NET MVC Script Manager -->
    @Html.EJS().ScriptManager()
</body>

{% endhighlight %}
{% endtabs %}

**Step 5:** Add the Syncfusion ASP.NET MVC Grid

Now, add the Syncfusion ASP.NET MVC Grid tag helper in `~/Views/Home/Index.cshtml` file. This allows the Grid to be rendered and interact with data dynamically from a remote database.

* Create a `DataManager` instance specifying the URL of your API endpoint(https:localhost:xxxx/Grid/UrlDataSource) using the `url` property and set the `adaptor` UrlAdaptor.

* The `DataManager` offers multiple adaptor options to connect with remote database based on an API service. Below is an example of the `UrlAdaptor` configuration where an API service are set up to return the resulting data in the `result` and `count` format.

* The `UrlAdaptor` acts as the base adaptor for interacting with remote data service. Most of the built-in adaptors are derived from the `UrlAdaptor`.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}

// Replace `xxxx` with your actual port number
@Html.EJS().Grid("Grid").DataSource(ds => ds.Url("https://localhost:xxxx/Grid/UrlDataSource").Adaptor("UrlAdaptor")).Columns(col =>
{
  col.Field("OrderID").HeaderText("Order ID").Width("100").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).Add();
  col.Field("CustomerID").HeaderText("Customer Name").Width("100").Add();
  col.Field("EmployeeID").HeaderText("Employee ID").Width("100").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).Add();
  col.Field("Freight").HeaderText("Freight").Width("100").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).Format("C2").Add();
  col.Field("ShipCity").HeaderText("Ship City").Width("120").Add();
}).Render()

{% endhighlight %}

{% highlight cs tabtitle="GridController.cs" %}

using Microsoft.Data.Sqlite;
using Syncfusion.EJ2.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web.Mvc;

namespace Grid_Sqlite.Controllers
{
  public class GridController : Controller
    {
        private readonly string ConnectionString = "<Enter a valid connection string>";

        /// <summary>
        /// Processes the DataManager request to perform searching, filtering, sorting, and paging operations.
        /// </summary>
        /// <param name="DataManagerRequest">Contains the details of the data operation requested.</param>
        /// <returns>Returns a JSON object along with the total record count.</returns>
        [HttpPost]
        public object UrlDataSource()
        {
            // Retrieve data from the database.
            IQueryable<Orders> dataSource = GetOrderData().AsQueryable();

            // Get the total count of records.
            int totalRecordsCount = dataSource.Count();

            // Return the data and total record count as a JSON response.
            return Ok(new { result = dataSource, count = totalRecordsCount });
        }

        /// <summary>
        /// Retrieves the order data from the database.
        /// </summary>
        /// <returns>Returns a list of orders fetched from the database.</returns>
        [HttpGet]
        public List<Orders> GetOrderData()
        {
            // SQL query to fetch all records from the Orders table and sort them by OrderID.
            string queryStr = "SELECT * FROM Orders ORDER BY OrderID.";

            // Create a list to store retrieved orders from the database.
            List<Orders> dataSource = new List<Orders>();

            // Establish a connection to the SQLite database using the provided connection string.
            using (SqliteConnection connection = new SqliteConnection(ConnectionString))
            {
                // Open the database connection to enable SQL queries.
                connection.Open();

                // Create a command to execute the SQL query.
                using (SqliteCommand command = new SqliteCommand(queryStr, connection))
                {
                    // Execute the command and retrieve data using SqliteDataReader.
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Orders order = new Orders
                            {
                                OrderID = reader.GetInt32(reader.GetOrdinal("OrderID")),
                                CustomerID = reader.GetString(reader.GetOrdinal("CustomerID")),
                                EmployeeID = reader.GetInt32(reader.GetOrdinal("EmployeeID")),
                                ShipCity = reader.GetString(reader.GetOrdinal("ShipCity")),
                                Freight = reader.GetDecimal(reader.GetOrdinal("Freight"))
                            };
                            dataSource.Add(order);
                        }
                    }
                }
            }
            return dataSource;
        }

        /// Represents an order entity with relevant fields.
        public class Orders
        {
            [Key]
            public int? OrderID { get; set; }
            public string? CustomerID { get; set; }
            public int? EmployeeID { get; set; }
            public decimal? Freight { get; set; }
            public string? ShipCity { get; set; }
        }
    }
}

{% endhighlight %}
{% endtabs %}

**Step 7:** Run the Project

Run the project in Visual Studio, and the Syncfusion ASP.NET MVC Grid will successfully fetch data from the API service.

> * The Syncfusion ASP.NET MVC Grid provides built-in support for handling various data operations such as searching, sorting, filtering, aggregate and paging on the server-side. These operations can be handled using methods such as `PerformSearching`, `PerformFiltering`, `PerformSorting`, `PerformTake` and `PerformSkip` available in the [Syncfusion.EJ2.MVC5](https://www.nuget.org/packages/Syncfusion.EJ2.MVC5) package. Let’s explore how to manage these data operations using the `UrlAdaptor`.
> * In an API service project, add `Syncfusion.EJ2.MVC5` by opening the NuGet package manager in Visual Studio (Tools → NuGet Package Manager → Manage NuGet Packages for Solution), search and install it.
> * To access `DataManagerRequest`, import [Syncfusion.EJ2.Base](https://www.npmjs.com/package/@syncfusion/ej2-base) in `GridController.cs` file.

### Handling searching operation

To handle searching operation, ensure that your API endpoint supports custom searching criteria. Implement the searching logic on the server-side using the `PerformSearching` method from the `QueryableOperation` class. This allows the custom data source to undergo searching based on the criteria specified in the incoming `DataManagerRequest` object.

{% tabs %}
{% highlight cs tabtitle="GridController.cs" %}

/// <summary>
/// Processes the DataManager request to perform searching operation.
/// </summary>
/// <param name="DataManagerRequest">Contains the details of the data operation requested.</param>
/// <returns>Returns a JSON object with the searched data along with the total record count.</returns>
public JsonResult UrlDataSource(DataManagerRequest DataManagerRequest)
{
  // Retrieve data from the data source (e.g., database).
  IQueryable<Orders> dataSource = GetOrderData().AsQueryable();

  // Initialize QueryableOperation instance.
  QueryableOperation queryableOperation = new QueryableOperation();

  // Handling searching operation.
  if (DataManagerRequest.Search?.Count > 0)
  {
    dataSource = queryableOperation.PerformSearching(dataSource, DataManagerRequest.Search);
    //Add custom logic here if needed and remove above method.
  }

  // Get the total count of records.
  int totalRecordsCount = DataSource.Count();

  // Return data based on the request.
  return Json(new { result = dataSource, count = totalRecordsCount }, JsonRequestBehavior.AllowGet);
}

{% endhighlight %}

{% highlight cshtml tabtitle="Index.cshtml" %}

// Replace `xxxx` with your actual localhost port number.
@Html.EJS().Grid("Grid").DataSource(ds => ds.Url("https://localhost:xxxx/Grid/UrlDatasource").Adaptor("UrlAdaptor")).Columns(col =>
{
  col.Field("OrderID").HeaderText("Order ID").Width("100").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).Add();
  col.Field("CustomerID").HeaderText("Customer Name").Width("100").Add();
  col.Field("EmployeeID").HeaderText("Employee ID").Width("100").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).Add();
  col.Field("Freight").HeaderText("Freight").Width("100").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).Format("C2").Add();
  col.Field("ShipCity").HeaderText("Ship City").Width("120").Add();
}).Toolbar(new List<string>() { "Search" }).Render()

{% endhighlight %}
{% endtabs %}

### Handling filtering operation

To handle filtering operation, ensure that your API endpoint supports custom filtering criteria. Implement the filtering logic on the server-side using the `PerformFiltering` method from the `QueryableOperation` class. This allows the custom data source to undergo filtering based on the criteria specified in the incoming `DataManagerRequest` object.

{% tabs %}
{% highlight cs tabtitle="GridController.cs" %}

/// <summary>
/// Processes the DataManager request to perform filtering operation.
/// </summary>
/// <param name="DataManagerRequest">Contains the details of the data operation requested.</param>
/// <returns>Returns a JSON object with the filtered data along with the total record count.</returns>
public JsonResult UrlDataSource(DataManagerRequest DataManagerRequest)
{
  // Retrieve data from the data source (e.g., database).
  IQueryable<Orders> dataSource = GetOrderData().AsQueryable();

  // Initialize QueryableOperation instance.
  QueryableOperation queryableOperation = new QueryableOperation();

  // Handling filtering operation.
  if (DataManagerRequest.Where?.Count > 0)
  {
    foreach (WhereFilter condition in DataManagerRequest.Where)
    {
      foreach (WhereFilter predicate in condition.predicates)
      {
        dataSource = queryableOperation.PerformFiltering(dataSource, DataManagerRequest.Where, predicate.Operator);
        //Add custom logic here if needed and remove above method.
      }
    }
  }

  // Get the total count of records.
  int totalRecordsCount = DataSource.Count();  

  // Return data based on the request.
  return Json(new { result = dataSource, count = totalRecordsCount }, JsonRequestBehavior.AllowGet);
}

{% endhighlight %}

{% highlight cshtml tabtitle="Index.cshtml" %}

// Replace `xxxx` with your actual localhost port number.
@Html.EJS().Grid("Grid").DataSource(ds => ds.Url("https://localhost:xxxx/Grid/UrlDatasource").Adaptor("UrlAdaptor")).Columns(col =>
{
  col.Field("OrderID").HeaderText("Order ID").Width("100").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).Add();
  col.Field("CustomerID").HeaderText("Customer Name").Width("100").Add();
  col.Field("EmployeeID").HeaderText("Employee ID").Width("100").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).Add();
  col.Field("Freight").HeaderText("Freight").Width("100").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).Format("C2").Add();
  col.Field("ShipCity").HeaderText("Ship City").Width("120").Add();
}).AllowFiltering().Render()

{% endhighlight %}
{% endtabs %}

### Handling sorting operation

To handle sorting operation, ensure that your API endpoint supports custom sorting criteria. Implement the sorting logic on the server-side using the `PerformSorting` method from the `QueryableOperation` class. This allows the custom data source to undergo sorting based on the criteria specified in the incoming `DataManagerRequest` object.

{% tabs %}
{% highlight cs tabtitle="GridController.cs" %}

/// <summary>
/// Processes the DataManager request to perform sorting operation.
/// </summary>
/// <param name="DataManagerRequest">Contains the details of the data operation requested.</param>
/// <returns>Returns a JSON object with the sorted data along with the total record count.</returns>
public JsonResult UrlDataSource(DataManagerRequest DataManagerRequest)
{
  // Retrieve data from the data source (e.g., database).
  IQueryable<Orders> dataSource = GetOrderData().AsQueryable();

  // Initialize QueryableOperation instance.
  QueryableOperation queryableOperation = new QueryableOperation();

  // Handling sorting operation.
  if (DataManagerRequest.Sorted?.Count > 0)
  {
    dataSource = queryableOperation.PerformSorting(dataSource, DataManagerRequest.Sorted);
    //Add custom logic here if needed and remove above method.
  }

  // Get the total count of records.
  int totalRecordsCount = DataSource.Count();

  // Return data based on the request.
  return Json(new { result = dataSource, count = totalRecordsCount }, JsonRequestBehavior.AllowGet);
}

{% endhighlight %}

{% highlight cshtml tabtitle="Index.cshtml" %}

// Replace `xxxx` with your actual localhost port number.
@Html.EJS().Grid("Grid").DataSource(ds => ds.Url("https://localhost:xxxx/Grid/UrlDatasource").Adaptor("UrlAdaptor")).Columns(col =>
{
  col.Field("OrderID").HeaderText("Order ID").Width("100").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).Add();
  col.Field("CustomerID").HeaderText("Customer Name").Width("100").Add();
  col.Field("EmployeeID").HeaderText("Employee ID").Width("100").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).Add();
  col.Field("Freight").HeaderText("Freight").Width("100").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).Format("C2").Add();
  col.Field("ShipCity").HeaderText("Ship City").Width("120").Add();
}).AllowSorting().Render()

{% endhighlight %}
{% endtabs %}

### Handling paging operation

To handle paging operation, ensure that your API endpoint supports custom paging criteria. Implement the paging logic on the server-side using the `PerformTake` and `PerformSkip` method from the `QueryableOperation` class. This allows the custom data source to undergo paging based on the criteria specified in the incoming `DataManagerRequest` object.

{% tabs %}
{% highlight cs tabtitle="GridController.cs" %}

/// <summary>
/// Processes the DataManager request to perform paging operation.
/// </summary>
/// <param name="DataManagerRequest">Contains the details of the data operation requested.</param>
/// <returns>Returns a JSON object with the paginated data along with the total record count.</returns>
public JsonResult UrlDataSource(DataManagerRequest DataManagerRequest)
{
  // Retrieve data from the data source (e.g., database).
  IQueryable<Orders> dataSource = GetOrderData().AsQueryable();

  // Initialize QueryableOperation instance.
  QueryableOperation queryableOperation = new QueryableOperation();

  // Get the total count of records.
  int totalRecordsCount = dataSource.Count();

  // Handling paging operation.
  if (DataManagerRequest.Skip > 0)
  {
    dataSource = queryableOperation.PerformSkip(dataSource, DataManagerRequest.Skip);
  }
  if (DataManagerRequest.Take > 0)
  {
    dataSource = queryableOperation.PerformTake(dataSource, DataManagerRequest.Take);
  }

  // Return data based on the request.
  return Json(new { result = dataSource, count = totalRecordsCount }, JsonRequestBehavior.AllowGet);
}

{% endhighlight %}

{% highlight cshtml tabtitle="Index.cshtml" %}

// Replace `xxxx` with your actual localhost port number.
@Html.EJS().Grid("Grid").DataSource(ds => ds.Url("https://localhost:xxxx/Grid/UrlDatasource").Adaptor("UrlAdaptor")).Columns(col =>
{
  col.Field("OrderID").HeaderText("Order ID").Width("100").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).Add();
  col.Field("CustomerID").HeaderText("Customer Name").Width("100").Add();
  col.Field("EmployeeID").HeaderText("Employee ID").Width("100").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).Add();
  col.Field("Freight").HeaderText("Freight").Width("100").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).Format("C2").Add();
  col.Field("ShipCity").HeaderText("Ship City").Width("120").Add();
}).AllowPaging().Render()

{% endhighlight %}
{% endtabs %}

### Handling CRUD operations

The Syncfusion ASP.NET MVC Grid seamlessly integrates CRUD (Create, Read, Update and Delete) operations with server-side controller actions through specific properties: `InsertUrl`, `RemoveUrl`, `UpdateUrl`, and `BatchUrl`. These properties enable the Grid to communicate with the data service for every Grid action, facilitating server-side operations.

**CRUD operations mapping**

CRUD operations within the Grid can be mapped to server-side controller actions using specific properties:

1. **InsertUrl**: Specifies the URL for inserting new data.
2. **RemoveUrl**: Specifies the URL for removing existing data.
3. **UpdateUrl**: Specifies the URL for updating existing data.
4. **BatchUrl**: Specifies the URL for batch editing.

To enable editing in ASP.NET MVC Grid, refer to the editing [documentation](https://ej2.syncfusion.com/aspnetmvc/documentation/grid/editing/edit). In the below example, the inline edit `Mode` is enabled and [Toolbar](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Toolbar) property is configured to display toolbar items for editing purposes.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}

// Replace `xxxx` with your actual localhost port number.
@Html.EJS().Grid("Grid").DataSource(ds => ds.Url("https://localhost:xxxx/Grid/UrlDatasource")
        .UpdateUrl("https://localhost:xxxx/Grid/Update")
        .InsertUrl("https://localhost:xxxx/Grid/Insert")
        .RemoveUrl("https://localhost:xxxx/Grid/Remove").Adaptor("UrlAdaptor")).Columns(col =>
{
  col.Field("OrderID").HeaderText("Order ID").Width("100").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).IsPrimaryKey(true).IsIdentity(true).Add();
  col.Field("CustomerID").HeaderText("Customer Name").Width("100").ValidationRules(new { required = "true" }).Add();
  col.Field("EmployeeID").HeaderText("Employee ID").Width("100").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).ValidationRules(new { required = "true", number = true}).Add();
  col.Field("Freight").HeaderText("Freight").Width("100").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).Format("C2").ValidationRules(new { required = "true", min=1, max=1000 }).Add();
  col.Field("ShipCity").HeaderText("Ship City").Width("120").ValidationRules(new { required = "true" }).Add();
}).EditSettings(edit => { edit.AllowAdding(true).AllowEditing(true).AllowDeleting(true).Mode(Syncfusion.EJ2.Grids.EditMode.Normal); }).Toolbar(new List<string>() { "Add", "Edit", "Delete", "Update", "Cancel" }).Render()

{% endhighlight %}
{% endtabs %}

> * Normal/Inline editing is the default edit `Mode` for the Grid. To enable CRUD operations, ensure that the [IsPrimaryKey](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_IsPrimaryKey) property is set to **true** for a specific Grid column, ensuring that its value is unique.
> * If database has an auto generated column, ensure to define [IsIdentity](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_IsIdentity) property of Grid column to disable them during adding or editing operations.

**Insert operation:**

To insert a new row, simply click the **Add** toolbar button. The new record edit form will be displayed as shown below. Upon clicking the **Update** toolbar button, record will inserted into the **Orders** table by calling the following **POST** method of an API.

{% tabs %}
{% highlight cs tabtitle="GridController.cs" %}

/// <summary>
/// Inserts a new data item into the data collection.
/// </summary>
/// <param name="value">It contains the new record detail which is need to be inserted.</param>
/// <returns>Returns void.</returns>
public void Insert(Orders value)
{
    //Create query to insert the specific into the database by accessing its properties.
    string queryStr = $"Insert into Orders(CustomerID,Freight,ShipCity,EmployeeID) values('{value.CustomerID}','{value.Freight}','{value.ShipCity}','{value.EmployeeID}')";

    // Establishes a connection to the SQLite database using the provided connection string.
    SqliteConnection Connection = new SqliteConnection(ConnectionString);

    // Opens the database connection to execute queries.
    Connection.Open();

    //Execute the SQLite command.
    SqliteCommand Command = new SqliteCommand(queryStr, Connection);

    //Execute this code to reflect the changes into the database.
    Command.ExecuteNonQuery();

    // Close the database connection after executing the query.
    Connection.Close();

    //Add custom logic here if needed and remove above method.
}

public class Orders
{
    [Key]
    public int? OrderID { get; set; }
    public string CustomerID { get; set; }
    public int? EmployeeID { get; set; }
    public decimal? Freight { get; set; }
    public string ShipCity { get; set; }
}

{% endhighlight %}
{% endtabs %}

**Update operation:**

To edit a row, first select desired row and click the **Edit** toolbar button. The edit form will be displayed and proceed to modify any column value as per your requirement. Clicking the **Update** toolbar button will update the edit record in the **Orders** table by involving the following **Post** method of an API.

{% tabs %}
{% highlight cs tabtitle="GridController.cs" %}

/// <summary>
/// Update a existing data item from the data collection.
/// </summary>
/// <param name="value">It contains the updated record detail which is need to be updated.</param>
/// <returns>Returns void.</returns>
public void Update(Orders value)
{
    //Create query to update the changes into the database by accessing its properties.
    string queryStr = $"Update Orders set CustomerID='{value.CustomerID}', Freight='{value.Freight}',EmployeeID='{value.EmployeeID}',ShipCity='{value.ShipCity}' where OrderID='{value.OrderID}'";

    // Establishes a connection to the SQLite database using the provided connection string.
    SqliteConnection Connection = new SqliteConnection(ConnectionString);

    // Opens the database connection to execute queries.
    Connection.Open();

    //Execute the SQLite command.
    SqliteCommand Command = new SqliteCommand(queryStr, Connection);

    //Execute this code to reflect the changes into the database.
    Command.ExecuteNonQuery();

    // Close the database connection after executing the query.
    Connection.Close();

    //Add custom logic here if needed and remove above method.
}

public class Orders
{
    [Key]
    public int? OrderID { get; set; }
    public string CustomerID { get; set; }
    public int? EmployeeID { get; set; }
    public decimal? Freight { get; set; }
    public string ShipCity { get; set; }
}

{% endhighlight %}
{% endtabs %}

**Delete operation:**

To delete a row, simply select the desired row and click the **Delete** toolbar button. This action will trigger a **DELETE** request to an API, containing the primary key value of the selected record. As a result corresponding record will be removed from the **Orders** table.

{% tabs %}
{% highlight cs tabtitle="GridController.cs" %}

/// <summary>
/// Update a existing data item from the data collection.
/// </summary>
/// <param name="value">It contains the updated record detail which is need to be updated.</param>
/// <returns>Returns void.</returns>
public void Remove(CRUDModel<Orders> value)
{
    //Create query to remove the specific from database by passing the primary key column value.
    string queryStr = $"Delete from Orders where OrderID={value.key}";

    // Establishes a connection to the SQLite database using the provided connection string.
    SqliteConnection Connection = new SqliteConnection(ConnectionString);

    // Opens the database connection to execute queries.
    Connection.Open();

    //Execute the SQLite command.
    SqliteCommand Command = new SqliteCommand(queryStr, Connection);

    //Execute this code to reflect the changes into the database.
    Command.ExecuteNonQuery();

    // Close the database connection after executing the query.
    Connection.Close();

    //Add custom logic here if needed and remove above method.
}
public class CRUDModel<T> where T : class
{
    public string action { get; set; }
    public string keyColumn { get; set; }
    public object key { get; set; }
    public T value { get; set; }
    public List<T> added { get; set; }
    public List<T> changed { get; set; }
    public List<T> deleted { get; set; }
    public IDictionary<string, object> @params { get; set; }
}

public class Orders
{
    [Key]
    public int? OrderID { get; set; }
    public string CustomerID { get; set; }
    public int? EmployeeID { get; set; }
    public decimal? Freight { get; set; }
    public string ShipCity { get; set; }
}

{% endhighlight %}
{% endtabs %}

**Batch operation:**

To perform batch operation, define the edit `Mode` as **Batch** and specify the `batchUrl` property in the `DataManager`. Use the **Add** toolbar button to insert new row in batch editing mode. To edit a cell, double-click the desired cell and update the value as required. To delete a record, simply select the record and press the **Delete** toolbar button. Now, all CRUD operations will be executed in batch editing mode. Clicking the **Update** toolbar button will update the newly added, edited, or deleted records from the **Orders** table using a single API **POST** request.

{% tabs %}
{% highlight cs tabtitle="GridController.cs" %}

/// <summary>
/// Batch update (Insert, Update, and Delete) a collection of data items from the data collection.
/// </summary>
/// <param name="value">The set of information along with details about the CRUD actions to be executed from the database.</param>
/// <returns>Returns a JsonResult containing the processed data.</returns>
public JsonResult BatchUpdate(CRUDModel<Orders> value)
{
    using (SqliteConnection connection = new SqliteConnection(ConnectionString))
    {
        // Open the database connection.
        connection.Open();

        using (SqliteTransaction transaction = connection.BeginTransaction())
        {
            using (SqliteCommand command = connection.CreateCommand())
            {
                // Process updated records if any.
                if (value.changed != null && value.changed.Count > 0)
                {
                    command.CommandText = "UPDATE Orders SET CustomerID=@CustomerID, Freight=@Freight, EmployeeID=@EmployeeID, ShipCity=@ShipCity WHERE OrderID=@OrderID";
                    foreach (Orders record in value.changed)
                    {
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@CustomerID", record.CustomerID);
                        command.Parameters.AddWithValue("@Freight", record.Freight);
                        command.Parameters.AddWithValue("@EmployeeID", record.EmployeeID);
                        command.Parameters.AddWithValue("@ShipCity", record.ShipCity);
                        command.Parameters.AddWithValue("@OrderID", record.OrderID);
                        command.ExecuteNonQuery();
                    }
                }

                // Process inserted records if any.
                if (value.added != null && value.added.Count > 0)
                {
                    command.CommandText = "INSERT INTO Orders (CustomerID, Freight, ShipCity, EmployeeID) VALUES (@CustomerID, @Freight, @ShipCity, @EmployeeID)";
                    foreach (Orders record in value.added)
                    {
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@CustomerID", record.CustomerID);
                        command.Parameters.AddWithValue("@Freight", record.Freight);
                        command.Parameters.AddWithValue("@ShipCity", record.ShipCity);
                        command.Parameters.AddWithValue("@EmployeeID", record.EmployeeID);
                        command.ExecuteNonQuery();
                    }
                }

                // Process deleted records if any.
                if (value.deleted != null && value.deleted.Count > 0)
                {
                    command.CommandText = "DELETE FROM Orders WHERE OrderID=@OrderID";
                    foreach (Orders record in value.deleted)
                    {
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@OrderID", record.OrderID);
                        command.ExecuteNonQuery();
                    }
                }
            }

            // Commit the transaction.
            transaction.Commit();
        }
    }

    return Json(new { success = true, message = "Batch update successful.", data = value }, JsonRequestBehavior.AllowGet);
}


public class CRUDModel<T> where T : class
{
    public string action { get; set; }
    public string keyColumn { get; set; }
    public object key { get; set; }
    public T value { get; set; }
    public List<T> added { get; set; }
    public List<T> changed { get; set; }
    public List<T> deleted { get; set; }
    public IDictionary<string, object> @params { get; set; }
}

public class Orders
{
    [Key]
    public int? OrderID { get; set; }
    public string CustomerID { get; set; }
    public int? EmployeeID { get; set; }
    public decimal? Freight { get; set; }
    public string ShipCity { get; set; }
}

{% endhighlight %}

{% highlight cshtml tabtitle="Index.cshtml" %}

// Replace `xxxx` with your actual localhost port number.
@Html.EJS().Grid("Grid").DataSource(ds => ds.Url("https://localhost:xxxx/Grid/UrlDatasource").BatchUrl("https://localhost:xxxx/Grid/BatchUpdate").Adaptor("UrlAdaptor")).Columns(col =>
{
    col.Field("OrderID").HeaderText("Order ID").Width("100").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).IsPrimaryKey(true).IsIdentity(true).Add();
    col.Field("CustomerID").HeaderText("Customer Name").Width("100").ValidationRules(new { required = "true" }).Add();
    col.Field("EmployeeID").HeaderText("Employee ID").Width("100").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).ValidationRules(new { required = "true", number = true}).Add();
    col.Field("Freight").HeaderText("Freight").Width("100").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).Format("C2").ValidationRules(new { required = "true", min=1, max=1000 }).Add();
    col.Field("ShipCity").HeaderText("Ship City").Width("120").ValidationRules(new { required = "true" }).Add();
}).AllowPaging().EditSettings(edit => { edit.AllowAdding(true).AllowEditing(true).AllowDeleting(true).Mode(Syncfusion.EJ2.Grids.EditMode.Batch); }).Toolbar(new List<string>() { "Add", "Edit", "Delete", "Update", "Cancel" }).Render()

{% endhighlight %}
{% endtabs %}

When you run the application, the resultant Grid will look like this

![Syncfusion ASP.NET MVC Grid bound with Microsoft SQL Sqlite](../images/database/db-crud.gif)

## Binding data from SQLite Server using CustomAdaptor

This section describes step by step process how to retrieve data from a Microsoft SQL Server using [CustomAdaptor](https://ej2.syncfusion.com/aspnetmvc/documentation/grid/connecting-to-adaptors/custom-adaptor) and bind it to the Syncfusion ASP.NET MVC Grid.

**1.** To create a simple Grid, the procedure is explained in the above-mentioned topic on [Connecting Syncfusion ASP.NET MVC Grid to an API service](##connecting-syncfusion-aspnet-mvc-grid-to-an-api-service)

**2.** To connect a SQLite Server database using the SQLite driver in your application, you need to install the [Microsoft.Data.Sqlite](https://www.nuget.org/packages/Microsoft.Data.Sqlite/) NuGet package. To add **Microsoft.Data.Sqlite** in the app, open the NuGet package manager in Visual Studio (Tools → NuGet Package Manager → Manage NuGet Packages for Solution), search and install it.

**3.** If you intend to inject your own service into the `CustomAdaptor` and utilize it, you can achieve this as follows:

  * Create a `CustomAdaptor` that extends the `UrlAdaptor` class.
  * Override the `processResponse` method to process server responses.

**4.** Within the `processResponse` method of `CustomAdaptor`, fetch data by calling the **GetOrderData** method.

  * In this **GetOrderData** method, the SQLite Server database data is fetch by using the **SqliteDataReader** class.
  * Employ the `processResponse` method to asynchronously iterate over the results retrieved by executing the SQL query with **ExecuteReaderAsync** method, gathering the data into a list.
  * Finally, return the response as a `result` and `count` pair object in the `processResponse` method to bind the data to the Grid.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}

@Html.EJS().Grid("Grid").Columns(col =>
{
  col.Field("OrderID").HeaderText("Order ID").Width("100").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).Add();
  col.Field("CustomerID").HeaderText("Customer Name").Width("100").Add();
  col.Field("EmployeeID").HeaderText("Employee ID").Width("100").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).Add();
  col.Field("Freight").HeaderText("Freight").Width("100").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).Format("C2").Add();
  col.Field("ShipCity").HeaderText("Ship City").Width("120").Add();
}).Render()

<script>
	class CustomAdaptor extends ej.data.UrlAdaptor {
		processResponse(data, ds, query, xhr, request, changes) {
			var original = super.processResponse(data, ds, query, xhr, request, changes);
			return original;
		}
	}
	document.addEventListener("DOMContentLoaded", function () {
		let grid = document.getElementById("Grid").ej2_instances[0];
		if (grid) {
			let dataManager = new ejs.data.DataManager({
				url: "https://localhost:xxxx/Grid/UrlDataSource", // Replace `xxxx` with your actual port number.
				adaptor: new CustomAdaptor(),
			});
			grid.dataSource = dataManager;
		}
	});
</script>

{% endhighlight %}

{% highlight cs tabtitle="GridController.cs" %}

using Microsoft.Data.Sqlite;
using Syncfusion.EJ2.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web.Mvc;

namespace Grid_Sqlite.Controllers
{
  public class GridController : Controller
    {
        private readonly string ConnectionString = "<Enter a valid connection string>";

        /// <summary>
        /// Processes the DataManager request to perform searching, filtering, sorting, and paging operations.
        /// </summary>
        /// <param name="DataManagerRequest">Contains the details of the data operation requested.</param>
        /// <returns>Returns a JSON object along with the total record count.</returns>
        [HttpPost]
        public object UrlDataSource()
        {
            // Retrieve data from the database.
            IQueryable<Orders> dataSource = GetOrderData().AsQueryable();

            // Get the total count of records.
            int totalRecordsCount = dataSource.Count();

            // Return the data and total record count as a JSON response.
            return Ok(new { result = dataSource, count = totalRecordsCount });
        }

        /// <summary>
        /// Retrieves the order data from the database.
        /// </summary>
        /// <returns>Returns a list of orders fetched from the database.</returns>
        [HttpGet]
        public List<Orders> GetOrderData()
        {
            // SQL query to fetch all records from the Orders table and sort them by OrderID.
            string queryStr = "SELECT * FROM Orders ORDER BY OrderID.";

            // Create a list to store retrieved orders from the database.
            List<Orders> dataSource = new List<Orders>();

            // Establish a connection to the SQLite database using the provided connection string.
            using (SqliteConnection connection = new SqliteConnection(ConnectionString))
            {
                // Open the database connection to enable SQL queries.
                connection.Open();

                // Create a command to execute the SQL query.
                using (SqliteCommand command = new SqliteCommand(queryStr, connection))
                {
                    // Execute the command and retrieve data using SqliteDataReader.
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Orders order = new Orders
                            {
                                OrderID = reader.GetInt32(reader.GetOrdinal("OrderID")),
                                CustomerID = reader.GetString(reader.GetOrdinal("CustomerID")),
                                EmployeeID = reader.GetInt32(reader.GetOrdinal("EmployeeID")),
                                ShipCity = reader.GetString(reader.GetOrdinal("ShipCity")),
                                Freight = reader.GetDecimal(reader.GetOrdinal("Freight"))
                            };
                            dataSource.Add(order);
                        }
                    }
                }
            }
            return dataSource;
        }

        /// Represents an order entity with relevant fields.
        public class Orders
        {
            [Key]
            public int? OrderID { get; set; }
            public string? CustomerID { get; set; }
            public int? EmployeeID { get; set; }
            public decimal? Freight { get; set; }
            public string? ShipCity { get; set; }
        }
    }
}

{% endhighlight %}
{% endtabs %}

> * The `DataManagerRequest` encompasses details about the Grid actions such as searching, filtering, sorting, aggregate, paging and grouping.

### Handling searching operation

When utilizing the `CustomAdaptor` in ASP.NET MVC, managing the searching operation involves overriding the `processResponse` method of the `UrlAdaptor` class.

In the code example below, searching a custom data source can be accomplished by employing the built-in `PerformSearching` method of the `QueryableOperation` class. Alternatively, you can implement your own method for searching operation and bind the resultant data to the Grid.

{% tabs %}
{% highlight cs tabtitle="GridController.cs" %}

/// <summary>
/// Processes the DataManager request to perform searching operation.
/// </summary>
/// <param name="DataManagerRequest">Contains the details of the data operation requested.</param>
/// <returns>Returns a JSON object with the searched data along with the total record count.</returns>
public JsonResult UrlDataSource(DataManagerRequest DataManagerRequest)
{
  // Retrieve data from the data source (e.g., database).
  IQueryable<Orders> dataSource = GetOrderData().AsQueryable();

  // Initialize QueryableOperation instance.
  QueryableOperation queryableOperation = new QueryableOperation();

  // Handling searching operation.
  if (DataManagerRequest.Search?.Count > 0)
  {
    dataSource = queryableOperation.PerformSearching(dataSource, DataManagerRequest.Search);
    //Add custom logic here if needed and remove above method.
  }

  // Get the total count of records.
  int totalRecordsCount = DataSource.Count();

  // Return data based on the request.
  return Json(new { result = dataSource, count = totalRecordsCount }, JsonRequestBehavior.AllowGet);
}

{% endhighlight %}

{% highlight cshtml tabtitle="Index.cshtml" %}

// Replace `xxxx` with your actual localhost port number.
@Html.EJS().Grid("Grid").Columns(col =>
{
  col.Field("OrderID").HeaderText("Order ID").Width("100").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).Add();
  col.Field("CustomerID").HeaderText("Customer Name").Width("100").Add();
  col.Field("EmployeeID").HeaderText("Employee ID").Width("100").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).Add();
  col.Field("Freight").HeaderText("Freight").Width("100").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).Format("C2").Add();
  col.Field("ShipCity").HeaderText("Ship City").Width("120").Add();
}).Toolbar(new List<string>() { "Search" }).Render()

<script>
	class CustomAdaptor extends ej.data.UrlAdaptor {
		processResponse(data, ds, query, xhr, request, changes) {
			var original = super.processResponse(data, ds, query, xhr, request, changes);
			return original;
		}
	}
	document.addEventListener("DOMContentLoaded", function () {
		let grid = document.getElementById("Grid").ej2_instances[0];
		if (grid) {
			let dataManager = new ejs.data.DataManager({
				url: "https://localhost:xxxx/Grid/UrlDataSource", // Replace `xxxx` with your actual port number.
				adaptor: new CustomAdaptor(),
			});
			grid.dataSource = dataManager;
		}
	});
</script>

{% endhighlight %}
{% endtabs %}

### Handling filtering operation

When utilizing the `CustomAdaptor` in ASP.NET MVC, managing the filtering operation involves overriding the `processResponse` method of the `UrlAdaptor` class.

In the code example below, filtering a custom data source can be achieved by utilizing the built-in `PerformFiltering` method of the `QueryableOperation` class. Alternatively, you can implement your own method for filtering operation and bind the resulting data to the Grid.

{% tabs %}
{% highlight cs tabtitle="GridController.cs" %}

/// <summary>
/// Processes the DataManager request to perform filtering operation.
/// </summary>
/// <param name="DataManagerRequest">Contains the details of the data operation requested.</param>
/// <returns>Returns a JSON object with the filtered data along with the total record count.</returns>
public JsonResult UrlDataSource(DataManagerRequest DataManagerRequest)
{
  // Retrieve data from the data source (e.g., database).
  IQueryable<Orders> dataSource = GetOrderData().AsQueryable();

  // Initialize QueryableOperation instance.
  QueryableOperation queryableOperation = new QueryableOperation();

  // Handling filtering operation.
  if (DataManagerRequest.Where?.Count > 0)
  {
    foreach (WhereFilter condition in DataManagerRequest.Where)
    {
      foreach (WhereFilter predicate in condition.predicates)
      {
        dataSource = queryableOperation.PerformFiltering(dataSource, DataManagerRequest.Where, predicate.Operator);
        //Add custom logic here if needed and remove above method.
      }
    }
  }

  // Get the total count of records.
  int totalRecordsCount = DataSource.Count();  

  // Return data based on the request.
  return Json(new { result = dataSource, count = totalRecordsCount }, JsonRequestBehavior.AllowGet);
}

{% endhighlight %}

{% highlight cshtml tabtitle="Index.cshtml" %}

// Replace `xxxx` with your actual localhost port number.
@Html.EJS().Grid("Grid").Columns(col =>
{
  col.Field("OrderID").HeaderText("Order ID").Width("100").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).Add();
  col.Field("CustomerID").HeaderText("Customer Name").Width("100").Add();
  col.Field("EmployeeID").HeaderText("Employee ID").Width("100").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).Add();
  col.Field("Freight").HeaderText("Freight").Width("100").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).Format("C2").Add();
  col.Field("ShipCity").HeaderText("Ship City").Width("120").Add();
}).AllowFiltering().Render()

<script>
	class CustomAdaptor extends ej.data.UrlAdaptor {
		processResponse(data, ds, query, xhr, request, changes) {
			var original = super.processResponse(data, ds, query, xhr, request, changes);
			return original;
		}
	}
	document.addEventListener("DOMContentLoaded", function () {
		let grid = document.getElementById("Grid").ej2_instances[0];
		if (grid) {
			let dataManager = new ejs.data.DataManager({
				url: "https://localhost:xxxx/Grid/UrlDataSource", // Replace `xxxx` with your actual port number.
				adaptor: new CustomAdaptor(),
			});
			grid.dataSource = dataManager;
		}
	});
</script>

{% endhighlight %}
{% endtabs %}

### Handling sorting operation

When utilizing the `CustomAdaptor` in ASP.NET MVC, managing the sorting operation involves overriding the `processResponse` method of the `UrlAdaptor` class.

In the code example below, sorting a custom data source can be accomplished by employing the built-in `PerformSorting` method of the `QueryableOperation` class. Alternatively, you can implement your own method for sorting operation and bind the resulting data to the Grid.

{% tabs %}
{% highlight cs tabtitle="GridController.cs" %}

/// <summary>
/// Processes the DataManager request to perform sorting operation.
/// </summary>
/// <param name="DataManagerRequest">Contains the details of the data operation requested.</param>
/// <returns>Returns a JSON object with the sorted data along with the total record count.</returns>
public JsonResult UrlDataSource(DataManagerRequest DataManagerRequest)
{
  // Retrieve data from the data source (e.g., database).
  IQueryable<Orders> dataSource = GetOrderData().AsQueryable();

  // Initialize QueryableOperation instance.
  QueryableOperation queryableOperation = new QueryableOperation();

  // Handling sorting operation.
  if (DataManagerRequest.Sorted?.Count > 0)
  {
    dataSource = queryableOperation.PerformSorting(dataSource, DataManagerRequest.Sorted);
    //Add custom logic here if needed and remove above method.
  }

  // Get the total count of records.
  int totalRecordsCount = DataSource.Count();

  // Return data based on the request.
  return Json(new { result = dataSource, count = totalRecordsCount }, JsonRequestBehavior.AllowGet);
}

{% endhighlight %}

{% highlight cshtml tabtitle="Index.cshtml" %}

// Replace `xxxx` with your actual localhost port number.
@Html.EJS().Grid("Grid").Columns(col =>
{
  col.Field("OrderID").HeaderText("Order ID").Width("100").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).Add();
  col.Field("CustomerID").HeaderText("Customer Name").Width("100").Add();
  col.Field("EmployeeID").HeaderText("Employee ID").Width("100").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).Add();
  col.Field("Freight").HeaderText("Freight").Width("100").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).Format("C2").Add();
  col.Field("ShipCity").HeaderText("Ship City").Width("120").Add();
}).AllowSorting().Render()

<script>
	class CustomAdaptor extends ej.data.UrlAdaptor {
		processResponse(data, ds, query, xhr, request, changes) {
			var original = super.processResponse(data, ds, query, xhr, request, changes);
			return original;
		}
	}
	document.addEventListener("DOMContentLoaded", function () {
		let grid = document.getElementById("Grid").ej2_instances[0];
		if (grid) {
			let dataManager = new ejs.data.DataManager({
				url: "https://localhost:xxxx/Grid/UrlDataSource", // Replace `xxxx` with your actual port number.
				adaptor: new CustomAdaptor(),
			});
			grid.dataSource = dataManager;
		}
	});
</script>

{% endhighlight %}
{% endtabs %}

### Handling paging operation

When utilizing the `CustomAdaptor` in ASP.NET MVC, managing the paging operation involves overriding the `processResponse` method of the `UrlAdaptor` class.

In the code example below, paging a custom data source can be achieved by utilizing the built-in `PerformTake` and `PerformSkip` method of the `QueryableOperation` class. Alternatively, you can use your own method for paging operation and bind the resulting data to the Grid.

{% tabs %}
{% highlight cs tabtitle="GridController.cs" %}

/// <summary>
/// Processes the DataManager request to perform paging operation.
/// </summary>
/// <param name="DataManagerRequest">Contains the details of the data operation requested.</param>
/// <returns>Returns a JSON object with the paginated data along with the total record count.</returns>
public JsonResult UrlDataSource(DataManagerRequest DataManagerRequest)
{
  // Retrieve data from the data source (e.g., database).
  IQueryable<Orders> dataSource = GetOrderData().AsQueryable();

  // Initialize QueryableOperation instance.
  QueryableOperation queryableOperation = new QueryableOperation();

  // Get the total count of records.
  int totalRecordsCount = dataSource.Count();

  // Handling paging operation.
  if (DataManagerRequest.Skip > 0)
  {
    dataSource = queryableOperation.PerformSkip(dataSource, DataManagerRequest.Skip);
  }
  if (DataManagerRequest.Take > 0)
  {
    dataSource = queryableOperation.PerformTake(dataSource, DataManagerRequest.Take);
  }

  // Return data based on the request.
  return Json(new { result = dataSource, count = totalRecordsCount }, JsonRequestBehavior.AllowGet);
}

{% endhighlight %}

{% highlight cshtml tabtitle="Index.cshtml" %}

// Replace `xxxx` with your actual localhost port number.
@Html.EJS().Grid("Grid").Columns(col =>
{
  col.Field("OrderID").HeaderText("Order ID").Width("100").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).Add();
  col.Field("CustomerID").HeaderText("Customer Name").Width("100").Add();
  col.Field("EmployeeID").HeaderText("Employee ID").Width("100").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).Add();
  col.Field("Freight").HeaderText("Freight").Width("100").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).Format("C2").Add();
  col.Field("ShipCity").HeaderText("Ship City").Width("120").Add();
}).AllowPaging().Render()

<script>
	class CustomAdaptor extends ej.data.UrlAdaptor {
		processResponse(data, ds, query, xhr, request, changes) {
			var original = super.processResponse(data, ds, query, xhr, request, changes);
			return original;
		}
	}
	document.addEventListener("DOMContentLoaded", function () {
		let grid = document.getElementById("Grid").ej2_instances[0];
		if (grid) {
			let dataManager = new ejs.data.DataManager({
				url: "https://localhost:xxxx/Grid/UrlDataSource", // Replace `xxxx` with your actual port number.
				adaptor: new CustomAdaptor(),
			});
			grid.dataSource = dataManager;
		}
	});
</script>

{% endhighlight %}
{% endtabs %}

### Handling CRUD operations

To enable editing in the Syncfusion ASP.NET MVC Grid, utilize the [GridEditSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridEditSettings.html) property. The Grid offers multiple edit modes including the **Inline/Normal**, **Dialog** and **Batch** editing. For more details, refer to the Grid [editing](https://ej2.syncfusion.com/aspnetmvc/documentation/grid/editing/edit) documentation.

In this scenario, the inline edit `Mode` and [Toolbar](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Toolbar) property configured to display toolbar items for editing purpose.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}

// Replace `xxxx` with your actual localhost port number.
@Html.EJS().Grid("Grid").Columns(col =>
{
    col.Field("OrderID").HeaderText("Order ID").Width("100").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).IsPrimaryKey(true).IsIdentity(true).Add();
    col.Field("CustomerID").HeaderText("Customer Name").Width("100").ValidationRules(new { required = "true" }).Add();
    col.Field("EmployeeID").HeaderText("Employee ID").Width("100").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).ValidationRules(new { required = "true", number = true}).Add();
    col.Field("Freight").HeaderText("Freight").Width("100").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).Format("C2").ValidationRules(new { required = "true", min=1, max=1000 }).Add();
    col.Field("ShipCity").HeaderText("Ship City").Width("120").ValidationRules(new { required = "true" }).Add();
}).EditSettings(edit => { edit.AllowAdding(true).AllowEditing(true).AllowDeleting(true).Mode(Syncfusion.EJ2.Grids.EditMode.Normal); }).Toolbar(new List<string>() { "Add", "Edit", "Delete", "Update", "Cancel" }).Render()

<script>
    class CustomAdaptor extends ej.data.UrlAdaptor {
        processResponse(data, ds, query, xhr, request, changes) {
            var original = super.processResponse(data, ds, query, xhr, request, changes);
            return original;
        }
    }
    document.addEventListener("DOMContentLoaded", function () {
        let grid = document.getElementById("Grid").ej2_instances[0];
        if (grid) {
            let dataManager = new ejs.data.DataManager({
                url: "https://localhost:xxxx/Grid/UrlDataSource", // Replace `xxxx` with your actual port number.
                adaptor: new CustomAdaptor(),
                insertUrl: "https://localhost:xxxx/Grid/Insert",
                updateUrl: "https://localhost:xxxx/Grid/Update",
                removeUrl: "https://localhost:xxxx/Grid/Remove",
            });
            grid.dataSource = dataManager;
        }
    });
</script>

{% endhighlight %}
{% endtabs %}

> * Normal/Inline editing is the default edit `Mode` for the Grid. To enable CRUD operations, ensure that the [IsPrimaryKey](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_IsPrimaryKey) property is set to **true** for a specific Grid column, ensuring that its value is unique.
> * If database has an auto generated column, ensure to define [IsIdentity](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_IsIdentity) property of Grid column to disable them during adding or editing operations.

The CRUD operations can be performed and customized on our own by overriding the following CRUD methods of the `UrlAdaptor` 

* insert
* remove
* update
* batchRequest

Let’s see how to perform CRUD operation using SQLite Server data with Grid.

**Insert operation:**

To execute the insert operation, you will need to override the `insert` method of the `CustomAdaptor`. Then, integrate the following code snippet into the `CustomAdaptor` class. The below code snippet demonstrated how to handle the insertion of new records within the `insert` method of `CustomAdaptor`. Modify the logic within this method according to the requirements of your application.

{% tabs%}
{% highlight cshtml tabtitle="Index.cshtml" %}

<script>
	class CustomAdaptor extends ej.data.UrlAdaptor {
        processResponse(data, ds, query, xhr, request, changes) {
            var original = super.processResponse(data, ds, query, xhr, request, changes);
            return original;
        }
        insert(dataManager, data) {
        return {
                url: dataManager.dataSource.insertUrl || dataManager.dataSource.url,
                data: JSON.stringify({
                    __RequestVerificationToken: "Syncfusion",
                    value: data,
                    action: 'insert'
                }),
                type: 'POST'
        };
    }
	}
	document.addEventListener("DOMContentLoaded", function () {
		let grid = document.getElementById("Grid").ej2_instances[0];
		if (grid) {
			let dataManager = new ejs.data.DataManager({
				url: "https://localhost:xxxx/Grid/UrlDataSource",
				adaptor: new CustomAdaptor(),
				insertUrl: "https://localhost:xxxx/Grid/Insert",
				updateUrl: "https://localhost:xxxx/Grid/Update",
				removeUrl: "https://localhost:xxxx/Grid/Remove",
			});
			grid.dataSource = dataManager;
		}
	});
</script>

{% endhighlight %}

{% highlight cs tabtitle="GridController.cs" %}

/// <summary>
/// Inserts a new data item into the data collection.
/// </summary>
/// <param name="value">It contains the new record detail which is need to be inserted.</param>
/// <returns>Returns void.</returns>
public void Insert(Orders value)
{
    //Create query to insert the specific into the database by accessing its properties.
    string queryStr = $"Insert into Orders(CustomerID,Freight,ShipCity,EmployeeID) values('{value.CustomerID}','{value.Freight}','{value.ShipCity}','{value.EmployeeID}')";

    // Establishes a connection to the SQLite database using the provided connection string.
    SqliteConnection Connection = new SqliteConnection(ConnectionString);

    // Opens the database connection to execute queries.
    Connection.Open();

    //Execute the SQLite command.
    SqliteCommand Command = new SqliteCommand(queryStr, Connection);

    //Execute this code to reflect the changes into the database.
    Command.ExecuteNonQuery();

    // Close the database connection after executing the query.
    Connection.Close();

    //Add custom logic here if needed and remove above method.
}

public class Orders
{
    [Key]
    public int? OrderID { get; set; }
    public string CustomerID { get; set; }
    public int? EmployeeID { get; set; }
    public decimal? Freight { get; set; }
    public string ShipCity { get; set; }
}

{% endhighlight %}
{% endtabs %}

**Update operation:**

To execute the update operation, override the `update` method of the `CustomAdaptor`. Then, integrate the following code snippet into the `CustomAdaptor` class. The below code snippet demonstrated how to handle the updating of existing records within the `update` method of the `CustomAdaptor`. Modify the logic within this method according to the requirements of your application.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}

<script>
	class CustomAdaptor extends ej.data.UrlAdaptor {
        processResponse(data, ds, query, xhr, request, changes) {
            var original = super.processResponse(data, ds, query, xhr, request, changes);
            return original;
        }
        update(dataManager, keyField, value) {
            return {
            url: dataManager.dataSource.updateUrl || dataManager.dataSource.url,
            data: JSON.stringify({
            __RequestVerificationToken: "Syncfusion",
            value: value,
            action: 'update',
            }),
            type: 'POST',
            };
        }
	}
	document.addEventListener("DOMContentLoaded", function () {
		let grid = document.getElementById("Grid").ej2_instances[0];
		if (grid) {
			let dataManager = new ejs.data.DataManager({
				url: "https://localhost:xxxx/Grid/UrlDataSource",
				adaptor: new CustomAdaptor(),
				insertUrl: "https://localhost:xxxx/Grid/Insert",
				updateUrl: "https://localhost:xxxx/Grid/Update",
				removeUrl: "https://localhost:xxxx/Grid/Remove",
			});
			grid.dataSource = dataManager;
		}
	});
</script>

{% endhighlight %}

{% highlight cs tabtitle="GridController.cs" %}

/// <summary>
/// Update a existing data item from the data collection.
/// </summary>
/// <param name="value">It contains the updated record detail which is need to be updated.</param>
/// <returns>Returns void.</returns>
public void Update(Orders value)
{
    //Create query to update the changes into the database by accessing its properties.
    string queryStr = $"Update Orders set CustomerID='{value.CustomerID}', Freight='{value.Freight}',EmployeeID='{value.EmployeeID}',ShipCity='{value.ShipCity}' where OrderID='{value.OrderID}'";

    // Establishes a connection to the SQLite database using the provided connection string.
    SqliteConnection Connection = new SqliteConnection(ConnectionString);

    // Opens the database connection to execute queries.
    Connection.Open();

    //Execute the SQLite command.
    SqliteCommand Command = new SqliteCommand(queryStr, Connection);

    //Execute this code to reflect the changes into the database.
    Command.ExecuteNonQuery();

    // Close the database connection after executing the query.
    Connection.Close();

    //Add custom logic here if needed and remove above method.
}

public class Orders
{
    [Key]
    public int? OrderID { get; set; }
    public string CustomerID { get; set; }
    public int? EmployeeID { get; set; }
    public decimal? Freight { get; set; }
    public string ShipCity { get; set; }
}

{% endhighlight %}
{% endtabs %}

**Delete operation:**

To perform the delete operation, you need to override the `remove` method of the `CustomAdaptor`. Below is the code snippet that you can add to `CustomAdaptor` class. The below code snippet demonstrated how to handle the deletion of existing records within the `remove` method of `CustomAdaptor`. Modify the logic within this method according to the requirements of your application.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}

<script>
	class CustomAdaptor extends ej.data.UrlAdaptor {
		processResponse(data, ds, query, xhr, request, changes) {
			var original = super.processResponse(data, ds, query, xhr, request, changes);
			return original;
		}
        remove(dataManager, keyField, value) {
            return {
            url: dataManager.dataSource.removeUrl || dataManager.dataSource.url,
            data: JSON.stringify({
            __RequestVerificationToken: "Syncfusion",
            key: value,
            keyColumn: keyField,
            action: 'remove',
            }),
            type: 'POST',
            };
        }
	}
	document.addEventListener("DOMContentLoaded", function () {
		let grid = document.getElementById("Grid").ej2_instances[0];
		if (grid) {
			let dataManager = new ejs.data.DataManager({
				url: "https://localhost:xxxx/Grid/UrlDataSource",
				adaptor: new CustomAdaptor(),
				insertUrl: "https://localhost:xxxx/Grid/Insert",
				updateUrl: "https://localhost:xxxx/Grid/Update",
				removeUrl: "https://localhost:xxxx/Grid/Remove",
			});
			grid.dataSource = dataManager;
		}
	});
</script>

{% endhighlight %}

{% highlight cs tabtitle="GridController.cs" %}

/// <summary>
/// Update a existing data item from the data collection.
/// </summary>
/// <param name="value">It contains the updated record detail which is need to be updated.</param>
/// <returns>Returns void.</returns>
public void Remove(CRUDModel<Orders> value)
{
    //Create query to remove the specific from database by passing the primary key column value.
    string queryStr = $"Delete from Orders where OrderID={value.key}";

    // Establishes a connection to the SQLite database using the provided connection string.
    SqliteConnection Connection = new SqliteConnection(ConnectionString);

    // Opens the database connection to execute queries.
    Connection.Open();

    //Execute the SQLite command.
    SqliteCommand Command = new SqliteCommand(queryStr, Connection);

    //Execute this code to reflect the changes into the database.
    Command.ExecuteNonQuery();

    // Close the database connection after executing the query.
    Connection.Close();

    //Add custom logic here if needed and remove above method.
}
public class CRUDModel<T> where T : class
{
    public string action { get; set; }
    public string keyColumn { get; set; }
    public object key { get; set; }
    public T value { get; set; }
    public List<T> added { get; set; }
    public List<T> changed { get; set; }
    public List<T> deleted { get; set; }
    public IDictionary<string, object> @params { get; set; }
}

public class Orders
{
    [Key]
    public int? OrderID { get; set; }
    public string CustomerID { get; set; }
    public int? EmployeeID { get; set; }
    public decimal? Freight { get; set; }
    public string ShipCity { get; set; }
}

{% endhighlight %}
{% endtabs %}

**Batch operation:**

To perform the batch operation, override the `batchRequest` method of the `CustomAdaptor` and add the following code in the `CustomAdaptor`. The below code snippet demonstrated how to handle the batch update request within the `batchRequest` method of `CustomAdaptor`. Modify the logic within this method according to the requirements of your application.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}

// Replace `xxxx` with your actual localhost port number.
@Html.EJS().Grid("Grid").Columns(col =>
{
    col.Field("OrderID").HeaderText("Order ID").Width("100").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).IsPrimaryKey(true).IsIdentity(true).Add();
    col.Field("CustomerID").HeaderText("Customer Name").Width("100").ValidationRules(new { required = "true" }).Add();
    col.Field("EmployeeID").HeaderText("Employee ID").Width("100").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).ValidationRules(new { required = "true", number = true}).Add();
    col.Field("Freight").HeaderText("Freight").Width("100").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).Format("C2").ValidationRules(new { required = "true", min=1, max=1000 }).Add();
    col.Field("ShipCity").HeaderText("Ship City").Width("120").ValidationRules(new { required = "true" }).Add();
}).AllowPaging().EditSettings(edit => { edit.AllowAdding(true).AllowEditing(true).AllowDeleting(true).Mode(Syncfusion.EJ2.Grids.EditMode.Batch); }).Toolbar(new List<string>() { "Add", "Edit", "Delete", "Update", "Cancel" }).Render()

<script>
	class CustomAdaptor extends ej.data.UrlAdaptor {
		processResponse(data, ds, query, xhr, request, changes) {
			var original = super.processResponse(data, ds, query, xhr, request, changes);
			return original;
		}
        batchRequest(dataManager, changes, e) {
            return {
            url: dataManager.dataSource.batchUrl || dataManager.dataSource.url,
            data: JSON.stringify({
            __RequestVerificationToken: "Syncfusion",
            added: changes.addedRecords,
            changed: changes.changedRecords,
            deleted: changes.deletedRecords,
            key: e.key,
            action: 'batch',
            }),
            type: 'POST',
            };
        }
	}
	document.addEventListener("DOMContentLoaded", function () {
		let grid = document.getElementById("Grid").ej2_instances[0];
		if (grid) {
			let dataManager = new ejs.data.DataManager({
				url: "https://localhost:xxxx/Grid/UrlDataSource",
				adaptor: new CustomAdaptor(),
				insertUrl: "https://localhost:xxxx/Grid/Insert",
				updateUrl: "https://localhost:xxxx/Grid/Update",
				removeUrl: "https://localhost:xxxx/Grid/Remove",
			});
			grid.dataSource = dataManager;
		}
	});
</script>

{% endhighlight %}

{% highlight cs tabtitle="GridController.cs" %}

/// <summary>
/// Batch update (Insert, Update, and Delete) a collection of data items from the data collection.
/// </summary>
/// <param name="value">The set of information along with details about the CRUD actions to be executed from the database.</param>
/// <returns>Returns a JsonResult containing the processed data.</returns>
public JsonResult BatchUpdate(CRUDModel<Orders> value)
{
    using (SqliteConnection connection = new SqliteConnection(ConnectionString))
    {
        // Open the database connection.
        connection.Open();

        using (SqliteTransaction transaction = connection.BeginTransaction())
        {
            using (SqliteCommand command = connection.CreateCommand())
            {
                // Process updated records if any.
                if (value.changed != null && value.changed.Count > 0)
                {
                    command.CommandText = "UPDATE Orders SET CustomerID=@CustomerID, Freight=@Freight, EmployeeID=@EmployeeID, ShipCity=@ShipCity WHERE OrderID=@OrderID";
                    foreach (Orders record in value.changed)
                    {
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@CustomerID", record.CustomerID);
                        command.Parameters.AddWithValue("@Freight", record.Freight);
                        command.Parameters.AddWithValue("@EmployeeID", record.EmployeeID);
                        command.Parameters.AddWithValue("@ShipCity", record.ShipCity);
                        command.Parameters.AddWithValue("@OrderID", record.OrderID);
                        command.ExecuteNonQuery();
                    }
                }

                // Process inserted records if any.
                if (value.added != null && value.added.Count > 0)
                {
                    command.CommandText = "INSERT INTO Orders (CustomerID, Freight, ShipCity, EmployeeID) VALUES (@CustomerID, @Freight, @ShipCity, @EmployeeID)";
                    foreach (Orders record in value.added)
                    {
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@CustomerID", record.CustomerID);
                        command.Parameters.AddWithValue("@Freight", record.Freight);
                        command.Parameters.AddWithValue("@ShipCity", record.ShipCity);
                        command.Parameters.AddWithValue("@EmployeeID", record.EmployeeID);
                        command.ExecuteNonQuery();
                    }
                }

                // Process deleted records if any.
                if (value.deleted != null && value.deleted.Count > 0)
                {
                    command.CommandText = "DELETE FROM Orders WHERE OrderID=@OrderID";
                    foreach (Orders record in value.deleted)
                    {
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@OrderID", record.OrderID);
                        command.ExecuteNonQuery();
                    }
                }
            }

            // Commit the transaction.
            transaction.Commit();
        }
    }

    return Json(new { success = true, message = "Batch update successful.", data = value }, JsonRequestBehavior.AllowGet);
}


public class CRUDModel<T> where T : class
{
    public string action { get; set; }
    public string keyColumn { get; set; }
    public object key { get; set; }
    public T value { get; set; }
    public List<T> added { get; set; }
    public List<T> changed { get; set; }
    public List<T> deleted { get; set; }
    public IDictionary<string, object> @params { get; set; }
}

public class Orders
{
    [Key]
    public int? OrderID { get; set; }
    public string CustomerID { get; set; }
    public int? EmployeeID { get; set; }
    public decimal? Freight { get; set; }
    public string ShipCity { get; set; }
}

{% endhighlight %}
{% endtabs %}

![Grid bound with SQLite Server data](../images/database/db-batch.gif)