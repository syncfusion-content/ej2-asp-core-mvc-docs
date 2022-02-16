---
layout: post
title: Working Days in ##Platform_Name## Schedule Component
description: Learn here all about Working Days in Syncfusion ##Platform_Name## Schedule component and more.
platform: ej2-asp-core-mvc
control: Working Days
publishingplatform: ##Platform_Name##
documentation: ug
---


# Setting working days and hours

The Scheduler can be customized on various aspects as well as it inherits almost all the calendar-specific features such as options,

* To set custom time range display on Scheduler
* To set different working hours
* To set different working days
* To set different first day of week
* To show/hide weekend days
* To show the week number

## Set working days

By default, Scheduler considers the week days from Monday to Friday as `Working days` and therefore defaults to [1,2,3,4,5] - where 1 represents Monday, 2 represents Tuesday and so on. The days which are not defined in this working days collection are considered as non-working days. Therefore, when the weekend days are set to hide from Scheduler, all those non-working days too gets hidden from the layout.

The Work week and Timeline Work week views displays exactly the defined working days on Scheduler layout, whereas other views displays all the days and simply differentiates the non-working days on UI with inactive cell color.

> The working or business hours depiction on Scheduler are usually valid only on these specified working days.

The following example code depicts how to set the Scheduler to display Monday, Wednesday and Friday as working days of a week.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/schedule/working-days/work-days/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/working-days/work-days/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/schedule/working-days/work-days/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/working-days/work-days/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Hiding weekend days

The `ShowWeekend` property is used to either show or hide the weekend days of a week and it is not applicable on Work week view (as non-working days are usually not displayed on work week view). By default, it is set to `true`. The days which are not a part of the working days collection of a Scheduler are usually considered as non-working or weekend days.

Here, the working days are defined as [1, 3, 4, 5] on Scheduler and therefore the remaining days (0, 2, 6 – Sunday, Tuesday and Saturday) are considered as non-working or weekend days and will be hidden from all the views when `ShowWeekend` property is set to `false`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/schedule/working-days/hide-weekend/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/working-days/hide-weekend/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/schedule/working-days/hide-weekend/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/working-days/hide-weekend/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Show week numbers

It is possible to show the week number count of a week in the header bar of the Scheduler by setting true to `ShowWeekNumber` property. By default, its default value is `false`. In Month view, the week numbers are displayed as a first column.

> The `ShowWeekNumber` property is not applicable on Timeline views, as it has the equivalent [HeaderRows](./header-rows/#display-week-numbers-in-timeline-views) property to handle such requirement with additional customization.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/schedule/working-days/week-number/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/working-days/week-number/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/schedule/working-days/week-number/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/working-days/week-number/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Different options in showing week numbers

By default, week numbers are shown in the Scheduler based on the first day of the year. However, the week numbers can be determined based on the following criteria.

`FirstDay` – The first week of the year is calculated based on the first day of the year.

`FirstFourDayWeek` – The first week of the year begins from the first week with four or more days.

`FirstFullWeek` – The first week of the year begins when meeting the first day of the week (firstDayOfWeek) and the first day of the year.

For more details refer to [this link](https://docs.microsoft.com/en-us/dotnet/api/system.globalization.calendarweekrule?view=net-5.0#remarks)

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/schedule/working-days/week-rule/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/working-days/week-rule/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/schedule/working-days/week-rule/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/working-days/week-rule/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Note**: Enable the `showWeekNumber` property to configure the `weekRule` property. Also, the weekRule property depends on the value of the `firstDayOfWeek` property.

## Set working hours

Working hours indicates the work hour limit within the Scheduler, which is visually highlighted with an active color on work cells. The working hours can be set on Scheduler using the `WorkHours` property which is of object type and includes the following sub-options,

* `Highlight` – enables/disables the highlighting of work hours.
* `Start` - sets the start time of the working/business hour of a day.
* `End` - sets the end time limit of the working/business hour of a day.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/schedule/working-days/working-hours/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/working-days/working-hours/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/schedule/working-days/working-hours/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/working-days/working-hours/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Scheduler displaying custom hours

It is possible to display the event Scheduler layout with specific time durations by hiding the unwanted hours. To do so, set the start and end hour for the Scheduler using the `StartHour` and `EndHour` properties respectively.

The following code example displays the Scheduler starting from the time range 7.00 AM to 6.00 PM and the remaining hours are hidden on the UI.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/schedule/working-days/display-hours/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/working-days/display-hours/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/schedule/working-days/display-hours/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/working-days/display-hours/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Setting start day of the week

By default, Scheduler defaults to `Sunday` as its first day of a week. To change the Scheduler's start day of a week with different day, set the `FirstDayOfWeek` property with the values ranging from 0 to 6.

> Here, Sunday is always denoted as 0, Monday as 1 and so on.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/schedule/working-days/start-week/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/working-days/start-week/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/schedule/working-days/start-week/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/working-days/start-week/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Scroll to specific time and date

You can manually scroll to a specific time on Scheduler by making use of the `scrollTo` method as depicted in the following code example.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/schedule/working-days/scroll-specific-time/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/working-days/scroll-specific-time/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/schedule/working-days/scroll-specific-time/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/working-days/scroll-specific-time/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### How to scroll to current time on initial load

There are scenarios where you may need to load the Scheduler displaying the system's current time on the currently visible view port area. In such cases, the Scheduler needs to be scrolled to a specific time based on the system's current time which is depicted in the following code example.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/schedule/working-days/initial-load/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/working-days/initial-load/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/schedule/working-days/initial-load/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/working-days/initial-load/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You can refer to our [ASP.NET MVC Scheduler](https://www.syncfusion.com/aspnet-mvc-ui-controls/scheduler) feature tour page for its groundbreaking feature representations. You can also explore our [ASP.NET MVC Scheduler](https://ej2.syncfusion.com/aspnetmvc/Schedule/Overview#/material) example to knows how to present and manipulate data.

## See Also

* [To display the current time indicator](./timescale/#highlighting-current-date-and-time)
* [To set different working hours dynamically](./how-to/set-different-work-hours)
* [To set different working hours for each resources](./resources/#set-different-work-hours)
* [To set different working days for each resources](./resources/#set-different-work-days)