---
layout: post
title: Legend in ##Platform_Name## Syncfusion Circular Chart 3D Component
description: Learn here all about Legend in Syncfusion ##Platform_Name## Circular Chart 3D component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Legend
publishingplatform: ##Platform_Name##
documentation: ug
---


# Legend in ##Platform_Name## Circular Chart 3D Component

As like a chart, the legend is also available for Circular Chart 3D, which gives information about the points. By default, the legend will be placed on the right, if the width of the chart is high or will be placed on the bottom, if the height of the chart is high. Other customization features regarding the legend element are same as the `chart legend`. Here, the legend for a point can be collapsed by giving the empty string to the x value of the point.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circular-chart/user-interaction/legend/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Legend.cs" %}
{% include code-snippet/circular-chart/user-interaction/legend/legend.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circular-chart/user-interaction/legend/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Legend.cs" %}
{% include code-snippet/circular-chart/user-interaction/legend/legend.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Position and alignment

By using the position property, you can position the legend at the `Left`, `Right`, `Top` or `Bottom` of the chart. You can also align the legend to `Center`, `Far` or `Near` of the chart using the alignment property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circular-chart/user-interaction/position/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Position.cs" %}
{% include code-snippet/circular-chart/user-interaction/position/position.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circular-chart/user-interaction/position/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Position.cs" %}
{% include code-snippet/circular-chart/user-interaction/position/position.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Legend reverse

You can reverse the order of the legend items by using the `Reverse` property. By default, legend for the first series in the collection will be placed first.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circular-chart/user-interaction/reverse/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Reverse.cs" %}
{% include code-snippet/circular-chart/user-interaction/reverse/reverse.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circular-chart/user-interaction/reverse/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Reverse.cs" %}
{% include code-snippet/circular-chart/user-interaction/reverse/reverse.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Legend shape

To change the legend icon shape, use the `LegendShape` property in the `Series`. By default, legend icon shape is `SeriesType`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circular-chart/user-interaction/legend-shape/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Legend-shape.cs" %}
{% include code-snippet/circular-chart/user-interaction/legend-shape/legend-shape.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circular-chart/user-interaction/legend-shape/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Legend-shape.cs" %}
{% include code-snippet/circular-chart/user-interaction/legend-shape/legend-shape.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Legend size

The legend size can be changed by using the `Width` and `Height` properties of the `LegendSettings`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circular-chart/user-interaction/legend-size/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Legend-size.cs" %}
{% include code-snippet/circular-chart/user-interaction/legend-size/legend-size.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circular-chart/user-interaction/legend-size/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Legend-size.cs" %}
{% include code-snippet/circular-chart/user-interaction/legend-size/legend-size.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Legend item size

You can customize the size of the legend items by using the `ShapeHeight` and `ShapeWidth` properties.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circular-chart/user-interaction/item-size/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Item-size.cs" %}
{% include code-snippet/circular-chart/user-interaction/item-size/item-size.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circular-chart/user-interaction/item-size/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Item-size.cs" %}
{% include code-snippet/circular-chart/user-interaction/item-size/item-size.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Paging for legend

Paging will be enabled by default, when the legend items exceeds the legend bounds. You can view the each legend item by navigating between the pages using the navigation buttons.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circular-chart/user-interaction/paging/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Paging.cs" %}
{% include code-snippet/circular-chart/user-interaction/paging/paging.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circular-chart/user-interaction/paging/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Paging.cs" %}
{% include code-snippet/circular-chart/user-interaction/paging/paging.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Legend text wrap

When the legend text exceeds the container, the text can be wrapped by using `TextWrap` Property. End user can also wrap the legend text based on the `MaximumLabelWidth` property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circular-chart/user-interaction/text-wrap/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Text-wrap.cs" %}
{% include code-snippet/circular-chart/user-interaction/text-wrap/text-wrap.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circular-chart/user-interaction/text-wrap/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Text-wrap.cs" %}
{% include code-snippet/circular-chart/user-interaction/text-wrap/text-wrap.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Legend title

You can set title for legend using `Title` property in `LegendSettings`. You can also customize the `FontStyle`, `Size`, `FontWeight`, `Color`, `TextAlignment`, `FontFamily`, `Opacity` and `TextOverflow` of legend title. `TitlePosition` is used to set the legend position in `Top`, `Left` and `Right` position. `MaximumTitleWidth` is used to set the width of the legend title. By default, it will be `100px`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circular-chart/user-interaction/legend-title/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Legend-title.cs" %}
{% include code-snippet/circular-chart/user-interaction/legend-title/legend-title.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circular-chart/user-interaction/legend-title/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Legend-title.cs" %}
{% include code-snippet/circular-chart/user-interaction/legend-title/legend-title.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Arrow page navigation

By default, the page number will be enabled while legend paging. Now, you can disable that page number and also you can get left and right arrows for page navigation. You have to set `false` value to `EnablePages` to get this support.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circular-chart/user-interaction/arrow-page/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Arrow-page.cs" %}
{% include code-snippet/circular-chart/user-interaction/arrow-page/arrow-page.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circular-chart/user-interaction/arrow-page/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Arrow-page.cs" %}
{% include code-snippet/circular-chart/user-interaction/arrow-page/arrow-page.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Legend item padding

The `ItemPadding` property can be used to adjust the space between the legend items.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circular-chart/user-interaction/item-padding/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Item-padding.cs" %}
{% include code-snippet/circular-chart/user-interaction/item-padding/item-padding.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circular-chart/user-interaction/item-padding/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Item-padding.cs" %}
{% include code-snippet/circular-chart/user-interaction/item-padding/item-padding.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}