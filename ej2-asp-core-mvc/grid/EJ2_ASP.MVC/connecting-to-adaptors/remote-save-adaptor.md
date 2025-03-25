---
layout: post
title: RemoteSaveAdaptor in Syncfusion ##Platform_Name## Grid.
description: Learn here all about how to bind data and perform CRUD action using RemoteSaveAdaptor in Syncfusion ##Platform_Name## Grid.
platform: ej2-asp-core-mvc
control: grid
keywords: Adaptors, RemoteSaveAdaptor, remotesave adaptor, remotedata 
publishingplatform: ##Platform_Name##
documentation: ug
domainurl: ##DomainURL##
---

# RemoteSaveAdaptor in Syncfusion ASP.NET MVC Grid

The `RemoteSaveAdaptor` in Syncfusion ASP.NET MVC Grid allows efficient handling of sorting, filtering, searching, and paging primarily on the client-side, while delegating CRUD operations (Create, Read, Update, Delete) to the server-side for data persistence. This approach reduces unnecessary server interactions, improving performance and user experience.

Ensure your server-side implementation in ASP.NET MVC handles CRUD operations. Below is an example of how you can set up your ASP.NET MVC controller to manage these operations:

**Server-Side Implementation**

To configure a server with Syncfusion ASP.NET MVC Grid, follow the below steps:

**1. Project Creation:**

Open Visual Studio and create an ASP.NET MVC project named **RemoteSaveAdaptor**. To create an ASP.NET MVC application, follow the documentation [link](https://learn.microsoft.com/en-us/aspnet/mvc/overview/getting-started/introduction/getting-started#create-your-first-app) for detailed steps.

**2. Model Class Creation:**

Create a model class named **OrdersDetails.cs** inside the **Models** folder on the server-side. This model will represent the order data structure.

```cs
using System.ComponentModel.DataAnnotations;

namespace RemoteSaveAdaptor_MVC.Models
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

**3. API Controller Creation:**

Create a file named `OrdersController.cs` under the **Controllers** folder. This controller will handle data retrieval and communication with the Syncfusion ASP.NET MVC Grid.

```cs
using RemoteSaveAdaptor_MVC.Models;
using System.Web.Mvc;

namespace RemoteSaveAdaptor_MVC.Controllers
{
    public class OrdersController : Controller
    {
        [HttpGet]
        public JsonResult GetOrderData()
        {
            // Retrieve data from the data source (e.g., database).
            var data = OrdersDetails.GetAllRecords();
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Post()
        {
            var data = OrdersDetails.GetAllRecords();
            // Get the total records count.
            int totalRecordsCount = data.Count;

            // Return data based on the request.
            return Json(new { result = data, count = totalRecordsCount });
        }}}
```

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

To insert a new record, utilize the `InsertUrl` property to specify the controller action mapping URL for the insert operation. Implement the `Insert` method in the API controller to handle the insertion of new records.The newly added record details are bound to the **newRecord** parameter.

![Insert record](../images/adaptors/remotesave-adaptor-insert.png)

```cs
     /// <summary>
     /// Inserts a new data item into the data collection.
     /// </summary>
     /// <returns>It returns the newly inserted record detail.</returns>
     [HttpPost]
     public JsonResult Insert(CRUDModel<OrdersDetails> newRecord)
     {
         if (newRecord.value != null)
         {
             var orders = OrdersDetails.GetAllRecords();
             newRecord.value.OrderID = orders.Max(o => o.OrderID) + 1;
             orders.Insert(0, newRecord.value);
         }

         return Json(newRecord.value);
     }
```

**Update Operation:**

For updating existing records, use the `UpdateUrl` property to specify the controller action mapping URL for the update operation. Implement the Update method in the API controller to handle record updates. The updated record details are bound to the **updatedRecord** parameter.

![Update record](../images/adaptors/remotesave-adaptor-update.png)

```cs
  /// <summary>
  /// Updates an existing order.
  /// </summary>
  /// <param name="updateRecord">The updated order details.</param>
  /// <returns>It returns the updated order details.</returns>
   public JsonResult Update(CRUDModel<OrdersDetails> updatedRecord)
   {
     var updatedOrder = updatedRecord.value;
     if (updatedOrder != null)
     {
         var data = OrdersDetails.GetAllRecords().FirstOrDefault(o => o.OrderID == updatedOrder.OrderID);
         if (data != null)
         {
             // Update the existing record.
             data.CustomerID = updatedOrder.CustomerID;
             data.ShipCity = updatedOrder.ShipCity;
             data.ShipCountry = updatedOrder.ShipCountry;
             data.Freight = updatedOrder.Freight;
             // Update other properties similarly.
         }
     }
     return Json(updatedRecord);
 }
```

**Delete Operation**

To delete existing records, use the `RemoveUrl` property to specify the controller action mapping URL for the delete operation. The primary key value of the deleted record is bound to the **deletedRecord** parameter.

![Delete Record](../images/adaptors/remotesave-adaptor-delete.png)

```cs
        /// <summary>
        /// Deletes an order.
        /// </summary>
        /// <param name="deletedRecord">It contains the specific record detail which is need to be removed.</param>
        /// <returns>It returns the deleted record detail.</returns>
        [HttpPost]
        public JsonResult Remove(CRUDModel<OrdersDetails> deletedRecord)
        {
            if (deletedRecord.key != null)
            {
                int orderId = int.Parse(deletedRecord.key.ToString());
                var orders = OrdersDetails.GetAllRecords();
                // Get key value from the deletedRecord.
                var data = orders.FirstOrDefault(o => o.OrderID == orderId);
                if (data != null)
                {
                    // Remove the record from the data collection.
                    orders.Remove(data);
                }
            }
            return Json(deletedRecord);
        }
```

## Connecting Syncfusion ASP.NET MVC Grid to an API Service

To integrate the Syncfusion Grid into your ASP.NET MVC project using Visual Studio, follow these steps:

**Step 1:** Install the Syncfusion ASP.NET MVC Package:

To add `ASP.NET MVC` in the application, open the NuGet package manager in Visual Studio (Tools → NuGet Package Manager → Manage NuGet Packages for Solution), search for [Syncfusion.EJ2.MVC5](https://www.nuget.org/packages/Syncfusion.EJ2.MVC5) and install it.
Alternatively, you can install it using the following Package Manager Console command:


{% tabs %}
{% highlight C# tabtitle="Package Manager" %}

Install-Package Syncfusion.EJ2.MVC5 -Version {{ site.releaseversion }}

{% endhighlight %}
{% endtabs %}

**Step 2:** Add Syncfusion ASP.NET MVC namespace:

Add `Syncfusion.EJ2` namespace reference in `Web.config` file under `Views` folder.

```cs
<namespaces>
    <add namespace="Syncfusion.EJ2"/>
</namespaces>
```

**Step 3:** Add stylesheet and script resources:

To include the required styles and scripts, add the following references inside the `<head>` section of `~/Pages/Shared/_Layout.cshtml`:

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

**Step 4:** Register Syncfusion Script Manager:

To ensure proper script execution, register the Syncfusion Script Manager `EJS().ScriptManager()` at the end of `<body>` in the `~/Pages/Shared/_Layout.cshtml`.

{% tabs %}
{% highlight cshtml tabtitle="~/_Layout.cshtml" %}

<body>
...
    <!-- Syncfusion ASP.NET MVC Script Manager -->
    @Html.EJS().ScriptManager()
</body>

{% endhighlight %}
{% endtabs %}

**Step 5:** Add ASP.NET MVC Grid:

Now, add the Syncfusion ASP.NET MVC Grid in `~/Views/Home/Index.cshtml` page.  The Grid will fetch data from a remote API and support various features such as paging, sorting, filtering, and CRUD operations.

***CRUD Operations Mapping:*** CRUD operations in the Grid can be mapped to server-side controller actions using the following properties:

* **InsertUrl**: Specifies the URL for inserting new data.
* **RemoveUrl**: Specifies the URL for removing existing data.
* **UpdateUrl**: Specifies the URL for updating existing data.
* **CrudUrl**: Specifies a single URL for all CRUD operations.
* **BatchUrl**: Specifies the URL for batch editing.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
@Html.EJS().Grid("Grid").EditSettings(edit => edit.AllowAdding(true).AllowEditing(true).AllowDeleting(true).Mode(Syncfusion.EJ2.Grids.EditMode.Normal)).Toolbar(new List<string>() { "Add", "Edit", "Delete", "Update", "Cancel", "Search" }).Columns(col =>
{
    col.Field("OrderID").HeaderText("Order ID").Width("120").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).IsPrimaryKey(true).Add();
    col.Field("CustomerID").HeaderText("Customer ID").Width("140").Add();
    col.Field("ShipCity").HeaderText("Ship City").Width("140").Add();
}).Render()
@section Scripts {
    <script>
    document.addEventListener("DOMContentLoaded", function () {
            loadGridData();
        });

        function loadGridData() {
            fetch('/Orders/GetOrderData') // Fetch from the backend API.
                .then(response => {
                    if (!response.ok) {
                        throw new Error("Failed to fetch data.");
                    }
                    return response.json();
                })
                .then(data => {
                    var dataManager = new ej.data.DataManager({
                        json: data,
                        insertUrl: '/Orders/Insert',
                        updateUrl: '/Orders/Update',
                        removeUrl: '/Orders/Remove',
                        adaptor: new ej.data.RemoteSaveAdaptor()
                    });

                    var grid = document.querySelector('#Grid')?.ej2_instances?.[0];
                    if (grid) {
                        grid.dataSource = dataManager;
                    } else {
                        console.error("Grid instance not found!");
                    }
                })
                .catch(error => console.error("Error:", error));
        }
    </script>
}
{% endhighlight %}
{% endtabs %}

**Step 7:** Run the Project

Run the project in Visual Studio, and the Syncfusion ASP.NET MVC Grid will successfully fetch data from the API service.
