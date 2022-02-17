---
layout: post
title: Select A Sequence Of Dates In Calendar in ##Platform_Name## Calendar Component
description: Learn here all about Select A Sequence Of Dates In Calendar in Syncfusion ##Platform_Name## Calendar component and more.
platform: ej2-asp-core-mvc
control: Select A Sequence Of Dates In Calendar
publishingplatform: ##Platform_Name##
documentation: ug
---


# Select a sequence of dates in Calendar

The following example demonstrates how to select the week dates of chosen date in the Calendar using [values](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.Calendar.html#Syncfusion_EJ2_Calendars_Calendar_Values) property, when [isMultiSelection](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.Calendar.html#Syncfusion_EJ2_Calendars_Calendar_IsMultiSelection) property is enabled. Methods of Moment.js is used in this sample for calculating the start and end of week from the selected date.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/calendar/multi-select/multi-moment/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Multi.cs" %}
{% include code-snippet/calendar/multi-select/multi-moment/multi.cs %}
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

