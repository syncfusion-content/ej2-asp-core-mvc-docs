---
layout: post
title: Context Menu in ##Platform_Name## Spreadsheet Component
description: Learn here all about Context Menu in Syncfusion ##Platform_Name## Spreadsheet component and more.
platform: ej2-asp-core-mvc
control: Context Menu
publishingplatform: ##Platform_Name##
documentation: ug
---


# Context Menu

Context Menu is used to improve user interaction with Spreadsheet using the popup menu. This will open when right-clicking on Cell/Column Header/Row Header/ Pager in the Spreadsheet. You can use [`enableContextMenu`](../api/spreadsheet/#enableContextMenu) property to enable/disable context menu.

> The default value for the `enableContextMenu` property is `true`.

## Context Menu Items in Row Cell

Please find the table below for default context menu items and their actions.

| Context Menu items | Action |
|-------|---------|
| [`Cut`](../api/spreadsheet/#cut) | Cut the selected cells data to the clipboard, you can select a cell where you want to move the data. |
| [`Copy`](../api/spreadsheet/#copy) | Copy the selected cells data to the clipboard, so that you can paste it to somewhere else. |
| [`Paste`](../api/spreadsheet/#paste) | Paste the data from clipboard to spreadsheet. |
| [`Paste Special`](../api/spreadsheet/#paste) | `Values` - Paste the data values from clipboard to spreadsheet.  `Formats` - Paste the data formats from clipboard to spreadsheet. |
| [`Filter`](../api/spreadsheet/#filter) | Perform filtering to the selected cells based on an active cell’s value. |
| [`Sort`](../api/spreadsheet/#sort) | Perform sorting to the selected range of cells by ascending or descending. |
| [`Hyperlink`](../api/spreadsheet/#hyperlink) | Create a link in the spreadsheet to navigate to web links or cell reference within the sheet or other sheets in the Spreadsheet. |

## Context Menu Items in Row Header / Column Header

Please find the table below for default context menu items and their actions.

| Context Menu items | Action |
|-------|---------|
| [`Cut`](../api/spreadsheet/#cut) | Cut the selected row/column header data to the clipboard, you can select a cell where you want to move the data. |
| [`Copy`](../api/spreadsheet/#copy) | Copy the selected row/column header data to the clipboard, so that you can paste it to somewhere else. |
| [`Paste`](../api/spreadsheet/#paste) | Paste the data from clipboard to spreadsheet. |
| [`Paste Special`](../api/spreadsheet/#paste) | `Values` - Paste the data values from clipboard to spreadsheet. `Formats` - Paste the data formats from clipboard to spreadsheet. |
| [`Insert Columns`](../api/spreadsheet/#insertRow) | Insert new rows or columns into the worksheet. |
| [`Delete Columns`](../api/spreadsheet/#deleteRow) | Delete existing rows or columns from the worksheet. |
| [`Hide Columns`](../api/spreadsheet/#insert) | Hide the rows and columns. |
| [`UnHide Columns`](../api/spreadsheet/#delete) | Show the hidden rows and columns. |

## Context Menu Items in Pager

Please find the table below for default context menu items and their actions.

| Context Menu items | Action |
|-------|---------|
| `Insert` | Insert a new worksheet in front of an existing worksheet in the spreadsheet. |
| `Delete` | Delete the selected worksheet from the spreadsheet. |
| `Rename` | Rename the selected worksheet. |
| [`Protect Sheet`](../api/spreadsheet/#protectSheet) | Prevent unwanted changes from others by limiting their ability to edit. |
| [`Hide`](../api/spreadsheet/#hide) |Hide the selected worksheet. |

## Context Menu Customization

You can perform the following context menu customization options in the spreadsheet

* Add Context Menu Items
* Remove Context Menu Items
* Enable/Disable Context Menu Items

### Add Context Menu Items

You can add the custom items in context menu using the [`addContextMenuItems`](../api/spreadsheet/#addContextMenuItems) in `contextmenuBeforeOpen` event

In this demo, Custom Item is added after the Paste item in the context menu.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/add-context-menu/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="AddContextMenu.cs" %}
{% include code-snippet/spreadsheet/add-context-menu/addContextMenu.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/add-context-menu/razor %}
{% endhighlight %}
{% highlight c# tabtitle="AddContextMenu.cs" %}
{% include code-snippet/spreadsheet/add-context-menu/addContextMenu.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Remove Context Menu Items

You can remove the items in context menu using the [`removeContextMenuItems`](../api/spreadsheet/#removeContextMenuItems) in `contextmenuBeforeOpen` event

In this demo, Insert Column item has been removed from the row/column header context menu.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/remove-context-menu/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="RemoveContextMenu.cs" %}
{% include code-snippet/spreadsheet/remove-context-menu/removeContextMenu.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/remove-context-menu/razor %}
{% endhighlight %}
{% highlight c# tabtitle="RemoveContextMenu.cs" %}
{% include code-snippet/spreadsheet/remove-context-menu/removeContextMenu.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Enable/Disable Context Menu Items

You can enable/disable the items in context menu using the [`enableContextMenuItems`](../api/spreadsheet/#enableContextMenuItems) in `contextmenuBeforeOpen` event

In this demo, Rename item is disabled in the pager context menu.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/enable-context-menu/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="EnableContextMenu.cs" %}
{% include code-snippet/spreadsheet/enable-context-menu/enableContextMenu.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/enable-context-menu/razor %}
{% endhighlight %}
{% highlight c# tabtitle="EnableContextMenu.cs" %}
{% include code-snippet/spreadsheet/enable-context-menu/enableContextMenu.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [Worksheet](./worksheet)
* [Rows and columns](./rows-and-columns)
