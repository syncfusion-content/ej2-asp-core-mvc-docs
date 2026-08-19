---
layout: post
title: How to display Tooltip on SVG and canvas elements in ##Platform_Name## Tooltip | Syncfusion
description: Display the Syncfusion ##Platform_Name## Tooltip on SVG and canvas elements by directly attaching the visualization targets for data hover tooltips.
platform: ej2-asp-core-mvc
control: Display Tooltip On Svg And Canvas Elements
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to display Tooltip on SVG and canvas elements in ##Platform_Name## Tooltip

Tooltip can be displayed on both SVG and Canvas elements. You can directly attach the `<svg>` or `<canvas>` elements to show tooltips on data visualization elements.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tooltip/svg-canvas/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Svg-canvas.cs" %}
{% include code-snippet/tooltip/svg-canvas/svg-canvas.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tooltip/svg-canvas/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Svg-canvas.cs" %}
{% include code-snippet/tooltip/svg-canvas/svg-canvas.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

