---
layout: post
title: Splitting and merging task in Syncfusion ##Platform_Name## Gantt Component
description: Learn here all about Splitting and merging task in Syncfusion ##Platform_Name## Gantt component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Managing Tasks
publishingplatform: ##Platform_Name##
documentation: ug
---


# Splitting and Merging tasks

## Splitting task at load time

To split task at load time, we can define segment details in both hierarchical and self-referential way. Refer below link for more details.

* [Split task at load time](https://ej2.syncfusion.com/aspnetmvc/documentation/gantt/data-binding#split-task)

## Split task dynamically

The task can be split dynamically, either by using the context menu or dialog.

* `Dialog`: `Segments` tab is rendered in add/edit dialog, when the [`TaskFields.Segments`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_SegmentData) or [`TaskFields.segmentId`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_SegmentData) property is mapped. Using this tab, we can split the task based on the original start and end date of a particular task.

* `Context menu`: When the [`TaskFields.Segments`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_SegmentData) or [`TaskFields.SegmentId`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_SegmentData) property is mapped and the [`EnableContextMenu`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_EnableContextMenu) property is enabled, `Split Task` item will be included in the context menu.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/split-tasks/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Split-tasks.cs" %}
{% include code-snippet/gantt/editing/split-tasks/split-tasks.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/split-tasks/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Split-tasks.cs" %}
{% include code-snippet/gantt/editing/split-tasks/split-tasks.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Alt text](images/split-tasks.png)

![Alt text](images/split-contextmenu.png)

![Alt text](images/merge-contextmenu.png)

![Alt text](images/segment-tab.png)

## Merge tasks

The split tasks can be merged either by using the `Merge Task` item of the Context menu or by using the dialog. We can also merge the tasks, by simply dragging the segments together in the UI.

## Limitations of Split tasks

1. Parent and milestone tasks cannot be split into segments.
2. The task must have a width greater than the timeline unit cell in order to be split.
3. Split task is not supported in the `Resource view`.