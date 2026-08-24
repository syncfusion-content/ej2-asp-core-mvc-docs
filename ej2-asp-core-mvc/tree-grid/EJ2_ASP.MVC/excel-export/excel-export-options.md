---
layout: post
title: ##Platform_Name## TreeGrid Excel Export Options | Syncfusion
description: Learn about Excel export options in ##Platform_Name## TreeGrid, including export customization, hidden columns, selected records, and advanced export settings.
platform: ej2-asp-core-mvc
control: Excel Export Options
publishingplatform: ##Platform_Name##
documentation: ug
---


# Excel Export Options in ##Platform_Name## TreeGrid

The excel export provides an option to customize mapping of the tree grid to excel document.

## Export hidden columns

The excel export provides an option to export hidden columns of treegrid by defining [`includeHiddenColumn`](https://ej2.syncfusion.com/documentation/api/grid/excelexportproperties#includehiddencolumn) in [`ExcelExportProperties`](https://ej2.syncfusion.com/documentation/api/grid/excelexportproperties#excelexportproperties) as **true**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/excel-export/hidden-column/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Hidden-column.cs" %}
{% include code-snippet/tree-grid/excel-export/hidden-column/hidden-column.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/excel-export/hidden-column/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Hidden-column.cs" %}
{% include code-snippet/tree-grid/excel-export/hidden-column/hidden-column.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Show or hide columns on exported excel

You can show a hidden column or hide a visible column while printing the treegrid using [`ToolbarClick`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_ToolbarClick) and [`ExcelExportComplete`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_ExcelExportComplete) events.

In the [`ToolbarClick`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_ToolbarClick) event, based on **args.item.text** as **Excel Export**. We can show or hide columns by setting [`Visible`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGrid.TreeGridColumn.html#Syncfusion_EJ2_TreeGrid_TreeGridColumn_Visible) property to **true** or **false** respectively.

In [`ExcelExportComplete`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_ExcelExportComplete) event, We have reversed the state back to the previous state.

In the below example, we have **Duration** as a hidden column in the treegrid. While exporting, we have changed **Duration** to visible column and **StartDate** as hidden column.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/excel-export/show-hide/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Show-hide.cs" %}
{% include code-snippet/tree-grid/excel-export/show-hide/show-hide.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/excel-export/show-hide/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Show-hide.cs" %}
{% include code-snippet/tree-grid/excel-export/show-hide/show-hide.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


## File name for exported document

You can assign the file name for the exported document by defining [`fileName`](https://ej2.syncfusion.com/documentation/api/grid/excelexportproperties#filename) property in [`ExcelExportProperties`](https://ej2.syncfusion.com/documentation/api/grid/excelexportproperties#excelexportproperties).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/excel-export/file-name/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="File-name.cs" %}
{% include code-snippet/tree-grid/excel-export/file-name/file-name.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/excel-export/file-name/razor %}
{% endhighlight %}
{% highlight c# tabtitle="File-name.cs" %}
{% include code-snippet/tree-grid/excel-export/file-name/file-name.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



N> You can refer to our [`ASP.NET MVC Tree Grid`](https://www.syncfusion.com/aspnet-mvc-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our [`ASP.NET MVC Tree Grid example`](https://ej2.syncfusion.com/aspnetmvc/treegrid/overview#/fluent2) to knows how to present and manipulate data.