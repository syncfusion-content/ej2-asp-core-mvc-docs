---
layout: post
title: Date Time Range in ##Platform_Name## Datetimepicker Component
description: Learn here all about Date Time Range in Syncfusion ##Platform_Name## Datetimepicker component and more.
platform: ej2-asp-core-mvc
control: Date Time Range
publishingplatform: ##Platform_Name##
documentation: ug
---


# DateTime Range

DateTimePicker provides an option to select a date and time value within a specified range
by using the [min](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.DateTimePicker.html#Syncfusion_EJ2_Calendars_DateTimePicker_Min)
and [max](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.DateTimePicker.html#Syncfusion_EJ2_Calendars_DateTimePicker_Max)properties.
Always the min value has to be lesser than the max value.

When the min and max properties are configured and the selected datetime value is out-of-range
or invalid, then the model value will be set to `out of range` datetime value or `null`
respectively with highlighted `error` class to indicates the datetime is out of range or invalid

The value property depends
on the min/max with respect to [strictMode](./strict-mode/) property.

The below example allows selecting a
date within the range from 7th to 27th day in
a month.

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



> If the value of `min` or `max` properties
changed through code behind, then you have to
update the `value` property to set within the
range.