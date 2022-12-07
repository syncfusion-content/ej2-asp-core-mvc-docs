---
layout: post
title: Context Menu in Syncfusion ##Platform_Name## Grid Component
description: Learn here all about Context Menu in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Context Menu
publishingplatform: ##Platform_Name##
documentation: ug
---


# Context menu in ASP.NET MVC Grid Component

The Grid has options to show the context menu when right clicked on it. To enable this feature, you need to define either default or custom item in the [`ContextMenuItems`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ContextMenuItems).

The default items are in the following table.

|Items| Description|
|----|----|
|`AutoFit`|  Auto fit the current column.|
|`AutoFitAll` | Auto fit all columns.|
|`Edit`|  Edit the current record.|
|`Delete` | Delete the current record.|
|`Save` | Save the edited record.|
|`Cancel` | Cancel the edited state.|
|`Copy` | Copy the selected records.|
|`PdfExport` | Export the grid data as Pdf document.|
|`ExcelExport` | Export the grid data as Excel document.|
|`CsvExport` | Export the grid data as CSV document.|
|`Group` | Group the current column.|
|`Ungroup` | Ungroup the current column.|
|`SortAscending` | Sort the current column in ascending order.|
|`SortDescending` | Sort the current column in descending order.|
|`FirstPage` | Go to the first page.|
|`PrevPage` | Go to the previous page.|
|`LastPage` | Go to the last page.|
|`NextPage` | Go to the next page.|

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/context-menu/contextmenu/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Contextmenu.cs" %}
{% include code-snippet/grid/context-menu/contextmenu/contextmenu.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/context-menu/contextmenu/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Contextmenu.cs" %}
{% include code-snippet/grid/context-menu/contextmenu/contextmenu.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Custom context menu items

The custom context menu items can be added by defining the [`ContextMenuItems`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ContextMenuItems) as a collection of **ContextMenuItemModel**. Actions for this customized items can be defined in the [`ContextMenuClick`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ContextMenuClick) event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/context-menu/customcontextmenu/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Customcontextmenu.cs" %}
{% include code-snippet/grid/context-menu/customcontextmenu/customcontextmenu.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/context-menu/customcontextmenu/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Customcontextmenu.cs" %}
{% include code-snippet/grid/context-menu/customcontextmenu/customcontextmenu.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You can hide or show an item in context menu for specific area inside of grid by defining the **Target** property.

## Show context menu on left click

By default, the context menu items will be shown in the Grid using the right mouse click action. Show the context menu items during the left mouse click action using the [Created](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Created) and context menu's `beforeOpen` events of the Grid.

Using the `onclick` eventlistener of Grid , you can get the clicked position values and send them to the `open` method of the context menu in the `onclick` event of the Grid. Also, we have prevented the default right click action to open the context menu items using the `Created` event of the Grid.

This is demonstrated in the following sample.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/context-menu/contextmenuclick/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Contextmenuclick.cs" %}
{% include code-snippet/grid/context-menu/contextmenuclick/contextmenuclick.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/context-menu/contextmenuclick/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Contextmenuclick.cs" %}
{% include code-snippet/grid/context-menu/contextmenuclick/contextmenuclick.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


## Enable or disable context menu items

It is possible to enable or disable the default and custom context menu items in the Grid component. This is achieved by using the `enableItems` method of the ContextMenu. To enable or disable menu items, set the `enable` parameter in the `enableItems` method to true, and vice versa.

In the following sample, the Copy item is enabled or disabled based on some condition (as per the needs of the application) in the [RowSelected](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_RowSelected) event of the Grid.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/context-menu/enablecontextmenu/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Contextmenu.cs" %}
{% include code-snippet/grid/context-menu/enablecontextmenu/enablecontextmenu.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/context-menu/enablecontextmenu/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Contextmenu.cs" %}
{% include code-snippet/grid/context-menu/enablecontextmenu/enablecontextmenu.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}