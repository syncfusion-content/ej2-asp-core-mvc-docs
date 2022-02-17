---
layout: post
title: Data Markers in ##Platform_Name## Gantt Component
description: Learn here all about Data Markers in Syncfusion ##Platform_Name## Gantt component and more.
platform: ej2-asp-core-mvc
control: Data Markers
publishingplatform: ##Platform_Name##
documentation: ug
---


# Data markers

Data markers are a set of events used to represent the schedule events for a task. Data markers are defined in data source as array of objects, and this value is mapped to the Gantt control using the [`taskFields.indicators`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttTaskFields.html#Syncfusion_EJ2_Gantt_GanttTaskFields_Indicators) property. You can represent more than one data marker in a task.

Data markers can be defined using the following properties:

* `date`: Defines the date of indicator.
* `iconClass`: Defines the icon class of indicator.
* `name`: Defines the name of indicator.
* `tooltip`: Defines the tooltip of indicator.

> Data Marker `tooltip` will be rendered only if tooltip property has value.

The following code example demonstrates how to implement data markers in the Gantt chart.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/datamarkers/datamarkers/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Datamarkers.cs" %}
{% include code-snippet/gantt/datamarkers/datamarkers/datamarkers.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/datamarkers/datamarkers/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Datamarkers.cs" %}
{% include code-snippet/gantt/datamarkers/datamarkers/datamarkers.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Alt text](images/indicators.PNG)