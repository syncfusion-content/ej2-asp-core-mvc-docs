---
layout: post
title: Column Spanning in ##Platform_Name## Tree Grid Component | Syncfusion
description: Learn here all about Column Spanning in Syncfusion ##Platform_Name## Tree Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Column Spanning
publishingplatform: ##Platform_Name##
documentation: ug
---

# Column Spanning in ##Platform_Name## Tree Grid Component

The column spanning feature in the Syncfusion<sup style="font-size:70%">&reg;</sup> TreeGrid allows merging adjacent cells horizontally, creating a visually appealing and informative layout. By defining the `colSpan` attribute in the [queryCellInfo](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_QueryCellInfo) event, cells can be easily spanned and the appearance of the TreeGrid can be customized.

In the following example, Employee **Davolio** is doing analysis from 9.00 AM to 10.00 AM, so those cells have been spanned.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-core/spanning/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Spanning.cs" %}
{% include code-snippet/tree-grid/columns-core/spanning/spanning.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Spanning.cs" %}
{% include code-snippet/tree-grid/columns-core/spanning/spanning.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Change the border color while column spanning

The border color for the spanned cells can be changed by using the [queryCellInfo](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_QueryCellInfo) event. This event triggers before the cell element is appended to the TreeGrid element, allowing customization of the cell appearance including border styles.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-core/spanning-event/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="spanning.cs" %}
{% include code-snippet/tree-grid/columns-core/spanning-event/spanevent.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="spanning.cs" %}
{% include code-snippet/tree-grid/columns-core/spanning-event/spanevent.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Limitations

Column spanning in the TreeGrid has the following limitations:

* The `updateCell` method does not support column spanning.
* Column spanning is not compatible with the following features:
    1. Virtual scrolling
    2. Infinite scrolling

> When using column spanning, ensure that the spanned cells do not interfere with TreeGrid operations such as sorting, filtering, or editing, as this may lead to unexpected behavior.

## Column spanning using enableColumnSpan property

The TreeGrid component introduces a simplified approach to horizontally merge cells using the `enableColumnSpan` property. 

When the `enableColumnSpan` property is enabled, the Tree Grid automatically merges cells with matching data across adjacent columns without requiring manual span configuration using the [queryCellInfo](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_QueryCellInfo) event. These merged cells are visually combined into a single cell, improving readability.

Here is an example of how to use the `enableColumnSpan` property to merge cells horizontally:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-core/spanning-property/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Spanning.cs" %}
{% include code-snippet/tree-grid/columns-core/spanning-property/spanproperty.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="spanning.cs" %}
{% include code-snippet/tree-grid/columns-core/spanning-property/spanproperty.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

N> You can also control spanning at the column level. To prevent merging for specific columns, set `enableColumnSpan` to **false** in the column definition.

### Limitations

* Virtualization
* Infinite Scrolling
* Row Drag and Drop
* Column Virtualization
* Detail Template
* Editing
* Export