---
layout: post
title: Axis in Syncfusion ##Platform_Name## HeatMap Chart Component
description: Learn here all about axis in Syncfusion ##Platform_Name## HeatMap Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Axis
publishingplatform: ##Platform_Name##
documentation: ug
---


# Axis in ##Platform_Name## HeatMap Chart Component

HeatMap consists of two axes namely, X-axis and Y-axis that displays the row headers and column headers to plot the data points respectively. You can define the type, format, and other customizing options for both axes in the HeatMap.

## Types

{% if page.publishingplatform == "aspnet-core" %}

There are three different axis types available in the HeatMap, which defines the data type of the axis labels. You can define the axis type by using the [valueType](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapAxis.html#Syncfusion_EJ2_HeatMap_HeatMapAxis_ValueType) property in the HeatMap.

{% elsif page.publishingplatform == "aspnet-mvc" %}

There are three different axis types available in the HeatMap, which defines the data type of the axis labels. You can define the axis type by using the [ValueType](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapAxis.html#Syncfusion_EJ2_HeatMap_HeatMapAxis_ValueType) property in the HeatMap.

{% endif %}

### Category axis

Category axis type is used to represent the string values in axis labels.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/axis/category/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Category.cs" %}
{% include code-snippet/heatmap/axis/category/category.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/axis/category/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Category.cs" %}
{% include code-snippet/heatmap/axis/category/category.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


### Numeric axis

Numeric axis type is used to represent the numeric values in axis labels.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/axis/numeric/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Numeric.cs" %}
{% include code-snippet/heatmap/axis/numeric/numeric.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/axis/numeric/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Numeric.cs" %}
{% include code-snippet/heatmap/axis/numeric/numeric.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Date-time axis

{% if page.publishingplatform == "aspnet-core" %}

Date-time axis type is used to represent the date-time values in axis labels with a specific format. In date-time axis, you can define the start and end date/time using the [minimum](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapAxis.html#Syncfusion_EJ2_HeatMap_HeatMapAxis_Minimum) and [maximum](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapAxis.html#Syncfusion_EJ2_HeatMap_HeatMapAxis_Maximum) properties.


{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/axis/dateTime/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="DateTime.cs" %}
{% include code-snippet/heatmap/axis/dateTime/dateTime.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

Date-time axis type is used to represent the date-time values in axis labels with a specific format. In date-time axis, you can define the start and end date/time using the [Minimum](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapAxis.html#Syncfusion_EJ2_HeatMap_HeatMapAxis_Minimum) and [Maximum](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapAxis.html#Syncfusion_EJ2_HeatMap_HeatMapAxis_Maximum) properties.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/axis/dateTime/razor %}
{% endhighlight %}
{% highlight c# tabtitle="DateTime.cs" %}
{% include code-snippet/heatmap/axis/dateTime/dateTime.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


## Inversed axis

{% if page.publishingplatform == "aspnet-core" %}

HeatMap supports inversing the axis origin for both axes, where the axis labels are placed in an inversed manner. You can enable axis inversing by enabling the [isInversed](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapAxis.html#Syncfusion_EJ2_HeatMap_HeatMapAxis_IsInversed) property.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/axis/inversed/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Inversed.cs" %}
{% include code-snippet/heatmap/axis/inversed/inversed.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

HeatMap supports inversing the axis origin for both axes, where the axis labels are placed in an inversed manner. You can enable axis inversing by enabling the [IsInversed](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapAxis.html#Syncfusion_EJ2_HeatMap_HeatMapAxis_IsInversed) property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/axis/inversed/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Inversed.cs" %}
{% include code-snippet/heatmap/axis/inversed/inversed.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Opposed axis

{% if page.publishingplatform == "aspnet-core" %}

In HeatMap, you can place the axis label in an opposite position of its default axis label position by using the [opposedPosition](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapAxis.html#Syncfusion_EJ2_HeatMap_HeatMapAxis_OpposedPosition) property.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/axis/opposed/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Opposed.cs" %}
{% include code-snippet/heatmap/axis/opposed/opposed.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

In HeatMap, you can place the axis label in an opposite position of its default axis label position by using the [OpposedPosition](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapAxis.html#Syncfusion_EJ2_HeatMap_HeatMapAxis_OpposedPosition) property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/axis/opposed/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Opposed.cs" %}
{% include code-snippet/heatmap/axis/opposed/opposed.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Axis labels customization

### Customizing the text style

{% if page.publishingplatform == "aspnet-core" %}

The text style of the axis labels can be customized using the following options available in the [textStyle](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapAxis.html#Syncfusion_EJ2_HeatMap_HeatMapAxis_TextStyle) property.

* [color](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapFont.html#Syncfusion_EJ2_HeatMap_HeatMapFont_Color) - It is used to change the text color of the axis labels.
* [fontFamily](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapFont.html#Syncfusion_EJ2_HeatMap_HeatMapFont_FontFamily) - It is used to change the font family of the axis labels.
* [fontStyle](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapFont.html#Syncfusion_EJ2_HeatMap_HeatMapFont_FontStyle) - It is used to change the font style of the axis labels.
* [fontWeight](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapFont.html#Syncfusion_EJ2_HeatMap_HeatMapFont_FontWeight) - It is used to change the font weight of the axis labels.
* [size](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapFont.html#Syncfusion_EJ2_HeatMap_HeatMapFont_Size) - It is used to change the font size of the axis labels.
* [textAlignment](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapFont.html#Syncfusion_EJ2_HeatMap_HeatMapFont_TextAlignment) - It is used to position and align the axis labels. This property allows you to specify values such as **Near**, **Center**, and **Far**.
* [textOverflow](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapFont.html#Syncfusion_EJ2_HeatMap_HeatMapFont_TextOverflow) - When the axis label exceeds the intended space, this property is used to trim or wrap it. This property takes values such as **None**, **Trim**, and **Wrap**.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/axis/textstyle/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="TextStyle.cs" %}
{% include code-snippet/heatmap/axis/textstyle/textstyle.cs %}
{% endhighlight %}
{% endtabs %}

![Customizing the text style of axis labels in ASP.NET Core HeatMap chart](./images/heatmap-chart-axis-labels-text-style.png)

{% elsif page.publishingplatform == "aspnet-mvc" %}

The text style of the axis labels can be customized using the following options available in the [TextStyle](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapAxis.html#Syncfusion_EJ2_HeatMap_HeatMapAxis_TextStyle) property.

* [Color](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapFont.html#Syncfusion_EJ2_HeatMap_HeatMapFont_Color) - It is used to change the text color of the axis labels.
* [FontFamily](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapFont.html#Syncfusion_EJ2_HeatMap_HeatMapFont_FontFamily) - It is used to change the font family of the axis labels.
* [FontStyle](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapFont.html#Syncfusion_EJ2_HeatMap_HeatMapFont_FontStyle) - It is used to change the font style of the axis labels.
* [FontWeight](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapFont.html#Syncfusion_EJ2_HeatMap_HeatMapFont_FontWeight) - It is used to change the font weight of the axis labels.
* [Size](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapFont.html#Syncfusion_EJ2_HeatMap_HeatMapFont_Size) - It is used to change the font size of the axis labels.
* [TextAlignment](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapFont.html#Syncfusion_EJ2_HeatMap_HeatMapFont_TextAlignment) - It is used to position and align the axis labels. This property allows you to specify values such as **Near**, **Center**, and **Far**.
* [TextOverflow](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapFont.html#Syncfusion_EJ2_HeatMap_HeatMapFont_TextOverflow) - When the axis label exceeds the intended space, this property is used to trim or wrap it. This property takes values such as **None**, **Trim**, and **Wrap**.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/axis/textstyle/razor %}
{% endhighlight %}
{% highlight c# tabtitle="TextStyle.cs" %}
{% include code-snippet/heatmap/axis/textstyle/textstyle.cs %}
{% endhighlight %}
{% endtabs %}

![Customizing the text style of axis labels in ASP.NET MVC HeatMap chart](./images/heatmap-chart-axis-labels-text-style.png)

{% endif %}

### Customizing labels when intersecting with other labels

{% if page.publishingplatform == "aspnet-core" %}

When the axis labels intersect, [labelIntersectAction](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapAxis.html#Syncfusion_EJ2_HeatMap_HeatMapAxis_LabelIntersectAction) property is used to handle the intersection. The `labelIntersectAction` property can take the following values.

* **None** - It specifies that no action is taken when the axis labels intersect.
* **Trim** - It specifies to trim the axis labels when they intersect.
* **Rotate45** - When the axis labels intersect, they are rotated to 45 degrees.
* **MultipleRows** - It specifies to show all the axis labels as multiple rows when they intersect.

The below example demonstrates to trim the axis labels by using the `labelIntersectAction` property.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/axis/label-intersection/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="LabelIntersectAction.cs" %}
{% include code-snippet/heatmap/axis/label-intersection/label-intersection.cs %}
{% endhighlight %}
{% endtabs %}

![Customizing axis labels when intersecting with other labels in ASP.NET Core HeatMap chart](./images/heatmap-chart-label-intersect-action.png)

{% elsif page.publishingplatform == "aspnet-mvc" %}

When the axis labels intersect, [LabelIntersectAction](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapAxis.html#Syncfusion_EJ2_HeatMap_HeatMapAxis_LabelIntersectAction) property is used to handle the intersection. The `LabelIntersectAction` property can take the following values.

* **None** - It specifies that no action is taken when the axis labels intersect.
* **Trim** - It specifies to trim the axis labels when they intersect.
* **Rotate45** - When the axis labels intersect, they are rotated to 45 degrees.
* **MultipleRows** - It specifies to show all the axis labels as multiple rows when they intersect.

The below example demonstrates to trim the axis labels by using the `LabelIntersectAction` property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/axis/label-intersection/razor %}
{% endhighlight %}
{% highlight c# tabtitle="LabelIntersectAction.cs" %}
{% include code-snippet/heatmap/axis/label-intersection/label-intersection.cs %}
{% endhighlight %}
{% endtabs %}

![Customizing axis labels when intersecting with other labels in ASP.NET MVC HeatMap chart](./images/heatmap-chart-label-intersect-action.png)

{% endif %}

### Rotating labels

{% if page.publishingplatform == "aspnet-core" %}

The axis labels can be rotated to the desired angles by using the [labelRotation](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapAxis.html#Syncfusion_EJ2_HeatMap_HeatMapAxis_LabelRotation) property.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/axis/label-rotation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="LabelRotation.cs" %}
{% include code-snippet/heatmap/axis/label-rotation/label-rotation.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core HeatMap chart with rotated axis labels](./images/heatmap-chart-rotating-labels.png)

{% elsif page.publishingplatform == "aspnet-mvc" %}

The axis labels can be rotated to the desired angles by using the [LabelRotation](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapAxis.html#Syncfusion_EJ2_HeatMap_HeatMapAxis_LabelRotation) property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/axis/label-rotation/razor %}
{% endhighlight %}
{% highlight c# tabtitle="LabelRotation.cs" %}
{% include code-snippet/heatmap/axis/label-rotation/label-rotation.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC HeatMap chart with rotated axis labels](./images/heatmap-chart-rotating-labels.png)

{% endif %}

### Label formatting

{% if page.publishingplatform == "aspnet-core" %}

HeatMap supports formatting the axis labels by using the [labelFormat](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapAxis.html#Syncfusion_EJ2_HeatMap_HeatMapAxis_LabelFormat) property. Using this property, you can customize the axis label by global string format ('P', 'C', etc) or customized format like '{value}°C'.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/axis/label-format/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Label-format.cs" %}
{% include code-snippet/heatmap/axis/label-format/label-format.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

HeatMap supports formatting the axis labels by using the [LabelFormat](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapAxis.html#Syncfusion_EJ2_HeatMap_HeatMapAxis_LabelFormat) property. Using this property, you can customize the axis label by global string format ('P', 'C', etc) or customized format like '{value}°C'.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/axis/label-format/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Label-format.cs" %}
{% include code-snippet/heatmap/axis/label-format/label-format.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Axis intervals

{% if page.publishingplatform == "aspnet-core" %}

In HeatMap, you can define an interval between the axis labels using the [interval](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapAxis.html#Syncfusion_EJ2_HeatMap_HeatMapAxis_Interval) property. In date-time axis, you can change the interval mode by using the [intervalType](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapAxis.html#Syncfusion_EJ2_HeatMap_HeatMapAxis_IntervalType) property. The date-time axis supports the following interval types:

* Years
* Months
* Days
* Hours
* Minutes

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/axis/interval/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Interval.cs" %}
{% include code-snippet/heatmap/axis/interval/interval.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

In HeatMap, you can define an interval between the axis labels using the [Interval](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapAxis.html#Syncfusion_EJ2_HeatMap_HeatMapAxis_Interval) property. In date-time axis, you can change the interval mode by using the [IntervalType](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapAxis.html#Syncfusion_EJ2_HeatMap_HeatMapAxis_IntervalType) property. The date-time axis supports the following interval types:

* Years
* Months
* Days
* Hours
* Minutes

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/axis/interval/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Interval.cs" %}
{% include code-snippet/heatmap/axis/interval/interval.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


## Axis label increment

{% if page.publishingplatform == "aspnet-core" %}

Axis label increment in the HeatMap is used to display the axis labels with regular interval values in numeric and date-time axes. The labels will be displayed with tick gaps when you set the label interval. But, to achieve the same behavior without tick gaps, use the label increment. You can set the axis label increment using the [increment](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapAxis.html#Syncfusion_EJ2_HeatMap_HeatMapAxis_Increment) property and the default value of this property is **1**.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/axis/increment/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Increment.cs" %}
{% include code-snippet/heatmap/axis/increment/increment.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

Axis label increment in the HeatMap is used to display the axis labels with regular interval values in numeric and date-time axes. The labels will be displayed with tick gaps when you set the label interval. But, to achieve the same behavior without tick gaps, use the label increment. You can set the axis label increment using the [Increment](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapAxis.html#Syncfusion_EJ2_HeatMap_HeatMapAxis_Increment) property and the default value of this property is **1**.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/axis/increment/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Increment.cs" %}
{% include code-snippet/heatmap/axis/increment/increment.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


## Limiting labels in date-time axis

{% if page.publishingplatform == "aspnet-core" %}

You can display the axis labels at specific time intervals along with the date-time axis using the [showLabelOn](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapAxis.html#Syncfusion_EJ2_HeatMap_HeatMapAxis_ShowLabelOn) property. This property supports the following types:

* **None**: Displays the axis labels based on the `intervalType` and `interval` property of the axis. This type is default value of the `showLabelOn` property.
* **Years**: Displays the axis labels on every year between given date-time range.
* **Months**: Displays the axis labels on every month between given date-time range.
* **Days**: Displays the axis labels on every day between given date-time range.
* **Minutes**: Displays the axis labels on every minute between given date-time range.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/axis/show-label/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Show-label.cs" %}
{% include code-snippet/heatmap/axis/show-label/show-label.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

You can display the axis labels at specific time intervals along with the date-time axis using the [ShowLabelOn](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapAxis.html#Syncfusion_EJ2_HeatMap_HeatMapAxis_ShowLabelOn) property. This property supports the following types:

* **None**: Displays the axis labels based on the `IntervalType` and `Interval` property of the axis. This type is default value of the `ShowLabelOn` property.
* **Years**: Displays the axis labels on every year between given date-time range.
* **Months**: Displays the axis labels on every month between given date-time range.
* **Days**: Displays the axis labels on every day between given date-time range.
* **Minutes**: Displays the axis labels on every minute between given date-time range.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/axis/show-label/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Show-label.cs" %}
{% include code-snippet/heatmap/axis/show-label/show-label.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


## Multilevel Labels

{% if page.publishingplatform == "aspnet-core" %}

Multilevel labels are used to classify a group of axis labels as a single category, which is then displayed with a label. By using [multiLevelLabels](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapMultiLevelLabel.html#properties), you can add multiple levels on top of the axis labels.

To divide and group the axis labels, you can use `multiLevelLabels` property. The starting and ending indexes of the axis labels can be set using the `start` and `end` properties in the [categories](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapMultiLevelLabel.html#Syncfusion_EJ2_HeatMap_HeatMapMultiLevelLabel_Categories). The `text` property can be used to specify a name for the grouped axis labels.

The multilevel labels can be customized by using the following properties.
* [overflow](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapMultiLevelLabel.html#Syncfusion_EJ2_HeatMap_HeatMapMultiLevelLabel_Overflow) - It is used to trim or wrap the multilevel labels when the label overflows the intended space. NOTE: This property is only for x-axis.
* [alignment](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapMultiLevelLabel.html#Syncfusion_EJ2_HeatMap_HeatMapMultiLevelLabel_Alignment) - It is used to place and align the multilevel labels.
* `maximumTextWidth` - It is used to set the maximum width of the text. When the text length exceeds the maximum text width, the overflow action will be performed.
* [textStyle](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapMultiLevelLabel.html#Syncfusion_EJ2_HeatMap_HeatMapMultiLevelLabel_TextStyle) - It is used to customize the font style of the multilevel labels.
* [border](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapMultiLevelLabel.html#Syncfusion_EJ2_HeatMap_HeatMapMultiLevelLabel_Border) - It is used to customize the border of the multilevel labels displayed in the x-axis and y-axis.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/axis/multi-level-labels/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Multi-level-labels.cs" %}
{% include code-snippet/heatmap/axis/multi-level-labels/multi-level-labels.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core HeatMap chart with multilevel labels](./images/heatmap-chart-multi-level-labels.png)

{% elsif page.publishingplatform == "aspnet-mvc" %}

Multilevel labels are used to classify a group of axis labels as a single category, which is then displayed with a label. By using [MultiLevelLabels](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapMultiLevelLabel.html#properties) tag, you can add multiple levels on top of the axis labels.

To divide and group the axis labels, you can use `MultiLevelLabels` property. The starting and ending indexes of the axis labels can be set using the `Start` and `End` properties in the [Categories](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapMultiLevelLabel.html#Syncfusion_EJ2_HeatMap_HeatMapMultiLevelLabel_Categories). The `Text` property can be used to specify a name for the grouped axis labels.

The multilevel labels can be customized by using the following properties and tags.
* [Overflow](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapMultiLevelLabel.html#Syncfusion_EJ2_HeatMap_HeatMapMultiLevelLabel_Overflow) - It is used to trim or wrap the multilevel labels when the label overflows the intended space. NOTE: This property is only for x-axis.
* [Alignment](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapMultiLevelLabel.html#Syncfusion_EJ2_HeatMap_HeatMapMultiLevelLabel_Alignment) - It is used to place and align the multilevel labels.
* `MaximumTextWidth` - It is used to set the maximum width of the text. When the text length exceeds the maximum text width, the overflow action will be performed.
* [TextStyle](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapMultiLevelLabel.html#Syncfusion_EJ2_HeatMap_HeatMapMultiLevelLabel_TextStyle) - It is used to customize the font style of the multilevel labels.
* [Border](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapMultiLevelLabel.html#Syncfusion_EJ2_HeatMap_HeatMapMultiLevelLabel_Border) - It is used to customize the border of the multilevel labels displayed in the x-axis and y-axis.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/axis/multi-level-labels/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Multi-level-labels.cs" %}
{% include code-snippet/heatmap/axis/multi-level-labels/multi-level-labels.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC HeatMap chart with multilevel labels](./images/heatmap-chart-multi-level-labels.png)

{% endif %}
