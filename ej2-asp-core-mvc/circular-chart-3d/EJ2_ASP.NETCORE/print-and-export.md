---
layout: post
title: Print and Export in ##Platform_Name## Syncfusion 3D Circular Chart Component
description: Learn here all about print and export in Syncfusion ##Platform_Name## 3D Circular Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Print and Export
publishingplatform: ##Platform_Name##
documentation: ug
---


# Print and Export in ##Platform_Name## 3D Circular Chart Component

## Print

The rendered 3D Circular Chart can be printed directly from the browser by calling the public method `print`. The ID of the 3D Circular Chart div element must be passed as the input parameter to that method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circular-chart/user-interaction/print/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Print.cs" %}
{% include code-snippet/circular-chart/user-interaction/print/print.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circular-chart/user-interaction/print/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Print.cs" %}
{% include code-snippet/circular-chart/user-interaction/print/print.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Export

The rendered 3D Circular Chart can be exported to `JPEG`, `PNG`, or `SVG` format using the `export` method. Additionally, you can export the 3D Circular Chart as a `PDF` format using the `pdfExport` method. The input parameters for this method are `type` for the format and `fileName` for the result.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circular-chart/user-interaction/export/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Export.cs" %}
{% include code-snippet/circular-chart/user-interaction/export/export.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circular-chart/user-interaction/export/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Export.cs" %}
{% include code-snippet/circular-chart/user-interaction/export/export.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


