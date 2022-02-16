---
layout: post
title: Series Type in ##Platform_Name## Range Navigator Component
description: Learn here all about Series Type in Syncfusion ##Platform_Name## Range Navigator component and more.
platform: ej2-asp-core-mvc
control: Series Type
publishingplatform: ##Platform_Name##
documentation: ug
---


# Series Types

To render the data, the Range Selector supports three types of series.

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