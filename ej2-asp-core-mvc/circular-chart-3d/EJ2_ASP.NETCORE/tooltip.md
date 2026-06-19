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

## Inline tooltip formatting

The tooltip content can be formatted directly within the `Format` property by adding DateTime or number format specifiers to supported tooltip tokens. This allows you to control how point and series values are displayed without using additional events.

A format specifier is applied by adding a colon (`:`) followed by the required format.

For example:

```cshtml
    <e-circularchart3d-tooltipsettings enable="true" 
                                       format="${point.x:MMM yyyy} : <b>${point.y:n2}%</b>">
    </e-circularchart3d-tooltipsettings>
```

In the above example, `point.x` is displayed in month-year format and `point.y` is displayed with two decimal places.

Inline formatting can be applied to the following tooltip tokens:

- `point.x` – Specifies the x-value or category value of the 3D circular chart point.
- `point.y` – Specifies the numeric y-value of the 3D circular chart point.
- `point.percentage` – Specifies the percentage contribution of the point value in the 3D circular chart.
- `point.text` – Specifies the text value mapped to the point, when text mapping is configured.
- `point.tooltip` – Specifies the tooltip value mapped from the data source, when tooltip mapping is configured.
- `point.index` – Specifies the index position of the point in the 3D circular chart.
- `point.color` – Specifies the fill color applied to the point.
- `point.visible` – Specifies the visibility state of the point.
- `series.name` – Specifies the name assigned to the 3D circular chart series.
- `series.opacity` – Specifies the opacity value applied to the 3D circular chart series.

**Important:** The availability of point-specific tokens depends on the values configured in the data source and the 3D circular chart series. For example, `point.percentage` is useful for pie and doughnut charts, while `point.text` and `point.tooltip` depend on the corresponding field mappings. String tokens such as `series.name`, `point.text`, `point.tooltip`, `point.color`, and `point.visible` return string values, so DateTime or number formatting is not applied to these tokens.

The following format types are supported:

- DateTime formats such as `MMM yyyy`, `MM:yy`, and `dd MMM`
- Number formats such as:
  - `n2` – number with two decimal places
  - `n0` – number without decimals
  - `c2` – currency format
  - `p1` – percentage format
  - `e1` – exponential notation

If the specified format does not match the resolved value type, the original value is displayed.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circular-chart/user-interaction/inline-format/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Inline-format.cs" %}
{% include code-snippet/circular-chart/user-interaction/inline-format/inline-format.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circular-chart/user-interaction/inline-format/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Inline-format.cs" %}
{% include code-snippet/circular-chart/user-interaction/inline-format/inline-format.cs %}
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


