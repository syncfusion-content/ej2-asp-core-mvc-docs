---
layout: post
title: Tool Bar in ##Platform_Name## Tree Grid Component
description: Learn here all about Tool Bar in Syncfusion ##Platform_Name## Tree Grid component and more.
platform: ej2-asp-core-mvc
control: Tool Bar
publishingplatform: ##Platform_Name##
documentation: ug
---


# ToolBar

The TreeGrid provides ToolBar support to handle treegrid actions. The [`Toolbar`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~Toolbar.html)
property accepts either the collection of built-in toolbar items and [`ItemModel`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.ToolbarItem_members.html) objects for custom toolbar items or
HTML element ID for toolbar template.

## Built-in toolbar items

Built-in toolbar items execute standard actions of the treegrid, and it can be added by defining the [`Toolbar`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~Toolbar.html)
as a collection of built-in items. It renders the button with icon and text.

The following table shows built-in toolbar items and its actions.

| Built-in Toolbar Items | Actions |
|------------------------|---------|
| ExpandAll | Expands all the rows.|
| CollapseAll | Collapses all the rows.|
| Add | Adds a new record.|
| Edit | Edits the selected record.|
| Update | Updates the edited record.|
| Delete | Deletes the selected record.|
| Cancel | Cancels the edit state.|
| Search | Searches the records by the given key.|
| Print | Prints the treegrid.|
| ExcelExport | Exports the treegrid to Excel.|
| PdfExport | Exports the treegrid to PDF.|
| WordExport | Exports the treegrid to Word.|

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/toolbar/default-toolbar/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default-toolbar.cs" %}
{% include code-snippet/tree-grid/toolbar/default-toolbar/default-toolbar.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/toolbar/default-toolbar/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default-toolbar.cs" %}
{% include code-snippet/tree-grid/toolbar/default-toolbar/default-toolbar.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> The [`Toolbar`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~Toolbar.html) has options to define both built-in and custom toolbar items.

## Custom toolbar items

Custom toolbar items can be added by defining the [`Toolbar`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~Toolbar.html) as a collection of
[`ItemModels`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.ToolbarItem_members.html).
Actions for this customized toolbar items are defined in the [`ToolbarClick`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~ToolbarClick.html) event.

By default, Custom toolbar items are in position **Left**. You can change the position by using the [`Align`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.ToolbarItem~Align.html) property. In the below sample, we have applied position **Right** for the **Quick Filter** toolbar item.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/toolbar/custom-toolbar/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-toolbar.cs" %}
{% include code-snippet/tree-grid/toolbar/custom-toolbar/custom-toolbar.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/toolbar/custom-toolbar/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-toolbar.cs" %}
{% include code-snippet/tree-grid/toolbar/custom-toolbar/custom-toolbar.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> The [`Toolbar`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~Toolbar.html) has options to define both built-in and custom toolbar items.
> If a toolbar item does not match the built-in items, it will be treated as a custom toolbar item.

## Built-in and custom items in toolbar

TreeGrid have an option to use both built-in and custom toolbar items at same time.

In the below example, **ExpandAll**, **CollapseAll** are built-in toolbar items and **Click** is custom toolbar item.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/toolbar/builtincustomitems/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Builtincustomitems.css" %}
{% include code-snippet/tree-grid/toolbar/builtincustomitems/builtincustomitems.css %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/toolbar/builtincustomitems/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Builtincustomitems.css" %}
{% include code-snippet/tree-grid/toolbar/builtincustomitems/builtincustomitems.css %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Enable/disable toolbar items

You can enable/disable toolbar items by using the **enableItems** method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/toolbar/toolbar-enable/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Toolbar-enable.cs" %}
{% include code-snippet/tree-grid/toolbar/toolbar-enable/toolbar-enable.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/toolbar/toolbar-enable/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Toolbar-enable.cs" %}
{% include code-snippet/tree-grid/toolbar/toolbar-enable/toolbar-enable.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You can refer to our [`ASP.NET MVC Tree Grid`](https://www.syncfusion.com/aspnet-mvc-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our [`ASP.NET MVC Tree Grid example`](https://ej2.syncfusion.com/aspnetmvc/TreeGrid/Overview#/material) to knows how to present and manipulate data.