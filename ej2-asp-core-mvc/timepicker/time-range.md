---
layout: post
title: Time Range in ##Platform_Name## Timepicker Component
description: Learn here all about Time Range in Syncfusion ##Platform_Name## Timepicker component and more.
platform: ej2-asp-core-mvc
control: Time Range
publishingplatform: ##Platform_Name##
documentation: ug
---


# Time Range

TimePicker provides an option to select a time value within a specified range by using the
[min](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.TimePicker.html#Syncfusion_EJ2_Calendars_TimePicker_Min)
and
[max](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.TimePicker.html#Syncfusion_EJ2_Calendars_TimePicker_Max)
properties. The min value should always be
lesser than the max value.

When the min and max properties are configured and the selected time value is out-of-range or
invalid, then the model value will be set to `out of range` time value or `null` respectively
with highlighted `error` class to indicates the time is out of range or invalid.

The value property depends on the min/max with respect to [strictMode](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.TimePicker.html#Syncfusion_EJ2_Calendars_TimePicker_StrictMode) property.
The following example allows you to select a time value within a range of `9:00 AM` to `11:30 AM`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/timepicker/time-range/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Timerange.cs" %}
{% include code-snippet/timepicker/time-range/timerange.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/timepicker/time-range/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Timerange.cs" %}
{% include code-snippet/timepicker/time-range/timerange.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> If the value of `min` or `max` property is changed through code behind you have to
update the `value` property to set within the range.

## Time Range customization using two TimePicker components

Here, two TimePicker components are used to select the start and end time. The below sample illustrates the appointment time selection scenario with the start and end time option.

Before the start time selection, the end time TimePicker is in disable state. When the start time is selected, then you will be able to select the end time or else, need to select the entire business hours 9:00 to 18:00 from the Business Hours option. Once the options are checked, both the TimePicker components goes to readonly state.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/timepicker/time-range-customization/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Timerange-customization.cs" %}
{% include code-snippet/timepicker/time-range-customization/timerange-customization.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/timepicker/time-range-customization/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Timerange-customization.cs" %}
{% include code-snippet/timepicker/time-range-customization/timerange-customization.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

