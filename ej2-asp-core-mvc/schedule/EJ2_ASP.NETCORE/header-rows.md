---
layout: post
title: Header Rows in ##Platform_Name## Schedule Component | Syncfusion
description: Learn here all about Header Rows in Syncfusion ##Platform_Name## Schedule component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Header Rows
publishingplatform: ##Platform_Name##
documentation: ug
---


# Timeline header rows

The Timeline views can have additional header rows other than its default date and time header rows. It is possible to show individual header rows for displaying year, month and week separately using the [`headerRows`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Schedule.Schedule.html#Syncfusion_EJ2_Schedule_Schedule_HeaderRows) property. This property is applicable only on the timeline views. The possible rows which can be added using `headerRows` property are as follows.

* `Year`
* `Month`
* `Week`
* `Date`
* `Hour`

N> The `Hour` row is not applicable for Timeline month view.

The following example shows the Scheduler displaying all the available header rows on timeline views.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/schedule/header-rows/all-option/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/header-rows/all-option/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/schedule/header-rows/all-option/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/header-rows/all-option/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


![Display Timeline Header Rows in ASP.NET Core Scheduler](images/scheduler-header-default.png)

## Display year and month rows in timeline views

To display the timeline Scheduler simply with year and month names alone, define the option `Year` and `Month` within the [`headerRows`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Schedule.Schedule.html#Syncfusion_EJ2_Schedule_Schedule_HeaderRows) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/schedule/header-rows/year-month/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/header-rows/year-month/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/schedule/header-rows/year-month/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/header-rows/year-month/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


![Display Year and Month in ASP.NET Core Scheduler Timeline Views](images/scheduler-header-year-month.png)

## Display week numbers in timeline views

The week number can be displayed in a separate header row of the timeline Scheduler by setting `Week` option within[`headerRows`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Schedule.Schedule.html#Syncfusion_EJ2_Schedule_Schedule_HeaderRows) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/schedule/header-rows/week-number/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/header-rows/week-number/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/schedule/header-rows/week-number/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/header-rows/week-number/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


![Display Week Numbers in ASP.NET Core Scheduler Timeline Views](images/scheduler-header-week-number.png)

## Timeline view displaying dates of a complete year

It is possible to display a complete year in a timeline view by setting [`interval`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Schedule.ScheduleTimeScale.html#Syncfusion_EJ2_Schedule_ScheduleTimeScale_Interval) value as 12 and defining **TimelineMonth** view option within the [`e-schedule-views`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Schedule.Schedule.html#Syncfusion_EJ2_Schedule_Schedule_Views) tag helper of Scheduler.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/schedule/header-rows/complete-year/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/header-rows/complete-year/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/schedule/header-rows/complete-year/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/header-rows/complete-year/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


![Display Dates of Complete Year in ASP.NET Core Scheduler Timeline Views](images/scheduler-header-date-complete-year.png)

## Customizing the header rows using template

You can customize the text of the header rows and display any images or formatted text on each individual header rows using the built-in `template` option available within the [`headerRows`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Schedule.Schedule.html#Syncfusion_EJ2_Schedule_Schedule_HeaderRows) property.

To get start quickly about header row template option available in our Scheduler, you can check on this video:

{% youtube
"youtube:https://www.youtube.com/watch?v=oX2cPQGyIkk"%}

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/schedule/header-rows/header-row-template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/header-rows/header-row-template/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/schedule/header-rows/header-row-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/header-rows/header-row-template/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


![Display Customizing the Header Rows using Template in ASP.NET Core Scheduler](images/scheduler-custom-header-template.png)

N> You can refer to our [ASP.NET Core Scheduler](https://www.syncfusion.com/aspnet-core-ui-controls/scheduler) feature tour page for its groundbreaking feature representations. You can also explore our [ASP.NET Core Scheduler example](https://ej2.syncfusion.com/aspnetcore/Schedule/Overview#/material) to knows how to present and manipulate data.
