---
layout: post
title: Event Markers in ##Platform_Name## Gantt Component
description: Learn here all about Event Markers in Syncfusion ##Platform_Name## Gantt component and more.
platform: ej2-asp-core-mvc
control: Event Markers
publishingplatform: ##Platform_Name##
documentation: ug
---


# Event Markers

The event markers in the Gantt control is used to highlight the important events in a project. Event markers can be initialized by using the [`EventMarkers`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_EventMarkers) property, and you can define date and label for the event markers using the [`Day`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttEventMarker.html#Syncfusion_EJ2_Gantt_GanttEventMarker_Day) and [`Label`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttEventMarker.html#Syncfusion_EJ2_Gantt_GanttEventMarker_Label) properties. You can also customize it using the [`CssClass`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttEventMarker.html#Syncfusion_EJ2_Gantt_GanttEventMarker_CssClass) properties. The following code example shows how to add event markers in the Gantt control.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/eventmarkers/eventmarkers/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Eventmarkers.cs" %}
{% include code-snippet/gantt/eventmarkers/eventmarkers/eventmarkers.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/eventmarkers/eventmarkers/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Eventmarkers.cs" %}
{% include code-snippet/gantt/eventmarkers/eventmarkers/eventmarkers.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Alt text](images/eventmarkers.png)