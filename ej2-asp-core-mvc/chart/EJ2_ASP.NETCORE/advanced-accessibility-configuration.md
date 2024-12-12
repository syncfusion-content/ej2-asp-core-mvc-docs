---
layout: post
title: Accessibility customization in Syncfusion Accumulation chart Component
description: Learn here all about Accessibility customization in Syncfusion ASP MVC Accumulation Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Accessibility customization
publishingplatform: ##Platform_Name##
documentation: ug
---


# Accessibility customization in ##Platform_Name## Chart control

The Syncfusion® ##Platform_Name## Chart control is structured to visualize data in a graphical manner. It provides robust customization options for accessibility, allowing you to enhance the user experience for those with disabilities. The main attributes of the ##Platform_Name## Chart control's accessibility customization are briefly explained in this section.

The chart control has a number of characteristics that enable accessibility features to be customized, including:

* `accessibilityDescription` - Provides a text description for the chart, improving support for screen readers.
* `accessibilityRole` - Specifies the role of the chart, helping screen readers to identify the element appropriately.
* `focusable` - Allows the chart to receive focus, making it accessible via keyboard navigation.
* `focusBorderColor` - Sets the color of the focus border, enhancing visibility when the chart is focused.
* `focusBorderMargin` - Defines the margin around the focus border.
* `focusBorderWidth` - Specifies the width of the focus border.
* `tabIndex` - Specifies the tab order of the chart element, enabling efficient keyboard navigation.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accessibility/line/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Line.cs" %}
{% include code-snippet/chart/accessibility/line/line.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accessibility/line/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Line.cs" %}
{% include code-snippet/chart/accessibility/line/line.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Series

The `series` supports the customization of accessibility for data points, allowing key characteristics to be adjusted for enhanced accessibility, such as:

* `accessibilityDescription` - Provides a text description for the series root element, enhancing support for screen readers.
* `accessibilityDescriptionFormat` - Specifies a format for the accessibility description of each point in the series, allowing dynamic content. The format string can include the placeholders such as ${series.name}, ${point.x}, ${point.y}, ${point.high}, etc. For example, the format "${series.name} : ${point.x}" displays the series name and x-value of the point in the accessibility description. Data point's values like high, low, open, and close are applicable based on the series types.
* `accessibilityRole` - Specifies the role of the series, helping screen readers to identify the element appropriately.
* `focusable` - Allows the series to receive focus, making it accessible via keyboard navigation.
* `tabIndex` - Specifies the tab order of the series element, enabling efficient keyboard navigation.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accessibility/series/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Series.cs" %}
{% include code-snippet/chart/accessibility/series/series.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accessibility/series/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Series.cs" %}
{% include code-snippet/chart/accessibility/series/series.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Title and subtitle

In the ##Platform_Name## chart control, the `titleStyle` and `subTitleStyle` attributes allow you to customize the accessibility of the chart's title and subtitle. The following `accessibility` properties in `titleStyle` and `subTitleStyle` can be customized for accessibility:

* `accessibilityDescription` - Provides a text description for the chart title and subtitle, enhancing support for screen readers.
* `accessibilityRole` - Specifies the role of the chart title and subtitle, helping screen readers to identify the element appropriately.
* `focusable` - Enables or disables the keyboard navigation focus for the title and subtitle.
* `tabIndex` - Specifies the tab order of the title and subtitle element, enabling efficient keyboard navigation.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accessibility/title/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Title.cs" %}
{% include code-snippet/chart/accessibility/title/title.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accessibility/title/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Title.cs" %}
{% include code-snippet/chart/accessibility/title/title.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Annotations

The `annotations` property allows you to add annotations to the chart in specific regions. The following characteristics allow for the customization of the annotations accessibility:

* `accessibilityDescription` - Provides a text description for the annotation, enhancing support for screen readers.
* `accessibilityRole` - Specifies the role of the annotation, helping screen readers to identify the element appropriately.
* `focusable` - Specifies whether annotations are focusable via keyboard navigation.
* `tabIndex` - Specifies the tab order of the annotation element, enabling efficient keyboard navigation.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accessibility/annotation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Annotation.cs" %}
{% include code-snippet/chart/accessibility/annotation/annotation.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accessibility/annotation/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Annotation.cs" %}
{% include code-snippet/chart/accessibility/annotation/annotation.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Trendline

Customizable properties within the `trendlines` allow you to control the accessibility of the trendlines on the chart, including:

* `accessibilityDescription` - Provides a text description for the trendline, enhancing support for screen readers.
* `accessibilityRole` - Specifies the role of the trendline, helping screen readers to identify the element appropriately.
* `focusable` - Specifies whether trendlines are focusable via keyboard navigation.
* `tabIndex` - Specifies the tab order of the trendline element, enabling efficient keyboard navigation.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accessibility/trendline/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Trendline.cs" %}
{% include code-snippet/chart/accessibility/trendline/trendline.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accessibility/trendline/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Trendline.cs" %}
{% include code-snippet/chart/accessibility/trendline/trendline.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Zooming

The `zoomSettings` attributes allow you to adjust the chart's zooming capability. The following `accessibility` properties in `zoomSettings` offer the parameters for accessibility customization:

* `accessibilityDescription` - Provides a text description for the zoom toolkit items, enhancing support for screen readers.
* `accessibilityRole` - Specifies the role of the zoom toolkit items, helping screen readers to identify the element appropriately.
* `focusable` - Specifies whether zoom toolkit items are focusable via keyboard navigation.
* `tabIndex` - Specifies the tab order of the zooming element, enabling efficient keyboard navigation.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accessibility/zoom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Zoom.cs" %}
{% include code-snippet/chart/accessibility/zoom/zoom.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accessibility/zoom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Zoom.cs" %}
{% include code-snippet/chart/accessibility/zoom/zoom.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Technical indicators

Customizable properties within the `indicators` allow you to control the accessibility of the technical indicators on the chart, including:

* `accessibilityDescription` - Provides a text description for the indicators, enhancing support for screen readers.
* `accessibilityRole` - Specifies the role of the indicators, helping screen readers to identify the element appropriately.
* `focusable` - Specifies whether indicators are focusable via keyboard navigation.
* `tabIndex` - Specifies the tab order of the indicators element, enabling efficient keyboard navigation.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accessibility/indicator/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Indicator.cs" %}
{% include code-snippet/chart/accessibility/indicator/indicator.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accessibility/indicator/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Indicator.cs" %}
{% include code-snippet/chart/accessibility/indicator/indicator.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Legend

The `legendSettings` provide information about the series shown in the chart. The following `accessibility` properties in `legendSettings` can be used to alter the accessibility of the chart's legend:

* `accessibilityDescription` - Provides a text description for the legend root element, enhancing support for screen readers.
* `accessibilityRole` - Specifies the role of the legend items to screen readers, providing appropriate context.
* `focusable` - Specifies whether legend items are focusable via keyboard navigation.
* `tabIndex` - Specifies the tab order of the legend element, enabling efficient keyboard navigation.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accessibility/legend/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Legend.cs" %}
{% include code-snippet/chart/accessibility/legend/legend.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accessibility/legend/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Legend.cs" %}
{% include code-snippet/chart/accessibility/legend/legend.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}