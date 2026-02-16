---
layout: post
title: Sorting in ##Platform_Name## Syncfusion Pivot Table Component
description: Learn here all about Sorting in Syncfusion ##Platform_Name## Pivot Table component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Sorting
publishingplatform: ##Platform_Name##
documentation: ug
---


# Sorting in ##Platform_Name## Pivot Table Component

## Member Sorting

The Member Sorting functionality enables you to arrange field members in the rows and columns of a pivot table in either **ascending** or **descending** order. By default, field members are sorted in ascending order.

### Enabling Member Sorting

To enable member sorting, set the [`enableSorting`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_EnableSorting) property in [`e-datasourcesettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html) to **true**. Once enabled, you can click the sort icon next to each field in the row or column axis within the **Field List** or **Grouping Bar** UI to reorder members in ascending or descending order.

> By default the [`enableSorting`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_EnableSorting) property in [`e-datasourcesettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html) set as **true**. If we set it as **false**, then the field members arrange in pivot table as its data source order. And, the sort icons in grouping bar and field list buttons will be removed.

#### Visual Reference

- **Field List Sort Icon**:  
  ![Member sorting icon in field list](images/sorting_fl.png)

- **Grouping Bar Sort Icon**:  
  ![Member sorting icon in grouping bar](images/sorting_gb.png)

- **Sorted Pivot Table**:  
  ![Resultant pivot table after member sorting](images/sorting_grid.png)

### Configuring Member Sorting Code Behind

You can also configure member sorting during initial rendering using the [`e-sortsettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewSortSetting.html) property in code behind. The required settings are:

* [`name`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewSortSetting.html#Syncfusion_EJ2_PivotView_PivotViewSortSetting_Name): Specifies the name of the field to sort.
* [`order`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewSortSetting.html#Syncfusion_EJ2_PivotView_PivotViewSortSetting_Order): Defines the sort direction, either [**Ascending**](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.Sorting.html#Syncfusion_EJ2_PivotView_Sorting_Ascending) or [**Descending**](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.Sorting.html#Syncfusion_EJ2_PivotView_Sorting_Descending).

> By default the [`order`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewSortSetting.html#Syncfusion_EJ2_PivotView_PivotViewSortSetting_Order) property in the [`e-sortsettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewSortSetting.html) set as [**Ascending**](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.Sorting.html#Syncfusion_EJ2_PivotView_Sorting_Ascending). Meanwhile, we can arrange the field members as its order in data source by setting it as [**None**](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.Sorting.html#Syncfusion_EJ2_PivotView_Sorting_None) where the sort icons in grouping bar and field list buttons for the corresponding field will be removed.

The following example demonstrates how to configure the Pivot Table to enable member sorting and set the "Year" field to sort in descending order:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/sorting/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Sorting.cs" %}
{% include code-snippet/pivot-table/sorting/Sorting.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/sorting/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Sorting.cs" %}
{% include code-snippet/pivot-table/sorting/Sorting.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Alphanumeric Sorting

Usually, string sorting is applied to field members even if their names start with numbers. To sort field members numerically based on the numbers at the beginning of their names, you can set the [`dataType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotFieldListRow.html#Syncfusion_EJ2_PivotView_PivotFieldListRow_DataType) property to **number** for the specific field. This enables numeric sorting instead of alphabetical sorting, allowing for better logical ordering of numbered items.

When [`dataType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotFieldListRow.html#Syncfusion_EJ2_PivotView_PivotFieldListRow_DataType) is set to **number**, the component intelligently sorts members like '71-AJ', '209-FB', '36-SW' in the correct numerical sequence (36-SW, 71-AJ, 209-FB) rather than alphabetical order (209-FB, 36-SW, 71-AJ).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/sorting/alpha-numeric-headers/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="AlphaHeader.cs" %}
{% include code-snippet/pivot-table/sorting/alpha-numeric-headers/AlphaHeader.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/sorting/alpha-numeric-headers/razor %}
{% endhighlight %}
{% highlight c# tabtitle="AlphaHeader.cs" %}
{% include code-snippet/pivot-table/sorting/alpha-numeric-headers/AlphaHeader.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Alphanumeric sorting example](images/alpha-numeric-header.png)

### Custom Sorting

Custom sorting allows you to sort field members (also referred to as headers) in rows and columns based on a user-defined order rather than an alphabetical or numerical sequence. This functionality is configured using the eld headers (aka, members) in rows and columns based on user-defined order. This can be configured mainly using the [`membersOrder`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewSortSetting.html#Syncfusion_EJ2_PivotView_PivotViewSortSetting_MembersOrder) property within the [`e-sortsettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewSortSetting.html) during component initialization.

To set up custom sorting, use the following properties:

- [`name`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewSortSetting.html#Syncfusion_EJ2_PivotView_PivotViewSortSetting_Name): Specifies the field name to apply custom sorting.
- eld headers (aka, members) in rows and columns based on user-defined order. This can be configured mainly using the [`membersOrder`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewSortSetting.html#Syncfusion_EJ2_PivotView_PivotViewSortSetting_MembersOrder): An array of member values arranged in the user-defined sequence.
- [`order`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewSortSetting.html#Syncfusion_EJ2_PivotView_PivotViewSortSetting_Order): Determines whether the specified member array should be arranged in ascending or descending order.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/sorting/custom-sorting/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-sorting.cs" %}
{% include code-snippet/pivot-table/sorting/custom-sorting/Custom-sorting.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/sorting/custom-sorting/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-sorting.cs" %}
{% include code-snippet/pivot-table/sorting/custom-sorting/Custom-sorting.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Custom sorting example](images/Custom sorting.png)

## Value Sorting

Value sorting allows users to sort a specific value field and its aggregated values in either the row or column axis, in ascending or descending order. To enable this functionality, set the [`enableValueSorting`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_EnableValueSorting) property in [`ejs-pivotview`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html) tag to **true**. Once enabled, users can sort values by clicking the header of a value field in the pivot table's row or column axis.

You can also configure value sorting programmatically using the [`e-valuesortsettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewValueSortSettings.html) option. The required settings are:

* [`headerText`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewValueSortSettings.html#Syncfusion_EJ2_PivotView_PivotViewValueSortSettings_HeaderText): It allows to set the header names with delimiters, that is used for value sorting. The header names are arranged from Level 1 to Level N, down the hierarchy with a delimiter for better specification.
* [`headerDelimiter`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewValueSortSettings.html#Syncfusion_EJ2_PivotView_PivotViewValueSortSettings_HeaderDelimiter): It allows to set the delimiters string to separate the header text between levels.
* [`sortOrder`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewValueSortSettings.html#Syncfusion_EJ2_PivotView_PivotViewValueSortSettings_SortOrder): It allows to set the sort direction of the value field.

> Value fields are set to the column axis by default. In such cases, the value sorting applied will have an effect on the column alone. You need to place the value fields in the row axis to do so in row wise. For more information, please [`refer here`](https://ej2.syncfusion.com/aspnetcore/documentation/pivot-table/data-binding#values-in-row-axis).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/value-sorting/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ValueSorting.cs" %}
{% include code-snippet/pivot-table/value-sorting/ValueSorting.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/value-sorting/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ValueSorting.cs" %}
{% include code-snippet/pivot-table/value-sorting/ValueSorting.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Value sorting example](images/valuesorting.png)

### Multiple Axis Sorting

Multiple axis sorting allows simultaneous sorting of value fields in both row and column axes for more flexible and precise data analysis. Apply this functionality using the following settings in [`valueSortSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewValueSortSettings.html#Syncfusion_EJ2_PivotView_PivotViewValueSortSettings):

* [`columnHeaderText`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewValueSortSettings.html#Syncfusion_EJ2_PivotView_PivotViewValueSortSettings_ColumnHeaderText): Specifies the column header hierarchy for value sorting. Header levels are defined from Level 1 to N using a delimiter for clarity.
* [`headerDelimiter`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewValueSortSettings.html#Syncfusion_EJ2_PivotView_PivotViewValueSortSettings_HeaderDelimiter): It allows to set the delimiters string to separate the header text between levels.
* [`columnSortOrder`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewValueSortSettings.html#Syncfusion_EJ2_PivotView_PivotViewValueSortSettings_ColumnSortOrder): Determines the sorting direction for the specified column header.
* [`rowHeaderText`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewValueSortSettings.html#Syncfusion_EJ2_PivotView_PivotViewValueSortSettings_RowHeaderText): Defines the specific row header for which the value sorting should be applied.
* [`rowSortOrder`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewValueSortSettings.html#Syncfusion_EJ2_PivotView_PivotViewValueSortSettings_RowSortOrder): Determines the sorting direction for the specified row header.

> Note: This feature is applicable only to relational data sources and operates exclusively with client-side engine.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/multiple-axis-sorting/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="MultipleAxisSorting.cs" %}
{% include code-snippet/pivot-table/multiple-axis-sorting/MultipleAxisSorting.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/multiple-axis-sorting/razor %}
{% endhighlight %}
{% highlight c# tabtitle="MultipleAxisSorting.cs" %}
{% include code-snippet/pivot-table/multiple-axis-sorting/MultipleAxisSorting.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Multiple Axis Sorting](images/multiple-axis-sorting.png)

## Event

### OnHeadersSort

The [`OnHeadersSort`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_OnHeadersSort) event is triggered each time a row or column header cell is rendered after sorting is applied. This event enables users to customize the order of headers(also referred to as members) in the pivot table. It provides the following parameters:

* `fieldName`: It holds the field name where the sort settings applied.

* `sortOrder`: It holds the current sort order of the field.

* `members`: It holds the sorted headers according to the specified sort order.

* `levelName`: It holds the specific field's unique level name. **Note:** This option is applicable only for OLAP data.

* `isOrderChanged`: By setting this boolean property to **true**, it allows to display the modified members order.

The example below demonstrates how to use the [`OnHeadersSort`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_OnHeadersSort) event in the Pivot Table component to customize the header order for specific fields, such as **Country** and **Year**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/onHeaderSort/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="OnHeaderSort.cs" %}
{% include code-snippet/pivot-table/onHeaderSort/OnHeaderSort.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/onHeaderSort/razor %}
{% endhighlight %}
{% highlight c# tabtitle="OnHeaderSort.cs" %}
{% include code-snippet/pivot-table/onHeaderSort/OnHeaderSort.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![OnHeadersSort event example](images/Custom sorting_event.png)

### ActionBegin

The [`actionBegin`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_ActionBegin) event is triggered when the user clicks the value sort icon or the sort icon in a field button, available in both the grouping bar and field list UI. This event allows the user to detect the current action being performed at runtime. The event argument includes the following properties:

* `dataSourceSettings`: Contains the current data source settings, including input data, rows, columns, values, filters, format settings, and more.
* `actionName`: Indicates the name of the action that has begun. The possible UI actions and corresponding names are:

   | Action | Action Name|
   |------|-------------|
   | [`Sort field`](./sorting#member-sorting) | Sort field |
   | [`Value sort icon`](./sorting#value-sorting) | Sort value |

* `fieldInfo`: Provides information about the selected field.
* `cancel`: Set this property to **true** to prevent the current action.

> Note: This event is triggered only when field-based UI actions such as filtering, sorting, removing fields from the grouping bar, editing, or changing the aggregation type are performed.

In the sample below, the sort action is restricted by setting the **args.cancel** property to **true** in the [`actionBegin`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_ActionBegin) event handler.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/action-event/actionBegin-sort/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ActionBegin-aggregation.cs" %}
{% include code-snippet/pivot-table/action-event/actionBegin-sort/actionBegin-aggregation.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/action-event/actionBegin-sort/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ActionBegin-aggregation.cs" %}
{% include code-snippet/pivot-table/action-event/actionBegin-sort/actionBegin-aggregation.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### ActionComplete

The event [`actionComplete`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_ActionComplete) triggers when the UI actions such as value sorting or sorting via the field button, which is present in both grouping bar and field list UI, is completed. This allows user to identify the current UI actions being completed at runtime. The event argument includes the following properties:

* `dataSourceSettings`: Contains the current data source settings, including input data, rows, columns, values, filters, format settings, and more.
* `actionName`: Indicates the name of the completed action. The possible UI actions and corresponding names are:

   | Action | Action Name|
   |------|-------------|
   | [`Sort field`](./sorting#member-sorting) | Field sorted |
   | [`Value sort icon`](./sorting#value-sorting) | Value sorted |

* `fieldInfo`: Provides information about the selected field.
* `actionInfo`: It holds the unique information about the current UI action. For example, if sorting is completed, the event argument contains information such as sort order and the field name.

> Note: This event is triggered only when field-based UI actions such as filtering, sorting, removing fields from the grouping bar, editing, or changing the aggregation type are performed.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/action-event/actionComplete-sort/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ActionComplete-aggregation.cs" %}
{% include code-snippet/pivot-table/action-event/actionComplete-sort/actionComplete-aggregation.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/action-event/actionComplete-sort/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ActionComplete-aggregation.cs" %}
{% include code-snippet/pivot-table/action-event/actionComplete-sort/actionComplete-aggregation.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### ActionFailure

The [`actionFailure`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_ActionFailure) event is triggered when a UI action fails to produce the expected result. This event provides detailed information about the failure through the following parameters:

* `actionName`: It holds the name of the current action failed. The following are the UI actions and their names:

    | Action | Action Name|
    |------|-------------|
    | [`Sort field`](./sorting#member-sorting)| Sort field |
    | [`Value sort icon`](./sorting#value-sorting)| Sort value|

* `errorInfo`: It holds the error information of the current UI action.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/action-event/actionFailure-sort/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ActionFailure-aggregation.cs" %}
{% include code-snippet/pivot-table/action-event/actionFailure-sort/actionFailure-aggregation.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/action-event/actionFailure-sort/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ActionFailure-aggregation.cs" %}
{% include code-snippet/pivot-table/action-event/actionFailure-sort/actionFailure-aggregation.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}
