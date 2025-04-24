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

# WebMethodAdaptor in Syncfusion ASP.NET MVC Grid 

The `WebMethodAdaptor` in Syncfusion ASP.NET MVC Grid enables seamless data binding from remote services using web methods. This powerful feature enables efficient communication between the client-side application and the server. Similar to the **URLAdaptor**, the **WebMethodAdaptor** sends query parameters encapsulated within an object named **value**. This **value** object includes various **DataManager** properties such as **requiresCounts**, **skip**, **take**, **sorted**, and **where** queries are included.

![Webmethod Adaptor](../images/adaptors/web-method-adaptor-value.png)

This section provides a step-by-step guide to retrieving data using `WebMethodAdaptor`, binding it to the ASP.NET MVC Grid, and managing CRUD operations effectively.

## Creating an API Service

To configure a server with Syncfusion ASP.NET MVC Grid, follow the steps below:

**1. Project Creation:**

1. Open **Visual Studio**.
2. Select **Create a new project** → Choose **ASP.NET Web Application (.NET Framework)**.
3. Name the project **WebMethodAdaptor** and select **MVC** as the project template.
4. Ensure that the **Web API** option is selected.

For detailed information, refer to this [documentation](https://learn.microsoft.com/en-us/aspnet/mvc/overview/getting-started/introduction/getting-started#create-your-first-app).

**2. Model Class Creation:**

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

**3. Configure Routing in Web API**

Modify `WebApiConfig.cs` inside the `App_Start` folder to enable routing.

```cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web.Http;

namespace WebMethodAdaptor
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Enable Attribute Routing.
            config.MapHttpAttributeRoutes();
            // Default route.
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            // Format JSON responses properly.
            config.Formatters.JsonFormatter.SerializerSettings.Formatting = Newtonsoft.Json.Formatting.Indented;
            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("application/json"));
        }
    }
}
```

**4. API Controller Creation:**

Create a file named `GridController.cs` under the **Controllers** folder. This controller will handle data retrieval and communication with the Syncfusion ASP.NET MVC Grid.

{% tabs %}
{% highlight cs tabtitle="GridController.cs" %}

using Syncfusion.EJ2.Base;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebMethodAdaptor.Models;

namespace WebMethodAdaptor.Controllers
{
  public class GridController : ApiController
  {
    // Method to retrieve order data.
    public List<OrdersDetails> GetOrderData()
    {
        // Retrieve all records and convert to list.
        var data = OrdersDetails.GetAllRecords().ToList();
        return data;
    }
    // Method to handle incoming data manager requests.
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

**5. Run the Application:**

Run the application in Visual Studio. It will be accessible via a URL like **https://localhost:xxxx**. 

After running the application, you can verify that the server-side API controller is successfully returning the order data at the URL(https://localhost:xxxx/api/Grid). Here **xxxx** denotes the port number.

![WebMethodAdaptor-data](../images/adaptors/url-adaptor-data.jpeg)

## Connecting Syncfusion ASP.NET MVC Grid to an API Service

To integrate the Syncfusion Grid into your ASP.NET MVC project using Visual Studio, follow these steps:

**Step 1:** Install the Syncfusion ASP.NET MVC Package:

To add `ASP.NET MVC` controls to your application, open the NuGet Package Manager in Visual Studio (Tools → NuGet Package Manager → Manage NuGet Packages for Solution), search for [Syncfusion.EJ2.MVC5](https://www.nuget.org/packages/Syncfusion.EJ2.MVC5) and then install it. Alternatively, you can install it using the following Package Manager Console command:

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

To include the required styles and scripts, add the following references inside the `<head>` of `~/Views/Shared/_Layout.cshtml` file:

{% tabs %}
{% highlight html tabtitle="~/_Layout.cshtml" %}

<head>
  ...
  <!-- Syncfusion ASP.NET MVC controls styles -->
  <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/bootstrap5.css" />
  <!-- Syncfusion ASP.NET MVC controls scripts -->
  <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/dist/ej2.min.js"></script>
  <!-- Include the necessary CSS files to style the Syncfusion ASP.NET MVC component: -->
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

To ensure proper script execution, register the Syncfusion Script Manager `EJS().ScriptManager()` at the end of `<body>` in the `~/Views/Shared/_Layout.cshtml` file as follows.

{% tabs %}
{% highlight html tabtitle="~/_Layout.cshtml" %}

<body>
  <!-- Syncfusion ASP.NET MVC Script Manager -->
  @Html.EJS().ScriptManager()
</body>

{% endhighlight %}
{% endtabs %}

**Step 5:** Add the Syncfusion ASP.NET MVC Grid

Now, add the Syncfusion ASP.NET MVC Grid in `~/Views/Home/Index.cshtml` file.

{% tabs %}
{% highlight html tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2
// Replace `xxxx` with your actual localhost port number.
@Html.EJS().Grid("Grid").DataSource(ds => ds.Url("https://localhost:xxxx/api/Grid").Adaptor("WebMethodAdaptor")).Columns(col =>
    {
        col.Field("OrderID").HeaderText("Order ID").Width("150").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).IsPrimaryKey(true).Add();
        col.Field("CustomerID").HeaderText("Customer ID").Width("150").Add();
        col.Field("ShipCity").HeaderText("Ship City").Width("150").Add();
        col.Field("ShipCountry").HeaderText("Ship Country").Width("150").Add();
    }).Render()

{% endhighlight %}
{% endtabs %}

> Replace https://localhost:xxxx/api/Grid with the actual URL of your endpoint that provides the data in a consumable format (e.g., JSON).

**Step 7:** Run the Project

Run the project in Visual Studio, and the Syncfusion ASP.NET MVC Grid will successfully fetch data from the API service.

![WebMethodAdaptor](../images/adaptors/adaptor.gif)

> * The Syncfusion Grid provides built-in support for handling various data operations such as searching, sorting, filtering, aggregate and paging on the server-side. These operations can be handled using methods such as `PerformSearching`, `PerformFiltering`, `PerformSorting`, `PerformTake` and `PerformSkip` available in the `Syncfusion.EJ2.MVC5` package. Let’s explore how to manage these data operations using the `WebMethodAdaptor`.
> * In an API service project, add `Syncfusion.EJ2.MVC5 ` by opening the NuGet package manager in Visual Studio (Tools → NuGet Package Manager → Manage NuGet Packages for Solution), search and install it.
> * To access `DataManagerRequest`, import `Syncfusion.EJ2.Base` in `GridController.cs` file.
> * In the `WebMethodAdaptor` configuration, the properties of the `DataManager` object are encapsulated within an object named **value**. To access the `DataManager` properties, a dedicated class is created, representing the **value** object.

    ```cs
    // Model for handling data manager requests.
    public class DataManager
    {
        public required DataManagerRequest Value { get; set; }
    }
    ```

## Handling Searching Operation

To enable search functionality, ensure that your API endpoint supports custom searching criteria. Implement the searching logic on the server-side using the `PerformSearching` method from the `QueryableOperation` class. This allows the custom data source to undergo searching based on the criteria specified in the incoming `DataManagerRequest` object.

![WebMethodAdaptor searching](../images/adaptors/web-method-adaptor-searching.png)

{% tabs %}
{% highlight cs tabtitle="GridController.cs" %}

public object Post(DataManager DataManagerRequest)
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
{% highlight html tabtitle="Index.cshtml" %}
// Replace `xxxx` with your actual localhost port number.
@Html.EJS().Grid("Grid").DataSource(ds => ds.Url("https://localhost:xxxx/api/Grid").Adaptor("WebMethodAdaptor")).Columns(col =>
    {
        col.Field("OrderID").HeaderText("Order ID").Width("150").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).IsPrimaryKey(true).Add();
        col.Field("CustomerID").HeaderText("Customer ID").Width("150").Add();
        col.Field("ShipCity").HeaderText("Ship City").Width("150").Add();
        col.Field("ShipCountry").HeaderText("Ship Country").Width("150").Add();
    }).Toolbar(new List<string>() { "Search" }).Render()

{% endhighlight %}
{% endtabs %}

## Handling Filtering Operation

To handle filtering operation, configure your API endpoint to support filter criteria. Implement the filtering logic on the server-side using the `PerformFiltering` method from the `QueryableOperation` class. This allows the custom data source to undergo filtering based on the criteria specified in the incoming `DataManagerRequest` object.

**Single column filtering**
![Single column filtering](../images/adaptors/web-method-adaptor-filtering.png)

**Multi column filtering**
![Multi column filtering](../images/adaptors/web-method-adaptor-multi-filtering.png)

{% tabs %}
{% highlight cs tabtitle="GridController.cs" %}

[HttpPost]
public object Post(DataManager DataManagerRequest)
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
{% highlight html tabtitle="Index.cshtml" %}
// Replace `xxxx` with your actual localhost port number.
@Html.EJS().Grid("Grid").DataSource(ds => ds.Url("https://localhost:xxxx/api/Grid").Adaptor("WebMethodAdaptor")).Columns(col =>
    {
        col.Field("OrderID").HeaderText("Order ID").Width("150").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).IsPrimaryKey(true).Add();
        col.Field("CustomerID").HeaderText("Customer ID").Width("150").Add();
        col.Field("ShipCity").HeaderText("Ship City").Width("150").Add();
        col.Field("ShipCountry").HeaderText("Ship Country").Width("150").Add();
    }).AllowFiltering().Render()

{% endhighlight %}
{% endtabs %}

## Handling Sorting Operation

To handle sorting operation, configure your API to support custom sorting criteria. Implement the sorting logic on the server-side using the `PerformSorting` method from the `QueryableOperation` class. This allows the custom data source to undergo sorting based on the criteria specified in the incoming `DataManagerRequest` object.

**Single column sorting**
![Single column sorting](../images/adaptors/web-method-adaptor-sorting.png)

**Multi column sorting**
![Multi column sorting](../images/adaptors/web-method-adaptor-multi-sorting.png)

{% tabs %}
{% highlight cs tabtitle="GridController.cs" %}

[HttpPost]
public object Post(DataManager DataManagerRequest)
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
{% highlight html tabtitle="Index.cshtml" %}
// Replace `xxxx` with your actual localhost port number.
@Html.EJS().Grid("Grid").DataSource(ds => ds.Url("https://localhost:xxxx/api/Grid").Adaptor("WebMethodAdaptor")).Columns(col =>
    {
        col.Field("OrderID").HeaderText("Order ID").Width("150").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).IsPrimaryKey(true).Add();
        col.Field("CustomerID").HeaderText("Customer ID").Width("150").Add();
        col.Field("ShipCity").HeaderText("Ship City").Width("150").Add();
        col.Field("ShipCountry").HeaderText("Ship Country").Width("150").Add();
    }).AllowSorting().Render()

{% endhighlight %}
{% endtabs %}

## Handling Paging Operation

To handle paging operation, configure your API endpoint to support custom paging criteria. Implement the paging logic on the server-side using the `PerformTake` and `PerformSkip` method from the `QueryableOperation` class. This allows the custom data source to undergo paging based on the custom paging criteria specified in the incoming `DataManagerRequest` object.

![WebMethodAdaptor paging](../images/adaptors/web-method-adaptor-paging.png)

{% tabs %}
{% highlight cs tabtitle="GridController.cs" %}

[HttpPost]
public object Post(DataManager DataManagerRequest)
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
{% highlight html tabtitle="Index.cshtml" %}
// Replace `xxxx` with your actual localhost port number.
@Html.EJS().Grid("Grid").DataSource(ds => ds.Url("https://localhost:xxxx/api/Grid").Adaptor("WebMethodAdaptor")).Columns(col =>
    {
        col.Field("OrderID").HeaderText("Order ID").Width("150").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).IsPrimaryKey(true).Add();
        col.Field("CustomerID").HeaderText("Customer ID").Width("150").Add();
        col.Field("ShipCity").HeaderText("Ship City").Width("150").Add();
        col.Field("ShipCountry").HeaderText("Ship Country").Width("150").Add();
    }).AllowPaging().Render()

{% endhighlight %}
{% endtabs %}

## Handling CRUD Operations

The Syncfusion ASP.NET MVC Grid seamlessly integrates CRUD (Create, Read, Update, Delete) operations with server-side controller actions through specific properties: `InsertUrl`, `RemoveUrl`, `UpdateUrl`, `CrudUrl`, and `BatchUrl`. These properties enable the Grid to communicate with the data service for every Grid action, facilitating server-side operations.

**CRUD Operations Mapping**

The following properties enable the Grid to interact with API endpoints for different CRUD actions:

1. **InsertUrl**: Specifies the URL for inserting new data.
2. **RemoveUrl**: Specifies the URL for removing existing data.
3. **UpdateUrl**: Specifies the URL for updating existing data.
4. **CrudUrl**: Specifies a single URL for all CRUD operations.
5. **BatchUrl**: Specifies the URL for batch editing.

To enable editing in ASP.NET MVC Grid, refer to the editing [documentation](https://ej2.syncfusion.com/aspnetmvc/documentation/grid/editing/edit). In the below example, the inline edit `Mode` is enabled and [Toolbar](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Toolbar) property is configured to display toolbar items for editing purposes.

{% tabs %}
{% highlight html tabtitle="Index.cshmtl" %}

// Replace `xxxx` with your actual localhost port number.
@Html.EJS().Grid("Grid").DataSource(dm => dm.Url("https://localhost:xxxx/api/Grid").Adaptor("WebMethodAdaptor").InsertUrl("https://localhost:xxxx/api/Grid/Insert").UpdateUrl("https://localhost:xxxx/api/Grid/Update").RemoveUrl("https://localhost:xxxx/api/Grid/Remove")).AllowFiltering().AllowSorting().AllowPaging().EditSettings(edit => edit.AllowAdding(true).AllowEditing(true).AllowDeleting(true).Mode(Syncfusion.EJ2.Grids.EditMode.Normal)).Toolbar(new List<string>() { "Add", "Edit", "Delete", "Update", "Cancel", "Search" }).Columns(col =>
	{
		col.Field("OrderID").HeaderText("Order ID").Width("150").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).IsPrimaryKey(true).Add();
		col.Field("CustomerID").HeaderText("Customer ID").Width("150").Add();
		col.Field("ShipCity").HeaderText("Ship City").Width("150").Add();
		col.Field("ShipCountry").HeaderText("Ship Country").Width("150").Add();
	}).Render()

{% endhighlight %}
{% endtabs %}

> Normal/Inline editing is the default edit `Mode` for the Grid. To enable CRUD operations, ensure that the [IsPrimaryKey](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_IsPrimaryKey) property is set to **true** for a specific Grid column, ensuring that its value is unique.

**Insert Operation:**

To insert a new record, utilize the `InsertUrl` property to specify the controller action mapping URL for the insert operation. The newly added record details are bound to the **newRecord** parameter.

![Insert record](../images/adaptors/web-method-adaptor-insert-record.png)

```cs
/// <summary>
/// Inserts a new data item into the data collection.
/// </summary>
/// <param name="newRecord">It contains the new record detail which is need to be inserted.</param>
/// <returns>Returns new record data.</returns>
[Route("api/Grid/Insert")]
public IHttpActionResult Insert(CRUDModel<OrdersDetails> newRecord)
{
    if (newRecord?.Value == null)
        return BadRequest("Invalid order data");

    OrdersDetails.GetAllRecords().Insert(0, newRecord.Value);
    return Ok(newRecord.Value);
}
```

**Update Operation:**

For updating existing records, utilize the `UpdateUrl` property to specify the controller action mapping URL for the update operation. The updated record details are bound to the **updatedRecord** parameter.

![Update record](../images/adaptors/web-method-adaptor-update-record.png)

```cs
/// <summary>
/// Update a existing data item from the data collection.
/// </summary>
/// <param name="updatedRecord">It contains the updated record detail which is need to be updated.</param>
/// <returns>Returns data.</returns>
[Route("api/Grid/Update")]
public IHttpActionResult Update(CRUDModel<OrdersDetails> updatedRecord)
{
    var updatedOrder = updatedRecord?.Value;
    if (updatedOrder == null){
        return BadRequest("Invalid update data");
    }
    var data = OrdersDetails.GetAllRecords().FirstOrDefault(or => or.OrderID == updatedOrder.OrderID);
    if (data == null) return NotFound();
    data.CustomerID = updatedOrder.CustomerID;
    data.ShipCity = updatedOrder.ShipCity;
    data.ShipCountry = updatedOrder.ShipCountry;
    // Update other properties...
    return Ok(data);
}
```

**Delete Operation**

To delete existing records, use the `RemoveUrl` property to specify the controller action mapping URL for the delete operation. The primary key value of the deleted record is bound to the **deletedRecord** parameter.

![Delete Record](../images/adaptors/web-method-adaptor-delete-record.png)

```cs
/// <summary>
/// Remove a specific data item from the data collection.
/// </summary>
/// <param name="deletedRecord">It contains the specific record detail which is need to be removed.</param>
/// <return>Returns message</return>
[Route("api/Grid/Remove")]
public IHttpActionResult Remove(CRUDModel<OrdersDetails> deletedRecord)
{
    int orderId = int.Parse(deletedRecord.Key.ToString());
    var data = OrdersDetails.GetAllRecords().FirstOrDefault(order => order.OrderID == orderId);

    if (data == null) return NotFound();

    OrdersDetails.GetAllRecords().Remove(data);
    return Ok($"Order {orderId} deleted successfully");
}
```

![WebMethodAdaptor CRUD operations](../images/adaptors/adaptor-crud-operation.gif)

**Single Method for Performing All CRUD Operations**

Using the `CrudUrl` property, the controller action mapping URL can be specified to perform all the CRUD operation at server-side using a single method instead of specifying separate controller action method for CRUD (insert, update and delete) operations.

The following code example describes the above behavior.

{% tabs %}
{% highlight html tabtitle="Index.cshmtl" %}

// Replace `xxxx` with your actual localhost port number.
@Html.EJS().Grid("Grid").DataSource(dm => dm.Url("https://localhost:xxxx/api/Grid").Adaptor("WebMethodAdaptor").CrudUrl("https://localhost:xxxx/api/Grid/CrudUpdate")).AllowFiltering().AllowSorting().AllowPaging().EditSettings(edit => edit.AllowAdding(true).AllowEditing(true).AllowDeleting(true).Mode(Syncfusion.EJ2.Grids.EditMode.Normal)).Toolbar(new List<string>() { "Add", "Edit", "Delete", "Update", "Cancel", "Search" }).Columns(col =>
	{
		col.Field("OrderID").HeaderText("Order ID").Width("150").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).IsPrimaryKey(true).Add();
		col.Field("CustomerID").HeaderText("Customer ID").Width("150").Add();
		col.Field("ShipCity").HeaderText("Ship City").Width("150").Add();
		col.Field("ShipCountry").HeaderText("Ship Country").Width("150").Add();
	}).Render()

{% endhighlight %}
{% endtabs %}

```cs
[Route("api/Grid/CrudUpdate")]
public void CrudUpdate(CRUDModel<OrdersDetails> request)
{
    // Perform update operation.
    if (request.Action == "update")
    {
        var orderValue = request.Value;
        OrdersDetails existingRecord = OrdersDetails.GetAllRecords().Where(or => or.OrderID == orderValue.OrderID).FirstOrDefault();
        existingRecord.OrderID = orderValue.OrderID;
        existingRecord.CustomerID = orderValue.CustomerID;
        existingRecord.ShipCity = orderValue.ShipCity;
        existingRecord.ShipCountry = orderValue.ShipCountry;
    }
    // Perform insert operation.
    else if (request.Action == "insert")
    {
        OrdersDetails.GetAllRecords().Insert(0, request.Value);
    }
    // Perform remove operation.
    else if (request.Action == "remove")
    {
        OrdersDetails.GetAllRecords().Remove(OrdersDetails.GetAllRecords().Where(or => or.OrderID == int.Parse(request.Key.ToString())).FirstOrDefault());
    }
}
```

**Batch Operation**

To perform batch operation, set the edit `Mode` as **Batch** and specify the `BatchUrl` property in the `DataManager`. Use the **Add** toolbar button to insert new row in batch editing mode. To edit a cell, double-click the desired cell and update the value as required. To delete a record, simply select the record and press the **Delete** toolbar button. Now, all CRUD operations will be executed in single request. Clicking the **Update** toolbar button will update the newly added, edited, or deleted records from the OrdersDetails table using a single API POST request.

{% tabs %}
{% highlight html tabtitle="Index.cshmtl" %}

// Replace `xxxx` with your actual localhost port number.
@Html.EJS().Grid("Grid").DataSource(dm => dm.Url("https://localhost:xxxx/api/Grid").Adaptor("WebMethodAdaptor").BatchUrl("https://localhost:xxxx/api/Grid/BatchUpdate")).AllowFiltering().AllowSorting().AllowPaging().EditSettings(edit => edit.AllowAdding(true).AllowEditing(true).AllowDeleting(true).Mode(Syncfusion.EJ2.Grids.EditMode.Batch)).Toolbar(new List<string>() { "Add", "Edit", "Delete", "Update", "Cancel", "Search" }).Columns(col =>
	{
		col.Field("OrderID").HeaderText("Order ID").Width("150").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).IsPrimaryKey(true).Add();
		col.Field("CustomerID").HeaderText("Customer ID").Width("150").Add();
		col.Field("ShipCity").HeaderText("Ship City").Width("150").Add();
		col.Field("ShipCountry").HeaderText("Ship Country").Width("150").Add();
	}).Render()

{% endhighlight %}
{% endtabs %}

```cs
[Route("api/Grid/BatchUpdate")]
public object BatchUpdate(CRUDModel<OrdersDetails> batchOperation)
{
    if (batchOperation.Added != null)
    {
        foreach (var addedOrder in batchOperation.Added)
        {
            OrdersDetails.GetAllRecords().Insert(0, addedOrder);
        }
    }
    if (batchOperation.Changed != null)
    {
        foreach (var changedOrder in batchOperation.Changed)
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
    if (batchOperation.Deleted != null)
    {
        foreach (var deletedOrder in batchOperation.Deleted)
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

> Please find the sample in this [GitHub location](https://github.com/SyncfusionExamples/Binding-data-from-remote-service-to-asp-net-mvc-data-grid/tree/master/WebMethodAdaptor).