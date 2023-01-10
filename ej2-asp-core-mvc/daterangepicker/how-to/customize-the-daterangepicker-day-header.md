---
layout: post
title: Customize The Daterangepicker Day Header in ##Platform_Name## Daterangepicker Component
description: Learn here all about how to customize the Daterangepicker day header in Syncfusion ##Platform_Name## Daterangepicker component of syncfusion and more.
platform: ej2-asp-core-mvc
control: Customize The Daterangepicker Day Header
publishingplatform: ##Platform_Name##
documentation: ug
---


# Customize the daterangepicker day header

You can change the format of the day that has to be displayed in header using [dayHeaderFormat](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.DateRangePicker.html#Syncfusion_EJ2_Calendars_DateRangePicker_DayHeaderFormat) property.

N> By default, the format is `Short`.

You can find the possible formats on below.

| **Name** | **Description** |
|------|---------------------|
| `Short` | Sets the short format of day name (like Su ) in day header. |
| `Narrow` | Sets the single character of day name (like S ) in day header. |
| `Abbreviated` | Sets the min format of day name (like Sun ) in day header. |
| `Wide` | Sets the long format of day name (like Sunday ) in day header. |

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/daterangepicker/how-to/headerformat/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Headerformat.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/daterangepicker/how-to/headerformat/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Headerformat.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}


![daterangepicker](../images/narrow.png)

![daterangepicker](../images/abbreviated.png)