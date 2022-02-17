---
layout: post
title: Date Views in ##Platform_Name## Datepicker Component
description: Learn here all about Date Views in Syncfusion ##Platform_Name## Datepicker component and more.
platform: ej2-asp-core-mvc
control: Date Views
publishingplatform: ##Platform_Name##
documentation: ug
---

# Start and Depth View

The DatePicker has the following predefined views
that provides a flexible way to navigate back and forth to select the date.

| **View** | **Description** |
| --- | --- |
| month (default) | Displays the days in a month |
| year | Displays the months in a year |
| decade | Displays the years in a decade |

## Start view

You can use the [`start`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/aspnetcore/Syncfusion.EJ2~Syncfusion.EJ2.Calendars.DatePicker~Start.html) property to define the initial rendering view.

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

Define the [`depth`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/aspnetcore/Syncfusion.EJ2~Syncfusion.EJ2.Calendars.DatePicker~Depth.html) property to control the view navigation.

> Always the depth view has to be smaller than the start view, otherwise the view restriction
will be not restricted.

The following example demonstrates how to create a DatePicker that allows users to select a month.

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



> To know more about Calendar views refer the Calendar's
[Calendar Views](../calendar/calendar-views.html)
section.