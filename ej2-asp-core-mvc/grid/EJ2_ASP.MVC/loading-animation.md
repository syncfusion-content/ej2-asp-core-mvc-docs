---
layout: post
title: Loading Animation in Syncfusion ASP.NET MVC Grid Component
description: Learn here all about Loading Animation in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Loading Animation
publishingplatform: ##Platform_Name##
documentation: ug
---

# Loading Animation ASP.NET MVC Grid Component

The grid has an option to show a loading indicator in-between the time of fetching the data and binding it to the grid during initial rendering or refreshing or after performing any grid action like sorting, filtering, grouping, and more. The grid supports two indicator types, which is achieved by setting the `loadingIndicator.indicatorType` property to Spinner or Shimmer. The default value of the indicator type is "Spinner."

In the following sample, the Shimmer indicator is displayed while the grid is loading and refreshing when using the remote data.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/animation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Loading-Animation.cs" %}
{% include code-snippet/grid/data-binding/animation/animation.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/animation/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Loading-Animation.cs" %}
{% include code-snippet/grid/data-binding/animation/animation.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

