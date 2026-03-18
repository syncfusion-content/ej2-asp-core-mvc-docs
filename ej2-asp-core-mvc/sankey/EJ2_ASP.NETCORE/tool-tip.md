<!-- Converted from: sankey/EJ2_ASP.MVC/tool-tip.md -->

---
layout: post
title: ToolTip in ##Platform_Name## Sankey Chart Component
description: Learn here all about ToolTip in Syncfusion ##Platform_Name## Sankey Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: ToolTip
publishingplatform: ##Platform_Name##
documentation: ug
---

# ToolTip in React Sankey Chart component

The Sankey Chart provides tooltips that surface contextual details for hovered elements without cluttering the diagram. Tooltips display additional information when users hover over nodes or links in the Sankey Chart. You can enable and customize tooltips using the `tooltip` property and by injecting the `SankeyTooltip` module.

This guide outlines how to enable and customize tooltips in the React Sankey Chart.

## Tooltip Settings Properties

The following table lists the main tooltip configuration properties:

| Property | Type | Default | Description |
|----------|------|---------|-------------|
| enable | boolean | true | Enables or disables the tooltip display. |
| fill | string | null | Background fill color of the tooltip. |
| opacity | number | 0.75 | Opacity of the tooltip container (0 to 1). |
| textStyle | object | null | Text styling for the tooltip content. |
| nodeFormat | string | '$name : $value' | Format string for node tooltips. |
| linkFormat | string | '$start.name $start.value → $target.name $target.value' | Format string for link tooltips. |
| enableAnimation | boolean | true | Toggles tooltip animation. |
| duration | number | 300 | Animation duration in milliseconds. |
| fadeOutDuration | number | 1000 | Fade-out duration in milliseconds. |
| fadeOutMode | string | 'Move' | Fade-out animation mode ('Move', 'Fade', 'Delay'). |

## Basic Tooltip Configuration

Enable tooltips with default formatting:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sankey/tooltip/basic-tooltip/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Basic-tooltip.cs" %}
{% include code-snippet/sankey/tooltip/basic-tooltip/basic-tooltip.cs %}
{% endhighlight %}
{% endtabs %}

## Customizing Tooltip Appearance

Adjust tooltip appearance and behavior using tooltip configuration properties:

- **Enable**: Shows or hides tooltips.
- **Fill**: Sets background color.
- **Opacity**: Controls transparency (0 to 1). The default value is 0.75.
- **TextStyle**: Configures font size, family, weight, and color for the tooltip text.
- **EnableAnimation**: Toggles animation. Default: true.
- **Duration**: Animation duration in milliseconds. The default value is 300.
- **FadeOutDuration**: Fade-out duration in milliseconds. The default value is 1000.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sankey/tooltip/customized-tooltip/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Customized-tooltip.cs" %}
{% include code-snippet/sankey/tooltip/customized-tooltip/customized-tooltip.cs %}
{% endhighlight %}
{% endtabs %}

## Format Strings

... (content preserved)
