<!-- Converted from: sankey/EJ2_ASP.MVC/labels.md -->

---
layout: post
title: Labels in ##Platform_Name## Sankey Chart Component
description: Learn here all about Labels in Syncfusion ##Platform_Name## Sankey Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Labels
publishingplatform: ##Platform_Name##
documentation: ug
---

# Labels in React Sankey Chart component

Labels display descriptive text associated with nodes in the Sankey Chart, making the diagram more understandable and interpretable. The Sankey Chart provides comprehensive label customization options including visibility control, font styling, individual label configuration, and dynamic rendering events.

This guide covers label appearance configuration, visibility control, font styling, and advanced label customization.

## Label Settings Properties

The `labelSettings` property provides options to control label appearance, text styling, and visibility. These properties apply globally to all node labels.

### Label Configuration Properties

| Property | Type | Default | Description |
|----------|------|---------|-------------|
| visible | boolean | true | Shows or hides all node labels. |
| fontSize | string \| number | '12px' | Font size of the labels. |
| color | string | '' | Text color of the labels. |
| fontFamily | string | null | Font family for the label text. |
| fontWeight | string | '400' | Font weight (e.g., '400' for normal, '700' for bold). |
| fontStyle | string | 'normal' | Font style (e.g., 'normal' or 'italic'). |
| padding | number | 10 | Space around the label text. |

Configure global label styling for all nodes by setting properties like font size, color, font family, and font weight

Here is an example of customizing label appearance:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sankey/labels/label-configuration/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Label-configuration.cs" %}
{% include code-snippet/sankey/labels/label-configuration/label-configuration.cs %}
{% endhighlight %}
{% endtabs %}

## Hiding Labels

Control label visibility using the `visible` property in `labelSettings`. Set it to `false` to hide all node labels, which can be useful for creating cleaner visualizations when labels take up too much space:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sankey/labels/hiding-labels/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Hiding-labels.cs" %}
{% include code-snippet/sankey/labels/hiding-labels/hiding-labels.cs %}
{% endhighlight %}
{% endtabs %}

## Font Styling

Apply custom font styling to all labels using properties such as:

- **`fontSize`**: Adjust text size (e.g., '12px', '14px')
- **`fontFamily`**: Specify font family (e.g., 'Arial', 'Times New Roman')
- **`fontWeight`**: Control text thickness ('400' = normal, '700' = bold)
- **`fontStyle`**: Apply text styling ('normal' or 'italic')
- **`color`**: Set text color (hex or color names)

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sankey/labels/font-style/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Font-style.cs" %}
{% include code-snippet/sankey/labels/font-style/font-style.cs %}
{% endhighlight %}
{% endtabs %}

## Individual Node Labels

Customize the appearance of specific node labels by configuring the `label` property on each node object. This allows you to override global label settings for specific nodes, enabling data-driven label customization:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sankey/labels/individual-node-labels/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Individual-node-labels.cs" %}
{% include code-snippet/sankey/labels/individual-node-labels/individual-node-labels.cs %}
{% endhighlight %}
{% endtabs %}

## Advanced Label Configuration

... (content preserved)
