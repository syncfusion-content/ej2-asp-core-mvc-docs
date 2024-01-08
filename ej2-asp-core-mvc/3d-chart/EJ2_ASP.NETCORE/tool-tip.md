---
layout: post
title: Tooltip in ##Platform_Name## 3D Chart Component
description: Learn here all about Tooltip in Syncfusion ##Platform_Name## 3D Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Tooltip
publishingplatform: ##Platform_Name##
documentation: ug
---

# Tooltip in ##Platform_Name## 3D Chart Component

3D Chart will display details about the points through tooltip, when the mouse is moved over the specific point.

## Default tooltip

By default, tooltip is not visible. The tooltip can be enabled by setting [`Enable`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart3DTooltipSettings.html#Syncfusion_EJ2_Charts_Chart3DTooltipSettings_Enable) property to **true**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/user-interaction/default-tooltip/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default-tooltip.cs" %}
{% include code-snippet/3d-chart/series/user-interaction/default-tooltip/default-tooltip.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/user-interaction/default-tooltip/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default-tooltip.cs" %}
{% include code-snippet/3d-chart/series/user-interaction/default-tooltip/default-tooltip.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Fixed tooltip

By default, tooltip track the mouse movement, but the tooltip can be set in fixed position by using the [`Location`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart3DTooltipSettings.html#Syncfusion_EJ2_Charts_Chart3DTooltipSettings_Location) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/user-interaction/fixed-tooltip/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Fixed-tooltip.cs" %}
{% include code-snippet/3d-chart/series/user-interaction/fixed-tooltip/fixed-tooltip.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/user-interaction/fixed-tooltip/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Fixed-tooltip.cs" %}
{% include code-snippet/3d-chart/series/user-interaction/fixed-tooltip/fixed-tooltip.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Format the tooltip

By default, tooltip shows information of x and y value in points. In addition to that, more information can be shown in tooltip by using the [`Format`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart3DTooltipSettings.html#Syncfusion_EJ2_Charts_Chart3DTooltipSettings_Format) property. For example the format `${series.name} : ${point.y}` shows series name and point x value.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/user-interaction/format-tooltip/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Format-tooltip.cs" %}
{% include code-snippet/3d-chart/series/user-interaction/format-tooltip/format-tooltip.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/user-interaction/format-tooltip/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Format-tooltip.cs" %}
{% include code-snippet/3d-chart/series/user-interaction/format-tooltip/format-tooltip.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Tooltip template

Any HTML elements can be displayed in the tooltip by using the [`Template`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart3DTooltipSettings.html#Syncfusion_EJ2_Charts_Chart3DTooltipSettings_Template) property of the tooltip. The ${x} and ${y} can be used as place holders in the HTML element to display the x and y values of the corresponding data point.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/user-interaction/template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Template.cs" %}
{% include code-snippet/3d-chart/series/user-interaction/template/template.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/user-interaction/template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Template.cs" %}
{% include code-snippet/3d-chart/series/user-interaction/template/template.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Customize the appearance of tooltip

The [`Fill`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart3DTooltipSettings.html#Syncfusion_EJ2_Charts_Chart3DTooltipSettings_Fill) and [`Border`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart3DTooltipSettings.html#Syncfusion_EJ2_Charts_Chart3DTooltipSettings_Border) properties are used to customize the background color and border of the tooltip respectively. The [`TextStyle`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart3DTooltipSettings.html#Syncfusion_EJ2_Charts_Chart3DTooltipSettings_TextStyle) property in the tooltip is used to customize the font of the tooltip text.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/user-interaction/custom-tooltip/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-tooltip.cs" %}
{% include code-snippet/3d-chart/series/user-interaction/custom-tooltip/custom-tooltip.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/user-interaction/custom-tooltip/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-tooltip.cs" %}
{% include code-snippet/3d-chart/series/user-interaction/custom-tooltip/custom-tooltip.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


