---
layout: post
title: Strict Mode in ##Platform_Name## Timepicker Component
description: Learn here all about Strict Mode in Syncfusion ##Platform_Name## Timepicker component and more.
platform: ej2-asp-core-mvc
control: Strict Mode
publishingplatform: ##Platform_Name##
documentation: ug
---


# Strict mode

The [strictMode](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.TimePicker.html#Syncfusion_EJ2_Calendars_TimePicker_StrictMode)
is an act that allows you to enter only valid time value within the specified min/max
range in the textbox. If the time value is invalid, the control value sets to the previous value.
If the time value is
out of range, the control sets the time value to min/max value.

The following example demonstrates the TimePicker in `strictMode` with min/max range of `10:00 AM` to
`4:00 PM` . It allows you to enter
only valid time within the specified range. If you enter the out-of-range value like
`8:00 PM`,
the value sets to the max time `4:00 PM` as the value `8:00 PM` is greater than `max` value
of `4:00 PM`. If you enter invalid time value like `9:00 tt`, the value sets to the previous value.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/timepicker/strict-mode/strictmode/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Strictmode.cs" %}
{% include code-snippet/timepicker/strict-mode/strictmode/strictmode.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/timepicker/strict-mode/strictmode/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Strictmode.cs" %}
{% include code-snippet/timepicker/strict-mode/strictmode/strictmode.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



By default, the TimePicker act in strictMode `false` state, that allows to enter the invalid or out-of-range time in textbox.

If the time is out-of-range or invalid, then the model value will be set to `out of range` time
value or `null` respectively with highlighted `error` class to indicates the time is out of range or invalid.

The following example demonstrates the `strictMode` as `false`. Here, it allows to enter the
valid or invalid value in textbox.
If you are entering the out-of-range or invalid time value, then the model value will be set to
`out of range` time value or `null` respectively with highlighted `error` class to indicates the time is out of range or invalid..

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/timepicker/strict-mode/normalmode/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Normalmode.cs" %}
{% include code-snippet/timepicker/strict-mode/normalmode/normalmode.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/timepicker/strict-mode/normalmode/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Normalmode.cs" %}
{% include code-snippet/timepicker/strict-mode/normalmode/normalmode.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> If the value of `min` or `max` property is changed through code behind, update the `value` property to set within the range.