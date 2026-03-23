---
layout: post
title: Legend in ##Platform_Name## Sankey Chart Component
description: Learn here all about Legend in Syncfusion ##Platform_Name## Sankey Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Legend
publishingplatform: ##Platform_Name##
documentation: ug
---

# Legend in ##Platform_Name## Sankey Chart component

A legend provides a visual key that helps users understand the categories and meanings represented by nodes in the Sankey Chart. The Sankey Chart provides comprehensive legend configuration options including positioning, styling, customization, and interactive behaviors. You can enable and customize legend using the `Legend` property.

This guide covers legend configuration, positioning strategies, customization options, and dynamic legend rendering events.

## Legend Settings Properties

The `LegendSettings` property provides comprehensive options to configure legend appearance, behavior, and positioning. The following properties are commonly used:

### Legend Configuration Properties

| Property | Type | Default | Description |
|----------|------|---------|-------------|
| visible | boolean | true | Shows or hides the legend. |
| position | string | 'Auto' | Position of the legend (Auto, Top, Bottom, Left, Right, Custom). |
| width | string | null | Width of the legend container. |
| height | string | null | Height of the legend container. |
| shapeWidth | number | 10 | Width of the legend shape (icon). |
| shapeHeight | number | 10 | Height of the legend shape (icon). |
| padding | number | 8 | Padding around the legend container. |
| itemPadding | number | null | Padding between legend items. |
| shapePadding | number | 8 | Padding between the legend shape and its text. |
| background | string | 'transparent' | Background color of the legend. |
| opacity | number | 1 | Opacity of the legend container (0 to 1). |
| title | string | null | Title text for the legend. |
| enableHighlight | boolean | true | Enables highlighting of related nodes/links when legend item is clicked. |
| isInversed | boolean | false | Inverts the legend layout. |
Enable the legend and configure its basic properties such as visibility, position, and sizing. By default, the legend is automatically positioned based on available space. |

## Basic Legend Configuration

Here is an example of enabling and customizing the legend:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sankey/legend/basic-legend/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Basic-legend.cs" %}
{% include code-snippet/sankey/legend/basic-legend/basic-legend.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sankey/legend/basic-legend/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Basic-legend.cs" %}
{% include code-snippet/sankey/legend/basic-legend/basic-legend.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}

## Legend Position

Control the legend position using the `Position` property with the following options:

- **'Top'**: Legend appears above the Sankey Chart
- **'Bottom'**: Legend appears below the Sankey Chart
- **'Left'**: Legend appears to the left of the chart
- **'Right'**: Legend appears to the right of the chart (default for most cases)
- **'Auto'**: Automatically positions the legend based on available space
- **'Custom'**: Allows you to specify custom coordinates using the `Location` property

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sankey/legend/legend-position/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Legend-position.cs" %}
{% include code-snippet/sankey/legend/legend-position/legend-position.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sankey/legend/legend-position/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Legend-position.cs" %}
{% include code-snippet/sankey/legend/legend-position/legend-position.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}

Customize the legend appearance with properties like background color, opacity, shape sizing, padding, and interactive highlighting. The following example demonstrates comprehensive legend styling:

## Customized Legend

Here is an example with comprehensive legend customization:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sankey/legend/customized-legend/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Customized-legend.cs" %}
{% include code-snippet/sankey/legend/customized-legend/customized-legend.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sankey/legend/customized-legend/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Customized-legend.cs" %}
{% include code-snippet/sankey/legend/customized-legend/customized-legend.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}

## Custom Legend Position

Position the legend at a specific location using the `Custom` position setting. When using `Custom` position, specify the exact X and Y coordinates where the legend should appear. This provides precise control over legend placement:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sankey/legend/custom-legend-position/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-legend-position.cs" %}
{% include code-snippet/sankey/legend/custom-legend-position/custom-legend-position.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sankey/legend/custom-legend-position/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-legend-position.cs" %}
{% include code-snippet/sankey/legend/custom-legend-position/custom-legend-position.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}

## Advanced Legend Configuration

### Dynamic Legend Customization

Use the `LegendItemRendering` event to customize individual legend items before they are rendered. This event is triggered for each legend item and allows you to apply conditional styling, modify colors, or change text based on data values:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sankey/legend/dynamic-legend-custom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Dynamic-legend-custom.cs" %}
{% include code-snippet/sankey/legend/dynamic-legend-custom/dynamic-legend-custom.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sankey/legend/dynamic-legend-custom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Dynamic-legend-custom.cs" %}
{% include code-snippet/sankey/legend/dynamic-legend-custom/dynamic-legend-custom.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}