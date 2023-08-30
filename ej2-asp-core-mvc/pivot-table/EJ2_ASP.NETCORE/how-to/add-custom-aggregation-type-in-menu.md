---
layout: post
title: Add custom aggregation type to the menu in ##Platform_Name## Pivot Table Component
description: Learn here all about how to add custom aggregation type to the menu in Syncfusion ##Platform_Name## Pivot Table component of syncfusion and more.
platform: ej2-asp-core-mvc
control: Add custom aggregation type to the menu
publishingplatform: ##Platform_Name## 
documentation: ug
---

<!-- markdownlint-disable MD009 -->

# Add custom aggregation type to the menu in ##Platform_Name## Pivot Table Component

By using the [`dataBound`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_DataBound) event, you can add your own custom aggregate type(s) to the pivot table's aggregate menu.

In the following example, we have added the aggregation types **CustomAggregateType 1** and **CustomAggregateType 2** to the aggregate menu. The calculation for those aggregated types can be done using the [`aggregateCellInfo`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_AggregateCellInfo) event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/add-custom-aggregation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CustomAggregation.cs" %}
{% include code-snippet/pivot-table/add-custom-aggregation/CustomAggregation.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/add-custom-aggregation/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CustomAggregation.cs" %}
{% include code-snippet/pivot-table/add-custom-aggregation/CustomAggregation.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Add custom aggregation type to the menu](../images/add-custom-aggregation-type-in-menu.png)