---
layout: post
title: Loading Animation in Syncfusion ##Platform_Name## Tree Grid Component
description: Learn here all about Loading Animation in Syncfusion ##Platform_Name## Tree Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Loading Animation
publishingplatform: ##Platform_Name##
documentation: ug
---



# Loading Animation

The Tree Grid displays a loading indicator while the data is being fetched and bound to the tree grid during initial rendering, refreshing, and after performing any tree grid actions like sorting, filtering, and more.

The tree grid supports two indicator types, which can be enabled by setting the `loadingIndicator.indicatorType` property to Spinner or Shimmer. The default value of the indicator type is Spinner.

In the following sample, the Shimmer indicator is displayed while the tree grid is loading and refreshing when using the remote data.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/data-binding-core/loading-animation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="LoadingAnimation.cs" %}
{% include code-snippet/tree-grid/data-binding-core/loading-animation/loadingAnimation.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="LoadingAnimation.cs" %}
{% include code-snippet/tree-grid/data-binding-core/loading-animation/loadingAnimation.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You can refer to our  [`ASP.NET Core Tree Grid`](https://www.syncfusion.com/aspnet-core-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our ASP.NET Core Tree Grid example [`ASP.NET Core Tree Grid example`](https://ej2.syncfusion.com/aspnetcore/TreeGrid/Overview#/material) to knows how to present and manipulate data.
