---
layout: post
title: Resource Multi Taskbar  in ##Platform_Name## Gantt Component
description: Learn here all about Multi Taskbar  in Syncfusion ##Platform_Name## Gantt component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Resource Multi Taskbar 
publishingplatform: ##Platform_Name##
documentation: ug
---

# Resource Multi Taskbar in ##Platform_Name## Gantt Component

## Resource Multi Taskbar

To visualize multiple tasks assigned to each resource in a row when the records are in the collapsed state. It can be enabled by settings the `enableMultiTaskbar` property value as `true`.

The collapse or expand action of a resource record can be achieved only by using the tree grid side arrow icon. Because it will be disabled on chart side action for this support.

When a resource has multiple tasks scheduled on the same date, then the tasks will be overlapped one another. Taskbar editing is also possible to change the task scheduling on the collapsed state.

N> By default, the `enableMultiTaskbar` property value is `false`.

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

## Disable taskbar overlap

In Gantt, you can disable taskbar overlap between resource tasks using the [`AllowTaskbarOverlap`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_AllowTaskbarOverlap) property. This prevents the taskbars for different tasks from overlapping on the same row, making it easier to distinguish between the different tasks and manage resources effectively.

When `AllowTaskbarOverlap` is set to false, the resources are displayed in a single row and the row height will be extended to occupy the tasks of the resource when it is in a collapsed state. This view allows you to easily identify any overallocation of tasks for a resource in a project.

It's important to note that when `AllowTaskbarOverlap` is disabled, task dependencies or relationships cannot be established between tasks that are rendered in multiple lines for the same resource. If you need to establish dependencies between tasks for the same resource, you may want to consider enabling taskbar overlap.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/resource-view/taskbaroverlap/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="TaskbarOverlap.cs" %}
{% include code-snippet/gantt/resource-view/taskbaroverlap/taskbaroverlap.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/resource-view/taskbaroverlap/razor %}
{% endhighlight %}
{% highlight c# tabtitle="TaskbarOverlap.cs" %}
{% include code-snippet/gantt/resource-view/taskbaroverlap/taskbaroverlap.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}
