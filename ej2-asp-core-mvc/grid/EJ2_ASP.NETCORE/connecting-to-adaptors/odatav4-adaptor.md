---
layout: post
title: ODataV4Adaptor in Syncfusion ##Platform_Name## Grid
description: Learn here all about Bind data and perform CRUD action with ODataV4Adaptor in Syncfusion ##Platform_Name## Grid of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Grid
keywords: Adaptors, ODataV4Adaptor, ODataV4 adaptor, remotedata 
publishingplatform: ##Platform_Name##
documentation: ug
---

# ODataV4Adaptor in Syncfusion ASP.NET Core Grid 

The `ODataV4Adaptor` in the Syncfusion Core Grid allows seamless integration of the Syncfusion Grid with OData v4 services, enabling efficient data fetching and manipulation. This guide provides detailed instructions on binding data and performing CRUD (Create, Read, Update, Delete) actions using the `ODataV4Adaptor` in your Syncfusion ASP.NET Core Grid.

## Creating an OData Service

To configure a server with Syncfusion ASP.NET Core Grid, follow the steps below:

**1. Project Creation:**

Open Visual Studio and create an ASP.NET Core project named **ODataV4Adaptor**. To create an ASP.NET Core application, follow the documentation [link](https://learn.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-8.0&tabs=visual-studio#create-a-razor-pages-web-app) for detailed steps.

**2. Install NuGet Packages**

Using the NuGet package manager in Visual Studio (Tools → NuGet Package Manager → Manage NuGet Packages for Solution), install the [Microsoft.AspNetCore.OData](https://www.nuget.org/packages?q=Microsoft.AspNetCore.OData) NuGet package.

**3. Model Class Creation:**

Create a model class named **OrdersDetails.cs** inside the **Models** folder on the server-side. This model will represent the order data structure.

{% tabs %}
{% highlight cs tabtitle="OrdersDetails.cs" %}

 using System.ComponentModel.DataAnnotations;

 namespace ODataV4Adaptor.Models
 {
  public class OrdersDetails
  {
    public static List<OrdersDetails> order = new List<OrdersDetails>();
    public OrdersDetails()
    {

    }
    public OrdersDetails(int OrderID, string CustomerId, int EmployeeId, string ShipCountry)
    {
        this.OrderID = OrderID;
        this.CustomerID = CustomerId;
        this.EmployeeID = EmployeeId;
        this.ShipCountry = ShipCountry;
    }

    public static List<OrdersDetails> GetAllRecords()
    {
        if (order.Count() == 0)
        {
            int code = 10000;
            for (int i = 1; i < 10; i++)
            {
                order.Add(new OrdersDetails(code + 1, "ALFKI", i + 0,  "Denmark"));
                order.Add(new OrdersDetails(code + 2, "ANATR", i + 2, "Brazil"));
                order.Add(new OrdersDetails(code + 3, "ANTON", i + 1, "Germany"));
                order.Add(new OrdersDetails(code + 4, "BLONP", i + 3, "Austria"));
                order.Add(new OrdersDetails(code + 5, "BOLID", i + 4, "Switzerland"));
                code += 5;
            }
        }
        return order;
    }
    [Key]
    public int? OrderID { get; set; }
    public string? CustomerID { get; set; }
    public int? EmployeeID { get; set; }
    public string? ShipCountry { get; set; }
  }
 }

{% endhighlight %}
{% endtabs %}

**4. Build the Entity Data Model**

To construct the Entity Data Model for your OData service, utilize the `ODataConventionModelBuilder` to define the model's structure. Start by creating an instance of the `ODataConventionModelBuilder`, then register the entity set **Orders** using the `EntitySet<T>` method, where `OrdersDetails` represents the CLR type containing order details. 

```cs
using ODataV4Adaptor.Models;
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
using ODataV4Adaptor.Models;

namespace ODataV4Adaptor.Controllers
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

**Step 5:** Add the Syncfusion ASP.NET Core Grid:

Now, add the Syncfusion ASP.NET Core Grid inside the `~/Pages/Index.cshtml` file.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
<ejs-grid id="Grid" height="315">
   <e-data-manager url="https://localhost:xxxx/odata/Orders" adaptor="ODataV4Adaptor"></e-data-manager> // Replace `xxxx` with your actual localhost port number.
   <e-grid-columns>
    <e-grid-column field="OrderID" headerText="Order ID" width="120" textAlign="Right" isPrimaryKey="true"></e-grid-column>
    <e-grid-column field="CustomerID" headerText="Customer ID" width="150"></e-grid-column>
    <e-grid-column field="EmployeeID" headerText="Employee ID" width="150"></e-grid-column>
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

> Replace https://localhost:xxxx/odata/Orders with the actual **URL** of your API endpoint that provides the data in a consumable format (e.g., JSON).

## Handling Searching Operation

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
{% highlight ts tabtitle="Index.cshtml" %}

 <ejs-grid id="Grid" height="280" toolbar="@(new List<string>() { "Search"})">
    <e-data-manager url="https://localhost:xxxx/odata/Orders" adaptor="ODataV4Adaptor"></e-data-manager>
     // Replace `xxxx` with your actual localhost port number.
    <e-grid-columns>
        <e-grid-column field="OrderID" headerText="Order ID" width="120" textAlign="Right" isPrimaryKey="true" type="number"></e-grid-column>
        <e-grid-column field="CustomerID" headerText="Customer ID" width="150" type="string"></e-grid-column>
        <e-grid-column field="EmployeeID" headerText="Employee ID" width="150"></e-grid-column>
        <e-grid-column field="ShipCountry" headerText="Ship Country" width="150"></e-grid-column>
    </e-grid-columns>
</ejs-grid>

{% endhighlight %}
{% endtabs %}

![Searching query](../images/adaptors/ODataV4Adaptor/odatav4-adaptor-searching.png)

## Handling Filtering Operation

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
{% highlight ts tabtitle="Index.cshtml" %}

 <ejs-grid id="Grid" height="280" allowFiltering="true">
    <e-data-manager url="https://localhost:xxxx/odata/Orders" adaptor="ODataV4Adaptor"></e-data-manager>
    // Replace `xxxx` with your actual localhost port number.
    <e-grid-columns>
            <e-grid-column field="OrderID" headerText="Order ID" width="120" textAlign="Right" isPrimaryKey="true" type="number"></e-grid-column>
            <e-grid-column field="CustomerID" headerText="Customer ID" width="150" type="string"></e-grid-column>
            <e-grid-column field="EmployeeID" headerText="Employee ID" width="150"></e-grid-column>
            <e-grid-column field="ShipCountry" headerText="Ship Country" width="150"></e-grid-column>
    </e-grid-columns>
</ejs-grid>

{% endhighlight %}
{% endtabs %}

Single column filtering
![Filtering query](../images/adaptors/ODataV4Adaptor/odatav4-adaptor-filtering.png)
Multi column filtering
![Filtering query](../images/adaptors/ODataV4Adaptor/odatav4-adaptor-multi-column-filtering.png)

## Handling Sorting Operation

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
{% highlight ts tabtitle="Index.cshtml" %}

<ejs-grid id="Grid" height="280" allowSorting="true">
    <e-data-manager url="https://localhost:xxxx/odata/Orders" adaptor="ODataV4Adaptor"></e-data-manager>
    // Replace `xxxx` with your actual localhost port number.
    <e-grid-columns>
        <e-grid-column field="OrderID" headerText="Order ID" width="120" textAlign="Right" isPrimaryKey="true" type="number"></e-grid-column>
        <e-grid-column field="CustomerID" headerText="Customer ID" width="150" type="string"></e-grid-column>
        <e-grid-column field="EmployeeID" headerText="Employee ID" width="150"></e-grid-column>
        <e-grid-column field="ShipCountry" headerText="Ship Country" width="150"></e-grid-column>
    </e-grid-columns>
</ejs-grid>

{% endhighlight %}
{% endtabs %}

**Single column sorting**

![Single column sorting query](../images/adaptors/ODataV4Adaptor/odatav4-adaptor-sorting.png)

**Multi column sorting**

![Multi column sorting query](../images/adaptors/ODataV4Adaptor/odatav4-adaptor-multi-column-sorting.png)

## Handling Paging Operation

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
{% highlight ts tabtitle="Index.cshtml" %}

<ejs-grid id="Grid" height="280" allowPaging="true">
    <e-data-manager url="https://localhost:xxxx/odata/Orders" adaptor="ODataV4Adaptor"></e-data-manager>
    // Replace `xxxx` with your actual localhost port number.
    <e-grid-columns>
        <e-grid-column field="OrderID" headerText="Order ID" width="120" textAlign="Right" isPrimaryKey="true" type="number"></e-grid-column>
        <e-grid-column field="CustomerID" headerText="Customer ID" width="150" type="string"></e-grid-column>
        <e-grid-column field="EmployeeID" headerText="Employee ID" width="150"></e-grid-column>
        <e-grid-column field="ShipCountry" headerText="Ship Country" width="150"></e-grid-column>
    </e-grid-columns>
</ejs-grid>

{% endhighlight %}
{% endtabs %}

![paging query](../images/adaptors/ODataV4Adaptor/odatav4-adaptor-paging.png)

## Handling CRUD operations

To manage CRUD (Create, Read, Update, Delete) operations using the ODataV4Adaptor, follow the provided guide for configuring the Syncfusion Grid for [editing](https://ej2.syncfusion.com/aspnetcore/documentation/grid/editing/edit) and utilize the sample implementation of the `OrdersController` in your server application. This controller handles HTTP requests for CRUD operations such as GET, POST, PATCH, and DELETE.

To enable CRUD operations in the Syncfusion ASP.NET Core Grid, follow the below steps:

{% tabs %}
{% highlight ts tabtitle="Index.cshtml" %}

<ejs-grid id="Grid" height="280" toolbar="@(new List<string>() { "Add", "Edit", "Delete", "Update", "Cancel", "Search"})">
   <e-grid-editSettings allowAdding="true" allowDeleting="true" allowEditing="true" mode="Normal"></e-grid-editSettings>
    <e-data-manager url="https://localhost:xxxx/odata/Orders" adaptor="ODataV4Adaptor"></e-data-manager>
    // Replace `xxxx` with your actual localhost port number.
    <e-grid-columns>
        <e-grid-column field="OrderID" headerText="Order ID" width="120" textAlign="Right" isPrimaryKey="true" type="number"></e-grid-column>
        <e-grid-column field="CustomerID" headerText="Customer ID" width="150" type="string"></e-grid-column>
        <e-grid-column field="EmployeeID" headerText="Employee ID" width="150"></e-grid-column>
        <e-grid-column field="ShipCountry" headerText="Ship Country" width="150"></e-grid-column>
    </e-grid-columns>
</ejs-grid>

{% endhighlight %}
{% endtabs %}

> Normal/Inline editing is the default edit `mode` for the Grid control. To enable CRUD operations, ensure that the `isPrimaryKey` property is set to **true** for a specific Grid column, ensuring that its value is unique.

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

![ODataV4Adaptor-Insert-record](../images/adaptors/ODataV4Adaptor/odatav4-adaptor-insert-record.png)

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
![ODataV4Adaptor-Update-record](../images/adaptors/ODataV4Adaptor/odatav4-adaptor-update-record.png)

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
![ODataV4Adaptor-Delete-record](../images/adaptors/ODataV4Adaptor/odatav4-adaptor-delete-record.png)

## Odata with custom url

The Syncfusion ODataV4 adaptor extends support for calling customized URLs to accommodate data retrieval and CRUD actions as per your application's requirements. However, when utilizing a custom URL with the ODataV4 adaptor, it's essential to modify the routing configurations in your application's route configuration file to align with your custom URL. You can invoke the custom URL by the following methods in the `DataManager`.

**Configuring Custom URLs**

To work with custom URLs for CRUD operations in the Syncfusion Grid, you can use the following properties:

* insertUrl: Specifies the custom URL for inserting new records.
* removeUrl: Specifies the custom URL for deleting records.
* updateUrl: Specifies the custom URL for updating records.
* batchUrl: Specifies the custom URL for batch editing operations.

> Ensure that the routing configurations on the server-side are properly updated to handle these custom URLs.

The following code example describes the above behavior.

{% tabs %}
{% highlight ts tabtitle="Index.cshtml" %}
<ejs-grid id="Grid" height="280" toolbar="@(new List<string>() { "Add", "Edit", "Delete", "Update", "Cancel", "Search"})">
   <e-grid-editSettings allowAdding="true" allowDeleting="true" allowEditing="true" mode="Normal"></e-grid-editSettings>
   <e-data-manager url="https://localhost:xxxx/odata/Orders"
                   updateUrl= "https://localhost:xxxx/odata/Orders/Update" 
                   insertUrl= "https://localhost:xxxx/odata/Orders/Insert" 
                   removeUrl= "https://localhost:xxxx/odata/Orders/Delete" 
                   adaptor="ODataV4Adaptor">
   </e-data-manager> // Replace `xxxx` with your actual localhost port number.
   <e-grid-columns>
    <e-grid-column field="OrderID" headerText="Order ID" width="120" textAlign="Right" isPrimaryKey="true" type="number"></e-grid-column>
    <e-grid-column field="CustomerID" headerText="Customer ID" width="150" type="string"></e-grid-column>
    <e-grid-column field="EmployeeID" headerText="Employee ID" width="150"></e-grid-column>
    <e-grid-column field="ShipCountry" headerText="Ship Country" width="150"></e-grid-column>
   </e-grid-columns>
</ejs-grid>
{% endhighlight %}
{% endtabs %}

For batch editing, you can specify a custom batch URL as follows:

{% tabs %}
{% highlight ts tabtitle="Index.cshtml" %}
<ejs-grid id="Grid" height="280" toolbar="@(new List<string>() { "Add", "Edit", "Delete", "Update", "Cancel", "Search"})">
   <e-grid-editSettings allowAdding="true" allowDeleting="true" allowEditing="true" mode="Normal"></e-grid-editSettings>
   <e-data-manager url="https://localhost:xxxx/odata/Orders" 
                   batchUrl= "https://localhost:xxxx/odata/Orders/BatchUpdate"
                   adaptor="ODataV4Adaptor">
   </e-data-manager> // Replace `xxxx` with your actual localhost port number.
   <e-grid-columns>
    <e-grid-column field="OrderID" headerText="Order ID" width="120" textAlign="Right" isPrimaryKey="true" type="number"></e-grid-column>
    <e-grid-column field="CustomerID" headerText="Customer ID" width="150" type="string"></e-grid-column>
    <e-grid-column field="EmployeeID" headerText="Employee ID" width="150"></e-grid-column>
    <e-grid-column field="ShipCountry" headerText="Ship Country" width="150"></e-grid-column>
   </e-grid-columns>
</ejs-grid>
{% endhighlight %}
{% endtabs %}