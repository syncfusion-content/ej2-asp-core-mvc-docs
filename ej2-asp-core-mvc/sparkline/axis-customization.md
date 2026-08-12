---
layout: post
title: Axis Customization in ##Platform_Name## Sparkline | Syncfusion
description: Learn here all about Axis Customization in Syncfusion ##Platform_Name## Sparkline component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Axis Customization
publishingplatform: ##Platform_Name##
documentation: ug
---


# Axis Customization in ##Platform_Name## Sparkline

You can customize axis value types and min and max values of the sparkline.

## Change value type of the sparkline

You can change the sparkline value type by setting the [valueType](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Sparkline.ValueType.html) property to [Numeric](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Sparkline.ValueType.html#Syncfusion_EJ2_Sparkline_ValueType_Numeric), [Category](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Sparkline.ValueType.html#Syncfusion_EJ2_Sparkline_ValueType_Category), or [DateTime](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Sparkline.ValueType.html#Syncfusion_EJ2_Sparkline_ValueType_DateTime).
<!-- markdownlint-disable MD036 -->

**DateTime**

You can assign date-time values to the sparkline by setting the [valueType](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Sparkline.ValueType.html) property to [DateTime](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Sparkline.ValueType.html#Syncfusion_EJ2_Sparkline_ValueType_DateTime).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sparkline/axis/datetime/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Datetime.cs" %}
{% include code-snippet/sparkline/axis/datetime/datetime.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sparkline/axis/datetime/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Datetime.cs" %}
{% include code-snippet/sparkline/axis/datetime/datetime.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



<!-- markdownlint-disable MD036 -->

**Category**

You can assign category values to the sparkline by setting [valueType](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Sparkline.ValueType.html) to [Category](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Sparkline.ValueType.html#Syncfusion_EJ2_Sparkline_ValueType_Category).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sparkline/axis/category/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Category.cs" %}
{% include code-snippet/sparkline/axis/category/category.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sparkline/axis/category/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Category.cs" %}
{% include code-snippet/sparkline/axis/category/category.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Numeric**

You can assign numeric values to the sparkline by setting [valueType](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Sparkline.ValueType.html) to [Numeric](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Sparkline.ValueType.html#Syncfusion_EJ2_Sparkline_ValueType_Numeric).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sparkline/axis/numeric/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Numeric.cs" %}
{% include code-snippet/sparkline/axis/numeric/numeric.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sparkline/axis/numeric/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Numeric.cs" %}
{% include code-snippet/sparkline/axis/numeric/numeric.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



<!-- markdownlint-disable MD036 -->

## Change min and max values of axis

You can change the min and max values of x-axis by setting the [`minX`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.SparklineAxisSettings.html#Syncfusion_EJ2_Charts_SparklineAxisSettings_MinX) and [`maxX`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.SparklineAxisSettings.html#Syncfusion_EJ2_Charts_SparklineAxisSettings_MaxX) values to the [`axisSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.SparklineAxisSettings.html) property. You can also change the min and max values of y-axis by setting the [`minY`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.SparklineAxisSettings.html#Syncfusion_EJ2_Charts_SparklineAxisSettings_MinY) and [`maxY`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.SparklineAxisSettings.html#Syncfusion_EJ2_Charts_SparklineAxisSettings_MaxY) values to the [`axisSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.SparklineAxisSettings.html) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sparkline/axis/minmax/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Minmax.cs" %}
{% include code-snippet/sparkline/axis/minmax/minmax.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sparkline/axis/minmax/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Minmax.cs" %}
{% include code-snippet/sparkline/axis/minmax/minmax.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Change value of axis

You can set horizontal axis line value of the sparkline by setting [`value`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.SparklineAxisSettings.html#Syncfusion_EJ2_Charts_SparklineAxisSettings_Value) to the [`axisSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.SparklineAxisSettings.html) property. The following code example shows this.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sparkline/axis/value/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Value.cs" %}
{% include code-snippet/sparkline/axis/value/value.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sparkline/axis/value/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Value.cs" %}
{% include code-snippet/sparkline/axis/value/value.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Axis line customization

Axis of the sparkline can be collapsed using the [`visible`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.SparklineLineSettings.html#Syncfusion_EJ2_Charts_SparklineLineSettings_Visible) property in [`lineSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.SparklineLineSettings.html); this is not applicable for win-loss. You can customize the [`color`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.SparklineLineSettings.html#Syncfusion_EJ2_Charts_SparklineLineSettings_Color), [`width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.SparklineLineSettings.html#Syncfusion_EJ2_Charts_SparklineLineSettings_Width), [`opacity`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.SparklineLineSettings.html#Syncfusion_EJ2_Charts_SparklineLineSettings_Opacity), and [`dashArray`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.SparklineLineSettings.html#Syncfusion_EJ2_Charts_SparklineLineSettings_DashArray) of axis line.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sparkline/axis/axis-line/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Axis_line.cs" %}
{% include code-snippet/sparkline/axis/axis-line/axis_line.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sparkline/axis/axis-line/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Axis_line.cs" %}
{% include code-snippet/sparkline/axis/axis-line/axis_line.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

