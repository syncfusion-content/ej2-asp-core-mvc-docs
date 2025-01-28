---
layout: post
title: HERE map in Syncfusion ##Platform_Name## Syncfusion Maps Component
description: Learn here all about displaying HERE map in the Syncfusion ##Platform_Name## Maps component and much more details.
platform: ej2-asp-core-mvc
control: HERE map
publishingplatform: ##Platform_Name##
documentation: ug
---

# HERE map in ##Platform_Name## Maps Component

{% if page.publishingplatform == "aspnet-core" %}

HERE map, an online map provider, owned by HERE Technologies, offers map tile images based on user requests. The Syncfusion Maps component then combines these images into a single display to present the map. To display an HERE map, you can specify its tile service URL in the [urlTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_UrlTemplate) property.

{% elsif page.publishingplatform == "aspnet-mvc" %}

HERE map, an online map provider, owned by HERE Technologies, offers map tile images based on user requests. The Syncfusion Maps component then combines these images into a single display to present the map. To display an HERE map, you can specify its tile service URL in the [UrlTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_UrlTemplate) property.

{% endif %}

## Displaying HERE map

The HERE map tile service can be accessed via the following URL:
https://maps.hereapi.com/v3/base/mc/{z}/{x}/{y}/png?apiKey=Your_key

In the above URL template,

* {z} - It represents the zoom level of the map.
* {x} - It represents the horizontal position of the tile.
* {y} - It represents the vertical position of the tile. 

These placeholders are replaced by **level**, **tileX**, and **tileY**, respectively, to retrieve the correct map tile.

N> You can refer this documentation [link](https://www.here.com/docs/bundle/raster-tile-api-developer-guide/page/topics/quickstart.html#obtain-a-tile) for the latest URL template for Here map.

The **subscription_key** is required and must be included in the URL to authenticate and access the map tiles. Follow the steps in this [link](https://www.here.com/docs/bundle/raster-tile-api-developer-guide/page/topics/quickstart.html#get-an-api-key) to generate an API key, and then added the key to the URL.

{% if page.publishingplatform == "aspnet-core" %}

In the following example, the HERE map can be rendered using the [urlTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_UrlTemplate) property with its tile server URL.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/here-map/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="HEREMap.cs" %}
{% include code-snippet/maps/map-providers/here-map/here-map.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

The Here map tiles can be accessed using the following URL Template:
https://maps.hereapi.com/v3/base/mc/{z}/{x}/{y}/png?apiKey=Your_key

In this template, {z} represents the zoom level of the map, {x} represents the horizontal position of the tile, and {y} represents the vertical position of the tile. These placeholders are replaced by **level**, **tileX**, and **tileY**, respectively, to fetch the correct map tile. The subscription_key is required and must be included in the URL to authenticate and access the map tiles. Follow the steps in this [link](https://www.here.com/docs/bundle/raster-tile-api-developer-guide/page/topics/quickstart.html) to generate an API key, and then add this key to the URL.

In the following example, the HERE map is displayed by setting [UrlTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_UrlTemplate) property with its tile server URL.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/here-map/razor %}
{% endhighlight %}
{% highlight c# tabtitle="C.cs" %}
{% include code-snippet/maps/map-providers/here-map/here-map.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![HERE Map](../images/MapProviders/Here-map/here-map.png)

## Enabling zooming and panning

The HERE map layer supports both zooming and panning. Zooming allows you to take a closer look at a particular area on the map for in-depth analysis, while panning enables you to move the map around to focus on the target area.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/here-map-zoom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="HEREMapZoom.cs" %}
{% include code-snippet/maps/map-providers/here-map-zoom/here-map-zoom.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/here-map-zoom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HEREMapZoom.cs" %}
{% include code-snippet/maps/map-providers/here-map-zoom/here-map-zoom.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![HERE Map with Zooming and Panning](../images/MapProviders/Here-map/here-map-zooming.png)

## Adding markers and navigation line

{% if page.publishingplatform == "aspnet-core" %}

Markers can be added to the HERE map layer by setting the latitude and longitude coordinates of the desired location using [MarkerSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_MarkerSettings). Additionally, navigation lines can be added on top of the HERE map layer to highlight paths between various places by specifying the corresponding latitude and longitude coordinates in the [NavigationLineSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_NavigationLineSettings).

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/here-map-marker/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="HEREMapMarker.cs" %}
{% include code-snippet/maps/map-providers/here-map-marker/here-map-marker.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

Markers can be added to the HERE map layer by setting the latitude and longitude coordinates of the desired location using [MarkerSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_MarkerSettings). Additionally, navigation lines can be added on top of the HERE map layer to highlight paths between various places by specifying the corresponding latitude and longitude coordinates in the [NavigationLineSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_NavigationLineSettings).

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/here-map-marker/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HEREMapMarker.cs" %}
{% include code-snippet/maps/map-providers/here-map-marker/here-map-marker.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![HERE Map with Markers and Navigation Line](../images/MapProviders/Here-map/here-map-marker-and-line.png)

## Adding sublayer

{% if page.publishingplatform == "aspnet-core" %}

Any GeoJSON shape can be rendered as a sublayer on top of the HERE map layer to highlight a particular continent or country. This is achieved by adding another layer and setting the [Type](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_Type) property of Maps layer to **SubLayer**.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/here-map-sublayer/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="HEREMapSubLayer.cs" %}
{% include code-snippet/maps/map-providers/here-map-sublayer/here-map-sublayer.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

Any GeoJSON shape can be rendered as a sublayer on top of the HERE map layer to highlight a particular continent or country. This is achieved by adding another layer and setting the [Type](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_Type) property of Maps layer to **SubLayer**.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/here-map-sublayer/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HEREMapSubLayer.cs" %}
{% include code-snippet/maps/map-providers/here-map-sublayer/here-map-sublayer.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![HERE Map with Sublayer](../images/MapProviders/Here-map/here-map-sublayer.png)

## Enabling legend

{% if page.publishingplatform == "aspnet-core" %}

The legend can be added to the tile Maps by setting the [Visible](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLegendSettings.html#Syncfusion_EJ2_Maps_MapsLegendSettings_Visible) property of [LegendSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.Maps.html#Syncfusion_EJ2_Maps_Maps_LegendSettings) to **true**.

In the example below, the legend is added to the markers on the HERE map layer.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/here-map-legend/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="HEREMapLegend.cs" %}
{% include code-snippet/maps/map-providers/here-map-legend/here-map-legend.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

The legend can be added to the tile Maps by setting the [Visible](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLegendSettings.html#Syncfusion_EJ2_Maps_MapsLegendSettings_Visible) property of [LegendSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.Maps.html#Syncfusion_EJ2_Maps_Maps_LegendSettings) to **true**.

In the example below, the legend is added to the markers on the HERE map layer.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/here-map-legend/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HEREMapLegend.cs" %}
{% include code-snippet/maps/map-providers/here-map-legend/here-map-legend.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![HERE Map with Legend](../images/MapProviders/Here-map/here-map-legend.png)
