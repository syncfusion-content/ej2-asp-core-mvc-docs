---
layout: post
title: Show tooltip for row and column headers in ##Platform_Name## Pivot Table Component
description: Learn here all about Show tooltip for row and column headers in Syncfusion ##Platform_Name## Pivot Table component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Show tooltip for row and column headers 
documentation: ug
publishingplatform: ##Platform_Name##
---

# Show tooltip for row and column headers in ##Platform_Name## Pivot Table Component

To display tooltips for row and column headers, initialize an external `Tooltip` component within the Pivot Table's [`DataBound`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_DataBound)event. This ensures the tooltip is created only once, after the Pivot Table has finished rendering and is ready to interact with its elements. The tooltip targets both row and column header elements using specific CSS selectors: `td.e-rowsheader` for row headers and `th.e-columnsheader` for column headers.

For row header tooltips, the formatted text and field name of the current row header are retrieved from the [`pivotValues`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_PivotValues) and displayed in the tooltip. For column header tooltips, the text content of the respective column header element is extracted and displayed directly in the tooltip.

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