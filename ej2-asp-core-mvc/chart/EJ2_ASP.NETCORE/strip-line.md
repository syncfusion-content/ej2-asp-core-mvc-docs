---
layout: post
title: Strip Line in ##Platform_Name## Chart Component
description: Learn here all about Strip Line in Syncfusion ##Platform_Name## Chart component and more.
platform: ej2-asp-core-mvc
control: Strip Line
publishingplatform: ##Platform_Name##
documentation: ug
---


<!-- markdownlint-disable MD036 -->

# Strip lines

<!-- markdownlint-disable MD036 -->

EJ2 chart supports horizontal and vertical strip lines and customization of stripline in both orientation.

## Horizontal Strip lines

You can create Horizontal stripline by adding the `stripline` in the vertical axis and set `visible` option to true.
Striplines are rendered in the specified start to end range and you can add more than one stripline for an axis.

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

You can create vertical stripline by adding the`stripline` in the horizontal axis and set `visible` option to true.
Striplines are rendered in the specified start to end range and you can add more than one stripline for an axis.

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

Starting value in specific strip line can be customized by `start` property in strip line. Similarly, ending value
is customized by `end`. It can be also set for starting from the corresponding origin of the axis by `startFromOrigin`.
Size of the strip line is customized by `size`. Border for the stripline is customized by `border`.
Order of the strip line such that whether it should be rendered in behind or over the series elements
is customized by `zIndex`.

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

You can customize the text rendered in stripline by `textStyle` property. Rotation of the strip line text can be changed by `rotation` property.
Horizontal and Vertical alignment of stripline text can be changed by `horizontalAlignment` and `verticalAlignment` property.

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

You can create dash array stripline by using `dashArray` property. The Striplines are rendered with specified dash array values.

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

* `isRepeat`       - It is used for enable / disable the recurrence strip line.
* `repeatEvery`    - It is used for mention the stripline interval.
* `repeatUntil`    - It specifies the end value at which point strip line has to stop repeating.

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

The `sizeType` property refers the size of the stripline. They are,

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

You can create stripline in a particular region with respect to segment. You can enable the segment stripline using `isSegmented` property. The start and end value of this type of stripline can be defined using `segmentStart` and `segmentEnd` properties.

* `isSegmented`     - It is used for enable the segment stripline.
* `segmentStart`    - Used to change the segment start value. Value correspond to associated axis.
* `segmentEnd`      - Used to change the segment end value. Value correspond to associated axis.
* `segmentAxisName` - Used to specify the name of the associated axis.

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

