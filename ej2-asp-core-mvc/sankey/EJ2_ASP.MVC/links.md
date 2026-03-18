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

The `LinkStyle` property allows you to customize the visual appearance of all links in the Sankey Chart. These properties control opacity, highlighting behavior, curvature, and color blending.

### Link Style Configuration Properties

| Property | Type | Default | Description |
|----------|------|---------|-------------|
| opacity | number | 0.35 | Opacity of the link (0 to 1). |
| highlightOpacity | number | 1 | Opacity of link when highlighted or hovered. |
| inactiveOpacity | number | 0.3 | Opacity of link when not interacting (when other links are hovered). |
| curvature | number | 0.55 | Curvature factor of the link path (0 = straight line, 1 = fully curved). |
| colorType | string | 'Blend' | Color blending type: 'Source', 'Target', or 'Blend'. |

## Basic Link Customization

Customize the appearance of all links using the `LinkStyle` property to set global opacity levels, curvature, and color blending behavior:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sankey/links/basic-links/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Basic-links.cs" %}
{% include code-snippet/sankey/links/basic-links/basic-links.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sankey/links/basic-links/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Basic-links.cs" %}
{% include code-snippet/sankey/links/basic-links/basic-links.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}

## Link Curvature

The `Curvature` property controls the bend of the links, affecting the visual flow representation:

- **Value 0**: Creates straight lines between nodes
- **Value 0.5-0.7**: Creates moderate curves (often preferred for readability)
- **Value 1.0**: Creates maximum curvature with smooth paths

Choose curvature values based on your data density and aesthetic preferences:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sankey/links/link-curvature/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Link-curvature.cs" %}
{% include code-snippet/sankey/links/link-curvature/link-curvature.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sankey/links/link-curvature/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Link-curvature.cs" %}
{% include code-snippet/sankey/links/link-curvature/link-curvature.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}

## Link Color Type

The `ColorType` property determines how links are colored, providing flexibility in visual representation:

- **'Source'**: Links inherit the color of their source node (useful for tracking origin)
- **'Target'**: Links inherit the color of their target node (useful for tracking destination)
- **'Blend'**: Links display a smooth gradient blend of source and target node colors (default - recommended for most cases)

The color type you choose affects how users perceive flow relationships in the diagram:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sankey/links/link-color-type/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Link-color-type.cs" %}
{% include code-snippet/sankey/links/link-color-type/link-color-type.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sankey/links/link-color-type/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Link-color-type.cs" %}
{% include code-snippet/sankey/links/link-color-type/link-color-type.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}

## Link Value and Thickness

The link thickness is determined by the `Value` property in the link data. This quantitative value is automatically mapped to the visual thickness of the link:

- **Larger values**: Create thicker links (proportional to the value)
- **Smaller values**: Create thinner links
- **Equal values**: Create links of equal thickness

The thickness visualization makes it easy to understand relative flow quantities at a glance:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sankey/links/link-value-thickness/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Link-value-thickness.cs" %}
{% include code-snippet/sankey/links/link-value-thickness/link-value-thickness.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sankey/links/link-value-thickness/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Link-value-thickness.cs" %}
{% include code-snippet/sankey/links/link-value-thickness/link-value-thickness.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}

## Advanced Link Configuration

### Dynamic Link Customization

Use the `LinkRendering` event to customize link appearance dynamically during the render process. This event is triggered for each link before rendering, allowing you to apply conditional styling based on flow values, source-target combinations, or other data attributes:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sankey/links/dynamic-link/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Dynamic-link.cs" %}
{% include code-snippet/sankey/links/dynamic-link/dynamic-link.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sankey/links/dynamic-link/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Dynamic-link.cs" %}
{% include code-snippet/sankey/links/dynamic-link/dynamic-link.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}