---
layout: post
title: Top tier and Bottom tier in ##Platform_Name## Gantt Component
description: Learn here all about Top tier and Bottom tier in Syncfusion ##Platform_Name## Gantt component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Time Line
publishingplatform: ##Platform_Name##
documentation: ug
---


# Top tier and Bottom tier

Gantt control contains two tier layout in timeline, we can customize the top tier and bottom tier using [`TopTier`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttTimelineSettings.html#Syncfusion_EJ2_Gantt_GanttTimelineSettings_TopTier) and [`BottomTier`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttTimelineSettings.html#Syncfusion_EJ2_Gantt_GanttTimelineSettings_BottomTier) properties. Timeline tier's unit can be defined by using [`Unit`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttTimelineTierSettings.html#Syncfusion_EJ2_Gantt_GanttTimelineTierSettings_Unit) property and [`Format`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttTimelineTierSettings.html#Syncfusion_EJ2_Gantt_GanttTimelineTierSettings_Format) property was used to define date format of timeline cell and [`Count`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttTimelineTierSettings.html#Syncfusion_EJ2_Gantt_GanttTimelineTierSettings_Count) property was used to define how many unit will be combined as single cell and [`Formatter`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttTimelineTierSettings.html#Syncfusion_EJ2_Gantt_GanttTimelineTierSettings_Formatter) property was used to define custom method to format the date value of timeline cell.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/timeline/topBottomTier/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="TopBottomTier.cs" %}
{% include code-snippet/gantt/timeline/topBottomTier/topBottomTier.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/timeline/topBottomTier/razor %}
{% endhighlight %}
{% highlight c# tabtitle="TopBottomTier.cs" %}
{% include code-snippet/gantt/timeline/topBottomTier/topBottomTier.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Alt text](images/topBottomTier.png)

## Combining timeline cells

In Gantt, timeline cells in top tier and bottom tier can be combined with number of timeline units, this can be acheived by using [`TopTier.Count`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttTimelineTierSettings.html#Syncfusion_EJ2_Gantt_GanttTimelineTierSettings_Count) and [`BottomTier.Count`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttTimelineTierSettings.html#Syncfusion_EJ2_Gantt_GanttTimelineTierSettings_Count) properties. Refer the below sample.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/timeline/combineCells/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CombineCells.cs" %}
{% include code-snippet/gantt/timeline/combineCells/combineCells.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/timeline/combineCells/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CombineCells.cs" %}
{% include code-snippet/gantt/timeline/combineCells/combineCells.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Alt text](images/combineCells.png)

## Format value of timeline cell

In the Gantt control, you can format the value of top and bottom timeline cells using the standard date format string or the custom formatter method. This can be done using the [`TopTier.Format`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttTimelineTierSettings.html#Syncfusion_EJ2_Gantt_GanttTimelineTierSettings_Format), [`TopTier.Formatter`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttTimelineTierSettings.html#Syncfusion_EJ2_Gantt_GanttTimelineTierSettings_Formatter), [`BottomTier.Format`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttTimelineTierSettings.html#Syncfusion_EJ2_Gantt_GanttTimelineTierSettings_Format) and [`BottomTier.Formatter`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttTimelineTierSettings.html#Syncfusion_EJ2_Gantt_GanttTimelineTierSettings_Formatter) properties. The following example shows how to use the formatter method for timeline cells.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/timeline/formatCells/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="FormatCells.cs" %}
{% include code-snippet/gantt/timeline/formatCells/formatCells.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/timeline/formatCells/razor %}
{% endhighlight %}
{% highlight c# tabtitle="FormatCells.cs" %}
{% include code-snippet/gantt/timeline/formatCells/formatCells.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Alt text](images/formatCells.png)

## Timeline cell width

In the Gantt control, you can define the width value of timeline cell using the [`TimelineSettings.TimelineUnitSize`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttTimelineSettings.html#Syncfusion_EJ2_Gantt_GanttTimelineSettings_TimelineUnitSize) property. This value will be set to the bottom timeline cell, and the width value of top timeline cell will be calculated automatically based on bottom tier cell width using the [`TopTier.Unit`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttTimelineTierSettings.html#Syncfusion_EJ2_Gantt_GanttTimelineTierSettings_Unit) and [`TimelineSettings.TimelineUnitSize`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttTimelineSettings.html#Syncfusion_EJ2_Gantt_GanttTimelineSettings_TimelineUnitSize) properties. Refer to the following example.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/timeline/timelineWidth/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="TimelineWidth.cs" %}
{% include code-snippet/gantt/timeline/timelineWidth/timelineWidth.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/timeline/timelineWidth/razor %}
{% endhighlight %}
{% highlight c# tabtitle="TimelineWidth.cs" %}
{% include code-snippet/gantt/timeline/timelineWidth/timelineWidth.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Alt text](images/timelineWidth.png)

## Week start day customization

In the Gantt control, you can customize the week start day using the [`WeekStartDay`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttTimelineSettings.html#Syncfusion_EJ2_Gantt_GanttTimelineSettings_WeekStartDay) property. By default, the [`WeekStartDay`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttTimelineSettings.html#Syncfusion_EJ2_Gantt_GanttTimelineSettings_WeekStartDay) is set to 0, which specifies the Sunday as a start day of the week. But, you can customize the week start day by using the following code example.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/timeline/weekStartDay/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="WeekStartDay.cs" %}
{% include code-snippet/gantt/timeline/weekStartDay/weekStartDay.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/timeline/weekStartDay/razor %}
{% endhighlight %}
{% highlight c# tabtitle="WeekStartDay.cs" %}
{% include code-snippet/gantt/timeline/weekStartDay/weekStartDay.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Alt text](images/weekStartDay.png)

## Customize automatic timescale update action

In the Gantt control, the schedule timeline will be automatically updated when the tasks date values are updated beyond the project start date and end date ranges. This can be enabled or disabled using the [`UpdateTimescaleView`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttTimelineSettings.html#Syncfusion_EJ2_Gantt_GanttTimelineSettings_UpdateTimescaleView) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/timeline/updateTimescaleView/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="UpdateTimescaleView.cs" %}
{% include code-snippet/gantt/timeline/updateTimescaleView/updateTimescaleView.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/timeline/updateTimescaleView/razor %}
{% endhighlight %}
{% highlight c# tabtitle="UpdateTimescaleView.cs" %}
{% include code-snippet/gantt/timeline/updateTimescaleView/updateTimescaleView.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}