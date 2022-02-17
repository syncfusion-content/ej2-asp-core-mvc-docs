---
layout: post
title: Color Mapping in ##Platform_Name## Treemap Component
description: Learn here all about Color Mapping in Syncfusion ##Platform_Name## Treemap component and more.
platform: ej2-asp-core-mvc
control: Color Mapping
publishingplatform: ##Platform_Name##
documentation: ug
---

# Color Mapping

Color mapping is used to customize the color for each group or item based on the specified types. The following options are available to customize the group and leaf items in the TreeMap.

## Range color mapping

Range color mapping is used to apply color to the items by giving specific ranges in the DataSource, and it should be specifying the data source properties to the `rangeColorValuePath`. The color mapping ranges to be specified in the `from` and `to` properties of the `colorMapping`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/treemap/colormapping/range/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Range.cs" %}
{% include code-snippet/treemap/colormapping/range/range.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/treemap/colormapping/range/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Range.cs" %}
{% include code-snippet/treemap/colormapping/range/range.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![TreeMap with color mapping](images/Colormapping/Range.png)

## Equal color mapping

Equal color mapping is used to fill colors to each item by specifying equal value present in the data source, that can be specified in the `equalColorValuePath` property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/treemap/colormapping/equal/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Equal.cs" %}
{% include code-snippet/treemap/colormapping/equal/equal.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/treemap/colormapping/equal/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Equal.cs" %}
{% include code-snippet/treemap/colormapping/equal/equal.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![TreeMap with equal color mapping](images/Colormapping/EqualColor.png)

## Desaturation color mapping

Desaturation color mapping is used to apply colors to the items based on `minOpacity` and `maxOpacity` properties in the `colorMapping`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/treemap/colormapping/desaturation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Desaturation.cs" %}
{% include code-snippet/treemap/colormapping/desaturation/desaturation.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/treemap/colormapping/desaturation/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Desaturation.cs" %}
{% include code-snippet/treemap/colormapping/desaturation/desaturation.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![TreeMap with desaturation color mapping](images/Colormapping/Desaturation.png)

## Palette color mapping

The palette color mapping is used to fill the color to each group or leaf item by given colors in the `palette` property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/treemap/colormapping/pallete/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Pallete.cs" %}
{% include code-snippet/treemap/colormapping/pallete/pallete.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/treemap/colormapping/pallete/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Pallete.cs" %}
{% include code-snippet/treemap/colormapping/pallete/pallete.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![TreeMap with palette color mapping](images/Colormapping/Palette.png)

## Desaturation with multiple colors

Multiple colors are used as gradient effect to specific shapes based on the ranges in datasource. By using [`color`] property, you can set n number of colors.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/treemap/colormapping/pallete/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Pallete.cs" %}
{% include code-snippet/treemap/colormapping/pallete/pallete.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/treemap/colormapping/pallete/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Pallete.cs" %}
{% include code-snippet/treemap/colormapping/pallete/pallete.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Multiple color mapping in TreeMap with desaturation](images/Colormapping/DesaturationwithMultiplecolor.png)

## Color for items excluded from color mapping

Get the excluded ranges from data source using the color mapping and apply the specific color to those items, without specifying the `from` and `to` properties.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/treemap/colormapping/excludecolor/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Excludecolor.cs" %}
{% include code-snippet/treemap/colormapping/excludecolor/excludecolor.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/treemap/colormapping/excludecolor/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Excludecolor.cs" %}
{% include code-snippet/treemap/colormapping/excludecolor/excludecolor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![TreeMap color mapping for excluded items](images/Colormapping/ExcludeItem.png)

## Bind the colors to the items from data source

To set the color for each item from the data source, bind the data source property to the `colorValuePath`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/treemap/colormapping/multiplecolor/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Multiplecolor.cs" %}
{% include code-snippet/treemap/colormapping/multiplecolor/multiplecolor.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/treemap/colormapping/multiplecolor/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Multiplecolor.cs" %}
{% include code-snippet/treemap/colormapping/multiplecolor/multiplecolor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Bind the colors to TreeMap from datasource](images/Colormapping/ColorDS.png)