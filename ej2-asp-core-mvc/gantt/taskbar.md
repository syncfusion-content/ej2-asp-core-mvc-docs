---
layout: post
title: Taskbar in ##Platform_Name## Syncfusion Gantt Component
description: Learn here all about Taskbar in Syncfusion ##Platform_Name## Gantt component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Taskbar
publishingplatform: ##Platform_Name##
documentation: ug
---

# Taskbar in ##Platform_Name## Gantt Chart Component

## Taskbar template

You can design your own taskbars to view the tasks in Gantt by using [`TaskbarTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_TaskbarTemplate) property. And it is possible to map the template script element’s ID value to this property. It is also possible to customize the parent taskbars and milestones with custom templates by using [`ParentTaskbarTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_ParentTaskbarTemplate) and [`MilestoneTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_MilestoneTemplate) properties.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/customizations/taskbarTemplate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="TaskbarTemplate.cs" %}
{% include code-snippet/gantt/customizations/taskbarTemplate/taskbarTemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/customizations/taskbarTemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="TaskbarTemplate.cs" %}
{% include code-snippet/gantt/customizations/taskbarTemplate/taskbarTemplate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Alt text](images/taskbarTemplate1.png)

## Taskbar customization

### Taskbar Height

Height of child taskbars and parent taskbars can be customized by using [`TaskbarHeight`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_TaskbarHeight) property. The following code example shows how to use the property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/appearance-and-styling/taskbarHeight/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="TaskbarHeight.cs" %}
{% include code-snippet/gantt/appearance-and-styling/taskbarHeight/taskbarHeight.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/appearance-and-styling/taskbarHeight/razor %}
{% endhighlight %}
{% highlight c# tabtitle="TaskbarHeight.cs" %}
{% include code-snippet/gantt/appearance-and-styling/taskbarHeight/taskbarHeight.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Alt text](images/taskbarHeight.png)

N> The [`TaskbarHeight`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_TaskbarHeight) value should be lower than the [`RowHeight`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_RowHeight) property value and these properties accept only pixel values.

### Conditional formatting

The default taskbar UI can be replaced with custom templates using the [`QueryTaskbarInfo`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_QueryTaskbarInfo) event. The following code example shows customizing the taskbar UI based on task progress values in the Gantt control.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/appearance-and-styling/conditionalFormatting/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ConditionalFormatting.cs" %}
{% include code-snippet/gantt/appearance-and-styling/conditionalFormatting/conditionalFormatting.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/appearance-and-styling/conditionalFormatting/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ConditionalFormatting.cs" %}
{% include code-snippet/gantt/appearance-and-styling/conditionalFormatting/conditionalFormatting.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Alt text](images/conditionalFormatting.png)


### Change gripper icon in taskbar

You can change the gripper icon in the taskbar by applying styles to their respective class elements.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/change-gripper-icon/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="data.cs" %}
{% include code-snippet/gantt/change-gripper-icon/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/change-gripper-icon/razor %}
{% endhighlight %}
{% highlight c# tabtitle="data.cs" %}
{% include code-snippet/gantt/change-gripper-icon/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Change Gripper Icon in Taskbar](images/change-gripper-icon.png)

## Multi Taskbar support in project view

The Gantt component, supports rendering multi-taskbars in the project view. With this feature the parent taskbar, when it is collapsed, visually summarize the progress of all its child taskbars.

This feature can be enabled by setting the [EnableMultiTaskbar](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_EnableMultiTaskbar) property value to `true`. 

The following code example shows how to use this property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/projectview-multitaskbar-cs1/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Projectview-multitaskbar.cs" %}
{% include code-snippet/gantt/projectview-multitaskbar-cs1/projectview-multitaskbar.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/projectview-multitaskbar-cs1/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Projectview-multitaskbar.cs" %}
{% include code-snippet/gantt/projectview-multitaskbar-cs1/Projectview-multitaskbar.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Multitaskbar support in projectview](images/project-multitaskbar.png)

## Connector lines

The width and background color of connector lines in Gantt can be customized using the [`ConnectorLineWidth`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_ConnectorLineWidth) and [`ConnectorLineBackground`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_ConnectorLineBackground) properties. The following code example shows how to use these properties.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/appearance-and-styling/dependencyFormatting/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="DependencyFormatting.cs" %}
{% include code-snippet/gantt/appearance-and-styling/dependencyFormatting/dependencyFormatting.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/appearance-and-styling/dependencyFormatting/razor %}
{% endhighlight %}
{% highlight c# tabtitle="DependencyFormatting.cs" %}
{% include code-snippet/gantt/appearance-and-styling/dependencyFormatting/dependencyFormatting.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Alt text](images/dependencyFormatting.png)

## Tooltip

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

N> The default value of the [`TooltipSettings.ShowTooltip`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttTooltipSettings.html#Syncfusion_EJ2_Gantt_GanttTooltipSettings_ShowTooltip) property is true.

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

### Timeline tooltip

A timeline tooltip can be customized using the [`TooltipSettings.Timeline`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttTooltipSettings.html#Syncfusion_EJ2_Gantt_GanttTooltipSettings_Timeline) property. This allows modifying the appearance and content of the tooltip displayed over the timeline. The following code example shows how to customize the timeline tooltip in Gantt.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/tooltip/timelineTooltipTemplate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="TimelineTooltipTemplate.cs" %}
{% include code-snippet/gantt/tooltip/timelineTooltipTemplate/timelineTooltipTemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/tooltip/timelineTooltipTemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="TimelineTooltipTemplate.cs" %}
{% include code-snippet/gantt/tooltip/timelineTooltipTemplate/timelineTooltipTemplate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


The below screenshot shows the output of above code example.

![Alt text](images/tooltiptemplate.png)
