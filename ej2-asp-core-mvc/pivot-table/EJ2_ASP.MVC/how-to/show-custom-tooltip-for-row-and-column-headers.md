---
layout: post
title: Add Custom Tooltip to Headers in ASP.NET MVC Pivot Table | Syncfusion
description: Learn how to show custom tooltips on ASP.NET MVC Pivot Table row and column headers via an external Tooltip component in the DataBound event.
platform: ej2-asp-core-mvc
control: Show tooltip for row and column headers
documentation: ug
publishingplatform: ##Platform_Name##
---

# How to add custom tooltips to ASP.NET MVC Pivot Table headers

You can display custom tooltips for row and column headers to provide additional context and information. This approach enhances the user experience by showing detailed field information when hovering over header cells in the pivot table.

## Implementation

To display tooltips for row and column headers, initialize an external `Tooltip` component within the Pivot Table's [`DataBound`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_DataBound)event. This ensures the tooltip is created only once, after the Pivot Table has finished rendering and is ready to interact with its elements. The tooltip targets both row and column header elements using specific CSS selectors: `td.e-rowsheader` for row headers and `th.e-columnsheader` for column headers.

For row header tooltips, the formatted text and field name of the current row header are retrieved from the [`PivotValues`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_PivotValues) and displayed in the tooltip. For column header tooltips, the text content of the respective column header element is extracted and displayed directly in the tooltip.

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
