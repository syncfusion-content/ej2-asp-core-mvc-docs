---
layout: post
title: Scrolling in ##Platform_Name## Syncfusion Spreadsheet Component
description: Learn here all about Scrolling in Syncfusion ##Platform_Name## Spreadsheet component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Scrolling
publishingplatform: ##Platform_Name##
documentation: ug
---


# Scrolling in Spreadsheet control

Scrolling helps you to move quickly to different areas of the worksheet. It moves faster if we use horizontal and vertical scroll bars. Scrolling can be enabled by setting the [`allowScrolling`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Spreadsheet.Spreadsheet.html#Syncfusion_EJ2_Spreadsheet_Spreadsheet_AllowScrolling) as true.

N> By default, the `allowScrolling` property is true.

You have the following options in Scrolling by using [`scrollSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Spreadsheet.Spreadsheet.html#Syncfusion_EJ2_Spreadsheet_Spreadsheet_ScrollSettings).

* Finite scrolling.
* Virtual scrolling.

## Finite Scrolling

Finite scrolling supports two type of modes in scrolling. You can use the `isFinite` property in [`scrollSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Spreadsheet.Spreadsheet.html#Syncfusion_EJ2_Spreadsheet_Spreadsheet_ScrollSettings) to specify the mode of scrolling.

* Finite - This mode does not create a new row/column when the scrollbar reaches the end. This can be achieved by setting the `isFinite` property as `true`.

* Infinite - This mode creates a new row/column when the scrollbar reaches the end. This can be achieved by setting the `isFinite`property as `false`.

N> By Default, the `isFinite` property is `false`.

## Virtual Scrolling

* Virtual scrolling allows you to load data that you require (load data based on viewport size) without buffering the entire huge database. You can set the `enableVirtualization` property in `scrollSettings` as `true`.

In virtual scrolling `enableVirtualization` is set to true means, it allows you to load the spreadsheet data while scrolling.

N> By Default, the `enableVirtualization` property is `true`.

**User Interface**:

You can scroll through the worksheet using one of the following ways,

* Using the `arrow` keys.
* Using the Horizontal and Vertical`scroll` bars.
* Using the `mouse` wheel.

## Finite scrolling with defined rows and columns

If you want to perform scrolling with defined rows and columns, you must define `rowCount` and `colCount` in the [`sheets`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Spreadsheet.Spreadsheet.html#Syncfusion_EJ2_Spreadsheet_Spreadsheet_Sheets) property and set `isFinite` as true and `enableVirtualization` as false in `scrollSettings`.

The following code example shows the finite scrolling with defined rows and columns in the spreadsheet. Here, we used rowCount as 20 and colCount as 20, after reaching the 20th row or 20th column you can't able to scroll.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/scrolling/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ScrollingController.cs" %}
{% include code-snippet/spreadsheet/scrolling/Core/scrollingController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/scrolling/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ScrollingController.cs" %}
{% include code-snippet/spreadsheet/scrolling/MVC/scrollingController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

