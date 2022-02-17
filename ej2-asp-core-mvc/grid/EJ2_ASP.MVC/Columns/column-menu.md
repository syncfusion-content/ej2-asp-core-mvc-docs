---
layout: post
title: Column Menu in ##Platform_Name## Grid Component
description: Learn here all about Column Menu in Syncfusion ##Platform_Name## Grid component and more.
platform: ej2-asp-core-mvc
control: Column Menu
publishingplatform: ##Platform_Name##
documentation: ug
---

# Column Menu

The column menu has options to integrate features like sorting, grouping, filtering, column chooser, and autofit. It will show a menu with the integrated feature when users click on multiple icon of the column. To enable column menu, you need to define the [`ShowColumnMenu`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ShowColumnMenu) property as true.

The default items are displayed in following table.

| Item | Description |
|-----|-----|
| `SortAscending` | Sort the current column in ascending order. |
| `SortDescending` | Sort the current column in descending order. |
| `Group` | Group the current column. |
| `Ungroup` | Ungroup the current column. |
| `AutoFit` | Auto fit the current column. |
| `AutoFitAll` | Auto fit all columns. |
| `ColumnChooser` | Choose the column visibility. |
| `Filter` | Show the filter option as given in `FilterSettings.Type` |

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/columnmenu/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Columnmenu.cs" %}
{% include code-snippet/grid/columns/columnmenu/columnmenu.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/columnmenu/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Columnmenu.cs" %}
{% include code-snippet/grid/columns/columnmenu/columnmenu.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You can disable column menu for a particular column by defining the [`ShowColumnMenu`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_ShowColumnMenu) property of [`Columns`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html) as false.
> You can customize the default items by defining the [`ColumnMenuItems`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ColumnMenuItems) with required items.

## Column menu Events

During the resizing action, the grid component triggers the below two events.

1. The [`ColumnMenuOpen`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ColumnMenuOpen) event triggers before the column menu opens.
2. The [`ColumnMenuClick`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ColumnMenuClick) event triggers when the user clicks the column menu of the grid.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/columnmenuevents/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Columnmenuevents.cs" %}
{% include code-snippet/grid/columns/columnmenuevents/columnmenuevents.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/columnmenuevents/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Columnmenuevents.cs" %}
{% include code-snippet/grid/columns/columnmenuevents/columnmenuevents.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Custom column menu item

Custom column menu items can be added by defining the [`ColumnMenuItems`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ColumnMenuItems) as collection of
the ColumnMenuItemModel.

Actions for this customized items can be defined in the [`ColumnMenuClick`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ColumnMenuClick) event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/customcolumnmenu/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Customcolumnmenu.cs" %}
{% include code-snippet/grid/columns/customcolumnmenu/customcolumnmenu.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/customcolumnmenu/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Customcolumnmenu.cs" %}
{% include code-snippet/grid/columns/customcolumnmenu/customcolumnmenu.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Customize menu items for particular columns

Sometimes, you have a scenario that to hide an item from column menu for particular columns. In that case, you need to define the **hide** as true in the arguments of [`ColumnMenuOpen`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ColumnMenuOpen) event.

The following sample, **Filter** item was hidden in column menu when opens for the **OrderID** column.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/customizecolumnmenu/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Customizecolumnmenu.cs" %}
{% include code-snippet/grid/columns/customizecolumnmenu/customizecolumnmenu.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/customizecolumnmenu/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Customizecolumnmenu.cs" %}
{% include code-snippet/grid/columns/customizecolumnmenu/customizecolumnmenu.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

