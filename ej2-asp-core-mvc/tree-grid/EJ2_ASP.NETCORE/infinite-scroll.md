---
layout: post
title: Infinite Scroll in ##Platform_Name## Tree Grid Component
description: Learn here all about Infinite Scroll in Syncfusion ##Platform_Name## Tree Grid component and more.
platform: ej2-asp-core-mvc
control: Infinite Scroll
publishingplatform: ##Platform_Name##
documentation: ug
---


# Infinite scrolling

Infinite scrolling is used to load a huge amount of data without degrading the Tree Grid performance. This feature works like the lazy loading concept, which means the buffer data is loaded only when the scrollbar reaches the end of the scroller.

To use Infinite scrolling, set `enableInfiniteScrolling` property as true

> * In this feature, Tree Grid will not make a new data request when you visit the same page again.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/infinite-scroll/infinite/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Infinitescroll.cs" %}
{% include code-snippet/tree-grid/infinite-scroll/infinite/infinitescroll.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/infinite-scroll/infinite/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Infinitescroll.cs" %}
{% include code-snippet/tree-grid/infinite-scroll/infinite/infinitescroll.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## InitialBlocks

You can define the initial loading pages count by using `initialBlocks` property of `e-treegrid-infinitescrollsettings` tag helper. By default, this feature loads three pages in initial rendering.

In the below demo, we have changed this property value to load five page records instead of three.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/infinite-scroll/initialblocks/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Infinitescroll.cs" %}
{% include code-snippet/tree-grid/infinite-scroll/initialblocks/infinitescroll.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/infinite-scroll/initialblocks/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Infinitescroll.cs" %}
{% include code-snippet/tree-grid/infinite-scroll/initialblocks/infinitescroll.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Cache Mode

Cache is used to store the loaded rows object in the Tree Grid instance which can be reused for creating the row elements whenever you scroll to already visited page. Also, this mode maintains row elements based on the `maxBlocks` count value of `e-treegrid-infinitescrollsettings` tag helper, once this limit exceeds then it will remove row elements from DOM for new rows.

To enable the cache mode in Infinite scrolling, set `enableCache` property of `e-treegrid-infinitescrollsettings` tag helper as true.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/infinite-scroll/cache/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Infinitescroll.cs" %}
{% include code-snippet/tree-grid/infinite-scroll/cache/infinitescroll.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/infinite-scroll/cache/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Infinitescroll.cs" %}
{% include code-snippet/tree-grid/infinite-scroll/cache/infinitescroll.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Limitations for Infinite Scrolling

* Due to the element height limitation in browsers, the maximum number of records loaded by the tree grid is limited due to the browser capability.
* Initial loading rows total height must be greater than the viewport height.
* Cell selection will not be persisted in cache mode.
* Infinite scrolling is not compatible with batch editing, detail template and hierarchy features.
* The aggregated information and total group items are displayed based on the current view items. To get these information regardless of the view items, refer to the
* Programmatic selection using the [`selectRows`](../api/treegrid/#selectrows) and [`selectRow`](../api/treegrid/#selectrow) method is not supported in infinite scrolling.

> You can refer to our  [`ASP.NET Core Tree Grid`](https://www.syncfusion.com/aspnet-core-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our ASP.NET Core Tree Grid example [`ASP.NET Core Tree Grid example`](https://ej2.syncfusion.com/aspnetcore/TreeGrid/Overview#/material) to knows how to present and manipulate data.