---
layout: post
title: Strict Mode in ##Platform_Name## Datepicker Component
description: Learn here all about Strict Mode in Syncfusion ##Platform_Name## Datepicker component and more.
platform: ej2-asp-core-mvc
control: Strict Mode
publishingplatform: ##Platform_Name##
documentation: ug
---


# Strict Mode

The [strictMode](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.DatePicker.html#Syncfusion_EJ2_Calendars_DatePicker_StrictMode)
is an act,that allows the user to enter only the valid date within the specified `min/max` range in textbox.
If the date is invalid, then the component will stay with the previous value.
Else, if the date is out of range, then the component will set the date to the min/max date.

The following example demonstrates the DatePicker in `strictMode` with min/max range of 5th to 25th in a month of May.
Here, it allows to enter only the valid date within the specified range. If you are trying to enter the out-of-range value as like 28th of May,
then the value will set to the max date of 25th May. Since the value 28th is greater than to max value of 25th.
Or else if you are trying to enter the invalid date, then the value will stay with the previous value.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/datepicker/strict-mode/strict-true/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Strict-true.cs" %}
{% include code-snippet/datepicker/strict-mode/strict-true/strict-true.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/datepicker/strict-mode/strict-true/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Strict-true.cs" %}
{% include code-snippet/datepicker/strict-mode/strict-true/strict-true.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



By default, the DatePicker act in strictMode `false` state, that allows to enter the invalid or out-of-range date in textbox.

If the date is out-of-range or invalid, then the model value will be set to `out of range` date
value or `null` respectively with highlighted  `error` class to indicates the date is out of range or invalid.

The following example demonstrates the `strictMode` as `false`. Here, it allows to enter the
valid or invalid value in textbox.
If you are entering out-of-range or invalid date value, then the model value will be set to
`out of range` date value or `null` respectively with highlighted  `error` class to indicates
the date is out of range or invalid.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/datepicker/strict-mode/strict-false/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Strict-false.cs" %}
{% include code-snippet/datepicker/strict-mode/strict-false/strict-false.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/datepicker/strict-mode/strict-false/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Strict-false.cs" %}
{% include code-snippet/datepicker/strict-mode/strict-false/strict-false.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> If the value of `min` or `max` properties changed through code behind,
then you have to update the `value` property to set within the range.
