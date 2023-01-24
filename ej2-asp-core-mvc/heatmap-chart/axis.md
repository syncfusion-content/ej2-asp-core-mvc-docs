---
layout: post
title: Axis in Syncfusion ##Platform_Name## Heatmap Chart Component
description: Learn here all about Axis in Syncfusion ##Platform_Name## Heatmap Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Axis
publishingplatform: ##Platform_Name##
documentation: ug
---


# Axis in ##Platform_Name## HeatMap Chart Component

Heatmap consists of two axes namely, X-axis and Y-axis that displays the row headers and column headers to plot the data points respectively. You can customize both the axes by specifying the properties like type, format, and other customising options in the axis of the heatmap.

## Axis types

There are three different axis types available in the heatmap, which defines the data type of the axis labels. You can define the axis type by using the [valueType](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapAxis~ValueType.html) property in the heatmap.

Three different types of axis in the heatmap as follows.

* Category axis
* Numeric axis
* Date Time axis

### Category axis

{% if page.publishingplatform == "aspnet-core" %}

Category axis type is used to represent the string values in the axis labels. You can specify the [valueType](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapAxis.html#Syncfusion_EJ2_HeatMap_HeatMapAxis_ValueType) property for the axis is **Category**.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/axis/category/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Category.cs" %}
{% include code-snippet/heatmap/axis/category/category.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

Category axis type is used to represent the string values in the axis labels. You can specify the [ValueType](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapAxis.html#Syncfusion_EJ2_HeatMap_HeatMapAxis_ValueType) property for the axis is **Category**.

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

{% if page.publishingplatform == "aspnet-core" %}

Numeric axis type is used to represent the numeric values in the axis labels. You can specify the [valueType](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapAxis~ValueType.html)property for the axis is **Numeric**.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/axis/numeric/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Numeric.cs" %}
{% include code-snippet/heatmap/axis/numeric/numeric.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

Numeric axis type is used to represent the numeric values in the axis labels. You can specify the [ValueType](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapAxis.html#Syncfusion_EJ2_HeatMap_HeatMapAxis_ValueType)property for the axis is **Numeric**.

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

Date-time axis type is used to represent the date-time values in axis labels with a specific format. In date-time axis, you can define the start and end date/time using the [minimum](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapAxis~Minimum.html) and [maximum](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapAxis~Maximum.html) properties. You can specify the [valueType](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapAxis~ValueType.html) property for the axis is **DateTime**.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/axis/dateTime/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="DateTime.cs" %}
{% include code-snippet/heatmap/axis/dateTime/dateTime.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

Date-time axis type is used to represent the date-time values in axis labels with a specific format. In date-time axis, you can define the start and end date/time using the [Minimum](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapAxis.html#Syncfusion_EJ2_HeatMap_HeatMapAxis_Minimuml) and [Maximum](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapAxis.html#Syncfusion_EJ2_HeatMap_HeatMapAxis_Maximum) properties. You can specify the [ValueType](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapAxis.html#Syncfusion_EJ2_HeatMap_HeatMapAxis_ValueType) property for the axis is **DateTime**.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/axis/dateTime/razor %}
{% endhighlight %}
{% highlight c# tabtitle="DateTime.cs" %}
{% include code-snippet/heatmap/axis/dateTime/dateTime.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Axis customization

### Inversed axis

{% if page.publishingplatform == "aspnet-core" %}


Heatmap supports inversing the axis origin for both axes, where the axis labels are placed in an inversed manner. You can enable axis inversing by enabling the [isInversed](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapAxis~IsInversed.html) property.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/axis/inversed/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Inversed.cs" %}
{% include code-snippet/heatmap/axis/inversed/inversed.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

Heatmap supports inversing the axis origin for both axes, where the axis labels are placed in an inversed manner. You can enable axis inversing by enabling the [IsInversed](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapAxis.html#Syncfusion_EJ2_HeatMap_HeatMapAxis_IsInversed) property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/axis/inversed/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Inversed.cs" %}
{% include code-snippet/heatmap/axis/inversed/inversed.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Opposed axis

{% if page.publishingplatform == "aspnet-core" %}

In heatmap, you can place the axis label in an opposite position of its default axis label position by using the [opposedPosition](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapAxis~OpposedPosition.html) property.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/axis/opposed/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Opposed.cs" %}
{% include code-snippet/heatmap/axis/opposed/opposed.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

In heatmap, you can place the axis label in an opposite position of its default axis label position by using the [OpposedPosition](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapAxis.html#Syncfusion_EJ2_HeatMap_HeatMapAxis_OpposedPosition) property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/axis/opposed/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Opposed.cs" %}
{% include code-snippet/heatmap/axis/opposed/opposed.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Axis label customization

### Label formatting

{% if page.publishingplatform == "aspnet-core" %}

Heatmap supports formatting the axis labels by using the [labelFormat](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapAxis~LabelFormat.html) property. Using this property, you can customize the axis label by global string format ('P', 'C', etc) or customized format like '{value}°C'.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/axis/label-format/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Label-format.cs" %}
{% include code-snippet/heatmap/axis/label-format/label-format.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

Heatmap supports formatting the axis labels by using the [LabelFormat](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapAxis.html#Syncfusion_EJ2_HeatMap_HeatMapAxis_LabelFormat) property. Using this property, you can customize the axis label by global string format ('P', 'C', etc) or customized format like '{value}°C'.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/axis/label-format/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Label-format.cs" %}
{% include code-snippet/heatmap/axis/label-format/label-format.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Axis intervals

{% if page.publishingplatform == "aspnet-core" %}

In heatmap, you can define an interval between the axis labels using the [interval](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapAxis~Interval.html) property. In date-time axis, you can change the interval mode by using the [intervalType](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapAxis~IntervalType.html) property. The date-time axis supports the following interval types:

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

In heatmap, you can define an interval between the axis labels using the [Interval](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapAxis.html#Syncfusion_EJ2_HeatMap_HeatMapAxis_Interval) property. In date-time axis, you can change the interval mode by using the [IntervalType](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapAxis.html#Syncfusion_EJ2_HeatMap_HeatMapAxis_IntervalType) property. The date-time axis supports the following interval types:

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



### Axis label increment

{% if page.publishingplatform == "aspnet-core" %}

Axis label increment in the heatmap is used to display the axis labels with regular interval values in numeric and date-time axes. The labels will be displayed with tick gaps when you set the label interval. But, to achieve the same behavior without tick gaps, use the label increment. You can set the axis label increment using the [increment](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapAxis~Increment.html) property and the default value of this property is **1**.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/axis/increment/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Increment.cs" %}
{% include code-snippet/heatmap/axis/increment/increment.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

Axis label increment in the heatmap is used to display the axis labels with regular interval values in numeric and date-time axes. The labels will be displayed with tick gaps when you set the label interval. But, to achieve the same behavior without tick gaps, use the label increment. You can set the axis label increment using the [Increment](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapAxis.html#Syncfusion_EJ2_HeatMap_HeatMapAxis_Increment) property and the default value of this property is **1**.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/axis/increment/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Increment.cs" %}
{% include code-snippet/heatmap/axis/increment/increment.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Limiting labels in date-time axis

{% if page.publishingplatform == "aspnet-core" %}

You can display the axis labels at specific time intervals along with the date-time axis using the [showLabelOn](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapAxis~ShowLabelOn.html) property. This property supports the following types:

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

* **None**: Displays the axis labels based on the `intervalType` and `interval` property of the axis. This type is default value of the `showLabelOn` property.
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


### Multi Level Labels

{% if page.publishingplatform == "aspnet-core" %}

You can add many levels of labels using the [multiLevelLabels](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapAxis~MultiLevelLabels.html) property. This property can be configured using the following properties:

* Categories
* Overflow
* Alignment
* Text style
* Border

{% elsif page.publishingplatform == "aspnet-mvc" %}

You can add many levels of labels using the [MultiLevelLabels](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapAxis.html#Syncfusion_EJ2_HeatMap_HeatMapAxis_MultiLevelLabels) property. This property can be configured using the following properties:

* Categories
* Overflow
* Alignment
* Text style
* Border

{% endif %}

#### Categories

{% if page.publishingplatform == "aspnet-core" %}

Using the [category](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapMultiLevelLabel.html#Syncfusion_EJ2_HeatMap_HeatMapMultiLevelLabel_Categories) property, you can configure `start`, `end`, `text` and `maximumTextWidth` in the [multiLevelLabels](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapAxis~MultiLevelLabels.html).

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/axis/multi-level-category/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Multi-level-category.cs" %}
{% include code-snippet/heatmap/axis/multi-level-category/multi-level-category.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

Using the [category](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapMultiLevelLabel.html#Syncfusion_EJ2_HeatMap_HeatMapMultiLevelLabel_Categories) property, you can configure `start`, `end`, `text` and `maximumTextWidth` in the [MultiLevelLabels](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapAxis.html#Syncfusion_EJ2_HeatMap_HeatMapAxis_MultiLevelLabels).

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/axis/multi-level-category/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Multi-level-category.cs" %}
{% include code-snippet/heatmap/axis/multi-level-category/multi-level-category.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


#### Overflow

{% if page.publishingplatform == "aspnet-core" %}

Using the [overflow](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapMultiLevelLabel.html#Syncfusion_EJ2_HeatMap_HeatMapMultiLevelLabel_Overflow) property, you can trim and wrap the multilevel labels.

> This support works in x-axis only.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/axis/multi-level-overflow/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Multi-level-overflow.cs" %}
{% include code-snippet/heatmap/axis/multi-level-overflow/multi-level-overflow.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}


Using the [Overflow](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapMultiLevelLabel.html#Syncfusion_EJ2_HeatMap_HeatMapMultiLevelLabel_Overflow) property, you can trim and wrap the multilevel labels.

> This support works in x-axis only.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/axis/multi-level-overflow/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Multi-level-overflow.cs" %}
{% include code-snippet/heatmap/axis/multi-level-overflow/multi-level-overflow.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


#### Alignment

{% if page.publishingplatform == "aspnet-core" %}

The [alignment](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapMultiLevelLabel.html#Syncfusion_EJ2_HeatMap_HeatMapMultiLevelLabel_Alignment) property provides an option to position the multilevel labels at **Far**, **Center**, and **Near**.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/axis/multi-level-alignment/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Multi-level-alignment.cs" %}
{% include code-snippet/heatmap/axis/multi-level-alignment/multi-level-alignment.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

The [Alignment](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapMultiLevelLabel.html#Syncfusion_EJ2_HeatMap_HeatMapMultiLevelLabel_Alignment) property provides an option to position the multilevel labels at **Far**, **Center**, and **Near**.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/axis/multi-level-alignment/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Multi-level-alignment.cs" %}
{% include code-snippet/heatmap/axis/multi-level-alignment/multi-level-alignment.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


#### Text Customization

{% if page.publishingplatform == "aspnet-core" %}

The [textStyle](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapMultiLevelLabel.html#Syncfusion_EJ2_HeatMap_HeatMapMultiLevelLabel_TextStyle) property in the multi level labels provides the following options to customize the labels on the axis of the heatmap.

* `color` - To customize the color of the labels on the axis of the heatmap.
* `fontFamily` - To customize the font family of the labels on the axis of the heatmap.
* `fontWeight` - To customize the font weight of the labels on the axis of the heatmap.
* `fontStyle` - To customize the font style of the labels on the axis of the heatmap.
* `size` - To customize the size of the labels on the axis of the heatmap.
* `textAlignment` - To customize the alignment for the labels on the axis of the    
  heatmap. The possible values can be **Center**, **Near** and **Far**.
* `textOverflow` -  When the text size exceeds the maximum width of the labels, it is  
   used to wrap or trim the labels.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/axis/multi-level-textstyle/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Multi-level-textstyle.cs" %}
{% include code-snippet/heatmap/axis/multi-level-textstyle/multi-level-textstyle.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

The [TextStyle](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapMultiLevelLabel.html#Syncfusion_EJ2_HeatMap_HeatMapMultiLevelLabel_TextStyle) property in the multi level labels provides the following options to customize the labels on the axis of the heatmap.

* `Color` - To customize the color of the labels on the axis of the heatmap.
* `FontFamily` - To customize the font family of the labels on the axis of the heatmap.
* `FontWeight` - To customize the font weight of the labels on the axis of the heatmap.
* `FontStyle` - To customize the font style of the labels on the axis of the heatmap.
* `Size` - To customize the size of the labels on the axis of the heatmap.
* `TextAlignment` - To customize the alignment for the labels on the axis of the    
  heatmap. The possible values can be **Center**, **Near** and **Far**.
* `TextOverflow` -  When the text size exceeds the maximum width of the labels, it is  
   used to wrap or trim the labels.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/axis/multi-level-textstyle/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Multi-level-textstyle.cs" %}
{% include code-snippet/heatmap/axis/multi-level-textstyle/multi-level-textstyle.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


#### Border Customization

{% if page.publishingplatform == "aspnet-core" %}

Using the [border](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapMultiLevelLabel.html#Syncfusion_EJ2_HeatMap_HeatMapMultiLevelLabel_Border) 
property, you can customize the border for the labels by changing the `width`, `color`, and `type` properties in the axis of the [multiLevelLabels](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapAxis~MultiLevelLabels.html) property. The different types of border support for labels are **Rectangle**, **WithoutTopBorder**, **WithoutBottomBorder**, **WithoutTopAndBottomBorder**, **Brace**, and **WithoutBorder**.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/axis/multi-level-border/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Multi-level-border.cs" %}
{% include code-snippet/heatmap/axis/multi-level-border/multi-level-border.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

Using the [Border](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapMultiLevelLabel.html#Syncfusion_EJ2_HeatMap_HeatMapMultiLevelLabel_Border) 
property, you can customize the border for the labels by changing the `width`, `color`, and `type` properties in the axis of the [MultiLevelLabels](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapAxis.html#Syncfusion_EJ2_HeatMap_HeatMapAxis_MultiLevelLabels) property. The different types of border support for labels are **Rectangle**, **WithoutTopBorder**, **WithoutBottomBorder**, **WithoutTopAndBottomBorder**, **Brace**, and **WithoutBorder**.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/axis/multi-level-border/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Multi-level-border.cs" %}
{% include code-snippet/heatmap/axis/multi-level-border/multi-level-border.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

