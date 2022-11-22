---
layout: post
title: Cell in ##Platform_Name## Tree Grid Component | Syncfusion
description: Learn here all about Cell in Syncfusion ##Platform_Name## Tree Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Cell
publishingplatform: ##Platform_Name##
documentation: ug
---


# Cell in ##Platform_Name## Tree Grid Component

## Customize cell styles

The appearance of cells can be customized by using the [`queryCellInfo`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~QueryCellInfo.html) event. The [`queryCellInfo`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~QueryCellInfo.html) event triggers for every cell. In that event handler, you can get **QueryCellInfoEventArgs** that contains the details of the cell.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/cell/query-cell/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="QueryCell.cs" %}
{% include code-snippet/tree-grid/cell/query-cell/queryCell.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/cell/query-cell/razor %}
{% endhighlight %}
{% highlight c# tabtitle="QueryCell.cs" %}
{% include code-snippet/tree-grid/cell/query-cell/queryCell.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You can refer to our  [`ASP.NET Core Tree Grid`](https://www.syncfusion.com/aspnet-core-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our ASP.NET Core Tree Grid example [`ASP.NET Core Tree Grid example`](https://ej2.syncfusion.com/aspnetcore/TreeGrid/Overview#/material) to knows how to present and manipulate data.