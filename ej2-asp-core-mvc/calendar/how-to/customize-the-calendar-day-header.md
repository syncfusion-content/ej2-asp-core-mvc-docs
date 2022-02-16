---
layout: post
title: Customize The Calendar Day Header in ##Platform_Name## Calendar Component
description: Learn here all about Customize The Calendar Day Header in Syncfusion ##Platform_Name## Calendar component and more.
platform: ej2-asp-core-mvc
control: Customize The Calendar Day Header
publishingplatform: ##Platform_Name##
documentation: ug
---


# Customize the calendar day header

You can change the format of the day that to be displayed in header using [`dayHeaderFormat`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.Calendar.html#Syncfusion_EJ2_Calendars_Calendar_DayHeaderFormat) property.

> By default, the format is `Short`.

You can find the possible formats on below.

| **Name** | **Description** |
|------|---------------------|
| `Short` | Sets the short format of day name (like Su ) in day header. |
| `Narrow` | Sets the single character of day name (like S ) in day header. |
| `Abbreviated` | Sets the min format of day name (like Sun ) in day header. |
| `Wide` | Sets the long format of day name (like Sunday ) in day header. |

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/calendar/howto/headerformat/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Headerformat.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/calendar/howto/headerformat/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Headerformat.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



Output be like the below.

![calendar](../images/narrow.png)

![calendar](../images/abbreviated.png)