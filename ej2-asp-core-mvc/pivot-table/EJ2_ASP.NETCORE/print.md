---
layout: post
title: Print in ##Platform_Name## Syncfusion Pivot Table Component
description: Learn here all about Print in Syncfusion ##Platform_Name## Pivot Table component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Print 
documentation: ug
publishingplatform: ##Platform_Name##
---

# Print in ##Platform_Name## Pivot Table Component

The rendered pivot table can be printed directly from the browser by invoking the `print` method from the grid's instance. The below sample code illustrates the print option being invoked by an external button click.

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

Similarly, to print the pivot chart, use the `print` method from the chart's instance. The below sample code illustrates the print option being invoked by an external button click.

> To display the pivot chart, set the [`e-displayOption`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDisplayOption.html) property to either **Chart** or **Both**. 

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