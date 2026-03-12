---
layout: post
title: Gradient in ##Platform_Name## Syncfusion Accumulation Chart Component
description: Learn here all about Gradient in Syncfusion ##Platform_Name## Accumulation Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Gradient
publishingplatform: ##Platform_Name##
documentation: ug
---


# Gradient in ##Platform_Name## Accumulation Chart Component

Gradients add depth and modern styling to charts by smoothly blending multiple colors. The Charts component supports two gradient types:

- Linear Gradient
- Radial Gradient

The gradient can be defined in the `@{ }` Razor code block or dynamically configured in the `load` event of the chart.

## Linear gradient

A linear gradient blends colors along a straight path from a defined start point to an end point. In accumulation charts, a linear gradient can be applied either to the whole series or to each point via the pointRender event. An `LinearGradient` is configured with one or more color stops.

The linear gradient properties are:

- `X1` - Horizontal start position of the gradient (0 to 1).
- `Y1` - Vertical start position of the gradient (0 to 1).
- `X2` - Horizontal end position of the gradient (0 to 1).
- `Y2` - Vertical end position of the gradient (0 to 1).

Properties for `ChartGradientColorStop`:

- `Offset` - Position along the gradient (0 to 100).
- `Color` - Base color at the stop.
- `Opacity` - Transparency (0 to 1).
- `Lighten` - Adjusts the lightness at the stop. A value of 1 applies maximum lightening. Range: 0 to 1.
- `Brighten` - Adjusts brightness at the stop. Positive values increase brightness; negative values decrease it. Range: -1 to 1.

### Apply gradient to the entire series


A linear gradient may be applied directly at the series level. The same gradient is applied uniformly to all data points, legend symbols and tooltip markers.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/gradient/series-linear/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="LinearGradient.cs" %}
{% include code-snippet/chart/accumulation-charts/gradient/series-linear/series-linear.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/gradient/series-linear/razor %}
{% endhighlight %}
{% highlight c# tabtitle="LinearGradient.cs" %}
{% include code-snippet/chart/accumulation-charts/gradient/series-linear/series-linear.cs %}
{% endhighlight %}
{% endtabs %}

### Apply a gradient per point using the point render event

A diagonal linear gradient can be applied per data point using the pointRender event for a clear light-to-shadow transition.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/gradient/point-linear/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="LinearGradient.cs" %}
{% include code-snippet/chart/accumulation-charts/gradient/point-linear/point-linear.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/gradient/point-linear/razor %}
{% endhighlight %}
{% highlight c# tabtitle="LinearGradient.cs" %}
{% include code-snippet/chart/accumulation-charts/gradient/point-linear/point-linear.cs %}
{% endhighlight %}
{% endtabs %}

## Radial gradient

A radial gradient blends colors outward from a central point, creating a circular or elliptical color progression. Configure it by adding `RadialGradient` inside the target element and define one or more color stops to control how colors transition from the center to the outer edge. Set the gradient’s center, optional focal point, and radius using `RadialGradient` properties. The color stop values such as `Offset`, `Color`, `Opacity`, `Lighten`, and `Brighten` are set using the `ChartGradientColorStop` property.

In the `RadialGradient`:

- `Cx` - Sets the normalized horizontal center of the gradient (0 to 1).
- `Cy` - Sets the normalized vertical center of the gradient (0 to 1).
- `Fx` - Sets the normalized horizontal focal point of the gradient's origin (0 to 1).
- `Fy` - Sets the normalized vertical focal point (0 to 1).
- `R` - Sets the normalized radius of the gradient circle (0 to 1).

In the `gradientColorStop`:

- `Offset` - Specifies the position of the color stop along the gradient (0 to 100).
- `Color` - Sets the color at the stop.
- `Opacity` - Defines the transparency of the stop (0 to 1).
- `Lighten` - Adjusts lightness at the stop. Positive values lighten the color. Range: 0 to 1.
- `Brighten` - Adjusts brightness at the stop. Positive values increase brightness; negative values decrease it. Ranges: -1 to 1.

### Apply a radial gradient to the entire series

A radial gradient can be applied directly at the series level. The same gradient is applied uniformly to all data points, legend symbols and tooltip markers.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/gradient/series-radial/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="RadialGradient.cs" %}
{% include code-snippet/chart/accumulation-charts/gradient/series-radial/series-radial.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/gradient/series-radial/razor %}
{% endhighlight %}
{% highlight c# tabtitle="RadialGradient.cs" %}
{% include code-snippet/chart/accumulation-charts/gradient/series-radial/series-radial.cs %}
{% endhighlight %}
{% endtabs %}

### Apply a radial gradient per point using the point render event

The following example uses a distinct color palette and an off-center radial gradient to create a clear light-to-shadow effect on each data point. The gradient is configured in pointRender, so each data point receives its own radial gradient derived from its base color.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/gradient/point-radial/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="RadialGradient.cs" %}
{% include code-snippet/chart/accumulation-charts/gradient/point-radial/point-radial.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/gradient/point-radial/razor %}
{% endhighlight %}
{% highlight c# tabtitle="RadialGradient.cs" %}
{% include code-snippet/chart/accumulation-charts/gradient/point-radial/point-radial.cs %}
{% endhighlight %}
{% endtabs %}