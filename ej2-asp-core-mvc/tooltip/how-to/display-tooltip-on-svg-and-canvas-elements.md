---
layout: post
title: Display Tooltip On Svg And Canvas Elements in ##Platform_Name## Tooltip Component
description: Learn here all about Display Tooltip On Svg And Canvas Elements in Syncfusion ##Platform_Name## Tooltip component and more.
platform: ej2-asp-core-mvc
control: Display Tooltip On Svg And Canvas Elements
publishingplatform: ##Platform_Name##
documentation: ug
---

# Display Tooltip on SVG and canvas elements

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

