---
layout: post
title: Column spanning in Syncfusion ##Platform_Name## Gantt Component
description: Learn here all about Column spanning in Syncfusion ##Platform_Name## Gantt component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Columns
publishingplatform: ##Platform_Name##
documentation: ug
---


# Column Spanning in gantt control

The gantt has option to span the adjacent cells. You need to define the `colSpan` attribute to span cells in the [`QueryCellInfo`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_QueryCellInfo) event.

In the following demo, **Work 1** cells have been spanned.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/colSpan/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ColSpan.cs" %}
{% include code-snippet/gantt/columns/colSpan/colSpan.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/colSpan/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ColSpan.cs" %}
{% include code-snippet/gantt/columns/colSpan/colSpan.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Alt text](images/colspan.png)