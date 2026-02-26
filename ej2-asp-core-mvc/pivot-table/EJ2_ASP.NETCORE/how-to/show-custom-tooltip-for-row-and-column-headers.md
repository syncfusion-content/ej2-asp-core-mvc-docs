---
layout: post
title: Show tooltip for row and column headers in ##Platform_Name## Pivot Table Component
description: Learn here all about Show tooltip for row and column headers in Syncfusion ##Platform_Name## Pivot Table component of syncfusion and more.
platform: ej2-asp-core-mvc
control: Show tooltip for row and column headers 
documentation: ug
publishingplatform: ##Platform_Name##
---

# Show tooltip for row and column headers in ##Platform_Name## Pivot Table Component

You can create and display the tooltip for each row and column header(s) in the pivot table by using an external tooltip component via the [`dataBound`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_DataBound) event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/custom-tooltip/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CustomTooltip.cs" %}
{% include code-snippet/pivot-table/custom-tooltip/CustomTooltip.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/custom-tooltip/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CustomTooltip.cs" %}
{% include code-snippet/pivot-table/custom-tooltip/CustomTooltip.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Show tooltip for row and column headers](../images/custom-tooltip.png)