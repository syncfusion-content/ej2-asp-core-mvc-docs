---
layout: post
title: Strip Line in ##Platform_Name## Chart Component
description: Learn here all about Strip Line in Syncfusion ##Platform_Name## Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Strip Line
publishingplatform: ##Platform_Name##
documentation: ug
---


<!-- markdownlint-disable MD036 -->

# Strip lines

<!-- markdownlint-disable MD036 -->

The ##Platform_Name## Chart component supports horizontal and vertical strip lines, providing visual guides to highlight specific ranges in the chart area. Strip lines can be added to both axes and fully customized based on visual and functional requirements.

## Horizontal Strip lines

Horizontal strip lines are created by adding the `Stripline` configuration to the vertical axis and setting the `Visible` property to `true`. They highlight horizontal ranges in the chart, and multiple strip lines can be added to the same axis.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/strip-line/horizontal/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Horizontal.cs" %}
{% include code-snippet/chart/axis/strip-line/horizontal/horizontal.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/strip-line/horizontal/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Horizontal.cs" %}
{% include code-snippet/chart/axis/strip-line/horizontal/horizontal.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Vertical Striplines

Vertical strip lines are created by adding the `Stripline` configuration to the horizontal axis and enabling the `Visible` property. They highlight vertical regions in the chart and support multiple entries for an axis.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/strip-line/vertical/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Vertical.cs" %}
{% include code-snippet/chart/axis/strip-line/vertical/vertical.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/strip-line/vertical/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Vertical.cs" %}
{% include code-snippet/chart/axis/strip-line/vertical/vertical.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Customize the strip line

Strip lines can be customized to highlight specific regions more effectively:

- Use `Start` to set the beginning value of the strip line.
- Use `End` to define the ending value.
- Use `StartFromOrigin` to begin the strip line from the axis origin.
- Use `Size` to specify the strip line height or width (based on orientation).
- Use `Border` to customize border appearance.
- Use `ZIndex` to control whether the strip line appears behind or above chart series.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/strip-line/custom-stripline/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-stripline.cs" %}
{% include code-snippet/chart/axis/strip-line/custom-stripline/custom-stripline.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/strip-line/custom-stripline/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-stripline.cs" %}
{% include code-snippet/chart/axis/strip-line/custom-stripline/custom-stripline.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Customize the stripline text

Strip line text labels can be customized for readability and visual presentation:

- Use `TextStyle` to set text appearance.
- Use `Rotation` to rotate the strip line text.
- Use `HorizontalAlignment` and `VerticalAlignment` to adjust label placement.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/strip-line/custom-striptext/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-striptext.cs" %}
{% include code-snippet/chart/axis/strip-line/custom-striptext/custom-striptext.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/strip-line/custom-striptext/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-striptext.cs" %}
{% include code-snippet/chart/axis/strip-line/custom-striptext/custom-striptext.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Dash Array

You can create dash array stripline by using `DashArray` property. The Striplines are rendered with specified dash array values.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/strip-line/dasarray/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Dash.cs" %}
{% include code-snippet/chart/axis/strip-line/dasarray/dash.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/strip-line/dasarray/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Dash.cs" %}
{% include code-snippet/chart/axis/strip-line/dasarray/dash.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Recurrence Stripline

The strip lines to be drawn repeatedly at the regular intervals – this will be useful when you want to mark an event that occurs recursively along the timeline of the chart. Following properties are used to configure this feature.

* `IsRepeat`       - It is used for enable / disable the recurrence strip line.
* `RepeatEvery`    - It is used for mention the stripline interval.
* `RepeatUntil`    - It specifies the end value at which point strip line has to stop repeating.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/strip-line/recurrence/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Recurrence.cs" %}
{% include code-snippet/chart/axis/strip-line/recurrence/recurrence.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/strip-line/recurrence/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Recurrence.cs" %}
{% include code-snippet/chart/axis/strip-line/recurrence/recurrence.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Size Type

The `SizeType` property refers the size of the stripline. They are,

* `Auto`
* `Pixel`
* `Years`
* `Months`
* `Days`
* `Hours`
* `Minutes`
* `Seconds`

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/strip-line/size-type/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Size-type.cs" %}
{% include code-snippet/chart/axis/strip-line/size-type/size-type.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/strip-line/size-type/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Size-type.cs" %}
{% include code-snippet/chart/axis/strip-line/size-type/size-type.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Segment Stripline

You can create stripline in a particular region with respect to segment. You can enable the segment stripline using `IsSegmented` property. The start and end value of this type of stripline can be defined using `SegmentStart` and `SegmentEnd` properties.

* `IsSegmented`     - It is used for enable the segment stripline.
* `SegmentStart`    - Used to change the segment start value. Value correspond to associated axis.
* `SegmentEnd`      - Used to change the segment end value. Value correspond to associated axis.
* `SegmentAxisName` - Used to specify the name of the associated axis.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/strip-line/segment/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Segment.cs" %}
{% include code-snippet/chart/axis/strip-line/segment/segment.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/strip-line/segment/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Segment.cs" %}
{% include code-snippet/chart/axis/strip-line/segment/segment.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

