---
layout: post
title: Legend in ##Platform_Name## Stock Chart Component
description: Learn here all about Legend in Syncfusion ##Platform_Name## Stock Chart component and more.
platform: ej2-asp-core-mvc
control: Legend
publishingplatform: ##Platform_Name##
documentation: ug
---


# Legend

Legend provides information about the series rendered in the Stock Chart. Legend can be added to a Stock Chart by enabling the [`visible`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartStockChartLegendSettings.html#Syncfusion_EJ2_Charts_StockChartStockChartLegendSettings_Visible) option in the [`legendSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartStockChartLegendSettings.html#Syncfusion_EJ2_Charts_StockChartStockChartLegendSettings).

## Position and Alignment

By using the [`position`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartStockChartLegendSettings.html#Syncfusion_EJ2_Charts_StockChartStockChartLegendSettings_Position) property, legend can be placed at `Left`, `Right`, `Top`, `Bottom` or `Custom` of the Stock Chart. The legend is positioned at the bottom of the Stock Chart, by default.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/stockchart-legend/position/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Position.cs" %}
{% include code-snippet/stock-chart/stockchart-legend/position/position.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/stockchart-legend/position/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Position.cs" %}
{% include code-snippet/stock-chart/stockchart-legend/position/position.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



[`Custom`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartStockChartLegendSettings.html#Syncfusion_EJ2_Charts_StockChartStockChartLegendSettings_Position) position is used to position the legend anywhere in the Stock Chart using x, y coordinates.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/stockchart-legend/custom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom.cs" %}
{% include code-snippet/stock-chart/stockchart-legend/custom/custom.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/stockchart-legend/custom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom.cs" %}
{% include code-snippet/stock-chart/stockchart-legend/custom/custom.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Legend Alignment

The legend can be align as `Center`, `Far` or `Near` to the Stock Chart using [`alignment`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartStockChartLegendSettings.html#Syncfusion_EJ2_Charts_StockChartStockChartLegendSettings_Alignment) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/stockchart-legend/alignment/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Alignment.cs" %}
{% include code-snippet/stock-chart/stockchart-legend/alignment/alignment.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/stockchart-legend/alignment/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Alignment.cs" %}
{% include code-snippet/stock-chart/stockchart-legend/alignment/alignment.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Customization

To change the legend icon shape, [`legendShape`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartStockChartSeries.html#Syncfusion_EJ2_Charts_StockChartStockChartSeries_LegendShape) property in the [`series`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartStockChartSeries.html#Syncfusion_EJ2_Charts_StockChartStockChartSeries) can be used. By default legend icon shape is `seriesType`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/stockchart-legend/customization/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Customization.cs" %}
{% include code-snippet/stock-chart/stockchart-legend/customization/customization.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/stockchart-legend/customization/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Customization.cs" %}
{% include code-snippet/stock-chart/stockchart-legend/customization/customization.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Legend Size

By default, legend takes 20% - 25% of the Stock Chart's height horizontally, when it is placed on top or bottom position and 20% - 25% of the width vertically, while placing on left or right position of the Stock Chart. The default legend size can be changed by using the [`width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartStockChartLegendSettings.html#Syncfusion_EJ2_Charts_StockChartStockChartLegendSettings_Width) and [`height`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartStockChartLegendSettings.html#Syncfusion_EJ2_Charts_StockChartStockChartLegendSettings_Height) property of the `legendSettings`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/stockchart-legend/size/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Size.cs" %}
{% include code-snippet/stock-chart/stockchart-legend/size/size.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/stockchart-legend/size/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Size.cs" %}
{% include code-snippet/stock-chart/stockchart-legend/size/size.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Legend Item Size

The size of the legend items can customized by using the [`shapeHeight`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartStockChartLegendSettings.html#Syncfusion_EJ2_Charts_StockChartStockChartLegendSettings_ShapeHeight) and [`shapeWidth`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartStockChartLegendSettings.html#Syncfusion_EJ2_Charts_StockChartStockChartLegendSettings_ShapeWidth) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/stockchart-legend/item-size/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Item-size.cs" %}
{% include code-snippet/stock-chart/stockchart-legend/item-size/item-size.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/stockchart-legend/item-size/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Item-size.cs" %}
{% include code-snippet/stock-chart/stockchart-legend/item-size/item-size.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Collapsing Legend Item

By default, series name will be displayed as legend. To skip the legend for a particular series, empty string to the series name can be given.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/stockchart-legend/collapsing/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Collapsing.cs" %}
{% include code-snippet/stock-chart/stockchart-legend/collapsing/collapsing.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/stockchart-legend/collapsing/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Collapsing.cs" %}
{% include code-snippet/stock-chart/stockchart-legend/collapsing/collapsing.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Legend Title

The title for legend can be set using [`title`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartStockChartLegendSettings.html#Syncfusion_EJ2_Charts_StockChartStockChartLegendSettings_Title) property in `legendSettings`. Customize the [`fontStyle`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartFont.html#Syncfusion_EJ2_Charts_StockChartFont_FontStyle), [`size`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartFont.html#Syncfusion_EJ2_Charts_StockChartFont_Size), [`fontWeight`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartFont.html#Syncfusion_EJ2_Charts_StockChartFont_FontWeight), [`color`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartFont.html#Syncfusion_EJ2_Charts_StockChartFont_Color), [`textAlignment`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartFont.html#Syncfusion_EJ2_Charts_StockChartFont_TextAlignment), [`fontFamily`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartFont.html#Syncfusion_EJ2_Charts_StockChartFont_FontFamily), [`opacity`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartFont.html#Syncfusion_EJ2_Charts_StockChartFont_Opacity) and [`textOverflow`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartFont.html#Syncfusion_EJ2_Charts_StockChartFont_TextOverflow) of legend title. [`titlePosition`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartStockChartLegendSettings.html#Syncfusion_EJ2_Charts_StockChartStockChartLegendSettings_TitlePosition) is used to set the legend position in `Top`, `Left` and `Right` position. [`maximumTitleWidth`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartStockChartLegendSettings.html#Syncfusion_EJ2_Charts_StockChartStockChartLegendSettings_MaximumTitleWidth) is used to set the width of the legend title. By default, it will be `100px`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/stockchart-legend/title/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Title.cs" %}
{% include code-snippet/stock-chart/stockchart-legend/title/title.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/stockchart-legend/title/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Title.cs" %}
{% include code-snippet/stock-chart/stockchart-legend/title/title.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


