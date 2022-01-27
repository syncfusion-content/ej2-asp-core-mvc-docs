---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Filtering of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Filtering
publishingplatform: ##Platform_Name##
documentation: ug
---

= |=value |equal |Number
!= |!=value |notequal |Number
> |>value |greaterthan |Number
< |<value |lessthan |Number
>= |>=value |greaterthanorequal |Number
<=|<=value|lessthanorequal |Number
* |*value |startswith |String
% |%value |endswith |String
N/A |N/A | `equal` operator will always be used for date filter. |Date
N/A |N/A |`equal` operator will always be used for Boolean filter. |Boolean

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="filter-bar" %}
{% include_relative code-snippet/filtering/filter-bar/filter-bar.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="filter-bar" %}
{% include_relative code-snippet/filtering/filter-bar/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="filter-bar" %}
{% include_relative code-snippet/filtering/filter-bar/filter-bar.cs %}
{% endhighlight %}
{% highlight razor tabtitle="filter-bar" %}
{% include_relative code-snippet/filtering/filter-bar/razor %}
{% endhighlight %}
{% endtabs %}



## Filter bar template with custom component

The [`filterBarTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_FilterBarTemplate) of **e-grid-column** is used to add a custom component for a particular column and this contains the following functions.
* **create** – It is used for creating custom components.
* **read** – It is used to read the Filter value selected.
* **write** - It is used to wire events for custom components.

In the following sample dropdown is used  as custom component in EmployeeID column.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="filterbartemplate" %}
{% include_relative code-snippet/filtering/filterbartemplate/filterbartemplate.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="filterbartemplate" %}
{% include_relative code-snippet/filtering/filterbartemplate/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="filterbartemplate" %}
{% include_relative code-snippet/filtering/filterbartemplate/filterbartemplate.cs %}
{% endhighlight %}
{% highlight razor tabtitle="filterbartemplate" %}
{% include_relative code-snippet/filtering/filterbartemplate/razor %}
{% endhighlight %}
{% endtabs %}



### Change default filterbar operator

You can change the default filter operator by extending **filterOperators** property in [`dataBound`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataBound) event. In the following sample,
we have changed the default operator for string typed columns as **contains** from **startsWith**.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="filteroptr" %}
{% include_relative code-snippet/filtering/filteroptr/filter.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="filteroptr" %}
{% include_relative code-snippet/filtering/filteroptr/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="filteroptr" %}
{% include_relative code-snippet/filtering/filteroptr/filter.cs %}
{% endhighlight %}
{% highlight razor tabtitle="filteroptr" %}
{% include_relative code-snippet/filtering/filteroptr/razor %}
{% endhighlight %}
{% endtabs %}



## Filter menu

You can enable filter menu by setting the [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridFilterSettings.html#Syncfusion_EJ2_Grids_GridFilterSettings_Type) of **e-grid-filterSettings** as **Menu**. The filter menu UI will be rendered based on its column type, which allows you to filter data.
You can filter the records with different operators.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="filtermenu" %}
{% include_relative code-snippet/filtering/filtermenu/filtermenu.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="filtermenu" %}
{% include_relative code-snippet/filtering/filtermenu/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="filtermenu" %}
{% include_relative code-snippet/filtering/filtermenu/filtermenu.cs %}
{% endhighlight %}
{% highlight razor tabtitle="filtermenu" %}
{% include_relative code-snippet/filtering/filtermenu/razor %}
{% endhighlight %}
{% endtabs %}



> * [`allowFiltering`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowFiltering) must be set as true to enable filter menu.
> * Setting [`allowFiltering`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_AllowFiltering) property of **e-grid-column** as false will prevent
 filter menu rendering for a particular column.

### Enable different filter for a column

You can use both **Menu** and **CheckBox** filter in a same Grid. To do so, set the
[`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridFilterSettings.html#Syncfusion_EJ2_Grids_GridFilterSettings_Type) as **Menu** in **e-grid-filterSettings** and **CheckBox** in [`filter`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Filter) property of **e-grid-column** tag helper.

In the following sample menu filter is enabled by default and checkbox filter is enabled for the CustomerID column using the [`filter`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Filter) property of **e-grid-column** tag helper.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="diffcolumnfilter" %}
{% include_relative code-snippet/filtering/diffcolumnfilter/diffcolumnfilter.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="diffcolumnfilter" %}
{% include_relative code-snippet/filtering/diffcolumnfilter/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="diffcolumnfilter" %}
{% include_relative code-snippet/filtering/diffcolumnfilter/diffcolumnfilter.cs %}
{% endhighlight %}
{% highlight razor tabtitle="diffcolumnfilter" %}
{% include_relative code-snippet/filtering/diffcolumnfilter/razor %}
{% endhighlight %}
{% endtabs %}



## Excel like filter

You can enable Excel like filter by defining.
[`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridFilterSettings.html#Syncfusion_EJ2_Grids_GridFilterSettings_Type) as **Excel**.The excel menu contains an option such as Sorting, Clear filter, Sub menu for advanced filtering.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="excelfilter" %}
{% include_relative code-snippet/filtering/excelfilter/excelfilter.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="excelfilter" %}
{% include_relative code-snippet/filtering/excelfilter/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="excelfilter" %}
{% include_relative code-snippet/filtering/excelfilter/excelfilter.cs %}
{% endhighlight %}
{% highlight razor tabtitle="excelfilter" %}
{% include_relative code-snippet/filtering/excelfilter/razor %}
{% endhighlight %}
{% endtabs %}



## See also

* [Customizing filter menu operators list](./how-to/customizing-filter-menu-operators-list)
* [Customizing Filter Dialog by using an additional parameter](./how-to/add-params-for-filtering)
* [Hide sorting options on Excel filter Dialog](./how-to/hide-sorting-in-excel-filter)