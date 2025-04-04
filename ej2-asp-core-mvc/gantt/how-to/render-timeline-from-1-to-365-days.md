---
layout: post
title: Render timeline from 1 to 365 days in ##Platform_Name## Gantt Component
description: Learn here all about Render timeline from 1 to 365 days in Syncfusion ##Platform_Name## Gantt component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Render timeline from 1 to 365 days
publishingplatform: ##Platform_Name##
documentation: ug
---

# Render timeline from 1 to 365 days in Gantt component

Gantt chart contains different types of in-built timeline view modes and it can be defined by using [`TimelineViewMode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.TimelineViewMode.html) property and also we can customize the timescale mode of top tier and bottom tier by using [`TopTier.Unit`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttTimelineTierSettings.html#Syncfusion_EJ2_Gantt_GanttTimelineTierSettings_Unit) and [`BottomTier.Unit`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttTimelineTierSettings.html#Syncfusion_EJ2_Gantt_GanttTimelineTierSettings_Unit) properties. Timeline tier’s unit can be defined by using [`Unit`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttTimelineTierSettings.html#Syncfusion_EJ2_Gantt_GanttTimelineTierSettings_Unit) property and  [`Format`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttTimelineTierSettings.html#Syncfusion_EJ2_Gantt_GanttTimelineTierSettings_Format) property was used to define date format of timeline cell and [`Formatter`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttTimelineTierSettings.html#Syncfusion_EJ2_Gantt_GanttTimelineTierSettings_Formatter) property was used to define custom method to format the date value of timeline cell.

In the [`BottomTier.Unit`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttTimelineTierSettings.html#Syncfusion_EJ2_Gantt_GanttTimelineTierSettings_Unit) timescale mode, it is possible to display timeline from 1 to 365 days by making use of the formatter in the `TimelineSettings` property. The following example shows how to use the formatter method for timeline cells.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/how-to/renderTimelineFrom1To365Days/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="RenderTimelineFrom1To365Days.cs" %}
{% include code-snippet/gantt/how-to/renderTimelineFrom1To365Days/renderTimelineFrom1To365Days.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/how-to/renderTimelineFrom1To365Days/razor %}
{% endhighlight %}
{% highlight c# tabtitle="RenderTimelineFrom1To365Days.cs" %}
{% include code-snippet/gantt/how-to/renderTimelineFrom1To365Days/renderTimelineFrom1To365Days.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}