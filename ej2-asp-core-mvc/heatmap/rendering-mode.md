---
layout: post
title: Rendering Mode in ##Platform_Name## Heatmap Component
description: Learn here all about Rendering Mode in Syncfusion ##Platform_Name## Heatmap component and more.
platform: ej2-asp-core-mvc
control: Rendering Mode
publishingplatform: ##Platform_Name##
documentation: ug
---


# Rendering mode

Heat map can be displayed using `Canvas` or `Scalable Vector Graphics (SVG)` rendering logic to improve the initial load performance and scalability. Heat map can also be automatically switched between `Canvas` and `SVG` modes based on dataset size. You can enable this mode by setting the [`renderingMode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMap~RenderingMode.html) property to `Auto`.

> If the `Auto` mode is enabled in the heat map and there are more than 10,000 data points, then the heat map will be rendered in a `Canvas` mode; Otherwise, the heat map will be rendered in a `SVG` mode.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/rendering-mode/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Rendering-mode.cs" %}
{% include code-snippet/heatmap/rendering-mode/rendering-mode.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/rendering-mode/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Rendering-mode.cs" %}
{% include code-snippet/heatmap/rendering-mode/rendering-mode.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

