---
layout: post
title: Skip A Month in Calendar in ##Platform_Name## Calendar | Syncfusion
description: Learn here all about how to skip a month in Calendar in Syncfusion ##Platform_Name## Calendar control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Skip A Month in Calendar
publishingplatform: ##Platform_Name##
documentation: ug
---

# Skip a Month in the Calendar

The following example demonstrates how to skip a month in the Calendar when the previous or next navigation icons are clicked. In the example below, the [navigated](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.Calendar.html#Syncfusion_EJ2_Calendars_Calendar_Navigated) event is used to skip a month using the [navigateTo](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.Calendar.html#Syncfusion_EJ2_Calendars_Calendar_NavigateTo) method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/calendar/howto/skipmonth/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Skipmonth.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/calendar/howto/skipmonth/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Skipmonth.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-UG-Examples/tree/main/Calendar/CalendarHowToSample).