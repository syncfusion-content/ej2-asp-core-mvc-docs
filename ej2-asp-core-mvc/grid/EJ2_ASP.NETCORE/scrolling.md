---
layout: post
title: Scrolling in Syncfusion ASP.NET Core Grid Component
description: Learn here all about Scrolling in Syncfusion ASP.NET Core Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Scrolling
publishingplatform: ##Platform_Name##
documentation: ug
---


# Scrolling in ASP.NET Core Grid Component

 The scrollbar will be displayed in the grid when content exceeds the element [`width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Width) or [`height`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Height). The vertical and horizontal scrollbars will be displayed based on the following criteria:

* The vertical scrollbar appears when the total height of rows present in the grid exceeds its element height.
* The horizontal scrollbar appears when the sum of columns width exceeds the grid element width.
* The [`height`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Height) and [`width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Width) are used to set the grid height and width, respectively.

N> The default value for [`height`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Height) and [`width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Width) is `auto`.

## Set width and height

To specify the [`width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Width) and [`height`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Height) of the scroller in the pixel, set the pixel value to a number.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/scrolling/width-height/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Width-height.cs" %}
{% include code-snippet/grid/scrolling/width-height/width-height.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/scrolling/width-height/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Width-height.cs" %}
{% include code-snippet/grid/scrolling/width-height/width-height.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Responsive with parent container

Specify the [`width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Width) and [`height`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Height) as `100%` to make the grid element fill its parent container.
Setting the [`height`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Height) to `100%` requires the grid parent element to have explicit height.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/scrolling/responsive-parent/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Responsive-parent.cs" %}
{% include code-snippet/grid/scrolling/responsive-parent/responsive-parent.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/scrolling/responsive-parent/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Responsive-parent.cs" %}
{% include code-snippet/grid/scrolling/responsive-parent/responsive-parent.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Sticky Header

You can make the Grid column headers remain fixed while scrolling by using the [`enableStickyHeader`](https://ej2.syncfusion.com/javascript/documentation/api/grid/#enablestickyheader) property.

In the below demo, the Grid headers will be sticky while scrolling the Grid's parent div element.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/scrolling/sticky-header/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Sticky-header.cs" %}
{% include code-snippet/grid/scrolling/sticky-header/sticky-header.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/scrolling/sticky-header/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Sticky-header.cs" %}
{% include code-snippet/grid/scrolling/sticky-header/sticky-header.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Scroll to selected row

You can scroll the grid content to the selected row position by using the [`rowSelected`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_RowSelected) event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/scrolling/scroll-selected-row/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Scroll-selected-row.cs" %}
{% include code-snippet/grid/scrolling/scroll-selected-row/scroll-selected-row.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/scrolling/scroll-selected-row/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Scroll-selected-row.cs" %}
{% include code-snippet/grid/scrolling/scroll-selected-row/scroll-selected-row.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Hide the scrollbar when the content is not overflown

You can hide the scrollbar of Grid content by using the [`hideScroll`](https://ej2.syncfusion.com/javascript/documentation/api/grid/#hidescroll) method when the content doesn't overflow its parent element.

In the following sample, we have invoked the [`hideScroll`](https://ej2.syncfusion.com/javascript/documentation/api/grid/#hidescroll) method inside the [`dataBound`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataBound) event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/scrolling/hide-scroll/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Hide-scroll.cs" %}
{% include code-snippet/grid/scrolling/hide-scroll/hide-scroll.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/scrolling/hide-scroll/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Hide-scroll.cs" %}
{% include code-snippet/grid/scrolling/hide-scroll/hide-scroll.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


