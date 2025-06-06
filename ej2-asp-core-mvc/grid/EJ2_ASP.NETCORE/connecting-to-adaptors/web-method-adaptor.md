---
layout: post
title: WebMethodAdaptor in Syncfusion ##Platform_Name## Grid.
description: Learn here all about how to bind data and perform CRUD action using WebMethodAdaptor in Syncfusion ##Platform_Name## Grid.
platform: ej2-asp-core-mvc
control: Grid
keywords: Adaptors, webmethodadaptor, web method adaptor, remotedata 
publishingplatform: ##Platform_Name##
documentation: ug
domainurl: ##DomainURL##
---

# WebMethodAdaptor in Syncfusion ASP.NET Core Grid 

The `WebMethodAdaptor` in Syncfusion ASP.NET Core Grid enables seamless data binding from remote services using web methods. This powerful feature enables efficient communication between the client-side application and the server. Similar to the **URLAdaptor**, the **WebMethodAdaptor** sends query parameters encapsulated within an object named **value**. This **value** object includes various **DataManager** properties such as **requiresCounts**, **skip**, **take**, **sorted**, and **where** queries are included.

![Webmethod Adaptor](../images/adaptors/web-method-adaptor-value.png)

This section provides a step-by-step guide to retrieving data using `WebMethodAdaptor`, binding it to the Grid, and managing CRUD operations effectively.

## Creating an API service

To configure a server with Syncfusion ASP.NET Core Grid, follow the steps below:

**1. Project creation:**

Open Visual Studio and create a new ASP.NET Core project named **WebMethodAdaptor**. To create an ASP.NET Core application, follow the documentation [link](https://learn.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-8.0&tabs=visual-studio#create-a-razor-pages-web-app) for detailed steps.

**2. Model class creation:**

Create a model class named **OrdersDetails.cs** inside the **Models** folder on the server-side. This model will represent the order data structure.

{% tabs %}
{% highlight cs tabtitle="OrdersDetails.cs" %}

namespace WebMethodAdaptor.Models
{
  public class OrdersDetails
  {
    public static List<OrdersDetails> order = new List<OrdersDetails>();
    public OrdersDetails()
    {

    }
    public OrdersDetails(int OrderID, string CustomerId, int EmployeeId, double Freight, bool Verified, DateTime OrderDate, string ShipCity, string ShipName, string ShipCountry, DateTime ShippedDate, string ShipAddress)
    {
      this.OrderID = OrderID;
      this.CustomerID = CustomerId;
      this.EmployeeID = EmployeeId;
      this.Freight = Freight;
      this.ShipCity = ShipCity;
      this.Verified = Verified;
      this.OrderDate = OrderDate;
      this.ShipName = ShipName;
      this.ShipCountry = ShipCountry;
      this.ShippedDate = ShippedDate;
      this.ShipAddress = ShipAddress;
    }

    public static List<OrdersDetails> GetAllRecords()
    {
      if (order.Count() == 0)
      {
        int code = 10000;
        for (int i = 1; i <= 2000; i++)
        {
          order.Add(new OrdersDetails(code + 1, "ALFKI", i + 0, 2.3 * i, false, new DateTime(1991, 05, 15), "Berlin", "Simons bistro", "Denmark", new DateTime(1996, 7, 16), "Kirchgasse 6"));
          order.Add(new OrdersDetails(code + 2, "ANATR", i + 2, 3.3 * i, true, new DateTime(1990, 04, 04), "Madrid", "Queen Cozinha", "Brazil", new DateTime(1996, 9, 11), "Avda. Azteca 123"));
          order.Add(new OrdersDetails(code + 3, "ANTON", i + 1, 4.3 * i, true, new DateTime(1957, 11, 30), "Cholchester", "Frankenversand", "Germany", new DateTime(1996, 10, 7), "Carrera 52 con Ave. Bolívar #65-98 Llano Largo"));
          order.Add(new OrdersDetails(code + 4, "BLONP", i + 3, 5.3 * i, false, new DateTime(1930, 10, 22), "Marseille", "Ernst Handel", "Austria", new DateTime(1996, 12, 30), "Magazinweg 7"));
          order.Add(new OrdersDetails(code + 5, "BOLID", i + 4, 6.3 * i, true, new DateTime(1953, 02, 18), "Tsawassen", "Hanari Carnes", "Switzerland", new DateTime(1997, 12, 3), "1029 - 12th Ave. S."));
          code += 5;
        }
      }
      return order;
    }
    [Key]
    public int? OrderID { get; set; }
    public string CustomerID { get; set; }
    public int? EmployeeID { get; set; }
    public double? Freight { get; set; }
    public string ShipCity { get; set; }
    public bool Verified { get; set; }
    public DateTime OrderDate { get; set; }
    public string ShipName { get; set; }
    public string ShipCountry { get; set; }
    public DateTime ShippedDate { get; set; }
    public string ShipAddress { get; set; }
  }
}

{% endhighlight %}
{% endtabs %}

**3. API Controller Creation:**

Create a file named `GridController.cs` under the **Controllers** folder. This controller will handle data retrieval and communication with the Syncfusion ASP.NET Core Grid.

{% tabs %}
{% highlight cs tabtitle="GridController.cs" %}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Syncfusion.EJ2.Base;
using WebMethodAdaptor.Models;

namespace WebMethodAdaptor.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class GridController : ControllerBase
  {
    // Method to retrieve order data.
    [HttpGet]
    [Route("api/[controller]")]
    public List<OrdersDetails> GetOrderData()
    {
        // Retrieve all records and convert to list.
        var data = OrdersDetails.GetAllRecords().ToList();
        return data;
    }
    // Method to handle incoming data manager requests.
    [HttpPost]
    [Route("api/[controller]")]
    public object Post()
    {
        // Retrieve data source and convert to queryable.
        IQueryable<OrdersDetails> DataSource = GetOrderData().AsQueryable();

        // Get total record count.
        int totalRecordsCount = DataSource.Count();

        // Return result and total record count.
        return new { result = DataSource, count = totalRecordsCount };
    }
  }
}

{% endhighlight %}
{% endtabs %}

> The **GetOrderData** method retrieves sample order data. You can modify it to fetch data from a database or any other source.

**4. Run the application:**

Run the application in Visual Studio. It will be accessible via a URL like **https://localhost:xxxx**. 

After running the application, you can verify that the server-side API controller is successfully returning the order data at the URL(https://localhost:xxxx/api/Grid). Here **xxxx** denotes the port number.

![WebMethodAdaptor-data](../images/adaptors/url-adaptor-data.jpeg)

## Connecting Syncfusion ASP.NET Core Grid to an API service

To integrate the Syncfusion Grid into your ASP.NET Core project using Visual Studio, follow these steps:

**Step 1:** Install the Syncfusion ASP.NET Core package:

To add `ASP.NET Core` in the application, open the NuGet package manager in Visual Studio (Tools → NuGet Package Manager → Manage NuGet Packages for Solution), search for [Syncfusion.EJ2.AspNet.Core](https://www.nuget.org/packages/Syncfusion.EJ2.AspNet.Core) and install it.
Alternatively, you can install it using the following Package Manager Console command:

{% tabs %}
{% highlight C# tabtitle="Package Manager" %}

Install-Package Syncfusion.EJ2.AspNet.Core -Version {{ site.releaseversion }}

{% endhighlight %}
{% endtabs %}

**Step 2:** Add Syncfusion ASP.NET Core tag helper

Open `~/Pages/_ViewImports.cshtml` file and import the `Syncfusion.EJ2` tagHelper.

{% tabs %}
{% highlight cshtml tabtitle="~/_ViewImports.cshtml" %}

@addTagHelper *, Syncfusion.EJ2

{% endhighlight %}
{% endtabs %}

**Step 3:** Add stylesheets and script resources

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

**Step 4:** Register Syncfusion script manager:

To ensure proper script execution, register the Syncfusion script manager `<ejs-scripts>` at the end of the `<body>` tag in your ASP.NET Core application as follows:

{% tabs %}
{% highlight cshtml tabtitle="~/_Layout.cshtml" %}

<body>
    ...
    <!-- Syncfusion ASP.NET Core script manager -->
    <ejs-scripts></ejs-scripts>
</body>

{% endhighlight %}
{% endtabs %}

**Step 5:** Add the Syncfusion ASP.NET Core Grid:

Now, add the Syncfusion ASP.NET Core Grid inside the `~/Pages/Index.cshtml` file.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}

<ejs-grid id="Grid" height="315">
    <e-data-manager url="https://localhost:xxxx/api/Grid" adaptor="WebMethodAdaptor"></e-data-manager> // Replace `xxxx` with your actual localhost port number.
    <e-grid-columns>
        <e-grid-column field="OrderID" headerText="Order ID" width="120" textAlign="Right" isPrimaryKey="true"></e-grid-column>
        <e-grid-column field="CustomerID" headerText="Customer ID" width="160"></e-grid-column>
        <e-grid-column field="ShipCity" headerText="Ship City" width="150"></e-grid-column>
        <e-grid-column field="ShipCountry" headerText="Ship Country" width="150"></e-grid-column>
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

![WebMethodAdaptor](../images/adaptors/adaptor.gif)

> * The Syncfusion ASP.NET Core Grid provides built-in support for handling various data operations such as searching, sorting, filtering, aggregate and paging on the server-side. These operations can be handled using methods such as `PerformSearching`, `PerformFiltering`, `PerformSorting`, `PerformTake` and `PerformSkip` available in the [Syncfusion.EJ2.AspNet.Core](https://www.nuget.org/packages/Syncfusion.EJ2.AspNet.Core) package. Let’s explore how to manage these data operations using the `WebMethodAdaptor`.
> * In an API service project, add `Syncfusion.EJ2.AspNet.Core` by opening the NuGet package manager in Visual Studio (Tools → NuGet Package Manager → Manage NuGet Packages for Solution), search and install it.
> * To access `DataManagerRequest` and `QueryableOperation`, import [Syncfusion.EJ2.Base](https://www.npmjs.com/package/@syncfusion/ej2-base) in `GridController.cs` file.
> * In the `WebMethodAdaptor` configuration, the properties of the `DataManager` object are encapsulated within an object named **value**. To access the `DataManager` properties, a dedicated class is created, representing the **value** object.
    ```cs
    // Model for handling data manager requests.
    public class DataManager
    {
        public required DataManagerRequest Value { get; set; }
    }
    ```

## Handling searching operation

To enable search functionality, ensure that your API endpoint supports custom searching criteria. Implement the searching logic on the server-side using the `PerformSearching` method from the `QueryableOperation` class. This allows the custom data source to undergo searching based on the criteria specified in the incoming `DataManagerRequest` object

![WebMethodAdaptor searching](../images/adaptors/web-method-adaptor-searching.png)

{% tabs %}
{% highlight cs tabtitle="GridController.cs" %}

[HttpPost]
public object Post([FromBody] DataManager DataManagerRequest)
{
    // Retrieve data from the data source (e.g., database).
    IQueryable<OrdersDetails> DataSource = GetOrderData().AsQueryable();

    QueryableOperation queryableOperation = new QueryableOperation(); // Initialize QueryableOperation instance.

    // Retrieve data manager value.
    DataManagerRequest DataManagerParams = DataManagerRequest.Value;

    // Handling Searching.
    if (DataManagerParams.Search != null && DataManagerParams.Search.Count > 0)
    {
    DataSource = queryableOperation.PerformSearching(DataSource, DataManagerParams.Search);
    }
    // Get the total records count.
    int totalRecordsCount = DataSource.Count();

    // Return data based on the request.
    return new { result = DataSource, count = totalRecordsCount };
}

// Model for handling data manager requests.
public class DataManager
{
    public required DataManagerRequest Value { get; set; }
}

{% endhighlight %}
{% highlight cshtml tabtitle="Index.cshtml" %}

<ejs-grid id="Grid" toolbar="@(new List<string>() { "Search" })" height="315">
    <e-data-manager url="https://localhost:xxxx/api/Grid" adaptor="WebMethodAdaptor"></e-data-manager> // Replace `xxxx` with your actual localhost port number.
    <e-grid-columns>
        <e-grid-column field="OrderID" headerText="Order ID" width="120" textAlign="Right" isPrimaryKey="true"></e-grid-column>
        <e-grid-column field="CustomerID" headerText="Customer ID" width="160"></e-grid-column>
        <e-grid-column field="ShipCity" headerText="Ship City" width="150"></e-grid-column>
        <e-grid-column field="ShipCountry" headerText="Ship Country" width="150"></e-grid-column>
    </e-grid-columns>
</ejs-grid>

{% endhighlight %}
{% endtabs %}

## Handling filtering operation

To handle filtering operation, configure your API endpoint to support filter criteria. Implement the filtering logic on the server-side using the `PerformFiltering` method from the `QueryableOperation` class. This allows the custom data source to undergo filtering based on the criteria specified in the incoming `DataManagerRequest` object.

**Single column filtering**
![Single column filtering](../images/adaptors/web-method-adaptor-filtering.png)

**Multi column filtering**
![Multi column filtering](../images/adaptors/web-method-adaptor-multi-filtering.png)

{% tabs %}
{% highlight cs tabtitle="GridController.cs" %}

[HttpPost]
public object Post([FromBody] DataManager DataManagerRequest)
{
    // Retrieve data from the data source (e.g., database).
    IQueryable<OrdersDetails> DataSource = GetOrderData().AsQueryable();

    QueryableOperation queryableOperation = new QueryableOperation(); // Initialize QueryableOperation instance.

    // Retrieve data manager value.
    DataManagerRequest DataManagerParams = DataManagerRequest.Value;

    if (DataManagerParams.Where != null && DataManagerParams.Where.Count > 0)
    {
        // Handling filtering operation.
        foreach (var condition in DataManagerParams.Where)
        {
            foreach (var predicate in condition.predicates)
            {
                DataSource = queryableOperation.PerformFiltering(DataSource, DataManagerParams.Where, predicate.Operator);
            }
        }
    }
    // Get the total records count.
    int totalRecordsCount = DataSource.Count();

    // Return data based on the request.
    return new { result = DataSource, count = totalRecordsCount };
}

// Model for handling data manager requests.
public class DataManager
{
    public required DataManagerRequest Value { get; set; }
}

{% endhighlight %}
{% highlight cshtml tabtitle="Index.cshtml" %}

<ejs-grid id="Grid" allowFiltering="true" height="315">
    <e-data-manager url="https://localhost:xxxx/api/Grid" adaptor="WebMethodAdaptor"></e-data-manager> // Replace `xxxx` with your actual localhost port number.
    <e-grid-columns>
        <e-grid-column field="OrderID" headerText="Order ID" width="120" textAlign="Right" isPrimaryKey="true"></e-grid-column>
        <e-grid-column field="CustomerID" headerText="Customer ID" width="160"></e-grid-column>
        <e-grid-column field="ShipCity" headerText="Ship City" width="150"></e-grid-column>
        <e-grid-column field="ShipCountry" headerText="Ship Country" width="150"></e-grid-column>
    </e-grid-columns>
</ejs-grid>

{% endhighlight %}
{% endtabs %}

## Handling sorting operation

To handle sorting operation, configure your API to support custom sorting criteria. Implement the sorting logic on the server-side using the `PerformSorting` method from the `QueryableOperation` class. This allows the custom data source to undergo sorting based on the criteria specified in the incoming `DataManagerRequest` object.

**Single column sorting**
![Single column sorting](../images/adaptors/web-method-adaptor-sorting.png)

**Multi column sorting**
![Multi column sorting](../images/adaptors/web-method-adaptor-multi-sorting.png)

{% tabs %}
{% highlight cs tabtitle="GridController.cs" %}

[HttpPost]
public object Post([FromBody] DataManager DataManagerRequest)
{
    // Retrieve data from the data source (e.g., database).
    IQueryable<OrdersDetails> DataSource = GetOrderData().AsQueryable();

    QueryableOperation queryableOperation = new QueryableOperation(); // Initialize QueryableOperation instance.

    // Retrieve data manager value.
    DataManagerRequest DataManagerParams = DataManagerRequest.Value;

    // Handling Sorting operation.
    if (DataManagerParams.Sorted != null && DataManagerParams.Sorted.Count > 0)
    {
        DataSource = queryableOperation.PerformSorting(DataSource, DataManagerParams.Sorted);
    }

    // Get the total count of records.
    int totalRecordsCount = DataSource.Count();

    // Return data based on the request.
    return new { result = DataSource, count = totalRecordsCount };
}

// Model for handling data manager requests.
public class DataManager
{
    public required DataManagerRequest Value { get; set; }
}

{% endhighlight %}
{% highlight cshtml tabtitle="Index.cshtml" %}

<ejs-grid id="Grid" allowSorting="true" height="315">
    <e-data-manager url="https://localhost:xxxx/api/Grid" adaptor="WebMethodAdaptor"></e-data-manager> // Replace `xxxx` with your actual localhost port number.
    <e-grid-columns>
        <e-grid-column field="OrderID" headerText="Order ID" width="120" textAlign="Right" isPrimaryKey="true"></e-grid-column>
        <e-grid-column field="CustomerID" headerText="Customer ID" width="160"></e-grid-column>
        <e-grid-column field="ShipCity" headerText="Ship City" width="150"></e-grid-column>
        <e-grid-column field="ShipCountry" headerText="Ship Country" width="150"></e-grid-column>
    </e-grid-columns>
</ejs-grid>

{% endhighlight %}
{% endtabs %}

## Handling paging operation

To handle paging operation, configure your API endpoint to support custom sorting criteria. Implement the paging logic on the server-side using the `PerformTake` and `PerformSkip` method from the `QueryableOperation` class. This allows the custom data source to undergo paging based on the criteria specified in the incoming `DataManagerRequest` object.

![WebMethodAdaptor paging](../images/adaptors/web-method-adaptor-paging.png)

{% tabs %}
{% highlight cs tabtitle="GridController.cs" %}

[HttpPost]
public object Post([FromBody] DataManager DataManagerRequest)
{
    // Retrieve data from the data source (e.g., database).
    IQueryable<OrdersDetails> DataSource = GetOrderData().AsQueryable();

    // Get the total records count.
    int totalRecordsCount = DataSource.Count();

    QueryableOperation queryableOperation = new QueryableOperation(); // Initialize QueryableOperation instance.

    // Retrieve data manager value.
    DataManagerRequest DataManagerParams = DataManagerRequest.Value;

    // Handling paging operation.
    if (DataManagerParams.Skip != 0)
    {
        DataSource = queryableOperation.PerformSkip(DataSource, DataManagerParams.Skip);
    }
    if (DataManagerParams.Take != 0)
    {
        DataSource = queryableOperation.PerformTake(DataSource, DataManagerParams.Take);
    }

    // Return data based on the request.
    return new { result = DataSource, count = totalRecordsCount };
}

// Model for handling data manager requests.
public class DataManager
{
    public required DataManagerRequest Value { get; set; }
}

{% endhighlight %}
{% highlight cshtml tabtitle="Index.cshtml" %}

<ejs-grid id="Grid" allowPaging="true" height="315">
    <e-data-manager url="https://localhost:xxxx/api/Grid" adaptor="WebMethodAdaptor"></e-data-manager> // Replace `xxxx` with your actual localhost port number.
    <e-grid-columns>
        <e-grid-column field="OrderID" headerText="Order ID" width="120" textAlign="Right" isPrimaryKey="true"></e-grid-column>
        <e-grid-column field="CustomerID" headerText="Customer ID" width="160"></e-grid-column>
        <e-grid-column field="ShipCity" headerText="Ship City" width="150"></e-grid-column>
        <e-grid-column field="ShipCountry" headerText="Ship Country" width="150"></e-grid-column>
    </e-grid-columns>
</ejs-grid>

{% endhighlight %}
{% endtabs %}

## Handling CRUD operations

The Syncfusion ASP.NET Core Grid seamlessly integrates CRUD (Create, Read, Update, Delete) operations with server-side controller actions through specific properties: `insertUrl`, `removeUrl`, `updateUrl`, `crudUrl`, and `batchUrl`. These properties enable the Grid to communicate with the data service for every Grid action, facilitating server-side operations.

**CRUD operations mapping**

The following properties enable the Grid to interact with API endpoints for different CRUD actions:

1. **insertUrl**: Specifies the URL for inserting new data.
2. **removeUrl**: Specifies the URL for removing existing data.
3. **updateUrl**: Specifies the URL for updating existing data.
4. **crudUrl**: Specifies a single URL for all CRUD operations.
5. **batchUrl**: Specifies the URL for batch editing.

To enable editing in ASP.NET Core Grid, refer to the editing [documentation](https://ej2.syncfusion.com/aspnetcore/documentation/grid/editing/edit). In the below example, the inline edit `mode` is enabled and [toolbar](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Toolbar) property is configured to display toolbar items for editing purposes.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshmtl" %}

<ejs-grid id="Grid" toolbar="@(new List<string>() { "Add", "Edit", "Delete", "Update", "Cancel"})">
    <e-data-manager url='https://localhost:xxxx/api/Grid'
                insertUrl='https://localhost:xxxx/api/Grid/Insert'
                updateUrl='https://localhost:xxxx/api/Grid/Update'
                removeUrl='https://localhost:xxxx/api/Grid/Remove'
                adaptor="WebMethodAdaptor"> // Replace `xxxx` with your actual localhost port number.
    </e-data-manager>
    <e-grid-editSettings allowAdding="true" allowDeleting="true" allowEditing="true" mode="Normal"></e-grid-editSettings>
    <e-grid-columns>
        <e-grid-column field="OrderID" headerText="Order ID" width="120" textAlign="Right" isPrimaryKey="true"></e-grid-column>
        <e-grid-column field="CustomerID" headerText="Customer ID" width="160"></e-grid-column>
        <e-grid-column field="ShipCity" headerText="Ship City" width="150"></e-grid-column>
        <e-grid-column field="ShipCountry" headerText="Ship Country" width="150"></e-grid-column>
    </e-grid-columns>
</ejs-grid>

{% endhighlight %}
{% endtabs %}

> Normal/Inline editing is the default edit `mode` for the Grid. To enable CRUD operations, ensure that the `isPrimaryKey` property is set to **true** for a specific Grid column, ensuring that its value is unique.

The below class is used to structure data sent during CRUD operations.

```cs
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
```

**Insert operation:**

To insert a new record, utilize the `insertUrl` property to specify the controller action mapping URL for the insert operation. The newly added record details are bound to the **newRecord** parameter.

![Insert record](../images/adaptors/web-method-adaptor-insert-record.png)

```cs

/// <summary>
/// Inserts a new data item into the data collection.
/// </summary>
/// <param name="newRecord">It contains the new record detail which is need to be inserted.</param>
/// <returns>Returns void.</returns>
[HttpPost]
[Route("api/[controller]/Insert")]
public void Insert([FromBody] CRUDModel<OrdersDetails> newRecord)
{
    // Check if new record is not null.
    if (newRecord.value != null)
    {
        // Insert new record.
        OrdersDetails.GetAllRecords().Insert(0, newRecord.value);
    }
}
```

**Update operation:**

For updating existing records, utilize the `updateUrl` property to specify the controller action mapping URL for the update operation. The updated record details are bound to the **updatedRecord** parameter.

![Update record](../images/adaptors/web-method-adaptor-update-record.png)

```cs

/// <summary>
/// Update a existing data item from the data collection.
/// </summary>
/// <param name="updatedRecord">It contains the updated record detail which is need to be updated.</param>
/// <returns>Returns void.</returns>
[HttpPost]
[Route("api/[controller]/Update")]
public void Update([FromBody] CRUDModel<OrdersDetails> updatedRecord)
{
    // Retrieve updated order.
    var updatedOrder = updatedRecord.value;
    if (updatedOrder != null)
    {
        // Find existing record.
        var data = OrdersDetails.GetAllRecords().FirstOrDefault(or => or.OrderID == updatedOrder.OrderID);
        if (data != null)
        {
            // Update existing record.
            data.OrderID = updatedOrder.OrderID;
            data.CustomerID = updatedOrder.CustomerID;
            data.ShipCity = updatedOrder.ShipCity;
            data.ShipCountry = updatedOrder.ShipCountry;
            // Update other properties similarly.
        }
    }
}
```

**Delete operation**

To delete existing records, use the `removeUrl` property to specify the controller action mapping URL for the delete operation. The primary key value of the deleted record is bound to the **deletedRecord** parameter.

![Delete Record](../images/adaptors/web-method-adaptor-delete-record.png)

```cs
/// <summary>
/// Remove a specific data item from the data collection.
/// </summary>
/// <param name="deletedRecord">It contains the specific record detail which is need to be removed.</param>
/// <return>Returns void.</return>
[HttpPost]
[Route("api/[controller]/Remove")]
public void Remove([FromBody] CRUDModel<OrdersDetails> deletedRecord)
{
    int orderId = int.Parse(deletedRecord.key.ToString()); // Get key value from the deletedRecord.
    var data = OrdersDetails.GetAllRecords().FirstOrDefault(orderData => orderData.OrderID == orderId);
    if (data != null)
    {
        // Remove the record from the data collection.
        OrdersDetails.GetAllRecords().Remove(data);
    }
}
```

![WebMethodAdaptor CRUD operations](../images/adaptors/adaptor-crud-operation.gif)

**Single method for performing all CRUD operations**

Using the `crudUrl` property, the controller action mapping URL can be specified to perform all the CRUD operation at server-side using a single method instead of specifying separate controller action method for CRUD (insert, update and delete) operations.

The following code example describes the above behavior.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshmtl" %}

<ejs-grid id="Grid" toolbar="@(new List<string>() { "Add", "Edit", "Delete", "Update", "Cancel"})">
    <e-data-manager url='https://localhost:xxxx/api/Grid'
                    crudUrl='https://localhost:xxxx/api/grid/CrudUpdate'
                    adaptor="WebMethodAdaptor"> // Replace `xxxx` with your actual localhost port number.
    </e-data-manager>
    <e-grid-editSettings allowAdding="true" allowDeleting="true" allowEditing="true" mode="Normal"></e-grid-editSettings>
    <e-grid-columns>
        <e-grid-column field="OrderID" headerText="Order ID" width="120" textAlign="Right" isPrimaryKey="true"></e-grid-column>
        <e-grid-column field="CustomerID" headerText="Customer ID" width="160"></e-grid-column>
        <e-grid-column field="ShipCity" headerText="Ship City" width="150"></e-grid-column>
        <e-grid-column field="ShipCountry" headerText="Ship Country" width="150"></e-grid-column>
    </e-grid-columns>
</ejs-grid>

{% endhighlight %}
{% endtabs %}

```cs
[HttpPost]
[Route("api/[controller]/CrudUpdate")]
public void CrudUpdate([FromBody] CRUDModel<OrdersDetails> request)
{
  // Perform update operation.
  if (request.action == "update")
  {
    var orderValue = request.value;
    OrdersDetails existingRecord = OrdersDetails.GetAllRecords().Where(or => or.OrderID == orderValue.OrderID).FirstOrDefault();
    existingRecord.OrderID = orderValue.OrderID;
    existingRecord.CustomerID = orderValue.CustomerID;
    existingRecord.ShipCity = orderValue.ShipCity;
  }
  // Perform insert operation.
  else if (request.action == "insert")
  {
    OrdersDetails.GetAllRecords().Insert(0, request.value);
  }
  // Perform remove operation.
  else if (request.action == "remove")
  {
    OrdersDetails.GetAllRecords().Remove(OrdersDetails.GetAllRecords().Where(or => or.OrderID == int.Parse(request.key.ToString())).FirstOrDefault());
  }
}
```

**Batch operation**

To perform batch operation, set the edit `mode` as **Batch** and specify the `batchUrl` property in the `DataManager`. Use the **Add** toolbar button to insert new row in batch editing mode. To edit a cell, double-click the desired cell and update the value as required. To delete a record, simply select the record and press the **Delete** toolbar button. Now, all CRUD operations will be executed in single request. Clicking the **Update** toolbar button will update the newly added, edited, or deleted records from the OrdersDetails table using a single API POST request.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshmtl" %}

<ejs-grid id="Grid" toolbar="@(new List<string>() { "Add", "Edit", "Delete", "Update", "Cancel"})">
    <e-data-manager url='https://localhost:xxxx/api/Grid'
                    batchUrl='https://localhost:xxxx/api/Grid/BatchUpdate'
                    adaptor="WebMethodAdaptor"> // Replace `xxxx` with your actual localhost port number.
    </e-data-manager>
    <e-grid-editSettings allowAdding="true" allowDeleting="true" allowEditing="true" mode="Batch"></e-grid-editSettings>
    <e-grid-columns>
        <e-grid-column field="OrderID" headerText="Order ID" width="120" textAlign="Right" isPrimaryKey="true"></e-grid-column>
        <e-grid-column field="CustomerID" headerText="Customer ID" width="160"></e-grid-column>
        <e-grid-column field="ShipCity" headerText="Ship City" width="150"></e-grid-column>
        <e-grid-column field="ShipCountry" headerText="Ship Country" width="150"></e-grid-column>
    </e-grid-columns>
</ejs-grid>

{% endhighlight %}
{% endtabs %}

```cs
[HttpPost]
[Route("api/[controller]/BatchUpdate")]
public IActionResult BatchUpdate([FromBody] CRUDModel<OrdersDetails> batchOperation)
{
  if (batchOperation.added != null)
  {
    foreach (var addedOrder in batchOperation.added)
    {
      OrdersDetails.GetAllRecords().Insert(0, addedOrder);
    }
  }
 if (batchOperation.changed != null)
  {
    foreach (var changedOrder in batchOperation.changed)
    {
      var existingOrder = OrdersDetails.GetAllRecords().FirstOrDefault(or => or.OrderID == changedOrder.OrderID);
      if (existingOrder != null)
      {
        existingOrder.CustomerID = changedOrder.CustomerID;
        existingOrder.ShipCity = changedOrder.ShipCity;
        // Update other properties as needed.
      }
    }
  }
if (batchOperation.deleted != null)
  {
    foreach (var deletedOrder in batchOperation.deleted)
    {
      var orderToDelete = OrdersDetails.GetAllRecords().FirstOrDefault(or => or.OrderID == deletedOrder.OrderID);
      if (orderToDelete != null)
      {
        OrdersDetails.GetAllRecords().Remove(orderToDelete);
      }
    }
  }
  return Json(batchOperation);
}
```

![WebMethodAdaptor Batch Editing](../images/adaptors/url-adaptor-batch-editing.gif)

> Please find the sample in this [GitHub location](https://github.com/SyncfusionExamples/Binding-data-from-remote-service-to-asp.net-core-data-grid/tree/master/WebMethodAdaptor_Core).