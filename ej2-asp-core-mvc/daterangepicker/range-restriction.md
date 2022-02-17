---
layout: post
title: Range Restriction in ##Platform_Name## Daterangepicker Component
description: Learn here all about Range Restriction in Syncfusion ##Platform_Name## Daterangepicker component and more.
platform: ej2-asp-core-mvc
control: Range Restriction
publishingplatform: ##Platform_Name##
documentation: ug
---


# Range Restriction

Range selection in a DateRangePicker can be made-to-order with desire restrictions based on the application needs.

## Restrict the range within a range

You can restrict the minimum and maximum date that can be allowed as start and end date in a range selection with the help of [min](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.DateRangePicker.html#Syncfusion_EJ2_Calendars_DateRangePicker_Min), [max](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.DateRangePicker.html#Syncfusion_EJ2_Calendars_DateRangePicker_Max) properties.
* `min` – sets the minimum date that can be selected as startDate.
* `max` – sets the maximum date that can be selected as endDate.

In the following sample, you can select a range from 15th day of this month to 15th day of next month.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/daterangepicker/range-restriction/daterange/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Daterange.cs" %}
{% include code-snippet/daterangepicker/range-restriction/daterange/daterange.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/daterangepicker/range-restriction/daterange/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Daterange.cs" %}
{% include code-snippet/daterangepicker/range-restriction/daterange/daterange.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> If the value of `min` or `max` property
is changed through code behind, update the `start date` and `end date` properties to set within the range.
Or else , if the `start` and `end` date is out of specified date range, a validation error class will be appended to the input element. If `strictMode` is enabled, and both the start, end date is lesser than the min date then start and end date will be updated with `min` date. If both the start and end date is higher than the max date then start and end date will be updated with `max` date. Or else, if startDate is less than `min` date, startDate will be updated with `min` date or if endDate is greater than `max` date, endDate will be updated with the `max` date.

## Range span

Span between ranges can be limited to avoid excess or less days selection towards the required days in a range.
In this, minimum and maximum span allowed within the date range can be customized by [minDays](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.DateRangePicker.html#Syncfusion_EJ2_Calendars_DateRangePicker_MinDays) and [maxDays](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.DateRangePicker.html#Syncfusion_EJ2_Calendars_DateRangePicker_MaxDays) properties.

* `minDays` - Sets the minimum number of days between start and end date.
* `maxDays` - Sets the maximum number of days between start and end date.

In the following sample, the range selection should be greater than 3 days and less than 8 days else it will not set.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/daterangepicker/range-restriction/rangespan/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Rangespan.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/daterangepicker/range-restriction/rangespan/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Rangespan.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



## Strict mode

DateRangePicker provides an option to limit the user towards entering the valid date.  With strict mode, you can set only the valid date. If any invalid range is specified, the date range value resets to previous value. This restriction can be availed by enabling [strictMode](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.DateRangePicker.html#Syncfusion_EJ2_Calendars_DateRangePicker_StrictMode) property as true.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/daterangepicker/range-restriction/strictmode/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Strickmode.cs" %}
{% include code-snippet/daterangepicker/range-restriction/strictmode/strickmode.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/daterangepicker/range-restriction/strictmode/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Strickmode.cs" %}
{% include code-snippet/daterangepicker/range-restriction/strictmode/strickmode.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

