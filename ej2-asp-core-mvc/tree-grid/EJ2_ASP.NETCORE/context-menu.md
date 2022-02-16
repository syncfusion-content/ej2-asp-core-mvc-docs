---
layout: post
title: Context Menu in ##Platform_Name## Tree Grid Component
description: Learn here all about Context Menu in Syncfusion ##Platform_Name## Tree Grid component and more.
platform: ej2-asp-core-mvc
control: Context Menu
publishingplatform: ##Platform_Name##
documentation: ug
---


# Context menu

The TreeGrid has options to show the context menu when right clicked on it. To enable this feature, you need to define either default or custom item in the [`contextMenuItems`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~ContextMenuItems.html) property.

The default items are in the following table.

Items| Description
----|----
`AutoFit`|  Auto fit the current column.
`AutoFitAll` | Auto fit all columns.
`Edit`|  Edit the current record.
`Delete` | Delete the current record.
`Save` | Save the edited record.
`Cancel` | Cancel the edited state.
`PdfExport` | Export the treegrid data as Pdf document.
`ExcelExport` | Export the treegrid data as Excel document.
`CsvExport` | Export the treegrid data as CSV document.
`SortAscending` | Sort the current column in ascending order.
`SortDescending` | Sort the current column in descending order.
`FirstPage` | Go to the first page.
`PrevPage` | Go to the previous page.
`LastPage` | Go to the last page.
`NextPage` | Go to the next page.
`AddRow` | Add new row to the treegrid.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/contextmenu/default-contextmenu/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default-contextmenu.cs" %}
{% include code-snippet/tree-grid/contextmenu/default-contextmenu/default-contextmenu.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/contextmenu/default-contextmenu/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default-contextmenu.cs" %}
{% include code-snippet/tree-grid/contextmenu/default-contextmenu/default-contextmenu.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Custom context menu items

The custom context menu items can be added by defining the [`contextMenuItems`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~ContextMenuItems.html) as a collection of
**contextMenuItemModel**.
Actions for this customized items can be defined in the [`contextMenuClick`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~ContextMenuClick.html) event.

In the below sample, we have shown context menu item for parent rows to expand or collapse child rows.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/contextmenu/custom-contextmenu/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-contextmenu.cs" %}
{% include code-snippet/tree-grid/contextmenu/custom-contextmenu/custom-contextmenu.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/contextmenu/custom-contextmenu/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-contextmenu.cs" %}
{% include code-snippet/tree-grid/contextmenu/custom-contextmenu/custom-contextmenu.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You can hide or show an item in context menu for specific area inside of treegrid by defining the [`target`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.ContextMenu~Target.html) property.
> You can refer to our  [`ASP.NET Core Tree Grid`](https://www.syncfusion.com/aspnet-core-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our ASP.NET Core Tree Grid example [`ASP.NET Core Tree Grid example`](https://ej2.syncfusion.com/aspnetcore/TreeGrid/Overview#/material) to knows how to present and manipulate data.