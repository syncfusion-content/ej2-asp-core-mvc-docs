---
layout: post
title: Export Print in ##Platform_Name## Stock Chart Component
description: Learn here all about Export Print in Syncfusion ##Platform_Name## Stock Chart component and more.
platform: ej2-asp-core-mvc
control: Export Print
publishingplatform: ##Platform_Name##
documentation: ug
---


# Print and Export

The rendered stock chart can be exported to `JPEG`, `PNG`, `SVG`, or `PDF` format using the export dropdown button in the period selector toolbar. You can choose the required format using the export dropdown button in stock-chart.

The rendered stock chart can be printed directly using print button in period selector toolbar.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/getting-started/print/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Print.cs" %}
{% include code-snippet/stock-chart/getting-started/print/print.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/getting-started/print/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Print.cs" %}
{% include code-snippet/stock-chart/getting-started/print/print.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Disable Export and print

To empty the value of `ExportType` for to disable the Export button.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/getting-started/disable/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Disable.cs" %}
{% include code-snippet/stock-chart/getting-started/disable/disable.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/getting-started/disable/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Disable.cs" %}
{% include code-snippet/stock-chart/getting-started/disable/disable.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

