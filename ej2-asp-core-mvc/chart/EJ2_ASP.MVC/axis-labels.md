---
layout: post
title: Axis Labels in ##Platform_Name## Chart Component
description: Learn here all about Axis Labels in Syncfusion ##Platform_Name## Chart component and more.
platform: ej2-asp-core-mvc
control: Axis Labels
publishingplatform: ##Platform_Name##
documentation: ug
---


# Axis Labels

## Smart Axis Labels

When the axis labels overlap with each other, you can use [`LabelIntersectAction`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_LabelIntersectAction)
property in the axis, to place them smartly.

When setting `LabelIntersectAction` as `Hide`

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/multiple/hide/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Hide.cs" %}
{% include code-snippet/chart/axis/multiple/hide/hide.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/multiple/hide/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Hide.cs" %}
{% include code-snippet/chart/axis/multiple/hide/hide.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



When setting `LabelIntersectAction` as `Rotate45`

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/multiple/rotate45/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Rotate45.cs" %}
{% include code-snippet/chart/axis/multiple/rotate45/rotate45.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/multiple/rotate45/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Rotate45.cs" %}
{% include code-snippet/chart/axis/multiple/rotate45/rotate45.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



When setting `LabelIntersectAction` as `Rotate90`

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/multiple/rotate90/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Rotate90.cs" %}
{% include code-snippet/chart/axis/multiple/rotate90/rotate90.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/multiple/rotate90/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Rotate90.cs" %}
{% include code-snippet/chart/axis/multiple/rotate90/rotate90.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Axis Labels Positioning

By default, the axis labels can be placed at `Outside` the axis line and this also can be placed at `Inside`
the axis line using the `LabelPosition` property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/multiple/position/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Position.cs" %}
{% include code-snippet/chart/axis/multiple/position/position.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/multiple/position/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Position.cs" %}
{% include code-snippet/chart/axis/multiple/position/position.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Multilevel Labels

Any number of levels of labels can be added to an axis using the `MultiLevelLabels` property. This property can be
configured using the following properties:

• Categories
• Overflow
• Alignment
• Text style
• Border

### Categories

Using the categories property, you can configure the `Start`, `End`, `Text`, and `MaximumTextWidth` of multilevel labels.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/multiple/multi-category/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Category.cs" %}
{% include code-snippet/chart/axis/multiple/multi-category/category.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/multiple/multi-category/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Category.cs" %}
{% include code-snippet/chart/axis/multiple/multi-category/category.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Overflow

Using the `Overflow` property, you can `Trim` or `Wrap` the multilevel labels.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/multiple/multi-overflow/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Overflow.cs" %}
{% include code-snippet/chart/axis/multiple/multi-overflow/overflow.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/multiple/multi-overflow/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Overflow.cs" %}
{% include code-snippet/chart/axis/multiple/multi-overflow/overflow.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Alignment

The `Alignment` property provides option to position the multilevel labels at `Far`, `Center`, or `Near`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/multiple/multi-alignment/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Alignement.cs" %}
{% include code-snippet/chart/axis/multiple/multi-alignment/alignement.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/multiple/multi-alignment/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Alignement.cs" %}
{% include code-snippet/chart/axis/multiple/multi-alignment/alignement.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Text customization

The `TextStyle` property of multilevel labels provides options to customize the `Size`, `Color`, `FontFamily`,
`FontWeight`, `FontStyle`, `Opacity`, `TextAlignment` and `TextOverflow`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/multiple/multi-textcustom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Text-custom.cs" %}
{% include code-snippet/chart/axis/multiple/multi-textcustom/text-custom.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/multiple/multi-textcustom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Text-custom.cs" %}
{% include code-snippet/chart/axis/multiple/multi-textcustom/text-custom.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Border customization

Using the `Border` property, you can customize the `Width`, `Color`, and `Type`. The `Type` of border
are `Rectangle`, `Brace`, `WithoutBorder`, `WithoutTopBorder`, `WithoutTopandBottomBorder` and `CurlyBrace`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/multiple/multi-bordercustom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Border-custom.cs" %}
{% include code-snippet/chart/axis/multiple/multi-bordercustom/border-custom.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/multiple/multi-bordercustom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Border-custom.cs" %}
{% include code-snippet/chart/axis/multiple/multi-bordercustom/border-custom.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Edge Label Placement

Labels with long text at the edges of an axis may appear partially in the chart. To avoid this,
use [`EdgeLabelPlacement`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_EdgeLabelPlacement) property in axis, which moves
the label inside the chart area for better appearance or hides it.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/multiple/edge/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Edge.cs" %}
{% include code-snippet/chart/axis/multiple/edge/edge.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/multiple/edge/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Edge.cs" %}
{% include code-snippet/chart/axis/multiple/edge/edge.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Labels Customization

The [`LabelStyle`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_LabelStyle) property of an axis provides options to customize the
`Color`, `Font-family`, `Font-size` and `Font-weight` of the axis labels.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/multiple/labels-custom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Labels-custom.cs" %}
{% include code-snippet/chart/axis/multiple/labels-custom/labels-custom.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/multiple/labels-custom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Labels-custom.cs" %}
{% include code-snippet/chart/axis/multiple/labels-custom/labels-custom.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Customizing Specific Point

You can customize the specific text in the axis labels using `AxisLabelRender` event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/multiple/custom-point/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-point.cs" %}
{% include code-snippet/chart/axis/multiple/custom-point/custom-point.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/multiple/custom-point/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-point.cs" %}
{% include code-snippet/chart/axis/multiple/custom-point/custom-point.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Trim using maximum label width

You can trim the label using [`EnableTrim`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_EnableTrim) property and width of the labels can also be customized using [`MaximumLabelWidth`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_MaximumLabelWidth) property in the axis, the value maximum label width is `34` by default.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/multiple/labels-trim/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Labels-trim.cs" %}
{% include code-snippet/chart/axis/multiple/labels-trim/labels-trim.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/multiple/labels-trim/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Labels-trim.cs" %}
{% include code-snippet/chart/axis/multiple/labels-trim/labels-trim.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Line break support

Line break feature used to customize the long axis label text into multiple lines by using
`<br>` tag. Refer the below example in that dataSource x value contains long text, it breaks into two lines by using  `<br>` tag.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/multiple/line-break/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Line-break.cs" %}
{% include code-snippet/chart/axis/multiple/line-break/line-break.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/multiple/line-break/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Line-break.cs" %}
{% include code-snippet/chart/axis/multiple/line-break/line-break.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Maximum Labels

`MaximumLabels` property is set, then the labels will be rendered based on the count in the property per 100 pixel. If you have set range (minimum, maximum, interval) and maximumLabels, then the priority goes to range only. If you haven’t set the range, then we have considered priority to maximumLabels property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="Max-label.cs" %}
{% include code-snippet/chart/axis/multiple/max-label/max-label.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/multiple/max-label/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Max-label.cs" %}
{% include code-snippet/chart/axis/multiple/max-label/max-label.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

