---
layout: post
title: Gradient and Customization in ##Platform_Name## Syncfusion Chart Component
description: Learn here all about Gradient in Syncfusion ##Platform_Name## Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Gradient
publishingplatform: ##Platform_Name##
documentation: ug
---

# Gradient in ##Platform_Name## Chart control

Gradients add depth and modern styling to charts by smoothly blending multiple colors. The Charts component supports two gradient types:

- Linear Gradient
- Radial Gradient

Gradients can be applied to:

- Series
- Trendlines
- Technical Indicators

The gradient can be defined in the `@{ }` Razor code block or dynamically configured in the `load` event of the chart.

## Linear Gradient

A linear gradient blends color along side a straight path from a defined start point to an end point. Configure it by adding `LinearGradient` inside the target element (Series, Trendlines or Indicators) and define one or more color stops that control how colors transition across the gradient. Set the start and end positions of the gradient using `X1`, `Y1`, `X2` and `Y2` properties. The gradient color stop values such as `Offset`, `Color`, `Opacity`, `Lighten` and `Brighten` are set using the `ChartGradientColorStop` property.

In the `LinearGradient`:
- `X1` - Sets the horizontal start position of the gradient (0 to 1).
- `Y1` - Sets the vertical start position of the gradient (0 to 1).
- `X2` - Sets the horizontal end position of the gradient (0 to 1).
- `Y2` - Sets the vertical end position of the gradient (0 to 1).

In the `ChartGradientColorStop`:

- `Offset` - Specifies the position of the color stop along the gradient (0 to 100).
- `Color` - Sets the color at the stop.
- `Opacity` - Defines the transparency of the stop (0 to 1).
- `Lighten` - Adjusts lightness at the stop. Positive values lighten the color. Range: 0 to 1.
- `Brighten` - Adjusts brightness at the stop. Positive values increase brightness; negative values decrease it. Ranges: -1 to 1.

### Series

Apply a linear gradient to a series by adding `LinearGradient` inside the target Series. The same gradient is applied to the series markers, legend symbol and tooltip marker for visual consistency.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/gradient/series-linear/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="LinearGradient.cs" %}
{% include code-snippet/chart/gradient/series-linear/series-linear.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/gradient/series-linear/razor %}
{% endhighlight %}
{% highlight c# tabtitle="LinearGradient.cs" %}
{% include code-snippet/chart/gradient/series-linear/series-linear.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Trendlines

Apply a linear gradient to a trendline by adding `LinearGradient` inside the target Trendline.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/gradient/trendlines-linear/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="LinearGradient.cs" %}
{% include code-snippet/chart/gradient/trendlines-linear/trendlines-linear.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/gradient/trendlines-linear/razor %}
{% endhighlight %}
{% highlight c# tabtitle="LinearGradient.cs" %}
{% include code-snippet/chart/gradient/trendlines-linear/trendlines-linear.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Technical Indicators

Apply a linear gradient to a technical indicator by adding `LinearGradient` inside the target Indicator.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/gradient/indicators-linear/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="LinearGradient.cs" %}
{% include code-snippet/chart/gradient/indicators-linear/indicators-linear.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/gradient/indicators-linear/razor %}
{% endhighlight %}
{% highlight c# tabtitle="LinearGradient.cs" %}
{% include code-snippet/chart/gradient/indicators-linear/indicators-linear.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Radial gradient

A radial gradient blends colors outward from a central point, creating a circular or elliptical color progression. Configure it by adding `RadialGradient` inside the target element (Series, Trendline, or Indicator) and define one or more color stops to control how colors transition from the center to the outer edge. Set the gradient’s center, optional focal point, and radius using `RadialGradient` properties. The color stop values such as `Offset`, `Color`, `Opacity`, `Lighten`, and `Brighten` are set using the `ChartGradientColorStop` property.

In the `RadialGradient`:

- `Cx` - Sets the normalized horizontal center of the gradient (0 to 1).
- `Cy` - Sets the normalized vertical center of the gradient (0 to 1).
- `Fx` - Sets the normalized horizontal focal point from which the gradient appears to originate (0 to 1).
- `Fy` - Sets the normalized vertical focal point (0 to 1).
- `R` - Sets the normalized radius of the gradient circle (0 to 1).

In the `ChartGradientColorStop`:

- `Offset` - Specifies the position of the color stop along the gradient (0 to 100).
- `Color` - Sets the color at the stop.
- `Opacity` - Defines the transparency of the stop (0 to 1).
- `Lighten` - Adjusts lightness at the stop. Positive values lighten the color. Range: 0 to 1.
- `Brighten` - Adjusts brightness at the stop. Positive values increase brightness; negative values decrease it. Ranges: -1 to 1.

### Series

Apply a radial gradient to a series by adding `RadialGradient` inside the target Series. The same gradient is applied to the series markers, legend symbol and tooltip marker for visual consistency.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/gradient/series-radial/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="RadialGradient.cs" %}
{% include code-snippet/chart/gradient/series-radial/series-radial.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/gradient/series-radial/razor %}
{% endhighlight %}
{% highlight c# tabtitle="RadialGradient.cs" %}
{% include code-snippet/chart/gradient/series-radial/series-radial.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}