---
layout: post
title: WebApiAdaptor in Syncfusion ##Platform_Name## Grid
description: Learn here all about Bind data and perform CRUD action with WebApiAdaptor in Syncfusion ##Platform_Name## Grid of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Grid
keywords: Adaptors, webapiadaptor, webapi adaptor, remotedata, webapi 
publishingplatform: ##Platform_Name##
documentation: ug
---

# WebApiAdaptor in Syncfusion ASP.NET Core Grid

The `WebApiAdaptor` is an extension of the `ODataAdaptor`, designed to interact with Web APIs created with OData endpoints. This adaptor ensures seamless communication between Syncfusion Grid and OData-endpoint based Web APIs, enabling efficient data retrieval and manipulation. For successful integration, the endpoint must be capable of understanding OData-formatted queries sent along with the request.

To enable the OData query option for a Web API, please refer to the corresponding [documentation](https://learn.microsoft.com/en-us/aspnet/web-api/overview/odata-support-in-aspnet-web-api/supporting-odata-query-options), which provides detailed instructions on configuring the endpoint to understand OData-formatted queries.

This section describes a step-by-step process for retrieving data service using `WebApiAdaptor`, then binding it to the ASP.NET Core Grid to facilitate data and CRUD operations.

## Creating a Web API Service

To configure a server with Syncfusion ASP.NET Core Grid, follow the steps below:

**1. Project Creation:**

Open Visual Studio and create an ASP.NET Core project named **WebApiAdaptor**. To create an ASP.NET Core application, follow the documentation [link](https://learn.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-8.0&tabs=visual-studio#create-a-razor-pages-web-app) for detailed steps.

**2. Model Class Creation:**

Create a model class named `OrdersDetails.cs` inside the **Models** folder on the server-side. This model will represent the order data structure.

{% tabs %}
{% highlight cs tabtitle="OrdersDetails.cs" %}

 namespace WebApiAdaptor.Models
 {
 public class OrdersDetails
 {
    public static List<OrdersDetails> order = new List<OrdersDetails>();
    public OrdersDetails()
    {

    }
    public OrdersDetails(
    int OrderID, string CustomerId, int EmployeeId, double Freight, bool Verified,
    DateTime OrderDate, string ShipCity, string ShipName, string ShipCountry,
    DateTime ShippedDate, string ShipAddress)
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
        for (int i = 1; i < 10; i++)
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

    public int? OrderID { get; set; }
    public string? CustomerID { get; set; }
    public int? EmployeeID { get; set; }
    public double? Freight { get; set; }
    public string? ShipCity { get; set; }
    public bool? Verified { get; set; }
    public DateTime OrderDate { get; set; }
    public string? ShipName { get; set; }
    public string? ShipCountry { get; set; }
    public DateTime ShippedDate { get; set; }
    public string? ShipAddress { get; set; }
 }
}

{% endhighlight %}
{% endtabs %}

**3. API Controller Creation:**

Create a file named `OrdersController.cs` under the **Controllers** folder. This controller will handle data communication with the ASP.NET Core Grid. Implement the **Get** method in the controller to return the data in JSON format, including the **Items** and **Count** properties as required by `WebApiAdaptor`.

{% tabs %}
{% highlight cs tabtitle="OrdersController.cs" %}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiAdaptor.Models;

namespace WebApiAdaptor.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class OrdersController : ControllerBase
  {
    [HttpGet]
    public object Get()
    {
    var data = OrdersDetails.GetAllRecords().ToList();
    return  new { Items = data, Count = data.Count() };
    }
  }
}

{% endhighlight %}
{% endtabs %}

**4. Run the Application:**

Run the application in Visual Studio. It will be accessible on a URL like **https://localhost:xxxx**. 

After running the application, you can verify that the server-side API controller is successfully returning the order data in the URL(https://localhost:xxxx/api/Orders). Here **xxxx** denotes the port number.

![WebApiAdaptor-data](../images/adaptors/webapiAdaptors/webapi-adaptor-data.png)

## Connecting Syncfusion ASP.NET Core Grid to an API Service

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
    <!-- Include the necessary CSS files to style the Syncfusion ASP.NET Core controls: -->
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

**Step 5:** Add ASP.NET Core Grid

Now, add the Syncfusion ASP.NET Core Grid tag helper in `~/Pages/Index.cshtml` page.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
<ejs-grid id="Grid" height="315">
    <e-data-manager url="https://localhost:xxxx/api/Grid" adaptor="WebApiAdaptor"></e-data-manager> // Replace `xxxx` with your actual localhost port number.
    <e-grid-columns>
        <e-grid-column field="OrderID" headerText="Order ID" width="120" textAlign="Right" isPrimaryKey="true"></e-grid-column>
        <e-grid-column field="CustomerID" headerText="Customer ID" width="160"></e-grid-column>
        <e-grid-column field="ShipCity" headerText="Ship City" width="150"></e-grid-column>
        <e-grid-column field="ShipCountry" headerText="Ship Country" width="150"></e-grid-column>
    </e-grid-columns>
</ejs-grid>
{% endhighlight %}
{% endtabs %}

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

![WebApiAdaptor](../images/adaptors/webapiAdaptors/adaptor.gif)

## Handling Searching Operation

To handle search operation, implement search logic on the server side according to the received OData-formatted query.

![Searching query](../images/adaptors/webapiAdaptors/webapiadaptor-searching.png)

{% tabs %}
{% highlight cs tabtitle="OrdersController.cs" %}

[HttpGet]
public object Get()
{
  var queryString = Request.Query;
  var data = OrdersDetails.GetAllRecords().ToList();
  string filter = queryString["$filter"];

  if (filter != null)
  {
    var filters = filter.Split(new string[] { " and " }, StringSplitOptions.RemoveEmptyEntries);
    foreach (var filterItem in filters)
    {
      if (filterItem.Contains("substringof"))
      {
        // Perform Searching.
        var searchParts = filterItem.Split('(', ')', '\'');
        var searchValue = searchParts[3];

        // Apply the search value to all searchable fields.
        data = data.Where(cust =>
          cust.OrderID.ToString().Contains(searchValue) ||
          cust.CustomerID.ToLower().Contains(searchValue) ||
          cust.ShipCity.ToLower().Contains(searchValue)
        // Add conditions for other searchable fields as needed.
        ).ToList();
      }
      else
      {
        // Perform filtering.
      }
    }
  }
  return new { Items = data, Count = data.Count() };
}
{% endhighlight %}
{% highlight ts tabtitle="Index.cshtml" %}
<ejs-grid id="Grid" toolbar="@(new List<string>() { "Search" })" height="315">
    <e-data-manager url="https://localhost:xxxx/api/Grid" adaptor="WebApiAdaptor"></e-data-manager> // Replace `xxxx` with your actual localhost port number.
    <e-grid-columns>
        <e-grid-column field="OrderID" headerText="Order ID" width="120" textAlign="Right" isPrimaryKey="true"></e-grid-column>
        <e-grid-column field="CustomerID" headerText="Customer ID" width="160"></e-grid-column>
        <e-grid-column field="ShipCity" headerText="Ship City" width="150"></e-grid-column>
        <e-grid-column field="ShipCountry" headerText="Ship Country" width="150"></e-grid-column>
    </e-grid-columns>
</ejs-grid>
{% endhighlight %}
{% endtabs %}

## Handling Filtering Operation

To handle filter operations, ensure that your Web API endpoint supports filtering based on OData-formatted queries. Implement the filtering logic on the server-side as shown in the provided code snippet.

![Filtering query](../images/adaptors/webapiAdaptors/webapiadaptor-filtering.png)

{% tabs %}
{% highlight cs tabtitle="OrdersController.cs" %}

[HttpGet]
public object Get()
{
  var queryString = Request.Query;
  var data = Orders.GetAllRecords().ToList();
  string filter = queryString["$filter"];
  
  if (filter != null)
  {
    var filters = filter.Split(new string[] { " and " }, StringSplitOptions.RemoveEmptyEntries);
    foreach (var filterItem in filters)
    {
      var filterfield = "";
      var filtervalue = "";
      var filterParts = filterItem.Split('(', ')', '\'');
      if (filterParts.Length != 9)
      {
        var filterValueParts = filterParts[1].Split();
        filterfield = filterValueParts[0];
        filtervalue = filterValueParts[2];
      }
      else
      {
        filterfield = filterParts[3];
        filtervalue = filterParts[5];
      }
      switch (filterfield)
      {
        case "OrderID":
          data = (from cust in data
                where cust.OrderID.ToString() == filtervalue.ToString()
                select cust).ToList();
        break;
        case "CustomerID":
          data = (from cust in data
                where cust.CustomerID.ToLower().StartsWith(filtervalue.ToString())
                select cust).ToList();
        break;
        case "ShipCity":
          data = (from cust in data
                where cust.ShipCity.ToLower().StartsWith(filtervalue.ToString())
                select cust).ToList();
        break;
      }
    }
    return new { Items = data, Count = data.Count() };
  }
}
{% endhighlight %}
{% highlight ts tabtitle="Index.cshmtl" %}
<ejs-grid id="Grid" allowFiltering="true" height="315">
    <e-data-manager url="https://localhost:xxxx/api/Grid" adaptor="WebApiAdaptor"></e-data-manager> // Replace `xxxx` with your actual localhost port number.
    <e-grid-columns>
        <e-grid-column field="OrderID" headerText="Order ID" width="120" textAlign="Right" isPrimaryKey="true"></e-grid-column>
        <e-grid-column field="CustomerID" headerText="Customer ID" width="160"></e-grid-column>
        <e-grid-column field="ShipCity" headerText="Ship City" width="150"></e-grid-column>
        <e-grid-column field="ShipCountry" headerText="Ship Country" width="150"></e-grid-column>
    </e-grid-columns>
</ejs-grid>
{% endhighlight %}
{% endtabs %}

## Handling Sorting Operation

To handle sorting action, implement sorting logic on the server-side according to the received OData-formatted query.

***Ascending Sorting***

![Sorting Ascending query](../images/adaptors/webapiAdaptors/webapiadaptor-sorting-asc.png)

***Descending Sorting***

![Sorting Descending query](../images/adaptors/webapiAdaptors/webapiadaptor-sorting-desc.png)

{% tabs %}
{% highlight cs tabtitle="OrdersController.cs" %}

[HttpGet]
public object Get()
{
    var queryString = Request.Query;
    var data = OrdersDetails.GetAllRecords().ToList();
    string sort = queryString["$orderby"];    
    if (!string.IsNullOrEmpty(sort))
    {
        var sortConditions = sort.Split(',');
        var orderedData = data.OrderBy(x => 0); // Start with a stable sort.
        foreach (var sortCondition in sortConditions)
        {
            var sortParts = sortCondition.Trim().Split(' ');
            var sortBy = sortParts[0];
            var sortOrder = sortParts.Length > 1 && sortParts[1].ToLower() == "desc";
            switch (sortBy)
            {
                case "OrderID":
                    orderedData = sortOrder ? orderedData.ThenByDescending(x => x.OrderID) : orderedData.ThenBy(x => x.OrderID);
                    break;
                case "CustomerID":
                    orderedData = sortOrder ? orderedData.ThenByDescending(x => x.CustomerID) : orderedData.ThenBy(x => x.CustomerID);
                    break;
                case "ShipCity":
                    orderedData = sortOrder ? orderedData.ThenByDescending(x => x.ShipCity) : orderedData.ThenBy(x => x.ShipCity);
                    break;
            }
        }
        data = orderedData.ToList();
    }
    return new { Items = data, Count = data.Count() };
}
{% endhighlight %}
{% highlight ts tabtitle="Index.cshmtl" %}
<ejs-grid id="Grid" allowFiltering="true" height="315">
    <e-data-manager url="https://localhost:xxxx/api/Grid" adaptor="WebApiAdaptor"></e-data-manager> // Replace `xxxx` with your actual localhost port number.
    <e-grid-columns>
        <e-grid-column field="OrderID" headerText="Order ID" width="120" textAlign="Right" isPrimaryKey="true"></e-grid-column>
        <e-grid-column field="CustomerID" headerText="Customer ID" width="160"></e-grid-column>
        <e-grid-column field="ShipCity" headerText="Ship City" width="150"></e-grid-column>
        <e-grid-column field="ShipCountry" headerText="Ship Country" width="150"></e-grid-column>
    </e-grid-columns>
</ejs-grid>
{% endhighlight %}
{% endtabs %}

## Handling Paging Operation

Implement paging logic on the server-side according to the received OData-formatted query. Ensure that the endpoint supports paging based on the specified criteria.

![paging query](../images/adaptors/webapiAdaptors/webapiadaptor-paging.png)
{% tabs %}
{% highlight cs tabtitle="OrdersController.cs" %}

[HttpGet]
public object Get()
{
    var queryString = Request.Query;
    var data = Orders.GetAllRecords().ToList();
    // Perform Paging operation
    int skip = Convert.ToInt32(queryString["$skip"]);
    int take = Convert.ToInt32(queryString["$top"]);
    return take != 0 ? new { Items = data.Skip(skip).Take(take).ToList(), Count = data.Count() } : new { Items = data, Count = data.Count() };
}
{% endhighlight %}
{% highlight ts tabtitle="Index.cshmtl" %}
<ejs-grid id="Grid" allowPaging="true" height="315">
    <e-data-manager url="https://localhost:xxxx/api/Grid" adaptor="WebApiAdaptor"></e-data-manager> // Replace `xxxx` with your actual localhost port number.
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

To manage CRUD (Create, Read, Update, Delete) operations using the `WebApiAdaptor`, follow the provided guide for configuring the Syncfusion Grid for [editing](https://ej2.syncfusion.com/aspnetcore/documentation/grid/editing/edit) and utilize the sample implementation of the `OrdersController` in your server application. This controller handles HTTP requests for CRUD operations such as GET, POST, PUT, and DELETE.

To enable CRUD operations in the Syncfusion Grid within an ASP.NET Core application, follow the below steps:

{% tabs %}
{% highlight ts tabtitle="Index.cshmtl" %}
<ejs-grid id="Grid" toolbar="@(new List<string>() { "Add", "Edit", "Delete", "Update", "Cancel", "Search"})">
<e-data-manager url="https://localhost:xxxx/api/Grid" adaptor="WebApiAdaptor"></e-data-manager> // Replace `xxxx` with your actual localhost port number.
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

**Insert Record**

To insert a new record into your Syncfusion Grid, you can utilize the `HttpPost` method in your server application. Below is a sample implementation of inserting a record using the **OrdersController**:

![WebApiAdaptor-Insert-record](../images/adaptors/webapiAdaptors/webapiadaptor-insert-record.png)

```cs

[HttpPost]
/// <summary>
/// Inserts a new data item into the data collection.
/// </summary>
/// <param name="newRecord">It holds new record detail which is need to be inserted.</param>
/// <returns>Returns void.</returns>
public void Post([FromBody] OrdersDetails newRecord)
{
  // Insert a new record into the OrdersDetails model.
  OrdersDetails.GetAllRecords().Insert(0, newRecord);
}
```

**Update Record**

Updating a record in the Syncfusion Grid can be achieved by utilizing the `HttpPut` method in your controller. Here's a sample implementation of updating a record:

![WebApiAdaptor-Update-record](../images/adaptors/webapiAdaptors/webapiadaptor-update-record.png)

```cs

[HttpPut]
/// <summary>
/// Update a existing data item from the data collection.
/// </summary>
/// <param name="updatedOrder">It holds updated record detail which is need to be updated.</param>
/// <returns>Returns void.</returns>
public void Put(int id, [FromBody] OrdersDetails updatedOrder)
{
  // Find the existing order by ID.
  var existingOrder = OrdersDetails.GetAllRecords().FirstOrDefault(o => o.OrderID == id);
  if (existingOrder != null)
  {
    // If the order exists, update its properties.
    existingOrder.OrderID = updatedOrder.OrderID;
    existingOrder.CustomerID = updatedOrder.CustomerID;
    existingOrder.ShipCity = updatedOrder.ShipCity;
    existingOrder.ShipCountry = updatedOrder.ShipCountry;
  }
}
```

**Delete Record**

To delete a record from your Syncfusion Grid, you can utilize the `HttpDelete` method in your controller. Below is a sample implementation:

![WebApiAdaptor-Delete-record](../images/adaptors/webapiAdaptors/webapiadaptor-delete-record.png)

```cs

[HttpDelete("{id}")]
/// <summary>
/// Remove a specific data item from the data collection.
/// </summary>
/// <param name="key">It holds specific record detail id which is need to be removed.</param>
/// <returns>Returns void.</returns>
public void Delete(int key)
{
  // Find the order to remove by ID.
  var orderToRemove = OrdersDetails.GetAllRecords().FirstOrDefault(order => order.OrderID == key);
  // If the order exists, remove it.
  if (orderToRemove != null)
  {
    OrdersDetails.GetAllRecords().Remove(orderToRemove);
  }
}
```

![WebApiAdaptor CRUD operations](../images/adaptors/webapiAdaptors/adaptor-crud-operation.gif)
