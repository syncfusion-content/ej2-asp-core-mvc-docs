---
layout: post
title: Excel Export in ##Platform_Name## Tree Grid Component
description: Learn here all about Excel Export in Syncfusion ##Platform_Name## Tree Grid component and more.
platform: ej2-asp-core-mvc
control: Excel Export
publishingplatform: ##Platform_Name##
documentation: ug
---


# Excel Export

The excel export allows exporting TreeGrid data to Excel document. You need to use the
 [`excelExport`](https://ej2.syncfusion.com/documentation/api/grid/#excelexport) method for exporting. To enable Excel export in the treegrid, set the [`AllowExcelExport`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~AllowExcelExport.html) as true.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/excel-export/export/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Export.cs" %}
{% include code-snippet/tree-grid/excel-export/export/export.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/excel-export/export/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Export.cs" %}
{% include code-snippet/tree-grid/excel-export/export/export.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## To customize excel export

The excel export provides an option to customize mapping of the treegrid to excel document.

### Export hidden columns

The excel export provides an option to export hidden columns of treegrid by defining [`includeHiddenColumn`](https://ej2.syncfusion.com/documentation/api/grid/excelExportProperties/#includehiddencolumn) in [`ExcelExportProperties`](https://ej2.syncfusion.com/documentation/api/grid/excelExportProperties/#excelexportproperties) as **true**.

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



### Show or Hide columns on Exported Excel

You can show a hidden column or hide a visible column while printing the treegrid using [`ToolbarClick`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~ToolbarClick.html) and [`ExcelExportComplete`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~ExcelExportComplete.html) events.

In the [`ToolbarClick`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~ToolbarClick.html) event, based on **args.item.text** as **Excel Export**. We can show or hide columns by setting [`Visible`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Visible.html) property to **true** or **false** respectively.

In [`ExcelExportComplete`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~ExcelExportComplete.html) event, We have reversed the state back to the previous state.

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



### Conditional Cell Formatting

TreeGrid cells in the exported Excel can be customized or formatted using [`ExcelQueryCellInfo`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~ExcelQueryCellInfo.html) event. In this event, we can format the treegrid cells of exported PDF document based on the column cell value.

In the below sample, we have set the background color for **Duration** column in the exported excel by **args.cell** and **backgroundColor** property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/excel-export/conditional-cell/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Conditional-cell.cs" %}
{% include code-snippet/tree-grid/excel-export/conditional-cell/conditional-cell.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/excel-export/conditional-cell/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Conditional-cell.cs" %}
{% include code-snippet/tree-grid/excel-export/conditional-cell/conditional-cell.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Theme

The excel export provides an option to include theme for exported excel document.

To apply theme in exported Excel, define the [`theme`](https://ej2.syncfusion.com/documentation/api/grid/excelExportProperties/#theme) in [`ExcelExportProperties`](https://ej2.syncfusion.com/documentation/api/grid/excelExportProperties/#excelexportproperties).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/excel-export/theme/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Theme.cs" %}
{% include code-snippet/tree-grid/excel-export/theme/theme.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/excel-export/theme/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Theme.cs" %}
{% include code-snippet/tree-grid/excel-export/theme/theme.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



>By default, material theme is applied to exported excel document.

### To add header and footer

The excel export provides an option to include header and footer content for exported excel document.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/excel-export/header-footer/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Header-footer.cs" %}
{% include code-snippet/tree-grid/excel-export/header-footer/header-footer.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/excel-export/header-footer/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Header-footer.cs" %}
{% include code-snippet/tree-grid/excel-export/header-footer/header-footer.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### File Name for Exported document

You can assign the file name for the exported document by defining [`fileName`](https://ej2.syncfusion.com/documentation/api/grid/excelExportProperties/#filename) property in [`ExcelExportProperties`](https://ej2.syncfusion.com/documentation/api/grid/excelExportProperties/#excelexportproperties).

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



### To persist collapsed state

You can persist the collapsed state in the exported document by defining `isCollapsedStatePersist` property as true in `TreeGridExcelExportProperties` parameter of [`excelExport`](https://ej2.syncfusion.com/documentation/api/grid/#excelexport) method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/excel-export/is-collapsed/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Is-collapsed.cs" %}
{% include code-snippet/tree-grid/excel-export/is-collapsed/is-collapsed.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/excel-export/is-collapsed/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Is-collapsed.cs" %}
{% include code-snippet/tree-grid/excel-export/is-collapsed/is-collapsed.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You can refer to our [`ASP.NET MVC Tree Grid`](https://www.syncfusion.com/aspnet-mvc-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our [`ASP.NET MVC Tree Grid example`](https://ej2.syncfusion.com/aspnetmvc/TreeGrid/Overview#/material) to knows how to present and manipulate data.