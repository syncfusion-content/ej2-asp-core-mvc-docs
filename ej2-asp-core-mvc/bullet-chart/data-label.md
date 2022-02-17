---
layout: post
title: Data Label in ##Platform_Name## Bullet Chart Component
description: Learn here all about Data Label in Syncfusion ##Platform_Name## Bullet Chart component and more.
platform: ej2-asp-core-mvc
control: Data Label
publishingplatform: ##Platform_Name##
documentation: ug
---


# Data Label

Data Labels are used to identify the value of actual bar in the Bullet Chart component. The Data Labels will be shown by specifying the `dataLabel` setting's `enable` property to **true**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/data-label/data-label/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data-label.cs" %}
{% include code-snippet/bullet-chart/data-label/data-label/data-label.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/data-label/data-label/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data-label.cs" %}
{% include code-snippet/bullet-chart/data-label/data-label/data-label.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Data Label Customization

Data Labels color, opacity, font size, font family, font weight, and font style can be customized using the `labelStyle`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/data-label/data-label-custom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data-label-custom.cs" %}
{% include code-snippet/bullet-chart/data-label/data-label-custom/data-label-custom.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/data-label/data-label-custom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data-label-custom.cs" %}
{% include code-snippet/bullet-chart/data-label/data-label-custom/data-label-custom.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Bullet Chart with Data Labels](images/blazor-bullet-chart-data-label.png)