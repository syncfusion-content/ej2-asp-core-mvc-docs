---
layout: post
title: Filtering in Syncfusion ##Platform_Name## Grid Component
description: Learn here all about Filtering in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Filtering
publishingplatform: ##Platform_Name##
documentation: ug
---


# Filtering in ASP.Net MVC Grid Component

Filtering allows you to view particular records based on filter criteria. To enable filtering in the Grid, set the [`AllowFiltering`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowFiltering) to true. Filtering options can be configured through [`FilterSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridFilterSettings.html) property.

<!---
Grid supports two types of filter, they are:
* Filter bar
* Excel
-->

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/filtering/filter/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Filter.cs" %}
{% include code-snippet/grid/filtering/filter/filter.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/filtering/filter/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Filter.cs" %}
{% include code-snippet/grid/filtering/filter/filter.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You can apply and clear filtering by using [`filterByColumn`](https://ej2.syncfusion.com/documentation/api/grid/#filterbycolumn) and [`clearFiltering`](https://ej2.syncfusion.com/documentation/api/grid/#clearfiltering) methods.
> To disable filtering for a particular column, set [`AllowFiltering`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_AllowFiltering) of [`Column`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html) to false.

## Initial filter

To apply the filter at initial rendering, set the filter **Predicate** object in [`FilterSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridFilterSettings.html) property of [`Column`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/filtering/initialfilter/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Initialfilter.cs" %}
{% include code-snippet/grid/filtering/initialfilter/initialfilter.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/filtering/initialfilter/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Initialfilter.cs" %}
{% include code-snippet/grid/filtering/initialfilter/initialfilter.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Filter operators

The filter operator for a column can be defined in the [`Operators`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridFilterSettings.html#Syncfusion_EJ2_Grids_GridFilterSettings_Operators) property of [`FilterSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridFilterSettings.html).

The available operators and its supported data types are:

|Operator |Description |Supported Types|
|-----|-----|-----|
|startswith |Checks whether the value begins with the specified value. |String|
|endswith |Checks whether the value ends with the specified value. |String|
|contains |Checks whether the value contains the specified value. |String|
|equal |Checks whether the value is equal to the specified value. |String &#124; Number &#124; Boolean &#124; Date|
|notequal |Checks for values not equal to the specified value. |String &#124; Number &#124; Boolean &#124; Date|
|greaterthan |Checks whether the value is greater than the specified value. |Number &#124; Date|
|greaterthanorequal|Checks whether a value is greater than or equal to the specified value. |Number &#124; Date|
|lessthan |Checks whether the value is less than the specified value. |Number &#124; Date|
|lessthanorequal |Checks whether the value is less than or equal to the specified value. |Number &#124; Date|
between|Filter the values based on the range between the start and end specified values. |Number &#124; Date|

> By default, the [`Operators`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridFilterSettings.html#Syncfusion_EJ2_Grids_GridFilterSettings_Operators) value is **equal**.

## See Also

* [Customizing Filter Dialog by using an additional parameter](../how-to/add-params-for-filtering)
* [Hide sorting options on Excel filter Dialog](../how-to/hide-sorting-in-excel-filter)