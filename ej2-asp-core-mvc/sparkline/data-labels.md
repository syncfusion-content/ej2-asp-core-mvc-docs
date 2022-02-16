---
layout: post
title: Data Labels in ##Platform_Name## Sparkline Component
description: Learn here all about Data Labels in Syncfusion ##Platform_Name## Sparkline component and more.
platform: ej2-asp-core-mvc
control: Data Labels
publishingplatform: ##Platform_Name##
documentation: ug
---


# Data Labels

Data labels are used to display values of data points to improve the readability.

## Enable data label

To enable data label for sparkline series, provide [`visible`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Charts.SparklineSparklineDataLabelSettings~Visible.html) of the [`dataLabelSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Charts.SparklineSparklineDataLabelSettings.html) as following possible values:

* All - Enables data label of  all points.
* Start - Enables data label of the start point.
* End - Enables data label of the end point.
* High - Enables data label of the high point.
* Low - Enables data label of the low point.
* Negative - Enables data labels of the negative points.

The following example shows enabling sparkline data label for all points.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sparkline/datalabel/enable/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Enable.cs" %}
{% include code-snippet/sparkline/datalabel/enable/enable.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sparkline/datalabel/enable/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Enable.cs" %}
{% include code-snippet/sparkline/datalabel/enable/enable.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Customize data label

Data labels can be customized using the fill, border, opacity, and text Style. The following code example shows customizing data label border, text color, and fill color.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sparkline/datalabel/custom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom.cs" %}
{% include code-snippet/sparkline/datalabel/custom/custom.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sparkline/datalabel/custom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom.cs" %}
{% include code-snippet/sparkline/datalabel/custom/custom.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Format data label text

The text of data labels can be formatted using the [`format`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Charts.SparklineSparklineDataLabelSettings~Format.html) API in the sparkline [`dataLabelSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Charts.SparklineSparklineDataLabelSettings.html). By default, data label shows the y-value of point. The following code example shows how to display x and y-values for points.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sparkline/datalabel/format/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Format.cs" %}
{% include code-snippet/sparkline/datalabel/format/format.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sparkline/datalabel/format/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Format.cs" %}
{% include code-snippet/sparkline/datalabel/format/format.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

