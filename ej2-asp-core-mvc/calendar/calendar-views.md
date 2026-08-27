---
layout: post
title: Calendar Views in ##Platform_Name## Calendar Control | Syncfusion
description: Learn here all about Calendar Views in Syncfusion ##Platform_Name## Calendar control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Calendar Views
publishingplatform: ##Platform_Name##
documentation: ug
---

# Calendar Views in Calendar Control

The Calendar has the following pre-defined views that provide a flexible way to navigate back and forth when selecting dates.

| **View** | **Description** |
| --- | --- |
| `month` (default) | Displays the days in a month. |
| `year` | Displays the months in a year. |
| `decade` | Displays the years in a decade. |

Defining the [start](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.DatePicker.html#Syncfusion_EJ2_Calendars_DatePicker_Start) property allows you to set the initial view rendered by the Calendar. 

The following example demonstrates how to set the `year` as the start view of the Calendar.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/calendar/calendar-view/views/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/calendar/calendar-view/views/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Views.cs" %}
{% include code-snippet/calendar/calendar-view/views/views.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Restricting calendar views

By defining the `start` and `depth` properties with different views, you can limit the drill-down and drill-up navigation available to the user. The Calendar will drill down to the view set in the [depth](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.Calendar.html#Syncfusion_EJ2_Calendars_Calendar_Depth) property and drill up to the view set in the [start](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.Calendar.html#Syncfusion_EJ2_Calendars_Calendar_Start) property. Both properties accept a `CalendarView` enum value (`Month`, `Year`, or `Decade`), ordered as `Month` < `Year` < `Decade`.

The following example displays the Calendar in `decade` view, and allows you to select a date in `month` view.

N> Depth view should always be smaller than the start view. If the `depth` and `start` views are the same, the Calendar view remains unchanged.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/calendar/calendar-view/restriction/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/calendar/calendar-view/restriction/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Restriction.cs" %}
{% include code-snippet/calendar/calendar-view/restriction/restriction.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-UG-Examples/tree/main/Calendar/CalendarUGSample).