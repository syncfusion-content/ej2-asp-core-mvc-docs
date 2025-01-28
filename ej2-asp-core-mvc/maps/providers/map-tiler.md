---
layout: post
title: MapTiler map in Syncfusion ##Platform_Name## Syncfusion Maps Component
description: Learn here all about displaying MapTiler map in the Syncfusion ##Platform_Name## Maps component and much more details.
platform: ej2-asp-core-mvc
control: MapTiler map
publishingplatform: ##Platform_Name##
documentation: ug
---

# MapTiler in ##Platform_Name## Maps Component

{% if page.publishingplatform == "aspnet-core" %}

MapTiler, an online map provider, owned by MapTiler AG, a Swiss companyoffers map tile images based on user requests. The Syncfusion EJ2 Maps control then combines these images into a single display to present the map. To display an MapTiler map, you can specify its tile service URL in the [urlTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_UrlTemplate) property.

{% elsif page.publishingplatform == "aspnet-mvc" %}

MapTiler, an online map provider, owned by MapTiler AG, a Swiss company, offers map tile images based on user requests. The Syncfusion EJ2 Maps control then combines these images into a single display to present the map. To display an MapTiler map, you can specify its tile service URL in the [UrlTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_UrlTemplate) property.

{% endif %}

## Displaying MapTiler

The MapTiler map tile service can be accessed via the following URL:
https://api.maptiler.com/tiles/satellite-v2/{z}/{x}/{y}.jpg?key=Your_Key

In the above URL template,

* {z} - It represents the zoom level of the map.
* {x} - It represents the horizontal position of the tile.
* {y} - It represents the vertical position of the tile. 

These placeholders are replaced by **level**, **tileX**, and **tileY**, respectively, to retrieve the correct map tile.

N> You can refer this documentation [link](https://docs.maptiler.com/cloud/api/tiles/#xyz-tiles) for the latest URL template for MapTiler.

The **subscription_key** is required and must be included in the URL to authenticate and access the map tiles. Follow the steps in this [link](https://docs.maptiler.com/cloud/api/authentication-key/#api-key) to generate an API key, and then add this key to the URL.

{% if page.publishingplatform == "aspnet-core" %}

In the following example, the MapTiler map is displayed by setting [urlTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_UrlTemplate) property with its tile server URL.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/maptiler/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="MapTiler.cs" %}
{% include code-snippet/maps/map-providers/maptiler/maptiler.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

In the following example, the MapTiler can be rendered using the [UrlTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_UrlTemplate) property with its tile server URL.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/maptiler/razor %}
{% endhighlight %}
{% highlight c# tabtitle="MapTiler.cs" %}
{% include code-snippet/maps/map-providers/maptiler/maptiler.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![MapTiler](../images/MapProviders/MapTiler/maptiler.png)

## Enabling zooming and panning

The MapTiler map layer supports both zooming and panning. Zooming allows you to take a closer look at a particular area on the map for in-depth analysis, while panning enables you to move the map around to focus on the target area.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/maptiler-zoom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="MapTilerZoom.cs" %}
{% include code-snippet/maps/map-providers/maptiler-zoom/maptiler-zoom.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/maptiler-zoom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="MapTilerZoom.cs" %}
{% include code-snippet/maps/map-providers/maptiler-zoom/maptiler-zoom.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![MapTiler with Zooming and Panning](../images/MapProviders/MapTiler/maptiler-zooming.png)

## Adding markers and navigation line

{% if page.publishingplatform == "aspnet-core" %}

Markers can be added to the MapTiler map layer by setting the latitude and longitude coordinates of the desired location using [MarkerSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_MarkerSettings).Additionally, navigation lines can be added on top of the MapTiler map layer to highlight paths between various places by specifying the corresponding latitude and longitude coordinates in the [NavigationLineSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_NavigationLineSettings).

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/maptiler-marker/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="MapTilerMarker.cs" %}
{% include code-snippet/maps/map-providers/maptiler-marker/maptiler-marker.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

Markers can be added to the MapTiler map layer by setting the latitude and longitude coordinates of the desired location using [MarkerSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_MarkerSettings). Additionally, navigation lines can be added on top of the MapTiler map layer to highlight paths between various places by specifying the corresponding latitude and longitude coordinates in the [NavigationLineSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_NavigationLineSettings).

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/maptiler-marker/razor %}
{% endhighlight %}
{% highlight c# tabtitle="MapTilerMarker.cs" %}
{% include code-snippet/maps/map-providers/maptiler-marker/maptiler-marker.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![MapTiler with Markers and Navigation Line](../images/MapProviders/MapTiler/maptiler-marker-and-line.png)

## Adding sublayer

{% if page.publishingplatform == "aspnet-core" %}

Any GeoJSON shape can be rendered as a sublayer on top of the MapTiler layer to highlight a particular continent or country. This is achieved by adding another layer and setting the [Type](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_Type) property of Maps layer to **SubLayer**.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/maptiler-sublayer/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="MapTilerSubLayer.cs" %}
{% include code-snippet/maps/map-providers/maptiler-sublayer/maptiler-sublayer.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

Any GeoJSON shape can be rendered as a sublayer on top of the MapTiler layer to highlight a particular continent or country. This is achieved by adding another layer and setting the [Type](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_Type) property of Maps layer to **SubLayer**.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/maptiler-sublayer/razor %}
{% endhighlight %}
{% highlight c# tabtitle="MapTilerSubLayer.cs" %}
{% include code-snippet/maps/map-providers/maptiler-sublayer/maptiler-sublayer.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![MapTiler with Sublayer](../images/MapProviders/MapTiler/maptiler-sublayer.png)

## Enabling legend

{% if page.publishingplatform == "aspnet-core" %}

The legend can be added to the tile Maps by setting the [Visible](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLegendSettings.html#Syncfusion_EJ2_Maps_MapsLegendSettings_Visible) property of [LegendSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.Maps.html#Syncfusion_EJ2_Maps_Maps_LegendSettings) to **true**.

In the example below, the legend is added to the markers on the MapTiler map layer.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/maptiler-legend/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="MapTilerLegend.cs" %}
{% include code-snippet/maps/map-providers/maptiler-legend/maptiler-legend.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

The legend can be added to the tile Maps by setting the [Visible](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLegendSettings.html#Syncfusion_EJ2_Maps_MapsLegendSettings_Visible) property of [LegendSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.Maps.html#Syncfusion_EJ2_Maps_Maps_LegendSettings) to **true**.

In the example below, the legend is added to the markers on the MapTiler map layer.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/maptiler-legend/razor %}
{% endhighlight %}
{% highlight c# tabtitle="MapTilerLegend.cs" %}
{% include code-snippet/maps/map-providers/maptiler-legend/maptiler-legend.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![MapTiler with Legend](../images/MapProviders/MapTiler/maptiler-legend.png)
