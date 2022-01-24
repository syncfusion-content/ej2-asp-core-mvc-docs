---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Enable Scroll Option On All Day Section of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Enable Scroll Option On All Day Section
publishingplatform: ##Platform_Name##
documentation: ug
---


# Enable scroll option on all-day section

When you have larger number of appointments in all-day row, it is difficult to view all the appointments properly. In that case you can enable scroller option for all-day row by setting true to `enableAllDayScroll` whereas its default value is false. When setting this property to true, individual scroller for all-day row is enabled when it reaches its maximum height on expanding.

> Note: This property is not applicable for Scheduler with height `auto`.

{% aspTab template="schedule/how-to/all-day-scroll", sourceFiles="data.cs"  %}

{% endaspTab %}