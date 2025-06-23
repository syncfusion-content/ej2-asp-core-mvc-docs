---
layout: post
title: Date Format in ##Platform_Name## Daterangepicker Component | Syncfusion
description: Learn here all about Date Format in Syncfusion ##Platform_Name## Daterangepicker component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Date Format
publishingplatform: ##Platform_Name##
documentation: ug
---


# Date Format in Syncfusion<sup style="font-size:70%">&reg;</sup> Daterangepicker Component

Date format is a way of representing the date value in different string format in textbox.

By default the DateRangePicker's format is based on the culture. You can also set the own custom format by using the [format](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.calendars.daterangepicker.html#Syncfusion_EJ2_Calendars_DateRangePicker_Format) property.

N> Once the date format property has been defined, it will be common to all the cultures.

To know more about the date format standards, refer to the [`Internationalization Date Format`](https://ej2.syncfusion.com/aspnetcore/documentation/daterangepicker/globalization) section.

The following example demonstrates the DateRangePicker with the custom format (`dd/MMM/yy hh:mm a`).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/daterangepicker/date-format/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Date-format.cs" %}
{% include code-snippet/daterangepicker/date-format/date-format.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/daterangepicker/date-format/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Date-format.cs" %}
{% include code-snippet/daterangepicker/date-format/date-format.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Input formats 

The [`inputFormats`](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.calendars.daterangepicker.html#properties) property in the DateRangePicker control allows users to enter dates in various formats, providing flexibility in date entry. This property accepts an array of predefined formats that the control recognizes, enabling users to input dates in different ways while ensuring they are parsed correctly.

When the user types the date in any of the specified input formats, it will be automatically converted to the display format after pressing Enter, the Tab key, or when the input loses focus. This enhances the user experience by allowing intuitive data entry through various custom input formats.

The following example demonstrates the DateRangePicker with multiple input formats.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/daterangepicker/input-format/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Date-format.cs" %}
{% include code-snippet/daterangepicker/input-format/input-format.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/daterangepicker/input-format/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Date-format.cs" %}
{% include code-snippet/daterangepicker/input-format/input-format.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}
