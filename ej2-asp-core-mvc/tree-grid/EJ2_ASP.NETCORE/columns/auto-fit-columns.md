---
layout: post
title: Auto Fit Columns in ##Platform_Name## Tree Grid Component | Syncfusion
description: Learn here all about Auto Fit Columns in Syncfusion ##Platform_Name## Tree Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Auto Fit Columns
publishingplatform: ##Platform_Name##
documentation: ug
---

# AutoFit Specific Columns in ##Platform_Name## Tree Grid Component

The autoFitColumns method resizes the column to fit the widest cell's content without wrapping. You can autofit a specific column at initial rendering by invoking the **autoFitColumns** method in [`dataBound`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~DataBound.html) event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-core/auto-fit/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Autofit.cs" %}
{% include code-snippet/tree-grid/columns-core/auto-fit/autofit.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Autofit.cs" %}
{% include code-snippet/tree-grid/columns-core/auto-fit/autofit.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



N> You can autofit all the columns by invoking the autoFitColumns method without column names.
<br/> You can refer to our  [`ASP.NET Core Tree Grid`](https://www.syncfusion.com/aspnet-core-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our ASP.NET Core Tree Grid example [`ASP.NET Core Tree Grid example`](https://ej2.syncfusion.com/aspnetcore/TreeGrid/Overview#/material) to knows how to present and manipulate data.