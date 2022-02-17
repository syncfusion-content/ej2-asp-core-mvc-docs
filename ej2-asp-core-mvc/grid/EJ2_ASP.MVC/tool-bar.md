---
layout: post
title: Tool Bar in ##Platform_Name## Grid Component
description: Learn here all about Tool Bar in Syncfusion ##Platform_Name## Grid component and more.
platform: ej2-asp-core-mvc
control: Tool Bar
publishingplatform: ##Platform_Name##
documentation: ug
---


# ToolBar

The Grid provides ToolBar support to handle grid actions. The [`Toolbar`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Toolbar)
property accepts either the collection of built-in toolbar items and **ItemModel** objects for custom toolbar items or HTML element ID for toolbar template.

## Built-in toolbar items

Built-in toolbar items execute standard actions of the grid, and it can be added by defining the [`Toolbar`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Toolbar)
as a collection of built-in items. It renders the button with icon and text.

The following table shows built-in toolbar items and its actions.

| Built-in Toolbar Items | Actions |
|------------------------|---------|
| Add | Adds a new record.|
| Edit | Edits the selected record.|
| Update | Updates the edited record.|
| Delete | Deletes the selected record.|
| Cancel | Cancels the edit state.|
| Search | Searches the records by the given key.|
| Print | Prints the grid.|
| ExcelExport | Exports the grid to Excel.|
| PdfExport | Exports the grid to PDF.|
| WordExport | Exports the grid to Word.|

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/toolbar/toolbar/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Toolbar.cs" %}
{% include code-snippet/grid/toolbar/toolbar/toolbar.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/toolbar/toolbar/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Toolbar.cs" %}
{% include code-snippet/grid/toolbar/toolbar/toolbar.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> The [`Toolbar`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Toolbar) has options to define both built-in and custom toolbar items.

## Custom toolbar items

Custom toolbar items can be added by defining the [`Toolbar`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Toolbar) as a collection of
**ItemModels**.
Actions for this customized toolbar items are defined in the [`ToolbarClick`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ToolbarClick) event.

By default, Custom toolbar items are in position **Left**. You can change the position by using the **align** property. In the below sample, we have applied position **Right** for the **Collapse All** toolbar item.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/toolbar/custom-toolbar-item/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-toolbar-item.cs" %}
{% include code-snippet/grid/toolbar/custom-toolbar-item/custom-toolbar-item.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/toolbar/custom-toolbar-item/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-toolbar-item.cs" %}
{% include code-snippet/grid/toolbar/custom-toolbar-item/custom-toolbar-item.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> The [`Toolbar`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Toolbar) has options to define both built-in and custom toolbar items.
> If a toolbar item does not match the built-in items, it will be treated as a custom toolbar item.

## Built-in and custom items in toolbar

Grid have an option to use both built-in and custom toolbar items at same time.

In the below example, **Add**, **Edit**, **Delete**, **Update**, **Cancel** are built-in toolbar items and **Click** is custom toolbar item.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/toolbar/builtin-custom-items/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Builtin-custom-items.cs" %}
{% include code-snippet/grid/toolbar/builtin-custom-items/builtin-custom-items.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/toolbar/builtin-custom-items/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Builtin-custom-items.cs" %}
{% include code-snippet/grid/toolbar/builtin-custom-items/builtin-custom-items.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Enable/disable toolbar items

You can enable/disable toolbar items by using the **enableItems** method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/toolbar/enable-disable/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Enable-disable.cs" %}
{% include code-snippet/grid/toolbar/enable-disable/enable-disable.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/toolbar/enable-disable/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Enable-disable.cs" %}
{% include code-snippet/grid/toolbar/enable-disable/enable-disable.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


