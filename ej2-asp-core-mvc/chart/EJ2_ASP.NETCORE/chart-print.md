---
layout: post
title: Chart Print in ##Platform_Name## Chart Component
description: Learn here all about Chart Print in Syncfusion ##Platform_Name## Chart component and more.
platform: ej2-asp-core-mvc
control: Chart Print
publishingplatform: ##Platform_Name##
documentation: ug
---


# Print and Export

## Print

The rendered chart can be printed directly from the browser by calling the public method print.
You can pass array of ID of elements or element to this method. By default it take element of the chart.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/getting-started/print/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Print.cs" %}
{% include code-snippet/chart/getting-started/print/print.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/getting-started/print/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Print.cs" %}
{% include code-snippet/chart/getting-started/print/print.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Export

The rendered chart can be exported to `JPEG`, `PNG`, `SVG`, or `PDF` format using the export method in chart. The input parameters for this method are `Export Type` for format and `fileName` for result.

The optional parameters for this method are,
* `orientation` - either portrait or landscape,
* `controls` - pass collections of controls for multiple export,
* `width` - width of chart export,
* `height` - height of chart export,
* `header` - header for the exported chart, and
* `footer` - footer for the exported chart.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/getting-started/export/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Export.cs" %}
{% include code-snippet/chart/getting-started/export/export.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/getting-started/export/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Export.cs" %}
{% include code-snippet/chart/getting-started/export/export.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


<!-- markdownlint-disable MD036 -->
**Export with optional parameters**
<!-- markdownlint-disable MD036 -->
The rendered chart can be exported to specific orientation, width and height by passing it as optional parameters in the export method of chart

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/getting-started/export-optionalParameter/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Export.cs" %}
{% include code-snippet/chart/getting-started/export-optionalParameter/export.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/getting-started/export-optionalParameter/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Export.cs" %}
{% include code-snippet/chart/getting-started/export-optionalParameter/export.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Multiple Chart Export

You can export the multiple charts in single page by passing the multiple chart objects in the export
method of chart.

To export multiple charts in a single page, follow the given steps:

**Step 1**:

Initially, render more than one chart to export, and then add button to export the multiple charts. In
button click, call the export private method in charts, and then pass the multiple chart objects in the
export method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/getting-started/multi-export/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Multi-export.cs" %}
{% include code-snippet/chart/getting-started/multi-export/multi-export.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/getting-started/multi-export/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Multi-export.cs" %}
{% include code-snippet/chart/getting-started/multi-export/multi-export.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

