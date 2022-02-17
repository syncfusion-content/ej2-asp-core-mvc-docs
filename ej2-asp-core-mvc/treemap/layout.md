---
layout: post
title: Layout in ##Platform_Name## Treemap Component
description: Learn here all about Layout in Syncfusion ##Platform_Name## Treemap component and more.
platform: ej2-asp-core-mvc
control: Layout
publishingplatform: ##Platform_Name##
documentation: ug
---

# Layout

Determine the visual representation of nodes belonging to all the TreeMap levels using the `layoutType` property.

## Types of layout

The available layout types are,

* Squarified
* SliceAndDiceVertical
* SliceAndDiceHorizontal
* SliceAndDiceAuto

### Squarified

The `Squarified` layout displays the nested rectangles based on aspect ratio in the TreeMap. The rectangles will be split based on the height and width of the parent. The default rendering type of layout is `Squarified`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/treemap/layout/squarified/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Squarified.cs" %}
{% include code-snippet/treemap/layout/squarified/squarified.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/treemap/layout/squarified/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Squarified.cs" %}
{% include code-snippet/treemap/layout/squarified/squarified.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![TreeMap with squarified layout](images/Layout/Squarified.png)

### SliceAndDiceVertical

The `SliceAndDiceVertical` layout creates rectangles with high aspect ratio and displays items in a vertically sorted order.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/treemap/layout/slice-vertical/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Slice_vertical.cs" %}
{% include code-snippet/treemap/layout/slice-vertical/slice-vertical.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/treemap/layout/slice-vertical/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Slice_vertical.cs" %}
{% include code-snippet/treemap/layout/slice-vertical/slice-vertical.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![TreeMap with slice and dice vertical layout](images/Layout/SliceAndDiceVertical.png)

### SliceAndDiceHorizontal

The `SliceAndDiceHorizontal` layout creates rectangles with high aspect ratio and displays items in a horizontally sorted order.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/treemap/layout/slice-horizontal/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Slice_horizontal.cs" %}
{% include code-snippet/treemap/layout/slice-horizontal/slice-horizontal.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/treemap/layout/slice-horizontal/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Slice_horizontal.cs" %}
{% include code-snippet/treemap/layout/slice-horizontal/slice-horizontal.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![TreeMap with slice and dice horizontal](images/Layout/SliceandDiceHorizontal.png)

### SliceAndDiceAuto

The `SliceAndDiceAuto` layout creates rectangles with high aspect ratio and display items sorted both horizontally and vertically.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/treemap/layout/slice-auto/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Slice_auto.cs" %}
{% include code-snippet/treemap/layout/slice-auto/slice-auto.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/treemap/layout/slice-auto/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Slice_auto.cs" %}
{% include code-snippet/treemap/layout/slice-auto/slice-auto.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![TreeMap with slice and dice auto layout](images/Layout/SliceAndDiceAuto.png)

## Right-to-left rendering

The TreeMap control supports right-to-left rendering for all its elements such as nodes, tooltip, data labels, and legends.

## Legend with Rtl support

If you set the `enableRtl` property to true, then the legend icon will be rendered on the right and the legend text will be rendered on the left of the legend icon.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/treemap/layout/legend-rtl/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Legend-rtl.cs" %}
{% include code-snippet/treemap/layout/legend-rtl/legend-rtl.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/treemap/layout/legend-rtl/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Legend-rtl.cs" %}
{% include code-snippet/treemap/layout/legend-rtl/legend-rtl.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![TreeMap with slice and dice auto layout](images/Layout/LegendRTL.png)

## Tooltip with Rtl support

If the `enableRtl` property is set to true, the tooltip data will be rendered in reverse direction.

The following example shows the format of the tooltip.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/treemap/layout/tooltip-rtl/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip-rtl.cs" %}
{% include code-snippet/treemap/layout/tooltip-rtl/tooltip-rtl.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/treemap/layout/tooltip-rtl/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip-rtl.cs" %}
{% include code-snippet/treemap/layout/tooltip-rtl/tooltip-rtl.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![TreeMap with tooltip RTL](images/Layout/TooltipRtl.png)

## Treemap Item Rendering Direction

The direction of TreeMap item is `TopLeftBottomRight` by default and customize the rendering direction of the TreeMap item by setting the `RenderDirection` property.

The TreeMap can be rendered in the following directions:

* TopLeftBottomRight
* TopRightBottomLeft
* BottomRightTopLeft
* BottomLeftTopRight

The following example demonstrate how to render the treemap in the RTL direction with `TopLeftBottomRight`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/treemap/layout/render-direction-one/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Render-direction-one.cs" %}
{% include code-snippet/treemap/layout/render-direction-one/render-direction-one.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/treemap/layout/render-direction-one/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Render-direction-one.cs" %}
{% include code-snippet/treemap/layout/render-direction-one/render-direction-one.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![TreeMap with custom rendering direction](images/Layout/TopLeftBottomRight.png)

The following example demonstrate how to render the treemap in the RTL direction with `TopRightBottomLeft`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/treemap/layout/render-direction-two/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Render-direction-two.cs" %}
{% include code-snippet/treemap/layout/render-direction-two/render-direction-two.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/treemap/layout/render-direction-two/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Render-direction-two.cs" %}
{% include code-snippet/treemap/layout/render-direction-two/render-direction-two.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![TreeMap custom rendering direction](images/Layout/TopRightBottomLeft.png)

The following example demonstrate how to render the treemap in the RTL direction with `BottomRightTopLeft`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/treemap/layout/render-direction-three/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Render-direction-three.cs" %}
{% include code-snippet/treemap/layout/render-direction-three/render-direction-three.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/treemap/layout/render-direction-three/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Render-direction-three.cs" %}
{% include code-snippet/treemap/layout/render-direction-three/render-direction-three.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![TreeMap custom rendering direction](images/Layout/BottomRightTopLeft.png)

The following example demonstrate how to render the treemap in the RTL direction with `BottomLeftTopRight`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/treemap/layout/render-direction-four/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Render-direction-four.cs" %}
{% include code-snippet/treemap/layout/render-direction-four/render-direction-four.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/treemap/layout/render-direction-four/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Render-direction-four.cs" %}
{% include code-snippet/treemap/layout/render-direction-four/render-direction-four.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![TreeMap custom rendering direction](images/Layout/BottomLeftTopRight.png)