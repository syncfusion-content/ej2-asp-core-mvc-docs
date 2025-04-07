---
layout: post
title: PostgreSQL Server Data Binding Syncfusion ##Platform_Name## Grid
description: Learn how to consume data from PostgreSQL Server, bind it to Syncfusion Grid, and perform CRUD operations.
platform: ej2-asp-core-mvc
control: grid
keywords: adaptors, customadaptor, urladaptor, postgresql, remotedata 
documentation: ug
domainurl: ##DomainURL##
---

# Connecting PostgreSQL Server data in to Syncfusion ASP.NET Core Grid

This section describes how to connect and retrieve data from a PostgreSQL Server database using [Npgsql EntityFrameworkCore PostgreSQL](https://www.nuget.org/packages/Npgsql.EntityFrameworkCore.PostgreSQL) and bind it to the Syncfusion ASP.NET Core Grid.

PostgreSQL Server database can be bound to the Grid in different ways (i.e.) using [DataSource](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataSource) property, custom adaptor and remote data binding using various adaptors. In this documentation, two approaches will be examined to connect a PostgreSQL Server database to a Grid. Both the approaches have capability to handle data and CRUD operations with built-in methods as well as can be customized as per your own.

**1. Using UrlAdaptor**

The [UrlAdaptor](https://ej2.syncfusion.com/aspnetcore/documentation/grid/connecting-to-adaptors/url-adaptor) serves as the base adaptor for facilitating communication between remote data services and an UI component. It enables the remote binding of data to the Syncfusion ASP.NET Core Grid by connecting to an existing pre-configured API service linked to the PostgreSQL Server database. While the Grid supports various adaptors to fulfill this requirement, including [Web API](https://ej2.syncfusion.com/aspnetcore/documentation/grid/connecting-to-adaptors/web-api-adaptor), [ODataV4](https://ej2.syncfusion.com/aspnetcore/documentation/grid/connecting-to-adaptors/odatav4-adaptor), [UrlAdaptor](https://ej2.syncfusion.com/aspnetcore/documentation/grid/connecting-to-adaptors/url-adaptor), [Web Method](https://ej2.syncfusion.com/aspnetcore/documentation/grid/connecting-to-adaptors/web-method-adaptor), and `GraphQL`, the `UrlAdaptor` is particularly useful for the scenarios where a custom API service with unique logic for handling data and CRUD operations is in place. This approach allows for custom handling of data and CRUD operations, and the resultant data returned in the `result` and `count` format for display in the Grid.

**2. Using CustomAdaptor**

The [CustomAdaptor](https://ej2.syncfusion.com/aspnetcore/documentation/grid/connecting-to-adaptors/custom-adaptor) serves as a mediator between the UI component and the database for data binding. While the data source from the database can be directly bound to the Syncfusion ASP.NET Core Grid locally using the `DataSource` property, the `CustomAdaptor` approach is preferred as it allows for customization of both data operations and CRUD operations according to specific requirements. In this approach, for every action in the Grid, a corresponding request with action details is sent to the `CustomAdaptor`. The Grid provides predefined methods to perform data operations such as **searching**, **filtering**, **sorting**, **aggregation**, **paging** and **grouping**. Alternatively, your own custom methods can be employed to execute operations and return the data in the `result` and `count` format for displaying in the Grid. Additionally, for CRUD operations, predefined methods can be overridden to provide custom functionality. Further details on this can be found in the latter part of the documentation.

## Binding data from PostgreSQL Server using an API service

This section describes step by step process how to retrieve data from a PostgreSQL Server using an API service and bind it to the Syncfusion ASP.NET Core Grid.

### Creating an API service

To configure a server with Syncfusion ASP.NET Core Grid, follow the below steps:

1. Project Creation:

Open Visual Studio and create an ASP.NET Core project named **Grid_PostgreSQL**. To create an ASP.NET Core application, follow the documentation [link](https://learn.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-8.0&tabs=visual-studio#create-a-razor-pages-web-app) for detailed steps.

**2.** To connect a PostgreSQL Server database using the PostgreSQL driver in your application, you need to install the [Npgsql.EntityFrameworkCore.PostgreSQL ](https://www.nuget.org/packages/Npgsql.EntityFrameworkCore.PostgreSQL) NuGet package. To add **Npgsql.EntityFrameworkCore.PostgreSQL** in the app, open the NuGet package manager in Visual Studio (Tools → NuGet Package Manager → Manage NuGet Packages for Solution), search and install it.

**3.** Create an API controller (aka, GridController.cs) file under **Controllers** folder that helps to establish data communication with the Grid.

**4.** In an API controller (aka, GridController), connect to PostgreSQL Server. In the **GetOrderData()** method **NpgsqlConnection** helps to connect the PostgreSQL Server database. Next, using **NpgsqlCommand** and **NpgsqlDataAdapter** you can process the desired Npgsql query string and retrieve data from the database. The **Fill** method of the **DataAdapter** is used to populate the Npgsql data into a **DataTable** as shown in the following code snippet.

{% tabs %}
{% highlight cs tabtitle="GridController.cs" %}

using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Data;
using Syncfusion.EJ2.Base;
using Npgsql;

namespace Grid_PostgreSQL.Controllers
{
  [ApiController]
  public class GridController : ControllerBase
  {

    string ConnectionString = @"<Enter a valid connection string>";

    /// <summary>
    /// Processes the DataManager request to perform searching, filtering, sorting, and paging operations.
    /// </summary>
    /// <param name="DataManagerRequest">Contains the details of the data operation requested.</param>
    /// <returns>Returns a JSON object along with the total record count.</returns>
    [HttpPost]
    [Route("api/[controller]")]
    public object Post([FromBody] DataManagerRequest DataManagerRequest)
    {
      // Retrieve data from the data source (e.g., database).
      IQueryable<Orders> DataSource = GetOrderData().AsQueryable();

      // Get the total count of records.
      int totalRecordsCount = DataSource.Count();

      // Return data based on the request.
      return new { result = DataSource, count = totalRecordsCount };
    }

    /// <summary>
    /// Retrieves the order data from the database.
    /// </summary>
    /// <returns>Returns a list of orders fetched from the database.</returns>
    [HttpGet]
    [Route("api/[controller]")]
    public List<Orders> GetOrderData()
    {
      // Define the SQL query to retrieve all orders from the database, ordered by OrderID.
      string queryStr = "SELECT * FROM public.\"Orders\" ORDER BY \"OrderID\"";

      // Create a new NpgsqlConnection object using the connection string.
      NpgsqlConnection Connection = new(ConnectionString);

      // Open the database connection before executing the query.
      Connection.Open();

      //Using NpgsqlCommand and query create connection with database.
      NpgsqlCommand Command = new(queryStr, Connection);

      // Using NpgsqlDataAdapter to execute the NpgsqlCommand and fill the results into a DataTable. 
      NpgsqlDataAdapter DataAdapter = new(Command);

      // Create a DataTable to hold the data retrieved from the database.
      DataTable DataTable = new();

      // Using NpgsqlDataAdapter, process the query string and fill the data into the dataset.
      DataAdapter.Fill(DataTable);

      // Close the connection after executing the command.
      Connection.Close();

      // Cast the data fetched from NpgsqlDataAdapter to List.<T>
      List<Orders> dataSource = (from DataRow Data in DataTable.Rows
        select new Orders()
          {
            OrderID = Convert.ToInt32(Data["OrderID"]),
            CustomerID = Data["CustomerID"].ToString(),
            EmployeeID = Convert.ToInt32(Data["EmployeeID"]),
            ShipCity = Data["ShipCity"].ToString(),
            Freight = Convert.ToDecimal(Data["Freight"])
        }).ToList();
      return dataSource;
    }

    public class Orders
    {
      [Key]
      public int? OrderID { get; set; }
      public string? CustomerID { get; set; }
      public int? EmployeeID { get; set; }
      public decimal Freight { get; set; }
      public string? ShipCity { get; set; }
    }
  }
}

{% endhighlight %}
{% endtabs %}

**5.** Run the application and it will be hosted within the URL `https://localhost:xxxx`.

**6.** Finally, the retrieved data from PostgreSQL Server database which is in the form of list can be found in an API controller available in the URL link `https://localhost:xxxx/api/Grid`, as shown in the browser page below.

To integrate the Syncfusion Grid into your ASP.NET Core project using Visual Studio, follow these steps:

**Step 1:** Install the Syncfusion ASP.NET Core Package:

To add `ASP.NET Core` in the application, open the NuGet package manager in Visual Studio (Tools → NuGet Package Manager → Manage NuGet Packages for Solution), search for [Syncfusion.EJ2.AspNet.Core](https://www.nuget.org/packages/Syncfusion.EJ2.AspNet.Core) and install it.
Alternatively, you can install it using the following Package Manager Console command:

{% tabs %}
{% highlight C# tabtitle="Package Manager" %}

Install-Package Syncfusion.EJ2.AspNet.Core -Version {{ site.releaseversion }}

{% endhighlight %}
{% endtabs %}

**Step 2:** Add Syncfusion ASP.NET Core Tag Helper

Open `~/Pages/_ViewImports.cshtml` file and import the `Syncfusion.EJ2` TagHelper.

{% tabs %}
{% highlight C# tabtitle="~/_ViewImports.cshtml" %}

@addTagHelper *, Syncfusion.EJ2

{% endhighlight %}
{% endtabs %}

**Step 3:** Add Stylesheets and Script Resources

To include the required styles and scripts, add the following references inside the `<head>` of `~/Pages/Shared/_Layout.cshtml` file:

{% tabs %}
{% highlight cshtml tabtitle="~/_Layout.cshtml" %}

<head>
    ...
    <!-- Syncfusion ASP.NET Core control styles -->
    <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/bootstrap5.css" />
    <!-- Syncfusion ASP.NET Core control scripts -->
    <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/dist/ej2.min.js"></script>
    <!-- Include the necessary CSS files to style the Syncfusion ASP.NET Core controls-->
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

**Step 4:** Register Syncfusion Script Manager:

To ensure proper script execution, register the Syncfusion Script Manager `<ejs-scripts>` at the end of the `<body>` tag in your ASP.NET Core application as follows:

{% tabs %}
{% highlight cshtml tabtitle="~/_Layout.cshtml" %}

<body>
    ...
    <!-- Syncfusion ASP.NET Core Script Manager -->
    <ejs-scripts></ejs-scripts>
</body>

{% endhighlight %}
{% endtabs %}

**Step 5:** Add ASP.NET Core Grid:

Now, add the Syncfusion ASP.NET Core Grid tag helper in `~/Pages/Index.cshtml` page.

{% tabs %}
{% highlight cs tabtitle="GridController.cs" %}

using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Data;
using Syncfusion.EJ2.Base;
using Npgsql;

namespace Grid_PostgreSQL.Controllers
{
  [ApiController]
  public class GridController : ControllerBase
  {

    string ConnectionString = @"<Enter a valid connection string>";

    /// <summary>
    /// Processes the DataManager request to perform searching, filtering, sorting, and paging operations.
    /// </summary>
    /// <param name="DataManagerRequest">Contains the details of the data operation requested.</param>
    /// <returns>Returns a JSON object along with the total record count.</returns>
    [HttpPost]
    [Route("api/[controller]")]
    public object Post([FromBody] DataManagerRequest DataManagerRequest)
    {
      // Retrieve data from the data source (e.g., database).
      IQueryable<Orders> DataSource = GetOrderData().AsQueryable();

      // Get the total count of records.
      int totalRecordsCount = DataSource.Count();

      // Return data based on the request.
      return new { result = DataSource, count = totalRecordsCount };
    }

    /// <summary>
    /// Retrieves the order data from the database.
    /// </summary>
    /// <returns>Returns a list of orders fetched from the database.</returns>
    [HttpGet]
    [Route("api/[controller]")]
    public List<Orders> GetOrderData()
    {
      // Define the SQL query to retrieve all orders from the database, ordered by OrderID.
      string queryStr = "SELECT * FROM public.\"Orders\" ORDER BY \"OrderID\"";

      // Create a new NpgsqlConnection object using the connection string.
      NpgsqlConnection Connection = new(ConnectionString);

      // Open the database connection before executing the query.
      Connection.Open();

      //Using NpgsqlCommand and query create connection with database.
      NpgsqlCommand Command = new(queryStr, Connection);

      // Using NpgsqlDataAdapter to execute the NpgsqlCommand and fill the results into a DataTable. 
      NpgsqlDataAdapter DataAdapter = new(Command);

      // Create a DataTable to hold the data retrieved from the database.
      DataTable DataTable = new();

      // Using NpgsqlDataAdapter, process the query string and fill the data into the dataset.
      DataAdapter.Fill(DataTable);

      // Close the connection after executing the command.
      Connection.Close();

      // Cast the data fetched from NpgsqlDataAdapter to List.<T>
      List<Orders> dataSource = (from DataRow Data in DataTable.Rows
        select new Orders()
          {
            OrderID = Convert.ToInt32(Data["OrderID"]),
            CustomerID = Data["CustomerID"].ToString(),
            EmployeeID = Convert.ToInt32(Data["EmployeeID"]),
            ShipCity = Data["ShipCity"].ToString(),
            Freight = Convert.ToDecimal(Data["Freight"])
        }).ToList();
      return dataSource;
    }

    public class Orders
    {
      [Key]
      public int? OrderID { get; set; }
      public string? CustomerID { get; set; }
      public int? EmployeeID { get; set; }
      public decimal Freight { get; set; }
      public string? ShipCity { get; set; }
    }
  }
}

{% endhighlight %}

{% highlight cshtml tabtitle="Index.cshtml" %}

<ejs-grid id="Grid" height="348">
    <e-data-manager url="https://localhost:xxxx/api/Grid" adaptor="UrlAdaptor"></e-data-manager> // Replace `xxxx` with your actual localhost port number.
    <e-grid-columns>
        <e-grid-column field='OrderID' headerText='Order ID' width='120' textAlign='Right'></e-grid-column>
        <e-grid-column field='CustomerID' headerText='Customer ID' width='160'></e-grid-column>
        <e-grid-column field='EmployeeID' headerText='Employee ID' width='160' textAlign='Right'></e-grid-column>
        <e-grid-column field='Freight' headerText='Freight' format="C2" width='160' textAlign='Right'></e-grid-column>
        <e-grid-column field='ShipCity' headerText='Ship City' width='150'></e-grid-column>
    </e-grid-columns>
</ejs-grid>

{% endhighlight %}
{% endtabs %}

**Step 6:** Configure the server:

In the `Program.cs` file of your project, configure the server to serve static files and handle API requests by adding the following code:

```cs
builder.Services.AddRazorPages();
builder.Services.AddControllers();

var app = builder.Build();

app.MapRazorPages();
app.MapControllers();
```
**Step 7:** Run the Project:

Run the project in Visual Studio, and the Syncfusion ASP.NET Core Grid will successfully fetch data from the API service.

> * The Syncfusion ASP.NET Core Grid provides built-in support for handling various data operations such as searching, sorting, filtering, aggregate and paging on the server-side. These operations can be handled using methods such as `PerformSearching`, `PerformFiltering`, `PerformSorting`, `PerformTake` and `PerformSkip` available in the [Syncfusion.EJ2.AspNet.Core](https://www.nuget.org/packages/Syncfusion.EJ2.AspNet.Core) package. Let’s explore how to manage these data operations using the `UrlAdaptor`.
> * In an API service project, add `Syncfusion.EJ2.AspNet.Core` by opening the NuGet package manager in Visual Studio (Tools → NuGet Package Manager → Manage NuGet Packages for Solution), search and install it.
> * To access `DataManagerRequest` and `QueryableOperation`, import [Syncfusion.EJ2.Base](https://www.npmjs.com/package/@syncfusion/ej2-base) in `GridController.cs` file.
> * In the `UrlAdaptor` configuration, the properties of the `DataManager` object are encapsulated within an object named **value**. To access the `DataManager` properties, a dedicated class is created, representing the **value** object.
    ```cs
    // Model for handling data manager requests.
    public class DataManager
    {
        public required DataManagerRequest Value { get; set; }
    }
    ```

## Handling searching operation

To handle searching operation, ensure that your API endpoint supports custom searching criteria. Implement the searching logic on the server-side using the `PerformSearching` method from the `QueryableOperation` class. This allows the custom data source to undergo searching based on the criteria specified in the incoming `DataManagerRequest` object.

{% tabs %}
{% highlight cs tabtitle="GridController.cs" %}

/// <summary>
/// Processes the DataManager request to perform searching operation.
/// </summary>
/// <param name="DataManagerRequest">Contains the details of the data operation requested.</param>
/// <returns>Returns a JSON object with the searched data along with the total record count.</returns>
[HttpPost]
[Route("api/[controller]")]
public object Post([FromBody] DataManagerRequest DataManagerRequest)
{
  // Retrieve data from the data source (e.g., database).
  IQueryable<Orders> DataSource = GetOrderData().AsQueryable();

  // Initialize QueryableOperation instance.
  QueryableOperation queryableOperation = new QueryableOperation();

  // Handling searching operation.
  if (DataManagerRequest.Search != null && DataManagerRequest.Search.Count > 0)
  {
    DataSource = queryableOperation.PerformSearching(DataSource, DataManagerRequest.Search);
    //Add custom logic here if needed and remove above method.
  }

  // Get the total count of records.
  int totalRecordsCount = DataSource.Count();

  // Return data based on the request.
  return new { result = DataSource, count = totalRecordsCount };
}

{% endhighlight %}

{% highlight cshtml tabtitle="Index.cshtml" %}

<ejs-grid id="Grid" toolbar="@(new List<string>() { "Search" })" height="348">
    <e-data-manager url="https://localhost:xxxx/api/Grid" adaptor="UrlAdaptor"></e-data-manager> // Replace `xxxx` with your actual localhost port number.
    <e-grid-columns>
        <e-grid-column field='OrderID' headerText='Order ID' width='120' textAlign='Right'></e-grid-column>
        <e-grid-column field='CustomerID' headerText='Customer ID' width='160'></e-grid-column>
        <e-grid-column field='EmployeeID' headerText='Employee ID' width='160' textAlign='Right'></e-grid-column>
        <e-grid-column field='Freight' headerText='Freight' format="C2" width='160' textAlign='Right'></e-grid-column>
        <e-grid-column field='ShipCity' headerText='Ship City' width='150'></e-grid-column>
    </e-grid-columns>
</ejs-grid>

{% endhighlight %}
{% endtabs %}

## Handling filtering operation

To handle filtering operation, ensure that your API endpoint supports custom filtering criteria. Implement the filtering logic on the server-side using the `PerformFiltering` method from the `QueryableOperation` class. This allows the custom data source to undergo filtering based on the criteria specified in the incoming `DataManagerRequest` object.

{% tabs %}
{% highlight cs tabtitle="GridController.cs" %}

[HttpPost]
public object Post([FromBody] DataManagerRequest DataManagerRequest)
{
  // Retrieve data from the data source (e.g., database).
  IQueryable<OrdersDetails> DataSource = GetOrderData().AsQueryable();

  QueryableOperation queryableOperation = new QueryableOperation(); // Initialize QueryableOperation instance.

  if (DataManagerRequest.Where != null && DataManagerRequest.Where.Count > 0)
  {
    // Handling filtering operation.
    foreach (var condition in DataManagerRequest.Where)
    {
      foreach (var predicate in condition.predicates)
      {
        DataSource = queryableOperation.PerformFiltering(DataSource, DataManagerRequest.Where, predicate.Operator);
      }
    }
  }
  // Get the total records count.
  int totalRecordsCount = DataSource.Count();

  // Return data based on the request.
  return new { result = DataSource, count = totalRecordsCount };
}

{% endhighlight %}

{% highlight cshtml tabtitle="Index.cshtml" %}

<ejs-grid id="Grid" allowFiltering="true" height="348">
  <e-data-manager url="https://localhost:xxxx/api/Grid" adaptor="UrlAdaptor"></e-data-manager> // Replace `xxxx` with your actual localhost port number.
  <e-grid-columns>
    <e-grid-column field='OrderID' headerText='Order ID' width='120' textAlign='Right'></e-grid-column>
    <e-grid-column field='CustomerID' headerText='Customer ID' width='160'></e-grid-column>
    <e-grid-column field='EmployeeID' headerText='Employee ID' width='160' textAlign='Right'></e-grid-column>
    <e-grid-column field='Freight' headerText='Freight' format="C2" width='160' textAlign='Right'></e-grid-column>
    <e-grid-column field='ShipCity' headerText='Ship City' width='150'></e-grid-column>
  </e-grid-columns>
</ejs-grid>

{% endhighlight %}
{% endtabs %}

## Handling sorting operation

To handle sorting operation, ensure that your API endpoint supports custom sorting criteria. Implement the sorting logic on the server-side using the `PerformSorting` method from the `QueryableOperation` class. This allows the custom data source to undergo sorting based on the criteria specified in the incoming `DataManagerRequest` object.

{% tabs %}
{% highlight cs tabtitle="GridController.cs" %}

[HttpPost]
public object Post([FromBody] DataManagerRequest DataManagerRequest)
{
  // Retrieve data from the data source (e.g., database).
  IQueryable<OrdersDetails> DataSource = GetOrderData().AsQueryable();

  QueryableOperation queryableOperation = new QueryableOperation(); // Initialize QueryableOperation instance.

  // Handling sorting operation.
  if (DataManagerRequest.Sorted != null && DataManagerRequest.Sorted.Count > 0)
  {
    DataSource = queryableOperation.PerformSorting(DataSource, DataManagerRequest.Sorted);
  }

  // Get the total count of records.
  int totalRecordsCount = DataSource.Count();

  // Return data based on the request.
  return new { result = DataSource, count = totalRecordsCount };
}

{% endhighlight %}

{% highlight cshtml tabtitle="Index.cshtml" %}

<ejs-grid id="Grid" allowSorting="true" height="348">
  <e-data-manager url="https://localhost:xxxx/api/Grid" adaptor="UrlAdaptor"></e-data-manager> // Replace `xxxx` with your actual localhost port number.
  <e-grid-columns>
        <e-grid-column field='OrderID' headerText='Order ID' width='120' textAlign='Right'></e-grid-column>
        <e-grid-column field='CustomerID' headerText='Customer ID' width='160'></e-grid-column>
        <e-grid-column field='EmployeeID' headerText='Employee ID' width='160' textAlign='Right'></e-grid-column>
        <e-grid-column field='Freight' headerText='Freight' format="C2" width='160' textAlign='Right'></e-grid-column>
        <e-grid-column field='ShipCity' headerText='Ship City' width='150'></e-grid-column>
  </e-grid-columns>
</ejs-grid>

{% endhighlight %}
{% endtabs %}

## Handling paging operation

To handle paging operation, ensure that your API endpoint supports custom paging criteria. Implement the paging logic on the server-side using the `PerformTake` and `PerformSkip`method from the `QueryableOperation` class. This allows the custom data source to undergo paging based on the criteria specified in the incoming `DataManagerRequest` object.

{% tabs %}
{% highlight cs tabtitle="GridController.cs" %}

[HttpPost]
public object Post([FromBody] DataManagerRequest DataManagerRequest)
{
  // Retrieve data from the data source (e.g., database).
  IQueryable<OrdersDetails> DataSource = GetOrderData().AsQueryable();

  // Get the total records count.
  int totalRecordsCount = DataSource.Count();

  QueryableOperation queryableOperation = new QueryableOperation(); // Initialize QueryableOperation instance.

  // Handling paging operation.
  if (DataManagerRequest.Skip != 0)
  {
    DataSource = queryableOperation.PerformSkip(DataSource, DataManagerRequest.Skip);
  }
  if (DataManagerRequest.Take != 0)
  {
    DataSource = queryableOperation.PerformTake(DataSource, DataManagerRequest.Take);
  }
  // Return data based on the request.
  return new { result = DataSource, count = totalRecordsCount };
}

{% endhighlight %}

{% highlight cshtml tabtitle="Index.cshtml" %}

<ejs-grid id="Grid" allowPaging="true" height="348">
  <e-data-manager url="https://localhost:xxxx/api/Grid" adaptor="UrlAdaptor"></e-data-manager> // Replace `xxxx` with your actual localhost port number.
  <e-grid-columns>
        <e-grid-column field='OrderID' headerText='Order ID' width='120' textAlign='Right'></e-grid-column>
        <e-grid-column field='CustomerID' headerText='Customer ID' width='160'></e-grid-column>
        <e-grid-column field='EmployeeID' headerText='Employee ID' width='160' textAlign='Right'></e-grid-column>
        <e-grid-column field='Freight' headerText='Freight' format="C2" width='160' textAlign='Right'></e-grid-column>
        <e-grid-column field='ShipCity' headerText='Ship City' width='150'></e-grid-column>
  </e-grid-columns>
</ejs-grid>

{% endhighlight %}
{% endtabs %}

### Handling CRUD operations

The Syncfusion ASP.NET Core Grid seamlessly integrates CRUD (Create, Read, Update, and Delete) operations with server-side controller actions through specific properties: `insertUrl`, `removeUrl`, `updateUrl` and `batchUrl`. These properties enable the Grid to communicate with the data service for every Grid action, facilitating server-side operations.

**CRUD Operations Mapping**

CRUD operations within the Grid can be mapped to server-side controller actions using specific properties:

1. **insertUrl**: Specifies the URL for inserting new data.
2. **removeUrl**: Specifies the URL for removing existing data.
3. **updateUrl**: Specifies the URL for updating existing data.
4. **batchUrl**: Specifies the URL for batch editing.

To enable editing in ASP.NET Core Grid, refer to the editing [documentation](https://ej2.syncfusion.com/aspnetcore/documentation/grid/editing/edit). In the below example, the inline edit `mode` is enabled and [toolbar](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Toolbar) property is configured to display toolbar items for editing purposes.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}

<ejs-grid id="Grid" toolbar="@(new List<string>() { "Add", "Edit", "Delete", "Update", "Cancel" })">
    <e-data-manager url='https://localhost:xxxx/api/Grid'
                        insertUrl='https://localhost:xxxx/api/Grid/Insert'
                        updateUrl='https://localhost:xxxx/api/Grid/Update'
                        removeUrl='https://localhost:xxxx/api/Grid/Remove'
                        adaptor="UrlAdaptor"> // Replace `xxxx` with your actual localhost port number.
    </e-data-manager>
    <e-grid-editSettings allowAdding="true" allowDeleting="true" allowEditing="true" mode="Normal"></e-grid-editSettings>
    <e-grid-columns>
        <e-grid-column field='OrderID' headerText='Order ID' width='120' textAlign='Right' isPrimaryKey=true></e-grid-column>
        <e-grid-column field='CustomerID' headerText='Customer ID' width='160'></e-grid-column>
        <e-grid-column field='EmployeeID' headerText='Employee ID' width='160' textAlign='Right'></e-grid-column>
        <e-grid-column field='Freight' headerText='Freight' format="C2" width='160' textAlign='Right'></e-grid-column>
        <e-grid-column field='ShipCity' headerText='Ship City' width='150'></e-grid-column>
    </e-grid-columns>
</ejs-grid>

{% endhighlight %}
{% endtabs %}

> * Normal/Inline editing is the default edit `mode` for the Grid. To enable CRUD operations, ensure that the [isPrimaryKey](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_IsPrimaryKey) property is set to **true** for a specific Grid column, ensuring that its value is unique.
> * If database has an auto generated column, ensure to define [isIdentity](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_IsIdentity) property of Grid column to disable them during adding or editing operations.
The below class is used to structure data sent during CRUD operations.

```cs
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
```

**Insert Operation:**

To insert a new row, simply click the **Add** toolbar button. The new record edit form will be displayed as shown below. Upon clicking the **Update** toolbar button, record will inserted into the **Orders** table by calling the following **POST** method of an API.
**Insert Operation:**

To insert a new row, simply click the **Add** toolbar button. The new record edit form will be displayed as shown below. Upon clicking the **Update** toolbar button, the record will be inserted into the **Orders** table by calling the following **POST** method of an API.

{% tabs %}
{% highlight cs tabtitle="GridController.cs" %}

/// <summary>
/// Inserts a new data item into the data collection.
/// </summary>
/// <param name="newRecord">It contains the new record detail which is need to be inserted.</param>
/// <returns>Returns void.</returns>
[HttpPost]
[Route("api/[controller]/Insert")]
public void Insert([FromBody] CRUDModel<Orders> value)
{
  // Create query to insert the specific into the database by accessing its properties.
  string queryStr = $"Insert into \"Orders\" (\"CustomerID\", \"Freight\", \"ShipCity\", \"EmployeeID\") values('{value.value.CustomerID}',{value.value.Freight},'{value.value.ShipCity}','{value.value.EmployeeID}')";

  // Create a new NpgsqlConnection object using the connection string.
  NpgsqlConnection Connection = new NpgsqlConnection(ConnectionString);

  // Open the database connection before executing the query.
  Connection.Open();

  // Execute the Npgsql command.
  NpgsqlCommand Command = new NpgsqlCommand(queryStr, Connection);

  // Execute this code to reflect the changes into the database.
  Command.ExecuteNonQuery();

  // Close the database connection after executing the command.
  Connection.Close();

  // Add custom logic here if needed and remove the above method.
}

public class CRUDModel<T> where T : class
{
  public string? action { get; set; }
  public string? keyColumn { get; set; }
  public object? key { get; set; }
  public T? value { get; set; }
  public List<T>? added { get; set; }
  public List<T>? changed { get; set; }
  public List<T>? deleted { get; set; }
  public IDictionary<string, object>? @params { get; set; }
}

{% endhighlight %}
{% endtabs %}

**Update Operation:**

To edit a row, first select desired row and click the **Edit** toolbar button. The edit form will be displayed and proceed to modify any column value as per your requirement. Clicking the **Update** toolbar button will update the edit record in the **Orders** table by involving the following **Post** method of an API.

{% tabs %}
{% highlight cs tabtitle="GridController.cs" %}

/// <summary>
/// Update a existing data item from the data collection.
/// </summary>
/// <param name="Order">It contains the updated record detail which is need to be updated.</param>
/// <returns>Returns void.</returns>
[HttpPost]
[Route("api/[controller]/Update")]
public void Update([FromBody] CRUDModel<Orders> value)
{
  // Create query to update the changes into the database by accessing its properties.
  string queryStr = $"Update \"Orders\" set \"CustomerID\"='{value.value.CustomerID}', \"Freight\"={value.value.Freight},\"EmployeeID\"={value.value.EmployeeID},\"ShipCity\"='{value.value.ShipCity}' where \"OrderID\"={value.value.OrderID}";

  // Create a new NpgsqlConnection object using the connection string.
  NpgsqlConnection Connection = new NpgsqlConnection(ConnectionString);

  // Open the database connection before executing the query.
  Connection.Open();

  // Execute the Npgsql command.
  NpgsqlCommand Command = new NpgsqlCommand(queryStr, Connection);

  // Execute this code to reflect the changes into the database.
  Command.ExecuteNonQuery();

  // Close the database connection after executing the command.
  Connection.Close();

  // Add custom logic here if needed and remove the above method.
}

public class CRUDModel<T> where T : class
{
  public string? action { get; set; }
  public string? keyColumn { get; set; }
  public object? key { get; set; }
  public T? value { get; set; }
  public List<T>? added { get; set; }
  public List<T>? changed { get; set; }
  public List<T>? deleted { get; set; }
  public IDictionary<string, object>? @params { get; set; }
}

{% endhighlight %}
{% endtabs %}

**Delete Operation:**

To delete a row, simply select the desired row and click the **Delete** toolbar button. This action will trigger a **DELETE** request to an API, containing the primary key value of the selected record. As a result corresponding record will be removed from the **Orders** table. 

{% tabs %}
{% highlight cs tabtitle="GridController.cs" %}

/// <summary>
/// Remove a specific data item from the data collection.
/// </summary>
/// <param name="value">It contains the specific record detail which is need to be removed.</param>
/// <return>Returns void.</return>
[HttpPost]
[Route("api/[controller]/Remove")]
public void Remove([FromBody] CRUDModel<Orders> value)
{
  //Create query to remove the specific from database by passing the primary key column value.
  string queryStr = $"DELETE FROM \"Orders\" WHERE \"OrderID\" = {value.key}";

  // Create a new NpgsqlConnection object using the connection string.
  NpgsqlConnection Connection = new NpgsqlConnection(ConnectionString);

  // Open the database connection before executing the query.
  Connection.Open();

  // Execute the Npgsql command.
  NpgsqlCommand Command = new NpgsqlCommand(queryStr, Connection);

  //Execute this code to reflect the changes into the database.
  Command.ExecuteNonQuery();

  // Close the database connection after executing the command.
  Connection.Close();

  //Add custom logic here if needed and remove above method.
}

public class CRUDModel<T> where T : class
{
  public string? action { get; set; }
  public string? keyColumn { get; set; }
  public object? key { get; set; }
  public T? value { get; set; }
  public List<T>? added { get; set; }
  public List<T>? changed { get; set; }
  public List<T>? deleted { get; set; }
  public IDictionary<string, object>? @params { get; set; }
}

{% endhighlight %}
{% endtabs %}

**Batch Operation:**

To perform batch operation, define the edit `mode` as **Batch** and specify the `batchUrl` property in the `DataManager`. Use the **Add** toolbar button to insert new row in batch editing mode. To edit a cell, double-click the desired cell and update the value as required. To delete a record, simply select the record and press the **Delete** toolbar button. Now, all CRUD operations will be executed in batch editing mode. Clicking the **Update** toolbar button will update the newly added, edited, or deleted records from the **Orders** table using a single API **POST** request.

{% tabs %}
{% highlight cs tabtitle="GridController.cs" %}

/// <summary>
/// Batch update (Insert, Update, and Delete) a collection of data items from the data collection.
/// </summary>
/// <param name="CRUDModel<T>">The set of information along with details about the CRUD actions to be executed from the database.</param>
/// <returns>Returns void.</returns>
[HttpPost]
[Route("api/[controller]/BatchUpdate")]
public IActionResult BatchUpdate([FromBody] CRUDModel<Orders> value)
{
  if (value.changed != null && value.changed.Count > 0)
  {
    foreach (Orders Record in (IEnumerable<Orders>)value.changed)
    {
      // Create query to update the changes into the database by accessing its properties.
      string queryStr = $"Update \"Orders\" set \"CustomerID\"='{Record.CustomerID}', \"Freight\"={Record.Freight},\"EmployeeID\"={Record.EmployeeID},\"ShipCity\"='{Record.ShipCity}' where \"OrderID\"={Record.OrderID}";

      // Create a new NpgsqlConnection object using the connection string.
      NpgsqlConnection Connection = new NpgsqlConnection(ConnectionString);

      // Open the database connection before executing the query.
      Connection.Open();

      // Execute the Npgsql command.
      NpgsqlCommand Command = new NpgsqlCommand(queryStr, Connection);

      // Execute this code to reflect the changes into the database.
      Command.ExecuteNonQuery();

      // Close the database connection after executing the command.
      Connection.Close();

      // Add custom logic here if needed and remove the above method.
    }
  }
  if (value.added != null && value.added.Count > 0)
  {
    foreach (Orders Record in (IEnumerable<Orders>)value.added)
    {
      // Create query to insert the specific into the database by accessing its properties.
      string queryStr = $"Insert into \"Orders\" (\"CustomerID\", \"Freight\", \"ShipCity\", \"EmployeeID\") values('{Record.CustomerID}',{Record.Freight},'{Record.ShipCity}','{Record.EmployeeID}')";

      // Create a new NpgsqlConnection object using the connection string.
      NpgsqlConnection Connection = new NpgsqlConnection(ConnectionString);

      // Open the database connection before executing the query.
      Connection.Open();

      // Execute the Npgsql command.
      NpgsqlCommand Command = new NpgsqlCommand(queryStr, Connection);

      // Execute this code to reflect the changes into the database.
      Command.ExecuteNonQuery();

      // Close the database connection after executing the command.
      Connection.Close();

      // Add custom logic here if needed and remove the above method.
    }
  }
  if (value.deleted != null && value.deleted.Count > 0)
  {
    foreach (Orders Record in (IEnumerable<Orders>)value.deleted)
    {
      //Create query to remove the specific from database by passing the primary key column value.
      string queryStr = $"DELETE FROM \"Orders\" WHERE \"OrderID\" = {Record.OrderID}";

      // Create a new NpgsqlConnection object using the connection string.
      NpgsqlConnection Connection = new NpgsqlConnection(ConnectionString);

      // Open the database connection before executing the query.
      Connection.Open();

      // Execute the Npgsql command.
      NpgsqlCommand Command = new NpgsqlCommand(queryStr, Connection);

      //Execute this code to reflect the changes into the database.
      Command.ExecuteNonQuery();

      // Close the database connection after executing the command.
      Connection.Close();

      //Add custom logic here if needed and remove above method.
    }
  }
  return new JsonResult(value);
}

public class CRUDModel<T> where T : class
{
  public string? action { get; set; }
  public string? keyColumn { get; set; }
  public object? key { get; set; }
  public T? value { get; set; }
  public List<T>? added { get; set; }
  public List<T>? changed { get; set; }
  public List<T>? deleted { get; set; }
  public IDictionary<string, object>? @params { get; set; }
}

{% endhighlight %}
{% endtabs %}

When you run the application, the resultant Syncfusion Grid will look like this

![Grid bound with PostgreSQL Server data](.../images/database/db-crud.gif)

## Binding data from PostgreSQL Server using CustomAdaptor

This section describes step by step process how to retrieve data from a PostgreSQL Server using `CustomAdaptor` and bind it to the Grid.

**1.** To create a simple Grid, the procedure is explained in the above-mentioned topic on [Connecting Syncfusion ASP.NET Core Grid to an API service](##connecting-syncfusion-aspnet-core-grid-to-an-api-service)

**2.** To connect a PostgreSQL Server database using the PostgreSQL driver in your application, you need to install the [Npgsql.EntityFrameworkCore.PostgreSQL](https://www.nuget.org/packages/Npgsql.EntityFrameworkCore.PostgreSQL) NuGet package. To add **Npgsql.EntityFrameworkCore.PostgreSQL** in the app, open the NuGet package manager in Visual Studio (Tools → NuGet Package Manager → Manage NuGet Packages for Solution), search and install it.

**3.** If you intend to inject your own service into the `CustomAdaptor` and utilize it, you can achieve this as follows:

  * Create a `CustomAdaptor` that extends the `UrlAdaptor` class.
  * Override the `processResponse` method to process server responses.

**4.** Within the `processResponse` method of `CustomAdaptor`, fetch data by calling the **GetOrderData** method.

  * In this `GetOrderData` method, the PostgreSQL Server database data is fetch by using the **NpgsqlDataAdapter** class.

  * Employ the **Fill** method of the **DataAdapter** to populate a **DataSet** with the results of the `Select` command of the **DataAdapter**, followed by conversion of the **DataSet** into a List.

  * Finally, return the response as a `result` and `count` pair object in the `processResponse` method to bind the data to the Grid.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}

<ejs-grid id="Grid" height="348">
    <e-grid-columns>
        <e-grid-column field='OrderID' headerText='Order ID' width='120' textAlign='Right'></e-grid-column>
        <e-grid-column field='CustomerID' headerText='Customer ID' width='160'></e-grid-column>
        <e-grid-column field='EmployeeID' headerText='Employee ID' width='160' textAlign='Right'></e-grid-column>
        <e-grid-column field='Freight' headerText='Freight' format="C2" width='160' textAlign='Right'></e-grid-column>
        <e-grid-column field='ShipCity' headerText='Ship City' width='150'></e-grid-column>
    </e-grid-columns>
</ejs-grid>

<script>
	class CustomAdaptor extends ej.data.UrlAdaptor {
		processResponse(data, ds, query, xhr, request, changes) {
			const original = super.processResponse(data, ds, query, xhr, request, changes);
			return original;
		}
	}
	document.addEventListener("DOMContentLoaded", function () {
		let grid = document.getElementById("Grid").ej2_instances[0];
		if (grid) {
			let dataManager = new ejs.data.DataManager({
				url: "https://localhost:xxxx/api/Grid", // Replace xxxx with your actual port number.
				adaptor: new CustomAdaptor(),
			});
			grid.dataSource = dataManager;
		}
	});
</script>

{% endhighlight %}

{% highlight cs tabtitle="GridController.cs" %}

using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Data;
using Syncfusion.EJ2.Base;
using Npgsql;

namespace Grid_PostgreSQL.Controllers
{
  [ApiController]
  public class GridController : ControllerBase
  {

    string ConnectionString = @"<Enter a valid connection string>";

    /// <summary>
    /// Processes the DataManager request to perform searching, filtering, sorting, and paging operations.
    /// </summary>
    /// <param name="DataManagerRequest">Contains the details of the data operation requested.</param>
    /// <returns>Returns a JSON object along with the total record count.</returns>
    [HttpPost]
    [Route("api/[controller]")]
    public object Post([FromBody] DataManagerRequest DataManagerRequest)
    {
      // Retrieve data from the data source (e.g., database).
      IQueryable<Orders> DataSource = GetOrderData().AsQueryable();

      // Get the total count of records.
      int totalRecordsCount = DataSource.Count();

      // Return data based on the request.
      return new { result = DataSource, count = totalRecordsCount };
    }

    /// <summary>
    /// Retrieves the order data from the database.
    /// </summary>
    /// <returns>Returns a list of orders fetched from the database.</returns>
    [HttpGet]
    [Route("api/[controller]")]
    public List<Orders> GetOrderData()
    {
      // Define the SQL query to retrieve all orders from the database, ordered by OrderID.
      string queryStr = "SELECT * FROM public.\"Orders\" ORDER BY \"OrderID\"";

      // Create a new NpgsqlConnection object using the connection string.
      NpgsqlConnection Connection = new(ConnectionString);

      // Open the database connection before executing the query.
      Connection.Open();

      //Using NpgsqlCommand and query create connection with database.
      NpgsqlCommand Command = new(queryStr, Connection);

      // Using NpgsqlDataAdapter to execute the NpgsqlCommand and fill the results into a DataTable. 
      NpgsqlDataAdapter DataAdapter = new(Command);

      // Create a DataTable to hold the data retrieved from the database.
      DataTable DataTable = new();

      // Using NpgsqlDataAdapter, process the query string and fill the data into the dataset.
      DataAdapter.Fill(DataTable);

      // Close the connection after executing the command.
      Connection.Close();

      // Cast the data fetched from NpgsqlDataAdapter to List.<T>
      List<Orders> dataSource = (from DataRow Data in DataTable.Rows
        select new Orders()
          {
            OrderID = Convert.ToInt32(Data["OrderID"]),
            CustomerID = Data["CustomerID"].ToString(),
            EmployeeID = Convert.ToInt32(Data["EmployeeID"]),
            ShipCity = Data["ShipCity"].ToString(),
            Freight = Convert.ToDecimal(Data["Freight"])
        }).ToList();
      return dataSource;
    }

    public class Orders
    {
      [Key]
      public int? OrderID { get; set; }
      public string? CustomerID { get; set; }
      public int? EmployeeID { get; set; }
      public decimal Freight { get; set; }
      public string? ShipCity { get; set; }
    }
  }
}


{% endhighlight %}
{% endtabs %}

> * The `DataManagerRequest` encompasses details about the Grid actions such as searching, filtering, sorting, aggregate, paging and grouping.

### Handling searching operation

When utilizing the `CustomAdaptor` in ASP.NET Core, managing the searching operation involves overriding the `processResponse` method of the `UrlAdaptor` class.

In the code example below, searching a custom data source can be accomplished by employing the built-in `PerformSearching` method of the `QueryableOperation` class. Alternatively, you can implement your own method for searching operation and bind the resultant data to the Syncfusion ASP.NET Core Grid.

{% tabs %}
{% highlight cs tabtitle="GridController.cs" %}

/// <summary>
/// Processes the DataManager request to perform searching operation.
/// </summary>
/// <param name="DataManagerRequest">Contains the details of the data operation requested.</param>
/// <returns>Returns a JSON object with the searched data along with the total record count.</returns>
[HttpPost]
[Route("api/[controller]")]
public object Post([FromBody] DataManagerRequest DataManagerRequest)
{
  // Retrieve data from the data source (e.g., database).
  IQueryable<Orders> DataSource = GetOrderData().AsQueryable();

  // Initialize QueryableOperation instance.
  QueryableOperation queryableOperation = new QueryableOperation();

  // Handling searching operation.
  if (DataManagerRequest.Search != null && DataManagerRequest.Search.Count > 0)
  {
    DataSource = queryableOperation.PerformSearching(DataSource, DataManagerRequest.Search);
    //Add custom logic here if needed and remove above method.
  }

  // Get the total count of records.
  int totalRecordsCount = DataSource.Count();

  // Return data based on the request.
  return new { result = DataSource, count = totalRecordsCount };
}

{% endhighlight %}

{% highlight cshtml tabtitle="Index.cshtml" %}

<ejs-grid id="Grid" toolbar="@(new List<string>() { "Search" })" height="348">
    <e-data-manager url="https://localhost:xxxx/api/Grid" adaptor="UrlAdaptor"></e-data-manager> // Replace `xxxx` with your actual localhost port number.
    <e-grid-columns>
        <e-grid-column field='OrderID' headerText='Order ID' width='120' textAlign='Right'></e-grid-column>
        <e-grid-column field='CustomerID' headerText='Customer ID' width='160'></e-grid-column>
        <e-grid-column field='EmployeeID' headerText='Employee ID' width='160' textAlign='Right'></e-grid-column>
        <e-grid-column field='Freight' headerText='Freight' format="C2" width='160' textAlign='Right'></e-grid-column>
        <e-grid-column field='ShipCity' headerText='Ship City' width='150'></e-grid-column>
    </e-grid-columns>
</ejs-grid>
<script>
	class CustomAdaptor extends ej.data.UrlAdaptor {
		processResponse(data, ds, query, xhr, request, changes) {
			const original = super.processResponse(data, ds, query, xhr, request, changes);
			return original;
		}
	}
	document.addEventListener("DOMContentLoaded", function () {
		let grid = document.getElementById("Grid").ej2_instances[0];
		if (grid) {
			let dataManager = new ejs.data.DataManager({
				url: "https://localhost:xxxx/api/Grid", // Replace xxxx with your actual port number.
				adaptor: new CustomAdaptor(),
			});
			grid.dataSource = dataManager;
		}
	});
</script>

{% endhighlight %}
{% endtabs %}

### Handling filtering operation

When utilizing the `CustomAdaptor` in ASP.NET Core, managing the filtering operation involves overriding the `processResponse` method of the `UrlAdaptor` class.

In the code example below, filtering a custom data source can be achieved by utilizing the built-in `PerformFiltering` method of the `QueryableOperation` class. Alternatively, you can implement your own method for filtering operation and bind the resulting data to the Syncfusion ASP.NET Core Grid.

{% tabs %}
{% highlight cs tabtitle="GridController.cs" %}

/// <summary>
/// Processes the DataManager request to perform filtering operation.
/// </summary>
/// <param name="DataManagerRequest">Contains the details of the data operation requested.</param>
/// <returns>Returns a JSON object with the filtered data along with the total record count.</returns>
[HttpPost]
public object Post(DataManagerRequest DataManagerRequest)
{
  // Retrieve data from the data source (e.g., database).
  IQueryable<Orders> DataSource = GetOrderData().AsQueryable();

  // Initialize QueryableOperation instance.
  QueryableOperation queryableOperation = new QueryableOperation();

  // Handling filtering operation.
  if (DataManagerRequest.Where != null && DataManagerRequest.Where.Count > 0)
  {
    foreach (WhereFilter condition in DataManagerRequest.Where)
    {
      foreach (WhereFilter predicate in condition.predicates)
      {
        DataSource = queryableOperation.PerformFiltering(DataSource, DataManagerRequest.Where, predicate.Operator);
        //Add custom logic here if needed and remove above method.
      }
    }
  }

  // Get the total count of records.
  int totalRecordsCount = DataSource.Count();

  // Return data based on the request.
  return new { result = DataSource, count = totalRecordsCount };
}

{% endhighlight %}

{% highlight cshtml tabtitle="Index.cshtml" %}

<ejs-grid id="Grid" allowFiltering="true" height="348">
  <e-data-manager url="https://localhost:xxxx/api/Grid" adaptor="UrlAdaptor"></e-data-manager> // Replace `xxxx` with your actual localhost port number.
  <e-grid-columns>
    <e-grid-column field='OrderID' headerText='Order ID' width='120' textAlign='Right'></e-grid-column>
    <e-grid-column field='CustomerID' headerText='Customer ID' width='160'></e-grid-column>
    <e-grid-column field='EmployeeID' headerText='Employee ID' width='160' textAlign='Right'></e-grid-column>
    <e-grid-column field='Freight' headerText='Freight' format="C2" width='160' textAlign='Right'></e-grid-column>
    <e-grid-column field='ShipCity' headerText='Ship City' width='150'></e-grid-column>
  </e-grid-columns>
</ejs-grid>

<script>
	class CustomAdaptor extends ej.data.UrlAdaptor {
		processResponse(data, ds, query, xhr, request, changes) {
			const original = super.processResponse(data, ds, query, xhr, request, changes);
			return original;
		}
	}
	document.addEventListener("DOMContentLoaded", function () {
		let grid = document.getElementById("Grid").ej2_instances[0];
		if (grid) {
			let dataManager = new ejs.data.DataManager({
				url: "https://localhost:xxxx/api/Grid", // Replace xxxx with your actual port number.
				adaptor: new CustomAdaptor(),
			});
			grid.dataSource = dataManager;
		}
	});
</script>

{% endhighlight %}
{% endtabs %}

### Handling sorting operation

When utilizing the `CustomAdaptor` in ASP.NET Core, managing the sorting operation involves overriding the `processResponse` method of the `UrlAdaptor` class.

In the code example below, sorting a custom data source can be accomplished by employing the built-in `PerformSorting` method of the `QueryableOperation` class. Alternatively, you can implement your own method for sorting operation and bind the resulting data to the Syncfusion ASP.NET Core Grid.

{% tabs %}
{% highlight cs tabtitle="GridController.cs" %}

/// <summary>
/// Processes the DataManager request to perform sorting operation.
/// </summary>
/// <param name="DataManagerRequest">Contains the details of the data operation requested.</param>
/// <returns>Returns a JSON object with the sorted data along with the total record count.</returns>
[HttpPost]
public object Post(DataManagerRequest DataManagerRequest)
{
  // Retrieve data from the data source (e.g., database).
  IQueryable<Orders> DataSource = GetOrderData().AsQueryable();

  // Initialize QueryableOperation instance.
  QueryableOperation queryableOperation = new QueryableOperation();

  // Handling sorting operation.
  if (DataManagerRequest.Sorted != null && DataManagerRequest.Sorted.Count > 0)
  {
    DataSource = queryableOperation.PerformSorting(DataSource, DataManagerRequest.Sorted);
    //Add custom logic here if needed and remove above method.
  }

  // Get the total count of records.
  int totalRecordsCount = DataSource.Count();

  // Return data based on the request.
  return new { result = DataSource, count = totalRecordsCount };
}

{% endhighlight %}

{% highlight cshtml tabtitle="Index.cshtml" %}

<ejs-grid id="Grid" allowSorting="true" height="348">
  <e-data-manager url="https://localhost:xxxx/api/Grid" adaptor="UrlAdaptor"></e-data-manager> // Replace `xxxx` with your actual localhost port number.
  <e-grid-columns>
    <e-grid-column field='OrderID' headerText='Order ID' width='120' textAlign='Right'></e-grid-column>
    <e-grid-column field='CustomerID' headerText='Customer ID' width='160'></e-grid-column>
    <e-grid-column field='EmployeeID' headerText='Employee ID' width='160' textAlign='Right'></e-grid-column>
    <e-grid-column field='Freight' headerText='Freight' format="C2" width='160' textAlign='Right'></e-grid-column>
    <e-grid-column field='ShipCity' headerText='Ship City' width='150'></e-grid-column>
  </e-grid-columns>
</ejs-grid>

<script>
	class CustomAdaptor extends ej.data.UrlAdaptor {
		processResponse(data, ds, query, xhr, request, changes) {
			const original = super.processResponse(data, ds, query, xhr, request, changes);
			return original;
		}
	}
	document.addEventListener("DOMContentLoaded", function () {
		let grid = document.getElementById("Grid").ej2_instances[0];
		if (grid) {
			let dataManager = new ejs.data.DataManager({
				url: "https://localhost:xxxx/api/Grid", // Replace xxxx with your actual port number.
				adaptor: new CustomAdaptor(),
			});
			grid.dataSource = dataManager;
		}
	});
</script>

{% endhighlight %}
{% endtabs %}

### Handling paging operation

When utilizing the `CustomAdaptor` in ASP.NET Core, managing the paging operation involves overriding the `processResponse` method of the `UrlAdaptor` class.

In the code example below, paging a custom data source can be achieved by utilizing the built-in `PerformTake` and `PerformSkip` method of the `QueryableOperation` class. Alternatively, you can use your own method for paging operation and bind the resulting data to the Syncfusion ASP.NET Core Grid.

{% tabs %}
{% highlight cs tabtitle="GridController.cs" %}

/// <summary>
/// Processes the DataManager request to perform paging operation.
/// </summary>
/// <param name="DataManagerRequest">Contains the details of the data operation requested.</param>
/// <returns>Returns a JSON object with the paginated data along with the total record count.</returns>
[HttpPost]
public object Post(DataManagerRequest DataManagerRequest)
{
  // Retrieve data from the data source (e.g., database).
  IQueryable<Orders> DataSource = GetOrderData().AsQueryable();

  // Initialize QueryableOperation instance.
  QueryableOperation queryableOperation = new QueryableOperation();

  // Get the total count of records.
  int totalRecordsCount = DataSource.Count();

  // Handling paging operation.
  if (DataManagerRequest.Skip != 0)
  {
    DataSource = queryableOperation.PerformSkip(DataSource, DataManagerRequest.Skip);
    //Add custom logic here if needed and remove above method.
  }
  if (DataManagerRequest.Take != 0)
  {
    DataSource = queryableOperation.PerformTake(DataSource, DataManagerRequest.Take);
    //Add custom logic here if needed and remove above method.
  }

  // Return data based on the request.
  return new { result = DataSource, count = totalRecordsCount };
}

{% endhighlight %}

{% highlight cshtml tabtitle="Index.cshtml" %}

<ejs-grid id="Grid" allowPaging="true" height="348">
  <e-data-manager url="https://localhost:xxxx/api/Grid" adaptor="UrlAdaptor"></e-data-manager> // Replace `xxxx` with your actual localhost port number.
  <e-grid-columns>
        <e-grid-column field='OrderID' headerText='Order ID' width='120' textAlign='Right'></e-grid-column>
        <e-grid-column field='CustomerID' headerText='Customer ID' width='160'></e-grid-column>
        <e-grid-column field='EmployeeID' headerText='Employee ID' width='160' textAlign='Right'></e-grid-column>
        <e-grid-column field='Freight' headerText='Freight' format="C2" width='160' textAlign='Right'></e-grid-column>
        <e-grid-column field='ShipCity' headerText='Ship City' width='150'></e-grid-column>
  </e-grid-columns>
</ejs-grid>

<script>
	class CustomAdaptor extends ej.data.UrlAdaptor {
		processResponse(data, ds, query, xhr, request, changes) {
			const original = super.processResponse(data, ds, query, xhr, request, changes);
			return original;
		}
	}
	document.addEventListener("DOMContentLoaded", function () {
		let grid = document.getElementById("Grid").ej2_instances[0];
		if (grid) {
			let dataManager = new ejs.data.DataManager({
				url: "https://localhost:xxxx/api/Grid", // Replace xxxx with your actual port number.
				adaptor: new CustomAdaptor(),
			});
			grid.dataSource = dataManager;
		}
	});
</script>

{% endhighlight %}
{% endtabs %}

### Handling CRUD Operations

The Syncfusion ASP.NET Core Grid seamlessly integrates CRUD (Create, Read, Update and Delete) operations with server-side controller actions through specific properties: `insertUrl`, `removeUrl`, `updateUrl`, and `batchUrl`. These properties enable the Grid to communicate with the data service for every Grid action, facilitating server-side operations.

**CRUD Operations Mapping**

The following properties enable the Grid to interact with API endpoints for different CRUD actions:

1. **insertUrl**: Specifies the URL for inserting new data.
2. **removeUrl**: Specifies the URL for removing existing data.
3. **updateUrl**: Specifies the URL for updating existing data.
5. **batchUrl**: Specifies the URL for batch editing.

To enable editing in ASP.NET Core Grid, refer to the editing [documentation](https://ej2.syncfusion.com/aspnetcore/documentation/grid/editing/edit). In the below example, the inline edit `mode` is enabled and [toolbar](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Toolbar) property is configured to display toolbar items for editing purposes.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}

<ejs-grid id="Grid" toolbar="@(new List<string>() { "Add", "Edit", "Delete", "Update", "Cancel" })">
    <e-data-manager url='https://localhost:xxxx/api/Grid'
                        insertUrl='https://localhost:xxxx/api/Grid/Insert'
                        updateUrl='https://localhost:xxxx/api/Grid/Update'
                        removeUrl='https://localhost:xxxx/api/Grid/Remove'
                        adaptor="UrlAdaptor"> // Replace `xxxx` with your actual localhost port number.
    </e-data-manager>
    <e-grid-editSettings allowAdding="true" allowDeleting="true" allowEditing="true" mode="Normal"></e-grid-editSettings>
    <e-grid-columns>
        <e-grid-column field='OrderID' headerText='Order ID' width='120' textAlign='Right' isPrimaryKey=true></e-grid-column>
        <e-grid-column field='CustomerID' headerText='Customer ID' width='160'></e-grid-column>
        <e-grid-column field='EmployeeID' headerText='Employee ID' width='160' textAlign='Right'></e-grid-column>
        <e-grid-column field='Freight' headerText='Freight' format="C2" width='160' textAlign='Right'></e-grid-column>
        <e-grid-column field='ShipCity' headerText='Ship City' width='150'></e-grid-column>
    </e-grid-columns>
</ejs-grid>

<script>
    class CustomAdaptor extends ej.data.UrlAdaptor {
        processResponse(data, ds, query, xhr, request, changes) {
            const original = super.processResponse(data, ds, query, xhr, request, changes);
            return original;
        }
    }
    document.addEventListener("DOMContentLoaded", function () {
        let grid = document.getElementById("Grid").ej2_instances[0];
        if (grid) {
            let dataManager = new ejs.data.DataManager({
                url: "https://localhost:xxxx/api/Grid", // Replace xxxx with your actual port number.
                adaptor: new CustomAdaptor(),
                insertUrl: "https://localhost:xxxx/api/Grid/Insert",
                updateUrl: "https://localhost:xxxx/api/Grid/Update",
                removeUrl: "https://localhost:xxxx/api/Grid/Remove",
            });
            grid.dataSource = dataManager;
        }
    });
</script>

{% endhighlight %}
{% endtabs %}

> * Normal/Inline editing is the default edit `mode` for the Grid. To enable CRUD operations, ensure that the [isPrimaryKey](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_IsPrimaryKey) property is set to **true** for a specific Grid column, ensuring that its value is unique.
> * If database has an auto generated column, ensure to define [isIdentity](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_IsIdentity) property of Grid column to disable them during adding or editing operations.

The below class is used to structure data sent during CRUD operations.

```cs
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
```

**Insert Operation:**

To insert a new row, simply click the **Add** toolbar button. The new record edit form will be displayed as shown below. Upon clicking the **Update** toolbar button, record will inserted into the **Orders** table by calling the following **POST** method of an API.

{% tabs %}
{% highlight cs tabtitle="GridController.cs" %}

/// <summary>
/// Inserts a new data item into the data collection.
/// </summary>
/// <param name="newRecord">It contains the new record detail which is need to be inserted.</param>
/// <returns>Returns void.</returns>
[HttpPost]
[Route("api/[controller]/Insert")]
public void Insert([FromBody] CRUDModel<Orders> value)
{
  // Create query to insert the specific into the database by accessing its properties.
  string queryStr = $"Insert into \"Orders\" (\"CustomerID\", \"Freight\", \"ShipCity\", \"EmployeeID\") values('{value.value.CustomerID}',{value.value.Freight},'{value.value.ShipCity}','{value.value.EmployeeID}')";

  // Create a new NpgsqlConnection object using the connection string.
  NpgsqlConnection Connection = new NpgsqlConnection(ConnectionString);

  // Open the database connection before executing the query.
  Connection.Open();

  // Execute the Npgsql command.
  NpgsqlCommand Command = new NpgsqlCommand(queryStr, Connection);

  // Execute this code to reflect the changes into the database.
  Command.ExecuteNonQuery();

  // Close the database connection after executing the command.
  Connection.Close();

  // Add custom logic here if needed and remove the above method.
}

public class CRUDModel<T> where T : class
{
  public string? action { get; set; }
  public string? keyColumn { get; set; }
  public object? key { get; set; }
  public T? value { get; set; }
  public List<T>? added { get; set; }
  public List<T>? changed { get; set; }
  public List<T>? deleted { get; set; }
  public IDictionary<string, object>? @params { get; set; }
}

{% endhighlight %}

{% highlight html tabtitle="Index.cshtml" %}

<script>
	class CustomAdaptor extends ej.data.UrlAdaptor {
        processResponse(data, ds, query, xhr, request, changes) {
            const original = super.processResponse(data, ds, query, xhr, request, changes);
            return original;
        }
        insert(dm, data) {
        return {
                url: dm.dataSource.insertUrl || dm.dataSource.url,
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
				url: "https://localhost:xxxx/api/Grid",
				adaptor: new CustomAdaptor(),
				insertUrl: "https://localhost:xxxx/api/Grid/Insert",
				updateUrl: "https://localhost:xxxx/api/Grid/Update",
				removeUrl: "https://localhost:xxxx/api/Grid/Remove",
			});
			grid.dataSource = dataManager;
		}
	});
</script>

{% endhighlight %}
{% endtabs %}

**Update Operation:**

To edit a row, first select desired row and click the **Edit** toolbar button. The edit form will be displayed and proceed to modify any column value as per your requirement. Clicking the **Update** toolbar button will update the edit record in the **Orders** table by involving the following **Post** method of an API.

{% tabs %}
{% highlight cs tabtitle="GridController.cs" %}

/// <summary>
/// Update a existing data item from the data collection.
/// </summary>
/// <param name="Order">It contains the updated record detail which is need to be updated.</param>
/// <returns>Returns void.</returns>
[HttpPost]
[Route("api/[controller]/Update")]
public void Update([FromBody] CRUDModel<Orders> value)
{
  // Create query to update the changes into the database by accessing its properties.
  string queryStr = $"Update \"Orders\" set \"CustomerID\"='{value.value.CustomerID}', \"Freight\"={value.value.Freight},\"EmployeeID\"={value.value.EmployeeID},\"ShipCity\"='{value.value.ShipCity}' where \"OrderID\"={value.value.OrderID}";

  // Create a new NpgsqlConnection object using the connection string.
  NpgsqlConnection Connection = new NpgsqlConnection(ConnectionString);

  // Open the database connection before executing the query.
  Connection.Open();

  // Execute the Npgsql command.
  NpgsqlCommand Command = new NpgsqlCommand(queryStr, Connection);

  // Execute this code to reflect the changes into the database.
  Command.ExecuteNonQuery();

  // Close the database connection after executing the command.
  Connection.Close();

  // Add custom logic here if needed and remove the above method.
}

public class CRUDModel<T> where T : class
{
  public string? action { get; set; }
  public string? keyColumn { get; set; }
  public object? key { get; set; }
  public T? value { get; set; }
  public List<T>? added { get; set; }
  public List<T>? changed { get; set; }
  public List<T>? deleted { get; set; }
  public IDictionary<string, object>? @params { get; set; }
}

{% endhighlight %}

{% highlight html tabtitle="Index.cshtml" %}

<script>
	class CustomAdaptor extends ej.data.UrlAdaptor {
        processResponse(data, ds, query, xhr, request, changes) {
            const original = super.processResponse(data, ds, query, xhr, request, changes);
            return original;
        }
        update(dm, keyField, value) {
            return {
            url: dm.dataSource.updateUrl || dm.dataSource.url,
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
				url: "https://localhost:xxxx/api/Grid",
				adaptor: new CustomAdaptor(),
				insertUrl: "https://localhost:xxxx/api/Grid/Insert",
				updateUrl: "https://localhost:xxxx/api/Grid/Update",
				removeUrl: "https://localhost:xxxx/api/Grid/Remove",
			});
			grid.dataSource = dataManager;
		}
	});
</script>

{% endhighlight %}
{% endtabs %}

**Delete Operation**

To delete a row, simply select the desired row and click the **Delete** toolbar button. This action will trigger a **DELETE** request to an API, containing the primary key value of the selected record. As a result corresponding record will be removed from the **Orders** table.

{% tabs %}
{% highlight cs tabtitle="GridController.cs" %}

/// <summary>
/// Remove a specific data item from the data collection.
/// </summary>
/// <param name="value">It contains the specific record detail which is need to be removed.</param>
/// <return>Returns void.</return>
[HttpPost]
[Route("api/[controller]/Remove")]
public void Remove([FromBody] CRUDModel<Orders> value)
{
  //Create query to remove the specific from database by passing the primary key column value.
  string queryStr = $"DELETE FROM \"Orders\" WHERE \"OrderID\" = {value.key}";

  // Create a new NpgsqlConnection object using the connection string.
  NpgsqlConnection Connection = new NpgsqlConnection(ConnectionString);

  // Open the database connection before executing the query.
  Connection.Open();

  // Execute the Npgsql command.
  NpgsqlCommand Command = new NpgsqlCommand(queryStr, Connection);

  //Execute this code to reflect the changes into the database.
  Command.ExecuteNonQuery();

  // Close the database connection after executing the command.
  Connection.Close();

  //Add custom logic here if needed and remove above method.
}

public class CRUDModel<T> where T : class
{
  public string? action { get; set; }
  public string? keyColumn { get; set; }
  public object? key { get; set; }
  public T? value { get; set; }
  public List<T>? added { get; set; }
  public List<T>? changed { get; set; }
  public List<T>? deleted { get; set; }
  public IDictionary<string, object>? @params { get; set; }
}

{% endhighlight %}

{% highlight html tabtitle="Index.cshtml" %}

<script>
	class CustomAdaptor extends ej.data.UrlAdaptor {
		processResponse(data, ds, query, xhr, request, changes) {
			const original = super.processResponse(data, ds, query, xhr, request, changes);
			return original;
		}
        remove(dm, keyField, value) {
            return {
            url: dm.dataSource.removeUrl || dm.dataSource.url,
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
				url: "https://localhost:xxxx/api/Grid",
				adaptor: new CustomAdaptor(),
				insertUrl: "https://localhost:xxxx/api/Grid/Insert",
				updateUrl: "https://localhost:xxxx/api/Grid/Update",
				removeUrl: "https://localhost:xxxx/api/Grid/Remove",
			});
			grid.dataSource = dataManager;
		}
	});
</script>

{% endhighlight %}
{% endtabs %}

**Batch Operation**

To perform batch operation, define the edit `mode` as **Batch** and specify the `batchUrl` property in the `DataManager`. Use the **Add** toolbar button to insert new row in batch editing mode. To edit a cell, double-click the desired cell and update the value as required. To delete a record, simply select the record and press the **Delete** toolbar button. Now, all CRUD operations will be executed in single request. Clicking the **Update** toolbar button will update the newly added, edited, or deleted records from the **Orders** table using a single API POST request.

{% tabs %}
{% highlight cs tabtitle="GridController.cs" %}

/// <summary>
/// Batch update (Insert, Update, and Delete) a collection of data items from the data collection.
/// </summary>
/// <param name="CRUDModel<T>">The set of information along with details about the CRUD actions to be executed from the database.</param>
/// <returns>Returns void.</returns>
[HttpPost]
[Route("api/[controller]/BatchUpdate")]
public IActionResult BatchUpdate([FromBody] CRUDModel<Orders> value)
{
  if (value.changed != null && value.changed.Count > 0)
  {
    foreach (Orders Record in (IEnumerable<Orders>)value.changed)
    {
      // Create query to update the changes into the database by accessing its properties.
      string queryStr = $"Update \"Orders\" set \"CustomerID\"='{Record.CustomerID}', \"Freight\"={Record.Freight},\"EmployeeID\"={Record.EmployeeID},\"ShipCity\"='{Record.ShipCity}' where \"OrderID\"={Record.OrderID}";

      // Create a new NpgsqlConnection object using the connection string.
      NpgsqlConnection Connection = new NpgsqlConnection(ConnectionString);

      // Open the database connection before executing the query.
      Connection.Open();

      // Execute the Npgsql command.
      NpgsqlCommand Command = new NpgsqlCommand(queryStr, Connection);

      // Execute this code to reflect the changes into the database.
      Command.ExecuteNonQuery();

      // Close the database connection after executing the command.
      Connection.Close();

      // Add custom logic here if needed and remove the above method.
    }
  }
  if (value.added != null && value.added.Count > 0)
  {
    foreach (Orders Record in (IEnumerable<Orders>)value.added)
    {
      // Create query to insert the specific into the database by accessing its properties.
      string queryStr = $"Insert into \"Orders\" (\"CustomerID\", \"Freight\", \"ShipCity\", \"EmployeeID\") values('{Record.CustomerID}',{Record.Freight},'{Record.ShipCity}','{Record.EmployeeID}')";

      // Create a new NpgsqlConnection object using the connection string.
      NpgsqlConnection Connection = new NpgsqlConnection(ConnectionString);

      // Open the database connection before executing the query.
      Connection.Open();

      // Execute the Npgsql command.
      NpgsqlCommand Command = new NpgsqlCommand(queryStr, Connection);

      // Execute this code to reflect the changes into the database.
      Command.ExecuteNonQuery();

      // Close the database connection after executing the command.
      Connection.Close();

      // Add custom logic here if needed and remove the above method.
    }
  }
  if (value.deleted != null && value.deleted.Count > 0)
  {
    foreach (Orders Record in (IEnumerable<Orders>)value.deleted)
    {
      //Create query to remove the specific from database by passing the primary key column value.
      string queryStr = $"DELETE FROM \"Orders\" WHERE \"OrderID\" = {Record.OrderID}";

      // Create a new NpgsqlConnection object using the connection string.
      NpgsqlConnection Connection = new NpgsqlConnection(ConnectionString);

      // Open the database connection before executing the query.
      Connection.Open();

      // Execute the Npgsql command.
      NpgsqlCommand Command = new NpgsqlCommand(queryStr, Connection);

      //Execute this code to reflect the changes into the database.
      Command.ExecuteNonQuery();

      // Close the database connection after executing the command.
      Connection.Close();

      //Add custom logic here if needed and remove above method.
    }
  }
  return new JsonResult(value);
}

public class CRUDModel<T> where T : class
{
  public string? action { get; set; }
  public string? keyColumn { get; set; }
  public object? key { get; set; }
  public T? value { get; set; }
  public List<T>? added { get; set; }
  public List<T>? changed { get; set; }
  public List<T>? deleted { get; set; }
  public IDictionary<string, object>? @params { get; set; }
}

{% endhighlight %}

{% highlight cshtml tabtitle="Index.cshtml" %}

<ejs-grid id="Grid" toolbar="@(new List<string>() { "Add", "Edit", "Delete", "Update", "Cancel" })">
    <e-grid-columns>
        <e-grid-column field='OrderID' headerText='Order ID' width='120' textAlign='Right' isPrimaryKey=true></e-grid-column>
        <e-grid-column field='CustomerID' headerText='Customer ID' width='160'></e-grid-column>
        <e-grid-column field='EmployeeID' headerText='Employee ID' width='160' textAlign='Right'></e-grid-column>
        <e-grid-column field='Freight' headerText='Freight' format="C2" width='160' textAlign='Right'></e-grid-column>
        <e-grid-column field='ShipCity' headerText='Ship City' width='150'></e-grid-column>
    </e-grid-columns>
</ejs-grid>

<script>
	class CustomAdaptor extends ej.data.UrlAdaptor {
		processResponse(data, ds, query, xhr, request, changes) {
			const original = super.processResponse(data, ds, query, xhr, request, changes);
			return original;
		}
        batchRequest(dm, changes, e) {
            return {
            url: dm.dataSource.batchUrl || dm.dataSource.url,
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
				url: "https://localhost:xxxx/api/Grid",
				adaptor: new CustomAdaptor(),
				batchUrl: "https://localhost:xxxx/api/Grid/BatchUpdate",
			});
			grid.dataSource = dataManager;
		}
	});
</script>

{% endhighlight %}
{% endtabs %}

When you run the application, the resultant Syncfusion ASP.NET Core Grid will look like this

![Syncfusion ASP.NET Core Grid bound with PostgreSQL Server data](../images/database/microsoft-sql-batch.gif)
