---
layout: post
title: Critical Path in Syncfusion ##Platform_Name## Gantt Component
description: Learn here all about Critical Path in Syncfusion ##Platform_Name## Gantt component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Index
publishingplatform: ##Platform_Name##
documentation: ug
---


# Critical Path feature

The critical path in a project is indicated by a single task or a series of tasks. If a task in critical path is delayed, the entire project will be delayed. A task is considered to be critical if any delay to this task would affect the project end date.

The critical path can be enabled in Gantt by using the built-in toolbar button or `enableCriticalPath` to true.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/criticalpath/default/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Criticalpath.cs" %}
{% include code-snippet/gantt/criticalpath/default/criticalpath.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/criticalpath/default/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Criticalpath.cs" %}
{% include code-snippet/gantt/criticalpath/default/criticalpath.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Alt text](images/criticalpath.PNG)

## Customize taskbar in critical path

The taskbar in critical path can be customized by using `queryTaskbarInfo` event and `isCritical` property of row `data` in the event arugment.

The following code example shows how to customize the critical path taskbar in the Gantt control:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/criticalpath/custom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Customcriticalpath.cs" %}
{% include code-snippet/gantt/criticalpath/custom/customcriticalpath.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/criticalpath/custom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Customcriticalpath.cs" %}
{% include code-snippet/gantt/criticalpath/custom/customcriticalpath.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Alt text](images/customCriticalPath.PNG)


