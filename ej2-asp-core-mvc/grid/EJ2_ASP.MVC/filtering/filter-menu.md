---
layout: post
title: ##Platform_Name## Grid Filter Menu | Syncfusion
description: Learn how to use Filter Menu in ##Platform_Name## Data Grid with configurable dialogs, custom components, operator options, and multi-value filtering.
platform: ej2-asp-core-mvc
control: Filter Menu
publishingplatform: ##Platform_Name##
documentation: ug
---

# Filter Menu in ASP.NET MVC Data Grid

The filter menu in the Data Grid component provides a dialog-based filtering interface that appears when clicking the filter icon in column headers. This menu displays dropdown operators (such as equals, contains, startswith) and an input field for entering filter values, which provides precise control over data filtering.

## Enable filter menu

To enable the filter menu, set the [FilterSettings.Type](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridFilterSettings.html#Syncfusion_EJ2_Grids_GridFilterSettings_Type) property to `Menu`. This property determines the type of filter UI that is rendered, enabling filters to be applied using different operators tailored to each column's data type.

The following example demonstrates basic filter menu usage in the Data Grid:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/filtering/filtermenu/razor %}
{% endhighlight %}
{% highlight c# tabtitle="filtermenu.cs" %}
{% include code-snippet/grid/filtering/filtermenu/filtermenu.cs %}
{% endhighlight %}
{% endtabs %}

![Filter menu](../images/filtering/filter-menu.png)

> * [AllowFiltering](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowFiltering) must be set as `true` to enable filter menu.
> * Setting `Columns.AllowFiltering` as `false` prevents the filter menu from being rendered for a particular column.

## Custom component in filter menu

The filter menu provides enhanced customization capabilities by allowing replacement of default filter components with custom ones. This enables the creation of filtering experiences tailored to specific data and application requirements.

By default, the filter menu provides:
- **`AutoComplete`** component for string type columns.
- **`NumericTextBox`** for number type columns.
- **`DropDownList`** component for boolean type columns.
- **`DatePicker`** for date type columns.
- **`DateTimePicker`** for datetime type columns.

To implement custom filter components, use the `Column.Filter.Ui` property and define the following functions:

* `create`: Creates the custom component for the filter.
* `write`: Applies the component model dynamically and connects event handlers for the custom component. This function handles changes in the custom filter UI and updates filter behavior accordingly.
* `read`: Reads the filter value from the custom component. This retrieves the selected filter value when the filter is applied.

The following example demonstrates rendering a `DropDownList` component for the "Customer ID" column instead of the default AutoComplete:

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

## Show 24-hour time format in filter dialog

The Data Grid provides a feature to display time in a "24-hour" format in date or datetime column filter dialogs.

By default, filter dialogs display time in "12-hour" format (AM/PM) for date or datetime columns. To customize this behavior, set the column type as `datetime` and format as "M/d/y HH:mm". The [ActionComplete](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionComplete) event with `requestType` as `filterafteropen` can be used to set the `timeFormat` of the `DateTimePicker` to "HH:mm".

Here is an example that demonstrates the "24-hour" time format in the filter dialog:
 
{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/filtering/filter-menu-format/razor %}
{% endhighlight %}
{% highlight c# tabtitle="filtermenu.cs" %}
{% include code-snippet/grid/filtering/filter-menu-format/filtermenu.cs %}
{% endhighlight %}
{% endtabs %}

![Filter menu](../images/filtering/filterbar-format.png)

## Customizing filter menu operators

Filter operators are comparison methods that determine the match between the filter value and data. Examples include:

- `equals`: Exact match
- `contains`: Partial match (substring search)
- `startswith`: Matches beginning of value
- `greaterthan`: Numeric/date comparison

The Data Grid enables customizing the default filter operator list using the [FilterSettings.Operators](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridFilterSettings.html#Syncfusion_EJ2_Grids_GridFilterSettings_Operators) property. This feature defines custom sets of operators available in the filter menu, allowing restriction or simplification of filtering methods for specific columns.

Customize operators for string, number, date, and boolean data types using these options:

* `stringOperator` - defines customized string operator list.
* `numberOperator` - defines customized number operator list.
* `dateOperator` - defines customized date operator list.
* `booleanOperator` - defines customized boolean operator list.
  
Here is an example that customizes the filter operators list in the Data Grid:

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

The Data Grid allows filtering based on multiple keywords simultaneously, rather than a single keyword. This is useful when a filter requires selecting multiple values from a list.

To enable this feature, set [FilterSettings.Type](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridFilterSettings.html#Syncfusion_EJ2_Grids_GridFilterSettings_Type)  as `Menu` and render the `MultiSelect` component as a custom component in the filter menu dialog using the `Filter.Ui` property.

The following example demonstrates multiple keyword filtering implementation:

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

The default settings of input components within the filter menu can be customized by utilizing the `Params` property within the column definition of `Filter`. This allows modification of specific filter component behavior to better suit application requirements.

Each column type uses a default component in the filter menu, which can be customized with specific parameters:

| Column Type | Default component                                                                                 | Customization                            | API Reference                                                                                             |
| ----------- | ------------------------------------------------------------------------------------------------- | ---------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| String      | [AutoComplete](https://ej2.syncfusion.com/aspnetmvc/documentation/auto-complete/getting-started)    | Eg: { params: { autofill: false }}       | [AutoComplete API](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.AutoComplete.html#properties) |
| Number      | [NumericTextBox](https://ej2.syncfusion.com/aspnetmvc/documentation/numerictextbox/getting-started) | Eg: { params: { showSpinButton: false }} | [NumericTextBox API](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Inputs.NumericTextBox.html#properties)                 |
| Boolean     | [DropDownList](https://ej2.syncfusion.com/aspnetmvc/documentation/drop-down-list/getting-started)   | Eg: { params: { sortOrder:'Ascending'}}  | [DropDownList API](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.DropDownList.html#properties)                   |
| Date        | [DatePicker](https://ej2.syncfusion.com/aspnetmvc/documentation/datepicker/getting-started)         | Eg: { params: { weekNumber: true }}      | [DatePicker API](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Calendars.DatePicker.html#properties)                         |
| DateTime    | [DateTimePicker](https://ej2.syncfusion.com/aspnetmvc/documentation/datetimepicker/getting-started) | Eg: { params: { showClearButton: true }} | [DateTimePicker API](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Calendars.DateTimePicker.html#properties)                 |

> Refer to the Getting Started documentation and API Reference for complete feature details.

In the following example, the "Order ID" and "Freight" columns are numeric columns. When the filter dialog opens for these columns, a `NumericTextBox` with a spin button displays by default. The `Params` property can be used to hide the spin button specifically for the "Order ID" column.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/filtering/filter-menu-menu-dialog/razor %}
{% endhighlight %}
{% highlight c# tabtitle="filtermenu.cs" %}
{% include code-snippet/grid/filtering/filter-menu-menu-dialog/filtermenu.cs %}
{% endhighlight %}
{% endtabs %}

![Filter menu](../images/filtering/filter-menu-input-hide.png)

## Hide filter icons during programmatic filtering

When filtering is performed programmatically using grid methods, the default filter icons can be hidden to provide a simpler interface.

To hide the filter icon in the grid, apply the following CSS rule to the filter menu class:

```css
.e-filtermenudiv.e-icons.e-icon-filter {
    display: none;
}
```

The following example demonstrates hiding the default filter icons while filtering the "Customer ID" column programmatically using a method.

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

The Data Grid provides the [ActionBegin](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionBegin) and [ActionComplete](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionComplete) events, which provide information about the actions being performed. Within the event handlers, an argument named `requestType` specifies the `action` being executed, such as `filterbeforeopen`, `filterafteropen`, or `filtering`. By analyzing this action type, custom logic can be implemented or messages displayed.

**Request types and their purposes**:

* `filterbeforeopen` - Triggered before the filter menu dialog opens. Use this to modify menu settings, pre-populate values, or prevent the dialog from opening based on conditions.
* `filterafteropen` - Triggered after the filter menu dialog opens. Use this to customize the dialog appearance, focus specific input fields, or add additional UI elements.
* `filtering` - Triggered when a filter is applied. Use this to log filter actions, display custom notifications, or perform additional data processing.

These events enable implementation of custom logic, display of messages, or modification of filter behavior based on specific requirements.

The following example demonstrates filter menu event handling in the Data Grid:

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

When using the filter menu, the UI displays operators for all columns based on the data type of the first data it encounters. If the first data is empty or null, the operators may not display correctly. To resolve this issue:

**Explicitly define data type:** When defining columns in an Data Grid component, explicitly specify the data type for each column using the `Type` property within the columns configuration:

```ts
@Html.EJS().Grid("Grid").DataSource((IEnumerable<object>)ViewBag.dataSource).AllowFiltering().Columns(col =>
{
    col.Field("OrderID").HeaderText("Order ID").Type("number").Width("120").Add();
    col.Field("CustomerID").HeaderText("CustomerID").Type("string").Width("150").Add();
   <!-- Define data types for other columns as needed -->
}).FilterSettings(filter => { filter.Type(Syncfusion.EJ2.Grids.FilterType.Menu); }).Render()
```

**Handle null or empty data:** If the data source contains null or empty values, these values should be appropriately handled within the data source or by preprocessing the data to maintain consistency.

**Check data types in data Source:** The data types specified in the column definitions must match the actual data types in the data source. Mismatched data types can lead to unexpected behavior.

## See also

* [How to perform filter by using Wildcard and LIKE operator filter](./filtering#wildcard-and-like-filters)