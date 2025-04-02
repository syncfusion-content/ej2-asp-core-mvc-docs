---
layout: post
title: Column Menu in Syncfusion ##Platform_Name## Grid Component
description: Learn here all about Column Menu in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Column Menu
publishingplatform: ##Platform_Name##
documentation: ug
---

# Column menu in ASP.NET Core Grid component

The column menu in the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Grid component provides options to enable features such as sorting, grouping, filtering, column chooser, and autofit. When users click on the column header's menu icon, a menu will be displayed with these integrated features. To enable the column menu, you need to set the [showColumnMenu](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ShowColumnMenu) property to **true** in the Grid configuration.

To use the column menu, inject the **ColumnMenu** in the **provide** section.

The default column menu items are displayed in following table.

| Item               | Description                                                                                                                              |
| ------------------ | ---------------------------------------------------------------------------------------------------------------------------------------- |
| **SortAscending**  | Sort the current column in ascending order.                                                                                              |
| **SortDescending** | Sort the current column in descending order.                                                                                             |
| **Group**          | Group the current column.                                                                                                                |
| **Ungroup**        | Ungroup the current column.                                                                                                              |
| **AutoFit**        | Autofit the current column.                                                                                                              |
| **AutoFitAll**     | Autofit all columns.                                                                                                                     |
| **ColumnChooser**  | Choose the column visibility.                                                                                                            |
| **Filter**         | Show the filter option as given in [filterSettings.type](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridFilterSettings.html#Syncfusion_EJ2_Grids_GridFilterSettings_Type) |

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/columnmenu/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Columnmenu.cs" %}
{% include code-snippet/grid/columns/columnmenu/columnmenu.cs %}
{% endhighlight %}
{% endtabs %}

![Column menu](../images/column-menu/Column-menu.png)

> You can disable column menu for a particular column by defining the `columns.showColumnMenu` as **false**.

> You can customize the default items by defining the [columnMenuItems](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ColumnMenuItems) with required items.

## Prevent column menu for particular column

The Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Grid component provides the ability to prevent the appearance of the column menu for specific columns. This feature is useful when you want to restrict certain columns from being customizable through the column menu.

To prevent the column menu for a particular column, you can set the [showColumnMenu](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ShowColumnMenu) property to **false** for that specific column configuration. This will disable the column menu options specifically for the designated column, while other columns will have the column menu enabled.

The following example demonstrates how to prevent the column menu for a specific column. In this example, the column menu is disabled for the **OrderID** column by setting the `showColumnMenu` property to **false**.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/prevent-column-menu/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Columnmenu.cs" %}
{% include code-snippet/grid/columns/prevent-column-menu/columnmenu.cs %}
{% endhighlight %}
{% endtabs %}

![Prevent column menu](../images/column-menu/prevent-column-menu.png)

## Add custom column menu item

The custom column menu item feature allows you to add additional menu items to the column menu in the Syncfusion<sup style="font-size:70%">&reg;</sup> Grid. These custom menu items can be defined using the [columnMenuItems](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ColumnMenuItems) property, which accepts a collection of `columnMenuItemModel` objects. You can define the actions for these custom items in the [columnMenuClick](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ColumnMenuClick) event.

Consider the following example, which demonstrates how to add a custom column menu item to clear the sorting of the Grid:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/customcolumnmenu/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Columnmenu.cs" %}
{% include code-snippet/grid/columns/customcolumnmenu/columnmenu.cs %}
{% endhighlight %}
{% endtabs %}

![custom menu](../images/column-menu/Column-menu-custom.gif)

## Customize menu items for particular columns

Sometimes, you have a scenario that to hide an item from column menu for particular columns. In that case, you need to define the `columnMenuOpenEventArgs.hide` as **true** in the [columnMenuOpen](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ColumnMenuOpen) event.

The following sample, **Filter** item was hidden in column menu when opens for the **OrderID** column.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/customizecolumnmenu/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Columnmenu.cs" %}
{% include code-snippet/grid/columns/customizecolumnmenu/columnmenu.cs %}
{% endhighlight %}
{% endtabs %}

![Customize menu items for particular columns](../images/column-menu/Column-menu-particular.png)

## Render nested column menu

The nested column menu feature provides an extended menu option in the grid column headers, allows you to access additional actions and options related to the columns.

To enable the nested column menu feature, you need to define the [columnMenuItems](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ColumnMenuItems) property in your component. The `columnMenuItems` property is an array that contains the items for the column menu. Each item can be a string representing a built-in menu item or an object defining a custom menu item.

Here is an example of how to configure the `columnMenuItems` property to include a nested menu:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/columnmenu-stacked/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Columnmenu.cs" %}
{% include code-snippet/grid/columns/columnmenu-stacked/columnmenu.cs %}
{% endhighlight %}
{% endtabs %}

![Render nested column menu](../images/column-menu/Column-menu-stacked.png)

## Customize the icon of column menu

To customize the column menu icon, you need to override the default grid class **.e-icons.e-columnmenu** with a custom CSS property called **content**. By specifying a Unicode character or an icon font's CSS class, you can change the icon displayed in the column menu.

To customize the column menu icon, follow the below step:

1.Add the necessary CSS code to override the default grid class:

```css
  .e-grid .e-columnheader .e-icons.e-columnmenu::before {
              content: "\e799";
      }
```

Here is an example that demonstrates how to customize the column menu icon in the Syncfusion<sup style="font-size:70%">&reg;</sup> Grid:


{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/custom-column-menu-icon/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Columnmenu.cs" %}
{% include code-snippet/grid/columns/custom-column-menu-icon/columnmenu.cs %}
{% endhighlight %}
{% endtabs %}

![Customize the icon of column menu](../images/column-menu/column-menu-icon.png)

## Column menu events

The column menu in Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Grid provides a set of events that allow customization of behavior and performing actions when the column menu is opened or clicked. The below events are helpful for adding additional functionality or implementing specific actions based on user interactions with the column menu.

1.The [columnMenuOpen](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ColumnMenuOpen) event triggers before the column menu opens.

2.The [columnMenuClick](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ColumnMenuClick) event triggers when the user clicks the column menu of the grid.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/columnmenuevents/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Columnmenu.cs" %}
{% include code-snippet/grid/columns/columnmenuevents/columnmenu.cs %}
{% endhighlight %}
{% endtabs %}

![Column menu events](../images/column-menu/column-menu-events.gif)