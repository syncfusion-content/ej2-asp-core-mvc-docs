---
layout: post
title: Chart dimensions in ##Platform_Name## 3D Chart Component
description: Learn here all about chart dimensions in Syncfusion ##Platform_Name## 3D Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Chart Dimensions
publishingplatform: ##Platform_Name##
documentation: ug
---

# Chart dimensions in ##Platform_Name## 3D Chart Component

## Size for container

Chart can be rendered to its container size and it can be set via inline or CSS as demonstrated below.

```index.cshtml
    @(Html.EJS().Chart3D("container").Width("650px").Height("350px"))
```

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/appearance/size/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Size.cs" %}
{% include code-snippet/3d-chart/series/appearance/size/size.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/appearance/size/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Size.cs" %}
{% include code-snippet/3d-chart/series/appearance/size/size.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Size for chart

<!-- markdownlint-disable MD036 -->

The size of the chart can be set directly through [`Width`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3D.html#Syncfusion_EJ2_Charts_Chart3D_Width) and [`Height`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3D.html#Syncfusion_EJ2_Charts_Chart3D_Height) properties.

**In pixel**

The size of the chart can be set in pixel as demonstrated below.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/appearance/pixel/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Pixel.cs" %}
{% include code-snippet/3d-chart/series/appearance/pixel/pixel.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/appearance/pixel/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Pixel.cs" %}
{% include code-snippet/3d-chart/series/appearance/pixel/pixel.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**In percentage**

By setting the value in percentage, chart gets its dimension with respect to its container. For example, when the height is ‘50%’, chart renders to half of the container height.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/appearance/percentage/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Percentage.cs" %}
{% include code-snippet/3d-chart/series/appearance/percentage/percentage.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/appearance/percentage/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Percentage.cs" %}
{% include code-snippet/3d-chart/series/appearance/percentage/percentage.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



N> When you do not specify the size, it takes `450px` as the height and window size as its width.