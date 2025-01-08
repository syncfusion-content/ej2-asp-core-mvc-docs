---
layout: post
title: MapTiler Maps in Syncfusion ##Platform_Name## Syncfusion Maps Component
description: Learn here all about MapTiler Maps in the Syncfusion ##Platform_Name## Maps component and much more details.
platform: ej2-asp-core-mvc
control: MapTiler Maps
publishingplatform: ##Platform_Name##
documentation: ug
---

# MapTiler Maps in ##Platform_Name## Maps Component

{% if page.publishingplatform == "aspnet-core" %}

MapTiler Maps is another online Maps provider, owned by MapTiler AG, a Swiss company. As like OSM and Bing Maps, it provides Maps tile images based on our requests and combines those images into a single one to display Maps area. The MapTiler Maps can be rendered from online map service providers by specifying the URL provided by those providers in the [UrlTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_UrlTemplate) property. The URL template is designed to enable seamless integration of MapTiler online map services, allowing users to preview their maps in the Syncfusion EJ2 Maps control. The following template provides a preview of MapTiler Maps within the Syncfusion EJ2 Maps control.

<!-- markdownlint-disable MD034 -->

Sample Template: https://< domain_name >/maps/basic/{z}/{x}/{y}.png

* "${z}" - It represents zoom factor (level).
* "${x}" - It indicates tile image x-position (tileX).
* "${y}" - It indicates tile image y-position (tileY).

{% elsif page.publishingplatform == "aspnet-mvc" %}

MapTiler Maps is another online Maps provider, owned by MapTiler AG, a Swiss company. As like OSM and Bing Maps, it provides Maps tile images based on our requests and combines those images into a single one to display Maps area. The MapTiler Maps can be rendered from online map service providers by specifying the URL provided by those providers in the [UrlTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_UrlTemplate) property. The URL template is designed to enable seamless integration of MapTiler online map services, allowing users to preview their maps in the Syncfusion EJ2 Maps control. The following template provides a preview of MapTiler Maps within the Syncfusion EJ2 Maps control.

<!-- markdownlint-disable MD034 -->

Sample Template: https://< domain_name >/maps/basic/{z}/{x}/{y}.png

* "${z}" - It represents zoom factor (level).
* "${x}" - It indicates tile image x-position (tileX).
* "${y}" - It indicates tile image y-position (tileY).

{% endif %}

## Adding MapTiler Maps

{% if page.publishingplatform == "aspnet-core" %}

The MapTiler map tiles can be accessed using the following URL Template:
https://api.maptiler.com/tiles/satellite/{z}/{x}/{y}.jpg?key=Your_Key

In this template, {z} represents the zoom level of the map, {x} represents the horizontal position of the tile, and {y} represents the vertical position of the tile. These placeholders are replaced by **level**, **tileX**, and **tileY**, respectively, to fetch the correct map tile. The subscription_key is required and must be included in the URL to authenticate and access the map tiles. Follow the steps in this [link](https://docs.maptiler.com/cloud/api/authentication-key/#api-key) to generate an API key, and then added the key to the URL.

In the follwing example, the MapTiler Maps can be rendered using the [UrlTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_UrlTemplate) property with the tile server URL provided by online map providers.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/maptiler-maps/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="MapTilerMaps.cs" %}
{% include code-snippet/maps/map-providers/maptiler-maps/maptiler-maps.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

The MapTiler map tiles can be accessed using the following URL Template:
https://api.maptiler.com/tiles/satellite/{z}/{x}/{y}.jpg?key=Your_Key

In this template, {z} represents the zoom level of the map, {x} represents the horizontal position of the tile, and {y} represents the vertical position of the tile. These placeholders are replaced by **level**, **tileX**, and **tileY**, respectively, to fetch the correct map tile. The subscription_key is required and must be included in the URL to authenticate and access the map tiles. Follow the steps in this [link](https://docs.maptiler.com/cloud/api/authentication-key/#api-key) to generate an API key, and then added the key to the URL.

In the follwing example, the MapTiler Maps can be rendered using the [UrlTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_UrlTemplate) property with the tile server URL provided by online map providers.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/maptiler-maps/razor %}
{% endhighlight %}
{% highlight c# tabtitle="MapTilerMaps.cs" %}
{% include code-snippet/maps/map-providers/maptiler-maps/maptiler-maps.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![MapTiler Maps](../images/MapProviders/MapTiler/maptiler-maps.PNG)

## Enabling zooming and panning

The MapTiler Maps layer can be zoomed and panned. Zooming helps to get a closer look at a particular area on a map for in-depth analysis. Panning helps to move a map around to focus the targeted area.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/maptiler-maps-zoom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="MapTilerMapsZoom.cs" %}
{% include code-snippet/maps/map-providers/maptiler-maps-zoom/maptiler-maps-zoom.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/maptiler-maps-zoom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="MapTilerMapsZoom.cs" %}
{% include code-snippet/maps/map-providers/maptiler-maps-zoom/maptiler-maps-zoom.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![MapTiler Maps with Zooming and Panning](../images/MapProviders/MapTiler/maptiler-maps-zooming.gif)

## Adding markers and navigation line

{% if page.publishingplatform == "aspnet-core" %}

Markers can be added to the layers of MapTiler Maps by setting the corresponding location's coordinates of latitude and longitude using [MarkerSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_MarkerSettings). Navigation lines can be added on top of the MapTiler Maps layer for highlighting a path among various places by setting the corresponding location's coordinates of latitude and longitude in the [NavigationLineSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_NavigationLineSettings).

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/maptiler-maps-marker/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="MapTilerMapsMarker.cs" %}
{% include code-snippet/maps/map-providers/maptiler-maps-marker/maptiler-maps-marker.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

Markers can be added to the layers of MapTiler Maps by setting the corresponding location's coordinates of latitude and longitude using [MarkerSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_MarkerSettings). Navigation lines can be added on top of the MapTiler Maps layer for highlighting a path among various places by setting the corresponding location's coordinates of latitude and longitude in the [NavigationLineSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_NavigationLineSettings).

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/maptiler-maps-marker/razor %}
{% endhighlight %}
{% highlight c# tabtitle="MapTilerMapsMarker.cs" %}
{% include code-snippet/maps/map-providers/maptiler-maps-marker/maptiler-maps-marker.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![MapTiler Maps with Markers and Navigation Line](../images/MapProviders/MapTiler/maptiler-maps-marker-and-line.PNG)

## Adding sublayer

{% if page.publishingplatform == "aspnet-core" %}

Any GeoJSON shape can be rendered as a sublayer on top of the MapTiler Maps layer for highlighting a particular continent or country in MapTiler Maps by adding another layer and specifying the [Type](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_Type) property of Maps layer to **SubLayer**.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/maptiler-maps-sublayer/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="MapTilerMapsSubLayer.cs" %}
{% include code-snippet/maps/map-providers/maptiler-maps-sublayer/maptiler-maps-sublayer.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

Any GeoJSON shape can be rendered as a sublayer on top of the MapTiler Maps layer for highlighting a particular continent or country in MapTiler Maps by adding another layer and specifying the [Type](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_Type) property of Maps layer to **SubLayer**.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/maptiler-maps-sublayer/razor %}
{% endhighlight %}
{% highlight c# tabtitle="MapTilerMapsSubLayer.cs" %}
{% include code-snippet/maps/map-providers/maptiler-maps-sublayer/maptiler-maps-sublayer.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![MapTiler Maps with Sublayer](../images/MapProviders/MapTiler/maptiler-maps-sublayer.PNG)

## Enabling legend

{% if page.publishingplatform == "aspnet-core" %}

The legend can be added to the tile Maps by setting the [Visible](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLegendSettings.html#Syncfusion_EJ2_Maps_MapsLegendSettings_Visible) property of [LegendSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.Maps.html#Syncfusion_EJ2_Maps_Maps_LegendSettings) to **true**.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/maptiler-maps-legend/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="MapTilerMapsLegend.cs" %}
{% include code-snippet/maps/map-providers/maptiler-maps-legend/maptiler-maps-legend.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

The legend can be added to the tile Maps by setting the [Visible](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLegendSettings.html#Syncfusion_EJ2_Maps_MapsLegendSettings_Visible) property of [LegendSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.Maps.html#Syncfusion_EJ2_Maps_Maps_LegendSettings) to **true**.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/maptiler-maps-legend/razor %}
{% endhighlight %}
{% highlight c# tabtitle="MapTilerMapsLegend.cs" %}
{% include code-snippet/maps/map-providers/maptiler-maps-legend/maptiler-maps-legend.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![MapTiler Maps with Legend](../images/MapProviders/MapTiler/maptiler-maps-legend.PNG)
