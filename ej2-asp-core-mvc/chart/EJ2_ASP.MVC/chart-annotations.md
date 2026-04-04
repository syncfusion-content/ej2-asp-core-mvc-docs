---
layout: post
title: Chart Annotations in ##Platform_Name## Chart Component
description: Learn here all about Chart Annotations in Syncfusion ##Platform_Name## Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Chart Annotations
publishingplatform: ##Platform_Name##
documentation: ug
---


# Annotation

Chart annotations allow highlighting specific areas of the chart using text, shapes, images, or custom HTML elements. Annotations can be used to emphasize trends, mark thresholds, show custom notes, or display additional information directly inside the chart area.

Annotations are added using the `annotations` option. Set the [`Content`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAnnotation.html#Syncfusion_EJ2_Charts_ChartAnnotation_Content) property to reference the element that should be rendered within the chart.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column/annotation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Annotation.cs" %}
{% include code-snippet/chart/series/column/annotation/annotation.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column/annotation/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Annotation.cs" %}
{% include code-snippet/chart/series/column/annotation/annotation.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Region

Annotations can be positioned relative to either the overall `Chart` area or a specific `Series`. When placed relative to the chart, the annotation uses the chart’s coordinate system. When placed relative to a series, the annotation aligns with that series' data points. By default, annotations are placed with respect to the chart.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column/region/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Region.cs" %}
{% include code-snippet/chart/series/column/region/region.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column/region/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Region.cs" %}
{% include code-snippet/chart/series/column/region/region.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Co-ordinate Units

Use the `CoordinateUnits` property to define how annotation coordinates are interpreted. Choose between:

- **Pixel** – The annotation is positioned using fixed pixel values within the chart area.  
- **Point** – The annotation is positioned based on chart data points (x and y values).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column/co-ordinate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Co-ordinate.cs" %}
{% include code-snippet/chart/series/column/co-ordinate/co-ordinate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column/co-ordinate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Co-ordinate.cs" %}
{% include code-snippet/chart/series/column/co-ordinate/co-ordinate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Alignment

Annotation provides `VerticalAlignment` and `HorizontalAlignment`. The `VerticalAlignment` can be customized via `Top`, `Bottom` or `Middle` and the `horizontalAlignment` can be customized via `Near`, `Far` or `Center`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column/alignment/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Alignment.cs" %}
{% include code-snippet/chart/series/column/alignment/alignment.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column/alignment/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Alignment.cs" %}
{% include code-snippet/chart/series/column/alignment/alignment.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Adding y-axis sub title through on annotation

By setting text div in the `Content` option of annotation object you can add sub title to chart y-axis. Specified the `Coordinate` value as `Pixel` and customize x and y location of the text.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column/axis-sub/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Axis-sub.cs" %}
{% include code-snippet/chart/series/column/axis-sub/axis-sub.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column/axis-sub/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Axis-sub.cs" %}
{% include code-snippet/chart/series/column/axis-sub/axis-sub.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

