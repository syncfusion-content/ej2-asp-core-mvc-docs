---
layout: post
title: Special Points Customization in ##Platform_Name## Sparkline Component
description: Learn here all about Special Points Customization in Syncfusion ##Platform_Name## Sparkline component and more.
platform: ej2-asp-core-mvc
control: Special Points Customization
publishingplatform: ##Platform_Name##
documentation: ug
---


# Special points customization

You can customize the points by initializing the point colors. The customization options allows to differentiate the [`start`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Charts.Sparkline~StartPointColor.html), [`end`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Charts.Sparkline~EndPointColor.html), [`positive`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Charts.Sparkline~HighPointColor.html), [`negative`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Charts.Sparkline~NegativePointColor.html), and [`low`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Charts.Sparkline~LowPointColor.html) points. This customization is only applicable for line, column, and area type sparklines.

<!-- markdownlint-disable MD036 -->

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sparkline/specialpoints/custom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom.cs" %}
{% include code-snippet/sparkline/specialpoints/custom/custom.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sparkline/specialpoints/custom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom.cs" %}
{% include code-snippet/sparkline/specialpoints/custom/custom.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Tie point color**

Tie point color is used to configure the win-loss series type sparkline's y-value point color. The following code sample shows the tie point color of sparkline series.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sparkline/specialpoints/tie-point/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Tie_point.cs" %}
{% include code-snippet/sparkline/specialpoints/tie-point/tie-point.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sparkline/specialpoints/tie-point/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Tie_point.cs" %}
{% include code-snippet/sparkline/specialpoints/tie-point/tie-point.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

