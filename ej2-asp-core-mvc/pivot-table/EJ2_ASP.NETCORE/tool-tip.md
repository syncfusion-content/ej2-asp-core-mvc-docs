---
layout: post
title: Tool Tip in ##Platform_Name## Pivot Table Component
description: Learn here all about Tool Tip in Syncfusion ##Platform_Name## Pivot Table component and more.
platform: ej2-asp-core-mvc
control: Tool Tip
publishingplatform: ##Platform_Name##
documentation: ug
---


# Tooltip

The tooltip can be enabled or disabled by setting the [`showTooltip`](https://ej2.syncfusion.com/react/documentation/api/pivotview/#showtooltip) property to **true**. By default, tooltip is enabled in the pivot table.

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



## Tooltip Template

User can design their own tooltip by setting the property [`tooltipTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_TooltipTemplate) with own HTML elements. The property accepts both HTML string and ID attribute. The following place holders are available to display its dynamic values inside the HTML elements.

`${rowHeaders}` – Row headers of the selected value cell.

`${columnHeaders}`  – Column headers of the selected value cell.

`${rowFields}` – Row fields of the selected value cell.

`${columnFields}` – Column fields of the selected value cell.

`${valueField}` – Field name of the selected value cell.

`${aggregateType}` – Aggregate type of the selected value cell.

`${value}` - Formatted value of the selected value cell.

The tooltip customization is common for both pivot table and pivot chart or it can be done individually as well. To customize the pivot table tooltip, the above procedure needs to be followed. To customize the pivot chart tooltip alone use `template` property of tooltip under [`e-chartSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewChartSettings.html).

In the below sample, the pivot table and pivot chart shows customized tooltip layouts.

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
![output](images/tooltipTemplate.png)
<br/>
<br/>
<br/>
![output](images/tooltipTemplate-chart.png)