---
layout: post
title: Tooltip in ##Platform_Name## Syncfusion 3D Circular Chart Component
description: Learn here all about tooltip in Syncfusion ##Platform_Name## 3D Circular Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Tooltip
publishingplatform: ##Platform_Name##
documentation: ug
---


# Tooltip in ##Platform_Name## 3D Circular Chart component

The 3D Circular Chart will display details about the points through a tooltip, when the mouse is moved over a specific point. By default, the tooltip is not visible. It can be enabled by using the `Enable` property in `Tooltip` to **true**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circular-chart/user-interaction/tooltip/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip.cs" %}
{% include code-snippet/circular-chart/user-interaction/tooltip/tooltip.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circular-chart/user-interaction/tooltip/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip.cs" %}
{% include code-snippet/circular-chart/user-interaction/tooltip/tooltip.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Header

You can specify a header for the tooltip by using the `Header` property in `Tooltip`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circular-chart/user-interaction/header/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Header.cs" %}
{% include code-snippet/circular-chart/user-interaction/header/header.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circular-chart/user-interaction/header/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Header.cs" %}
{% include code-snippet/circular-chart/user-interaction/header/header.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Format

By default, the tooltip shows information about the x and y values in points. Additionally, more information can be displayed in the tooltip by using the `Format` property. For example, the format `${series.name} : ${point.x}` shows the series name and the point's x value.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circular-chart/user-interaction/tooltip-format/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip-format.cs" %}
{% include code-snippet/circular-chart/user-interaction/tooltip-format/tooltip-format.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circular-chart/user-interaction/tooltip-format/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip-format.cs" %}
{% include code-snippet/circular-chart/user-interaction/tooltip-format/tooltip-format.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Tooltip template

Any HTML elements can be displayed in the tooltip by using the `Template` property in the tooltip.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circular-chart/user-interaction/template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Template.cs" %}
{% include code-snippet/circular-chart/user-interaction/template/template.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circular-chart/user-interaction/template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Template.cs" %}
{% include code-snippet/circular-chart/user-interaction/template/template.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Fixed tooltip

By default, the tooltip tracks the mouse movement, but it can be set to a fixed position using the `Location` property in `Tooltip`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circular-chart/user-interaction/fixed-tooltip/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Fixed-tooltip.cs" %}
{% include code-snippet/circular-chart/user-interaction/fixed-tooltip/fixed-tooltip.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circular-chart/user-interaction/fixed-tooltip/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Fixed-tooltip.cs" %}
{% include code-snippet/circular-chart/user-interaction/fixed-tooltip/fixed-tooltip.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Customization

The `Fill` and `Border` properties are used to customize the background color and border of the tooltip, respectively. The `TextStyle` property in the tooltip is used to customize the font of the tooltip text. Additionally, the `HighlightColor` property can be used to change the color of the data point when hovering.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circular-chart/user-interaction/tooltip-custom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip-custom.cs" %}
{% include code-snippet/circular-chart/user-interaction/tooltip-custom/tooltip-custom.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circular-chart/user-interaction/tooltip-custom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip-custom.cs" %}
{% include code-snippet/circular-chart/user-interaction/tooltip-custom/tooltip-custom.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Customization of individual tooltip

Using the `TooltipRender` event, you can customize tooltip values for a particular point.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circular-chart/user-interaction/tooltip-event/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip-event.cs" %}
{% include code-snippet/circular-chart/user-interaction/tooltip-event/tooltip-event.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circular-chart/user-interaction/tooltip-event/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip-event.cs" %}
{% include code-snippet/circular-chart/user-interaction/tooltip-event/tooltip-event.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


