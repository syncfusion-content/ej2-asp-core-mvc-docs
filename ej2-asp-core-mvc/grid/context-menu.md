---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Context Menu of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Context Menu
publishingplatform: ##Platform_Name##
documentation: ug
---

`AutoFit`|  Auto fit the current column.
`AutoFitAll` | Auto fit all columns.
`Edit`|  Edit the current record.
`Delete` | Delete the current record.
`Save` | Save the edited record.
`Cancel` | Cancel the edited state.
`Copy` | Copy the selected records.
`PdfExport` | Export the grid data as Pdf document.
`ExcelExport` | Export the grid data as Excel document.
`CsvExport` | Export the grid data as CSV document.
`Group` | Group the current column.
`Ungroup` | Ungroup the current column.
`SortAscending` | Sort the current column in ascending order.
`SortDescending` | Sort the current column in descending order.
`FirstPage` | Go to the first page.
`PrevPage` | Go to the previous page.
`LastPage` | Go to the last page.
`NextPage` | Go to the next page.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight %}
{% include_relative code-snippet/context-menu/contextmenu/contextmenu.cs %}
{% endhighlight %}
{% highlight %}
{% include_relative code-snippet/context-menu/contextmenu/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight %} {% include_relative code-snippet/context-menu/contextmenu/contextmenu.cs %}
{% endhighlight %}
{% highlight %}
{% include_relative code-snippet/context-menu/contextmenu/razor %}
{% endhighlight %}
{% endtabs %}



## Custom context menu items

The custom context menu items can be added by defining the [`ContextMenuItems`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ContextMenuItems) as a collection of
[`ContextMenuItemModel`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ContextMenuItems).
Actions for this customized items can be defined in the [`ContextMenuClick`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ContextMenuClick) event.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight %}
{% include_relative code-snippet/context-menu/customcontextmenu/customcontextmenu.cs %}
{% endhighlight %}
{% highlight %}
{% include_relative code-snippet/context-menu/customcontextmenu/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight %} {% include_relative code-snippet/context-menu/customcontextmenu/customcontextmenu.cs %}
{% endhighlight %}
{% highlight %}
{% include_relative code-snippet/context-menu/customcontextmenu/razor %}
{% endhighlight %}
{% endtabs %}



> You can hide or show an item in context menu for specific area inside of grid by defining the `Target` property.
