---
layout: post
title: RemoteSaveAdaptor in Syncfusion ##Platform_Name## Grid.
description: Learn here all about how to bind data and perform CRUD action using RemoteSaveAdaptor in Syncfusion ##Platform_Name## Grid.
platform: ej2-asp-core-mvc
control: Grid
keywords: Adaptors, RemoteSaveAdaptor, remotesave adaptor, remotedata 
publishingplatform: ##Platform_Name##
documentation: ug
domainurl: ##DomainURL##
---

# RemoteSaveAdaptor in Syncfusion ASP.NET Core Grid

The `RemoteSaveAdaptor` in Syncfusion ASP.NET Core Grid allows efficient handling of sorting, filtering, searching, and paging primarily on the client-side, while delegating CRUD operations (Create, Read, Update, Delete) to the server-side for data persistence. This approach reduces unnecessary server interactions, improving performance and user experience.

Ensure your server-side implementation in ASP.NET Core handles CRUD operations. Here is an example of how you can set up your ASP.NET Core controller to handle these operations:

**Server-Side Implementation**

To configure the server for Syncfusion ASP.NET Core Grid, follow these steps:

**1. Project Creation:**

Open Visual Studio and create an ASP.NET Core project named **RemoteSaveAdaptor**. To create an ASP.NET Core application, follow the documentation [link](https://learn.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-8.0&tabs=visual-studio#create-a-razor-pages-web-app) for detailed steps.

**2. Model Class Creation:**

Create a model class named **OrdersDetails.cs** inside the **Models** folder on the server-side. This model will represent the order data structure.

```cs
using System.ComponentModel.DataAnnotations;

namespace RemoteSaveAdaptor.Models
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

```

**3. API controller creation:**

Create a file named `OrdersController.cs` under the **Controllers** folder. This controller will handle data retrieval and communication with the Syncfusion ASP.NET Core Grid.

```cs
using Microsoft.AspNetCore.Mvc;
using RemoteSaveAdaptor.Models;

namespace RemoteSaveAdaptor.Controllers
{
  [ApiController]
  public class OrdersController : Controller
  {
    /// <summary>
    /// Handles HTTP POST requests to retrieve order data.
    /// </summary>
    /// <returns>Returns an object containing the list of orders and the total record count.</returns>
    [HttpPost]
    [Route("api/[controller]")]
    public object Post()
    {
      // Retrieve data from the data source (e.g., database).
      IQueryable<OrdersDetails> DataSource = GetOrderData().AsQueryable();

      // Get the total records count.
      int totalRecordsCount = DataSource.Count();

      // Return data based on the request.
      return new { result = DataSource, count = totalRecordsCount };
    }

    /// <summary>
    /// Retrieves all order records from the data source.
    /// </summary>
    /// <returns>Returns a list of all order details.</returns
    [HttpGet]
    [Route("api/[controller]")]
    public List<OrdersDetails> GetOrderData()
    {
      var data = OrdersDetails.GetAllRecords().ToList();
      return data;
    }
  }
}
```

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

To insert a new record, utilize the `insertUrl` property to specify the controller action mapping URL for the insert operation. Implement the `Insert` method in the API controller to handle the addition of new records.  The details of the newly added record are bound to the **newRecord** parameter.

![Insert record](../images/adaptors/remotesave-adaptor-insert.png)

```cs
  /// <summary>
  /// Inserts a new data item into the data collection.
  /// </summary>
  /// <param name="newRecord">The order to be inserted.</param>
  /// <returns>It returns the newly inserted record detail.</returns>
  [HttpPost]
  [Route("api/Orders/Insert")]
  public ActionResult Insert([FromBody] CRUDModel<OrdersDetails> newRecord)
  {
      if (newRecord.value !=null)
      {
          OrdersDetails.GetAllRecords().Insert(0, newRecord.value);
      }
      
      return Json(newRecord.value);
  }
```

**Update Operation:**

For updating existing records, use the `updateUrl` property to specify the controller action mapping URL for the update operation. Implement the `Update` method in the API controller to handle record updates. The updated record details are bound to the **updatedRecord** parameter.

![Update record](../images/adaptors/remotesave-adaptor-update.png)

```cs
  /// <summary>
  /// Updates an existing order.
  /// </summary>
  /// <param name="updateRecord">The updated order details.</param>
  /// <returns>It returns the updated order details.</returns>
  [HttpPost]
  [Route("api/Orders/Update")]
  public object Update([FromBody] CRUDModel<OrdersDetails> updatedRecord)
  {
    var updatedOrder = updatedRecord.value;
    if (updatedOrder != null)
    {
      var data = OrdersDetails.GetAllRecords().FirstOrDefault(or => or.OrderID == updatedOrder.OrderID);
      if (data != null)
      {
        // Update the existing record.
        data.OrderID = updatedOrder.OrderID;
        data.CustomerID = updatedOrder.CustomerID;
        data.Freight = updatedOrder.Freight;
        data.ShipCity = updatedOrder.ShipCity;
        data.ShipCountry = updatedOrder.ShipCountry;
        data.Verified = updatedOrder.Verified;
        // Update other properties similarly.
      }
    }
    return updatedRecord;
  }
```

**Delete Operation**

To delete existing records, use the `removeUrl` property to specify the controller action mapping URL for the delete operation. The primary key value of the deleted record is bound to the **deletedRecord** parameter.

![Delete Record](../images/adaptors/remotesave-adaptor-delete.png)

```cs
  /// <summary>
  /// Deletes an order.
  /// </summary>
  /// <param name="deletedRecord">It contains the specific record detail which is need to be removed.</param>
  /// <returns>It returns the deleted record detail.</returns>
  [HttpPost]
  [Route("api/Orders/Remove")]
  public object Remove([FromBody] CRUDModel<OrdersDetails> deletedRecord)
  {
      int orderId = int.Parse(deletedRecord.key.ToString()); // Get key value from the deletedRecord.
      var data = OrdersDetails.GetAllRecords().FirstOrDefault(orderData => orderData.OrderID == orderId);
      if (data != null)
      {
          // Remove the record from the data collection.
          OrdersDetails.GetAllRecords().Remove(data);
      }
      return deletedRecord;
  }
```

**4. Run the Application:**

Run the application in Visual Studio. It will be accessible on a URL like **https://localhost:xxxx**. 

After running the application, you can verify that the server-side API controller is successfully returning the order data in the URL(https://localhost:xxxx/api/Grid). Here **xxxx** denotes the port number.

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

**Step 2:** Add Syncfusion ASP.NET Core tag helper

Open `~/Pages/_ViewImports.cshtml` file and import the `Syncfusion.EJ2` tagHelper.

{% tabs %}
{% highlight C# tabtitle="~/_ViewImports.cshtml" %}

@addTagHelper *, Syncfusion.EJ2

{% endhighlight %}
{% endtabs %}

**Step 3:** Add stylesheets and script resources

To include the required styles and scripts, add the following references inside the `<head>` of `~/Pages/Shared/_Layout.cshtml` file:

{% tabs %}
{% highlight cshtml tabtitle="~/_Layout.cshtml" %}

<head>
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

**Step 5:** Add ASP.NET Core Grid:

Now, add the Syncfusion ASP.NET Core Grid tag helper in `~/Pages/Index.cshtml` page. The Grid will fetch data from a remote API and support various features such as paging, sorting, filtering, and CRUD operations.

***CRUD operations mapping:*** CRUD operations in the Grid can be mapped to server-side controller actions using the following properties:

* **insertUrl**: Specifies the URL for inserting new data.
* **removeUrl**: Specifies the URL for removing existing data.
* **updateUrl**: Specifies the URL for updating existing data.
* **crudUrl**: Specifies a single URL for all CRUD operations.
* **batchUrl**: Specifies the URL for batch editing.


{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}

<ejs-grid id="Grid" height="315" toolbar="@(new List<string>() { "Add", "Edit", "Delete", "Update", "Cancel"})">
    <e-grid-editSettings allowAdding="true" allowDeleting="true" allowEditing="true"></e-grid-editSettings>
    <e-grid-columns>
        <e-grid-column field="OrderID" headerText="Order ID" width="120" textAlign="Right" isPrimaryKey="true"></e-grid-column>
        <e-grid-column field="CustomerID" headerText="Customer ID" width="160"></e-grid-column>
        <e-grid-column field="ShipCity" headerText="Ship City" width="150"></e-grid-column>
        <e-grid-column field="ShipCountry" headerText="Ship Country" width="150"></e-grid-column>
    </e-grid-columns>
</ejs-grid>

@section Scripts {
    <script>
        document.addEventListener("DOMContentLoaded", function () {
            load();
        });

        function load() {
            fetch('/api/Orders')  // Fetch from the backend API.
                .then(response => {
                    if (!response.ok) {
                        throw new Error("Unable to Fetch Data. Please check URL or network connectivity.");
                    }
                    return response.json();
                })
                .then(jsonValue => {
                    let data = new ej.data.DataManager({
                        json: jsonValue,
                        insertUrl: '/api/Orders/Insert',
                        updateUrl: '/api/Orders/Update',
                        removeUrl: '/api/Orders/Remove',
                        adaptor: new ej.data.RemoteSaveAdaptor()
                    });

                    createGrid(data);
                })
                .catch(error => console.error("Error fetching data:", error));
        }

        function createGrid(data) {
          var grid = document.querySelector('#Grid')?.ej2_instances?.[0];
          if (!grid) {
              console.error("Grid instance not found!");
              return;
          }
          grid.dataSource = data
        }
    </script>
}

{% endhighlight %}
{% endtabs %}

**Step 6:** Configure the server:

In the `Program.cs` file of your project, configure the server to serve static files by adding the following code:

```cs
builder.Services.AddRazorPages();
builder.Services.AddControllers();

var app = builder.Build();

app.MapRazorPages();
app.MapControllers();
```

**Step 7:** Run the Project:

Run the project in Visual Studio, and the Syncfusion ASP.NET Core Grid will successfully fetch data from the API service.

> Please find the sample in this [GitHub location](https://github.com/SyncfusionExamples/Binding-data-from-remote-service-to-asp.net-core-data-grid/tree/master/RemoteSaveAdaptor_EJ2Core).