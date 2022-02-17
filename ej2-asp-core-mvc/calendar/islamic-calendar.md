---
layout: post
title: Islamic Calendar in ##Platform_Name## Calendar Component
description: Learn here all about Islamic Calendar in Syncfusion ##Platform_Name## Calendar component and more.
platform: ej2-asp-core-mvc
control: Islamic Calendar
publishingplatform: ##Platform_Name##
documentation: ug
---


# Islamic-Calendar

In addition to the Gregorian calendar, the Calendar control supports displaying the Islamic calendar (Hijri calendar). **Islamic calendar** or **Hijri calendar** is a `lunar calendar` consisting of 12 months in a year of 354 or 355 days. To know more about Islamic calendar, please refer this [wikipedia](https://en.wikipedia.org/wiki/Islamic_calendar).

Also, it consists of all Gregorian calendar functionalities as like min and max date, week number, start day of the week, multi selection, enable RTL, start and depth view, localization, highlight and customize the specific dates.

By default, calendar mode is in **Gregorian**. You can enable the Islamic mode by setting the **calendarMode** as **Islamic**.

The following example demonstrates how to display the Islamic Calendar (Hijri Calendar).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/calendar/islamic-mode/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Islamic-mode.cs" %}
{% include code-snippet/calendar/islamic-mode/islamic-mode.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/calendar/islamic-mode/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Islamic-mode.cs" %}
{% include code-snippet/calendar/islamic-mode/islamic-mode.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

