---
layout: post
title: Dimensions in ##Platform_Name## Schedule Component
description: Learn here all about Dimensions in Syncfusion ##Platform_Name## Schedule component and more.
platform: ej2-asp-core-mvc
control: Dimensions
publishingplatform: ##Platform_Name##
documentation: ug
---


# Scheduler dimensions

The Scheduler dimensions refers to both height and width of the entire layout and it accepts 3 types of values.

* auto
* pixel
* percentage

## Auto Height and Width

When height and width of the Scheduler are set to `auto`, it will try as hard as possible to keep an element the same width as its parent container. In other words, the parent container that holds Scheduler, it's width/height will be the sum of its children. By default, Scheduler is assigned with `auto` values for both height and width properties.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/schedule/dimension/auto/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/dimension/auto/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/schedule/dimension/auto/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/dimension/auto/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Height and Width in pixel

The Scheduler height and width will be rendered exactly as per the given pixel values. It accepts both string and number values.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/schedule/dimension/pixel/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/dimension/pixel/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/schedule/dimension/pixel/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/dimension/pixel/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Height and Width in percentage

When height and width of the Scheduler are given as percentage, it will make the Scheduler as wide as the parent container.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/schedule/dimension/percentage/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/dimension/percentage/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/schedule/dimension/percentage/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/dimension/percentage/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You can refer to our [ASP.NET MVC Scheduler](https://www.syncfusion.com/aspnet-mvc-ui-controls/scheduler) feature tour page for its groundbreaking feature representations. You can also explore our [ASP.NET MVC Scheduler](https://ej2.syncfusion.com/aspnetmvc/Schedule/Overview#/material) example to knows how to present and manipulate data.

## See Also

* [How to Change Scheduler Cell Dimensions](./cell-customization/#setting-cell-dimensions-in-all-views)