---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Get Row Cell Index of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Get Row Cell Index
publishingplatform: ##Platform_Name##
documentation: ug
---


# Get specific row and cell index in Grid

You can get the specific row and cell index of the grid by using [`rowSelected`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_RowSelected) event of the grid. Here, we can get the row and cell index by using **aria-rowindex**(get row Index from **tr** element) and **aria-colindex**(column index from **td** element) attribute.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="rowcellidx" %}
{% include code-snippet/grid/how-to/row-cell-index/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="rowcellidx" %}
{% include code-snippet/grid/how-to/row-cell-index/rowcellidx.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="rowcellidx" %}
{% include code-snippet/grid/how-to/row-cell-index/razor %}
{% endhighlight %}
{% highlight c# tabtitle="rowcellidx" %}
{% include code-snippet/grid/how-to/row-cell-index/rowcellidx.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

