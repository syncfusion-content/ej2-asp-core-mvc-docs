---
layout: post
title: Date Format in ##Platform_Name## Datepicker Component | Syncfusion
description: Learn here all about Date Format in Syncfusion ##Platform_Name## Datepicker component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Date Format
publishingplatform: ##Platform_Name##
documentation: ug
---


# Date Format in Syncfusion<sup style="font-size:70%">&reg;</sup> Datepicker Component

Date format is a way of representing the date value in different string format in textbox.

By default the DatePicker's format is based on the culture. You can also set the own custom format by using the [format](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.DatePicker.html#Syncfusion_EJ2_Calendars_DatePicker_Format) property.

N> Once the date format property has been defined, it will be common to all the cultures.

To know more about the date format standards, refer to the [`Internationalization Date Format`](https://ej2.syncfusion.com/aspnetcore/documentation/datepicker/globalization) section.

The following example demonstrates the DatePicker with the custom format (`yyyy-MM-dd`).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/datepicker/date-format/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Date-format.cs" %}
{% include code-snippet/datepicker/date-format/date-format.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/datepicker/date-format/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Date-format.cs" %}
{% include code-snippet/datepicker/date-format/date-format.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Input formats 

The [`inputFormats`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.DatePicker.html#Syncfusion_EJ2_Calendars_DatePicker_InputFormats) property in the DatePicker control allows users to enter dates in various formats, providing flexibility in date entry. This property accepts an array of predefined formats that the control recognizes, enabling users to input dates in different ways while ensuring they are parsed correctly.

When the user types the date in any of the specified input formats, it will be automatically converted to the display format after pressing Enter, the Tab key, or when the input loses focus. This enhances the user experience by allowing intuitive data entry through various custom input formats.

The following example demonstrates the DatePicker with multiple input formats.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/datepicker/input-format/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Date-format.cs" %}
{% include code-snippet/datepicker/input-format/input-format.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/datepicker/input-format/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Date-format.cs" %}
{% include code-snippet/datepicker/input-format/input-format.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}
