---
layout: post
title: Axis in ##Platform_Name## Heatmap Component
description: Learn here all about Axis in Syncfusion ##Platform_Name## Heatmap component and more.
platform: ej2-asp-core-mvc
control: Axis
publishingplatform: ##Platform_Name##
documentation: ug
---


# Axis

Heat map consists of two axes namely, X-axis and Y-axis that displays the row headers and column headers to plot the data points respectively. You can define the type, format, and other customizing options for both axes in the heat map.

## Types

There are three different axis types available in the heat map, which defines the data type of the axis labels. You can define the axis type by using the [`valueType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapAxis~ValueType.html) property in the heat map.

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

Date-time axis type is used to represent the date-time values in axis labels with a specific format. In date-time axis, you can define the start and end date/time using the [`minimum`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapAxis~Minimum.html) and [`maximum`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapAxis~Maximum.html) properties.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/axis/dateTime/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="DateTime.cs" %}
{% include code-snippet/heatmap/axis/dateTime/dateTime.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

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

Heat map supports inversing the axis origin for both axes, where the axis labels are placed in an inversed manner. You can enable axis inversing by enabling the [`isInversed`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapAxis~IsInversed.html) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/axis/inversed/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Inversed.cs" %}
{% include code-snippet/heatmap/axis/inversed/inversed.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

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

In heat map, you can place the axis label in an opposite position of its default axis label position by using the [`opposedPosition`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapAxis~OpposedPosition.html) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/axis/opposed/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Opposed.cs" %}
{% include code-snippet/heatmap/axis/opposed/opposed.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/axis/opposed/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Opposed.cs" %}
{% include code-snippet/heatmap/axis/opposed/opposed.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Label formatting

Heat map supports formatting the axis labels by using the [`labelFormat`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapAxis~LabelFormat.html) property. Using this property, you can customize the axis label by global string format ('P', 'C', etc) or customized format like '{value}°C'.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/axis/label-format/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Label-format.cs" %}
{% include code-snippet/heatmap/axis/label-format/label-format.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

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

In heat map, you can define an interval between the axis labels using the [`interval`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapAxis~Interval.html) property. In date-time axis, you can change the interval mode by using the [`intervalType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapAxis~IntervalType.html) property. The date-time axis supports the following interval types:

* Years
* Months
* Days
* Hours
* Minutes

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/axis/interval/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Interval.cs" %}
{% include code-snippet/heatmap/axis/interval/interval.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

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

Axis label increment in the heat map is used to display the axis labels with regular interval values in numeric and date-time axes. The labels will be displayed with tick gaps when you set the label interval. But, to achieve the same behavior without tick gaps, use the label increment. You can set the axis label increment using the [`increment`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapAxis~Increment.html) property and the default value of this property is 1.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/axis/increment/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Increment.cs" %}
{% include code-snippet/heatmap/axis/increment/increment.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

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

You can display the axis labels at specific time intervals along with the date-time axis using the [`showLabelOn`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapAxis~ShowLabelOn.html) property. This property supports the following types:

* None: Displays the axis labels based on the `intervalType` and `interval` property of the axis. This type is default value of the `showLabelOn` property.
* Years: Displays the axis labels on every year between given date-time range.
* Months: Displays the axis labels on every month between given date-time range.
* Days: Displays the axis labels on every day between given date-time range.
* Minutes: Displays the axis labels on every minute between given date-time range.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/axis/show-label/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Show-label.cs" %}
{% include code-snippet/heatmap/axis/show-label/show-label.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/axis/show-label/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Show-label.cs" %}
{% include code-snippet/heatmap/axis/show-label/show-label.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Multi Level Labels

You can add many levels of labels using the [`multiLevelLabels`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapAxis~MultiLevelLabels.html) property. This property can be configured using the following properties:

* Categories
* Overflow
* Alignment
* Text style
* Border

### Categories

Using this property, you can configure the  `start`, `end`, `text`, `maximumTextWidth` of the multilevel labels.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/axis/multi-level-category/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Multi-level-category.cs" %}
{% include code-snippet/heatmap/axis/multi-level-category/multi-level-category.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/axis/multi-level-category/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Multi-level-category.cs" %}
{% include code-snippet/heatmap/axis/multi-level-category/multi-level-category.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Overflow

Using this property, you can trim and wrap the multilevel labels.

> This support works in x-axis only.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/axis/multi-level-overflow/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Multi-level-overflow.cs" %}
{% include code-snippet/heatmap/axis/multi-level-overflow/multi-level-overflow.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/axis/multi-level-overflow/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Multi-level-overflow.cs" %}
{% include code-snippet/heatmap/axis/multi-level-overflow/multi-level-overflow.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Alignment

This property provides an option to position the multilevel labels at far, center, and near.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/axis/multi-level-alignment/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Multi-level-alignment.cs" %}
{% include code-snippet/heatmap/axis/multi-level-alignment/multi-level-alignment.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/axis/multi-level-alignment/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Multi-level-alignment.cs" %}
{% include code-snippet/heatmap/axis/multi-level-alignment/multi-level-alignment.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Text Customization

The [`textStyle`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapMultiLevelLabel~TextStyle.html) property of multilevel labels provides options to customize the size, color, fontFamily, fontWeight, fontStyle, opacity, textAlignment and textOverflow.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/axis/multi-level-textstyle/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Multi-level-textstyle.cs" %}
{% include code-snippet/heatmap/axis/multi-level-textstyle/multi-level-textstyle.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/axis/multi-level-textstyle/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Multi-level-textstyle.cs" %}
{% include code-snippet/heatmap/axis/multi-level-textstyle/multi-level-textstyle.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Border Customization

Using the [`border`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapMultiLevelLabel~Border.html) property, you can customize the width, color, and type. The types of border are `Rectangle`, `WithoutTopBorder`, `WithoutBottomBorder`, `WithoutTopAndBottomBorder`, `Brace`, `WithoutBorder`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/axis/multi-level-border/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Multi-level-border.cs" %}
{% include code-snippet/heatmap/axis/multi-level-border/multi-level-border.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/axis/multi-level-border/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Multi-level-border.cs" %}
{% include code-snippet/heatmap/axis/multi-level-border/multi-level-border.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

