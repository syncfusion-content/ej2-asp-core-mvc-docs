---
layout: post
title: Drill Through in ##Platform_Name## Pivot Table Component
description: Learn here all about Drill Through in Syncfusion ##Platform_Name## Pivot Table component and more.
platform: ej2-asp-core-mvc
control: Drill Through
publishingplatform: ##Platform_Name##
documentation: ug
---

<!-- markdownlint-disable MD012 -->

# Drill Through

Allows to view the underlying raw data of a summarized cell in the pivot table. It can be enabled by setting the [`AllowDrillThrough`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_AllowDrillThrough) property to **true**. By double-clicking on any value cell, user can view the detailed raw data in a data grid inside a new window. In the new window, row header, column header and measure name of the clicked cell will be shown at the top. Also, user can include or exclude fields available in the data grid using column chooser option.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/drill-through/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="DrillThrough.cs" %}
{% include code-snippet/pivot-table/drill-through/DrillThrough.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/drill-through/razor %}
{% endhighlight %}
{% highlight c# tabtitle="DrillThrough.cs" %}
{% include code-snippet/pivot-table/drill-through/DrillThrough.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![output](images/drillthrough.png)