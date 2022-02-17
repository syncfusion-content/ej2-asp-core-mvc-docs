---
layout: post
title: Appearance in ##Platform_Name## Stock Chart Component
description: Learn here all about Appearance in Syncfusion ##Platform_Name## Stock Chart component and more.
platform: ej2-asp-core-mvc
control: Appearance
publishingplatform: ##Platform_Name##
documentation: ug
---


# Appearance

## Stock Chart Title

Stock Chart can be given a title using [`Title`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChart.html#Syncfusion_EJ2_Charts_StockChart_Title) property, to show the information
about the data plotted.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/appearance/title/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Title.cs" %}
{% include code-snippet/stock-chart/appearance/title/title.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/appearance/title/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Title.cs" %}
{% include code-snippet/stock-chart/appearance/title/title.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



<!-- markdownlint-disable MD036 -->

## Title Customizations

The `TextStyle` property of chart title provides options to customize the `Size`, `Color`, `FontFamily`, `FontWeight`, `FontStyle`, `Opacity`, `TextAlignment` and `TextOverflow`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/appearance/titlewrap/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Titlewrap.cs" %}
{% include code-snippet/stock-chart/appearance/titlewrap/titlewrap.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/appearance/titlewrap/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Titlewrap.cs" %}
{% include code-snippet/stock-chart/appearance/titlewrap/titlewrap.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Stock Chart Theme

Changing theme will affect background color,gridlines,tooltip colors and appearance.

[`Theme`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChart.html#Syncfusion_EJ2_Charts_StockChart_Theme) property of Stock chart is shipped with several built-in themes such as `Material`, `Fabric`, `Bootstrap` , `HighContrastLight`, `MaterialDark`, `FabricDark`, `FabricDark`, `HighContrast` and `BootstrapDark`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/appearance/theme/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Theme.cs" %}
{% include code-snippet/stock-chart/appearance/theme/theme.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/appearance/theme/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Theme.cs" %}
{% include code-snippet/stock-chart/appearance/theme/theme.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [Axis Customization](./axis-customization/)
