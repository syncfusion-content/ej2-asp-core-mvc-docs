---
layout: post
title: Remote Data in Syncfusion ##Platform_Name## Grid Component
description: Learn here all about Remote Data in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Remote Data
publishingplatform: ##Platform_Name##
documentation: ug
---

# Remote data in ASP.Net MVC Grid Component

In ASP.Net MVC Grid component, binding remote data is a fundamental aspect that enhances the efficiency of data interaction. This process involves assigning the service data, represented as an instance of `DataManager`, to the `DataSource` property of the ASP.Net MVC Grid component. By doing so, you enable seamless interaction with a remote data source, and this is achieved by specifying the endpoint URL where the data is hosted.

Additionally, leverage the power for data retrieval and operations, enhancing event handling, asynchronous programming, and concurrent value management in ASP.Net MVC applications.

## Custom binding

The custom binding feature in the ASP.Net MVC Grid enables you to manage your own custom API for handling data processing externally and then binding the resulting data to the Grid. This allows you to implement your own custom data logic to your application's requirements. When using custom binding, the Grid expects the result of the custom logic to be an object with properties `result` and `count`. The `result` property should contain the data to be displayed in the Grid, while the `count` property indicates the total number of records in the dataset for your application. To utilize custom binding, you can handle the `DataManager`. The DataManager integrates seamlessly with the ASP.Net MVC Grid to manage custom data processing and binding. 

The Syncfusion Grid component offers a range of powerful features for handling grid actions such as **paging**, **grouping**, **sorting** and **filtering**. These actions trigger the [DataStateChange](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataStateChange) event. The feature for CRUD action such as **Create**, **Read**, **Update**, **Delete** operations. This action trigger the [DataSourceChanged](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataSourceChanged) event. This event provides you with the opportunity to manage and manipulate data according to the individual's interactions. 

**Using the DataStateChange event**

The `DataStateChange` event is triggered whenever you perform actions that modify the state of the grid's data, such as changing pages, applying sorting, or grouping. This event provides detailed information about the action performed and the current state of the grid, including parameters like page number, sorting details, and filtering criteria.

To implement the `DataStateChange` event, follow these steps:

1. **Subscribe to the event:** In your component code, subscribe to the `DataStateChange` event using the appropriate event handler function. This function will be executed whenever you interact with the grid.

2. **Handle data state:** Inside the event handler function, you can access the event arguments to determine the individual actions and intentions. The action property of the event arguments indicates the type of action performed (e.g., paging, sorting, grouping).

> The `DataStateChange` event will not be triggered during the initial rendering.

## Creating an API service

To configure a server with Syncfusion ASP.Net MVC Grid, you need to follow the below steps:

**Step 1:** To create a new ASP.NET Web Application (.NET Framework) project named FetchRequest, follow these steps:

* Open Visual Studio.
* Select “Create a new project”
* Choose ASP.NET Web Application (.NET Framework) project template.
* Name the project **CustomBinding**.
* Click “Create”

**Step 2:**  Create a simple ASP.NET MVC Grid by following the [Getting Started documentation link](https://ej2.syncfusion.com/aspnetmvc/documentation/grid/getting-started-mvc).

**Step 3:**  Create a model class named **OrdersDetails.cs** under the Models folder in the server-side project to represent the order data. Add the following code.

```cs
   public class OrdersDetails
   {
       public static List<OrdersDetails> order = new List<OrdersDetails>();
       public OrdersDetails() { }

       public OrdersDetails(int orderID, string customerId, int productID, string productName)
       {
           this.OrderID = orderID;
           this.CustomerName = customerId;
           this.ProductID = productID;
           this.ProductName = productName;
       }
       public static List<OrdersDetails> GetAllRecords()
       {
           if (order.Count() == 0)
           {
               int code = 10000;
               for (int i = 1; i < 5; i++)
               {
                   // Populate the orders with ProductID and ProductName
                   order.Add(new OrdersDetails(code + 1, "Maria", 1, "Chai"));
                   order.Add(new OrdersDetails(code + 2, "Ana Trujillo", 2, "Chang"));
                   order.Add(new OrdersDetails(code + 3, "Patricio Simpson", 3, "Aniseed Syrup"));
                   order.Add(new OrdersDetails(code + 4, "Ana Trujillo", 4, "Chef Anton's Cajun Seasoning"));
                   order.Add(new OrdersDetails(code + 5, "Georg Pipps", 5, "Grandma's Boysenberry Spread"));
                   order.Add(new OrdersDetails(code + 6, "Peter Franken", 5, "Chef Anton's Cajun Seasoning"));
                   order.Add(new OrdersDetails(code + 7, "Paul Henriot", 5, "Mishi Kobe Niku"));
                   order.Add(new OrdersDetails(code + 8, "Marie Bertrand", 5, "Northwoods Cranberry Sauce"));
                   order.Add(new OrdersDetails(code + 9, "Palle Ibsen", 5, "Carnarvon Tigers"));
                   order.Add(new OrdersDetails(code + 10, "Rita Müller", 5, "CFlotemysost"));
                   code += 10;
               }
           }
           return order;
       }
       public int? OrderID { get; set; }
       public string CustomerName { get; set; }
       public int ProductID { get; set; }
       public string ProductName { get; set; }
   }
```

**Step :** In the **HomeController.cs** file under the **Controllers** folder, add the following code to the GetOrderData method to return the result and count:

```cs
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetOrderData()
        {
            IEnumerable<OrdersDetails> dataSource = OrdersDetails.GetAllRecords();
            int totalCount = dataSource.Count();
            return Json(new { result = dataSource, count = totalCount });
        }
    }
```

**Step 9:** In the **Views/Home/Index.cshtml** file, handle CRUD operations and grid actions using Syncfusion’s DataManager to fetch and manipulate data. Add the following code:

```ts
@Html.EJS().Grid("grid").Height("348px").Columns(col =>
{
  col.Field("OrderID").HeaderText("Order ID").IsPrimaryKey(true).TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).Width("120").Add();
  col.Field("CustomerName").HeaderText("Customer Name").Width("150").Add();
  col.Field("ProductID").HeaderText("Product ID").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).Width("120").Add();
  col.Field("ProductName").HeaderText("Product Name").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).Width("120").Add();
}).AllowPaging().DataStateChange("dataStateChange").Created("created").Render()
<script>
        const baseUrl = "https://localhost:****/Home"; // Here xxxx denotes the port number.
        var gridData;
        var state = { skip: 0, take: 12 };
        function created() {
            dataStateChange(state)
        }
        function dataStateChange (state) {
            const grid = document.getElementById("grid").ej2_instances[0];
            const query = grid.getDataModule().generateQuery();
            getOrders(state, query).then(gridData => {
                grid.dataSource = gridData.result;
            });
        }
        function getOrders(state, action) {
            const query = new ej.data.Query();
            // page
            applyPaging(query, state)
            query.isCountRequired = true
            var fetchRequest = new ej.base.Fetch({
                url: `${baseUrl}/GetOrderData`,
                type: 'POST',

            })
            return fetchRequest.send()
                .then(data => {
                    // Create a DataManager instance with your fetched data
                    gridData = new ej.data.DataManager(data.result);
                    // Execute local data operations using the provided query
                    const result = gridData.executeLocal(query);
                    // Return the result along with the count of total records
                    return {
                        result: result, // Result of the data
                        count: result.count // Total record count based on fetched data length
                    };
                });
        }
        const applyPaging = (query, state) => {
            // Check if both 'take' and 'skip' values are available
            if (state.take && state.skip) {
                // Calculate pageSkip and pageTake values to get pageIndex and pageSize
                const pageSkip = state.skip / state.take + 1;
                const pageTake = state.take;
                query.page(pageSkip, pageTake);
            }
            // If if only 'take' is available and 'skip' is 0, apply paging for the first page.
            else if (state.skip === 0 && state.take) {
                query.page(1, state.take);
            }
        }
</script>

```

## Handling filtering operation

When filtering operation is performed in the grid, the [DataStateChange](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataStateChange) event is triggered, providing access to the following referenced arguments within the event.

![FilterBar](../images/databinding/remote-filtering.png)

You can change the new grid data state of filter action as follows:

```typescript
// Apply filtering
const applyFiltering = (query, filter)=> {
// Check if filter columns are specified
  if (filter.columns && filter.columns.length) {
    // Apply filtering for each specified column
    for (let i = 0; i < filter.columns.length; i++) {
      const field = filter.columns[i].field;
      const operator = filter.columns[i].operator;
      const value = filter.columns[i].value;
      query.where(field, operator, value);
    }
  }
  else {
    // Apply filtering based on direct filter conditions
    for (let i = 0; i < filter.length; i++) {
      const { fn, e } = filter[i];
      if (fn === 'onWhere') {
        query.where(e as string);
      }
    }
  }
}
/** GET all data from the server */
export function getOrders(state, action) {
  const query = new Query();
  // filter
  if (state.where) {
    applyFiltering(query, action.queries);
  }
  query.isCountRequired = true

  // Request the data from server using fetch
  return fetch(baseUrl)
    .then(res => res.json())
    .then(data => {
      // Create a DataManager instance with your fetched data
      const dataManager = new DataManager(data.result);
      // Execute local data operations using the provided query
      const result = dataManager.executeLocal(query);
      // Return the result along with the count of total records
      return {
        result: result, // Result of the data
        count: result.count // Total record count based on fetched data length
      };
    });
}
```

![Filtering Multiple Values](../images/databinding/remote-multiplefilter.png)

When filtering multiple values, you can get the predicates as arguments in the `DataStateChange` event. You can create your predicate execution based on the predicates values.

## Handling searching operation

When performing a search operation in the grid, the [DataStateChange](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataStateChange) event is triggered, allowing access to the following referenced arguments within the event

![Searching](../images/databinding/remote-search.png)

You can change the new grid data state of search action as follows:

```typescript
// Apply searching 
const applySearching = (query, search)=> {
  // Check if a search operation is requested
  if (search && search.length > 0) {
    // Extract the search key and fields from the search array
    const { fields, key } = search[0];
    // perform search operation using the field and key on the query
    query.search(key, fields);
  }
}
/** GET all data from the server */
export function getOrders(state, action) {
  const query = new Query();
  // search
  if (state.search) {
    applySearching(query, state.search);
  };
  query.isCountRequired = true
  // Request the data from server using fetch
  return fetch(baseUrl)
    .then(res => res.json())
    .then(data => {
      // Create a DataManager instance with your fetched data
      const dataManager = new DataManager(data.result);
      // Execute local data operations using the provided query
      const result = dataManager.executeLocal(query);
      // Return the result along with the count of total records
      return {
        result: result, // Result of the data
        count: result.count // Total record count based on fetched data length
      };
    });
  }
```

## Handling sorting operation

When sorting operation is performed in the grid, the [DataStateChange](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataStateChange) event is triggered, and within this event, you can access the following referenced arguments.

![Sorting](../images/databinding/remote-sorting.png)

When performing multi-column sorting, you can get the below referred arguments in the `DataStateChange` event.

![Multi Sorting](../images/databinding/remote-multiplesort.png)

You can change the new grid data state of sort action as follows:

```typescript
// Apply sorting
const applySorting = (query, sorted) =>{
  // Check if sorting data is available
  if (sorted && sorted.length > 0) {
    // Iterate through each sorting info
    sorted.forEach(sort => {
      // Get the sort field name either by name or field
      const sortField = sort.name || sort.field;
      // Perform sort operation using the query based on the field name and direction
      query.sortBy(sortField, sort.direction);
    });
  }
}
/** GET all data from the server */
export function getOrders(state, action) {
  const query = new Query();
  // sort
  if (state.sorted) {
    state.sorted.length ? applySorting(query, state.sorted) :
      // initial sorting
      state.sorted.columns.length ? applySorting(query, state.sorted.columns) : null
  }
  query.isCountRequired = true
  // Request the data from server using fetch
  return fetch(baseUrl)
    .then(res => res.json())
    .then(data => {
      // Create a DataManager instance with your fetched data
      const dataManager = new DataManager(data.result);
      // Execute local data operations using the provided query
      const result = dataManager.executeLocal(query);
      // Return the result along with the count of total records
      return {
        result: result, // Result of the data
        count: result.count // Total record count based on fetched data length
      };
    });
}
```

## Handling paging operation

When paging operation is performed in the grid, the [DataStateChange](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataStateChange) event is triggered, and within this event, you can access the following referenced arguments.

![Paging](../images/databinding/remote-paging.png)

You can change the new grid data state of page action as follows:

```typescript
// Apply paging
const applyPaging = (query, state)=> {
  // Check if both 'take' and 'skip' values are available
  if (state.take && state.skip) {
    // Calculate pageSkip and pageTake values to get pageIndex and pageSize
    const pageSkip = state.skip / state.take + 1;
    const pageTake = state.take;
    query.page(pageSkip, pageTake);
  }
  // If if only 'take' is available and 'skip' is 0, apply paging for the first page.
  else if (state.skip === 0 && state.take) {
    query.page(1, state.take);
  }
}
/** GET all data from the server */
export function getOrders(state, action) {
  const query = new Query();
  // page
  applyPaging(query, state)
  query.isCountRequired = true
  // Request the data from server using fetch
  return fetch(baseUrl)
    .then(res => res.json())
    .then(data => {
      // Create a DataManager instance with your fetched data
      const dataManager = new DataManager(data.result);
      // Execute local data operations using the provided query
      const result = dataManager.executeLocal(query);
      // Return the result along with the count of total records
      return {
        result: result, // Result of the data
        count: result.count // Total record count based on fetched data length
      };
    });
}
```

## Handling grouping operation

When grouping operation is performed in the grid, the [DataStateChange](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataStateChange) event is triggered, providing access to the following referenced arguments within the event.

![Grouping](../images/databinding/remote-group.png)

You can change the new grid data state of group action as follows:

```typescript
// Apply grouping
const applyGrouping = (query, group) =>{
  // Check if sorting data is available
  if (group.length > 0) {
    // Iterate through each group info
    group.forEach((column: string) => {
      // perform group operation using the column on the query
      query.group(column);
    });
  }
}
/** GET all data from the server */
export function getOrders(state, action) {
  const query = new Query();
  // grouping
  if (state.group) {
    state.group.length ? applyGrouping(query, state.group) :
      // initial grouping
      state.group.columns.length ? applyGrouping(query, state.group.columns) : null
  }
  query.isCountRequired = true
  // Request the data from server using fetch
  return fetch(baseUrl)
    .then(res => res.json())
    .then(data => {
      // Create a DataManager instance with your fetched data
      const dataManager = new DataManager(data.result);

      // Execute local data operations using the provided query
      const result = dataManager.executeLocal(query);

      // Return the result along with the count of total records
      return {
        result: result, // Result of the data
        count: result.count // Total record count based on fetched data length
      };
    });
}
```

> * In order to utilize group actions, it is necessary to manage the sorting query within your service.

**Lazy load grouping**

In ASP.Net MVC, lazy loading refers to the technique of loading data dynamically when they are needed, instead of loading everything upfront. Lazy load grouping allows you to load and display grouped data efficiently by fetching only the required data on demand. 

To enable this feature, you need to set the [GroupSettings.EnableLazyLoading](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridGroupSettings.html#Syncfusion_EJ2_Grids_GridGroupSettings_EnableLazyLoading) property to **true**. Also, you need to manage the state based on the initial grid action as follows.

```typescript
const state = { skip:0, take: 12, group: { enableLazyLoading: true, columns: ['ProductName'], showGroupedColumn: true }};
```

Based on the initial state, you can get the arguments as shown below

![Lazy load group](../images/databinding/remote-lazyload.png)

You can change the grid state as follows:

```typescript
// Apply grouping
const applyGrouping = (query, group) =>{
  // Check if sorting data is available
  if (group.length > 0) {
    // Iterate through each group info
    group.forEach((column: string) => {
      // perform group operation using the column on the query
      query.group(column);
    });
  }
}
// Apply lazy load grouping
const applyLazyLoad = (query, payload) => {
  // Configure lazy loading for the main data
  if (payload.isLazyLoad) {
    query.lazyLoad.push({ key: 'isLazyLoad', value: true });
    // If on-demand group loading is enabled, configure lazy loading for grouped data
    if (payload.onDemandGroupInfo) {
      query.lazyLoad.push({
          key: 'onDemandGroupInfo',
          value: payload.action.lazyLoadQuery,
      });
    }
  }
}
/** GET all data from the server */
export function getOrders(state, action) {
  const query = new Query();
  // grouping
  if (state.group) {
    state.group.length ? applyGrouping(query, state.group) :
      // initial grouping
      state.group.columns.length ? applyGrouping(query, state.group.columns) : null
  }
  // lazy load grouping
  if (state.group) {
    if (state.isLazyLoad) {
      applyLazyLoad(query, state)
    }
    if (state.group.enableLazyLoading) {
      query.lazyLoad.push({ key: 'isLazyLoad', value: true })
    }
  }
  query.isCountRequired = true
  // Request the data from server using fetch
  return fetch(baseUrl)
    .then(res => res.json())
    .then(data => {
      // Create a DataManager instance with your fetched data
      const dataManager = new DataManager(data.result);
      // Execute local data operations using the provided query
      const result = dataManager.executeLocal(query);
      // Return the result along with the count of total records
      return {
        result: result, // Result of the data
        count: result.count // Total record count based on fetched data length
      };
    });
}
```

> Further information can be accessed in the respective documentation for [lazy load grouping](https://ej2.syncfusion.com/aspnetmvc/documentation/grid/grouping/lazy-load-grouping).

## Handling CRUD operations

The Grid component provides powerful options for dynamically inserting, deleting, and updating records, enabling you to modify data directly within the grid. This feature is useful when you want to perform CRUD (Create, Read, Update, Delete) operations seamlessly.

Integrating CRUD Operations

To implement CRUD operations using Syncfusion Grid, follow these steps:

1. **Configure grid settings:** Set up the necessary grid settings, such as editing, adding, and deleting records. Define the toolbar options to facilitate your interactions.

2. **Handle data state changes:** Utilize the [DataStateChange](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataStateChange) event to respond to changes in the grid’s data state. This event is triggered whenever you interact with the grid, such as paging or sorting.

3. **Execute CRUD operations:** Within the event handler for [DataSourceChanged](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataSourceChanged), implement logic to handle various CRUD actions based on the action or requestType property of the event arguments.

4. **Call endEdit method:** After performing CRUD operations (adding, editing, or deleting), call the endEdit method to signal the completion of the operation and update the grid accordingly.

**Insert operation**

When an insert operation is performed in the grid, the `DataSourceChanged` event will be triggered, allowing access to the following referenced arguments within the event.

![Insert record](../images/databinding/remote-add.png)

```ts
// add
export function addRecord(order) {
  return fetch(baseUrl , {
    method: "post",
    headers: { "Content-Type": "application/json" },
    body: JSON.stringify({
      value: order
    })
  })
    .then((data) => {
      return data;
    });
}
```

**Edit operation**

When an edit operation is performed in the grid, the `DataSourceChanged` event will be triggered, providing access to the following referenced arguments within the event.

![Edit record](../images/databinding/remote-edit.png)

```ts
// update
export function updateRecord(order) {
  return fetch(`${baseUrl}/${order.OrderID}`, {
    method: "put",
    headers: { "Content-Type": "application/json" },
    body: JSON.stringify({
      value: order
    })
  })
    .then(data => {
      return data;
    });
}
```

**Delete operation**

When a delete operation is performed in the grid, the `DataSourceChanged` event will be triggered, allowing access to the following referenced arguments within the event.

![Delete record](../images/databinding/remote-delete.png)

```ts
// delete
export function deleteRecord(primaryKey) {
  return fetch(`${baseUrl}/${primaryKey}`, {
    method: "delete",
    body: JSON.stringify({
      value: primaryKey
    })
  })
  .then(data => {
    return data;
  });
}
```

The following example demonstrates how to bind custom data to handle grid actions and CRUD operation.

{% tabs %}
{% highlight razor tabtitle="Index.cshtml" %}
{% include code-snippet/grid/data-binding/remote-custom-handle/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/grid/data-binding/remote-custom-handle/custombinding.cs %}
{% endhighlight %}
{% highlight c# tabtitle="OrdersDetails.cs" %}
{% include code-snippet/grid/data-binding/remote-custom-handle/OrdersDetails.cs %}
{% endhighlight %}
{% endtabs %}

The following screenshot represents the grid action with custom binding
![Grid with Custom Binding](../images/databinding/remote-custom-binding.gif)

> * While working with grid edit operation, defining the `IsPrimaryKey` property of column is a mandatory step. In case the primary key column is not defined, the edit or delete action will take place on the first row of the grid.
> * Need to maintain the same instance for all grid actions.

## Export all records in client side

Export all records is especially beneficial when dealing with large datasets that need to be exported for offline analysis or sharing.

By default, the Syncfusion Grid component exports only the records on the current page. However, the Syncfusion ASP.Net MVC Grid component allows you to export all records, including those from multiple pages, by configuring the pdfExportProperties and excelExportProperties.

To export all records, including those from multiple pages, configure the `PdfExportProperties.DataSource` for PDF exporting and `ExcelExportProperties.DataSource` for Excel exporting within the [ToolbarClick](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ToolbarClick) event handler. Inside this event, set the `DataSource` property of `PdfExportProperties` and `ExcelExportProperties` for PDF and Excel exporting to include all records.

**Excel Exporting**

To export the complete grid data to Excel, utilize the `ExcelExportProperties.dataSource` when initiating the Excel export. Use the following code snippet to export all records within the grid:

```typescript
  const grid = document.getElementById("grid").ej2_instances[0];
  getOrders(state).then((event) => {
    let excelExportProperties = {
      dataSource: event.result.result
    };
    grid.excelExport(excelExportProperties);// need to call excelExport method of grid when get the entire data
  });
```

**Pdf Exporting**

To export the complete grid data to PDF document, utilize the `PdfExportProperties.DataSource` when initiating the PDF export. Use the following code snippet to export all records within the grid:

{% if page.publishingplatform == "typescript" %}

```typescript
  const grid = document.getElementById("grid").ej2_instances[0];
  getOrders(state).then((event) => {
    let pdfExportProperties = {
      dataSource: event.result.result
    };
    grid.pdfExport(pdfExportProperties);
  });
```

> Further customization on grid export can be accessed in the respective documentation for [PDF exporting](https://ej2.syncfusion.com/aspnetmvc/documentation/grid/pdf-export/pdf-export-options) and [Excel exporting](https://ej2.syncfusion.com/aspnetmvc/documentation/grid/excel-export/excel-export-options)

The following code example demonstrates how to export all records on the client side.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/remote-export/razor %}
{% endhighlight %}
{% highlight c# tabtitle="remotedata.cs" %}
{% include code-snippet/grid/data-binding/remote-export/remotedatamvc.cs %}
{% endhighlight %}
{% endtabs %}

## Offline mode

On remote data binding, all grid actions such as paging, sorting, editing, grouping, filtering, etc, will be processed on server-side. To avoid post back for every action, set the grid to load all data on initialization and make the actions process in client-side. To enable this behavior, use the **Offline** property of DataManager.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/offline/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Offline.cs" %}
{% include code-snippet/grid/data-binding/offline/offline.cs %}
{% endhighlight %}
{% endtabs %}
