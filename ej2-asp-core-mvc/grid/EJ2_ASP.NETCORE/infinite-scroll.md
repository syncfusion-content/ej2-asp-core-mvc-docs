---
layout: post
title: Infinite Scroll in Syncfusion ASP.NET Core Grid Control | Syncfusion
description: Learn here all about Infinite Scroll in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Infinite Scroll
publishingplatform: ##Platform_Name##
documentation: ug
---


# Infinite scrolling in ASP.NET Core Grid Component

Infinite scrolling is used to load a huge amount of data without degrading the Grid performance. This feature works like the lazy loading concept, which means the buffer data is loaded only when the scrollbar reaches the end of the scroller.

To enable Infinite scrolling, set `enableInfiniteScrolling` property as true.

N> * In this feature, Grid will not make a new data request when you visit the same page again.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/infinite-scroll-normal/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Infinite-scroll-normal.cs" %}
{% include code-snippet/grid/infinite-scroll-normal/infinite-scroll-normal.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/infinite-scroll-normal/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Infinite-scroll-normal.cs" %}
{% include code-snippet/grid/infinite-scroll-normal/infinite-scroll-normal.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## InitialBlocks

You can define the initial loading pages count by using `infiniteScrollSettings.initialBlocks` property. By default, this feature loads three pages in initial rendering.

In the below demo, we have changed this property value to load five page records instead of three.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/infinite-scroll-initialblocks/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Infinite-scroll-initialblocks.cs" %}
{% include code-snippet/grid/infinite-scroll-initialblocks/infinite-scroll-initialblocks.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/infinite-scroll-initialblocks/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Infinite-scroll-initialblocks.cs" %}
{% include code-snippet/grid/infinite-scroll-initialblocks/infinite-scroll-initialblocks.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Cache Mode

Cache is used to store the loaded rows object in the Grid instance which can be reused for creating the row elements whenever you scroll to already visited page. Also, this mode maintains row elements based on the `infiniteScrollSettings.maxBlocks` count value, once this limit exceeds then it will remove row elements from DOM for new rows.

To enable the cache mode in Infinite scrolling, set `infiniteScrollSettings.enableCache` property as true.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/infinite-scroll-cache/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Infinite-scroll-cache.cs" %}
{% include code-snippet/grid/infinite-scroll-cache/infinite-scroll-cache.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/infinite-scroll-cache/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Infinite-scroll-cache.cs" %}
{% include code-snippet/grid/infinite-scroll-cache/infinite-scroll-cache.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Limitations for Infinite Scrolling

* Due to the element height limitation in browsers, the maximum number of records loaded by the grid is limited due to the browser capability.
* Initial loading rows total height must be greater than the viewport height.
* Cell selection will not be persisted in cache mode.
* Infinite scrolling is not compatible with batch editing, detail template, autofill and hierarchy features.
* The group records cannot be collapsed in cache mode.
* The aggregated information and total group items are displayed based on the current view items. To get these information regardless of the view items, refer to the
[`Group with Page`](./grouping/#Group-with-paging) topic.
* Programmatic selection using the [`selectRows`](https://ej2.syncfusion.com/documentation/api/grid/#selectrows) and [`selectRow`](https://ej2.syncfusion.com/documentation/api/grid/#selectrow) method is not supported in infinite scrolling.
* Limitations of row drag and drop with infinite scrolling
    1. In cache mode, the grid refreshes automatically if the content's **tr** element count exceeds the cache limit of the grid's content after the drop action.
    2. When performing row drag and drop with lazy load grouping, the grid will refresh automatically.
    3. In remote data, changes are applied only in the UI. They will be lost once the grid is refreshed. To restore them, you need to update the changes in your database. By using the [rowDrop](https://ej2.syncfusion.com/aspnetcore/documentation/api/grid/#rowdrop) event, you can send the request to the server and apply the changes in your database. After this, you need to refresh the grid to show the updated data.
* Limitations of column virtualization with infinite scrolling in this documentation link [here](https://ej2.syncfusion.com/aspnetcore/documentation/grid/virtual-scroll#limitations-for-virtual-scrolling)