---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Infinite Scroll of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Infinite Scroll
publishingplatform: ##Platform_Name##
documentation: ug
---


# Infinite scrolling

Infinite scrolling is used to load a huge amount of data without degrading the Tree Grid performance. This feature works like the lazy loading concept, which means the buffer data is loaded only when the scrollbar reaches the end of the scroller.

To use Infinite scrolling, set `enableInfiniteScrolling` property as true

> * In this feature, Tree Grid will not make a new data request when you visit the same page again.

{% aspTab template="tree-grid/infinite-scroll/infinite", sourceFiles="infinitescroll.cs" %}

{% endaspTab %}

## InitialBlocks

You can define the initial loading pages count by using `initialBlocks` property of `e-treegrid-infinitescrollsettings` tag helper. By default, this feature loads three pages in initial rendering.

In the below demo, we have changed this property value to load five page records instead of three.

{% aspTab template="tree-grid/infinite-scroll/initialblocks", sourceFiles="infinitescroll.cs" %}

{% endaspTab %}

## Cache Mode

Cache is used to store the loaded rows object in the Tree Grid instance which can be reused for creating the row elements whenever you scroll to already visited page. Also, this mode maintains row elements based on the `maxBlocks` count value of `e-treegrid-infinitescrollsettings` tag helper, once this limit exceeds then it will remove row elements from DOM for new rows.

To enable the cache mode in Infinite scrolling, set `enableCache` property of `e-treegrid-infinitescrollsettings` tag helper as true.

{% aspTab template="tree-grid/infinite-scroll/cache", sourceFiles="infinitescroll.cs" %}

{% endaspTab %}

## Limitations for Infinite Scrolling

* Due to the element height limitation in browsers, the maximum number of records loaded by the tree grid is limited due to the browser capability.
* Initial loading rows total height must be greater than the viewport height.
* Cell selection will not be persisted in cache mode.
* Infinite scrolling is not compatible with batch editing, detail template and hierarchy features.
* The aggregated information and total group items are displayed based on the current view items. To get these information regardless of the view items, refer to the
* Programmatic selection using the [`selectRows`](../api/treegrid/#selectrows) and [`selectRow`](../api/treegrid/#selectrow) method is not supported in infinite scrolling.

> You can refer to our  [`ASP.NET Core Tree Grid`](https://www.syncfusion.com/aspnet-core-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our ASP.NET Core Tree Grid example [`ASP.NET Core Tree Grid example`](https://ej2.syncfusion.com/aspnetcore/TreeGrid/Overview#/material) to knows how to present and manipulate data.