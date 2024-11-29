---
layout: post
title: Context Menu in Syncfusion ##Platform_Name## Grid Control
description: Learn here all about Context Menu in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Context Menu
publishingplatform: ##Platform_Name##
documentation: ug
---

# Context menu in ASP.NET Core Grid component

The Syncfusion ASP.NET Core Grid component comes equipped with a context menu feature, which is triggered when a user right-clicks anywhere within the grid. This feature serves to enrich the user experience by offering immediate access to a variety of supplementary actions and operations that can be executed on the data displayed in the grid.

To activate the context menu within the grid, you have an option to configure the grid's [contextMenuItems](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ContextMenuItems) property. You can set this property to either include the default context menu items or define your own custom context menu items, tailoring the menu options to suit your specific needs. This customization allows you to enhance the grid's functionality by providing context-sensitive actions for interacting with your data.
   
The context menu is triggered when you right-click on different areas of the grid, including:
* Header: When you right-click on the grid's header section.
* Content: When you right-click on the grid's main content area.
* Pager: When you right-click on the pager section.

The default context menu items in the header area of the grid are as follows:

| Items            | Description                                                  |
| ---------------- | ------------------------------------------------------------ |
| `AutoFit`        | Automatically adjust the column width to fit the content.    |
| `AutoFitAll`     | Automatically adjust all column widths to fit their content. |
| `Group`          | Group the data based on the current column.                  |
| `Ungroup`        | Remove grouping for the current column.                      |
| `SortAscending`  | Sort the current column in ascending order.                  |
| `SortDescending` | Sort the current column in descending order.                 |

The default context menu items in the content area of the grid are as follows:

| Items         | Description                                                         |
| ------------- | ------------------------------------------------------------------- |
| `Edit`        | Edit the currently selected record in the grid.                     |
| `Delete`      | Delete the currently selected record.                               |
| `Save`        | Save the changes made to the edited record.                         |
| `Cancel`      | Cancel the edit state and revert changes made to the edited record. |
| `Copy`        | Copy the selected records to the clipboard.                         |
| `PdfExport`   | Export the grid data as a PDF document.                             |
| `ExcelExport` | Export the grid data as an Excel document.                          |
| `CsvExport`   | Export the grid data as a CSV document.                             |

The default context menu items in the pager area of the grid are as follows:

| Items       | Description                                |
| ----------- | ------------------------------------------ |
| `FirstPage` | Navigate to the first page of the grid.    |
| `PrevPage`  | Navigate to the previous page of the grid. |
| `LastPage`  | Navigate to the last page of the grid.     |
| `NextPage`  | Navigate to the next page of the grid.     |

The following example demonstrates how to enable context menu feature in the grid.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/context-menu/contextmenu/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="contextmenu.cs" %}
{% include code-snippet/grid/context-menu/contextmenu/contextmenu.cs %}
{% endhighlight %}
{% endtabs %}

![Context menu](images/context-menu/custom-menu.png)

## Custom context menu items

The Syncfusion ASP.NET Core Grid empowers you to enhance your user experience by incorporating custom context menu items into the default context menu. These customized options enable you to tailor the context menu to meet the unique requirements of your application.

To incorporate custom context menu items in the Syncfusion ASP.NET Core Grid, you can achieve this by specifying the [contextMenuItems](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ContextMenuItems) property as a collection of `contextMenuItemModel`. This allows you to define and customize the appearance and behavior of these additional context menu items according to your requirements.

Furthermore, you can assign actions to these custom items by utilizing the [contextMenuClick](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ContextMenuClick) event. This event provides you with the means to handle user interactions with the custom context menu items, enabling you to execute specific actions or operations when these items are clicked. 

The following example demonstrates how to add custom context menu items in the Grid component.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/context-menu/customcontextmenu/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Html.cs" %}
{% include code-snippet/grid/context-menu/customcontextmenu/customcontextmenu.cs %}
{% endhighlight %}
{% endtabs %}

![Custom context menu items](images/context-menu/custommenu-custom.png)

## Show context menu on left click

The Syncfusion ASP.NET Core Grid provides the ability to show the context menu items on a left mouse click instead of the default right mouse click action. 

This can be achieved by using the [created](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Created) event and the context menu's `beforeOpen` event of the Grid.

By using the `onclick` event listener of the Grid, you can obtain the clicked position values. The obtained positions are then sent to the `open` method of the context menu within the `onclick` event of the Grid. Additionally, the default action of right-clicking to open the context menu items items is prevented by utilizing the `created` event of the Grid.

The following example demonstrates how to show context menu on left click using `created` event.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/context-menu/contextmenuclick/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="contextmenuclick.cs" %}
{% include code-snippet/grid/context-menu/contextmenuclick/contextmenuclick.cs %}
{% endhighlight %}
{% endtabs %}

> You can hide or show an item in context menu for specific area inside of grid by defining the `target` property.

## Enable or disable context menu items

With the Syncfusion ASP.NET Core Grid, you have the ability to manage the activation or deactivation of both default and custom context menu items. This feature provides you with the flexibility to tailor the behavior of context menu items to suit specific conditions or individual interactions within your application.

This can be achieved using the `enableItems` method of the context menu. By setting the enable parameter in the enableItems method to **true**, you can enable context menu items, and by setting it to **false**, you can disable them. Based on your specific condition or requirements, you can enable or disable the context menu item using the `enableItems` method.

In the following example, the [EJ2 Toggle Switch Button](https://ej2.syncfusion.com/aspnetcore/documentation/switch/getting-started) component is added to enable and disable the context menu items using `enableItems` method. When the switch is toggled, the [change](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.Switch.html#Syncfusion_EJ2_Buttons_Switch_Change) event is triggered, and the **Copy** items is updated accordingly. 

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/context-menu/enablecontextmenu/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="enablecontextmenu.cs" %}
{% include code-snippet/grid/context-menu/enablecontextmenu/enablecontextmenu.cs %}
{% endhighlight %}
{% endtabs %}

![Enable or disable context menu items](images/context-menu/custom-menu-enable.png)

## Show or hide context menu items

The Syncfusion ASP.NET Core Grid provides the flexibility to show or hide both default and custom context menu items. This feature allows you to customize the context menu items based on various conditions or individuals interactions.

This can be achieved using the `showItems` and `hideItems` methods of the context menu by specifying the item you want to show or hide as an argument. 

In the following example, the [EJ2 Toggle Switch Button](https://ej2.syncfusion.com/aspnetcore/documentation/switch/getting-started) component is added to show or hide the context menu items using `showItems` and `hideItems` methods. When the switch is toggled, the [change](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.Switch.html#Syncfusion_EJ2_Buttons_Switch_Change) event is triggered, and the **Edit** and **Delete** items are updated accordingly.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/context-menu/contextmenu-show-hide/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="contextmenu.cs" %}
{% include code-snippet/grid/context-menu/contextmenu-show-hide/contextmenu.cs %}
{% endhighlight %}
{% endtabs %}

![Show or hide context menu items](images/context-menu/context-menu-hide.gif)