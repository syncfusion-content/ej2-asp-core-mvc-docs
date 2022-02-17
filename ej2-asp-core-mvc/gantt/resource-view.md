---
layout: post
title: Resource View in ##Platform_Name## Gantt Component
description: Learn here all about Resource View in Syncfusion ##Platform_Name## Gantt component and more.
platform: ej2-asp-core-mvc
control: Resource View
publishingplatform: ##Platform_Name##
documentation: ug
---


# Resource Breakdown View

The resource breakdown view is used to visualize the tasks assigned to each resource in hierarchy manner. Resources are displayed as parents and all the tasks assigned to each resource are displayed as its child records. It can be initialized by setting the [`viewType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.ViewType.html) property to `ResourceView`.

## Unassigned task

A task not assigned to any one of the resource are termed as unassigned tasks. The unassigned tasks are grouped with a name as `Unassigned Task` and displayed at the bottom of Gantt data collection . It is validated at load time during Gantt record creation by default based on a task [`resourceInfo`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttTaskFieldsBuilder.html#Syncfusion_EJ2_Gantt_GanttTaskFieldsBuilder_ResourceInfo_System_String_) mapping property in the Gantt chart data source. If the resource is assigned to the unassigned grouped tasks, the task will be moved as child to the respective resource.

## Resource task

A task assigned to one or more resources are termed as resource task and it is added as child task to the respective resource. Already assigned task can also be shared or moved with other resources by adding a resource name to the task or removing resource name from the task by cell or dialog editing.

> Currently there is no support for unscheduled task in Resource view Gantt.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/resource-view/resourceView/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ResourceView.cs" %}
{% include code-snippet/gantt/resource-view/resourceView/resourceView.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/resource-view/resourceView/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ResourceView.cs" %}
{% include code-snippet/gantt/resource-view/resourceView/resourceView.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Alt text](images/resourceView.png)

## Resource OverAllocation

When a resource is assigned too much of work to complete within a day of resource’s available time then it is called as overallocation.

The available working time of resources for completing the task in a day will be calculated based on the `dayWorkingTime` property and `resource unit`.

The range of overallocation dates can be highlighted by a square bracket. It can be enabled by setting the `showOverallocation` property as `true`. The following code example demonstrates how to hide or show the over allocation by clicking the custom button.

> By default, the `showOverAllocation` property value is `false`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/resource-view/showhide/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Showhide.cs" %}
{% include code-snippet/gantt/resource-view/showhide/showhide.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/resource-view/showhide/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Showhide.cs" %}
{% include code-snippet/gantt/resource-view/showhide/showhide.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Alt text](images/showhide.PNG)

## Resource Multi Taskbar

To visualize multiple tasks assigned to each resource in a row when the records are in the collapsed state. It can be enabled by settings the `enableMultiTaskbar` property value as `true`.

The collapse or expand action of a resource record can be achieved only by using the tree grid side arrow icon. Because it will be disabled on chart side action for this support.

When a resource has multiple tasks scheduled on the same date, then the tasks will be overlapped one another. Taskbar editing is also possible to change the task scheduling on the collapsed state.

> By default, the `enableMultiTaskbar` property value is `false`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/resource-view/multitaskbar/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Multitaskbar.cs" %}
{% include code-snippet/gantt/resource-view/multitaskbar/multitaskbar.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/resource-view/multitaskbar/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Multitaskbar.cs" %}
{% include code-snippet/gantt/resource-view/multitaskbar/multitaskbar.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Alt text](images/multitaskbar.PNG)