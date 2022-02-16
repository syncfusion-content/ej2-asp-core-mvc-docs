---
layout: post
title: Customization in ##Platform_Name## Progress Bar Component
description: Learn here all about Customization in Syncfusion ##Platform_Name## Progress Bar component and more.
platform: ej2-asp-core-mvc
control: Customization
publishingplatform: ##Platform_Name##
documentation: ug
---


# Customization

## Segments

<!-- markdownlint-disable MD033 -->

We can divide a progress bar into multiple segments using a `SegmentCount` to visualize the progress of multiple sequential tasks.

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

You can customize the thickness of the track  using `TrackThickness` and progress using `ProgressThickness` to render the ProgressBar with different appearances.

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

The  radius of the progress bar can be customized using `Radius` property and  corner can be customized by **CornerRadius** property.

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

The inner radius of the progress bar can be customized using `InnerRadius` property.

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



## Progress colour and track colour

<!-- markdownlint-disable MD033 -->

We can customize the color of progress and track by using  **ProgressColor** and **TrackColor** property.

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


