---
layout: post
title: Change The First Day Of Week in ##Platform_Name## Calendar Component
description: Learn here all about Change The First Day Of Week in Syncfusion ##Platform_Name## Calendar component and more.
platform: ej2-asp-core-mvc
control: Change The First Day Of Week
publishingplatform: ##Platform_Name##
documentation: ug
---


# Change the first day of the week

The Calendar provides an option to change the first day of the week by using the [firstDayOfWeek](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.Calendar.html#Syncfusion_EJ2_Calendars_Calendar_FirstDayOfWeek)
property. Generally, the day of the week starts from 0 (Sunday) and ends with 6 (Saturday).

> By default, the first day of the week is culture specific.

The following example shows the Calendar with `Tuesday` as the first day of the week.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/calendar/howto/firstday/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Firstday.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/calendar/howto/firstday/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Firstday.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}

