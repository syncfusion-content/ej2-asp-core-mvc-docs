---
layout: post
title: How to Show Custom Tooltip for Row and Column Headers in ASP.NET Core Pivot Table | Syncfusion
description: Learn how to show custom tooltips on ASP.NET Core Pivot Table row and column headers via an external Tooltip component initialized in the dataBound event handler.
platform: ej2-asp-core-mvc
control: Show tooltip for row and column headers 
documentation: ug
publishingplatform: ##Platform_Name##
---

# How to Show Custom Tooltip for Row and Column Headers in ASP.NET Core Pivot Table

You can display custom tooltips for row and column headers to provide additional context and information. This approach enhances the user experience by showing detailed field information when hovering over header cells in the pivot table.

## Implementation

To display tooltips for row and column headers, initialize an external [`tooltip`](https://ej2.syncfusion.com/aspnetcore/documentation/pivot-table/tool-tip) component within the Pivot Table's [`dataBound`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_DataBound) event. This ensures the tooltip is created only once, after the Pivot Table has finished rendering and is ready to interact with its elements. The tooltip targets both row and column header elements using specific CSS selectors: `td.e-rowsheader` for row headers and `th.e-columnsheader` for column headers.

For row header tooltips, the formatted text and field name of the current row header are retrieved from the [`pivotValues`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_PivotValues) and displayed in the tooltip. For column header tooltips, the text content of the respective column header element is extracted and displayed directly in the tooltip.

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