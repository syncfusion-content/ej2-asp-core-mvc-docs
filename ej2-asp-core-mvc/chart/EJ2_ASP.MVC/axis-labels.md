---
layout: post
title: Axis Labels in Syncfusion ##Platform_Name## Chart Component
description: Learn here all about Axis Labels in Syncfusion ##Platform_Name## Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Axis Labels
publishingplatform: ##Platform_Name##
documentation: ug
---


# Axis Labels in ##Platform_Name## Chart Component

## Smart Axis Labels

When axis labels overlap due to limited space or dense data points, the [`LabelIntersectAction`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_LabelIntersectAction) property can be used to control how the labels are rendered. This helps improve readability by automatically adjusting label visibility or orientation.

When setting `LabelIntersectAction` as `Hide`, overlapping labels are hidden to avoid visual clutter.

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



When setting `labelIntersectAction` as `Rotate45`, the labels are rotated by 45 degrees to reduce overlap.

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



When setting `labelIntersectAction` as `Rotate90`, the labels are rotated vertically to maximize space utilization.

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

By default, axis labels are positioned `Outside` the axis line. Labels can also be placed `Inside` the axis line using the `LabelPosition` property, which is useful when optimizing space within the chart area.

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

Multiple levels of labels can be displayed on an axis using the `MultiLevelLabels` property. This feature is useful for grouping related categories and improving data interpretation. The following configuration options are available:

• Categories  
• Overflow  
• Alignment  
• Text style  
• Border

### Categories

Using the categories property, the `Start`, `End`, `Text`, and `MaximumTextWidth` values of multilevel labels can be configured to define the label range and content.

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

Using the `Overflow` property, multilevel labels can be configured to either `Trim` or `Wrap` when the text exceeds the available space.

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

The `Alignment` property provides options to position multilevel labels at `Far`, `Center`, or `Near` relative to the axis.

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

The `TextStyle` property of multilevel labels provides options to customize the `Size`, `Color`, `FontFamily`, `FontWeight`, `FontStyle`, `Opacity`, `TextAlignment`, and `TextOverflow`.

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

Using the `Border` property, the `Width`, `Color`, and `Type` of the multilevel label border can be customized. The supported border types are `Rectangle`, `Brace`, `WithoutBorder`, `WithoutTopBorder`, `WithoutTopandBottomBorder`, and `CurlyBrace`.

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

Labels with long text at the edges of an axis may appear partially outside the chart area. To avoid this, use the [`EdgeLabelPlacement`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_EdgeLabelPlacement) property in the axis. This property moves the label inside the chart area or hides it for better appearance. By default, the [`EdgeLabelPlacement`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_EdgeLabelPlacement) property is set to **Shift**, ensuring that labels are repositioned inside the chart area to prevent overlap.

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

The [`LabelStyle`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_LabelStyle) property of an axis provides options to customize the `Color`, `Font-family`, `Font-size`, and `Font-weight` of axis labels.

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

Specific axis label text can be customized using the `AxisLabelRender` event, which allows conditional formatting or dynamic text updates during label rendering.

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

The line break feature is used to display long axis label text across multiple lines. In the following example, the `x` value in the data source contains long text, which is split into two lines using the `<br>` tag.

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


## Axis label template

The axis label template allows axis labels to be customized using HTML content. This enables conditional styling and the inclusion of dynamic elements such as icons, images, or additional contextual data. This customization is enabled by setting the template content in the `LabelTemplate` property of the [ChartAxis](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="Label-template.cs" %}
{% include code-snippet/chart/axis/multiple/label-template/label-template.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/multiple/label-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Label-template.cs" %}
{% include code-snippet/chart/axis/multiple/label-template/label-template.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![ASP.NET MVC Chart Control](images/axislabel-template.png)