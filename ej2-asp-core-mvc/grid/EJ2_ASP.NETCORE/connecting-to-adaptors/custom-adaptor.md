---
layout: post
title: Bind data & perform CRUD action with CustomAdaptor in Syncfusion Grid
description: Learn here all about Bind data and perform CRUD action with CustomAdaptor in Syncfusion ##Platform_Name## Grid of Syncfusion Essential JS 2 and more.
control: Custom Adaptor
platform: ej2-asp-core-mvc
documentation: ug
domainurl: ##DomainURL##
---

# CustomAdaptor in Syncfusion ASP.NET Core Grid

The `CustomAdaptor` in the Syncfusion ASP.NET Core Grid allows to create their own custom adaptors by extending the built-in adaptors. The custom adaptor involves handling the built-in adaptor query process, request and response. The `CustomAdaptor` to be allows extending the OData V4 services, enabling efficient data fetching and manipulation. By default, there are three method for `CustomAdaptor` built-in methods.

## Types of CustomAdaptor methods

There are three types of methods in custom adaptors.

### processQuery

The `processQuery` method handles the execution of a query sent to a `dataSource`, such as a database or custom data service. This query is responsible for performing operations like data retrieval, insertion, updating, or deletion. The `processQuery` method accepts two arguments: 

* `DataManager`: Used to modify the URL dynamically.

* `Query`: Allows setting additional parameter values or modifying queries such as sorting, filtering, and grouping, etc.

**DataManager**

![DataManager](../../images/adaptors/customadaptor/custom-adaptor-datamanager.png)

**Query**

![Query](../../images/adaptors/customadaptor/custom-adaptor-query.png)

```js
processQuery(dm, query) {
    query.addParams('Syncfusion in ASP.NET Core Grid', 'true'); // Add additional parameter.
    return super.processQuery.apply(this, arguments);
}
```

### beforeSend

The `beforeSend` method is executed before a request is sent to the server. This function allows modifying parameters, request headers, and data, or performing validation before the request is processed. It accepts three arguments:

* `DataManager`: Provides the `dataSource` and `adaptor` value.

* `Request`: Used to send custom headers, such as setting the `Authorization` header.

* `Settings`: An optional argument that allows additional configurations.

**DataManager**

![DataManager](../../images/adaptors/customadaptor/custom-adaptor-datamanager.png)

**Request**

![Request](../../images/adaptors/customadaptor/custom-adaptor-request.png)

**Settings**

![Settings](../../images/adaptors/customadaptor/custom-adaptor-fetch.png)

```js
beforeSend(dm, request, settings) {
    if (request){
        request.setRequestHeader("Authorization", "true");
    }
    return super.beforeSend(dm, request, settings);
}
```

### processResponse

The `processResponse` method handles the response received from the server after an asynchronous request. It is responsible for parsing the response data, managing errors, and preparing the data for further processing. This method can accept multiple optional arguments, allowing customization based on specific requirements.

```js
processResponse(data, ds, query, xhr, request, changes) {
    let i =0;
    const original = super.processResponse(data, ds, query, xhr, request, changes);
    // Adding serial number.
    if (original.result){
        original.result.forEach((item) => ej.base.setValue('SNo', ++i, item));
    }
return original;
}
```

This guide provides detailed instructions on binding data and performing CRUD (Create, Read, Update, Delete) actions using the `CustomAdaptor` by extending the `ODataV4Adaptor` in your Syncfusion ASP.NET Core Grid.
 
## Creating an custom service

To configure a server with Syncfusion ASP.NET Core Grid, you need to follow the below steps:

**1. Project Creation:**

Open Visual Studio and create an ASP.NET Core project named **CustomAdaptor**. To create an ASP.NET Core application, follow the documentation [link](https://learn.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-8.0&tabs=visual-studio#create-a-razor-pages-web-app) for detailed steps.

**2. Install NuGet Packages**

Using the NuGet package manager in Visual Studio (Tools → NuGet Package Manager → Manage NuGet Packages for Solution), install the [Microsoft.AspNetCore.OData](https://www.nuget.org/packages?q=Microsoft.AspNetCore.OData) NuGet package.

**3. Model Class Creation:**

Create a model class named `OrdersDetails.cs` inside the **Models** folder.

{% tabs %}
{% highlight cs tabtitle="OrdersDetails.cs" %}

 namespace CustomAdaptor.Models
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
      [Key]
      public int OrderID { get; set; }
      public string CustomerID { get; set; }
      public int? EmployeeID { get; set; }
      public double Freight { get; set; }
      public string ShipCity { get; set; }
      public bool Verified { get; set; }
      public DateTime OrderDate { get; set; }
      public string ShipName { get; set; }
      public string ShipCountry { get; set; }
      public DateTime ShippedDate { get; set; }
      public string ShipAddress { get; set; }
  }
}{% endhighlight %}
{% endtabs %}

**4. Build the Entity Data Model**

To construct the Entity Data Model for your OData service, utilize the `ODataConventionModelBuilder` to define the model's structure. Start by creating an instance of the `ODataConventionModelBuilder`, then register the entity set **Orders** using the `EntitySet<T>` method, where `OrdersDetails` represents the CLR type containing order details. 

```cs
using CustomAdaptor.Models;
using Microsoft.AspNetCore.OData;
using Microsoft.OData.ModelBuilder;

// Create an ODataConventionModelBuilder to build the OData model.
var modelBuilder = new ODataConventionModelBuilder();

// Register the "Orders" entity set with the OData model builder.
modelBuilder.EntitySet<OrdersDetails>("Orders");
```

**5. Register the OData Services**

Once the Entity Data Model is built, you need to register the OData services in your ASP.NET Core application. Here's how:

```cs
// Add controllers with OData support to the service collection.
builder.Services.AddControllers().AddOData(
    options => options
        .Count()
        .AddRouteComponents("odata", modelBuilder.GetEdmModel()));
```
**6. Add Controllers**

Finally, add controllers to expose the OData endpoints. Here's an example:

```cs
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using CustomAdaptor.Models;

namespace CustomAdaptor.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        /// <summary>
        /// Retrieves all orders.
        /// </summary>
        /// <returns>The collection of orders.</returns>
        [HttpGet]
        [EnableQuery]
        public IActionResult Get()
        {
            var data = OrdersDetails.GetAllRecords().AsQueryable();
            return Ok(data);
        }
    }
}
```
**7. Run the Application:**

Run the application in Visual Studio. It will be accessible on a URL like **https://localhost:xxxx**. 

After running the application, you can verify that the server-side API controller is successfully returning the order data in the URL(https://localhost:xxxx/odata/Orders). Here **xxxx** denotes the port number.

## Connecting Syncfusion ASP.NET Core Grid to an custom service extending the ODataV4 service

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
</body>{% endhighlight %}
{% endtabs %}

**Step 5: Adding Custom Adaptor**

To create a custom adaptor, extend the ODataV4Adaptor. This custom adaptor will implement three key methods: `processQuery`, `beforeSend`, and `processResponse`.

* The `processQuery` method modifies the API endpoint URL and sets additional parameters required for executing the query.

* The `beforeSend` method adds custom headers, such as the `Authorization` header, before sending the request.

* The `processResponse` method customizes the response by modifying data, such as adding a new field (`SNo`) to the dataset.

```js
<script>
	class CustomAdaptor extends ej.data.ODataV4Adaptor {
		processResponse(data, ds, query, xhr, request, changes) {
			let i = 0;
			const original = super.processResponse(data, ds, query, xhr, request, changes);
			// Adding serial number to each row.
			if (original.result) {
				original.result.forEach((item) => ej.base.setValue('SNo', ++i, item));
			}
			return original;
		}
        beforeSend(dm, request, settings) {
            if (request){
                request.setRequestHeader("Authorization", "true");
            }
            return super.beforeSend(dm, request, settings);
        }
		processQuery(dm, query) {
			dm.dataSource.url = 'https://localhost:xxxx/odata/orders'; // Update with your API endpoint.
			query.addParams('Syncfusion in ASP.NET Core Grid', 'true'); // Add additional parameters.
			return super.processQuery.apply(this, arguments);
		}
	}
	document.addEventListener("DOMContentLoaded", function () {
		let grid = document.getElementById("Grid").ej2_instances[0];
		if (grid) {
			let dataManager = new ej.data.DataManager({
				url: "https://localhost:xxxx/odata/Orders", // Replace `xxxx` with your actual localhost port number.
				adaptor: new CustomAdaptor(),
			});
			grid.dataSource = dataManager;
		}
	});
</script>
```

**Step 6: Adding Syncfusion Grid**

Define a `DataManager` instance, specifying the API endpoint (https://localhost:xxxx/odata/Orders) in the url property and setting the adaptor to `CustomAdaptor`.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
@page
@model IndexModel
@{
	ViewData["Title"] = "Home page";
}
<div>
	<ejs-grid id="Grid" height="315">
		<e-grid-columns>
			<e-grid-column field="SNo" headerText="S.No" width="120" textAlign="Right"></e-grid-column>
			<e-grid-column field="OrderID" headerText="Order ID" width="120" textAlign="Right" isPrimaryKey="true"></e-grid-column>
			<e-grid-column field="CustomerID" headerText="Customer ID" width="150"></e-grid-column>
			<e-grid-column field="EmployeeID" headerText="Employee ID" width="150"></e-grid-column>
			<e-grid-column field="ShipCountry" headerText="Ship Country" width="150"></e-grid-column>
		</e-grid-columns>
	</ejs-grid>
</div>
<script>
	class CustomAdaptor extends ej.data.ODataV4Adaptor {}
	document.addEventListener("DOMContentLoaded", function () {
		let grid = document.getElementById("Grid").ej2_instances[0];
		if (grid) {
			let dataManager = new ej.data.DataManager({
				url: "https://localhost:xxxx/odata/Orders", // Replace `xxxx` with your actual localhost port number.
				adaptor: new CustomAdaptor()
			});

			grid.dataSource = dataManager;
		}
	});
</script>
{% endhighlight %}
{% endtabs %}

**Step 7:** Configure the server:

In the `Program.cs` file of your project, configure the server to serve static files and handle API requests by adding the following code:

```cs
builder.Services.AddRazorPages();
builder.Services.AddControllers();

var app = builder.Build();

app.MapRazorPages();
app.MapControllers();
```
**Step 8:** Run the Project:

Run the project in Visual Studio, and the Syncfusion ASP.NET Core Grid will successfully fetch data from the API service.

> Replace https://localhost:xxxx/odata/Orders with the actual **URL** of your API endpoint that provides the data in a consumable format (e.g., JSON).

## Handling searching operation

To enable search operations in your web application using OData, you first need to configure the OData support in your service collection. This involves adding the `Filter` method within the OData setup, allowing you to filter data based on specified criteria. Once enabled, clients can utilize the **$filter** query option in their requests to search for specific data entries.

{% tabs %}
{% highlight cs tabtitle="Program.cs" %}
// Create a new instance of the web application builder.
var builder = WebApplication.CreateBuilder(args);

// Create an ODataConventionModelBuilder to build the OData model.
var modelBuilder = new ODataConventionModelBuilder();

// Register the "Orders" entity set with the OData model builder.
modelBuilder.EntitySet<OrdersDetails>("Orders");

// Add services to the container.

// Add controllers with OData support to the service collection.
builder.Services.AddControllers().AddOData(
    options => options
        .Count()
        .Filter() 
        .AddRouteComponents("odata", modelBuilder.GetEdmModel()));
{% endhighlight %}

{% highlight cshtml tabtitle="Index.cshtml" %}
 <ejs-grid id="Grid" height="280" toolbar="@(new List<string>() { "Search"})">
    <e-grid-columns>
        <e-grid-column field="OrderID" headerText="Order ID" width="120" textAlign="Right" isPrimaryKey="true" type="number"></e-grid-column>
        <e-grid-column field="CustomerID" headerText="Customer ID" width="150" type="string"></e-grid-column>
        <e-grid-column field="EmployeeID" headerText="Employee ID" width="150"></e-grid-column>
        <e-grid-column field="ShipCountry" headerText="Ship Country" width="150"></e-grid-column>
    </e-grid-columns>
</ejs-grid>
<script>
	class CustomAdaptor extends ej.data.ODataV4Adaptor {}
	document.addEventListener("DOMContentLoaded", function () {
		let grid = document.getElementById("Grid").ej2_instances[0];
		if (grid) {
			let dataManager = new ej.data.DataManager({
				url: "https://localhost:xxxx/odata/Orders", // Replace `xxxx` with your actual localhost port number.
				adaptor: new CustomAdaptor()
			});

			grid.dataSource = dataManager;
		}
	});
</script>
{% endhighlight %}
{% endtabs %}

![Searching query](../../images/adaptors/ODataV4Adaptor/odatav4-adaptor-searching.png)

## Handling filtering operation

To enable filter operations in your web application using OData, you first need to configure the OData support in your service collection. This involves adding the `Filter` method within the OData setup, allowing you to filter data based on specified criteria. Once enabled, clients can utilize the **$filter** query option in your requests to filter for specific data entries.

{% tabs %}
{% highlight cs tabtitle="Program.cs" %}
// Create a new instance of the web application builder.
var builder = WebApplication.CreateBuilder(args);

// Create an ODataConventionModelBuilder to build the OData model.
var modelBuilder = new ODataConventionModelBuilder();

// Register the "Orders" entity set with the OData model builder.
modelBuilder.EntitySet<OrdersDetails>("Orders");

// Add services to the container.

// Add controllers with OData support to the service collection.
builder.Services.AddControllers().AddOData(
    options => options
        .Count()
        .Filter()
        .AddRouteComponents("odata", modelBuilder.GetEdmModel()));
{% endhighlight %}

{% highlight cshtml tabtitle="Index.cshtml" %}
 <ejs-grid id="Grid" height="280" allowFiltering="true">
    <e-grid-columns>
            <e-grid-column field="OrderID" headerText="Order ID" width="120" textAlign="Right" isPrimaryKey="true" type="number"></e-grid-column>
            <e-grid-column field="CustomerID" headerText="Customer ID" width="150" type="string"></e-grid-column>
            <e-grid-column field="EmployeeID" headerText="Employee ID" width="150"></e-grid-column>
            <e-grid-column field="ShipCountry" headerText="Ship Country" width="150"></e-grid-column>
    </e-grid-columns>
</ejs-grid>
<script>
	class CustomAdaptor extends ej.data.ODataV4Adaptor {}
	document.addEventListener("DOMContentLoaded", function () {
		let grid = document.getElementById("Grid").ej2_instances[0];
		if (grid) {
			let dataManager = new ej.data.DataManager({
				url: "https://localhost:xxxx/odata/Orders", // Replace `xxxx` with your actual localhost port number.
				adaptor: new CustomAdaptor()
			});
			grid.dataSource = dataManager;
		}
	});
</script>
{% endhighlight %}
{% endtabs %}

**Single column filtering**
![Filtering query](../../images/adaptors/ODataV4Adaptor/odatav4-adaptor-filtering.png)
**Multi column filtering**
![Filtering query](../../images/adaptors/ODataV4Adaptor/odatav4-adaptor-multi-column-filtering.png)

## Handling sorting operation

To enable sorting operations in your web application using OData, you first need to configure the OData support in your service collection. This involves adding the `OrderBy` method within the OData setup, allowing you to sort data based on specified criteria. Once enabled, clients can utilize the **$orderby** query option in their requests to sort data entries according to desired attributes.

{% tabs %}
{% highlight cs tabtitle="Program.cs" %}

// Create a new instance of the web application builder.
var builder = WebApplication.CreateBuilder(args);

// Create an ODataConventionModelBuilder to build the OData model.
var modelBuilder = new ODataConventionModelBuilder();

// Register the "Orders" entity set with the OData model builder.
modelBuilder.EntitySet<OrdersDetails>("Orders");

// Add services to the container.

// Add controllers with OData support to the service collection.
builder.Services.AddControllers().AddOData(
    options => options
        .Count()
        .OrderBy() 
        .AddRouteComponents("odata", modelBuilder.GetEdmModel()));

{% endhighlight %}

{% highlight cshtml tabtitle="Index.cshtml" %}
<ejs-grid id="Grid" height="280" allowSorting="true">
    <e-grid-columns>
        <e-grid-column field="OrderID" headerText="Order ID" width="120" textAlign="Right" isPrimaryKey="true" type="number"></e-grid-column>
        <e-grid-column field="CustomerID" headerText="Customer ID" width="150" type="string"></e-grid-column>
        <e-grid-column field="EmployeeID" headerText="Employee ID" width="150"></e-grid-column>
        <e-grid-column field="ShipCountry" headerText="Ship Country" width="150"></e-grid-column>
    </e-grid-columns>
</ejs-grid>
<script>
	class CustomAdaptor extends ej.data.ODataV4Adaptor {}
	document.addEventListener("DOMContentLoaded", function () {
		let grid = document.getElementById("Grid").ej2_instances[0];
		if (grid) {
			let dataManager = new ej.data.DataManager({
				url: "https://localhost:xxxx/odata/Orders", // Replace `xxxx` with your actual localhost port number.
				adaptor: new CustomAdaptor()
			});
			grid.dataSource = dataManager;
		}
	});
</script>
{% endhighlight %}
{% endtabs %}

**Single column sorting**

![Single column sorting query](../../images/adaptors/ODataV4Adaptor/odatav4-adaptor-sorting.png)

**Multi column sorting**

![Multi column sorting query](../../images/adaptors/ODataV4Adaptor/odatav4-adaptor-multi-column-sorting.png)

## Handling paging operation

To implement paging operations in your web application using OData, you can utilize the `SetMaxTop` method within your OData setup to limit the maximum number of records that can be returned per request. While you configure the maximum limit, clients can utilize the **$skip** and **$top** query options in their requests to specify the number of records to skip and the number of records to take, respectively. 

{% tabs %}
{% highlight cs tabtitle="Program.cs" %}

// Create a new instance of the web application builder.
var builder = WebApplication.CreateBuilder(args);

// Create an ODataConventionModelBuilder to build the OData model.
var modelBuilder = new ODataConventionModelBuilder();

// Register the "Orders" entity set with the OData model builder.
modelBuilder.EntitySet<OrdersDetails>("Orders");
 
// Add services to the container.

// Add controllers with OData support to the service collection.

var recordCount= OrdersDetails.GetAllRecords().Count;

builder.Services.AddControllers().AddOData(
    options => options
    .Count()
    .SetMaxTop(recordCount)
    .AddRouteComponents(
        "odata",
        modelBuilder.GetEdmModel()));

{% endhighlight %}

{% highlight cshtml tabtitle="Index.cshtml" %}
<ejs-grid id="Grid" height="280" allowPaging="true">
    <e-grid-columns>
        <e-grid-column field="OrderID" headerText="Order ID" width="120" textAlign="Right" isPrimaryKey="true" type="number"></e-grid-column>
        <e-grid-column field="CustomerID" headerText="Customer ID" width="150" type="string"></e-grid-column>
        <e-grid-column field="EmployeeID" headerText="Employee ID" width="150"></e-grid-column>
        <e-grid-column field="ShipCountry" headerText="Ship Country" width="150"></e-grid-column>
    </e-grid-columns>
</ejs-grid>
<script>
	class CustomAdaptor extends ej.data.ODataV4Adaptor {}
	document.addEventListener("DOMContentLoaded", function () {
		let grid = document.getElementById("Grid").ej2_instances[0];
		if (grid) {
			let dataManager = new ej.data.DataManager({
				url: "https://localhost:xxxx/odata/Orders", // Replace `xxxx` with your actual localhost port number.
				adaptor: new CustomAdaptor()
			});
			grid.dataSource = dataManager;
		}
	});
</script>
{% endhighlight %}
{% endtabs %}

![paging query](../../images/adaptors/ODataV4Adaptor/odatav4-adaptor-paging.png)

## Handling CRUD operations

To manage CRUD (Create, Read, Update, Delete) operations using the ODataV4Adaptor, follow the provided guide for configuring the Syncfusion Grid for [editing](https://ej2.syncfusion.com/aspnetcore/documentation/grid/editing/edit) and utilize the sample implementation of the `OrdersController` in your server application. This controller handles HTTP requests for CRUD operations such as GET, POST, PATCH, and DELETE.

To enable CRUD operations in the Syncfusion ASP.NET Core Grid, follow the below steps:

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
<ejs-grid id="Grid" height="280" toolbar="@(new List<string>() { "Add", "Edit", "Delete", "Update", "Cancel", "Search"})">
   <e-grid-editSettings allowAdding="true" allowDeleting="true" allowEditing="true" mode="Normal"></e-grid-editSettings>
    <e-grid-columns>
        <e-grid-column field="OrderID" headerText="Order ID" width="120" textAlign="Right" isPrimaryKey="true" type="number"></e-grid-column>
        <e-grid-column field="CustomerID" headerText="Customer ID" width="150" type="string"></e-grid-column>
        <e-grid-column field="EmployeeID" headerText="Employee ID" width="150"></e-grid-column>
        <e-grid-column field="ShipCountry" headerText="Ship Country" width="150"></e-grid-column>
    </e-grid-columns>
</ejs-grid>
<script>
	class CustomAdaptor extends ej.data.ODataV4Adaptor {}
	document.addEventListener("DOMContentLoaded", function () {
		let grid = document.getElementById("Grid").ej2_instances[0];
		if (grid) {
			let dataManager = new ej.data.DataManager({
				url: "https://localhost:xxxx/odata/Orders", // Replace `xxxx` with your actual localhost port number.
				adaptor: new CustomAdaptor()
			});
			grid.dataSource = dataManager;
		}
	});
</script>
{% endhighlight %}
{% endtabs %}

> Normal/Inline editing is the default edit `Mode` for the Grid. To enable CRUD operations, ensure that the [isPrimaryKey](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_IsPrimaryKey) property is set to **true** for a specific Grid column, ensuring that its value is unique.

**Insert Record**

To insert a new record into your Syncfusion Grid, you can utilize the `HttpPost` method in your server application. Below is a sample implementation of inserting a record using the **OrdersController**:

```cs
/// <summary>
/// Inserts a new order to the collection.
/// </summary>
/// <param name="addRecord">The order to be inserted.</param>
/// <returns>It returns the newly inserted record detail.</returns>
[HttpPost]
[EnableQuery]
public IActionResult Post([FromBody] OrdersDetails addRecord)
{
    if (addRecord == null)
    {
        return BadRequest("Null order");
    }
    OrdersDetails.GetAllRecords().Insert(0, addRecord);
    return Ok(addRecord);
}
```

![ODataV4Adaptor-Insert-record](../../images/adaptors/ODataV4Adaptor/odatav4-adaptor-insert-record.png)

**Update Record**

Updating a record in the Syncfusion Grid can be achieved by utilizing the `HttpPatch` method in your controller. Here's a sample implementation of updating a record:

```cs
/// <summary>
/// Updates an existing order.
/// </summary>
/// <param name="key">The ID of the order to update.</param>
/// <param name="updateRecord">The updated order details.</param>
/// <returns>It returns the updated order details.</returns>
[HttpPatch("{key}")]
public IActionResult Patch(int key, [FromBody] OrdersDetails updateRecord)
{
    if (updateRecord == null)
    {
        return BadRequest("No records to update.");
    }

    var existingOrder = OrdersDetails.GetAllRecords().FirstOrDefault(order => order.OrderID == key);
    if (existingOrder == null)
    {
        return NotFound($"Order with ID {key} not found.");
    }

    // Update fields only if they are provided.
    existingOrder.CustomerID = updateRecord.CustomerID ?? existingOrder.CustomerID;
    existingOrder.EmployeeID = updateRecord.EmployeeID ?? existingOrder.EmployeeID;
    existingOrder.ShipCountry = updateRecord.ShipCountry ?? existingOrder.ShipCountry;

    // Return the updated record.
    return Ok(existingOrder);
}
```
![ODataV4Adaptor-Update-record](../../images/adaptors/ODataV4Adaptor/odatav4-adaptor-update-record.png)

**Delete Record**

To delete a record from your Syncfusion Grid, you can utilize the `HttpDelete` method in your controller. Below is a sample implementation:

```cs
/// <summary>
/// Deletes an order.
/// </summary>
/// <param name="key">The ID of the order to delete.</param>
/// <returns>It returns the deleted record detail.</returns>
[HttpDelete("{key}")]
public IActionResult Delete(int key)
{
    var deleteRecord = OrdersDetails.GetAllRecords().FirstOrDefault(order => order.OrderID == key);
    if (deleteRecord != null)
    {
        OrdersDetails.GetAllRecords().Remove(deleteRecord);
    }
    return Ok(deleteRecord);
}
```
![ODataV4Adaptor-Delete-record](../../images/adaptors/ODataV4Adaptor/odatav4-adaptor-delete-record.png)
