---
layout: post
title: Tooltip in ##Platform_Name## Gantt Component
description: Learn here all about Tooltip in Syncfusion ##Platform_Name## Gantt component and more.
platform: ej2-asp-core-mvc
control: Tooltip
publishingplatform: ##Platform_Name##
documentation: ug
---


# Tooltip

The Gantt control has a support to display a tooltip for various UI elements like taskbar, timeline cells, and grid cells

## Enable tooltip

In the Gantt control, you can enable or disable the mouse hover tooltip for the following UI elements using the [`TooltipSettings.ShowTooltip`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttTooltipSettings.html#Syncfusion_EJ2_Gantt_GanttTooltipSettings_ShowTooltip) property:

* Taskbar
* Connector line
* Baseline
* Event marker

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/tooltip/enableTooltip/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="EnableTooltip.cs" %}
{% include code-snippet/gantt/tooltip/enableTooltip/enableTooltip.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/tooltip/enableTooltip/razor %}
{% endhighlight %}
{% highlight c# tabtitle="EnableTooltip.cs" %}
{% include code-snippet/gantt/tooltip/enableTooltip/enableTooltip.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Alt text](images/taskbar-tooltip.png)

Taskbar Tooltip

![Alt text](images/dependency-tooltip.png)

Dependency Tooltip

![Alt text](images/baseline-tooltip.png)

Baseline Tooltip

![Alt text](images/event-marker-tooltip.png)

Event Marker Tooltip

> The default value of the [`TooltipSettings.ShowTooltip`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttTooltipSettings.html#Syncfusion_EJ2_Gantt_GanttTooltipSettings_ShowTooltip) property is true.

## Timeline cells tooltip

In the Gantt control, you can enable or disable the mouse hover tooltip of timeline cells using the [`TimelineSettings.ShowTooltip`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttTimelineSettings.html#Syncfusion_EJ2_Gantt_GanttTimelineSettings_ShowTooltip) property. The default value of this property is true. The following code example shows how to enable the timeline cells tooltip in Gantt.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/tooltip/timelinecellTooltip/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="TimelinecellTooltip.cs" %}
{% include code-snippet/gantt/tooltip/timelinecellTooltip/timelinecellTooltip.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/tooltip/timelinecellTooltip/razor %}
{% endhighlight %}
{% highlight c# tabtitle="TimelinecellTooltip.cs" %}
{% include code-snippet/gantt/tooltip/timelinecellTooltip/timelinecellTooltip.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Alt text](images/timelinecellTooltip.png)

## Cell tooltip

You can enable or disable the Grid cell tooltip using the [`Columns.ClipMode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttColumn.html#Syncfusion_EJ2_Gantt_GanttColumn_ClipMode) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/tooltip/gridcellTooltip/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="GridcellTooltip.cs" %}
{% include code-snippet/gantt/tooltip/gridcellTooltip/gridcellTooltip.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/tooltip/gridcellTooltip/razor %}
{% endhighlight %}
{% highlight c# tabtitle="GridcellTooltip.cs" %}
{% include code-snippet/gantt/tooltip/gridcellTooltip/gridcellTooltip.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Clip mode

The clip mode provides options to display its overflow cell content and it can be defined by the [`Columns.ClipMode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttColumn.html#Syncfusion_EJ2_Gantt_GanttColumn_ClipMode) property.

The following are three types of `ClipMode`:

* `Clip`: Truncates the cell content when it overflows its area.
* `Ellipsis`: Displays ellipsis when content of the cell overflows its area.
* `EllipsisWithTooltip`: Displays ellipsis when content of the cell overflows its area; it displays the tooltip content when hover over ellipsis.

> NOTE
> By default, all the column's [`ClipMode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttColumn.html#Syncfusion_EJ2_Gantt_GanttColumn_ClipMode) property is defined as `EllipsisWithTooltip`.

## Tooltip template

### Taskbar tooltip

The default tooltip in the Gantt control can be customized using the [`TooltipSettings.Taskbar`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttTooltipSettings.html#Syncfusion_EJ2_Gantt_GanttTooltipSettings_Taskbar) property. You can map the template script element’s ID value or template string directly to this property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/tooltip/taskbarTemplate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="TaskbarTemplate.cs" %}
{% include code-snippet/gantt/tooltip/taskbarTemplate/taskbarTemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/tooltip/taskbarTemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="TaskbarTemplate.cs" %}
{% include code-snippet/gantt/tooltip/taskbarTemplate/taskbarTemplate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



The below screenshot shows the output of above code example.

![Alt text](images/taskbarTemplate.png)

### Connector line tooltip

The default connector line tooltip in the Gantt control can be customized using the [`TooltipSettings.ConnectorLine`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttTooltipSettings.html#Syncfusion_EJ2_Gantt_GanttTooltipSettings_ConnectorLine) property. You can map the value to this property as template script element ID or template string format. The following code example shows how to use the [`TooltipSettings.ConnectorLine`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttTooltipSettings.html#Syncfusion_EJ2_Gantt_GanttTooltipSettings_ConnectorLine) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/tooltip/dependencyLineTemplate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="DependencyLineTemplate.cs" %}
{% include code-snippet/gantt/tooltip/dependencyLineTemplate/dependencyLineTemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/tooltip/dependencyLineTemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="DependencyLineTemplate.cs" %}
{% include code-snippet/gantt/tooltip/dependencyLineTemplate/dependencyLineTemplate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



The below screenshot shows the output of above code example.

![Alt text](images/dependencyLineTemplate.png)

### Taskbar editing tooltip

The taskbar editing tooltip can be customized using the [`TooltipSettings.Editing`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttTooltipSettings.html#Syncfusion_EJ2_Gantt_GanttTooltipSettings_Editing) property. The following code example shows how to customize the taskbar editing tooltip in Gantt.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/tooltip/editingTemplate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="EditingTemplate.cs" %}
{% include code-snippet/gantt/tooltip/editingTemplate/editingTemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/tooltip/editingTemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="EditingTemplate.cs" %}
{% include code-snippet/gantt/tooltip/editingTemplate/editingTemplate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



The below screenshot shows the output of above code example.

![Alt text](images/editingTemplate.png)

### Baseline tooltip

A baseline tooltip can be customized using the [`TooltipSettings.Baseline`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttTooltipSettings.html#Syncfusion_EJ2_Gantt_GanttTooltipSettings_Baseline) property. The following code example shows how to customize the baseline tooltip in Gantt.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/tooltip/baselineTemplate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="BaselineTemplate.cs" %}
{% include code-snippet/gantt/tooltip/baselineTemplate/baselineTemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/tooltip/baselineTemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="BaselineTemplate.cs" %}
{% include code-snippet/gantt/tooltip/baselineTemplate/baselineTemplate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



The following screenshot shows the template for baseline in Gantt.

![Alt text](images/baselineTemplate.png)