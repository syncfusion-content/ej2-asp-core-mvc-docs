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

Allows to order field members in rows and columns either in ascending or descending order. By default, field members in rows and columns are in ascending order.

Member sorting can be enabled by setting the [`enableSorting`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_EnableSorting) property in [`e-datasourcesettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html) tag to **true**. After enabling this API, click the sort icon besides each field in row or column axis, available in field list or grouping bar UI for re-arranging members either in ascending or descending order.

> By default the [`enableSorting`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_EnableSorting) property in [`e-datasourcesettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html) tag set as **true**. If we set it as **false**, then the field members arrange in pivot table as its data source order. And, the sort icons in grouping bar and field list buttons will be removed.

![output](images/sorting_fl.png "Member sorting icon in field list")
<br/>
![output](images/sorting_gb.png "Member sorting icon in grouping bar")
<br/>
![output](images/sorting_grid.png "Resultant pivot table on member sort")

Member sorting can also be configured using the [`e-sortsettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewSortSetting.html) tag through code behind, during initial rendering. The settings required to sort are:

* [`name`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewSortSetting.html#Syncfusion_EJ2_PivotView_PivotViewSortSetting_Name): It allows to set the field name.
* [`order`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewSortSetting.html#Syncfusion_EJ2_PivotView_PivotViewSortSetting_Order): It allows to set the sort direction either to ascending or descending of the respective field.

> By default the [`order`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewSortSetting.html#Syncfusion_EJ2_PivotView_PivotViewSortSetting_Order) property in the [`e-sortsettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewSortSetting.html) tag set as [**Ascending**](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.Sorting.html). Meanwhile, we can arrange the field members as its order in data source by setting it as [**None**](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.Sorting.html) where the sort icons in grouping bar and field list buttons for the corresponding field will be removed.

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

Usually string sorting is applied to field members even if it starts with numbers. But this kind of field members can also be sorted on the basis of numbers that are placed at the beginning of the member name. This can be achieved by setting the [`dataType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotFieldListRow.html#Syncfusion_EJ2_PivotView_PivotFieldListRow_DataType) property as **number** to the desired field.

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



![output](images/alpha-numeric-header.png)


### Custom Sorting

Allows to sort field headers (aka, members) in rows and columns based on user-defined order. This can be configured mainly using the [`membersOrder`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewSortSetting.html#Syncfusion_EJ2_PivotView_PivotViewSortSetting_MembersOrder) in the [`e-sortsettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewSortSetting.html) through code behind, during initial rendering. The other settings required to sort are:

* [`name`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewSortSetting.html#Syncfusion_EJ2_PivotView_PivotViewSortSetting_Name) : It allows to set the field name.
* [`membersOrder`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewSortSetting.html#Syncfusion_EJ2_PivotView_PivotViewSortSetting_MembersOrder) : It holds an array of headers in the order specified by the user.
* [`order`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewSortSetting.html#Syncfusion_EJ2_PivotView_PivotViewSortSetting_Order) : It allows to specify whether the array of headers should be sorted ascending or descending.

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



![output](images/Custom sorting.png "Custom Sorting")


## Value Sorting

> This property is applicable only for relational data source.

Allows to sort individual value field and its aggregated values either in row or column axis in both ascending and descending order. It can been enabled by setting the [`enableValueSorting`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_EnableValueSorting) property in [`ejs-pivotview`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html) tag to **true**. On enabling, end user can sort the values by directly clicking the value field header positioned either in row or column axis of the pivot table component.

The value sorting can also be configured using the [`e-valuesortsettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewValueSortSettings.html) option through code behind. The settings required to sort value fields are:

* [`headerText`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewValueSortSettings.html#Syncfusion_EJ2_PivotView_PivotViewValueSortSettings_HeaderText): It allows to set the header names with delimiters, that is used for value sorting. The header names are arranged from Level 1 to Level N, down the hierarchy with a delimiter for better specification.
* [`headerDelimiter`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewValueSortSettings.html#Syncfusion_EJ2_PivotView_PivotViewValueSortSettings_HeaderDelimiter): It allows to set the delimiters string to separate the header text between levels.
* [`sortOrder`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewValueSortSettings.html#Syncfusion_EJ2_PivotView_PivotViewValueSortSettings_SortOrder): It allows to set the sort direction of the value field.

> Value fields are set to the column axis by default. In such cases, the value sorting applied will have an effect on the column alone. You need to place the value fields in the row axis to do so in row wise. For more information, please [`refer here`](https://ej2.syncfusion.com/aspnetcore/documentation/pivot-table/data-binding/#values-in-row-axis).

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



![output](images/valuesorting.png)

## Event

### OnHeadersSort

The event [`OnHeadersSort`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_OnHeadersSort) triggers when clicking the value sort icon or the sort icon in the field button, which is present in both grouping bar and field list UI. This allows user to identify the current action being performed at runtime. It has the following parameters:

* `fieldName`: It holds the field name where the sort settings applied.

* `sortOrder`: It holds the current sort order of the field.

* `members`: It holds the sorted headers according to the specified sort order.

* `levelName`: It holds the specific field's unique level name. **Note:** This option is applicable only for OLAP data.

* `isOrderChanged`: By setting this boolean property to true, it allows to display the modified members order.

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



![output](images/Custom sorting_event.png "Custom Sorting Event")


### ActionBegin

The event [`actionBegin`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_ActionBegin) triggers when clicking the value sort icon or the sort icon in the field button, which is present in both grouping bar and field list UI. This allows user to identify the current action being performed at runtime. It has the following parameters:

* `dataSourceSettings`: It holds the current data source settings such as input data source, rows, columns, values, filters, format settings and so on.

* `actionName`: It holds the name of the current action began. The following are the UI actions and their names:

| Action | Action Name|
|------|-------------|
| [`Sort field`](./sorting/#member-sorting)| Sort field |
| [`Value sort icon`](./sorting/#value-sorting)| Sort value|

* `fieldInfo`: It holds the selected field information.

> This option is applicable only when the field based UI actions are performed such as filtering, sorting, removing field from grouping bar, editing and aggregation type change.

* `cancel`: It allows user to restrict the current action.

In the below sample, sort action can be restricted by setting the **args.cancel** option to **true** in the `actionBegin` event.

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

The event [`actionComplete`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_ActionComplete) triggers when the UI actions such as value sorting or sorting via the field button, which is present in both grouping bar and field list UI, is completed. This allows user to identify the current UI actions being completed at runtime. It has the following parameters:

* `dataSourceSettings`:  It holds the current data source settings such as input data source, rows, columns, values, filters, format settings and so on.

* `actionName`: It holds the name of the current action completed. The following are the UI actions and their names:

| Action | Action Name|
|------|-------------|
| [`Sort field`](./sorting/#member-sorting)| Field sorted|
| [`Value sort icon`](./sorting/#value-sorting)| Value sorted|

* `fieldInfo`: It holds the selected field information.

> This option is applicable only when the field based UI actions are performed such as filtering, sorting, removing field from grouping bar, editing and aggregation type change.

* `actionInfo`: It holds the unique information about the current UI action. For example, if sorting is completed, the event argument contains information such as sort order and the field name.

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

The event [`actionFailure`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_ActionFailure) triggers when the current UI action fails to achieve the desired result. It has the following parameters:

* `actionName`: It holds the name of the current action failed. The following are the UI actions and their names:

| Action | Action Name|
|------|-------------|
| [`Sort field`](./sorting/#member-sorting)| Sort field |
| [`Value sort icon`](./sorting/#value-sorting)| Sort value|

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

