---
layout: post
title: Print in ASP.NET Core Pivot Table | Syncfusion
description: Learn how the ASP.NET Core Pivot Table prints the current pivot report (table or chart) by invoking the print method on the underlying Grid or Chart component.
platform: ej2-asp-core-mvc
control: Pivot Table
documentation: ug
publishingplatform: ##Platform_Name##
---

# Print in ASP.NET Core Pivot Table

The ASP.NET Core Pivot Table component supports print functionality, allowing users to print the current state of the pivot table or pivot chart. This feature enables users to generate hard copies of pivot table reports for convenient review and data sharing.

## Print pivot table

Call the `print` method on the underlying [`Grid`](https://ej2.syncfusion.com/aspnetcore/documentation/grid/getting-started-core) instance to print the rendered pivot table. The [`Grid`](https://ej2.syncfusion.com/aspnetcore/documentation/grid/getting-started-core) control captures the current state of the pivot table, including all applied filters, sorting, and formatting.

> Pass options such as `{ pageSize: 'A4', orientation: 'landscape' }` to the `print()` method to control the page size and orientation of the printed output.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/print/print-table/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="PrintTable.cs" %}
{% include code-snippet/pivot-table/print/print-table/PrintTable.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/print/print-table/razor %}
{% endhighlight %}
{% highlight c# tabtitle="PrintTable.cs" %}
{% include code-snippet/pivot-table/print/print-table/PrintTable.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Print pivot chart

Call the `print` method on the underlying [`Chart`](https://ej2.syncfusion.com/aspnetcore/documentation/chart/getting-started) instance to print the pivot chart. The [`Chart`](https://ej2.syncfusion.com/aspnetcore/documentation/chart/getting-started) control preserves colors, legends, and data labels in the printed output.

> Set the [`e-displayOption`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDisplayOption.html) property to **Chart** or **Both** to display the pivot chart.

> To enable pivot chart functionality, inject the `PivotChart` module into the pivot table.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/print/print-chart/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="PrintChart.cs" %}
{% include code-snippet/pivot-table/print/print-chart/PrintChart.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/print/print-chart/razor %}
{% endhighlight %}
{% highlight c# tabtitle="PrintChart.cs" %}
{% include code-snippet/pivot-table/print/print-chart/PrintChart.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## See also

* [Pivot Chart](./pivot-chart)
* [Excel Export](./excel-export)
* [PDF Export](./pdf-export)
