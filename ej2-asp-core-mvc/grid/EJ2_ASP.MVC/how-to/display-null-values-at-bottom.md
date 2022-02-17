---
layout: post
title: Display Null Values At Bottom in ##Platform_Name## Grid Component
description: Learn here all about Display Null Values At Bottom in Syncfusion ##Platform_Name## Grid component and more.
platform: ej2-asp-core-mvc
control: Display Null Values At Bottom
publishingplatform: ##Platform_Name##
documentation: ug
---


# Display the null date values at bottom of the Grid while perform sorting

By default the null values are displayed at bottom of the Grid row while perform sorting in ascending order. As well as this values are displayed at top of the Grid row while perform sorting with descending order. But you can customize this default order to display the null values at always bottom row of the Grid by using [`SortComparer`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_SortComparer) property of [`Column`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html).

In the below code we have displayed the null date values at bottom of the Grid row while sorting the **OrderDate** column in both ways.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/sort-comparer/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Sort-comparer.cs" %}
{% include code-snippet/grid/how-to/sort-comparer/sort-comparer.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/sort-comparer/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Sort-comparer.cs" %}
{% include code-snippet/grid/how-to/sort-comparer/sort-comparer.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


