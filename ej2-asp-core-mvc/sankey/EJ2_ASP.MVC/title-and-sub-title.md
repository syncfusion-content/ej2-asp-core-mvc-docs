---
layout: post
title: Title and Subtitle in ##Platform_Name## Sankey Chart Component
description: Learn here all about Title and Subtitle in Syncfusion ##Platform_Name## Sankey Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Title and Subtitle
publishingplatform: ##Platform_Name##
documentation: ug
---

# Title and Subtitle in React Sankey Chart component

The Sankey Chart supports adding descriptive titles and subtitles to provide context and information about your data visualization. These text elements help users quickly understand the purpose and content of the diagram. You can fully customize the text, styling, alignment, and appearance using dedicated properties.

This guide covers title and subtitle configuration, styling options, and best practices for effective diagram labeling.

## Title and Subtitle Properties

| Property | Type | Description |
|----------|------|-------------|
| title | string | The main title text displayed at the top of the chart. |
| subTitle | string | The subtitle text displayed below the main title. |
| titleStyle | object | Styling options for the title text. |
| subTitleStyle | object | Styling options for the subtitle text. |

## Title/Subtitle Style Properties

Both `titleStyle` and `subTitleStyle` support the following properties:

| Property | Type | Default | Description |
|----------|------|---------|-------------|
| size | string | null | Font size for the text. |
| fontWeight | string | null | Font weight (e.g., '400', '700'). |
| fontFamily | string | null | Font family name. |
| color | string | null | Text color. |
| fontStyle | string | 'normal' | Font style ('normal' or 'italic'). |
| opacity | number | 1 | Text opacity (0 to 1). |
| textAlignment | string | 'Center' | Text alignment ('Left', 'Center', 'Right'). |

## Basic Title and Subtitle

Add a main title and descriptive subtitle to your Sankey Chart to provide context about the data visualization:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sankey/title-subtitle/title-subtitle/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Title-subtitle.cs" %}
{% include code-snippet/sankey/title-subtitle/title-subtitle/title-subtitle.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sankey/title-subtitle/title-subtitle/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Title-subtitle.cs" %}
{% include code-snippet/sankey/title-subtitle/title-subtitle/title-subtitle.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}

## Customized Title and Subtitle Styling

Apply custom styling to both the title and subtitle including font properties, colors, alignment, and opacity to match your design requirements:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sankey/title-subtitle/customized-title-subtitle/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Customized-title-subtitle.cs" %}
{% include code-snippet/sankey/title-subtitle/customized-title-subtitle/customized-title-subtitle.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sankey/title-subtitle/customized-title-subtitle/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Customized-title-subtitle.cs" %}
{% include code-snippet/sankey/title-subtitle/customized-title-subtitle/customized-title-subtitle.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}

## Title Only (Without Subtitle)

Add only a title to the Sankey Chart when a subtitle is not needed. This provides a clean, minimal header for your visualization:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sankey/title-subtitle/title-only/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Title-only.cs" %}
{% include code-snippet/sankey/title-subtitle/title-only/title-only.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sankey/title-subtitle/title-only/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Title-only.cs" %}
{% include code-snippet/sankey/title-subtitle/title-only/title-only.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}

## Title with Different Alignments

Control the alignment of title and subtitle text:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sankey/title-subtitle/title-different-alignments/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Title-different-alignments.cs" %}
{% include code-snippet/sankey/title-subtitle/title-different-alignments/title-different-alignments.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sankey/title-subtitle/title-different-alignments/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Title-different-alignments.cs" %}
{% include code-snippet/sankey/title-subtitle/title-different-alignments/title-different-alignments.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}

## Title Best Practices

- **Descriptive**: Use clear, descriptive titles that explain what the chart shows
- **Concise**: Keep titles brief and to the point
- **Hierarchy**: Make the title larger and bolder than the subtitle for visual hierarchy
- **Readability**: Ensure sufficient contrast between text color and background
- **Font Choice**: Use readable fonts like Segoe UI, Arial, or Verdana
