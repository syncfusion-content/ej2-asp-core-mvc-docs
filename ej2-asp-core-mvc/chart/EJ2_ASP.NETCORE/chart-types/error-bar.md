---
layout: post
title: Error Bar Chart in ##Platform_Name## Syncfusion Chart Component
description: Learn here all about Error Bar Chart in Syncfusion ##Platform_Name## Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Error Bar Chart
publishingplatform: ##Platform_Name##
documentation: ug
---


# Error Bar in ##Platform_Name## Charts Component

## Error Bar

Error bars are graphical representations of the variability of data and used on graphs to indicate the error or uncertainty in a reported measurement. To render the error bar for the series, set [`Visible`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartErrorBarSettings.html#Syncfusion_EJ2_Charts_ChartErrorBarSettings_Visible) as `true` in error bar object.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/other-types/errorbar/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Errorbar.cs" %}
{% include code-snippet/chart/series/other-types/errorbar/errorbar.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/other-types/errorbar/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Errorbar.cs" %}
{% include code-snippet/chart/series/other-types/errorbar/errorbar.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Error Bar Type

To change the error bar rendering type using [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartErrorBarSettings.html#Syncfusion_EJ2_Charts_ChartErrorBarSettings_Type) option of error bar. To change the error bar line length you can use [`VerticalError`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartErrorBarSettings.html#Syncfusion_EJ2_Charts_ChartErrorBarSettings_VerticalError) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/other-types/error-type/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Error-type.cs" %}
{% include code-snippet/chart/series/other-types/error-type/error-type.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/other-types/error-type/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Error-type.cs" %}
{% include code-snippet/chart/series/other-types/error-type/error-type.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Customizing Error Bar Type

To customize the error bar type, set error bar [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartErrorBarSettings.html#Syncfusion_EJ2_Charts_ChartErrorBarSettings_Type) as `Custom` and then change the horizontal/vertical positive and negative error of error bar.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/other-types/custom-error/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-error.cs" %}
{% include code-snippet/chart/series/other-types/custom-error/custom-error.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/other-types/custom-error/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-error.cs" %}
{% include code-snippet/chart/series/other-types/custom-error/custom-error.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Error Bar Mode

Error bar mode is used to define whether the error bar line has to be drawn horizontally, vertically or in both side. To change the error bar mode use [`Mode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartErrorBarSettings.html#Syncfusion_EJ2_Charts_ChartErrorBarSettings_Mode) option.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/other-types/error-mode/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Error-mode.cs" %}
{% include code-snippet/chart/series/other-types/error-mode/error-mode.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/other-types/error-mode/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Error-mode.cs" %}
{% include code-snippet/chart/series/other-types/error-mode/error-mode.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Error Bar Direction

To change the error bar direction to plus, minus or both side using [`Direction`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartErrorBarSettings.html#Syncfusion_EJ2_Charts_ChartErrorBarSettings_Direction) option.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/other-types/error-direction/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Error-direction.cs" %}
{% include code-snippet/chart/series/other-types/error-direction/error-direction.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/other-types/error-direction/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Error-direction.cs" %}
{% include code-snippet/chart/series/other-types/error-direction/error-direction.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Customizing Error Bar Cap

To customize the error bar cap length, width and fill color, you can use [`ErrorBarCap`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartErrorBarSettings.html#Syncfusion_EJ2_Charts_ChartErrorBarSettings_ErrorBarCap) option.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/other-types/error-cap/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Error-cap.cs" %}
{% include code-snippet/chart/series/other-types/error-cap/error-cap.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/other-types/error-cap/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Error-cap.cs" %}
{% include code-snippet/chart/series/other-types/error-cap/error-cap.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Customizing Error Bar Color

To customize the error bar color for individual errors, use the [`ErrorBarColorMapping`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartErrorBarSettings.html#Syncfusion_EJ2_Charts_ChartErrorBarSettings_ErrorBarColorMapping) property. You can also customize the vertical error, horizontal error, horizontal negative and positive error and vertical negative and positive error for an individual point using [`VerticalError`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartErrorBarSettings.html#Syncfusion_EJ2_Charts_ChartErrorBarSettings_VerticalError), [`HorizontalError`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartErrorBarSettings.html#Syncfusion_EJ2_Charts_ChartErrorBarSettings_HorizontalError), [`HorizontalNegativeError`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartErrorBarSettings.html#Syncfusion_EJ2_Charts_ChartErrorBarSettings_HorizontalNegativeError), [`HorizontalPositiveError`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartErrorBarSettings.html#Syncfusion_EJ2_Charts_ChartErrorBarSettings_HorizontalPositiveError), [`VerticalNegativeError`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartErrorBarSettings.html#Syncfusion_EJ2_Charts_ChartErrorBarSettings_VerticalNegativeError) and [`VerticalPositiveError`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartErrorBarSettings.html#Syncfusion_EJ2_Charts_ChartErrorBarSettings_VerticalPositiveError) properties.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/other-types/error-bar-color/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Error-bar-color.cs" %}
{% include code-snippet/chart/series/other-types/error-bar-color/error-bar-color.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/other-types/error-bar-color/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Error-bar-color.cs" %}
{% include code-snippet/chart/series/other-types/error-bar-color/error-bar-color.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [Data Label](../data-labels)
* [Tooltip](../tool-tip)