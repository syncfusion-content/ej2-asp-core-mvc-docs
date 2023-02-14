---
layout: post
title: Column Menu in ##Platform_Name## Tree Grid Component | Syncfusion
description: Learn here all about Column Menu in Syncfusion ##Platform_Name## Tree Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Column Menu
publishingplatform: ##Platform_Name##
documentation: ug
---

# Column Menu in ##Platform_Name## Tree Grid Component

The column menu has options to integrate features like sorting, filtering, and autofit. It will show a menu with the integrated feature when users click on multiple icon of the column. To enable column menu, you need to define the [`ShowColumnMenu`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~ShowColumnMenu.html) property as true.

By default, column menu is enabled for all columns and you can disable column menu for a particular column by defining the [`ShowColumnMenu`] as false in [`Columns`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGrid.TreeGridColumn.html#Syncfusion_EJ2_TreeGrid_TreeGridColumn_Columns) property.

The default items are displayed in following table.

| Item | Description |
|-----|-----|
| `SortAscending` | Sort the current column in ascending order. |
| `SortDescending` | Sort the current column in descending order. |
| `AutoFit` | Auto fit the current column. |
| `AutoFitAll` | Auto fit all columns. |
| `Filter` | Show the filter option as given in `filterSettings.type` |

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="Columnmenu.cs" %}
{% include code-snippet/tree-grid/columns-mvc/columnmenu/columnmenu.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-mvc/columnmenu/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Columnmenu.cs" %}
{% include code-snippet/tree-grid/columns-mvc/columnmenu/columnmenu.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Custom column menu item

The custom column menu items can be added to the column menu by defining the [`ColumnMenuItems`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_ColumnMenuItems) as a collection of the [`MenuItemModel`](https://ej2.syncfusion.com/documentation/api/context-menu/menuItemModel/).

The action for custom column menu items can be performed using [`ColumnMenuClick`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_ColumnMenuClick) event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="Columnmenu.cs" %}
{% include code-snippet/tree-grid/columns-mvc/customcolumnmenu/customcolumnmenu.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-mvc/customcolumnmenu/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CustomColumnmenu.cs" %}
{% include code-snippet/tree-grid/columns-mvc/customcolumnmenu/customcolumnmenu.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Customize menu items for particular columns

It is possible to customize specific items from the column menu for particular [`Columns`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGrid.TreeGridColumn.html#Syncfusion_EJ2_TreeGrid_TreeGridColumn_Columns) using [`ColumnMenuOpen`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_ColumnMenuOpen) event. `ColumnMenuOpen` event can be utilized to determine which items to customize in column menu.

The following example shows how to hide the built-in **Filter** menu item when the column menu is opened for the **taskName** column, while allowing it to remain visible for all other columns.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="Columnmenu.cs" %}
{% include code-snippet/tree-grid/columns-mvc/customizecolumnmenu/customizecolumnmenu.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-mvc/customizecolumnmenu/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CustomizeColumnmenu.cs" %}
{% include code-snippet/tree-grid/columns-mvc/customizecolumnmenu/customizecolumnmenu.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

N> You can refer to our [`ASP.NET MVC Tree Grid`](https://www.syncfusion.com/aspnet-mvc-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our [`ASP.NET MVC Tree Grid example`](https://ej2.syncfusion.com/aspnetmvc/TreeGrid/Overview#/material) to knows how to present and manipulate data.
