---
layout: post
title: Sequence of Dates in ##Platform_Name## Calendar | Syncfusion
description: Learn here all about how to select a sequence of dates in the Calendar in Syncfusion ##Platform_Name## Calendar control of Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Select a Sequence of Dates in Calendar
publishingplatform: ##Platform_Name##
documentation: ug
---

# Select a Sequence of Dates in Calendar

The following example demonstrates how to select the week dates of the chosen date in the Calendar using the [values](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.Calendar.html#Syncfusion_EJ2_Calendars_Calendar_Values) property, when the [isMultiSelection](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.Calendar.html#Syncfusion_EJ2_Calendars_Calendar_IsMultiSelection) property is enabled. Methods of Moment.js are used in this sample for calculating the start and end of the week from the selected date.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/calendar/multi-select/multi-moment/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/calendar/multi-select/multi-moment/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Multi.cs" %}
{% include code-snippet/calendar/multi-select/multi-moment/multi.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-UG-Examples/tree/main/Calendar/CalendarHowToSample).