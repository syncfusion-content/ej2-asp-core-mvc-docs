---
layout: post
title: Google Maps in Syncfusion ##Platform_Name## Syncfusion Maps Component
description: Learn here all about Google Maps in the Syncfusion ##Platform_Name## Maps component and much more details.
platform: ej2-asp-core-mvc
control: Google Maps
publishingplatform: ##Platform_Name##
documentation: ug
---

# Google Maps in ##Platform_Name## Maps Component

{% if page.publishingplatform == "aspnet-core" %}

Google Maps is yet another online Maps provider, owned by Google. As like OSM and Bing Maps, it provides Maps tile images based on our requests and combines those images into a single one to display Maps area. The Google Maps can be rendered from online map service providers by specifying the URL provided by those providers in the [UrlTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_UrlTemplate) property. The URL template is designed to enable seamless integration of Google online map services, allowing users to preview their maps in the Syncfusion EJ2 Maps control. The following template provides a preview of Google Maps within the Syncfusion EJ2 Maps control.

<!-- markdownlint-disable MD034 -->

Sample Template: https://< domain_name >/maps/basic/{z}/{x}/{y}.png

* "${z}" - It represents zoom factor (level).
* "${x}" - It indicates tile image x-position (tileX).
* "${y}" - It indicates tile image y-position (tileY).

{% elsif page.publishingplatform == "aspnet-mvc" %}

Google Maps is yet another online Maps provider, owned by Google. As like OSM and Bing Maps, it provides Maps tile images based on our requests and combines those images into a single one to display Maps area. The Google Maps can be rendered from online map service providers by specifying the URL provided by those providers in the [UrlTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_UrlTemplate) property. The URL template is designed to enable seamless integration of Google online map services, allowing users to preview their maps in the Syncfusion EJ2 Maps control. The following template provides a preview of Google Maps within the Syncfusion EJ2 Maps control.

<!-- markdownlint-disable MD034 -->

Sample Template: https://< domain_name >/maps/basic/{z}/{x}/{y}.png

* "${z}" - It represents zoom factor (level).
* "${x}" - It indicates tile image x-position (tileX).
* "${y}" - It indicates tile image y-position (tileY).

{% endif %}

## Adding Google Maps

{% if page.publishingplatform == "aspnet-core" %}

The Google map tiles can be accessed using the following URL Template:
https://tile.googleapis.com/v1/2dtiles/z/x/y?key=YOUR_API_KEY

In this template, {z} represents the zoom level of the map, {x} represents the horizontal position of the tile, and {y} represents the vertical position of the tile. These placeholders are replaced by **level**, **tileX**, and **tileY**, respectively, to fetch the correct map tile. The subscription_key is required and must be included in the URL to authenticate and access the map tiles. Follow the steps in this [link](https://developers.google.com/maps/documentation/tile/get-api-key) to generate an API key, and then added the key to the URL.

>You can refer this documentation link(https://developers.google.com/maps/documentation/tile/roadmap) for the latest URL template for Google Maps.

In the follwing example, the Google Maps can be rendered using the [UrlTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_UrlTemplate) property with the tile server URL provided by online map providers.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/google-maps/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="GoogleMaps.cs" %}
{% include code-snippet/maps/map-providers/google-maps/google-maps.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

The Google map tiles can be accessed using the following URL Template:
https://tile.googleapis.com/v1/2dtiles/z/x/y?key=YOUR_API_KEY

In this template, {z} represents the zoom level of the map, {x} represents the horizontal position of the tile, and {y} represents the vertical position of the tile. These placeholders are replaced by **level**, **tileX**, and **tileY**, respectively, to fetch the correct map tile. The subscription_key is required and must be included in the URL to authenticate and access the map tiles. Follow the steps in this [link](https://developers.google.com/maps/documentation/tile/get-api-key) to generate an API key, and then added the key to the URL.

>You can refer this documentation link(https://developers.google.com/maps/documentation/tile/roadmap) for the latest URL template for Google Maps.

In the follwing example, the Google Maps can be rendered using the [UrlTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_UrlTemplate) property with the tile server URL provided by online map providers.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/google-maps/razor %}
{% endhighlight %}
{% highlight c# tabtitle="GoogleMaps.cs" %}
{% include code-snippet/maps/map-providers/google-maps/google-maps.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Google Maps](../images/MapProviders/Google-maps/google-maps.PNG)

## Enabling zooming and panning

The Google Maps layer can be zoomed and panned. Zooming helps to get a closer look at a particular area on a map for in-depth analysis. Panning helps to move a map around to focus the targeted area.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/google-maps/zoom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="GoogleMapsZoom.cs" %}
{% include code-snippet/maps/map-providers/google-maps/zoom/google-maps-zoom.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/google-maps/zoom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="GoogleMapsZoom.cs" %}
{% include code-snippet/maps/map-providers/google-maps/zoom/google-maps-zoom.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Google Maps with Zooming and Panning](../images/MapProviders/Google-maps/google-maps-zooming.gif)

## Adding markers and navigation line

{% if page.publishingplatform == "aspnet-core" %}

Markers can be added to the layers of Google Maps by setting the corresponding location's coordinates of latitude and longitude using [MarkerSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_MarkerSettings). Navigation lines can be added on top of the Google Maps layer for highlighting a path among various places by setting the corresponding location's coordinates of latitude and longitude in the [NavigationLineSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_NavigationLineSettings).

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/google-maps/marker/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="GoogleMapsMarker.cs" %}
{% include code-snippet/maps/map-providers/google-maps/marker/google-maps-marker.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

Markers can be added to the layers of Google Maps by setting the corresponding location's coordinates of latitude and longitude using [MarkerSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_MarkerSettings). Navigation lines can be added on top of the Google Maps layer for highlighting a path among various places by setting the corresponding location's coordinates of latitude and longitude in the [NavigationLineSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_NavigationLineSettings).

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/google-maps/marker/razor %}
{% endhighlight %}
{% highlight c# tabtitle="GoogleMapsMarker.cs" %}
{% include code-snippet/maps/map-providers/google-maps/marker/google-maps-marker.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Google Maps with Markers and Navigation Line](../images/MapProviders/Google-maps/google-maps-marker-and-line.PNG)

## Adding sublayer

{% if page.publishingplatform == "aspnet-core" %}

Any GeoJSON shape can be rendered as a sublayer on top of the Google Maps layer for highlighting a particular continent or country in Google Maps by adding another layer and specifying the [Type](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_Type) property of Maps layer to **SubLayer**.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/google-maps/sublayer/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="GoogleMapsSubLayer.cs" %}
{% include code-snippet/maps/map-providers/google-maps/sublayer/google-maps-sublayer.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

Any GeoJSON shape can be rendered as a sublayer on top of the Google Maps layer for highlighting a particular continent or country in Google Maps by adding another layer and specifying the [Type](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_Type) property of Maps layer to **SubLayer**.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/google-maps/sublayer/razor %}
{% endhighlight %}
{% highlight c# tabtitle="GoogleMapsSubLayer.cs" %}
{% include code-snippet/maps/map-providers/google-maps/sublayer/google-maps-sublayer.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Google Maps with Sublayer](../images/MapProviders/Google-maps/google-maps-sublayer.PNG)

## Enabling legend

{% if page.publishingplatform == "aspnet-core" %}

The legend can be added to the tile Maps by setting the [Visible](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLegendSettings.html#Syncfusion_EJ2_Maps_MapsLegendSettings_Visible) property of [LegendSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.Maps.html#Syncfusion_EJ2_Maps_Maps_LegendSettings) to **true**.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/google-maps/legend/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="GoogleMapsLegend.cs" %}
{% include code-snippet/maps/map-providers/google-maps/legend/google-maps-legend.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

The legend can be added to the tile Maps by setting the [Visible](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLegendSettings.html#Syncfusion_EJ2_Maps_MapsLegendSettings_Visible) property of [LegendSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.Maps.html#Syncfusion_EJ2_Maps_Maps_LegendSettings) to **true**.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/google-maps/legend/razor %}
{% endhighlight %}
{% highlight c# tabtitle="GoogleMapsLegend.cs" %}
{% include code-snippet/maps/map-providers/google-maps/legend/google-maps-legend.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Google Maps with Legend](../images/MapProviders/Google-maps/google-maps-legend.PNG)
