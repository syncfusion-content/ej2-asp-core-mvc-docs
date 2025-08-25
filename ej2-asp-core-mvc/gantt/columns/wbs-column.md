---
layout: post
title: Work Breakdown Structure (WBS) in Syncfusion ##Platform_Name## Gantt Component
description: Learn how to enable and manage WBS codes in the Syncfusion ##Platform_Name## Gantt component to improve task hierarchy visualization and project tracking.
platform: ej2-asp-core-mvc
control: WBS Column
publishingplatform: ##Platform_Name##
documentation: ug
---

# Work Breakdown Structure (WBS) in Gantt Control

The Work Breakdown Structure (WBS) is a hierarchical numbering system that assigns unique and structured codes to each task, reflecting their positions within the overall project. This feature ensures data consistency and a clear, organized project view during operations such as sorting, filtering, editing, and drag-and-drop.

## Configuration and implementation

To enable and configure WBS in your Gantt component:

- **Enable WBS Codes**: Set the [`EnableWBS`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_EnableWBS) property to `true` to automatically generate unique task codes and their predecessors.
- **Auto-Update Codes**: Set the [`EnableAutoWbsUpdate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_EnableAutoWbsUpdate) property to `true` to maintain WBS code accuracy during operations like sorting, filtering, editing, or drag-and-drop.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/wbsColumn/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="WbsColumn.cs" %}
{% include code-snippet/gantt/columns/wbsColumn/wbsColumn.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/wbsColumn/razor %}
{% endhighlight %}
{% highlight c# tabtitle="WbsColumn.cs" %}
{% include code-snippet/gantt/columns/wbsColumn/wbsColumn.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Managing WBS code updates

For better performance, you can control when WBS codes are updated by using the [`ActionBegin`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_ActionBegin) and [`DataBound`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_DataBound) events. This is particularly useful during actions like dragging and dropping rows.

In the following example, WBS auto-update is enabled only during the **row drag and drop** action using these events.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/wbsColumnEvents/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="WbsColumnEvents.cs" %}
{% include code-snippet/gantt/columns/wbsColumnEvents/wbsColumnEvents.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/wbsColumnEvents/razor %}
{% endhighlight %}
{% highlight c# tabtitle="WbsColumnEvents.cs" %}
{% include code-snippet/gantt/columns/wbsColumnEvents/wbsColumnEvents.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Limitations

The WBS feature has a few limitations in the Gantt component:

- Editing of the WBS code and WBS predecessor columns is not supported.
- Load on demand is not supported with the WBS feature.
- WBS Code and WBS Predecessor fields cannot be mapped directly from the data source.