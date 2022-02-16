---
layout: post
title: Scrolling in ##Platform_Name## Spreadsheet Component
description: Learn here all about Scrolling in Syncfusion ##Platform_Name## Spreadsheet component and more.
platform: ej2-asp-core-mvc
control: Scrolling
publishingplatform: ##Platform_Name##
documentation: ug
---


# Scrolling

Scrolling helps you to move quickly to different areas of the worksheet. It moves faster if we use horizontal and vertical scroll bars. Scrolling can be enabled by setting the [`allowScrolling`](../api/spreadsheet/#allowscrolling) as true.

> By default, the `allowScrolling` property is true.

You have the following options in Scrolling by using [`scrollSettings`](../api/spreadsheet/scrollSettings).

* Finite scrolling.
* Virtual scrolling.

## Finite Scrolling

Finite scrolling supports two type of modes in scrolling. You can use the [`isFinite`](../api/spreadsheet/scrollSettings/#isfinite) property in [`scrollSettings`](../api/spreadsheet/scrollSettings) to specify the mode of scrolling.

* Finite - This mode does not create a new row/column when the scrollbar reaches the end. This can be achieved by setting the [`isFinite`](../api/spreadsheet/scrollSettings/#isfinite) property as `true`.

* Infinite - This mode creates a new row/column when the scrollbar reaches the end. This can be achieved by setting the [`isFinite`](../api/spreadsheet/scrollSettings/#isfinite) property as `false`.

> By Default, the `isFinite` property is `false`.

## Virtual Scrolling

* Virtual scrolling allows you to load data that you require (load data based on viewport size) without buffering the entire huge database. You can set the `enableVirtualization` property in `scrollSettings` as `true`.

In virtual scrolling `enableVirtualization` is set to true means, it allows you to load the spreadsheet data while scrolling.

> By Default, the `enableVirtualization` property is `true`.

**User Interface**:

You can scroll through the worksheet using one of the following ways,

* Using the `arrow` keys.
* Using the Horizontal and Vertical`scroll` bars.
* Using the `mouse` wheel.

## Finite scrolling with defined rows and columns

If you want to perform scrolling with defined rows and columns, you must define `rowCount` and `colCount` in the [`sheets`](../api/spreadsheet/#sheets) property and set `isFinite` as true and `enableVirtualization` as false in `scrollSettings`.

The following code example shows the finite scrolling with defined rows and columns in the spreadsheet. Here, we used rowCount as 20 and colCount as 20, after reaching the 20th row or 20th column you can't able to scroll.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/scrolling/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ScrollingController.cs" %}
{% include code-snippet/spreadsheet/scrolling/scrollingController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/scrolling/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ScrollingController.cs" %}
{% include code-snippet/spreadsheet/scrolling/scrollingController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

