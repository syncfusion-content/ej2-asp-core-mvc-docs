---
layout: post
title: ArcGIS in Syncfusion ##Platform_Name## Syncfusion Maps Component
description: Learn here all about ArcGIS in the Syncfusion ##Platform_Name## Maps component and much more details.
platform: ej2-asp-core-mvc
control: ArcGIS
publishingplatform: ##Platform_Name##
documentation: ug
---

# ArcGIS in ##Platform_Name## Maps Component

{% if page.publishingplatform == "aspnet-core" %}

ArcGIS is another online Maps provider, owned by Esri (Environmental Systems Research Institute). As like OSM and Bing Maps, it provides Maps tile images based on our requests and combines those images into a single one to display Maps area. The ArcGIS can be rendered from online map service providers by specifying the URL provided by those providers in the [urlTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_UrlTemplate) property. The URL template is designed to enable seamless integration of ArcGIS online map services, allowing users to preview their maps in the Syncfusion Maps Component.

{% elsif page.publishingplatform == "aspnet-mvc" %}

ArcGIS is another online Maps provider, owned by Esri (Environmental Systems Research Institute). As like OSM and Bing Maps, it provides Maps tile images based on our requests and combines those images into a single one to display Maps area. The ArcGIS can be rendered from online map service providers by specifying the URL provided by those providers in the [UrlTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_UrlTemplate) property. The URL template is designed to enable seamless integration of ArcGIS online map services, allowing users to preview their maps in the Syncfusion Maps Component.

{% endif %}

## Adding ArcGIS

The ArcGIS map tile service can be accessed via the following URL:
https://ibasemaps-api.arcgis.com/arcgis/rest/services/World_Imagery/MapServer/tile/{z}/{y}/{x}?apiKey=Your_Key

In the above URL template,

* {z} - It represents the zoom level of the map.
* {x} - It represents the horizontal position of the tile.
* {y} - It represents the vertical position of the tile. 

These placeholders are replaced by **level**, **tileX**, and **tileY**, respectively, to fetch the correct map tile.

>You can refer this documentation [link](https://www.esri.com/arcgis-blog/products/developers/developers/open-source-developers-time-to-upgrade-to-the-new-arcgis-basemap-layer-service/) for the latest URL template for ArcGIS.

The subscription_key is required and must be included in the URL to authenticate and access the map tiles. Follow the steps in this [link](https://developers.arcgis.com/documentation/security-and-authentication/api-key-authentication/tutorials/create-an-api-key/) to generate an API key, and then added the key to the URL.

{% if page.publishingplatform == "aspnet-core" %}

In the follwing example, the ArcGIS can be rendered using the [urlTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_UrlTemplate) property with the tile server URL provided by online map providers.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/arcgis/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ArcGIS.cs" %}
{% include code-snippet/maps/map-providers/arcgis/arcgis.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

In the follwing example, the ArcGIS can be rendered using the [UrlTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_UrlTemplate) property with the tile server URL provided by online map providers.

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

The ArcGIS layer can be zoomed and panned. Zooming helps to get a closer look at a particular area on a map for in-depth analysis. Panning helps to move a map around to focus the targeted area.

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

Markers can be added to the layers of ArcGIS by setting the corresponding location's coordinates of latitude and longitude using [MarkerSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_MarkerSettings). Navigation lines can be added on top of the ArcGIS layer for highlighting a path among various places by setting the corresponding location's coordinates of latitude and longitude in the [NavigationLineSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_NavigationLineSettings).

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/arcgismarker/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ArcGISMarker.cs" %}
{% include code-snippet/maps/map-providers/arcgismarker/arcgismarker.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

Markers can be added to the layers of ArcGIS by setting the corresponding location's coordinates of latitude and longitude using [MarkerSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_MarkerSettings). Navigation lines can be added on top of the ArcGIS layer for highlighting a path among various places by setting the corresponding location's coordinates of latitude and longitude in the [NavigationLineSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_NavigationLineSettings).

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

Any GeoJSON shape can be rendered as a sublayer on top of the ArcGIS layer for highlighting a particular continent or country in ArcGIS by adding another layer and specifying the [Type](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_Type) property of Maps layer to **SubLayer**.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/arcgissublayer/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ArcGISSubLayer.cs" %}
{% include code-snippet/maps/map-providers/arcgissublayer/arcgissublayer.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

Any GeoJSON shape can be rendered as a sublayer on top of the ArcGIS layer for highlighting a particular continent or country in ArcGIS by adding another layer and specifying the [Type](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_Type) property of Maps layer to **SubLayer**.

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

The legend can be added to the tile Maps by setting the [Visible](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLegendSettings.html#Syncfusion_EJ2_Maps_MapsLegendSettings_Visible) property of [LegendSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.Maps.html#Syncfusion_EJ2_Maps_Maps_LegendSettings) to **true**.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/arcgislegend/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ArcGISLegend.cs" %}
{% include code-snippet/maps/map-providers/arcgislegend/arcgislegend.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

The legend can be added to the tile Maps by setting the [Visible](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLegendSettings.html#Syncfusion_EJ2_Maps_MapsLegendSettings_Visible) property of [LegendSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.Maps.html#Syncfusion_EJ2_Maps_Maps_LegendSettings) to **true**.

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
