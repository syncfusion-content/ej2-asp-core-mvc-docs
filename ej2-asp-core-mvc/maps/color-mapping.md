---
layout: post
title: Color Mapping in ##Platform_Name## Maps Component
description: Learn here all about Color Mapping in Syncfusion ##Platform_Name## Maps component and more.
platform: ej2-asp-core-mvc
control: Color Mapping
publishingplatform: ##Platform_Name##
documentation: ug
---

# Color Mapping

Color mapping is used to customize the shape colors based on the given values. It has three types.

1. Range color mapping
2. Equal color mapping
3. Desaturation color mapping

To add color mapping to the shapes of the Maps, bind the data source to the `DataSource` property of `MapsLayer` and set the field name which contains the color value in the data source to the `ColorValuePath` property.

## Types of color mapping

### Range color mapping

Range color mapping applies the color to the shapes of the Maps which matches the numeric values in the data source within the given color mapping ranges. The `From` and `To` properties in the `MapsColorMapping` are used to mention the color mapping ranges in the Maps.

Bind the **ViewBag.populationData** data to the `DataSource` property of `MapsLayer` and set the `ColorValuePath` property of `MapsShapeSettings` as **density**. The range values can be set using the `From` and `To` properties of `MapsColorMapping`.

```sh
 [
    ...
    {
        'code': 'AE',
        'value': 90,
        'name': 'United Arab Emirates',
        'population': 8264070,
        'density': 99
    },
    {
        'code': 'GB',
        'value': 257,
        'name': 'United Kingdom',
        'population': 62041708,
        'density': 255
    },
    {
        'code': 'US',
        'value': 34,
        'name': 'United States',
        'population': 325020000,
        'density': 33
    }
    ...
    ];
```

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/colormapping/colorvaluepath/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Colorvaluepath.cs" %}
{% include code-snippet/maps/colormapping/colorvaluepath/colorvaluepath.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/colormapping/colorvaluepath/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Colorvaluepath.cs" %}
{% include code-snippet/maps/colormapping/colorvaluepath/colorvaluepath.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Range color mapping](./images/Colormapping/range-colormapping.PNG)

> Refer the data values of [Population-density.json](https://www.syncfusion.com/downloads/support/directtrac/general/ze/Population-density-1298888173) here.

### Equal color mapping

Equal color mapping applies the color to the shapes of the Maps when the `Value` property of `MapsColorMapping` matches with the values provided in the data source. The following example shows how to apply equal color mapping to the shapes with the data source **unCountries** which illustrates the permanent and non-permanent countries in the UN security council.

```sh
[
{ Country: 'China', Membership: 'Permanent' },
{ Country: 'France', Membership: 'Permanent' },
{ Country: 'Russia', Membership: 'Permanent' },
{ Country: 'United Kingdom', Membership: 'Permanent' },
{ Country: 'United States', Membership: 'Permanent' },
{ Country: 'Bolivia', Membership: 'Non-Permanent' },
{ Country: 'Eq. Guinea', Membership: 'Non-Permanent' },
{ Country: 'Ethiopia', Membership: 'Non-Permanent' },
{ Country: "Côte d'Ivoire", Membership: 'Permanent' },
{ Country: 'Kazakhstan', Membership: 'Non-Permanent' },
{ Country: 'Kuwait', Membership: 'Non-Permanent' },
{ Country: 'Netherlands', Membership: 'Non-Permanent' },
{ Country: 'Peru', Membership: 'Non-Permanent' },
{ Country: 'Poland', Membership: 'Non-Permanent' },
{ Country: 'Sweden', Membership: 'Non-Permanent' },
]
```

Bind the **ViewBag.unitedCountries** data to the `DataSource` property of `MapsLayer` and set the `ColorValuePath` property of `MapsShapeSettings` as **Membership**. Set the `Value` property in the `MapsColorMapping` to **Permanent** and **Non-Permanent** in the different set of shape color mapping properties. If the corresponding value of the `ColorValuePath` property matches with the corresponding field name in the data source, then the given color will be applied.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/colormapping/equalcolormapping/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Equalcolormapping.cs" %}
{% include code-snippet/maps/colormapping/equalcolormapping/equalcolormapping.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/colormapping/equalcolormapping/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Equalcolormapping.cs" %}
{% include code-snippet/maps/colormapping/equalcolormapping/equalcolormapping.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Equal color mapping](./images/Colormapping/equal-colormapping.PNG)

### Desaturation color mapping

Desaturation color mapping applies the color to the shapes of the Maps, similar to the range color mapping. The opacity will be applied in this color mapping based on the `MinOpacity` and `MaxOpacity` properties in the `MapsColorMapping`.

>The following example shows how to apply desaturation color mapping to the shapes with the data source  **Population_Density** that is available in the [Range color mapping](#range-color-mapping) section.

Bind the **Population_Density** data to the `DataSource` property of `MapsLayer` class and set the `ColorValuePath` property of `MapsShapeSettings` as **density**. The range values can be set using the `From` and `To` properties in the `MapsColorMapping`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/colormapping/desaturationcolormapping/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Desaturationcolormapping.cs" %}
{% include code-snippet/maps/colormapping/desaturationcolormapping/desaturationcolormapping.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/colormapping/desaturationcolormapping/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Desaturationcolormapping.cs" %}
{% include code-snippet/maps/colormapping/desaturationcolormapping/desaturationcolormapping.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Desaturation color mapping](./images/Colormapping/desaturation-colormapping.PNG)

>Refer the data values of [Population-density.json](https://www.syncfusion.com/downloads/support/directtrac/general/ze/Population-density-1298888173) here.

## Multiple colors for a single shape

Multiple colors can be added to the color mapping which can be used as gradient effect to a specific shape based on the ranges in the data source. By using the `Color` property of `MapsColorMapping`, any number of colors can be set to the shapes as a gradient.

>The following example demonstrates how to use multiple colors in color mapping with the data source  **Population_Density** that is available in the [Range color mapping](#range-color-mapping) section.

Bind the **Population_Density** data to the `DataSource` property of `MapsLayer` class and set the `ColorValuePath` property of `MapsShapeSettings` as **density**. The range values can be set using the `From` and `To` properties of `MapsColorMapping`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/colormapping/desaturationwithmultiplecolors/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Desaturationwithmultiplecolors.cs" %}
{% include code-snippet/maps/colormapping/desaturationwithmultiplecolors/desaturationwithmultiplecolors.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/colormapping/desaturationwithmultiplecolors/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Desaturationwithmultiplecolors.cs" %}
{% include code-snippet/maps/colormapping/desaturationwithmultiplecolors/desaturationwithmultiplecolors.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Desaturation with multiple colors](./images/Colormapping/desaturation-multiple-color.PNG)

>Refer the data values of [Population-density.json](https://www.syncfusion.com/downloads/support/directtrac/general/ze/Population-density-1298888173) here.

## Color for items excluded from color mapping

Color mapping can be applied to the shapes in the Maps which does not match color mapping criteria such as range or equal values using the `Color` property of `MapsColorMapping`.

>The following example shows how to set the color for items excluded from the color mapping with the data source **Population_Density** that is available in the [Range color mapping](#range-color-mapping) section.

In the following example, color mapping is added for the ranges from 0 to 200. If there are any records in the data source that are outside of this range, the color mapping will not be applied. To apply the color for these excluded items, set the `Color` property alone in the `MapsColorMapping`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/colormapping/excludedcolormapping/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Excludedcolormapping.cs" %}
{% include code-snippet/maps/colormapping/excludedcolormapping/excludedcolormapping.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/colormapping/excludedcolormapping/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Excludedcolormapping.cs" %}
{% include code-snippet/maps/colormapping/excludedcolormapping/excludedcolormapping.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Color for items excluded from color mapping](./images/Colormapping/excluded-colormapping.PNG)

> Refer the data values of [Population-density.json](https://www.syncfusion.com/downloads/support/directtrac/general/ze/Population-density-1298888173) here.

## Color mapping for bubbles

The color mapping types such as range color mapping, equal color mapping and desaturation color mapping are applicable for bubbles in the Maps. To add color mapping for bubbles of the Maps, bind the data source to the `DataSource` property of `MapsBubble` class and set the field name which contains the color value in the data source to the `ColorValuePath` property. Multiple colors for a single set of bubbles and color for excluded items from `ColorMapping` are also applicable for bubbles.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/colormapping/bubble-colormapping/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Bubble-colormapping.cs" %}
{% include code-snippet/maps/colormapping/bubble-colormapping/bubble-colormapping.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/colormapping/bubble-colormapping/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Bubble-colormapping.cs" %}
{% include code-snippet/maps/colormapping/bubble-colormapping/bubble-colormapping.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Color for items excluded from color mapping](./images/Colormapping/bubble-colormapping.PNG)