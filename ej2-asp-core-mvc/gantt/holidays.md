---
layout: post
title: Holidays in ##Platform_Name## Gantt Component
description: Learn here all about Holidays in Syncfusion ##Platform_Name## Gantt component and more.
platform: ej2-asp-core-mvc
control: Holidays
publishingplatform: ##Platform_Name##
documentation: ug
---


# Holidays

Non-working days in a project can be displayed in the Gantt control using the [`Holidays`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_Holidays) property. Each holiday can be defined with the following properties:

* [`From`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttHoliday.html#Syncfusion_EJ2_Gantt_GanttHoliday_From): Defines start date of the holiday(s).
* [`To`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttHoliday.html#Syncfusion_EJ2_Gantt_GanttHoliday_To): Defines end date of the holiday(s).
* [`Label`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttHoliday.html#Syncfusion_EJ2_Gantt_GanttHoliday_Label): Defines the description or label for the holiday.
* [`CssClass`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttHoliday.html#Syncfusion_EJ2_Gantt_GanttHoliday_CssClass): Formats the holidays label in the Gantt chart.

The following code example shows how to display the non-working days in the Gantt control.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/holidays/holidays/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Holidays.cs" %}
{% include code-snippet/gantt/holidays/holidays/holidays.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/holidays/holidays/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Holidays.cs" %}
{% include code-snippet/gantt/holidays/holidays/holidays.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



The following screenshot shows the output of Holidays in Gantt control.

![Alt text](images/holidays.png)