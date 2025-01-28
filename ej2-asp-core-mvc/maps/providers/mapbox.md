---
layout: post
title: Mapbox in Syncfusion ##Platform_Name## Syncfusion Maps Component
description: Learn here all about displaying Mapbox in the Syncfusion ##Platform_Name## Maps component and much more details.
platform: ej2-asp-core-mvc
control: Mapbox
publishingplatform: ##Platform_Name##
documentation: ug
---

# Mapbox in ##Platform_Name## Maps Component

{% if page.publishingplatform == "aspnet-core" %}

Mapbox, an online map provider, owned by Mapbox, Inc, offers map tile images based on user requests. The Syncfusion EJ2 Maps control then combines these images into a single display to present the map. To display an Mapbox map, you can specify its tile service URL in the [urlTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_UrlTemplate) property.

{% elsif page.publishingplatform == "aspnet-mvc" %}

Mapbox, an online map provider, owned by Mapbox, Inc, offers map tile images based on user requests. The Syncfusion EJ2 Maps control then combines these images into a single display to present the map. To display an Mapbox map, you can specify its tile service URL in the [UrlTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_UrlTemplate) property. 

{% endif %}

## Displaying Mapbox

The Mapbox map tile service can be accessed via the following URL:
https://api.mapbox.com/v4/mapbox.satellite/{zoom}/{x}/{y}.jpg?access_token=Your_Key

In the above URL template,

* {zoom} - It represents the zoom level of the map.
* {x} - It represents the horizontal position of the tile.
* {y} - It represents the vertical position of the tile. 

These placeholders are replaced by **level**, **tileX**, and **tileY**, respectively, to retrieve the correct map tile.

N> You can refer this documentation [link](https://docs.mapbox.com/api/maps/raster-tiles/) for the latest URL template for Mapbox.

The **subscription_key** is required and must be included in the URL to authenticate and access the map tiles. Follow the steps in this [link](https://docs.mapbox.com/help/dive-deeper/access-tokens/#creating-secret-access-tokens) to generate an API key, and then add this key to the URL.

{% if page.publishingplatform == "aspnet-core" %}

In the following example, the Mapbox map is displayed by setting [urlTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_UrlTemplate) property with its tile server URL.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/mapbox/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Mapbox.cs" %}
{% include code-snippet/maps/map-providers/mapbox/mapbox.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

In the following example, the Mapbox map is displayed by setting [UrlTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_UrlTemplate) property with its tile server URL.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/mapbox/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Mapbox.cs" %}
{% include code-snippet/maps/map-providers/mapbox/mapbox.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Mapbox](../images/MapProviders/Mapbox/mapbox.png)

## Enabling zooming and panning

The Mapbox map layer supports both zooming and panning. Zooming allows you to take a closer look at a particular area on the map for in-depth analysis, while panning enables you to move the map around to focus on the target area.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/mapbox-zoom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="MapboxZoom.cs" %}
{% include code-snippet/maps/map-providers/mapbox-zoom/mapbox-zoom.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/mapbox-zoom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="MapboxZoom.cs" %}
{% include code-snippet/maps/map-providers/mapbox-zoom/mapbox-zoom.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Mapbox with Zooming and Panning](../images/MapProviders/Mapbox/mapbox-zooming.png)

## Adding markers and navigation line

{% if page.publishingplatform == "aspnet-core" %}

Markers can be added to the Mapbox map layer by setting the latitude and longitude coordinates of the desired location using [MarkerSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_MarkerSettings). Additionally, navigation lines can be added on top of the Mapbox map layer to highlight paths between various places by specifying the corresponding latitude and longitude coordinates in the [NavigationLineSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_NavigationLineSettings).

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/mapbox-marker/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="MapboxMarker.cs" %}
{% include code-snippet/maps/map-providers/mapbox-marker/mapbox-marker.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

Markers can be added to the Mapbox map layer by setting the latitude and longitude coordinates of the desired location using [MarkerSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_MarkerSettings). Additionally, navigation lines can be added on top of the Mapbox map layer to highlight paths between various places by specifying the corresponding latitude and longitude coordinates in the [NavigationLineSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_NavigationLineSettings).

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/mapbox-marker/razor %}
{% endhighlight %}
{% highlight c# tabtitle="MapboxMarker.cs" %}
{% include code-snippet/maps/map-providers/mapbox-marker/mapbox-marker.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Mapbox with Markers and Navigation Line](../images/MapProviders/Mapbox/mapbox-marker-and-line.png)

## Adding sublayer

{% if page.publishingplatform == "aspnet-core" %}

Any GeoJSON shape can be rendered as a sublayer on top of the Mapbox layer to highlight a particular continent or country. This is achieved by adding another layer and setting the [Type](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_Type) property of Maps layer to **SubLayer**.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/mapbox-sublayer/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="MapboxSubLayer.cs" %}
{% include code-snippet/maps/map-providers/mapbox-sublayer/mapbox-sublayer.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

Any GeoJSON shape can be rendered as a sublayer on top of the Mapbox layer to highlight a particular continent or country. This is achieved by adding another layer and setting the [Type](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_Type) property of Maps layer to **SubLayer**.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/mapbox-sublayer/razor %}
{% endhighlight %}
{% highlight c# tabtitle="MapboxSubLayer.cs" %}
{% include code-snippet/maps/map-providers/mapbox-sublayer/mapbox-sublayer.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Mapbox with Sublayer](../images/MapProviders/Mapbox/mapbox-sublayer.png)

## Enabling legend

{% if page.publishingplatform == "aspnet-core" %}

The legend can be added to the tile Maps by setting the [Visible](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLegendSettings.html#Syncfusion_EJ2_Maps_MapsLegendSettings_Visible) property of [LegendSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.Maps.html#Syncfusion_EJ2_Maps_Maps_LegendSettings) to **true**.

In the example below, the legend is added to the markers on the Mapbox map layer.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/mapbox-legend/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="MapboxLegend.cs" %}
{% include code-snippet/maps/map-providers/mapbox-legend/mapbox-legend.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

The legend can be added to the tile Maps by setting the [Visible](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLegendSettings.html#Syncfusion_EJ2_Maps_MapsLegendSettings_Visible) property of [LegendSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.Maps.html#Syncfusion_EJ2_Maps_Maps_LegendSettings) to **true**.

In the example below, the legend is added to the markers on the Mapbox map layer.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/mapbox-legend/razor %}
{% endhighlight %}
{% highlight c# tabtitle="MapboxLegend.cs" %}
{% include code-snippet/maps/map-providers/mapbox-legend/mapbox-legend.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Mapbox with Legend](../images/MapProviders/Mapbox/mapbox-legend.png)
