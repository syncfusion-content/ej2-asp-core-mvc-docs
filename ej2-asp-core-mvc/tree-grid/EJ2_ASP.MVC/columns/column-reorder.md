---
layout: post
title: Column Reorder in ##Platform_Name## Tree Grid Component | Syncfusion
description: Learn here all about Column Reorder in Syncfusion ##Platform_Name## Tree Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Column Reorder
publishingplatform: ##Platform_Name##
documentation: ug
---

# Reorder in ##Platform_Name## Tree Grid Component

Reordering can be done by drag and drop of a particular column header from one index to another index within the treegrid. To enable reordering, set the [`AllowReordering`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~AllowReordering.html) to true.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="Reorder.cs" %}
{% include code-snippet/tree-grid/columns-mvc/reorder/reorder.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-mvc/reorder/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Reorder.cs" %}
{% include code-snippet/tree-grid/columns-mvc/reorder/reorder.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You can disable reordering a particular column by setting the [`AllowReordering`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~AllowReordering.html) of [`Column`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn.html) to false.

## Reorder Multiple Columns

Multiple columns can be reordered at a time by using the [`reorderColumns`](https://ej2.syncfusion.com/documentation/api/grid/#reordercolumns) method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="ReorderbyColumn.cs" %}
{% include code-snippet/tree-grid/columns-mvc/reorderbyColumn/reorderbyColumn.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-mvc/reorderbyColumn/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ReorderbyColumn.cs" %}
{% include code-snippet/tree-grid/columns-mvc/reorderbyColumn/reorderbyColumn.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You can refer to our [`ASP.NET MVC Tree Grid`](https://www.syncfusion.com/aspnet-mvc-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our [`ASP.NET MVC Tree Grid example`](https://ej2.syncfusion.com/aspnetmvc/TreeGrid/Overview#/material) to knows how to present and manipulate data.