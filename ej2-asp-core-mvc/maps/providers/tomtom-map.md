---
layout: post
title: TomTom map in Syncfusion ##Platform_Name## Syncfusion Maps Component
description: Learn here all about displaying TomTom map in the Syncfusion ##Platform_Name## Maps component and much more details.
platform: ej2-asp-core-mvc
control: TomTom map
publishingplatform: ##Platform_Name##
documentation: ug
---

# TomTom Map in ##Platform_Name## Maps Component

{% if page.publishingplatform == "aspnet-core" %}

TomTom Map, an online map provider, owned by TomTom N.V.(Naamloze Vennootschap), offers map tile images based on user requests. The Syncfusion Maps component then combines these images into a single display to present the map. To display an TomTom map, you can specify its tile service URL in the [urlTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_UrlTemplate) property.

{% elsif page.publishingplatform == "aspnet-mvc" %}

TomTom Map, an online map provider, owned by TomTom N.V.(Naamloze Vennootschap), offers map tile images based on user requests. The Syncfusion Maps component then combines these images into a single display to present the map. To display an TomTom map, you can specify its tile service URL in the [UrlTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_UrlTemplate) property.

{% endif %}

## Displaying TomTom map

The TomTom map tile service can be accessed via the following URL:
https://api.tomtom.com/maps/orbis/map-display/tile/{zoom}/{X}/{Y}.png?apiVersion=1&style=street-light&key=Your_Key

In the above URL template,

* {zoom} - It represents the zoom level of the map.
* {X} - It represents the horizontal position of the tile.
* {Y} - It represents the vertical position of the tile. 

These placeholders are replaced by **level**, **tileX**, and **tileY**, respectively, to retrieve the correct map tile.

N> You can refer this documentation [link](https://developer.tomtom.com/map-display-api/documentation/tomtom-orbis-maps/raster-tile) for the latest URL template for TomTom Map.

The **subscription_key** is required and must be included in the URL to authenticate and access the map tiles. Follow the steps in this [link](https://developer.tomtom.com/platform/documentation/dashboard/api-key-management#start-using-your-api-key) to generate an API key, and then add this key to the URL.

You can customize the tile types in TomTom Map by adjusting the **style** parameter in the URL. For example, setting the style to **street-light** in the URL displays light-themed tiles, which can be rendered in the Syncfusion Maps Component. Similarly, setting the style to **street-dark** switches to dark-themed tiles.

{% if page.publishingplatform == "aspnet-core" %}

In the following example, the TomTom map is displayed by setting [urlTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_UrlTemplate) property with its tile server URL.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/tomtom-map/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="TomTomMap.cs" %}
{% include code-snippet/maps/map-providers/tomtom-map/tomtom-map.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

In the following example, the TomTom map is displayed by setting [UrlTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_UrlTemplate) property with its tile server URL.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/tomtom-map/razor %}
{% endhighlight %}
{% highlight c# tabtitle="TomTomMap.cs" %}
{% include code-snippet/maps/map-providers/tomtom-map/tomtom-map.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![TomTom Map](../images/MapProviders/TomTom/tomtom-map.PNG)

## Enabling zooming and panning

The TomTom map layer supports both zooming and panning. Zooming allows you to take a closer look at a particular area on the map for in-depth analysis, while panning enables you to move the map around to focus on the target area.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/tomtom-map-zoom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="TomTomMapZoom.cs" %}
{% include code-snippet/maps/map-providers/tomtom-map-zoom/tomtom-map-zoom.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/tomtom-map-zoom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="TomTomMapZoom.cs" %}
{% include code-snippet/maps/map-providers/tomtom-map-zoom/tomtom-map-zoom.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![TomTom Map with Zooming and Panning](../images/MapProviders/TomTom/tomtom-map-zooming.png)

## Adding markers and navigation line

{% if page.publishingplatform == "aspnet-core" %}

Markers can be added to the TomTom map layer by setting the latitude and longitude coordinates of the desired location using [MarkerSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_MarkerSettings). Additionally, navigation lines can be added on top of the TomTom map layer to highlight paths between various places by specifying the corresponding latitude and longitude coordinates in the [NavigationLineSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_NavigationLineSettings).

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/tomtom-map-marker/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="TomTomMapMarker.cs" %}
{% include code-snippet/maps/map-providers/tomtom-map-marker/tomtom-map-marker.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

Markers can be added to the TomTom map layer by setting the latitude and longitude coordinates of the desired location using [MarkerSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_MarkerSettings). Additionally, navigation lines can be added on top of the TomTom map layer to highlight paths between various places by specifying the corresponding latitude and longitude coordinates in the [NavigationLineSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_NavigationLineSettings).

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/tomtom-map-marker/razor %}
{% endhighlight %}
{% highlight c# tabtitle="TomTomMapMarker.cs" %}
{% include code-snippet/maps/map-providers/tomtom-map-marker/tomtom-map-marker.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![TomTom Map with Markers and Navigation Line](../images/MapProviders/TomTom/tomtom-map-marker-and-line.png)

## Adding sublayer

{% if page.publishingplatform == "aspnet-core" %}

Any GeoJSON shape can be rendered as a sublayer on top of the TomTom Map layer to highlight a particular continent or country. This is achieved by adding another layer and setting the [Type](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_Type) property of Maps layer to **SubLayer**.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/tomtom-map-sublayer/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="TomTomMapSubLayer.cs" %}
{% include code-snippet/maps/map-providers/tomtom-map-sublayer/tomtom-map-sublayer.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

Any GeoJSON shape can be rendered as a sublayer on top of the TomTom Map layer to highlight a particular continent or country. This is achieved by adding another layer and setting the [Type](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_Type) property of Maps layer to **SubLayer**.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/tomtom-map-sublayer/razor %}
{% endhighlight %}
{% highlight c# tabtitle="TomTomMapSubLayer.cs" %}
{% include code-snippet/maps/map-providers/tomtom-map-sublayer/tomtom-map-sublayer.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![TomTom Map with Sublayer](../images/MapProviders/TomTom/tomtom-map-sublayer.png)

## Enabling legend

{% if page.publishingplatform == "aspnet-core" %}

The legend can be added to the tile Maps by setting the [Visible](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLegendSettings.html#Syncfusion_EJ2_Maps_MapsLegendSettings_Visible) property of [LegendSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.Maps.html#Syncfusion_EJ2_Maps_Maps_LegendSettings) to **true**.

In the example below, the legend is added to the markers on the TomTom map layer.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/tomtom-map-legend/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="TomTomMapLegend.cs" %}
{% include code-snippet/maps/map-providers/tomtom-map-legend/tomtom-map-legend.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

The legend can be added to the tile Maps by setting the [Visible](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLegendSettings.html#Syncfusion_EJ2_Maps_MapsLegendSettings_Visible) property of [LegendSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.Maps.html#Syncfusion_EJ2_Maps_Maps_LegendSettings) to **true**.

In the example below, the legend is added to the markers on the TomTom map layer.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/tomtom-map-legend/razor %}
{% endhighlight %}
{% highlight c# tabtitle="TomTomMapLegend.cs" %}
{% include code-snippet/maps/map-providers/tomtom-map-legend/tomtom-map-legend.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![TomTom Map with Legend](../images/MapProviders/TomTom/tomtom-map-legend.png)
