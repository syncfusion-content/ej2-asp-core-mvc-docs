---
layout: post
title: ArcGIS map in Syncfusion ##Platform_Name## Syncfusion Maps Component
description: Learn here all about displayin ArcGIS map in the Syncfusion ##Platform_Name## Maps component and much more details.
platform: ej2-asp-core-mvc
control: ArcGIS map
publishingplatform: ##Platform_Name##
documentation: ug
---

# ArcGIS map in ##Platform_Name## Maps Component

{% if page.publishingplatform == "aspnet-core" %}

ArcGIS, an online map provider owned by Esri (Environmental Systems Research Institute), offers map tile images based on user requests. The Syncfusion Maps component then combines these images into a single display to present the map. To display an ArcGIS map, you can specify its tile service URL in the [urlTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_UrlTemplate) property.

{% elsif page.publishingplatform == "aspnet-mvc" %}

ArcGIS, an online map provider owned by Esri (Environmental Systems Research Institute), offers map tile images based on user requests. The Syncfusion EJ2 Maps component then combines these images into a single display to present the map. To display an ArcGIS map, you can specify its tile service URL in the [UrlTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_UrlTemplate) property.

{% endif %}

## Displaying ArcGIS map

The ArcGIS map tile service can be accessed via the following URL:
https://ibasemaps-api.arcgis.com/arcgis/rest/services/World_Imagery/MapServer/tile/{z}/{y}/{x}?apiKey=Your_Key

In the above URL template,

* {z} - It represents the zoom level of the map.
* {x} - It represents the horizontal position of the tile.
* {y} - It represents the vertical position of the tile. 

These placeholders are replaced by **level**, **tileX**, and **tileY**, respectively, to retrieve the correct map tile.

N> You can refer this documentation [link](https://www.esri.com/arcgis-blog/products/developers/developers/open-source-developers-time-to-upgrade-to-the-new-arcgis-basemap-layer-service/) for the latest URL template for ArcGIS.

The **subscription_key** is required and must be included in the URL to authenticate and access the map tiles. Follow the steps in this [link](https://developers.arcgis.com/documentation/security-and-authentication/api-key-authentication/tutorials/create-an-api-key/) to generate an API key, and then add this key to the URL.

{% if page.publishingplatform == "aspnet-core" %}

In the following example, the ArcGIS map is displayed by setting [urlTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_UrlTemplate) property with its tile server URL.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/arcgis/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ArcGIS.cs" %}
{% include code-snippet/maps/map-providers/arcgis/arcgis.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

In the following example, the ArcGIS map is displayed by setting the [UrlTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_UrlTemplate) property with its tile server URL.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/arcgis/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ArcGIS.cs" %}
{% include code-snippet/maps/map-providers/arcgis/arcgis.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![ArcGIS](../images/MapProviders/Arcgis/arcgis.PNG)

## Enabling zooming and panning

The ArcGIS map layer supports both zooming and panning. Zooming allows you to take a closer look at a particular area on the map for in-depth analysis, while panning enables you to move the map around to focus on the target area.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/arcgiszoom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ArcGISZoom.cs" %}
{% include code-snippet/maps/map-providers/arcgiszoom/arcgiszoom.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/arcgiszoom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ArcGISZoom.cs" %}
{% include code-snippet/maps/map-providers/arcgiszoom/arcgiszoom.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![ArcGIS with Zooming and Panning](../images/MapProviders/Arcgis/arcgis-zooming.PNG)

## Adding markers and navigation line

{% if page.publishingplatform == "aspnet-core" %}

Markers can be added to the ArcGIS map layer by setting the latitude and longitude coordinates of the desired location using [MarkerSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_MarkerSettings). Additionally, navigation lines can be added on top of the ArcGIS layer to highlight paths between various places by specifying the corresponding latitude and longitude coordinates in the [NavigationLineSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_NavigationLineSettings).

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/arcgismarker/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ArcGISMarker.cs" %}
{% include code-snippet/maps/map-providers/arcgismarker/arcgismarker.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

Markers can be added to the ArcGIS map layer by setting the latitude and longitude coordinates of the desired location using [MarkerSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_MarkerSettings). Additionally, navigation lines can be added on top of the ArcGIS layer to highlight paths between various places by specifying the corresponding latitude and longitude coordinates in the [NavigationLineSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_NavigationLineSettings).

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/arcgismarker/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ArcGISMarker.cs" %}
{% include code-snippet/maps/map-providers/arcgismarker/arcgismarker.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![ArcGIS with Markers and Navigation Line](../images/MapProviders/Arcgis/arcgis-marker-and-line.PNG)

## Adding sublayer

{% if page.publishingplatform == "aspnet-core" %}

Any GeoJSON shape can be rendered as a sublayer on top of the ArcGIS layer to highlight a particular continent or country. This is achieved by adding another layer and setting the [Type](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_Type) property of Maps layer to **SubLayer**.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/arcgissublayer/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ArcGISSubLayer.cs" %}
{% include code-snippet/maps/map-providers/arcgissublayer/arcgissublayer.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

Any GeoJSON shape can be rendered as a sublayer on top of the ArcGIS layer to highlight a particular continent or country. This is achieved by adding another layer and setting the [Type](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_Type) property of Maps layer to **SubLayer**.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/arcgissublayer/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ArcGISSubLayer.cs" %}
{% include code-snippet/maps/map-providers/arcgissublayer/arcgissublayer.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![ArcGIS with Sublayer](../images/MapProviders/Arcgis/arcgis-sublayer.PNG)

## Enabling legend

{% if page.publishingplatform == "aspnet-core" %}

A legend can be added to the ArcGIS map by setting the [Visible](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLegendSettings.html#Syncfusion_EJ2_Maps_MapsLegendSettings_Visible) property of [LegendSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.Maps.html#Syncfusion_EJ2_Maps_Maps_LegendSettings) to **true**.

In the example below, the legend is added to the markers on the ArcGIS map layer.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/arcgislegend/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ArcGISLegend.cs" %}
{% include code-snippet/maps/map-providers/arcgislegend/arcgislegend.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

A legend can be added to the ArcGIS map by setting the [Visible](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLegendSettings.html#Syncfusion_EJ2_Maps_MapsLegendSettings_Visible) property of [LegendSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.Maps.html#Syncfusion_EJ2_Maps_Maps_LegendSettings) to **true**.

In the example below, the legend is added to the markers on the ArcGIS map layer.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/arcgislegend/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ArcGISLegend.cs" %}
{% include code-snippet/maps/map-providers/arcgislegend/arcgislegend.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![ArcGIS with Legend](../images/MapProviders/Arcgis/arcgis-legend.PNG)
