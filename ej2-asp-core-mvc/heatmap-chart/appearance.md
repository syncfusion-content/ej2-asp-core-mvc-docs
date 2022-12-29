---
layout: post
title: Appearance in Syncfusion ##Platform_Name## Heatmap Chart Component
description: Learn here all about Appearance in Syncfusion ##Platform_Name## Heatmap Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Appearance
publishingplatform: ##Platform_Name##
documentation: ug
---


# Appearance in ##Platform_Name## HeatMap Chart Component

## Cell customization

{% if page.publishingplatform == "aspnet-core" %}

You can customize the cell by using the [cellSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMap~CellSettings.html) property.

{% elsif page.publishingplatform == "aspnet-mvc" %}

You can customize the cell by using the [CellSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMap.html#Syncfusion_EJ2_HeatMap_HeatMap_CellSettings) property.

{% endif %}

### Border

{% if page.publishingplatform == "aspnet-core" %}

Change the width, color, and radius of the heat map cells by using the [border](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapCellSettings.html#Syncfusion_EJ2_HeatMap_HeatMapCellSettings_Border) property.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/appearance/border/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Border.cs" %}
{% include code-snippet/heatmap/appearance/border/border.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

Change the width, color, and radius of the heat map cells by using the [Border](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapCellSettings.html#Syncfusion_EJ2_HeatMap_HeatMapCellSettings_Border) property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/appearance/border/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Border.cs" %}
{% include code-snippet/heatmap/appearance/border/border.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Cell highlighting

{% if page.publishingplatform == "aspnet-core" %}

Enable or disable the cell highlighting while hovering over the heatmap cells by using the [enableCellHighlighting](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapCellSettings.html#Syncfusion_EJ2_HeatMap_HeatMapCellSettings_EnableCellHighlighting) property.

> The cell highlighting only works in a SVG rendering mode.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/appearance/cell-highlight/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Cell-highlight.cs" %}
{% include code-snippet/heatmap/appearance/cell-highlight/cell-highlight.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

Enable or disable the cell highlighting while hovering over the heat map cells by using the [EnableCellHighlighting](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapCellSettings.html#Syncfusion_EJ2_HeatMap_HeatMapCellSettings_EnableCellHighlighting) property.

> The cell highlighting only works in a SVG rendering mode.

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

{% if page.publishingplatform == "aspnet-core" %}

The [colorGradientMode](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.ColorGradientMode.html) property can be used to set the minimum and maximum values for colors based on row and column. Three types of color gradient modes are available.

* **Table**: The minimum and maximum value colors calculated for overall data.
* **Row**: The minimum and maximum value colors calculated for each row of data.
* **Column**: The minimum and maximum value colors calculated for each column of data.

> The default value of `colorGradientMode` is **Table**.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/appearance/colormode/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Colormode.cs" %}
{% include code-snippet/heatmap/appearance/colormode/colormode.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

The [ColorGradientMode](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.ColorGradientMode.html) property can be used to set the minimum and maximum values for colors based on row and column. Three types of color gradient modes are available.

* **Table**: The minimum and maximum value colors calculated for overall data.
* **Row**: The minimum and maximum value colors calculated for each row of data.
* **Column**: The minimum and maximum value colors calculated for each column of data.

> The default value of `ColorGradientMode` is Table.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/appearance/colormode/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Colormode.cs" %}
{% include code-snippet/heatmap/appearance/colormode/colormode.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Background color

{% if page.publishingplatform == "aspnet-core" %}

The background color of the HeatMap can be customized using the [backgroundColor](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMap.html#Syncfusion_EJ2_HeatMap_HeatMap_Background) property.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/appearance/background-color/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="BackgroundColor.cs" %}
{% include code-snippet/heatmap/appearance/background-color/background-color.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

The background color of the HeatMap can be customized using the [BackgroundColor](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMap.html#Syncfusion_EJ2_HeatMap_HeatMap_Background) property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/appearance/background-color/razor %}
{% endhighlight %}
{% highlight c# tabtitle="BackgroundColor.cs" %}
{% include code-snippet/heatmap/appearance/background-color/background-color.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Margin

{% if page.publishingplatform == "aspnet-core" %}

Set the margin for the heatmap from its container by using the [margin](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMap.html#Syncfusion_EJ2_HeatMap_HeatMap_Margin) property.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/appearance/margin/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Margin.cs" %}
{% include code-snippet/heatmap/appearance/margin/margin.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

Set the margin for the heat map from its container by using the [Margin](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMap.html#Syncfusion_EJ2_HeatMap_HeatMap_Margin) property.

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

{% if page.publishingplatform == "aspnet-core" %}

The title is used to provide a quick information about the data plotted in heatmap. The [text](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapTitle.html#Syncfusion_EJ2_HeatMap_HeatMapTitle_Text) property is used to set the title for the heatmap. The text style of the title can be customized by using the [textStyle](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapTitle.html#Syncfusion_EJ2_HeatMap_HeatMapTitle_TextStyle) property.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/appearance/title/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Title.cs" %}
{% include code-snippet/heatmap/appearance/title/title.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

The title is used to provide a quick information about the data plotted in heatmap. The [Text](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapTitle.html#Syncfusion_EJ2_HeatMap_HeatMapTitle_Text) property is used to set the title for the heatmap. The text style of the title can be customized by using the [TextStyle](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapTitle.html#Syncfusion_EJ2_HeatMap_HeatMapTitle_TextStyle) property.

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

{% if page.publishingplatform == "aspnet-core" %}

The visibility of data labels can be toggled using the [showLabel](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapCellSettings.html#Syncfusion_EJ2_HeatMap_HeatMapCellSettings_ShowLabel) property. By default, the data labels will be visible.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/appearance/data-label/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data-label.cs" %}
{% include code-snippet/heatmap/appearance/data-label/data-label.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

The visibility of data labels can be toggled using the [ShowLabel](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapCellSettings.html#Syncfusion_EJ2_HeatMap_HeatMapCellSettings_ShowLabel) property. By default, the data labels will be visible.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/appearance/data-label/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data-label.cs" %}
{% include code-snippet/heatmap/appearance/data-label/data-label.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Customize the data label

{% if page.publishingplatform == "aspnet-core" %}

The label displayed in the HeatMap cell can be changed using the [cellRender](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMap.html#Syncfusion_EJ2_HeatMap_HeatMap_CellRender) event.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/appearance/cellRender/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CellRender.cs" %}
{% include code-snippet/heatmap/appearance/cellRender/cellRender.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

The value displayed in the HeatMap cell can be changed using the [CellRender](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMap.html#Syncfusion_EJ2_HeatMap_HeatMap_CellRender) event.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/appearance/cellRender/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CellRender.cs" %}
{% include code-snippet/heatmap/appearance/cellRender/cellRender.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Text style

{% if page.publishingplatform == "aspnet-core" %}

The text attributes of the data label such as font-family, font-size, and color can be customized using the [textStyle](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapCellSettings.html#Syncfusion_EJ2_HeatMap_HeatMapCellSettings_TextStyle) in the [cellSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMap~CellSettings.html) property.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/appearance/text-style/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Text-style.cs" %}
{% include code-snippet/heatmap/appearance/text-style/text-style.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

The text attributes of the data label such as font-family, font-size, and color can be customized using the [TextStyle](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapCellSettings.html#Syncfusion_EJ2_HeatMap_HeatMapCellSettings_TextStyle) in the [CellSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapCellSettings.html) property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/appearance/text-style/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Text-style.cs" %}
{% include code-snippet/heatmap/appearance/text-style/text-style.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Format

{% if page.publishingplatform == "aspnet-core" %}

The format of the data label, such as currency, decimal, percent etc. can be changed using [format](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapCellSettings.html#Syncfusion_EJ2_HeatMap_HeatMapCellSettings_Format) property.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/appearance/format/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Format.cs" %}
{% include code-snippet/heatmap/appearance/format/format.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

The format of the data label, such as currency, decimal, percent etc. can be changed using [Format](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapCellSettings.html#Syncfusion_EJ2_HeatMap_HeatMapCellSettings_Format) property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/appearance/format/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Format.cs" %}
{% include code-snippet/heatmap/appearance/format/format.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

