---
layout: post
title: Loading Animation in Syncfusion ##Platform_Name## Gantt Component
description: Learn here all about Loading Animation in Syncfusion ##Platform_Name## Gantt component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Loading Animation
publishingplatform: ##Platform_Name##
documentation: ug
---


# Loading Animation

The gantt has an option to show a loading indicator in-between the time of fetching the data and binding it to the gantt during initial rendering, refreshing or after performing any gantt action like sorting, filtering, virtual scroll and more. The gantt support two indicator types, which is achieved by setting the [`loadingIndicator.indicatorType`] property to Shimmer or Spinner. The default value of the indicator type is "Spinner."

In the following sample, the Shimmer indicator is displayed while the gantt is scrolled when using the virtual data.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/loading-animation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Loading-animation.cs" %}
{% include code-snippet/gantt/loading-animation/loading-animation.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/loading-animation/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Loading-animation.cs" %}
{% include code-snippet/gantt/loading-animation/loading-animation.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

