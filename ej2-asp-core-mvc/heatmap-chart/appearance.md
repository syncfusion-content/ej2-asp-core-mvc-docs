---
layout: post
title: Appearance in ##Platform_Name## Heatmap Chart Component
description: Learn here all about Appearance in Syncfusion ##Platform_Name## Heatmap Chart component and more.
platform: ej2-asp-core-mvc
control: Appearance
publishingplatform: ##Platform_Name##
documentation: ug
---


# Appearance

## Cell/customizations

You can customize the cell by using the [`cellSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMap~CellSettings.html) property.

## Border

Change the width, color, and radius of the heat map cells by using the [`border`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapCellSettings~Border.html) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/appearance/border/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Border.cs" %}
{% include code-snippet/heatmap/appearance/border/border.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/appearance/border/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Border.cs" %}
{% include code-snippet/heatmap/appearance/border/border.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Cell highlighting

Enable or disable the cell highlighting while hover over the heat map cells by using the  [`enableCellHighlighting`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapCellSettings~EnableCellHighlighting.html) property.

> The cell highlighting only works in a SVG rendering mode.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/appearance/cell-highlight/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Cell-highlight.cs" %}
{% include code-snippet/heatmap/appearance/cell-highlight/cell-highlight.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/appearance/cell-highlight/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Cell-highlight.cs" %}
{% include code-snippet/heatmap/appearance/cell-highlight/cell-highlight.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Color gradient mode

You can set the minimum and maximum value colors based on row and column using the `ColorGradientMode` property.
The types of ColorGradientMode,

* Table: The minimum and maximum value colors calculated for overall data.
* Row: The minimum and maximum value colors calculated for each row of data.
* Column: The minimum and maximum value colors calculated for each column of data.

> The default value of `ColorGradientMode` is Table.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/appearance/colormode/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Colormode.cs" %}
{% include code-snippet/heatmap/appearance/colormode/colormode.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/appearance/colormode/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Colormode.cs" %}
{% include code-snippet/heatmap/appearance/colormode/colormode.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Margin

Set the margin for the heat map from its container by using the  [`margin`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMap~Margin.html) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/appearance/margin/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Margin.cs" %}
{% include code-snippet/heatmap/appearance/margin/margin.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/appearance/margin/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Margin.cs" %}
{% include code-snippet/heatmap/appearance/margin/margin.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Title

The title is used to provide a quick information about the data plotted in heat map. The [`text`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapTitle~Text.html) property is used to set the title for heat map. You can also customize text style of a title by using the [`textStyle`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapTitle~TextStyle.html) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/appearance/title/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Title.cs" %}
{% include code-snippet/heatmap/appearance/title/title.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/appearance/title/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Title.cs" %}
{% include code-snippet/heatmap/appearance/title/title.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Data label

You can toggle the visibility of data labels by using the [`showLabel`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapCellSettings~ShowLabel.html) property. By default, the data label will be visible.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/appearance/data-label/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data-label.cs" %}
{% include code-snippet/heatmap/appearance/data-label/data-label.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/appearance/data-label/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data-label.cs" %}
{% include code-snippet/heatmap/appearance/data-label/data-label.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Text style

You can customize the font family, font size, and color of the data label by using the [`textStyle`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapCellSettings~TextStyle.html) in the [`cellSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMap~CellSettings.html) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/appearance/text-style/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Text-style.cs" %}
{% include code-snippet/heatmap/appearance/text-style/text-style.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/appearance/text-style/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Text-style.cs" %}
{% include code-snippet/heatmap/appearance/text-style/text-style.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Format

You can change the format of the data label, such as currency, decimal, percent etc. by using [`format`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapCellSettings~Format.html) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/appearance/format/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Format.cs" %}
{% include code-snippet/heatmap/appearance/format/format.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/appearance/format/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Format.cs" %}
{% include code-snippet/heatmap/appearance/format/format.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Customize the cell value

In the HeatMap, you can customize the cell value using the [`cellRender`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMap~CellRender.html) client-side event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/appearance/cellRender/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CellRender.cs" %}
{% include code-snippet/heatmap/appearance/cellRender/cellRender.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/appearance/cellRender/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CellRender.cs" %}
{% include code-snippet/heatmap/appearance/cellRender/cellRender.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [To customize the appearance of tool tip](./tooltip/#customize-the-appearance-of-tooltip)
