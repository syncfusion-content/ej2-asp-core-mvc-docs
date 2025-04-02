---
layout: post
title: Foreign Key Column in Syncfusion ##Platform_Name## Grid Component
description: Learn here all about Foreign Key Column in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Foreign Key Column
publishingplatform: ##Platform_Name##
documentation: ug
---

# Foreign key column in ASP.NET MVC Grid component

The Foreign key column in the Syncfusion Grid component allows you to display related data from a foreign key data source in a column within the grid. This feature is particularly useful when you have a column in the grid that represents a foreign key relationship with another data source.

To enable and integrate the foreign key column in the ASP.NET MVC Grid component, follow these steps:

1. Define the foreign key column in the grid using the following properties:

* `DataSource`: Specifies the foreign data source that contains the related data.

* `ForeignKeyField`: Maps the column name in the grid to the field in the foreign data source that represents the foreign key relationship.

* `ForeignKeyValue`: Specifies the field from the foreign data source that should be displayed in the grid as the related data.

```html
    col.Field("EmployeeID").HeaderText("Employee Name").Width("140").foreignKeyField("EmployeeID").ForeignKeyValue("FirstName").DataSource(ViewBag.ForeignData).Add();
```

>The `ForeignKeyField` property should match the name of the field in the foreign data source that represents the foreign key relationship, and the `ForeignKeyValue` property should specify the field from the foreign data source that should be displayed in the grid as the related data.

## Binding local data

The Syncfusion Grid component provides a convenient way to bind local data to a foreign key column. This allows you to display related data from a local data source within the grid. Here's an example of how to bind local data to a Foreign Key column in Syncfusion Grid:

In this example, **data** is the local data source for the Grid, and **employeeData** is the local data source for the foreign key column. The `Field` property of the column is set to **EmployeeID** which represents the foreign key value in the **data**. The `ForeignKeyValue` property is set to **FirstName** which represents the field name in the **employeeData** that you want to display in the foreign key column.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/foreign/razor %}
{% endhighlight %}
{% highlight c# tabtitle="foreign.cs" %}
{% include code-snippet/grid/columns/foreign/foreign.cs %}
{% endhighlight %}
{% highlight c# tabtitle="employeeView.cs" %}
{% include code-snippet/grid/columns/foreign/employeeView.cs %}
{% endhighlight %}
{% endtabs %}

![Binding local data](../images/foreign/foreign-local.png)

## Binding remote data

The Foreign key column in Syncfusion Grid allows you to bind remote data for a foreign key column. You can assign the service data as an instance of `DataManager` to the `DataSource` property, and provide the endpoint `URL` as the data source URL.

This example demonstrates how to use the foreign key column with remote data binding using the [ODataV4Adaptor](https://ej2.syncfusion.com/aspnetmvc/documentation/grid/data-binding/remote-data#odata-v4-adaptor---binding-odata-v4-service) in the grid:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/foreign-remote/razor %}
{% endhighlight %}
{% endtabs %}

![Binding remote data](../images/foreign/foreign-remote.png)

> * For remote data, the sorting and grouping is done based on `Column.ForeignKeyField` instead of `Column.ForeignKeyValue`.
> * If `Column.ForeignKeyField` is not defined, then the column uses `Column.Field`.

## Use edit template in foreign key column

The Syncfusion Grid provides support for using an edit template in a foreign key column. By default, a dropdown component is used for editing foreign key column. However, you can render a different component for editing by using the `Column.Edit` property. Here's an example that demonstrates how to use an edit template in a foreign key column:

In this example, an [AutoComplete](https://ej2.syncfusion.com/aspnetmvc/documentation/auto-complete/getting-started) component is rendered as the edit template for the **"EmployeeID"** foreign key column. The [DataSource](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.AutoComplete.html#Syncfusion_EJ2_DropDowns_AutoComplete_DataSource) property of the AutoComplete component is set to the employees data, and the fields property is configured to display the **"FirstName"** field as the value.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/edit-template-foreign/razor %}
{% endhighlight %}
{% highlight c# tabtitle="edit-template-foreign.cs" %}
{% include code-snippet/grid/how-to/edit-template-foreign/edit-template-foreign.cs %}
{% endhighlight %}
{% endtabs %}

![Use edit template in foreign key column](../images/foreign/foreign-edit-template.gif)

## Customize filter UI of foreign key column

The Syncfusion Grid allows you to customize the filtering user interface (UI) for foreign key columns by using the `Column.Filter` property. By default, a dropdown component is used for filtering foreign key columns. However, you can create your own custom filtering UI by specifying a template function for the `Column.Filter` property. Here's an example that demonstrates how to create a custom filtering UI in a foreign key column:

In this example, a [DropDownList](https://ej2.syncfusion.com/aspnetmvc/documentation/drop-down-list/getting-started) component is rendered as the filter UI for the **"EmployeeID"** foreign key column. The [DataSource](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_DataSource) property of the DropDownList component is set to the employees data, and the fields property is configured to display the **FirstName** field as the `Text` and **EmployeeID** field as the `Value`. The `Value` property is set to the current filter value of the column.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/filter-ui-foreign/razor %}
{% endhighlight %}
{% highlight c# tabtitle="filter-ui-foreign.cs" %}
{% include code-snippet/grid/how-to/filter-ui-foreign/filter-ui-foreign.cs %}
{% endhighlight %}
{% endtabs %}

![Customize filter UI of foreign key column](../images/foreign/foreign-filter.gif)

## Use filter bar template in foreign key column

You can use the filter bar template in a foreign key column in Grid by defining the `Column.FilterBarTemplate` property. This allows you to customize the filter bar for the foreign key column with a custom component or HTML template. Here's an example that demonstrates how to use a filter bar template in a foreign key column:

In this example, the **"EmployeeID"** column is a foreign key column, and the **filter** function is used as the filter bar template for this column. The `Filter` function can be defined in your component code and should return the desired component or HTML template for the filter bar. The column header shows the custom filter bar template and you can select filter value by using the **DropDown** options.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/filterbar-temp-foreign/razor %}
{% endhighlight %}
{% highlight c# tabtitle="filterbar-temp-foreign.cs" %}
{% include code-snippet/grid/how-to/filterbar-temp-foreign/filterbar-temp-foreign.cs %}
{% endhighlight %}
{% endtabs %}

![Use filter bar template in foreign key column](../images/foreign/foreign-filter-template.png)

## Perform aggregation in foreign key column

By default, aggregations are not supported in a foreign key column in the Syncfusion Grid. However, you can achieve aggregation for a foreign key column by using `CustomAggregate`.

To perform aggregation in a foreign key column, follow these steps:

1.Define a foreign key column in the Grid.
2.Implement a custom aggregate function to calculate the aggregation for the foreign key column.
3.Set the `CustomAggregate` property of the column to the custom aggregate function.

Here's an example that demonstrates how to perform aggregation in a foreign key column:

In the provided example, the `customAggregateFn` function is used to filter the data based on the **FirstName** field of the foreign key column, using the `getForeignData` internal function. The function then counts the occurrences of **Margaret**. The result is displayed in the grid's footer template using the ng-template with the `FooterTemplate` reference.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/aggregate-foreign/razor %}
{% endhighlight %}
{% highlight c# tabtitle="aggregate-foreign.cs" %}
{% include code-snippet/grid/how-to/aggregate-foreign/aggregate-foreign.cs %}
{% endhighlight %}
{% endtabs %}

![Customize filter UI of foreign key column](../images/foreign/foreign-aggergate.png)

## Render foreign key value in column template

The Syncfusion ASP.NET MVC Grid allows for rendering foreign key values within a column template, enhancing the display of related data in a clear format. This feature is particularly useful when you want to show a more meaningful representation of a foreign key instead of its underlying value.

To render foreign key values in a column template, you need to define a template for the column using the [Template](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Template) property. The `Template` property can accept either an HTML element or a function that returns the desired HTML element.

The following example demonstrates how to render foreign key values in a column template within the Grid: 

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/foreignkey-columntemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="foreignkey-columntemplate.cs" %}
{% include code-snippet/grid/columns/foreignkey-columntemplate/foreignkey-columntemplate.cs %}
{% endhighlight %}
{% highlight c# tabtitle="OrdersDetails.cs" %}
{% include code-snippet/grid/columns/foreignkey-columntemplate/OrdersDetails.cs %}
{% endhighlight %}
{% highlight c# tabtitle="EmployeeDetails.cs" %}
{% include code-snippet/grid/columns/foreignkey-columntemplate/EmployeeDetails.cs %}
{% endhighlight %}
{% endtabs %}

![Render foreign key value in column template](../images/foreign/foreign-key-in-column-template.png)

## Enable multiple foreign key columns

The Syncfusion Grid component supports the feature of enabling multiple foreign key columns with editing options. This allows users to display columns from foreign data sources in the Grid component.

In the following example, **Customer Name** and **Ship City** are foreign key columns that display the **ContactName** and **City** columns from foreign data.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/foreignkeycol-multiple/razor %}
{% endhighlight %}
{% highlight c# tabtitle="foreignkeycol-multiple.cs" %}
{% include code-snippet/grid/columns/foreignkeycol-multiple/foreignkeycol-multiple.cs %}
{% endhighlight %}
{% endtabs %}

![Enable multiple foreign key columns](../images/foreign/foreign-multiple.png)

## Edit template in foreign key column using remote data

The Syncfusion ASP.NET MVC Grid allows you to customize the edit template for foreign key columns when using remote data. By default, a [DropDownList](https://ej2.syncfusion.com/aspnetmvc/documentation/drop-down-list/getting-started) component is used for editing foreign key column. However, you can render a different component by configuring the [Column.Edit](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Edit) property. 

This example demonstrates how to use an edit template in a foreign key column with remote data. In this case, an [AutoComplete](https://ej2.syncfusion.com/aspnetmvc/documentation/auto-complete/getting-started) component is rendered as the edit template for the **EmployeeID** foreign key column. The [DataSource](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.AutoComplete.html#Syncfusion_EJ2_DropDowns_AutoComplete_DataSource) property of the **AutoComplete** component is set to the employees data, and the [Field](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Field) property is configured to display the **FirstName** field as the value. Follow the steps below to achieve this:

**Step 1:** Open Visual Studio and create an ASP.NET MVC project named **UrlAdaptor**. To create an ASP.NET MVC application, follow the documentation [link](https://learn.microsoft.com/en-us/aspnet/mvc/overview/getting-started/introduction/getting-started#create-your-first-app) for detailed steps.

**Step 2 :** Create a simple Syncfusion ASP.NET MVC Grid by following the [Getting Started](https://ej2.syncfusion.com/aspnetmvc/documentation/grid/getting-started-mvc) documentation link.

**Step 3:** In your ASP.NET MVC file (e.g., **Index.cshtml**), define the Syncfusion ASP.NET MVC Grid with the necessary configurations, including a foreign key column for **EmployeeID**, and implement the required logic to manage its behavior.

```cs
@*Replace **** with your actual port number.*@
@Html.EJS().Grid("grid").DataSource(dataManger => { dataManger.Url("https://localhost:****/api/Grid").Adaptor("UrlAdaptor"); }).Height("348px").Columns(col =>
{
  col.Field("OrderID").HeaderText("Order ID").IsPrimaryKey(true).Width("120").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).Add();
  col.Field("EmployeeID").ForeignKeyField("EmployeeID").ForeignKeyValue("FirstName").DataSource(dataManger => { dataManger.Url("https://localhost:****/api/Employees/").Adaptor("UrlAdaptor"); }).HeaderText("Employee Name").Width("140").Edit(new { create = "create", read = "read", destroy = "destroy", write = "write" }).Add();
  col.Field("Freight").HeaderText("Freight").Width("120").Format("C2").EditType("numericedit").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).Add();
  col.Field("ShipCity").HeaderText("Ship City").Width("150").Add();
}).EditSettings(edit => { edit.AllowAdding(true).AllowEditing(true).AllowDeleting(true); }).Toolbar(new List<string>() { "Add", "Edit", "Delete", "Update", "Cancel" }).Render()

<script>
let autoComplete;
let employeeData = new ej.data.DataManager({
	url: 'https://localhost:****/api/Employees', //Replace **** with your actual port number.
	adaptor: new ej.data.UrlAdaptor(),
	crossDomain: true,
});

function create() {
	return ej.base.createElement('input');
}

function destroy() {
	if (autoComplete) autoComplete.destroy();
}

function read() {
	return autoComplete ? autoComplete.value : '';
}

function write(args) {
	let selectedValue = args.rowData ? args.rowData.employeeID : '';
	employeeData.executeQuery(new ej.data.Query()).then((data) => {
		let employees = data.result;
		autoComplete = new ej.dropdowns.AutoComplete({
			dataSource: employees,
			fields: { value: "EmployeeID", text: "FirstName" },
			value: selectedValue,
			placeholder: "Select Employee",
			allowFiltering: true,
			filtering: function (e) {
				let query = new ej.data.Query();
				query = e.text ? query.where("FirstName", "startswith", e.text, true) : query;
				e.updateData(employees, query);
			},
			change: function (e) {
				if (e.itemData) {
					args.rowData.employeeID = e.itemData.employeeID;
				}
			}
		});
		autoComplete.appendTo(args.element);
	}).catch((error) => {
		console.error("Error fetching employee data:", error);
	});
}
</script>
```

**Step 4:** On the server side, create a controller named **GridController.cs** and **EmployeesController.cs** under the **Controllers** folder to handle API requests:

```cs
namespace EditTemplate.Controllers
{
    [ApiController]
    public class GridController : Controller
    {
        [HttpPost]
        [Route("api/[controller]")]
        public object Post()
        {
            // Retrieve data from the data source (e.g., database).
            IQueryable<OrdersDetails> DataSource = GetOrderData().AsQueryable();

            // Get the total count of records.
            int totalRecordsCount = DataSource.Count();

            // Return data based on the request.
            return new { result = DataSource, count = totalRecordsCount };
        }

        [HttpGet]
        [Route("api/[controller]")]
        public List<OrdersDetails> GetOrderData()
        {
            var data = OrdersDetails.GetAllRecords().ToList();
            return data;
        }

        /// <summary>
        /// Inserts a new data item into the data collection.
        /// </summary>
        /// <param name="newRecord">It contains the new record detail which is need to be inserted.</param>
        /// <returns>Returns void.</returns>
        [HttpPost]
        [Route("api/Grid/Insert")]
        public void Insert(CRUDModel<OrdersDetails> newRecord)
        {
            if (newRecord.value != null)
            {
                OrdersDetails.GetAllRecords().Insert(0, newRecord.value);
            }
        }

        /// <summary>
        /// Update a existing data item from the data collection.
        /// </summary>
        /// <param name="Order">It contains the updated record detail which is need to be updated.</param>
        /// <returns>Returns void.</returns>
        [HttpPost]
        [Route("api/Grid/Update")]
        public void Update(CRUDModel<OrdersDetails> Order)
        {
            var updatedOrder = Order.value;
            if (updatedOrder != null)
            {
                var data = OrdersDetails.GetAllRecords().FirstOrDefault(or => or.OrderID == updatedOrder.OrderID);
                if (data != null)
                {
                    // Update the existing record.
                    data.OrderID = updatedOrder.OrderID;
                    data.CustomerID = updatedOrder.CustomerID;
                    data.EmployeeID = updatedOrder.EmployeeID;
                    data.ShipCity = updatedOrder.ShipCity;
                    data.ShipCountry = updatedOrder.ShipCountry;
                    // Update other properties similarly.
                }
            }

        }
        /// <summary>
        /// Remove a specific data item from the data collection.
        /// </summary>
        /// <param name="value">It contains the specific record detail which is need to be removed.</param>
        /// <return>Returns void.</return>
        [HttpPost]
        [Route("api/Grid/Remove")]
        public void Remove(CRUDModel<OrdersDetails> deletedRecord)
        {
            int orderId = int.Parse(deletedRecord.key.ToString()); // Get key value from the deletedRecord.
            var data = OrdersDetails.GetAllRecords().FirstOrDefault(orderData => orderData.OrderID == orderId);
            if (data != null)
            {
                // Remove the record from the data collection.
                OrdersDetails.GetAllRecords().Remove(data);
            }
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
    }
}
```

```cs
namespace EditTemplate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        [HttpPost]
        public object Post(DataManagerRequest DataManagerRequest)
        {
            // Retrieve data from the data source (e.g., database).
            IQueryable<EmployeeDetails> DataSource = EmployeeDetails.GetAllRecords().AsQueryable();
            
            // Get the total count of records.
            int totalRecordsCount = DataSource.Count();

            // Return result and total record count.
            return DataManagerRequest.RequiresCounts ? Ok(new { result = DataSource, totalRecordsCount }) : Ok(DataSource);
        }

        [HttpGet]
        public List<EmployeeDetails> GetOrderData()
        {
            var data = EmployeeDetails.GetAllRecords().ToList();
            return data;
        }
    }
}

```
**Step 5:** Create a model class named **OrdersDetails.cs** under the **Models** folder in the server-side project to represent the order data and employee data:

```cs
namespace EditTemplate.Models
{
  public class OrdersDetails
  {
    private static List<OrdersDetails> order = new List<OrdersDetails>();
    public OrdersDetails() { }
    public OrdersDetails(int OrderID, string CustomerId, int EmployeeId, double Freight, bool Verified,
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
      if (order.Count == 0)
      {
        int code = 10000;
        List<Employee> employees = Employee.GetAllEmployees();
        int employeeCount = employees.Count;
        for (int i = 1; i < 10; i++)
        {
          order.Add(new OrdersDetails(code++, "ALFKI", employees[(code + 0) % employeeCount].EmployeeID, 2.3 * i, false, new DateTime(1991, 05, 15), "Berlin", "Simons bistro", "Denmark", new DateTime(1996, 7, 16), "Kirchgasse 6"));
          order.Add(new OrdersDetails(code++, "ANATR", employees[(code + 1) % employeeCount].EmployeeID, 3.3 * i, true, new DateTime(1990, 04, 04), "Madrid", "Queen Cozinha", "Brazil", new DateTime(1996, 9, 11), "Avda. Azteca 123"));
          order.Add(new OrdersDetails(code++, "ANTON", employees[(code + 2) % employeeCount].EmployeeID, 4.3 * i, true, new DateTime(1957, 11, 30), "Cholchester", "Frankenversand", "Germany", new DateTime(1996, 10, 7), "Carrera 52 con Ave. Bolívar #65-98 Llano Largo"));
          order.Add(new OrdersDetails(code++, "BLONP", employees[(code + 3) % employeeCount].EmployeeID, 5.3 * i, false, new DateTime(1930, 10, 22), "Marseille", "Ernst Handel", "Austria", new DateTime(1996, 12, 30), "Magazinweg 7"));
          order.Add(new OrdersDetails(code++, "BOLID", employees[(code + 4) % employeeCount].EmployeeID, 6.3 * i, true, new DateTime(1953, 02, 18), "Tsawassen", "Hanari Carnes", "Switzerland", new DateTime(1997, 12, 3), "1029 - 12th Ave. S."));
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
  public class Employee
  {
    public int EmployeeID { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Department { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public static List<Employee> GetAllEmployees()
    {
      return new List<Employee>
      {
        new Employee { EmployeeID = 1, FirstName = "John", LastName = "Doe", Department = "Sales", Email = "john.doe@example.com", PhoneNumber = "123-456-7890" },
        new Employee { EmployeeID = 2, FirstName = "David", LastName = "Smith", Department = "Marketing", Email = "david.smith@example.com", PhoneNumber = "987-654-3210" },
        new Employee { EmployeeID = 3, FirstName = "Maria", LastName = "Gonzalez", Department = "HR", Email = "maria.gonzalez@example.com", PhoneNumber = "456-789-0123" },
        new Employee { EmployeeID = 4, FirstName = "Sophia", LastName = "Brown", Department = "Finance", Email = "sophia.brown@example.com", PhoneNumber = "321-654-0987" },
        new Employee { EmployeeID = 5, FirstName = "James", LastName = "Wilson", Department = "IT", Email = "james.wilson@example.com", PhoneNumber = "654-321-7654" },
        new Employee { EmployeeID = 6, FirstName = "Emma", LastName = "Taylor", Department = "Operations", Email = "emma.taylor@example.com", PhoneNumber = "213-546-8790" },
        new Employee { EmployeeID = 7, FirstName = "Daniel", LastName = "Anderson", Department = "Logistics", Email = "daniel.anderson@example.com", PhoneNumber = "789-654-3210" },
        new Employee { EmployeeID = 8, FirstName = "Olivia", LastName = "Thomas", Department = "Procurement", Email = "olivia.thomas@example.com", PhoneNumber = "567-890-1234" },
        new Employee { EmployeeID = 9, FirstName = "Michael", LastName = "Harris", Department = "R&D", Email = "michael.harris@example.com", PhoneNumber = "890-123-4567" },
        new Employee { EmployeeID = 10, FirstName = "Lucas", LastName = "Martin", Department = "Customer Service", Email = "lucas.martin@example.com", PhoneNumber = "345-678-9012" },
        new Employee { EmployeeID = 11, FirstName = "Elijah", LastName = "Clark", Department = "Support", Email = "elijah.clark@example.com", PhoneNumber = "741-852-9630" },
        new Employee { EmployeeID = 12, FirstName = "Isabella", LastName = "Hall", Department = "Legal", Email = "isabella.hall@example.com", PhoneNumber = "963-852-7410" },
        new Employee { EmployeeID = 13, FirstName = "Ethan", LastName = "Young", Department = "Administration", Email = "ethan.young@example.com", PhoneNumber = "258-963-1470" },
        new Employee { EmployeeID = 14, FirstName = "Charlotte", LastName = "Scott", Department = "Design", Email = "charlotte.scott@example.com", PhoneNumber = "147-258-3690" },
        new Employee { EmployeeID = 15, FirstName = "Alexander", LastName = "Allen", Department = "Engineering", Email = "alexander.allen@example.com", PhoneNumber = "369-147-2580" }
      };
    }
  }
}
```

![Edit template in foreign key column using remote data](../images/foreign/edit-template.gif)
