---
layout: post
title: Date Time Format in ##Platform_Name## Datetimepicker Component | Syncfusion
description: Learn here all about Date Time Format in Syncfusion ##Platform_Name## Datetimepicker component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Date Time Format
publishingplatform: ##Platform_Name##
documentation: ug
---


# DateTime Format

DateTime format is a way of representing the date and time value in different string format in textbox.

By default the DateTimePicker's format is based on the culture. You can also set the own custom format by using the [`format`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.DateTimePicker.html#Syncfusion_EJ2_Calendars_DateTimePicker_Format) property.

N> Once the date format property has been defined it will be common to all the cultures.

To know more about the date and time format standards, refer to the [`Internationalization Date Time Format`](/common/internationalization/) section.

The following example demonstrates the DateTimePicker with the custom format (`yyyy-MM-dd hh:mm`).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/datetimepicker/date-time-format/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Date-time-format.cs" %}
{% include code-snippet/datetimepicker/date-time-format/date-time-format.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/datetimepicker/date-time-format/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Date-time-format.cs" %}
{% include code-snippet/datetimepicker/date-time-format/date-time-format.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Input formats

The [`inputFormats`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.DateTimePicker.html#Syncfusion_EJ2_Calendars_DateTimePicker_InputFormats) property in the DatetimePicker control allows users to enter dates and times in various formats, providing flexibility in date and time entry. This property accepts an array of predefined formats that the control recognizes, enabling users to input dates in different ways while ensuring they are parsed correctly.

When the user types the date and time in any of the specified input formats, it will be automatically converted to the display format after pressing Enter, the Tab key, or when the input loses focus. This enhances the user experience by allowing intuitive data entry through various custom input formats.

The following example demonstrates the DateTimePicker with multiple input formats.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/datetimepicker/input-format/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Input-format.cs" %}
{% include code-snippet/datetimepicker/input-format/input-format.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/datetimepicker/input-format/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Input-format.cs" %}
{% include code-snippet/datetimepicker/input-format/input-format.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}
