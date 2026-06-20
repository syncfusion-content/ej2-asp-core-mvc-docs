---
layout: post
title: Syncfusion Series Type in ##Platform_Name## Range Navigator Component
description: Learn here all about Series Type in Syncfusion ##Platform_Name## Range Navigator component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Series Type
publishingplatform: ##Platform_Name##
documentation: ug
---


# Range Navigator Series Types

To render the data, the Range Selector supports six types of series.

<!-- markdownlint-disable MD036 -->

## Line

<!-- markdownlint-disable MD036 -->

To render a line series, use series `type` as **Line**. By default, the line series is rendered in the Range Selector.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/range-navigator/series-type/line/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Line.cs" %}
{% include code-snippet/range-navigator/series-type/line/line.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/range-navigator/series-type/line/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Line.cs" %}
{% include code-snippet/range-navigator/series-type/line/line.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Line Chart](images/series-type/line.png)

## Area

To render an area series, use series `type` as **Area**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/range-navigator/series-type/area/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Area.cs" %}
{% include code-snippet/range-navigator/series-type/area/area.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/range-navigator/series-type/area/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Area.cs" %}
{% include code-snippet/range-navigator/series-type/area/area.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Area Chart](images/series-type/area.png)

## StepLine

To render a Step line series, use series `type` as **Step Line**

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/range-navigator/series-type/step/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Step.cs" %}
{% include code-snippet/range-navigator/series-type/step/step.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/range-navigator/series-type/step/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Step.cs" %}
{% include code-snippet/range-navigator/series-type/step/step.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Step Line Chart](images/series-type/stepline.png)

## Spline

To render a Spline series, use series `type` as **Spline**

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/range-navigator/series-type/spline/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Spline.cs" %}
{% include code-snippet/range-navigator/series-type/spline/spline.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/range-navigator/series-type/spline/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Spline.cs" %}
{% include code-snippet/range-navigator/series-type/spline/spline.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Spline chart](images/series-type/spline.png)

## Spline Area

To render a Spline area series, use series `type` as **SplineArea**

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/range-navigator/series-type/splinearea/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="SplineArea.cs" %}
{% include code-snippet/range-navigator/series-type/splinearea/splinearea.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/range-navigator/series-type/splinearea/razor %}
{% endhighlight %}
{% highlight c# tabtitle="SplineArea.cs" %}
{% include code-snippet/range-navigator/series-type/splinearea/splinearea.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Spline area chart](images/series-type/splinearea.png)

## Column

To render a Column series, use series `type` as **Column**

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/range-navigator/series-type/column/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Column.cs" %}
{% include code-snippet/range-navigator/series-type/column/column.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/range-navigator/series-type/column/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Column.cs" %}
{% include code-snippet/range-navigator/series-type/column/column.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Column chart](images/series-type/column.png)