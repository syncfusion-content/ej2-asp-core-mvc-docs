---
layout: post
title: Strict Mode in ##Platform_Name## Datetimepicker Component
description: Learn here all about Strict Mode in Syncfusion ##Platform_Name## Datetimepicker component and more.
platform: ej2-asp-core-mvc
control: Strict Mode
publishingplatform: ##Platform_Name##
documentation: ug
---


# Strict Mode

The [strictMode](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.DateTimePicker.html#Syncfusion_EJ2_Calendars_DateTimePicker_StrictMode)is an act, that allows the user to enter only the valid date and time within the specified min/max range in textbox.
If the input entered is invalid, then the control will stay with the previous value.
Else, if the datetime is
out of range, then the control will set the datetime to the min/max value.

The following example demonstrates the DateTimePicker in `strictMode` with min/max range of `5/5/2019 2:00 AM` to
`5/25/2019 2:00 AM`. Here, it allows to enter
only the valid date and time within the specified range. If you are trying to enter the out-of-range value as
like `5/28/2019`,
then the value will set to the `max` value as `5/25/2019 2:00 AM`. Since the value 28 is greater than to `max` value
of 25. Or else if you are trying
to enter the invalid date, then the value will stay with the previous value.

The following example demonstrates the DateTimePicker with strictMode `true`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/datetimepicker/strict-mode/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Strictmode.cs" %}
{% include code-snippet/datetimepicker/strict-mode/strictmode.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/datetimepicker/strict-mode/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Strictmode.cs" %}
{% include code-snippet/datetimepicker/strict-mode/strictmode.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



By default, the DateTimePicker act in strictMode `false` state, that allows to enter the invalid or out-of-range datetime in textbox.

If the datetime is out-of-range or invalid, then the model value will be set to `out of range`
datetime value or `null` respectively with highlighted `error` class to indicates the datetime is out of range or invalid.

The following example demonstrates the `strictMode` as `false`. Here, it allows to enter the
valid or invalid value in textbox.
If you are entering the out-of-range or invalid datetime value, then the model value will be
set to `out of range` datetime value or `null` respectively with highlighted `error` class to
indicates the datetime is out of range or invalid.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/datetimepicker/strict-mode-disabled/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Strictmode.cs" %}
{% include code-snippet/datetimepicker/strict-mode-disabled/strictmode.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/datetimepicker/strict-mode-disabled/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Strictmode.cs" %}
{% include code-snippet/datetimepicker/strict-mode-disabled/strictmode.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> If the value of `min` or `max` properties changed through code behind,
then you have to update the `value` property to set within the range.