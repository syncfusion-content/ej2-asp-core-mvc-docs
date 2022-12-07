---
layout: post
title: Filter Menu in ##Platform_Name## Grid Control | Syncfusion
description: Learn here all about Filter Menu in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Filter Menu
publishingplatform: ##Platform_Name##
documentation: ug
---


# Filter Menu in Grid Control

You can enable filter menu by setting the [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridFilterSettings.html#Syncfusion_EJ2_Grids_GridFilterSettings_Type) of **e-grid-filterSettings** as **Menu**. The filter menu UI will be rendered based on its column type, which allows you to filter data. You can filter the records with different operators.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/filtering/filtermenu/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Filtermenu.cs" %}
{% include code-snippet/grid/filtering/filtermenu/filtermenu.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/filtering/filtermenu/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Filtermenu.cs" %}
{% include code-snippet/grid/filtering/filtermenu/filtermenu.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> * [`allowFiltering`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowFiltering) must be set as true to enable filter menu.
> * Setting [`allowFiltering`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_AllowFiltering) property of **e-grid-column** as false will prevent filter menu rendering for a particular column.

## Customizing filter menu operators list

You can customize the default filter operator list by defining the [`operators`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridFilterSettings.html#Syncfusion_EJ2_Grids_GridFilterSettings_Operators) property of [`e-grid-filterSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridFilterSettings.html) tag helper.

The available options are:
* `stringOperator`- defines customized string operator list.
* `numberOperator` - defines customized number operator list.
* `dateOperator` - defines customized date operator list.
* `booleanOperator` - defines customized boolean operator list.

In the following sample, we have customized string filter operators.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/customize-filter-menu/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Customize-filter-menu.cs" %}
{% include code-snippet/grid/how-to/customize-filter-menu/customize-filter-menu.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/customize-filter-menu/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Customize-filter-menu.cs" %}
{% include code-snippet/grid/how-to/customize-filter-menu/customize-filter-menu.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Enable different filter for a column

You can use both **Menu** and **CheckBox** filter in a same Grid. To do so, set the [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridFilterSettings.html#Syncfusion_EJ2_Grids_GridFilterSettings_Type) as **Menu** in **e-grid-filterSettings** and **CheckBox** in [`filter`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Filter) property of **e-grid-column** tag helper.

In the following sample menu filter is enabled by default and checkbox filter is enabled for the CustomerID column using the [`filter`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Filter) property of **e-grid-column** tag helper.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/filtering/diffcolumnfilter/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Diffcolumnfilter.cs" %}
{% include code-snippet/grid/filtering/diffcolumnfilter/diffcolumnfilter.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/filtering/diffcolumnfilter/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Diffcolumnfilter.cs" %}
{% include code-snippet/grid/filtering/diffcolumnfilter/diffcolumnfilter.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


## Add current selection to filter checkbox

By default, the CheckBox filter can only filter the selected items. If filtering is done multiple times on the same column, the previously filtered values in the column will be cleared. Now, it is possible to retain those previous values by using the `Add current selection to filter` checkbox. This checkbox is displayed when data is searched in the search bar of the CheckBox filter.

The following image describes the above mentioned behavior.

![Checkbox filter](images/checkboxfilter.png)