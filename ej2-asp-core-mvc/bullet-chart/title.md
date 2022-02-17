---
layout: post
title: Title in ##Platform_Name## Bullet Chart Component
description: Learn here all about Title in Syncfusion ##Platform_Name## Bullet Chart component and more.
platform: ej2-asp-core-mvc
control: Title
publishingplatform: ##Platform_Name##
documentation: ug
---


# Title and Subtitle

## Title

The title of the Bullet Chart displays the information about the data plotted by specifying it in the `title` property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/title/title/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Title.cs" %}
{% include code-snippet/bullet-chart/title/title/title.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/title/title/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Title.cs" %}
{% include code-snippet/bullet-chart/title/title/title.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Bullet Chart with Title](images/blazor-bullet-chart-with-title.png)

## Subtitle

To show additional information about the data plotted, the Bullet Chart can also be given a subtitle using the `subtitle` property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/title/sub-title/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Sub-title.cs" %}
{% include code-snippet/bullet-chart/title/sub-title/sub-title.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/title/sub-title/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Sub-title.cs" %}
{% include code-snippet/bullet-chart/title/sub-title/sub-title.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Bullet Chart with Subtitle](images/blazor-bullet-chart-subtitle.png)

## Title and SubTitle Position

The title and the subtitle positions can be customized using the `titlePosition` property. Possible positions are **Left**, **Right**, **Top**, and **Bottom**.

### Position as Left

By setting the `titlePosition` to **Left**, you can display the title and subtitle at the left side of the Bullet Chart.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/title/left/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Left.cs" %}
{% include code-snippet/bullet-chart/title/left/left.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/title/left/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Left.cs" %}
{% include code-snippet/bullet-chart/title/left/left.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Position as Right

By setting the `titlePosition` to **Right**, you can display the title and subtitle at the right side of the Bullet Chart.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/title/right/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Right.cs" %}
{% include code-snippet/bullet-chart/title/right/right.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/title/right/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Right.cs" %}
{% include code-snippet/bullet-chart/title/right/right.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Position as Top

By setting the `titlePosition` to **Top**, you can display the title and subtitle at the top of the Bullet Chart. The default title and subtitle positions of the Bullet Chart is **Top**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/title/top/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Top.cs" %}
{% include code-snippet/bullet-chart/title/top/top.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/title/top/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Top.cs" %}
{% include code-snippet/bullet-chart/title/top/top.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Position as Bottom

By setting the `titlePosition` to **Bottom**, you can display the title and subtitle at the bottom of the Bullet Chart.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/title/bottom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Bottom.cs" %}
{% include code-snippet/bullet-chart/title/bottom/bottom.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/title/bottom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Bottom.cs" %}
{% include code-snippet/bullet-chart/title/bottom/bottom.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Title and Subtitle Position in Bullet Chart](images/blazor-bullet-chart-title-positions.png)

## Title Customization

The title color, opacity, font size, font family, font weight, and font style can be customized using the `titleStyle` property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/title/title-custom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Title-custom.cs" %}
{% include code-snippet/bullet-chart/title/title-custom/title-custom.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/title/title-custom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Title-custom.cs" %}
{% include code-snippet/bullet-chart/title/title-custom/title-custom.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## SubTitle Customization

The sub-title color, opacity, font size, font family, font weight, and font style can be customized using the `subtitleStyle` property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/title/sub-title-custom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Sub-title-custom.cs" %}
{% include code-snippet/bullet-chart/title/sub-title-custom/sub-title-custom.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/title/sub-title-custom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Sub-title-custom.cs" %}
{% include code-snippet/bullet-chart/title/sub-title-custom/sub-title-custom.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Customizing Title and Subtitle in Bullet Chart](images/blazor-bullet-chart-title-customization.png)