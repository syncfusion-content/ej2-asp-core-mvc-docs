---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Scrolling of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Scrolling
publishingplatform: ##Platform_Name##
documentation: ug
---


# Scrolling

 The scrollbar will be displayed in the grid when content exceeds the element [`width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Width) or [`height`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Height). The vertical and horizontal scrollbars will be displayed based on the following criteria:

* The vertical scrollbar appears when the total height of rows present in the grid exceeds its element height.
* The horizontal scrollbar appears when the sum of columns width exceeds the grid element width.
* The [`height`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Height) and [`width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Width) are used to set the grid height and width, respectively.

> The default value for [`height`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Height) and [`width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Width) is `auto`.

## Set width and height

To specify the [`width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Width) and [`height`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Height) of the scroller in the pixel, set the pixel value to a number.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight %}
{% include_relative code-snippet/scrolling/width-height/width-height.cs %}
{% endhighlight %}
{% highlight %}
{% include_relative code-snippet/scrolling/width-height/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight %} {% include_relative code-snippet/scrolling/width-height/width-height.cs %}
{% endhighlight %}
{% highlight %}
{% include_relative code-snippet/scrolling/width-height/razor %}
{% endhighlight %}
{% endtabs %}



## Responsive with parent container

Specify the [`width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Width) and [`height`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Height) as `100%` to make the grid element fill its parent container.
Setting the [`height`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Height) to `100%` requires the grid parent element to have explicit height.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight %}
{% include_relative code-snippet/scrolling/responsive-parent/responsive-parent.cs %}
{% endhighlight %}
{% highlight %}
{% include_relative code-snippet/scrolling/responsive-parent/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight %} {% include_relative code-snippet/scrolling/responsive-parent/responsive-parent.cs %}
{% endhighlight %}
{% highlight %}
{% include_relative code-snippet/scrolling/responsive-parent/razor %}
{% endhighlight %}
{% endtabs %}



## Scroll to selected row

You can scroll the grid content to the selected row position by using the [`rowSelected`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_RowSelected) event.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight %}
{% include_relative code-snippet/scrolling/scroll-selected-row/scroll-selected-row.cs %}
{% endhighlight %}
{% highlight %}
{% include_relative code-snippet/scrolling/scroll-selected-row/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight %} {% include_relative code-snippet/scrolling/scroll-selected-row/scroll-selected-row.cs %}
{% endhighlight %}
{% highlight %}
{% include_relative code-snippet/scrolling/scroll-selected-row/razor %}
{% endhighlight %}
{% endtabs %}



## Hide the scrollbar when the content is not overflown

You can hide the scrollbar of Grid content by using the [`hideScroll`](https://ej2.syncfusion.com/javascript/documentation/api/grid/#hidescroll) method when the content doesn't overflow its parent element.

In the following sample, we have invoked the [`hideScroll`](https://ej2.syncfusion.com/javascript/documentation/api/grid/#hidescroll) method inside the [`dataBound`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataBound) event.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight %}
{% include_relative code-snippet/scrolling/hide-scroll/hide-scroll.cs %}
{% endhighlight %}
{% highlight %}
{% include_relative code-snippet/scrolling/hide-scroll/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight %} {% include_relative code-snippet/scrolling/hide-scroll/hide-scroll.cs %}
{% endhighlight %}
{% highlight %}
{% include_relative code-snippet/scrolling/hide-scroll/razor %}
{% endhighlight %}
{% endtabs %}



## Sticky Header

You can make the Grid column headers remain fixed while scrolling by using the [`enableStickyHeader`](https://ej2.syncfusion.com/javascript/documentation/api/grid/#enablestickyheader) property.

In the below demo, the Grid headers will be sticky while scrolling the Grid's parent div element.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight %}
{% include_relative code-snippet/scrolling/sticky-header/sticky-header.cs %}
{% endhighlight %}
{% highlight %}
{% include_relative code-snippet/scrolling/sticky-header/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight %} {% include_relative code-snippet/scrolling/sticky-header/sticky-header.cs %}
{% endhighlight %}
{% highlight %}
{% include_relative code-snippet/scrolling/sticky-header/razor %}
{% endhighlight %}
{% endtabs %}


