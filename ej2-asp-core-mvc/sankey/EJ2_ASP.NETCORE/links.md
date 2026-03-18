<!-- Converted from: sankey/EJ2_ASP.MVC/links.md -->

---
layout: post
title: Links in ##Platform_Name## Sankey Chart Component
description: Learn here all about Links in Syncfusion ##Platform_Name## Sankey Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Links
publishingplatform: ##Platform_Name##
documentation: ug
---

# Links in ##Platform_Name## Sankey Chart component

Links are the connecting paths that visualize flow between nodes in a Sankey Chart. Each link connects a source node to a target node and carries a quantitative value that determines its visual thickness. The Sankey Chart provides comprehensive customization options for link styling, colors, curvature, and interactions.

This guide covers link customization including appearance properties, color blending, curvature control, and dynamic rendering events.

## Link Style Properties

The `linkStyle` property allows you to customize the visual appearance of all links in the Sankey Chart. These properties control opacity, highlighting behavior, curvature, and color blending.

### Link Style Configuration Properties

| Property | Type | Default | Description |
|----------|------|---------|-------------|
| opacity | number | 0.35 | Opacity of the link (0 to 1). |
| highlightOpacity | number | 1 | Opacity of link when highlighted or hovered. |
| inactiveOpacity | number | 0.3 | Opacity of link when not interacting (when other links are hovered). |
| curvature | number | 0.55 | Curvature factor of the link path (0 = straight line, 1 = fully curved). |
| colorType | string | 'Blend' | Color blending type: 'Source', 'Target', or 'Blend'. |

## Basic Link Customization

Customize the appearance of all links using the `linkStyle` property to set global opacity levels, curvature, and color blending behavior:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sankey/links/basic-links/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Basic-links.cs" %}
{% include code-snippet/sankey/links/basic-links/basic-links.cs %}
{% endhighlight %}
{% endtabs %}

## Link Curvature

The `curvature` property controls the bend of the links, affecting the visual flow representation:

- **Value 0**: Creates straight lines between nodes
- **Value 0.5-0.7**: Creates moderate curves (often preferred for readability)
- **Value 1.0**: Creates maximum curvature with smooth paths

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sankey/links/link-curvature/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Link-curvature.cs" %}
{% include code-snippet/sankey/links/link-curvature/link-curvature.cs %}
{% endhighlight %}
{% endtabs %}

## Link Color Type

... (content preserved)
