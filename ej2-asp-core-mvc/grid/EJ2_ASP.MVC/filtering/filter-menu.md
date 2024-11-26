---
layout: post
title: Filter Menu in Syncfusion ##Platform_Name## Grid Component
description: Learn here all about Filter Menu in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Filter Menu
publishingplatform: ##Platform_Name##
documentation: ug
---
# Filter menu in  ASP.NET MVC Grid component

The filter menu in the  ASP.NET MVC Grid component allows you to enable filtering and provides a user-friendly interface for filtering data based on column types and operators.

To enable the filter menu, you need to set the [FilterSettings.Type](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridFilterSettings.html#Syncfusion_EJ2_Grids_GridFilterSettings_Type) property to **Menu**. This property determines the type of filter UI that will be rendered. The filter menu UI allows you to apply filters using different operators.

Here is an example that demonstrates the usage of the filter menu in the Syncfusion  ASP.NET MVC Grid:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/filtering/filtermenu/razor %}
{% endhighlight %}
{% highlight c# tabtitle="filtermenu.cs" %}
{% include code-snippet/grid/filtering/filtermenu/filtermenu.cs %}
{% endhighlight %}
{% endtabs %}

![Filter menu](../images/filtering/filter-menu.png)

> * [AllowFiltering](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowFiltering) must be set as true to enable filter menu.
> * By setting `Columns.AllowFiltering` as false will prevent filter menu rendering for a particular column.

## Custom component in filter menu

You can enhance the filtering experience in the Syncfusion  ASP.NET MVC Grid component by customizing the filter menu with custom components. This allows you to replace the default search box with custom components like dropdowns or textboxes. By default, the filter menu provides an autocomplete component for string type columns, a numeric textbox for number type columns, and a dropdown component for boolean type columns, making it easy to search for values.

To customize the filter menu, you can make use of the `Column.Filter.Ui` property. This property allows you to integrate your desired custom filter component into a specific column of the Grid. To implement a custom filter UI, you need to define the following functions:

* **create**: This function is responsible for creating the custom component for the filter.
* **write**: The write function is used to wire events for the custom component. This allows you to handle changes in the custom filter UI.
* **read**: The read function is responsible for reading the filter value from the custom component. This is used to retrieve the selected filter value.

For example, you can replace the standard search box in the filter menu with a dropdown component. This enables you to perform filtering operations by selecting values from the dropdown list, rather than manually typing in search queries.

Here is a sample code demonstrating how to render a dropdownlist component for the **CustomerID** column:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/filtering/filter-menu-component/razor %}
{% endhighlight %}
{% highlight c# tabtitle="filtermenu.cs" %}
{% include code-snippet/grid/filtering/filter-menu-component/filtermenu.cs %}
{% endhighlight %}
{% endtabs %}

**Default filter input for CustomerID column**
![Default filter input for CustomerID column](../images/filtering/filtermenu-custom-default.gif)
**Custom dropdown filter for CustomerID column**
![Custom dropdown filter for CustomerID column](../images/filtering/filter-menu-component.gif)

## Show 24 hours time format in filter dialog

The Syncfusion  ASP.NET MVC Grid provides a feature to display the time in a 24-hour format in the date or datetime column filter dialog. By default, the filter dialog displays the time in a 12-hour format (AM/PM) for the date or datetime column. However, you can customize the default format by setting the type as **dateTime** and the format as **M/d/y HH:mm**. To enable the 24-hour time format in the filter dialog, you need to handle the [ActionComplete](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionComplete) event with `requestType` as `filterafteropen` and set the `timeFormat` of the `DateTimepicker` to **HH:mm**.

Here is an example that demonstrates how to show 24 hours time format in filter dialog:
 
{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/filtering/filter-menu-format/razor %}
{% endhighlight %}
{% highlight c# tabtitle="filtermenu.cs" %}
{% include code-snippet/grid/filtering/filter-menu-format/filtermenu.cs %}
{% endhighlight %}
{% endtabs %}

![Filter menu](../images/filtering/filterbar-format.png)

## Customizing filter menu operators list

The Syncfusion  ASP.NET MVC Grid enables you to customize the default filter operator list by utilizing the [FilterSettings.Operators](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridFilterSettings.html#Syncfusion_EJ2_Grids_GridFilterSettings_Operators) property. This feature allows you to define your own set of operators that will be available in the filter menu. You can customize operators for string, number, date, and boolean data types.

The available options for customization are:

* **stringOperator**- defines customized string operator list.
* **numberOperator** - defines customized number operator list.
* **dateOperator** - defines customized date operator list.
* **booleanOperator** - defines customized boolean operator list.
  
Here is an example of how to customize the filter operators list in Syncfusion  ASP.NET MVC Grid:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/filtering/filter-menu-operators/razor %}
{% endhighlight %}
{% highlight c# tabtitle="filtermenu.cs" %}
{% include code-snippet/grid/filtering/filter-menu-operators/filtermenu.cs %}
{% endhighlight %}
{% endtabs %}

![Filter menu](../images/filtering/filtermenu-operator.png)

## Filter by multiple keywords using filter menu

The Syncfusion  ASP.NET MVC Grid allows you to perform filtering actions based on multiple keywords, rather than a single keyword, using the filter menu dialog. To enable this feature, you can set [FilterSettings.Type](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridFilterSettings.html#Syncfusion_EJ2_Grids_GridFilterSettings_Type)  as **Menu** and render the `MultiSelect` component as a custom component in the filter menu dialog.

Here is an example that demonstrates how to perform filtering by multiple keywords using the filter menu in the Syncfusion  ASP.NET MVC Grid:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/filtering/filter-menu-multiple-keywords/razor %}
{% endhighlight %}
{% highlight c# tabtitle="filtermenu.cs" %}
{% include code-snippet/grid/filtering/filter-menu-multiple-keywords/filtermenu.cs %}
{% endhighlight %}
{% endtabs %}

![Filter menu](../images/filtering/filtermenu-multiple-keyword.gif)

## Customize the default input component of filter menu dialog

You have the flexibility to customize the default settings of input components within the menu filter by utilizing the `Params` property within the column definition of `Filter`. This allows you to modify the behavior of specific filter components to better suit your needs.

| Column Type | Default component                                                                                 | Customization                            | API Reference                                                                                             |
| ----------- | ------------------------------------------------------------------------------------------------- | ---------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| String      | [AutoComplete](https://ej2.syncfusion.com/aspnetmvc/documentation/auto-complete/getting-started)    | Eg: { params: { autofill: false }}       | [AutoComplete API](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.AutoComplete.html#properties) |
| Number      | [NumericTextBox](https://ej2.syncfusion.com/aspnetmvc/documentation/numerictextbox/getting-started) | Eg: { params: { showSpinButton: false }} | [NumericTextBox API](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Inputs.NumericTextBox.html#properties)                 |
| Boolean     | [DropDownList](https://ej2.syncfusion.com/aspnetmvc/documentation/drop-down-list/getting-started)   | Eg: { params: { sortOrder:'Ascending'}}  | [DropDownList API](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.DropDownList.html#properties)                   |
| Date        | [DatePicker](https://ej2.syncfusion.com/aspnetmvc/documentation/datepicker/getting-started)         | Eg: { params: { weekNumber: true }}      | [DatePicker API](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Calendars.DatePicker.html#properties)                         |
| DateTime    | [DateTimePicker](https://ej2.syncfusion.com/aspnetmvc/documentation/datetimepicker/getting-started) | Eg: { params: { showClearButton: true }} | [DateTimePicker API](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Calendars.DateTimePicker.html#properties)                 |

> To know more about the feature, refer to the Getting Started documentation and API Reference

In the example provided below, the **OrderID** and **Freight** columns are numeric columns. When you open the filter dialog for these columns, you will notice that a `NumericTextBox` with a spin button is displayed to change or set the filter value. However, using the `Params` property, you can hide the spin button specifically for the **OrderID** column.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/filtering/filter-menu-menu-dialog/razor %}
{% endhighlight %}
{% highlight c# tabtitle="filtermenu.cs" %}
{% include code-snippet/grid/filtering/filter-menu-menu-dialog/filtermenu.cs %}
{% endhighlight %}
{% endtabs %}

![Filter menu](../images/filtering/filter-menu-input-hide.png)

## Hide default filter icons while perform filtering through method

When performing filtering programmatically using methods in the Syncfusion  ASP.NET MVC Grid component, you may want to hide the default filter icons to provide a simpler interface.

To customize the filter icon in the Grid, use the **display** property of the **filtermenu** as mentioned below

```css
.e-filtermenudiv.e-icons.e-icon-filter {
    display: none;
}
```

The following example demonstrate how to hide the default filter icons while filtering the **CustomerID** column programmatically using a method.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/filtering/filter-menu-hide-method/razor %}
{% endhighlight %}
{% highlight c# tabtitle="filtermenu.cs" %}
{% include code-snippet/grid/filtering/filter-menu-hide-method/filtermenu.cs %}
{% endhighlight %}
{% endtabs %}

![Filter menu](../images/filtering/filter-menu-method.gif)

## Filter menu events

The Syncfusion  ASP.NET MVC Grid offers the [ActionBegin](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionBegin) and [ActionComplete](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionComplete) events, which provide information about the actions being performed. Within the event handlers, you receive an argument named `requestType`. This argument specifies the `action` that is being executed, such as `filterbeforeopen`, `filterafteropen`, or `filtering`. By analyzing this action type, you can implement custom logic or showcase messages.

**filtering** - Defines current action as filtering.
**filterbeforeopen** - Defines current action as filter dialog before open.
**filterafteropen** - Defines current action as filter dialog after open.

Here's an example of how to use these events to handle filter menu action in the Syncfusion  ASP.NET MVC Grid:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/filtering/filter-menu-events/razor %}
{% endhighlight %}
{% highlight c# tabtitle="filtermenu.cs" %}
{% include code-snippet/grid/filtering/filter-menu-events/filtermenu.cs %}
{% endhighlight %}
{% endtabs %}

![Filter menu](../images/filtering/filtermenu-events.png)

## Troubleshoot filter menu operator issue

When using the filter menu, the UI displays operators for all columns based on the data type of the first data it encounters. If the first data is empty or null, it may not work correctly. To overcome this issue, follow these steps to troubleshoot and resolve it:

**Explicitly Define Data Type:** When defining columns in your  ASP.NET MVC Grid component, make sure to explicitly specify the data type for each column. You can do this using the type property within the columns configuration. For example:

```ts
@Html.EJS().Grid("Grid").DataSource((IEnumerable<object>)ViewBag.dataSource).AllowFiltering().Columns(col =>
{
    col.Field("OrderID").HeaderText("Order ID").Type("number").Width("120").Add();
    col.Field("CustomerID").HeaderText("CustomerID").Type("string").Width("150").Add();
   <!-- Define data types for other columns as needed -->
}).FilterSettings(filter => { filter.Type(Syncfusion.EJ2.Grids.FilterType.Menu); }).Render()
```

**Handle Null or Empty Data:** If your data source contains null or empty values, make sure that these values are appropriately handled within your data source or by preprocessing your data to ensure consistency.

**Check Data Types in Data Source:** Ensure that the data types specified in the column definitions match the actual data types in your data source. Mismatched data types can lead to unexpected behavior.

## Add current selection to filter checkbox

By default, the CheckBox filter can only filter the selected items. If filtering is done multiple times on the same column, the previously filtered values in the column will be cleared. Now, it is possible to retain those previous values by using the `Add current selection to filter` checkbox. This checkbox is displayed when data is searched in the search bar of the CheckBox filter.

The following image describes the above mentioned behavior.

![Checkbox filter](../images/checkboxfilter.png)

## See also

* [How to perform filter by using Wildcard and LIKE operator filter](./filtering/#wildcard-and-like-operator-filter)