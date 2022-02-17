---
layout: post
title: Annotation in ##Platform_Name## Accumulation Chart Component
description: Learn here all about Annotation in Syncfusion ##Platform_Name## Accumulation Chart component and more.
platform: ej2-asp-core-mvc
control: Annotation
publishingplatform: ##Platform_Name##
documentation: ug
---


# Annotation

The annotations are used to mark the specific area of interest in the chart area with texts, shapes or images.

<!-- markdownlint-disable MD033 -->

By using the <code>content</code> option of annotation property, you can specify the Id of the element that needs to be displayed in the chart area.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/annotation/annotation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Annotation.cs" %}
{% include code-snippet/chart/accumulation-charts/annotation/annotation/annotation.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/annotation/annotation/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Annotation.cs" %}
{% include code-snippet/chart/accumulation-charts/annotation/annotation/annotation.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Region

The annotation can be placed with respect to either `Series` or `Chart`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/annotation/region/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Region.cs" %}
{% include code-snippet/chart/accumulation-charts/annotation/region/region.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/annotation/region/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Region.cs" %}
{% include code-snippet/chart/accumulation-charts/annotation/region/region.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Co-ordinate Units

Specifies the coordinate units of an annotation either in `Pixel` or `Point`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/annotation/co-ordinate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Co-ordinate.cs" %}
{% include code-snippet/chart/accumulation-charts/annotation/co-ordinate/co-ordinate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/annotation/co-ordinate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Co-ordinate.cs" %}
{% include code-snippet/chart/accumulation-charts/annotation/co-ordinate/co-ordinate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Alignment

The annotations can be moved vertically and horizontally from its default position by using `verticalAlignment`
or `horizontalAlignment` properties. The verticalAlignment property takes value as `Top`, `Bottom` or `Middle` and the
horizontalAlignment property takes value as `Near`, `Far` or `Center`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/annotation/alignment/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Alignment.cs" %}
{% include code-snippet/chart/accumulation-charts/annotation/alignment/alignment.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/annotation/alignment/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Alignment.cs" %}
{% include code-snippet/chart/accumulation-charts/annotation/alignment/alignment.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

