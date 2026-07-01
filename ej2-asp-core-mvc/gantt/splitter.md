---
layout: post
title: Splitter in ##Platform_Name## Gantt Component
description: Learn here all about Splitter in Syncfusion ##Platform_Name## Gantt component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Splitter
publishingplatform: ##Platform_Name##
documentation: ug
---


# Splitter in ##Platform_Name## Gantt component

## Splitter

In the Gantt control, the Splitter separates the TreeGrid section from the Chart section. You can change the position of the Splitter when loading the Gantt control using the [`SplitterSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_SplitterSettings) property. By splitting the TreeGrid from the chart, the width of the TreeGrid and chart sections will vary in the control. The [`SplitterSettings.Position`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttSplitterSettings.html#Syncfusion_EJ2_Gantt_GanttSplitterSettings_Position) property denotes the percentage of the TreeGrid section’s width to be rendered and this property supports both pixels and percentage values. You can define the splitter position as column index value using the [`SplitterSettings.ColumnIndex`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttSplitterSettings.html#Syncfusion_EJ2_Gantt_GanttSplitterSettings_ColumnIndex) property. You can also define the splitter position with built-in splitter view modes by using the [`SplitterSettings.View`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttSplitterSettings.html#Syncfusion_EJ2_Gantt_GanttSplitterSettings_View) property. The following list is the possible values for this property:

* `Default`: Shows Grid side and Gantt side.
* `Grid`: Shows Grid side alone in Gantt.
* `Chart`: Shows chart side alone in Gantt.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/how-to/changeSplitter/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ChangeSplitter.cs" %}
{% include code-snippet/gantt/how-to/changeSplitter/changeSplitter.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/how-to/changeSplitter/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ChangeSplitter.cs" %}
{% include code-snippet/gantt/how-to/changeSplitter/changeSplitter.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Alt text](images/changeSplitter.png)

## Change splitter position dynamically

In Gantt, we can change the splitter position dynamically by using `setSplitterPosition` method. We can change the splitter position by passing value and type parameter to `setSplitterPosition` method. Type parameter will accept one of the following values 'position', 'columnIndex', 'viewType'. The following code example shows how to use this method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/how-to/setSplitterPosition/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="SetSplitterPosition.cs" %}
{% include code-snippet/gantt/how-to/setSplitterPosition/setSplitterPosition.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/how-to/setSplitterPosition/razor %}
{% endhighlight %}
{% highlight c# tabtitle="SetSplitterPosition.cs" %}
{% include code-snippet/gantt/how-to/setSplitterPosition/setSplitterPosition.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}
