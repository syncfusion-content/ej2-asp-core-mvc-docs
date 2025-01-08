---
layout: post
title: TomTom Maps in Syncfusion ##Platform_Name## Syncfusion Maps Component
description: Learn here all about TomTom Maps in the Syncfusion ##Platform_Name## Maps component and much more details.
platform: ej2-asp-core-mvc
control: TomTom Maps
publishingplatform: ##Platform_Name##
documentation: ug
---

# TomTom Maps in ##Platform_Name## Maps Component

{% if page.publishingplatform == "aspnet-core" %}

TomTom Maps is another online Maps provider, owned by TomTom N.V.(Naamloze Vennootschap). As like OSM and Bing Maps, it provides Maps tile images based on our requests and combines those images into a single one to display Maps area. The TomTom Maps can be rendered from online map service providers by specifying the URL provided by those providers in the [UrlTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_UrlTemplate) property. The URL template is designed to enable seamless integration of TomTom Maps online map services, allowing users to preview their maps in the Syncfusion EJ2 Maps control. The following template provides a preview of TomTom Maps within the Syncfusion EJ2 Maps control.

<!-- markdownlint-disable MD034 -->

Sample Template: https://< domain_name >/maps/basic/{z}/{x}/{y}.png

* "${z}" - It represents zoom factor (level).
* "${x}" - It indicates tile image x-position (tileX).
* "${y}" - It indicates tile image y-position (tileY).

{% elsif page.publishingplatform == "aspnet-mvc" %}

TomTom Maps is another online Maps provider, owned by TomTom N.V.(Naamloze Vennootschap). As like OSM and Bing Maps, it provides Maps tile images based on our requests and combines those images into a single one to display Maps area. The TomTom Maps can be rendered from online map service providers by specifying the URL provided by those providers in the [UrlTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_UrlTemplate) property. The URL template is designed to enable seamless integration of TomTom Maps online map services, allowing users to preview their maps in the Syncfusion EJ2 Maps control. The following template provides a preview of TomTom Maps within the Syncfusion EJ2 Maps control.

<!-- markdownlint-disable MD034 -->

Sample Template: https://< domain_name >/maps/basic/{z}/{x}/{y}.png

* "${z}" - It represents zoom factor (level).
* "${x}" - It indicates tile image x-position (tileX).
* "${y}" - It indicates tile image y-position (tileY).

{% endif %}

## Adding TomTom Maps

{% if page.publishingplatform == "aspnet-core" %}

The TomTom map tiles can be accessed using the following URL Template:
http://api.tomtom.com/map/1/tile/basic/main/{zoom}/{X}/{Y}.png?key=subscription_key

In this template, {zoom} represents the zoom level of the map, {X} represents the horizontal position of the tile, and {Y} represents the vertical position of the tile. These placeholders are replaced by **level**, **tileX**, and **tileY**, respectively, to fetch the correct map tile. The subscription_key is required and must be included in the URL to authenticate and access the map tiles. Follow the steps in this [link](https://www.mapsmarker.com/kb/user-guide/how-tomtom-api) to generate an API key, and then added the key to the URL.

In the follwing example, the TomTom Maps can be rendered using the [UrlTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_UrlTemplate) property with the tile server URL provided by online map providers.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/tomtom-maps/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="TomTomMaps.cs" %}
{% include code-snippet/maps/map-providers/tomtom-maps/tomtom-maps.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

The TomTom map tiles can be accessed using the following URL Template:
http://api.tomtom.com/map/1/tile/basic/main/{zoom}/{X}/{Y}.png?key=subscription_key

In this template, {zoom} represents the zoom level of the map, {X} represents the horizontal position of the tile, and {Y} represents the vertical position of the tile. These placeholders are replaced by **level**, **tileX**, and **tileY**, respectively, to fetch the correct map tile. The subscription_key is required and must be included in the URL to authenticate and access the map tiles. Follow the steps in this [link](https://www.mapsmarker.com/kb/user-guide/how-tomtom-api) to generate an API key, and then added the key to the URL.

In the follwing example, the TomTom Maps can be rendered using the [UrlTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_UrlTemplate) property with the tile server URL provided by online map providers.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/tomtom-maps/razor %}
{% endhighlight %}
{% highlight c# tabtitle="TomTomMaps.cs" %}
{% include code-snippet/maps/map-providers/tomtom-maps/tomtom-maps.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![TomTom Maps](../images/MapProviders/TomTom/tomtom-maps.PNG)

## Enabling zooming and panning

The TomTom Maps layer can be zoomed and panned. Zooming helps to get a closer look at a particular area on a map for in-depth analysis. Panning helps to move a map around to focus the targeted area.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/tomtom-maps-zoom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="TomTomMapsZoom.cs" %}
{% include code-snippet/maps/map-providers/tomtom-maps-zoom/tomtom-maps-zoom.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/tomtom-maps-zoom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="TomTomMapsZoom.cs" %}
{% include code-snippet/maps/map-providers/tomtom-maps-zoom/tomtom-maps-zoom.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![TomTom Maps with Zooming and Panning](../images/MapProviders/TomTom/tomtom-maps-zooming.gif)

## Adding markers and navigation line

{% if page.publishingplatform == "aspnet-core" %}

Markers can be added to the layers of TomTom Maps by setting the corresponding location's coordinates of latitude and longitude using [MarkerSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_MarkerSettings). Navigation lines can be added on top of the TomTom Maps layer for highlighting a path among various places by setting the corresponding location's coordinates of latitude and longitude in the [NavigationLineSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_NavigationLineSettings).

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/tomtom-maps-marker/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="TomTomMapsMarker.cs" %}
{% include code-snippet/maps/map-providers/tomtom-maps-marker/tomtom-maps-marker.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

Markers can be added to the layers of TomTom Maps by setting the corresponding location's coordinates of latitude and longitude using [MarkerSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_MarkerSettings). Navigation lines can be added on top of the TomTom Maps layer for highlighting a path among various places by setting the corresponding location's coordinates of latitude and longitude in the [NavigationLineSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_NavigationLineSettings).

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/tomtom-maps-marker/razor %}
{% endhighlight %}
{% highlight c# tabtitle="TomTomMapsMarker.cs" %}
{% include code-snippet/maps/map-providers/tomtom-maps-marker/tomtom-maps-marker.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![TomTom Maps with Markers and Navigation Line](../images/MapProviders/TomTom/tomtom-maps-marker-and-line.PNG)

## Adding sublayer

{% if page.publishingplatform == "aspnet-core" %}

Any GeoJSON shape can be rendered as a sublayer on top of the TomTom Maps layer for highlighting a particular continent or country in TomTom Maps by adding another layer and specifying the [Type](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_Type) property of Maps layer to **SubLayer**.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/tomtom-maps-sublayer/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="TomTomMapsSubLayer.cs" %}
{% include code-snippet/maps/map-providers/tomtom-maps-sublayer/tomtom-maps-sublayer.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

Any GeoJSON shape can be rendered as a sublayer on top of the TomTom Maps layer for highlighting a particular continent or country in TomTom Maps by adding another layer and specifying the [Type](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_Type) property of Maps layer to **SubLayer**.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/tomtom-maps-sublayer/razor %}
{% endhighlight %}
{% highlight c# tabtitle="TomTomMapsSubLayer.cs" %}
{% include code-snippet/maps/map-providers/tomtom-maps-sublayer/tomtom-maps-sublayer.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![TomTom Maps with Sublayer](../images/MapProviders/TomTom/tomtom-maps-sublayer.PNG)

## Enabling legend

{% if page.publishingplatform == "aspnet-core" %}

The legend can be added to the tile Maps by setting the [Visible](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLegendSettings.html#Syncfusion_EJ2_Maps_MapsLegendSettings_Visible) property of [LegendSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.Maps.html#Syncfusion_EJ2_Maps_Maps_LegendSettings) to **true**.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/tomtom-maps-legend/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="TomTomMapsLegend.cs" %}
{% include code-snippet/maps/map-providers/tomtom-maps-legend/tomtom-maps-legend.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

The legend can be added to the tile Maps by setting the [Visible](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLegendSettings.html#Syncfusion_EJ2_Maps_MapsLegendSettings_Visible) property of [LegendSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.Maps.html#Syncfusion_EJ2_Maps_Maps_LegendSettings) to **true**.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/tomtom-maps-legend/razor %}
{% endhighlight %}
{% highlight c# tabtitle="TomTomMapsLegend.cs" %}
{% include code-snippet/maps/map-providers/tomtom-maps-legend/tomtom-maps-legend.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![TomTom Maps with Legend](../images/MapProviders/TomTom/tomtom-maps-legend.PNG)
