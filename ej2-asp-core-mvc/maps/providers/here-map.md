---
layout: post
title: HERE Map in Syncfusion ##Platform_Name## Syncfusion Maps Component
description: Learn here all about HERE Map in the Syncfusion ##Platform_Name## Maps component and much more details.
platform: ej2-asp-core-mvc
control: HERE Map
publishingplatform: ##Platform_Name##
documentation: ug
---

# HERE Map in ##Platform_Name## Maps Component

{% if page.publishingplatform == "aspnet-core" %}

HERE Map is another online Maps provider, owned by HERE Technologies. As like OSM and Bing Maps, it provides Maps tile images based on our requests and combines those images into a single one to display Maps area. The HERE Map can be rendered from online map service providers by specifying the URL provided by those providers in the [urlTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_UrlTemplate) property. The URL template is designed to enable seamless integration of HERE Map online map services, allowing users to preview their maps in the Syncfusion EJ2 Maps Component.

{% elsif page.publishingplatform == "aspnet-mvc" %}

HERE Map is another online Maps provider, owned by HERE Technologies. As like OSM and Bing Maps, it provides Maps tile images based on our requests and combines those images into a single one to display Maps area. The HERE Map can be rendered from online map service providers by specifying the URL provided by those providers in the [UrlTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_UrlTemplate) property. The URL template is designed to enable seamless integration of ArcGIS online map services, allowing users to preview their maps in the Syncfusion EJ2 Maps Component.

{% endif %}

## Adding HERE Map

The HERE map tile service can be accessed via the following URL:
https://maps.hereapi.com/v3/base/mc/{z}/{x}/{y}/png?apiKey=Your_key

In the above URL template,

* {z} - It represents the zoom level of the map.
* {x} - It represents the horizontal position of the tile.
* {y} - It represents the vertical position of the tile. 

These placeholders are replaced by **level**, **tileX**, and **tileY**, respectively, to fetch the correct map tile.

N> You can refer this documentation [link](https://www.here.com/docs/bundle/raster-tile-api-developer-guide/page/topics/quickstart.html#obtain-a-tile) for the latest URL template for Here Map.

The subscription_key is required and must be included in the URL to authenticate and access the map tiles. Follow the steps in this [link](https://www.here.com/docs/bundle/raster-tile-api-developer-guide/page/topics/quickstart.html#get-an-api-key) to generate an API key, and then added the key to the URL.

{% if page.publishingplatform == "aspnet-core" %}

In the following example, the HERE Map can be rendered using the [urlTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_UrlTemplate) property with the tile server URL provided by online map providers.

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

In this template, {z} represents the zoom level of the map, {x} represents the horizontal position of the tile, and {y} represents the vertical position of the tile. These placeholders are replaced by **level**, **tileX**, and **tileY**, respectively, to fetch the correct map tile. The subscription_key is required and must be included in the URL to authenticate and access the map tiles. Follow the steps in this [link](https://www.here.com/docs/bundle/raster-tile-api-developer-guide/page/topics/quickstart.html) to generate an API key, and then added the key to the URL.

In the following example, the HERE Map can be rendered using the [UrlTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_UrlTemplate) property with the tile server URL provided by online map providers.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/here-map/razor %}
{% endhighlight %}
{% highlight c# tabtitle="C.cs" %}
{% include code-snippet/maps/map-providers/here-map/here-map.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![HERE Map](../images/MapProviders/Here-map/here-map.PNG)

## Enabling zooming and panning

The HERE Map layer can be zoomed and panned. Zooming helps to get a closer look at a particular area on a map for in-depth analysis. Panning helps to move a map around to focus the targeted area.

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

![HERE Map with Zooming and Panning](../images/MapProviders/Here-map/here-map-zooming.PNG)

## Adding markers and navigation line

{% if page.publishingplatform == "aspnet-core" %}

Markers can be added to the layers of HERE Map by setting the corresponding location's coordinates of latitude and longitude using [MarkerSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_MarkerSettings). Navigation lines can be added on top of the HERE Map layer for highlighting a path among various places by setting the corresponding location's coordinates of latitude and longitude in the [NavigationLineSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_NavigationLineSettings).

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/here-map-marker/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="HEREMapMarker.cs" %}
{% include code-snippet/maps/map-providers/here-map-marker/here-map-marker.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

Markers can be added to the layers of HERE Map by setting the corresponding location's coordinates of latitude and longitude using [MarkerSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_MarkerSettings). Navigation lines can be added on top of the HERE Map layer for highlighting a path among various places by setting the corresponding location's coordinates of latitude and longitude in the [NavigationLineSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_NavigationLineSettings).

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/here-map-marker/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HEREMapMarker.cs" %}
{% include code-snippet/maps/map-providers/here-map-marker/here-map-marker.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![HERE Map with Markers and Navigation Line](../images/MapProviders/Here-map/here-map-marker-and-line.PNG)

## Adding sublayer

{% if page.publishingplatform == "aspnet-core" %}

Any GeoJSON shape can be rendered as a sublayer on top of the HERE Map layer for highlighting a particular continent or country in HERE Map by adding another layer and specifying the [Type](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_Type) property of Maps layer to **SubLayer**.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/here-map-sublayer/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="HEREMapSubLayer.cs" %}
{% include code-snippet/maps/map-providers/here-map-sublayer/here-map-sublayer.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

Any GeoJSON shape can be rendered as a sublayer on top of the HERE Map layer for highlighting a particular continent or country in HERE Map by adding another layer and specifying the [Type](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_Type) property of Maps layer to **SubLayer**.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/here-map-sublayer/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HEREMapSubLayer.cs" %}
{% include code-snippet/maps/map-providers/here-map-sublayer/here-map-sublayer.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![HERE Map with Sublayer](../images/MapProviders/Here-map/here-map-sublayer.PNG)

## Enabling legend

{% if page.publishingplatform == "aspnet-core" %}

The legend can be added to the tile Maps by setting the [Visible](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLegendSettings.html#Syncfusion_EJ2_Maps_MapsLegendSettings_Visible) property of [LegendSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.Maps.html#Syncfusion_EJ2_Maps_Maps_LegendSettings) to **true**.

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

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/here-map-legend/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HEREMapLegend.cs" %}
{% include code-snippet/maps/map-providers/here-map-legend/here-map-legend.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![HERE Map with Legend](../images/MapProviders/Here-map/here-map-legend.PNG)
