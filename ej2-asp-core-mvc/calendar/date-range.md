---
layout: post
title: Date Range in ASP.NET Core Calendar Control | Syncfusion
description: Learn here all about Date Range in Syncfusion ASP.NET Core Calendar control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Date Range
publishingplatform: ej2-asp-core-mvc
documentation: ug
---


# Date Range in Calendar Control

[ASP.NET Core Calendar](https://www.syncfusion.com/aspnet-core-ui-controls/calendar) provides an option to select a date value within a specified range by defining the [min](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.Calendar.html#Syncfusion_EJ2_Calendars_Calendar_Min) and [max](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.Calendar.html#Syncfusion_EJ2_Calendars_Calendar_Max) properties. The min date should always be lesser than the max date. If the value of `min` or `max` properties are changed through code behind, then update the `value` property to be set within the specified range. Or else, if the value is out of specified date range and less than `min` date, value property will be updated with min date or the value is higher than max date, value property will be updated with `max` date.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/calendar/daterange/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/calendar/daterange/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Daterange.cs" %}
{% include code-snippet/calendar/daterange/daterange.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-UG-Examples/tree/main/Calendar/CalendarUGSample).