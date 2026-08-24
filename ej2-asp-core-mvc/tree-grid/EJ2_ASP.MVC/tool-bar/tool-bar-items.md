---
layout: post
title: ##Platform_Name## TreeGrid Toolbar Items | Syncfusion
description: Learn about configuring built-in and custom toolbar items in the ##Platform_Name## TreeGrid, including actions, alignment, and best practices.
platform: ej2-asp-core-mvc
control: Toolbar Items
publishingplatform: ##Platform_Name##
documentation: ug
---


# Toolbar Items in ##Platform_Name## TreeGrid

## Built-in toolbar items

Built-in toolbar items execute standard actions of the treegrid, and it can be added by defining the [`Toolbar`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_Toolbar) as a collection of built-in items. It renders the button with icon and text.

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
| ColumnChooser | Opens a dialog to select column visibility.|
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



N> The [`Toolbar`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_Toolbar) has options to define both built-in and custom toolbar items.

## Custom toolbar items

Custom toolbar items can be added by defining the [`Toolbar`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_Toolbar) as a collection of
[`ItemModels`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Toolbar.html#Syncfusion_EJ2_Navigations_Toolbar_Items).
Actions for this customized toolbar items are defined in the [`ToolbarClick`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_ToolbarClick) event.

By default, Custom toolbar items are in position **Left**. You can change the position by using the [`Align`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.ToolbarItem.html#Syncfusion_EJ2_Navigations_ToolbarItem_Align) property. In the below sample, we have applied position **Right** for the **Quick Filter** toolbar item.

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



N> The [`Toolbar`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_Toolbar) has options to define both built-in and custom toolbar items.
<br/> If a toolbar item does not match the built-in items, it will be treated as a custom toolbar item.

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



N> You can refer to our [`ASP.NET MVC Tree Grid`](https://www.syncfusion.com/aspnet-mvc-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our [`ASP.NET MVC Tree Grid example`](https://ej2.syncfusion.com/aspnetmvc/treegrid/overview#/fluent2) to knows how to present and manipulate data.