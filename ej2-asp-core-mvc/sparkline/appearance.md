---
layout: post
title: Appearance in ##Platform_Name## Sparkline Component
description: Learn here all about Appearance in Syncfusion ##Platform_Name## Sparkline component and more.
platform: ej2-asp-core-mvc
control: Appearance
publishingplatform: ##Platform_Name##
documentation: ug
---


# Appearance

The appearance of the sparkline can be customized using margin, container Area border, and container Area background.

## Sparkline border

The [`containerArea border`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Charts.SparklineContainerArea~Border.html) of the sparkline is used to render border to cover sparkline area.

The following code example shows the sparkline with overall border.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sparkline/appearance/border/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Border.cs" %}
{% include code-snippet/sparkline/appearance/border/border.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sparkline/appearance/border/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Border.cs" %}
{% include code-snippet/sparkline/appearance/border/border.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Sparkline padding

Padding is used to specify padding value between container and sparkline. By default, padding value of the sparkline is 5. Sparkline [`padding`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Charts.SparklinePadding.html) values are specified by the left, right, top, and bottom.

The following code example shows the sparkline with overall padding is set to 20.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sparkline/appearance/padding/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Padding.cs" %}
{% include code-snippet/sparkline/appearance/padding/padding.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sparkline/appearance/padding/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Padding.cs" %}
{% include code-snippet/sparkline/appearance/padding/padding.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Sparkline area customization

The background color of the sparkline area can be customized using the [`containerArea background`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Charts.SparklineContainerArea~BackGround.html) color. By default, the sparkline background color is `transparent`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sparkline/appearance/area-custom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Area_custom.cs" %}
{% include code-snippet/sparkline/appearance/area-custom/area_custom.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sparkline/appearance/area-custom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Area_custom.cs" %}
{% include code-snippet/sparkline/appearance/area-custom/area_custom.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Sparkline theme

Datalabel and track line colors of the sparkline will be changed based on theme. For example, for dark theme, the color of datalabel and track line should be white; for light theme, their value should be black. The possible values for sparkline theme are [`Material`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Charts.Sparkline~Theme.html), [`Fabric`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Charts.Sparkline~Theme.html), [`Bootstrap`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Charts.Sparkline~Theme.html), and [`Highcontrast`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Charts.Sparkline~Theme.html).

The following code example shows the color for datalabel and track line is set to white for dark theme.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sparkline/appearance/theme/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Theme.cs" %}
{% include code-snippet/sparkline/appearance/theme/theme.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sparkline/appearance/theme/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Theme.cs" %}
{% include code-snippet/sparkline/appearance/theme/theme.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

