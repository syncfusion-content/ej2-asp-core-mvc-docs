---
layout: post
title: Excel Export Options in ##Platform_Name## Tree Grid Component
description: Learn here all about Excel Export Options in Syncfusion ##Platform_Name## Tree Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Excel Export Options
publishingplatform: ##Platform_Name##
documentation: ug
---



# Excel Export Options

## Export hidden columns

The excel export provides an option to export hidden columns of treegrid by defining includeHiddenColumn as **true**.

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



## Show or Hide columns on Exported Excel

You can show a hidden column or hide a visible column while printing the treegrid using [`toolbarClick`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~ToolbarClick.html) and [`excelExportComplete`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~ExcelExportComplete.html) events.

In the [`toolbarClick`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~ToolbarClick.html) event, based on **args.item.text** as Excel Export. We can show or hide columns by setting [`visible`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Visible.html) property of [`e-treegrid-column`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn.html) to **true** or **false** respectively.

In the [`excelExportComplete`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~ExcelExportComplete.html) event, We have reversed the state back to the previous state.

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



## File Name for Exported document

You can assign the file name for the exported document by defining fileName property in ExcelExportProperties.

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



> You can refer to our  [`ASP.NET Core Tree Grid`](https://www.syncfusion.com/aspnet-core-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our ASP.NET Core Tree Grid example [`ASP.NET Core Tree Grid example`](https://ej2.syncfusion.com/aspnetcore/TreeGrid/Overview#/material) to knows how to present and manipulate data.