---
layout: post
title: Tooltip in ASP.NET Core Pivot Table | Syncfusion
description: Learn how the ASP.NET Core Pivot Table shows contextual tooltips on value cells and headers, with the showTooltip property to enable or disable them.
platform: ej2-asp-core-mvc
control: Pivot Table
publishingplatform: ##Platform_Name##
documentation: ug
---

# Tooltip in ASP.NET Core Pivot Table

The tooltip displays contextual information when users hover over value cells in the pivot table. It can be enabled or disabled by setting the [`showTooltip`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_ShowTooltip) property to **true** or **false**. By default, the tooltip is enabled in the pivot table and shows the cell value with its row and column headers.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pivot-tooltip/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ToolTip.cs" %}
{% include code-snippet/pivot-table/pivot-tooltip/ToolTip.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pivot-tooltip/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ToolTip.cs" %}
{% include code-snippet/pivot-table/pivot-tooltip/ToolTip.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Tooltip template

Users can customize the tooltip in the Pivot Table component by setting the [`tooltipTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_TooltipTemplate) property with their own HTML elements. This property accepts either an HTML string or an element ID. Use the following placeholders within the HTML to display dynamic values:

- `${rowHeaders}` – Displays the row headers for the selected value cell.
- `${columnHeaders}` – Displays the column headers for the selected value cell.
- `${rowFields}` – Displays the row fields of the selected value cell.
- `${columnFields}` – Displays the column fields of the selected value cell.
- `${valueField}` – Displays the value field name of the selected cell.
- `${aggregateType}` – Specifies the aggregate type of the selected value cell.
- `${value}` – Displays the formatted value of the selected value cell.

You can apply tooltip customization to both the Pivot Table and Pivot Chart together, or to either one individually. To customize the Pivot Table tooltip, define the HTML template via the [`tooltipTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_TooltipTemplate) property as described above. To set a custom tooltip for the Pivot Chart only, use the [`template`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPivotChartTooltipSettings.html) property within the [`tooltip`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewChartSettings.html#Syncfusion_EJ2_PivotView_PivotViewChartSettings_Tooltip) object of the [`chartSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewChartSettings.html) property.

The example below shows how to define the Pivot Table tooltip template in `index.html` and assign it to the [`tooltipTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_TooltipTemplate) property. The Pivot Chart tooltip is customized by setting an HTML string in the [`tooltip`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewChartSettings.html#Syncfusion_EJ2_PivotView_PivotViewChartSettings_Tooltip) property of [`chartSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewChartSettings.html).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/tooltip-template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip-template.cs" %}
{% include code-snippet/pivot-table/tooltip-template/tooltip-template.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/tooltip-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip-template.cs" %}
{% include code-snippet/pivot-table/tooltip-template/tooltip-template.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



<!-- markdownlint-disable MD012 -->
![Pivot table tooltip template](images/tooltipTemplate.png)
<br/>
<br/>
<br/>
![Pivot chart tooltip template](images/tooltipTemplate-chart.png)