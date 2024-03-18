---
layout: post
title: Tooltip in ##Platform_Name## Syncfusion Circular Chart 3D Component
description: Learn here all about Tooltip in Syncfusion ##Platform_Name## Circular Chart 3D component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Tooltip
publishingplatform: ##Platform_Name##
documentation: ug
---


# Tooltip in ##Platform_Name## Circular Chart 3D component

Tooltip for the Circular Chart 3D can be enabled by using the `Enable` property.

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

We can specify header for the tooltip using `Header` property.

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

By default, tooltip shows information of x and y value in points. In addition to that, you can show more information in tooltip. For example the format `${series.name} ${point.x}` shows series name and point x value.

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



## Tooltip format

Any HTML element can be displayed in the tooltip by using the `Template` property.

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

By default, tooltip track the mouse movement, but you can set a fixed position for the tooltip by using the `Location` property.

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

The `Fill` and `Border` properties are used to customize the background color and border of the tooltip respectively. The `TextStyle` property in the tooltip is used to customize the font of the tooltip text. The `HighlightColor` property can be used to change the color of the data point when hovering.

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



## To customize individual tooltip

Using `TooltipRender` event, you can customize a tooltip for particular point.

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


