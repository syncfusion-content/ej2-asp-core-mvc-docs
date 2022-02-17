---
layout: post
title: Grouping in ##Platform_Name## Accumulation Chart Component
description: Learn here all about Grouping in Syncfusion ##Platform_Name## Accumulation Chart component and more.
platform: ej2-asp-core-mvc
control: Grouping
publishingplatform: ##Platform_Name##
documentation: ug
---

<!-- markdownlint-disable MD036 -->

# Grouping

You can club/group few points of the series based on
[`GroupTo`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.AccumulationSeries.html#Syncfusion_EJ2_Charts_AccumulationSeries_GroupTo)
property. For example, if the club value is 11, then the points with value less than 11 is grouped together
and will be showed as a single point with label `others`. The property also takes value in percentage
(percentage of total data points value).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/grouping/group/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Group.cs" %}
{% include code-snippet/chart/accumulation-charts/grouping/group/group.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/grouping/group/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Group.cs" %}
{% include code-snippet/chart/accumulation-charts/grouping/group/group.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Pie Grouping

**Broken Slice**

You can visualize all points available in club/group points by clicking on the grouped point. For example, if 5 points are grouped together it will be showed as a single slice with label `others`. If we click on `others` slice it will explode and broke into 5 seperate slices.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/grouping/slice/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Slice.cs" %}
{% include code-snippet/chart/accumulation-charts/grouping/slice/slice.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/grouping/slice/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Slice.cs" %}
{% include code-snippet/chart/accumulation-charts/grouping/slice/slice.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Group Mode**

Slice can also be grouped based on number of points by specifying the [`GroupMode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.AccumulationSeries.html#Syncfusion_EJ2_Charts_AccumulationSeries_GroupMode)
to Point. For example, if the group to value is 11, accumulation chart will show 1st 11 points and will group remaining entries in the collection as a single point.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/grouping/groupmode/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Groupmode.cs" %}
{% include code-snippet/chart/accumulation-charts/grouping/groupmode/groupmode.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/grouping/groupmode/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Groupmode.cs" %}
{% include code-snippet/chart/accumulation-charts/grouping/groupmode/groupmode.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Customization

You can customize the grouped point and its data label using `PointRender` and `TextRender` event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/grouping/custom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom.cs" %}
{% include code-snippet/chart/accumulation-charts/grouping/custom/custom.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/grouping/custom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom.cs" %}
{% include code-snippet/chart/accumulation-charts/grouping/custom/custom.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

