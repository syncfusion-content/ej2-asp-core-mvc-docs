---
layout: post
title: User Interaction in ##Platform_Name## Sparkline Component
description: Learn here all about User Interaction in Syncfusion ##Platform_Name## Sparkline component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: User Interaction
publishingplatform: ##Platform_Name##
documentation: ug
---


# User interactions

Sparkline has two user interaction features: tooltip and tracker line.

## Tooltip

The sparkline provides options to display details about values of data points through tooltips when hovering the mouse over data point. To use tooltip in sparkline, inject the [`SparklineTooltip`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Charts.SparklineSparklineTooltipSettings.html) module to sparkline using the inject method.

The following code example shows enabling tooltip for sparkline with format.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sparkline/user-interaction/tooltip/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip.cs" %}
{% include code-snippet/sparkline/user-interaction/tooltip/tooltip.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sparkline/user-interaction/tooltip/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip.cs" %}
{% include code-snippet/sparkline/user-interaction/tooltip/tooltip.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Tooltip customization

The fill color, text styles, format, and border of the tooltip can be customized. The following code example shows customization of tooltip's fill color and text style.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sparkline/user-interaction/tooltip-custom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip-custom.cs" %}
{% include code-snippet/sparkline/user-interaction/tooltip-custom/tooltip-custom.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sparkline/user-interaction/tooltip-custom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip-custom.cs" %}
{% include code-snippet/sparkline/user-interaction/tooltip-custom/tooltip-custom.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Inline tooltip formatting

The tooltip content can be formatted directly within the [`format`] property by adding DateTime or number format specifiers to supported tooltip tokens. This allows you to control how point and series values are displayed without using additional events.

A format specifier can be applied to a tooltip token by adding a colon (`:`) followed by the required format.

For example:

```cshtml
<e-sparkline-tooltipsettings enable="true" format="${x:MMM yyyy} : ${y:n2}"></e-sparkline-tooltipsettings>
```

In the above example, `x` is displayed in month-year format and `y` is displayed with two decimal places.

Inline formatting can be applied to the following tooltip tokens:

- `${x}` or `${x:MMM yyyy}` – Specifies the x-value of the Sparkline data point, such as DateTime or category values.
- `${y}` or `${y:n2}` – Specifies the numeric y-value of the Sparkline data point.

**Important:** DateTime formatting is applied when the resolved value is a Date object, and number formatting is applied when the resolved value is numeric. 

The following format types are supported:

- DateTime formats such as `MMM yyyy`, `MM:yy`, and `dd MMM`
- Number formats such as:
  - `n2` – number with two decimal places
  - `n0` – number without decimals
  - `c2` – currency format
  - `p1` – percentage format

If the specified format does not match the resolved value type, the original value is displayed.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sparkline/user-interaction/inline-format/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Inline-format.cs" %}
{% include code-snippet/sparkline/user-interaction/inline-format/inline-format.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sparkline/user-interaction/inline-format/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Inline-format.cs" %}
{% include code-snippet/sparkline/user-interaction/inline-format/inline-format.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Tooltip template

Sparkline tooltip has template support. By using tooltip template, you can customize tooltips. The following code example shows more customization options provided to  `sparktooltip` class that is used in tooltip template div. Using this template, images also can be added to tooltip.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sparkline/user-interaction/tooltip-template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip_template.cs" %}
{% include code-snippet/sparkline/user-interaction/tooltip-template/tooltip-template.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sparkline/user-interaction/tooltip-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip_template.cs" %}
{% include code-snippet/sparkline/user-interaction/tooltip-template/tooltip-template.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Track line

The track line tracks data points that are closer to the mouse position or touch contact.

To enable track lines for sparkline, specify the [`visible`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Charts.SparklineTrackLineSettings~Visible.html) option of  [`trackLineSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Charts.SparklineTrackLineSettings.html) to true. Based on theme, tracker color will be changed. The default value of tracker color is black.

To use track line in sparkline, inject the [`SparklineTooltip`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Charts.SparklineSparklineTooltipSettings.html) module to sparkline using the inject method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sparkline/user-interaction/tooltip-trackline/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip_trackline.cs" %}
{% include code-snippet/sparkline/user-interaction/tooltip-trackline/tooltip-trackline.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sparkline/user-interaction/tooltip-trackline/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip_trackline.cs" %}
{% include code-snippet/sparkline/user-interaction/tooltip-trackline/tooltip-trackline.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

