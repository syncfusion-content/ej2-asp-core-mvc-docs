---
layout: post
title: Print in ASP.NET MVC Pivot Table | Syncfusion
description: Learn how the ASP.NET MVC Pivot Table prints pivot table and pivot chart content directly from the browser with options to control the print layout.
platform: ej2-asp-core-mvc
control: Print 
documentation: ug
publishingplatform: ##Platform_Name##
---

# Print in ASP.NET MVC Pivot Table

The ASP.NET MVC Pivot Table component supports print functionality, allowing users to print the current state of the pivot table or pivot chart. This feature enables users to generate hard copies of pivot table reports for convenient review and data sharing.

## Print pivot table

Call the `print` method on the underlying [`Grid`](https://ej2.syncfusion.com/aspnetmvc/documentation/grid/getting-started-mvc) instance (accessed via the `grid` property of the `pivotObj` ref) to print the rendered pivot table. The [`Grid`](https://ej2.syncfusion.com/aspnetmvc/documentation/grid/getting-started-mvc) control captures the current state of the pivot table, including all applied filters, sorting, and formatting. The sample code below demonstrates how to trigger the print operation using an external button click.

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

Call the `print` method on the underlying  [`Chart`](https://ej2.syncfusion.com/aspnetmvc/documentation/chart/getting-started) instance (accessed via the `chart` property of the `PivotViewComponent` ref) to print the pivot chart. The [`Chart`](https://ej2.syncfusion.com/aspnetmvc/documentation/chart/getting-started) control preserves colors, legends, and data labels in the printed output.

> Set the [`PivotViewDisplayOption`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewDisplayOption.html) property to **Chart** or **Both** to display the pivot chart.

The sample below prints the pivot chart when an external button is clicked.


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