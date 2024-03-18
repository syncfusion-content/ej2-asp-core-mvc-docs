---
layout: post
title: Circular Chart 3D Print in ##Platform_Name## Circular Chart 3D Component
description: Learn here all about Circular Chart 3D Print in Syncfusion ##Platform_Name## Circular Chart 3D component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Circular Chart 3D Print
publishingplatform: ##Platform_Name##
documentation: ug
---


# Circular Chart 3D print in ##Platform_Name## Circular Chart 3D Component

## Print

The rendered Circular Chart 3D can be printed directly from the browser by calling the public method print.

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

The rendered Circular Chart 3D can be exported to `Image`(jpeg or png) or `SVG` or `PDF` format by using the export method.
Input parameters for this method are `Export` type for `format` and `fileName` of result.

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


