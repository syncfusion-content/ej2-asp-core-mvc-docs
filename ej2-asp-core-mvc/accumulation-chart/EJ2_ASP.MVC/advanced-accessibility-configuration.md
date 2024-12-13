---
layout: post
title: Accessibility customization in Syncfusion Accumulation chart Component
description: Learn here all about Accessibility customization in Syncfusion ASP MVC Accumulation Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Accessibility customization
publishingplatform: ##Platform_Name##
documentation: ug
---


# Accessibility customization

The Syncfusion® ##Platform_Name## Accumulation Chart control is structured to visualize data in a graphical manner. It provides robust customization options for accessibility, allowing you to enhance the user experience for those with disabilities. The main attributes of the ##Platform_Name## Accumulation Chart control's accessibility customization are briefly explained in this section.

The accumulation chart control has a number of characteristics that enable accessibility features to be customized, including:

* `AccessibilityDescription` - Provides a text description for the accumulation chart, improving support for screen readers.
* `AccessibilityRole` - Specifies the role of the accumulation chart, helping screen readers to identify the element appropriately.
* `Focusable` - Allows the accumulation chart to receive focus, making it accessible via keyboard navigation.
* `FocusBorderColor` - Sets the color of the focus border, enhancing visibility when the accumulation chart is focused.
* `FocusBorderMargin` - Defines the margin around the focus border.
* `FocusBorderWidth` - Specifies the width of the focus border.
* `TabIndex` - Specifies the tab order for the accumulation chart element, enabling efficient keyboard navigation.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/accessibility/pie-chart/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Pie-chart.cs" %}
{% include code-snippet/chart/accumulation-charts/accessibility/pie-chart/pie-chart.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/accessibility/pie-chart/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Pie-chart.cs" %}
{% include code-snippet/chart/accumulation-charts/accessibility/pie-chart/pie-chart.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Series

The `Series` supports the customization of accessibility for data points, allowing key characteristics to be adjusted for enhanced accessibility, such as:

* `AccessibilityDescription` - Provides a text description for the series root element, enhancing support for screen readers.
* `AccessibilityRole` - Specifies the role of the series, helping screen readers to identify the element appropriately.
* `Focusable` - Allows the series to receive focus, making it accessible via keyboard navigation.
* `TabIndex` - Specifies the tab order of the series element, enabling efficient keyboard navigation.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/accessibility/series/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Series.cs" %}
{% include code-snippet/chart/accumulation-charts/accessibility/series/series.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/accessibility/series/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Series.cs" %}
{% include code-snippet/chart/accumulation-charts/accessibility/series/series.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Legend

The `LegendSettings` provide information about the series shown in the accumulation chart. The following `Accessibility` properties in `LegendSettings` can be used to alter the accessibility of the accumulation chart's legend:

* `AccessibilityDescription` - Provides a text description for the legend root element, enhancing support for screen readers..
* `AccessibilityRole` - Specifies the role of the legend items to screen readers, providing appropriate context.
* `Focusable` - Specifies whether legend items are focusable via keyboard navigation.
* `TabIndex` - Specifies the tab order of the legend element, enabling efficient keyboard navigation.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/accessibility/legend/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Legend.cs" %}
{% include code-snippet/chart/accumulation-charts/accessibility/legend/legend.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/accessibility/legend/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Legend.cs" %}
{% include code-snippet/chart/accumulation-charts/accessibility/legend/legend.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}