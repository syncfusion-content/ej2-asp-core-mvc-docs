---
layout: post
title: ##Platform_Name## Grid Filtering | Syncfusion
description: Learn how to use filtering in ##Platform_Name## Data Grid with filter types, server filtering, expression operators, and UI options for refined data results.
platform: ej2-asp-core-mvc
control: Filtering
publishingplatform: ##Platform_Name##
documentation: ug
---

# Filtering in ASP.NET Core Data Grid

The Data Grid provides flexible filtering capabilities for refining data based on specific criteria. Filtering helps narrow large datasets to focus on relevant information, improving data analysis and data exploration. Multiple filtering experiences are available, including filter bar, menu filter, excel filter, and checkbox filter, along with support for filter operators, wildcard and LIKE filtering, custom filter templates, and advanced filtering scenarios.

## Enable filtering

To enable filtering in the Data Grid, set the [allowFiltering](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_AllowFiltering) property to `true`. Once filtering is enabled, configure various filtering options through the [filterSettings](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_ExportGroupCaption) property to define the behavior and appearance of filters.

The following example demonstrates basic filtering functionality:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/filtering/filter/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="filter.cs" %}
{% include code-snippet/grid/filtering/filter/filter.cs %}
{% endhighlight %}
{% endtabs %}

![Filtering](../images/filtering/filtering.png)

> * Apply and clear filtering programmatically using `filterByColumn` and `clearFiltering` methods.
> * Disable filtering for specific columns by setting `columns.allowFiltering` to `false`.


## Filter types

The Data Grid supports multiple filtering options to meet different data-filtering requirements:

- **[Filter bar](filter-bar)**: Provides inline filtering directly within the column headers.
- **[Menu filter](filter-menu)**: Enables condition-based filtering through a filter menu.
- **[Excel filter](excel-like-filter)**: Offers an Excel-like filtering experience with search and checkbox-based value selection.
- **[CheckBox filter](excel-like-filter)**: Allows filtering by selecting from a list of distinct column values.

Use the `filterSettings.type` property to specify the desired filter type.

## Configure initial filter

To apply an initial filter, specify the filter criteria using the `predicate` object in [filterSettings.columns](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridFilterSettings.html#Syncfusion_EJ2_Grids_GridFilterSettings_Columns). The `predicate` object represents the filtering condition and contains properties such as field, operator, and value.

The following example demonstrates initial filter configuration:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/filtering/initialfilter/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="initialfilter.cs" %}
{% include code-snippet/grid/filtering/initialfilter/initialfilter.cs %}
{% endhighlight %}
{% endtabs %}

![Initial filter](../images/filtering/initial-filter.png)

### Initial filter with multiple values for the same column

Initial filtering with multiple values allows filter conditions to be preset for a specific column using multiple criteria. This displays only records matching any of the specified values when the grid first renders.

Set multiple `predicate` objects in [filterSettings.columns](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridFilterSettings.html#Syncfusion_EJ2_Grids_GridFilterSettings_Columns) for the same field.

The following example filters the "Customer ID" column to show only specific customer records.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/filtering/filter-multiple-same-column/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="filter.cs" %}
{% include code-snippet/grid/filtering/filter-multiple-same-column/filter.cs %}
{% endhighlight %}
{% endtabs %}

![Filtering](../images/filtering/initial-filter-same-column.png)

### Initial filter with multiple values for different columns 

Initial filter configuration with multiple values across different columns sets predefined filter criteria for each column. This configuration displays filtered records immediately when the grid loads.

To apply filters with multiple values for different columns at initial rendering, configure multiple filter `predicate`objects in [filterSettings.columns](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridFilterSettings.html#Syncfusion_EJ2_Grids_GridFilterSettings_Columns).

The following example demonstrates performing an initial filter with multiple values for different "Order ID" and "Customer ID" columns using `filterSettings.columns` and `predicate`.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/filtering/filter-multiple-different-column/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="filter.cs" %}
{% include code-snippet/grid/filtering/filter-multiple-different-column/filter.cs %}
{% endhighlight %}
{% endtabs %}

![Filtering](../images/filtering/initial-filter-different-columns.png)

## Filter operators

The Data Grid provides various filter operators to define filter conditions for columns. Define the filter operator using the  [operator](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridFilterSettings.html#Syncfusion_EJ2_Grids_GridFilterSettings_Operators) property in [filterSettings.columns](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridFilterSettings.html#Syncfusion_EJ2_Grids_GridFilterSettings_Columns).

The available operators and their supported data types are:

Operator |Description |Supported Types
-----|-----|-----
startsWith |Checks whether a value begins with the specified value. |String
endsWith |Checks whether a value ends with the specified value. |String
contains |Checks whether a value contains specified value. |String
doesnotstartwith |Checks whether the value does not begin with the specified value. |String
doesnotendwith |Checks whether the value does not end with the specified value. |String
doesnotcontain |Checks whether the value does not contain the specified value. |String
equal |Checks whether a value is equal to the specified value. |String &#124; Number &#124; Boolean &#124; Date
notEqual |Checks whether a value is not equal to the specified value. |String &#124; Number &#124; Boolean &#124; Date
greaterThan |Checks whether a value is greater than with specified value. |Number &#124; Date
greaterThanOrEqual|Checks whether a value is greater than or equal to specified value. |Number &#124; Date
lessThan |Checks whether a value is less than the specified value. |Number &#124; Date
lessThanOrEqual |Checks whether a value is less than or equal to specified value. |Number &#124; Date
isnull |Returns the values that are null. |String &#124; Number &#124; Date
isnotnull |Returns the values that are not null. |String &#124; Number &#124; Date
isempty |Returns the values that are empty. |String
isnotempty |Returns the values that are not empty. |String
between|Filter the values based on the range between the specified start and end values. |Number &#124; Date
in |Filters multiple records in the same column that exactly match any of the selected values. |String &#124; Number &#124; Date
notin |Filters multiple records in the same column that do not match any of the selected values. |String &#124; Number &#124; Date

> By default, the grid uses different filter operators for different column types. The default filter operator for string columns is `startswith`, for numeric columns is `equal`, and for boolean columns is `equal`.

## Case-sensitive filtering

The Data Grid provides the flexibility to enable or disable case sensitivity during filtering. Control whether filtering operations consider the case of characters using the  [enableCaseSensitivity](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridFilterSettings.html#Syncfusion_EJ2_Grids_GridFilterSettings_EnableCaseSensitivity) property within [filterSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_FilterSettings).

The following example demonstrates enabling or disabling case sensitivity while filtering.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/filtering/filter-case-sensitivity/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="filter.cs" %}
{% include code-snippet/grid/filtering/filter-case-sensitivity/filter.cs %}
{% endhighlight %}
{% endtabs %}

![Filtering](../images/filtering/filter-case-sensitivity.gif)

## Diacritics filtering

The diacritics filter feature handles text data that contains accented characters such as é, ñ, ü, and ç. By default, the grid ignores these characters during filtering.

This feature is essential for international data where names like "José" and "Jose" should be treated differently (or the same, depending on requirements).

Enable diacritic character consideration by setting [filterSettings.ignoreAccent](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridFilterSettings.html#Syncfusion_EJ2_Grids_GridFilterSettings_IgnoreAccent) property to `true`.

The following example demonstrates diacritics filtering with the `ignoreAccent` property set to `true`:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/filtering/filter-diacritics/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="filter.cs" %}
{% include code-snippet/grid/filtering/filter-diacritics/filter.cs %}
{% endhighlight %}
{% endtabs %}

![Filtering](../images/filtering/filter-diacritics.png)

## Wildcard and LIKE filters

`Wildcard` and `LIKE` filter operators filter values based on the given string pattern, and they apply to string-type columns. However, they work slightly differently.

### Wildcard filtering

The `Wildcard` filter processes one or more search patterns using the "*" symbol, retrieving values matching the specified patterns. This filter option supports a wide range of search scenarios.

**Wildcard pattern examples:**

| Operator | Description |
|----------|-------------|
| a*b | Everything that starts with "a" and ends with "b" |
| a* | Everything that starts with "a" |
| *b | Everything that ends with "b" |
| *a* | Everything that contains "a" |
| *a*b* | Everything containing "a", followed by anything, then "b", followed by anything |

![Wildcard filter in ASP.NET Core Grid](../images/filtering/filtering-wildcard.gif)

### LIKE filtering

The `LIKE` filter processes single search patterns using the "%" symbol, retrieving values matching the specified patterns. The following Data Grid features support LIKE filtering on string-type columns:

* Filter Menu
* Filter Bar with [filterSettings.showFilterBarOperator](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridFilterSettings.html#Syncfusion_EJ2_Grids_GridFilterSettings_ShowFilterBarOperator) property enabled
* Custom Filter of Excel filter type.

**LIKE pattern examples:**

| Operator | Description |
|----------|-------------|
| %ab% | Returns all values that contain "ab" characters |
| ab% | Returns all values that end with "ab" characters |
| %ab | Returns all values that start with "ab" characters |

![LIKE filter in ASP.NET Core Grid.](../images/filtering/filtering-like-fliter.gif)

## Configure different filter types for columns

The Data Grid offers flexibility to customize filtering behavior for different columns by enabling various filter types such as `Menu`, `Excel`, or `CheckBox`. This allows the filtering experience to be tailored to suit specific column needs. For example, use a menu-based filter for a category column, an Excel-like filter for a date column, and a checkbox filter for a status column.

It can be achieved by adjusting the `column.filter.type` property based on requirements.

The following example demonstrates configuring the Menu filter as the default filter type for all columns and modifying filter types dynamically using a dropdown.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/filtering/Enable-different-filter-column/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="filter.cs" %}
{% include code-snippet/grid/filtering/Enable-different-filter-column/filter.cs %}
{% endhighlight %}
{% endtabs %}

![Filtering](../images/filtering/filter-enable-different.gif)

## Change default filter operator for a particular column

The Data Grid provides flexibility to change the default filter operator for a particular column. By default, the filter operator for string columns is `startswith`, for numeric columns is `equal`, and for boolean columns is `equal`. Customize the filter operator to better match the nature of the data using the `operator` property within [filterSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_FilterSettings) configuration.

The following example demonstrates changing the default filter operator for a column:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/filtering/filter-operator-particular/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="filter.cs" %}
{% include code-snippet/grid/filtering/filter-operator-particular/filter.cs %}
{% endhighlight %}
{% endtabs %}

![Filtering](../images/filtering/filter-particular-column.png)

## Enum filtering with custom filter templates

The Data Grid supports filtering enum-type data using the [filterBarTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_FilterBarTemplate) feature. This is particularly useful for filtering predefined values, such as categories or statuses.

To achieve this functionality:

1. Render a [DropDownList](https://ej2.syncfusion.com/aspnetcore/documentation/drop-down-list/getting-started) in the `filterBarTemplate` for the enum-type column.

2. Bind the enumerated list data to the column.

3. Convert the `enum` values to a readable format using a computed column (e.g., TypeText) in the data model.
    ```cs
    public FileType Type { get; set; }
    public string TypeText => Type.ToString();
    ```

4. In the [change](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.DropDownList.html#Syncfusion_EJ2_DropDowns_DropDownList_Change) event of the `DropDownList`, dynamically filter the column using the `filterByColumn` method.

The following example demonstrates enum-type data filtering:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/filtering/enum-filtering/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="filter-bar.cs" %}
{% include code-snippet/grid/filtering/enum-filtering/filter.cs %}
{% endhighlight %}
{% endtabs %}

![Filter bar](../images/filtering/enum-filtering.png)

## Filtering events

Filtering events allow customization of grid behavior during filtering operations. Filtering can be prevented for specific columns, custom messages can be displayed, and additional actions can be performed based on application requirements.

Implement filtering events using available events such as [actionBegin](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionBegin) and [actionComplete](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionComplete). These events enable intervention in the filtering process and customization as needed.

The following example demonstrates filtering prevention for the "Ship City" column during the `actionBegin` event:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/filtering/filter-events/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="filter.cs" %}
{% include code-snippet/grid/filtering/filter-events/filter.cs %}
{% endhighlight %}
{% endtabs %}

![Filtering](../images/filtering/filter-events.gif)

## See also

* [Customizing Filter Dialog by using an additional parameter](../how-to/add-params-for-filtering)
* [Hide sorting options on Excel filter dialog](../how-to/hide-sorting-in-excel-filter)