---
layout: post
title: Legend in ##Platform_Name## Syncfusion 3D Circular Chart Component
description: Learn here all about legend in Syncfusion ##Platform_Name## 3D Circular Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Legend
publishingplatform: ##Platform_Name##
documentation: ug
---


# Legend in ##Platform_Name## 3D Circular Chart Component

The legend provides information about the data points rendered in the 3D Circular Chart. It can be added by enabling the `Visible` option in the `LegendSettings` property.

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

By using the `Position` property, the legend can be positioned at the `Left`, `Right`, `Top` or `Bottom` of the 3D Circular Chart. By default, the legend will be positioned to the right of the 3D Circular Chart. Additionally, you can align the legend to the `Center`, `Far` or `Near` of the chart using the `Alignment` property.

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

You can reverse the order of the legend items by using the `Reverse` property in `LegendSettings`. By default, the legend for the first series in the collection will be placed first.

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

To change the legend shape, use the `LegendShape` property in the `Series`. By default, the legend shape is set to `SeriesType`.

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

The legend size can be changed by using the `Width` and `Height` properties in `LegendSettings`.

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

The size of the legend items can be customized by using the `ShapeHeight` and `ShapeWidth` properties in `LegendSettings`.

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



## Legend paging

Paging will be enabled by default when the legend items exceed the legend bounds. Each legend item can be viewed by navigating between the pages using navigation buttons.

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

When the legend text exceeds the container, the text can be wrapped using the `TextWrap` property in `LegendSettings`. End users can also wrap the legend text based on the `MaximumLabelWidth` property in `LegendSettings`.

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

You can set a title for the legend using the `Title` property in `LegendSettings`. The `Size`, `Color`, `Opacity`, `FontStyle`, `FontWeight`, `FontFamily`, `TextAlignment`, and `TextOverflow` of the legend title can be customized using the `TitleStyle` property in `LegendSettings`.

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

The page number will always be visible when using legend paging. However, it is now possible to disable the page number and enable page navigation with the left and right arrows. To render the arrow page navigation, set the `EnablePages` property to **false**.

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