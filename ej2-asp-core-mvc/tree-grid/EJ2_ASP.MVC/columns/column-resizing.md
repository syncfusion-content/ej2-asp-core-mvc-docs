---
layout: post
title: Column Resizing in ##Platform_Name## Tree Grid Component | Syncfusion
description: Learn here all about Column Resizing in Syncfusion ##Platform_Name## Tree Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Column Resizing
publishingplatform: ##Platform_Name##
documentation: ug
---

# Column Resizing in ##Platform_Name## Tree Grid Component

Column width can be resized by clicking and dragging the right edge of the column header. While dragging, the width of the respective column will be resized immediately. Each column can be auto resized by double-clicking the right edge of the column header to fit the width of that column based on the widest cell content. To enable column resize, set the [`AllowResizing`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~AllowResizing.html) property to true.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="Resizing.cs" %}
{% include code-snippet/tree-grid/columns-mvc/resizing/resizing.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-mvc/resizing/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Resizing.cs" %}
{% include code-snippet/tree-grid/columns-mvc/resizing/resizing.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You can disable resizing for a particular column by setting the [`AllowResizing`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~AllowResizing.html) property of [`Column`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn.html) to false.
> In RTL mode, you can click and drag the left edge of the header cell to resize the column.

## Min and max width

Column resize can be restricted between minimum and maximum width by defining the [`MinWidth`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~MinWidth.html) and [`MaxWidth`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~MaxWidth.html) in [`Column`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn.html) API.

In the following sample, minimum and maximum width are defined for **Duration**, and **Task Name** columns.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="Minmax.cs" %}
{% include code-snippet/tree-grid/columns-mvc/minmax/minmax.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-mvc/minmax/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Minmax.cs" %}
{% include code-snippet/tree-grid/columns-mvc/minmax/minmax.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Resize stacked column

Stacked columns can be resized by clicking and dragging the right edge of the stacked column header. While dragging, the width of the respective child columns will be resized at the same time. You can disable resize for particular stacked column by setting [`AllowResizing`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~AllowResizing.html) as **false** to its columns.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-mvc/stackedresize/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Stackedresize.cs" %}
{% include code-snippet/tree-grid/columns-mvc/stackedresize/stackedresize.cs %}
{% endhighlight %}
{% endtabs %}

## Touch interaction

When the right edge of the header cell is tapped, a floating handler will be visible over the right border of the column. To resize the column, tap and drag the floating handler as needed.

The following screenshot represents the column resizing in touch device.

![Touch Interaction](images/column-resizing.png)



> You can refer to our [`ASP.NET MVC Tree Grid`](https://www.syncfusion.com/aspnet-mvc-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our [`ASP.NET MVC Tree Grid example`](https://ej2.syncfusion.com/aspnetmvc/TreeGrid/Overview#/material) to knows how to present and manipulate data.