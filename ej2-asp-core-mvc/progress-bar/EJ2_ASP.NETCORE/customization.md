---
layout: post
title: Customization in ##Platform_Name## Progress Bar Component
description: Learn here all about Customization in Syncfusion ##Platform_Name## Progress Bar component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Customization
publishingplatform: ##Platform_Name##
documentation: ug
---


# Customization

## Segments

<!-- markdownlint-disable MD033 -->

We can divide a progress bar into multiple segments using a `segmentCount` to visualize the progress of multiple sequential tasks.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/progress-bar/customization/segments/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Segments.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/progress-bar/customization/segments/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Segments.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



## Thickness

Customize the thickness of the track using [`trackThickness`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.ProgressBar.ProgressBar.html#Syncfusion_EJ2_ProgressBar_ProgressBar_TrackThickness), progress using [`progressThickness`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.ProgressBar.ProgressBar.html#Syncfusion_EJ2_ProgressBar_ProgressBar_ProgressThickness) and secondary progress using [`secondaryProgressThickness`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.ProgressBar.ProgressBar.html#Syncfusion_EJ2_ProgressBar_ProgressBar_SecondaryProgressThickness) to render the progress bar with different appearances.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/progress-bar/customization/thickness/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Thickness.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/progress-bar/customization/thickness/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Thickness.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



## Radius

<!-- markdownlint-disable MD033 -->

The radius of the progress bar can be customized using `radius` property and  corner can be customized by **cornerRadius** property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/progress-bar/customization/radius/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Radius.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/progress-bar/customization/radius/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Radius.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



## InnerRadius

<!-- markdownlint-disable MD033 -->

The inner radius of the progress bar can be customized using `innerRadius` property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/progress-bar/customization/inner-radius/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Inner-radius.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/progress-bar/customization/inner-radius/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Inner-radius.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



## Progress color and track color

<!-- markdownlint-disable MD033 -->

Customize the color of progress, secondary progress, and track by using the [`progressColor`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.ProgressBar.ProgressBar.html#Syncfusion_EJ2_ProgressBar_ProgressBar_ProgressColor), [`secondaryProgressColor`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.ProgressBar.ProgressBar.html#Syncfusion_EJ2_ProgressBar_ProgressBar_SecondaryProgressColor) and [`trackColor`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.ProgressBar.ProgressBar.html#Syncfusion_EJ2_ProgressBar_ProgressBar_TrackColor) properties.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/progress-bar/customization/track-thickness/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Track-thickness.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/progress-bar/customization/track-thickness/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Track-thickness.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}


