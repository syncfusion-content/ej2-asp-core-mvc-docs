---
layout: post
title: Chart print in ##Platform_Name## 3D Chart Component
description: Learn here all about chart print in Syncfusion ##Platform_Name## 3D Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Chart print
publishingplatform: ##Platform_Name##
documentation: ug
---

# Chart print in ##Platform_Name## 3D Chart Component

## Print

The rendered chart can be printed directly from the browser by calling the public method print. ID of the chart div element must be passed as argument to that method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/user-interaction/print/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Print.cs" %}
{% include code-snippet/3d-chart/series/user-interaction/print/print.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/user-interaction/print/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Print.cs" %}
{% include code-snippet/3d-chart/series/user-interaction/print/print.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Export

The rendered chart can be exported to `JPEG`, `PNG`, `SVG`, or `PDF` format using the export method in chart. The input parameters for this method are `type` for format and `fileName` for result.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/user-interaction/export/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Export.cs" %}
{% include code-snippet/3d-chart/series/user-interaction/export/export.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/user-interaction/export/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Export.cs" %}
{% include code-snippet/3d-chart/series/user-interaction/export/export.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


