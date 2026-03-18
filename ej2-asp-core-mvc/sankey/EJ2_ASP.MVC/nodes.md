---
layout: post
title: Nodes in ##Platform_Name## Sankey Chart Component
description: Learn here all about Nodes in Syncfusion ##Platform_Name## Sankey Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Nodes
publishingplatform: ##Platform_Name##
documentation: ug
---

# Nodes in React Sankey Chart component

Nodes are the fundamental building blocks of a Sankey Chart, representing sources, targets, and intermediate entities in flow diagrams. The Sankey Chart provides extensive customization options for node appearance, enabling you to create visually meaningful and interactive flow diagrams.

This guide covers node customization including styling, individual appearance changes, opacity control, positioning, and dynamic rendering events.

## Node Appearance

The `NodeStyle` property allows you to customize the visual appearance of all nodes in the Sankey Chart. This provides a unified style for all nodes, which can be overridden at the individual node level or through rendering events.

### Node Style Properties

| Property | Type | Default | Description |
|----------|------|---------|-------------|
| width | number | 20 | Width of the node rectangle in pixels. |
| padding | number | 10 | Spacing between nodes and their labels. |
| fill | string | null | Fill color of nodes. If not specified, theme color is used. |
| stroke | string | '' | Stroke color of node borders. |
| strokeWidth | number | 1 | Width of the node border stroke. |
| opacity | number | 1 | Opacity of the node (0 to 1). |
| highlightOpacity | number | 1 | Opacity of node when highlighted. |
| inactiveOpacity | number | 0.3 | Opacity of inactive nodes (when interacting with others). |

Customize the global node appearance by configuring the `NodeStyle` property with properties such as fill color, stroke, width, padding, and opacity levels

Here is an example of customizing node appearance:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sankey/nodes/node-style/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Node-style.cs" %}
{% include code-snippet/sankey/nodes/node-style/node-style.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sankey/nodes/node-style/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Node-style.cs" %}
{% include code-snippet/sankey/nodes/node-style/node-style.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}

## Individual Node Customization

Beyond global styling, you can customize the appearance of specific nodes by setting individual properties. Each node can have its own `Color`, styling, and appearance settings that override the global `NodeStyle` configuration. This approach is useful when you want certain nodes to stand out or follow a specific color scheme:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sankey/nodes/individual-node-custom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Individual-node-custom.cs" %}
{% include code-snippet/sankey/nodes/individual-node-custom/individual-node-custom.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sankey/nodes/individual-node-custom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Individual-node-custom.cs" %}
{% include code-snippet/sankey/nodes/individual-node-custom/individual-node-custom.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}

## Opacity and Interaction

Control how nodes appear during user interactions. The Sankey Chart provides three opacity properties:

- **`Opacity`**: The default opacity of nodes in their normal state (0 to 1)
- **`HighlightOpacity`**: The opacity when a node is highlighted or hovered
- **`InactiveOpacity`**: The opacity of nodes that are not actively being interacted with

Configure these properties to provide visual feedback and improve the interactivity experience:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sankey/nodes/node-opacity/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Node-opacity.cs" %}
{% include code-snippet/sankey/nodes/node-opacity/node-opacity.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sankey/nodes/node-opacity/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Node-opacity.cs" %}
{% include code-snippet/sankey/nodes/node-opacity/node-opacity.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}

## Node Offset

Use the `Offset` property to adjust node positions vertically (in Horizontal orientation) or horizontally (in Vertical orientation). The offset direction depends on the chart orientation:

- **In Horizontal orientation**: Offset adjusts node positions vertically
- **In Vertical orientation**: Offset adjusts node positions horizontally

This property is useful for manually arranging nodes to avoid overlaps or create specific flow patterns:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sankey/nodes/node-offset/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Node-offset.cs" %}
{% include code-snippet/sankey/nodes/node-offset/node-offset.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sankey/nodes/node-offset/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Node-offset.cs" %}
{% include code-snippet/sankey/nodes/node-offset/node-offset.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}

## Advanced Node Configuration

### Dynamic Node Customization

Use the `NodeRendering` event to customize node appearance dynamically during the render process. This event is triggered for each node before it is rendered, allowing you to apply conditional styling, calculate colors based on data values, or modify properties based on context. This is the most powerful way to create data-driven node visualizations:

## Node Rendering Event

Use the `NodeRendering` event to customize node appearance dynamically before rendering:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sankey/nodes/node-rendering-event/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Node-rendering-event.cs" %}
{% include code-snippet/sankey/nodes/node-rendering-event/node-rendering-event.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sankey/nodes/node-rendering-event/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Node-rendering-event.cs" %}
{% include code-snippet/sankey/nodes/node-rendering-event/node-rendering-event.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}