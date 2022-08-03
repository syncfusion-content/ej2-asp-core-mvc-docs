---
layout: post
title: Render The Calendar With Week Numbers in ##Platform_Name## Calendar Control | Syncfusion
description: Learn here all about how to Render the Calendar with Week Numbers in Syncfusion ##Platform_Name## Calendar control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Render The Calendar With Week Numbers
publishingplatform: ##Platform_Name##
documentation: ug
---


# Render the Calendar with week numbers

You can enable `weekNumbers` in the Calendar by using the [weekNumber](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.Calendar.html#Syncfusion_EJ2_Calendars_Calendar_WeekNumber) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/calendar/howto/weeknumber/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Weeknumber.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/calendar/howto/weeknumber/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Weeknumber.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}

> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-UG-Examples/tree/main/Calendar/CalendarHowToSample).