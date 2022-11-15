---
layout: post
title: Toolbar Items in Syncfusion ##Platform_Name## Grid Component
description: Learn here all about Toolbar Items in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Toolbar Items
publishingplatform: ##Platform_Name##
documentation: ug
---


# Toolbar Items in ASP.NET CORE Grid Component

## Built-in toolbar items

Built-in toolbar items execute standard actions of the grid, and it can be added by defining the [`toolbar`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Toolbar) as a collection of built-in items. It renders the button with icon and text.

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
| ColumnChooser | Choose the column’s visibility.|

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



> * The [`toolbar`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Toolbar) has options to define both built-in and custom toolbar items.

### Show only icons in built-in toolbar items

By default, the built-in toolbar items render as buttons with an icon and text. It is possible to hide the text and show only the icon using the following CSS style.

```css
.e-toolbar .e-tbar-btn-text, .e-toolbar .e-toolbar-items .e-toolbar-item .e-tbar-btn-text {
    display: none;
}
```

This is demonstrated in the following sample:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/toolbar/toolbaricon/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Toolbar-icon.cs" %}
{% include code-snippet/grid/toolbar/toolbaricon/toolbaricon.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/toolbar/toolbaricon/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Toolbar-icon.cs" %}
{% include code-snippet/grid/toolbar/toolbaricon/toolbaricon.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


## Custom toolbar items

Custom toolbar items can be added by defining the [`toolbar`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Toolbar) as a collection of **ItemModel**.
Actions for this customized toolbar items are defined in the [`toolbarClick`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ToolbarClick) event.

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



> * The [`toolbar`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Toolbar) has options to define both built-in and custom toolbar items.
> * If a toolbar item does not match the built-in items, it will be treated as a custom toolbar item.

## Both built-in and custom items in toolbar

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

## Custom toolbar component in a specific position

By default, Custom toolbar items are in the Left position. You can change the position by using the [align](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.ToolbarItem.html#Syncfusion_EJ2_Navigations_ToolbarItem_Align) property. In the following sample, we have applied the Right position for the Collapse All toolbar item, Left for the Expand All toolbar item, and Center for the Search toolbar item.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/toolbar/custom-toolbar-position/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-toolbar-position.cs" %}
{% include code-snippet/grid/toolbar/custom-toolbar-position/custom-toolbar-position.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/toolbar/custom-toolbar-position/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-toolbar-position.cs" %}
{% include code-snippet/grid/toolbar/custom-toolbar-position/custom-toolbar-position.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}