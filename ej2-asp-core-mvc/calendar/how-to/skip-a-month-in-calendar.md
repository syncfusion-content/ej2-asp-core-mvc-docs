---
layout: post
title: Skip A Month In Calendar in ##Platform_Name## Calendar Component
description: Learn here all about Skip A Month In Calendar in Syncfusion ##Platform_Name## Calendar component and more.
platform: ej2-asp-core-mvc
control: Skip A Month In Calendar
publishingplatform: ##Platform_Name##
documentation: ug
---


# Skip a month in the Calendar

The following example demonstrates how to skip a month in the Calendar while clicking the previous and next icons. In the example below,  the [navigated](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.Calendar.html#Syncfusion_EJ2_Calendars_Calendar_Navigated) event is used to skip a month with [navigateTo](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.Calendar.html#Syncfusion_EJ2_Calendars_Calendar_Navigated)
  method.

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

