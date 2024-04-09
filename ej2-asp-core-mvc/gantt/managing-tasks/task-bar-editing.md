---
layout: post
title: Taskbar Editing in Syncfusion ##Platform_Name## Gantt Component
description: Learn here all about taskbar editing in Syncfusion ##Platform_Name## Gantt component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Managing Tasks
publishingplatform: ##Platform_Name##
documentation: ug
---


# Taskbar editing action in gantt control

## Taskbar editing

Modify the task details through user interaction such as resizing and dragging the taskbar by enabling the [`AllowTaskbarEditing`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttEditSettings.html#Syncfusion_EJ2_Gantt_GanttEditSettings_AllowTaskbarEditing) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/enableTaskbarEditing/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="EnableTaskbarEditing.cs" %}
{% include code-snippet/gantt/editing/enableTaskbarEditing/enableTaskbarEditing.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/enableTaskbarEditing/razor %}
{% endhighlight %}
{% highlight c# tabtitle="EnableTaskbarEditing.cs" %}
{% include code-snippet/gantt/editing/enableTaskbarEditing/enableTaskbarEditing.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Prevent editing for specific tasks

On taskbar edit action, the [`TaskbarEditing`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_TaskbarEditing) event will be triggered. You can prevent the taskbar from editing using the [`TaskbarEditing`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_TaskbarEditing) event. This can be done by setting cancel property of [`TaskbarEditing`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_TaskbarEditing) event argument to true. And we can hide the taskbar editing indicators like taskbar resizer, progress resizer and connector points by using [`QueryTaskbarInfo`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_QueryTaskbarInfo) event. The following code example shows how to achieve this.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/preventTaskbarEditing/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="PreventTaskbarEditing.cs" %}
{% include code-snippet/gantt/editing/preventTaskbarEditing/preventTaskbarEditing.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/preventTaskbarEditing/razor %}
{% endhighlight %}
{% highlight c# tabtitle="PreventTaskbarEditing.cs" %}
{% include code-snippet/gantt/editing/preventTaskbarEditing/preventTaskbarEditing.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

