---
layout: post
title: Labels in ##Platform_Name## Sankey Chart Component
description: Learn here all about Labels in Syncfusion ##Platform_Name## Sankey Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Labels
publishingplatform: ##Platform_Name##
documentation: ug
---

# Labels in ##Platform_Name## Sankey Chart component

Labels display descriptive text associated with nodes in the Sankey Chart, making the diagram more understandable and interpretable. The Sankey Chart provides comprehensive label customization options including visibility control, font styling, individual label configuration, and dynamic rendering events.

This guide covers label appearance configuration, visibility control, font styling, and advanced label customization.

## Label Settings Properties

The `LabelSettings` property provides options to control label appearance, text styling, and visibility. These properties apply globally to all node labels.

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

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sankey/labels/label-configuration/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Label-configuration.cs" %}
{% include code-snippet/sankey/labels/label-configuration/label-configuration.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sankey/labels/label-configuration/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Label-configuration.cs" %}
{% include code-snippet/sankey/labels/label-configuration/label-configuration.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}

## Hiding Labels

Control label visibility using the `Visible` property in `LabelSettings`. Set it to `false` to hide all node labels, which can be useful for creating cleaner visualizations when labels take up too much space:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sankey/labels/hiding-labels/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Hiding-labels.cs" %}
{% include code-snippet/sankey/labels/hiding-labels/hiding-labels.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sankey/labels/hiding-labels/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Hiding-labels.cs" %}
{% include code-snippet/sankey/labels/hiding-labels/hiding-labels.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}

## Font Styling

Apply custom font styling to all labels using properties such as:

- **`FontSize`**: Adjust text size (e.g., '12px', '14px')
- **`FontFamily`**: Specify font family (e.g., 'Arial', 'Times New Roman')
- **`FontWeight`**: Control text thickness ('400' = normal, '700' = bold)
- **`FontStyle`**: Apply text styling ('normal' or 'italic')
- **`Color`**: Set text color (hex or color names)

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sankey/labels/font-style/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Font-style.cs" %}
{% include code-snippet/sankey/labels/font-style/font-style.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sankey/labels/font-style/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Font-style.cs" %}
{% include code-snippet/sankey/labels/font-style/font-style.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}

## Individual Node Labels

Customize the appearance of specific node labels by configuring the `Label` property on each node object. This allows you to override global label settings for specific nodes, enabling data-driven label customization:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sankey/labels/individual-node-labels/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Individual-node-labels.cs" %}
{% include code-snippet/sankey/labels/individual-node-labels/individual-node-labels.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sankey/labels/individual-node-labels/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Individual-node-labels.cs" %}
{% include code-snippet/sankey/labels/individual-node-labels/individual-node-labels.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}

## Advanced Label Configuration

### Dynamic Label Customization

Use the `LabelRendering` event to customize label text, styling, and appearance dynamically during the render process. This event is triggered for each label before rendering, allowing you to apply conditional formatting, modify text, or adjust styling based on data values:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sankey/labels/dynamic-label/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Dynamic-label.cs" %}
{% include code-snippet/sankey/labels/dynamic-label/dynamic-label.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sankey/labels/dynamic-label/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Dynamic-label.cs" %}
{% include code-snippet/sankey/labels/dynamic-label/dynamic-label.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}