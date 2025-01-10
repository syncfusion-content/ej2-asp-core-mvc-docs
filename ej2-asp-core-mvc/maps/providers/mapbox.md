---
layout: post
title: Mapbox in Syncfusion ##Platform_Name## Syncfusion Maps Component
description: Learn here all about Mapbox in the Syncfusion ##Platform_Name## Maps component and much more details.
platform: ej2-asp-core-mvc
control: Mapbox
publishingplatform: ##Platform_Name##
documentation: ug
---

# Mapbox in ##Platform_Name## Maps Component

{% if page.publishingplatform == "aspnet-core" %}

Mapbox is another online Maps provider, owned by Mapbox, Inc. As like OSM and Bing Maps, it provides Maps tile images based on our requests and combines those images into a single one to display Maps area. The Mapbox can be rendered from online map service providers by specifying the URL provided by those providers in the [urlTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_UrlTemplate) property. The URL template is designed to enable seamless integration of Mapbox online map services, allowing users to preview their maps in the Syncfusion EJ2 Maps Component.

{% elsif page.publishingplatform == "aspnet-mvc" %}

Mapbox is another online Maps provider, owned by Mapbox, Inc. As like OSM and Bing Maps, it provides Maps tile images based on our requests and combines those images into a single one to display Maps area. The Mapbox can be rendered from online map service providers by specifying the URL provided by those providers in the [UrlTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_UrlTemplate) property. The URL template is designed to enable seamless integration of Mapbox online map services, allowing users to preview their maps in the Syncfusion EJ2 Maps Component.
{% endif %}

## Adding Mapbox

The Mapbox map tile service can be accessed via the following URL:
https://api.mapbox.com/v4/mapbox.satellite/{zoom}/{x}/{y}.jpg?access_token=Your_Key

In the above URL template,

* {zoom} - It represents the zoom level of the map.
* {x} - It represents the horizontal position of the tile.
* {y} - It represents the vertical position of the tile. 

These placeholders are replaced by **level**, **tileX**, and **tileY**, respectively, to fetch the correct map tile. 

>You can refer this documentation [link](https://docs.mapbox.com/api/maps/raster-tiles/) for the latest URL template for Mapbox.

The subscription_key is required and must be included in the URL to authenticate and access the map tiles. Follow the steps in this [link](https://docs.mapbox.com/help/dive-deeper/access-tokens/#creating-secret-access-tokens) to generate an API key, and then added the key to the URL.

{% if page.publishingplatform == "aspnet-core" %}

In the follwing example, the Mapbox can be rendered using the [urlTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_UrlTemplate) property with the tile server URL provided by online map providers.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/mapbox-maps/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Mapbox.cs" %}
{% include code-snippet/maps/map-providers/mapbox/mapbox.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

In the follwing example, the Mapbox can be rendered using the [UrlTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_UrlTemplate) property with the tile server URL provided by online map providers.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/mapbox-maps/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Mapbox.cs" %}
{% include code-snippet/maps/map-providers/mapbox/mapbox.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Mapbox](../images/MapProviders/Mapbox/mapbox.PNG)

## Enabling zooming and panning

The Mapbox layer can be zoomed and panned. Zooming helps to get a closer look at a particular area on a map for in-depth analysis. Panning helps to move a map around to focus the targeted area.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/mapbox-maps-zoom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="MapboxZoom.cs" %}
{% include code-snippet/maps/map-providers/mapbox-maps-zoom/mapbox-maps-zoom.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/mapbox-maps-zoom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="MapboxZoom.cs" %}
{% include code-snippet/maps/map-providers/mapbox-maps-zoom/mapbox-maps-zoom.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Mapbox with Zooming and Panning](../images/MapProviders/Mapbox/mapbox-zooming.PNG)

## Adding markers and navigation line

{% if page.publishingplatform == "aspnet-core" %}

Markers can be added to the layers of Mapbox by setting the corresponding location's coordinates of latitude and longitude using [MarkerSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_MarkerSettings). Navigation lines can be added on top of the Mapbox layer for highlighting a path among various places by setting the corresponding location's coordinates of latitude and longitude in the [NavigationLineSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_NavigationLineSettings).

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/mapbox-maps-marker/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="MapboxMarker.cs" %}
{% include code-snippet/maps/map-providers/mapbox-maps-marker/mapbox-maps-marker.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

Markers can be added to the layers of Mapbox by setting the corresponding location's coordinates of latitude and longitude using [MarkerSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_MarkerSettings). Navigation lines can be added on top of the Mapbox layer for highlighting a path among various places by setting the corresponding location's coordinates of latitude and longitude in the [NavigationLineSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_NavigationLineSettings).

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/mapbox-maps-marker/razor %}
{% endhighlight %}
{% highlight c# tabtitle="MapboxMarker.cs" %}
{% include code-snippet/maps/map-providers/mapbox-maps-marker/mapbox-maps-marker.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Mapbox with Markers and Navigation Line](../images/MapProviders/Mapbox/mapbox-marker-and-line.PNG)

## Adding sublayer

{% if page.publishingplatform == "aspnet-core" %}

Any GeoJSON shape can be rendered as a sublayer on top of the Mapbox layer for highlighting a particular continent or country in Mapbox by adding another layer and specifying the [Type](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_Type) property of Maps layer to **SubLayer**.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/mapbox-maps-sublayer/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="MapboxSubLayer.cs" %}
{% include code-snippet/maps/map-providers/mapbox-maps-sublayer/mapbox-maps-sublayer.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

Any GeoJSON shape can be rendered as a sublayer on top of the Mapbox layer for highlighting a particular continent or country in Mapbox by adding another layer and specifying the [Type](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_Type) property of Maps layer to **SubLayer**.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/mapbox-maps-sublayer/razor %}
{% endhighlight %}
{% highlight c# tabtitle="MapboxSubLayer.cs" %}
{% include code-snippet/maps/map-providers/mapbox-maps-sublayer/mapbox-maps-sublayer.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Mapbox with Sublayer](../images/MapProviders/Mapbox/mapbox-sublayer.PNG)

## Enabling legend

{% if page.publishingplatform == "aspnet-core" %}

The legend can be added to the tile Maps by setting the [Visible](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLegendSettings.html#Syncfusion_EJ2_Maps_MapsLegendSettings_Visible) property of [LegendSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.Maps.html#Syncfusion_EJ2_Maps_Maps_LegendSettings) to **true**.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/mapbox-maps-legend/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="MapboxLegend.cs" %}
{% include code-snippet/maps/map-providers/mapbox-maps-legend/mapbox-maps-legend.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

The legend can be added to the tile Maps by setting the [Visible](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLegendSettings.html#Syncfusion_EJ2_Maps_MapsLegendSettings_Visible) property of [LegendSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.Maps.html#Syncfusion_EJ2_Maps_Maps_LegendSettings) to **true**.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/mapbox-maps-legend/razor %}
{% endhighlight %}
{% highlight c# tabtitle="MapboxLegend.cs" %}
{% include code-snippet/maps/map-providers/mapbox-maps-legend/mapbox-maps-legend.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Mapbox with Legend](../images/MapProviders/Mapbox/mapbox-legend.PNG)
