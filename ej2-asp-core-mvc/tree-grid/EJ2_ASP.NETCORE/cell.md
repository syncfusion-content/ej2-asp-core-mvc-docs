---
layout: post
title: Cell in ##Platform_Name## Tree Grid Component
description: Learn here all about Cell in Syncfusion ##Platform_Name## Tree Grid component and more.
platform: ej2-asp-core-mvc
control: Cell
publishingplatform: ##Platform_Name##
documentation: ug
---


# Cell

## Displaying the HTML content

The HTML tags can be displayed in the TreeGrid header and content by enabling the [`disableHtmlEncode`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~DisableHtmlEncode.html) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/cell/html-encode/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="HtmlEncode.cs" %}
{% include code-snippet/tree-grid/cell/html-encode/htmlEncode.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/cell/html-encode/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HtmlEncode.cs" %}
{% include code-snippet/tree-grid/cell/html-encode/htmlEncode.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Customize cell styles

The appearance of cells can be customized by using the [`queryCellInfo`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~QueryCellInfo.html) event.
The [`queryCellInfo`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~QueryCellInfo.html) event triggers for every cell. In that event handler, you can get **QueryCellInfoEventArgs** that contains the details of the cell.

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



## Auto wrap

The auto wrap allows the cell content of the treegrid to wrap to the next line when it exceeds the boundary of the cell width. The Cell Content wrapping works based on the position of white space between words.
To enable auto wrap, set the [`allowTextWrap`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~AllowTextWrap.html) property to **true**.

> When a column width is not specified, then auto wrap of columns will be adjusted with respect to the treegrid's width.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/cell/auto-wrap/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="AutoWrap.cs" %}
{% include code-snippet/tree-grid/cell/auto-wrap/autoWrap.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/cell/auto-wrap/razor %}
{% endhighlight %}
{% highlight c# tabtitle="AutoWrap.cs" %}
{% include code-snippet/tree-grid/cell/auto-wrap/autoWrap.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You can refer to our  [`ASP.NET Core Tree Grid`](https://www.syncfusion.com/aspnet-core-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our ASP.NET Core Tree Grid example [`ASP.NET Core Tree Grid example`](https://ej2.syncfusion.com/aspnetcore/TreeGrid/Overview#/material) to knows how to present and manipulate data.
