---
layout: post
title: Date Time Range in Syncfusion ##Platform_Name## Datetimepicker Component
description: Learn here all about Date Time Range in Syncfusion ##Platform_Name## Datetimepicker component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Date Time Range
publishingplatform: ##Platform_Name##
documentation: ug
---


# DateTime Range Restriction

## DateTime Restriction

DateTimePicker provides an option to select a date and time value within a specified range by using the [min](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.DateTimePicker.html#Syncfusion_EJ2_Calendars_DateTimePicker_Min) and [max](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.DateTimePicker.html#Syncfusion_EJ2_Calendars_DateTimePicker_Max) properties. Always the min value has to be lesser than the max value.

When the min and max properties are configured and the selected datetime value is out-of-range or invalid, then the model value will be set to `out of range` datetime value or `null` respectively with highlighted `error` class to indicate that the datetime is out of range or invalid. The value property depends on the min/max with respect to [strictMode](./strict-mode/) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/datetimepicker/datetime-range/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Datetimerange.cs" %}
{% include code-snippet/datetimepicker/datetime-range/datetimerange.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/datetimepicker/datetime-range/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Datetimerange.cs" %}
{% include code-snippet/datetimepicker/datetime-range/datetimerange.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



N> If the value of `min` or `max` properties changed through code behind, then you have to update the `value` property to set within the range.

## Time Restriction

DateTimePicker provides an option to select a time value within a specified range by using the [minTime](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.DateTimePicker.html#Syncfusion_EJ2_Calendars_DateTimePicker_MinTime) and [maxTime](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.DateTimePicker.html#Syncfusion_EJ2_Calendars_DateTimePicker_MaxTime) properties. Always the minTime value has to be lesser than the maxTime value.

When minTime and maxTime are set, the component will prioritize min if minTime is less than the current min time, and max if maxTime is greater than the current max time. Conversely, it will prioritize minTime if it is greater than the current min time, and maxTime if it is less than the current max time. These behaviors apply only when min and max Dates are selected or pre-bounded, with minTime and maxTime values set for all other dates apart from min and max dates.

The value property depends on the minTime/maxTime with respect to [`strictMode`](./strict-mode) property.

The below example allows selecting a time within the range from 10:00 AM to 8:30 PM of each day.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/datetimepicker/time-range/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Timerange.cs" %}
{% include code-snippet/datetimepicker/time-range/timerange.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/datetimepicker/time-range/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Timerange.cs" %}
{% include code-snippet/datetimepicker/time-range/timerange.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}
