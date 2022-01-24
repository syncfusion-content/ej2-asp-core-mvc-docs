---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Series Visible of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Series Visible
publishingplatform: ##Platform_Name##
documentation: ug
---


<!-- markdownlint-disable MD036 -->

# Show series based on respective legend click

By using the `chartMouseClick` event, you can show the series based on respective legend click. In this event, you can get the legend target id, using which you can get the current series index. Based on the index, you can set value of `visible` to `true` or `false`.

{% aspTab template="chart/series/column/series-visible", sourceFiles="series-visible.cs" %}

{% endaspTab %}