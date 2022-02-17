---
layout: post
title: Chart Annotations in ##Platform_Name## Chart Component
description: Learn here all about Chart Annotations in Syncfusion ##Platform_Name## Chart component and more.
platform: ej2-asp-core-mvc
control: Chart Annotations
publishingplatform: ##Platform_Name##
documentation: ug
---


# Annotation

Annotations are used to mark the specific area of interest in the chart area with texts, shapes or images.

<!-- markdownlint-disable MD033 -->

You can add annotations to the chart by using the <code>annotations</code> option. By using the
[`Content`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAnnotation.html#Syncfusion_EJ2_Charts_ChartAnnotation_Content) option of annotation object, you can specify
the id of the element that needs to be displayed in the chart area.

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

Annotations can be placed either with respect to `Series` or `Chart`. by default, it will placed with respect
to `Chart`.

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

Specified the coordinates units of the annotation either `Pixel` or `Point`.

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

Annotation provides `VerticalAlignment` and `HorizontalAlignment`. The `VerticalAlignment` can be customized
via `Top`, `Bottom` or `Middle` and the `horizontalAlignment` can be customized via `Near`, `Far` or `Center`.

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

By setting text div in the `Content` option of annotation object you can add sub title to chart y-axis. Specified the
`Coordinate` value as `Pixel` and customize x and y location of the text.

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

