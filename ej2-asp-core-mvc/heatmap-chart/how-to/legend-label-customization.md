---
layout: post
title: How to customize legend label in ##Platform_Name## HeatMap Chart | Syncfusion
description: Learn here all about Legend Label Customization in Syncfusion ##Platform_Name## Heatmap Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Legend Label Customization
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to customize legend label in ##Platform_Name## HeatMap Chart

You can change the legend label using the `LegendRender` client-side event. You can also hide the legend label using this client-side event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/how-to/legend/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/heatmap/how-to/legend/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/how-to/legend/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/heatmap/how-to/legend/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

