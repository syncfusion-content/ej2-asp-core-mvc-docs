---
layout: post
title: Date Format in ##Platform_Name## Datepicker Component
description: Learn here all about Date Format in Syncfusion ##Platform_Name## Datepicker component and more.
platform: ej2-asp-core-mvc
control: Date Format
publishingplatform: ##Platform_Name##
documentation: ug
---


# Date Format

Date format is a way of representing the date value in different string format in textbox.

By default the DatePicker's format is based on the culture. You can also set the own
custom format by using the
[format](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.DatePicker.html#Syncfusion_EJ2_Calendars_DatePicker_Format)
property.

> Once the date format property has been defined it will be common to all the cultures.

To know more about the date format standards, refer to the
[`Internationalization Date Format`](../common/internationalization/) section.

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

