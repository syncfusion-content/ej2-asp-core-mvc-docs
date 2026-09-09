---
layout: post
title: ##Platform_Name## Grid Validation | Syncfusion
description: Learn how to configure validation in ##Platform_Name## Data Grid using built-in and custom rules, display error messages, and prevent invalid data entry.
platform: ej2-asp-core-mvc
control: Validation
publishingplatform: ##Platform_Name##
documentation: ug
---

# Validation in ASP.NET Core Data Grid

Data validation ensures that information entered or modified in the grid follows specific validation rules, preventing errors and maintaining accuracy. The Data Grid component provides built-in validation support to make this process effective.

Validation rules support a wide range of validation scenarios, including mandatory fields, value validation, text validation, and custom validation logic.

> For basic grid editing setup and configuration, refer to the [Editing Feature Setup](../editing/edit.md#set-up-editing) section.

## Column validation

Column validation applies validation rules to individual columns during edit operations, ensuring data accuracy before saving. Invalid data displays error messages and prevents saving. The `FormValidator` component validates data using rules defined in the `validationRules` property for each column.

The following example demonstrates validation rules applied to a grid column:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/validation-columnvalid/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="columnvalid.cs" %}
{% include code-snippet/grid/edit/validation-columnvalid/columnvalid.cs %}
{% endhighlight %}
{% endtabs %}

![Column validation](../images/editing/validation.png)

### Custom validation

The custom validation feature is used to define and enforce specific validation rules for individual columns in the Data Grid. This is achieved by leveraging **Form Validator custom rules**, which allow enforcement of tailored validation logic and display of error messages for invalid fields.

In the following example, custom validation is applied to the **CustomerID** column.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/validation-customvalidation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="customvalidation.cs" %}
{% include code-snippet/grid/edit/validation-customvalidation/customvalidation.cs %}
{% endhighlight %}
{% endtabs %}

![Custom validation](../images/editing/validation-custom.png)

### Validation based on dropdown values

Dependent validation rules adjust based on selections in other columns, enabling linked column validation. The "Salary" column validation adjusts based on the "Role" column selection, ensuring both columns validate correctly together.

The following example demonstrates dependent validation between the "Role" and "Salary" columns:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/validation-dropdown-change/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="columnvalid.cs" %}
{% include code-snippet/grid/edit/validation-dropdown-change/columnvalid.cs %}
{% endhighlight %}
{% endtabs %}

![Custom validation based on dropdown change](../images/editing/validation-dropdown.gif)

### Validation for numeric columns

Numeric column validation applies rules for numeric data such as positive values, minimum/maximum ranges, or decimal limits. This example uses "customFn" and "customFn1" functions configured through the "freightRules" object to validate numeric values. The numeric columns are bound to the [change](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.NumericTextBox.html#Syncfusion_EJ2_Inputs_NumericTextBox_Change) event, which calls the `validate` method to check the value and display error messages whenever the data changes.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/validation-numericcolumn/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="columnvalid.cs" %}
{% include code-snippet/grid/edit/validation-numericcolumn/columnvalid.cs %}
{% endhighlight %}
{% endtabs %}

![Custom validation for numeric column](../images/editing/validation-numeric.png)

## Dynamic validation rules

Validation rules can be added or removed from input elements based on application scenarios or data conditions. The `addRules` method adds validation rules dynamically to input elements using the name attribute.

The following example demonstrates dynamic addition or removal of validation rules for an input field based on a checkbox selection.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/validation-add-remove/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="columnvalid.cs" %}
{% include code-snippet/grid/edit/validation-add-remove/columnvalid.cs %}
{% endhighlight %}
{% endtabs %}

![Dynamically add or remove validation rules from the form](../images/editing/validation-add-remove.png)

> To remove an existing validation rule from an input element, use the `removeRules` method. 

## Customize validation message position

Error message positioning customizes where validation messages appear in the grid. By default, messages display below the input field. The `customPlacement` event repositions messages to custom locations based on application needs.

The following example demonstrates moving validation messages to the top of the input field.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/validation-position/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="validation.cs" %}
{% include code-snippet/grid/edit/validation-position/validation.cs %}
{% endhighlight %}
{% endtabs %}

![Change the position of validation error message](../images/editing/validation-position.png)

## Handle server-side validation errors

Error handling for CRUD operations in the grid can display helpful error messages when operations fail. The [ActionFailure](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionFailure) event triggers on operation failures, providing access to error messages from server responses for display.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
@page
@model IndexModel

<div><p style="color: red; text-align: center" id="errorMessage"></p></div>
<ejs-grid id="Grid" allowFiltering="true" actionFailure="actionFailure" allowSorting="true" allowPaging="true" toolbar="@(new List<string>() { "Add", "Edit", "Delete", "Update", "Cancel","Search" })">
   //Replace xxxx with your actual port number
    <e-data-manager url='https://localhost:xxxx/api/Grid' insertUrl='https://localhost:xxxx/api/Grid/Insert' updateUrl='https://localhost:xxxx/api/Grid/Update' removeUrl='https://localhost:xxxx/api/Grid/Remove' adaptor="UrlAdaptor">
    </e-data-manager>
    <e-grid-editSettings allowAdding="true" allowDeleting="true" allowEditing="true" mode="Normal"></e-grid-editSettings>
    <e-grid-columns>
        <e-grid-column field="OrderID" headerText="Order ID" width="120" textAlign="Right" isPrimaryKey="true" type="number"></e-grid-column>
        <e-grid-column field="CustomerID" headerText="Customer ID" width="150" type="string"></e-grid-column>
        <e-grid-column field="ShipCity" headerText="Ship City" width="150"></e-grid-column>
        <e-grid-column field="ShipCountry" headerText="Ship Country" width="150"></e-grid-column>
    </e-grid-columns>
</ejs-grid>

<script>
let errorMessage = document.getElementById("errorMessage");
function actionFailure(args) {
    if (args.error && Array.isArray(args.error) && args.error.length > 0 && args.error[0].error){
        args.error[0].error.json().then(function (data) {
            errorMessage.innerHTML = data.message || "An unknown error occurred.";
        }).catch(function () {
            errorMessage.innerHTML = "Error occurred, but message could not be retrieved.";
        });
    }
    else{
        errorMessage.innerHTML = "An unexpected error occurred.";
    }
}
</script>

{% endhighlight %}

{% highlight cs tabtitle="GridController.cs" %}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Syncfusion.EJ2.Base;
using UrlAdaptor.Models;

namespace UrlAdaptor.Controllers
{
    [ApiController]
    public class GridController : Controller
    {
        [HttpPost]
        [Route("api/[controller]")]
        public object Post([FromBody] DataManagerRequest DataManagerRequest)
        {
            // Retrieve data from the data source (e.g., database).
            IQueryable<OrdersDetails> DataSource = GetOrderData().AsQueryable();
            
            // Initialize DataOperations instance.
            QueryableOperation queryableOperation = new QueryableOperation();

            // Handling searching operation.
            if (DataManagerRequest.Search != null && DataManagerRequest.Search.Count > 0)
            {
                DataSource = queryableOperation.PerformSearching(DataSource, DataManagerRequest.Search);
            }

            // Handling filtering operation.
            if (DataManagerRequest.Where != null && DataManagerRequest.Where.Count > 0)
            {
                foreach (var condition in DataManagerRequest.Where)
                {
                    foreach (var predicate in condition.predicates)
                    {
                        DataSource = queryableOperation.PerformFiltering(DataSource, DataManagerRequest.Where, predicate.Operator);
                    }
                }
            }

            // Handling sorting operation.
            if (DataManagerRequest.Sorted != null && DataManagerRequest.Sorted.Count > 0)
            {
                DataSource = queryableOperation.PerformSorting(DataSource, DataManagerRequest.Sorted);
            }

            // Get the total count of records.
            int totalRecordsCount = DataSource.Count();

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
        /// <param name="addRecord">The order to be inserted.</param>
        /// <returns>It returns the newly inserted record detail.</returns>
        [HttpPost]
        [Route("api/[controller]/Insert")]
        public IActionResult Insert([FromBody] CRUDModel<OrdersDetails> value)
        {
            if (value == null)
            {
                return BadRequest(new { message = "Invalid data received." });
            }
            var existingOrder = OrdersDetails.order.FirstOrDefault(or => or.OrderID == value.value.OrderID);
            if (existingOrder == null)
            {
                OrdersDetails.order.Insert(0, value.value);
                return Ok(new { success = true, message = "Order added successfully.", data = value });
            }
            else
            {
                return BadRequest(new { success = false, message = "Duplicate values cannot be inserted." });
            }
        }

        /// <summary>
        /// Updates an existing order.
        /// </summary>
        /// <param name="updateRecord">The updated order details.</param>
        /// <returns>It returns the updated order details.</returns>
        [HttpPost]
        [Route("api/[controller]/Update")]
        public IActionResult Update([FromBody] CRUDModel<OrdersDetails> Order)
        {
            var updatedOrder = Order.value;

            if (updatedOrder.OrderID < 10010 || updatedOrder.OrderID > 10030)
            {
                return BadRequest(new { message = "OrderID must be between 10010 and 10030 to update." });
            }

            var data = OrdersDetails.GetAllRecords().FirstOrDefault(or => or.OrderID == updatedOrder.OrderID);
            if (data == null)
            {
                return NotFound(new { message = "Order not found." });
            }

            // Update the existing record.
            data.CustomerID = updatedOrder.CustomerID;
            data.ShipCity = updatedOrder.ShipCity;
            data.ShipCountry = updatedOrder.ShipCountry;
            return Ok(new { success = true, message = "Order updated successfully." });
        }

        /// <summary>
        /// Deletes an order.
        /// </summary>
        /// <param name="deletedRecord">It contains the specific record detail which is need to be removed.</param>
        /// <returns>It returns the deleted record detail.</returns>
        [HttpPost]
        [Route("api/[controller]/Remove")]
        public IActionResult Remove([FromBody] CRUDModel<OrdersDetails> value)
        {
            int orderId;
            if (!int.TryParse(value.key.ToString(), out orderId))
            {
                return BadRequest(new { message = "Invalid OrderID format." });
            }

            if (orderId < 10031 || orderId > 10045)
            {
                return BadRequest(new { message = "OrderID must be between 10031 and 10045 to delete." });
            }

            var data = OrdersDetails.GetAllRecords().FirstOrDefault(orderData => orderData.OrderID == orderId);
            if (data == null)
            {
                return NotFound(new { message = "Order not found." });
            }

            OrdersDetails.GetAllRecords().Remove(data);
            return Ok(new { success = true, message = "Order deleted successfully." });
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

{% endhighlight %}
{% endtabs %}

![Show custom error message](../images/editing/custom-message.png)

## Prevent adding duplicate rows with custom validation

The Data Grid component supports enforcing constraints to prevent duplicate rows by customizing the validation logic within the grid configuration. This ensures data integrity by restricting duplicate entries in the "OrderID" column.

To prevent adding duplicate rows in the Grid, follow these steps:

1. Implement Custom Validation: Define the `orderIdCustomValidation` function to check whether the entered "OrderID" already exists in the [dataSource](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataSource). This allows editing an existing row without triggering a duplicate error.

2. Add Dynamic Validation Rules: Create the `orderIDRules` object to enforce unique "OrderID" values. Dynamically add this rule to the form during the `save` action.

3. Handle Validation in the [actionBegin](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_ActionBegin) event: In the `actionBegin` event, check if the `requestType` is `save`. Apply the validation rule before saving and cancel the action `args.cancel = true` if the validation fails.

For server-side validation to prevent adding duplicate rows, you can refer to the detailed guidance provided in our [knowledge base](https://support.syncfusion.com/kb/article/11608/how-to-do-server-side-validation-for-grid-in-aspnet-mvc-application). If you want to display the Grid's validation tooltip instead of the alert used in our knowledge base, you can call the `grid.editModule.formObj.validate()` method in the `Ajax/Fetch` success function to display the Grid's tooltip validation for the server side.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/prevent-add-duplicate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Edit-temp.cs" %}
{% include code-snippet/grid/edit/prevent-add-duplicate/customvalidation.cs %}
{% endhighlight %}
{% endtabs %}

![Prevent Duplicate row](../images/editing/prevent-duplicate-row.png)

## See also

* [Normal editing](./in-line-editing)
* [Template editing](./template-editing)
* [Cell editing](./cell-editing)
* [Batch editing](./batch-editing)
* [Dialog editing](./dialog-editing)