---
layout: post
title: Other Maps in ##Platform_Name## Maps Component
description: Learn here all about Other Maps in Syncfusion ##Platform_Name## Maps component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Other Maps
publishingplatform: ##Platform_Name##
documentation: ug
---

# Other Maps providers

Apart from OpenStreetMap and Bing Maps, you can also render Maps from other online map service providers by specifying the URL provided by those providers in the [urlTemplate](../api/maps/layerSettingsModel/#urlTemplate) property. The URL template concept has been implemented in such a way that any online map service providers using the following template can benefit from previewing their Map in the Syncfusion ##Platform_Name## Maps control.

<!-- markdownlint-disable MD034 -->

Sample Template: https://< domain_name >/maps/basic/{z}/{x}/{y}.png

* "${z}" - It represents zoom factor (level).
* "${x}" - It indicates tile image x-position (tileX).
* "${y}" - It indicates tile image y-position (tileY).

In this case, the key generated for those online map service providers can also be appended to the URL. This allows to create personalized Maps with your own content and imagery. In this example, Google Maps is rendered.
>Refer to [Google Maps Licensing](https://developers.google.com/maps/terms#10-license-restrictions).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/othermap/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Othermap.cs" %}
{% include code-snippet/maps/map-providers/othermap/othermap.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/othermap/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Othermap.cs" %}
{% include code-snippet/maps/map-providers/othermap/othermap.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Enabling zooming and panning

Tile Maps layer can be zoomed and panned. Zooming helps to get a closer look at a particular area on a Maps for in-depth analysis. Panning helps to move a Maps around to focus the targeted area.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/othermapzoom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Otherzoom.cs" %}
{% include code-snippet/maps/map-providers/othermapzoom/otherzoom.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/othermapzoom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Otherzoom.cs" %}
{% include code-snippet/maps/map-providers/othermapzoom/otherzoom.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Adding markers and navigation line

Markers can be added to the layers of tile Maps by setting the corresponding location's coordinates of latitude and longitude using `MarkerSettings`. Navigation lines can be added on top of an tile Maps layer for highlighting a path among various places by setting the corresponding location's coordinates of latitude and longitude in the `NavigationLineSettings`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/othermapmarker/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Othermarker.cs" %}
{% include code-snippet/maps/map-providers/othermapmarker/othermarker.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/othermapmarker/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Othermarker.cs" %}
{% include code-snippet/maps/map-providers/othermapmarker/othermarker.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Adding sublayer

Any GeoJSON shape can be rendered as a sublayer on top of the tile Maps layer for highlighting a particular continent or country in tile Maps by adding another layer and specifying the `Type` property of Maps layer to **SubLayer**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/othersublayer/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Othersublayer.cs" %}
{% include code-snippet/maps/map-providers/othersublayer/othersublayer.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/othersublayer/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Othersublayer.cs" %}
{% include code-snippet/maps/map-providers/othersublayer/othersublayer.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Enabling legend

The legend can be added to the tile Maps by setting the `Visible` property of `MapsLegendSettings` to **true**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/othermaplegend/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Othersublayer.cs" %}
{% include code-snippet/maps/map-providers/othermaplegend/othermaplegend.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/othermaplegend/razor %}
{% endhighlight %}
{% highlight c# tabtitle="OtherLegend.cs" %}
{% include code-snippet/maps/map-providers/othermaplegend/othermaplegend.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Other Map Providers With Legend](../images/MapProviders/google-map-legend.PNG)