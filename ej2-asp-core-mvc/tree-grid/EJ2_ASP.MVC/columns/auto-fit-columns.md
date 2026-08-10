---
layout: post
title: ##Platform_Name## TreeGrid Auto Fit Columns | Syncfusion
description: Learn how to use Auto Fit Columns in ##Platform_Name## TreeGrid to automatically resize columns based on content and improve data readability.
platform: ej2-asp-core-mvc
control: Auto Fit Columns
publishingplatform: ##Platform_Name##
documentation: ug
---

# Auto Fit Columns in ##Platform_Name## TreeGrid

The [`autoFitColumns`](https://ej2.syncfusion.com/documentation/api/grid#autofitcolumns) method resizes the column to fit the widest cell's content without wrapping. You can autofit a specific column at initial rendering by invoking the [`autoFitColumns`](https://ej2.syncfusion.com/documentation/api/grid#autofitcolumns) method in [`DataBound`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_DataBound) event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="Autofit.cs" %}
{% include code-snippet/tree-grid/columns-mvc/autofit/autofit.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-mvc/autofit/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Autofit.cs" %}
{% include code-snippet/tree-grid/columns-mvc/autofit/autofit.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



N> You can autofit all the columns by invoking the [`autoFitColumns`](https://ej2.syncfusion.com/documentation/api/grid#autofitcolumns) method without column names.
<br/> You can refer to our [`ASP.NET MVC Tree Grid`](https://www.syncfusion.com/aspnet-mvc-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our [`ASP.NET MVC Tree Grid example`](https://ej2.syncfusion.com/aspnetmvc/TreeGrid/Overview#/material) to knows how to present and manipulate data.