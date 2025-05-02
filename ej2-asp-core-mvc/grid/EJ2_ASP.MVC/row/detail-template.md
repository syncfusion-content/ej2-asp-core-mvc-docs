---
layout: post
title: Detail Template in Syncfusion ##Platform_Name## Grid Component
description: Learn here all about Detail Template in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Detail Template
publishingplatform: ##Platform_Name##
documentation: ug
---

# Detail template in ASP.NET MVC Grid component 

The detail template in the Grid component allows you to display additional information about a specific row in the grid by expanding or collapsing detail content. This feature is useful when you need to show additional data or custom content that is specific to each row in the grid. You can use the [DetailTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DetailTemplate) property to define an HTML template for the detail row. This template can include any HTML element or ASP.NET MVC component that you want to display as detail content.

Here's an example of using the `DetailTemplate` property in the grid component:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/row/detail-temp/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Detail-template.cs" %}
{% include code-snippet/grid/row/detail-temp/detail-temp.cs %}
{% endhighlight %}
{% endtabs %}

![Detail template](../images/row/detail-template.png)

## Rendering custom component

The Grid component provides a powerful feature that allows you to render custom components inside the detail row. This feature is helpful when you need to add additional information or functionality for a specific row in the grid.

To render a custom component inside the detail row, you need to define a template using the [DetailTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DetailTemplate) property and handle the [DetailDataBound](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DetailDataBound) event.This template can include any HTML element or ASP.NET MVC component that you want to display as the detail content.

The `DetailDataBound` event is an event that is triggered after a detail row is bound to data. This event provides an object of type `DetailDataBoundEventArgs` as a parameter.

For example, to render grid inside the detail row, place an HTML div element as the `DetailTemplate` and render the DIV element as grid component in the `DetailDataBound` event.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/row/custom-component/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-component.cs" %}
{% include code-snippet/grid/row/custom-component/custom-component.cs %}
{% endhighlight %}
{% endtabs %}

![Custom component in detail template](../images/row/custom-component.png)

## Expand by external button

The Grid provides a feature that allows users to expand the detail row of a grid using an external button. By default, detail rows render in a collapsed state, but this feature enables users to view additional details associated with a particular row. 

To achieve expanding the detail row of a grid using an external button, you need to invoke the `expand` method provided by the **DetailRowModule** object of the Syncfusion<sup style="font-size:70%">&reg;</sup> Grid library. This method will expand the detail row of a specific grid row.

Here is an example of how to use the `expand` method to expand a detail row:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/row/expand-external/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Expand-external.cs" %}
{% include code-snippet/grid/row/expand-external/expand-external.cs %}
{% endhighlight %}
{% endtabs %}

![Expand detail template](../images/row/detail-template-expand.gif)

## Customize detail template icon

The detail template icon in the Syncfusion<sup style="font-size:70%">&reg;</sup> Grid is used to expand or collapse the detail content of a row. By default, the icon represents a right arrow for the collapsed state and a down arrow for the expanded state. If you want to customize this icon, you can achieve it by overriding the following CSS styles:

```css

.e-grid .e-icon-grightarrow::before {
    content: "\e655";
}
.e-grid .e-icon-gdownarrow::before {
    content: "\e304";
}

```

Here is an example of how to customize the detail template icon:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/row/expand-icon/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Icon.cs" %}
{% include code-snippet/grid/row/expand-icon/icon.cs %}
{% endhighlight %}
{% endtabs %}

![Custom icon in detail template](../images/row/expand-icon.png)

## Limitations

Detail template is not supported with the following features:

* Frozen rows and columns
* Immutable mode
* Infinite scrolling
* Virtual scrolling
* Print
* Row template
* Row spanning
* Column spanning
* Lazy load grouping
* State persistence

