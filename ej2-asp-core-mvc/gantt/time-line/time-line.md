---
layout: post
title: Time Line in ##Platform_Name## Gantt Component
description: Learn here all about Time Line in Syncfusion ##Platform_Name## Gantt component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Time Line
publishingplatform: ##Platform_Name##
documentation: ug
---


# Timeline

In the Gantt control, timeline is used to represent the project duration as individual cells with defined unit and formats.

## Timeline view modes

Gantt contains the following in-built timeline view modes:

* Hour
* Week
* Month
* Year

Timescale mode in Gantt can be defined by using [`TimelineViewMode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.TimelineViewMode.html) property and also we can define timescale mode of top tier and bottom tier by using [`TopTier.Unit`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttTimelineTierSettings.html#Syncfusion_EJ2_Gantt_GanttTimelineTierSettings_Unit) and [`BottomTier.Unit`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttTimelineTierSettings.html#Syncfusion_EJ2_Gantt_GanttTimelineTierSettings_Unit) properties.

### Week timeline mode

In the `Week` timeline mode, the upper part of the schedule header displays the weeks, whereas the bottom half of the header displays the days. Refer to the following code example.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/timeline/weekMode/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="WeekMode.cs" %}
{% include code-snippet/gantt/timeline/weekMode/weekMode.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/timeline/weekMode/razor %}
{% endhighlight %}
{% highlight c# tabtitle="WeekMode.cs" %}
{% include code-snippet/gantt/timeline/weekMode/weekMode.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Alt text](images/weekMode.png)

### Month timeline mode

In the `Month` timeline mode, the upper part of the schedule header displays the months, whereas the bottom header of the schedule displays its corresponding weeks. Refer to the following code example.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/timeline/monthMode/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="MonthMode.cs" %}
{% include code-snippet/gantt/timeline/monthMode/monthMode.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/timeline/monthMode/razor %}
{% endhighlight %}
{% highlight c# tabtitle="MonthMode.cs" %}
{% include code-snippet/gantt/timeline/monthMode/monthMode.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Alt text](images/monthMode.png)

### Year timeline mode

In the `Year` timeline mode, the upper schedule header displays the years whereas, the bottom header displays its corresponding months. Refer to the following code example.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/timeline/yearMode/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="YearMode.cs" %}
{% include code-snippet/gantt/timeline/yearMode/yearMode.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/timeline/yearMode/razor %}
{% endhighlight %}
{% highlight c# tabtitle="YearMode.cs" %}
{% include code-snippet/gantt/timeline/yearMode/yearMode.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Alt text](images/yearMode.png)

### Day timeline mode

In the `Day` timeline mode, the upper part of the header displays the days whereas, the bottom schedule header displays its corresponding hours. Refer to the following code example.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/timeline/dayMode/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="DayMode.cs" %}
{% include code-snippet/gantt/timeline/dayMode/dayMode.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/timeline/dayMode/razor %}
{% endhighlight %}
{% highlight c# tabtitle="DayMode.cs" %}
{% include code-snippet/gantt/timeline/dayMode/dayMode.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Alt text](images/dayMode.png)

### Hour timeline mode

An `Hour` timeline mode tracks the tasks in minutes scale. In this mode, the upper schedule header displays hour scale and the lower schedule header displays its corresponding minutes.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/timeline/hourMode/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="HourMode.cs" %}
{% include code-snippet/gantt/timeline/hourMode/hourMode.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/timeline/hourMode/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HourMode.cs" %}
{% include code-snippet/gantt/timeline/hourMode/hourMode.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Alt text](images/hourMode.png)