<!-- Converted from: sankey/EJ2_ASP.MVC/nodes.md -->

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

The `nodeStyle` property allows you to customize the visual appearance of all nodes in the Sankey Chart. This provides a unified style for all nodes, which can be overridden at the individual node level or through rendering events.

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

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sankey/nodes/node-style/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Node-style.cs" %}
{% include code-snippet/sankey/nodes/node-style/node-style.cs %}
{% endhighlight %}
{% endtabs %}

## Individual Node Customization

... (content preserved)
