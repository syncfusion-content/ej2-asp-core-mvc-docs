---
layout: post
title: Column Spanning in Syncfusion ##Platform_Name## Grid 
description: Learn here all about Column Spanning in Syncfusion ##Platform_Name## Grid of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Column Spanning
publishingplatform: ##Platform_Name##
documentation: ug
---

# Column Spanning in ASP.NET Core Grid

The column spanning feature in the Syncfusion Grid allows you to merge adjacent cells horizontally, creating a visually appealing and informative layout. By defining the `colSpan` attribute in the [queryCellInfo](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_QueryCellInfo) event, you can easily span cells and customize the appearance of the Grid.

In the following demo, Employee **Davolio** doing analysis from 9.00 AM to 10.00 AM, so that cells have spanned.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/columnspanning/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Columnspanning.cs" %}
{% include code-snippet/grid/columns/columnspanning/columnspanning.cs %}
{% endhighlight %}
{% endtabs %}

![Column Spanning](../images/column-spanning/column-spanning.gif)

## Change the border color while column spanning

You can change the border color for the spanned cells by the using [queryCellInfo](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_QueryCellInfo) event. This event triggers before the cell element is appended to the Grid element.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/column-spanning-color/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Columnspanning.cs" %}
{% include code-snippet/grid/columns/column-spanning-color/column-spanning-color.cs %}
{% endhighlight %}
{% endtabs %}

![Column Spanning BorderColor](../images/column-spanning/column-spanning-color.gif)

## Limitations

* The `updateCell` method does not support column spanning.
* Column spanning is not compatible with the following features:
    1. Virtual scrolling
    2. Infinite scrolling
    3. Grouping
    4. Autofill

## column spanning using enableColumnSpan property    

The Syncfusion ASP.NET Core Grid introduces a simplified approach to horizontally merge cells using the `EnableColumnSpan` property. 

When the `enableColumnSpan` property is enabled, the Grid automatically merges cells with matching data across adjacent columns without requiring manual span configuration using the [queryCellInfo](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_QueryCellInfo) event. These merged cells are visually combined into a single cell, improving readability.

Here is an example of how to use the `enableColumnSpan` property to merge cells horizontally:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/column-spanning-using-property/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Columnspanning.cs" %}
{% include code-snippet/grid/columns/column-spanning-using-property/columnspanning.cs %}
{% endhighlight %}
{% endtabs %}

![Column Spanning Using Property](../images/column-spanning/column-spanning-using-property.png)

> You can also control spanning at the column level. To prevent merging for specific columns, set `enableColumnSpan` to **false** in the column definition.

### Limitation

* Virtualization
* Infinite Scrolling
* Lazy Load Grouping
* Row Drag and Drop
* Column Virtualization
* Detail Template
* Editing
* Export
* Foreign Key
* Hierarchy Grid   