---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Period Selector of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Period Selector
publishingplatform: ##Platform_Name##
documentation: ug
---


# Period selector

The period selector allows to select a range with specified periods. By default the period selector is enabled in stock chart.

## Periods

<!-- markdownlint-disable MD034 -->

Periods is an array of objects that allows users to specify the range of [`Periods`] (https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChart.html#Syncfusion_EJ2_Charts_StockChart_Periods). The `Interval` property specifies the count value of the button, and the `Text` property specifies the text to be displayed on button. The `IntervalType` property allows users to customize the intervals of the buttons. The `IntervalType` property supports the following interval types:

* Auto
* Years
* Quarter
* Months
* Weeks
* Days
* Hours
* Minutes
* Seconds

{% aspTab template="stock-chart/getting-started/period", sourceFiles="period.cs" %}

{% endaspTab %}

## Visibility of period selector

The [`EnablePeriodSelector`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChart.html#Syncfusion_EJ2_Charts_StockChart_EnablePeriodSelector) property allows users to toggle the visibility of period selector.

{% aspTab template="stock-chart/getting-started/visiblityperiod", sourceFiles="visiblityperiod.cs" %}

{% endaspTab %}