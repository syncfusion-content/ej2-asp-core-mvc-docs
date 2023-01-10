---
layout: post
title: View in ##Platform_Name## Datepicker Component
description: Learn here all about View in Syncfusion ##Platform_Name## Datepicker component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: View
publishingplatform: ##Platform_Name##
documentation: ug
---


# Start and Depth View

The DatePicker has the following predefined views that provides a flexible way to navigate back and forth to select the date.

| **View** | **Description** |
| --- | --- |
| month (default) | Displays the days in a month |
| year | Displays the months in a year |
| decade | Displays the years in a decade |

## Start view

You can use the [start](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.DatePicker.html#Syncfusion_EJ2_Calendars_DatePicker_Start) property to define the initial rendering view.

The following example demonstrates how to create a DatePicker with `decade` as initial rendering view.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/datepicker/view/start/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Start.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/datepicker/view/start/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Start.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



## Depth view

Define the [depth](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.DatePicker.html#Syncfusion_EJ2_Calendars_DatePicker_Depth) property to control the view navigation.

N> Always the depth view has to be smaller than the start view, otherwise the view restriction will be not restricted.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/datepicker/view/depth/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Depth.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/datepicker/view/depth/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Depth.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



N> To know more about Calendar views refer the Calendar's [Calendar Views](../calendar/calendar-views/) section.