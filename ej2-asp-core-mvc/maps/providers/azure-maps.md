---
layout: post
title: Azure Maps in Syncfusion ##Platform_Name## Syncfusion Maps Component
description: Learn here all about Azure Maps in the Syncfusion ##Platform_Name## Maps component and much more details.
platform: ej2-asp-core-mvc
control: Azure Maps
publishingplatform: ##Platform_Name##
documentation: ug
---

# Azure Maps in ##Platform_Name## Maps Component

{% if page.publishingplatform == "aspnet-core" %}

Azure Maps is another online Maps provider, owned by Microsoft. As like OSM and Bing Maps, it provides Maps tile images based on our requests and combines those images into a single one to display Maps area. The Azure Maps can be rendered from online map service providers by specifying the URL provided by those providers in the [urlTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_UrlTemplate) property. The URL template is designed to enable seamless integration of Azure online map services, allowing users to preview their maps in the Syncfusion Maps Component.

{% elsif page.publishingplatform == "aspnet-mvc" %}

Azure Maps is another online Maps provider, owned by Microsoft. As like OSM and Bing Maps, it provides Maps tile images based on our requests and combines those images into a single one to display Maps area. The Azure Maps can be rendered from online map service providers by specifying the URL provided by those providers in the [UrlTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_UrlTemplate) property. The URL template is designed to enable seamless integration of Azure online map services, allowing users to preview their maps in the Syncfusion Maps Component.
{% endif %}

## Adding Azure Maps

The Azure map tile service can be accessed via the following URL:
https://atlas.microsoft.com/map/tile?api-version=2024-04-01&tilesetId=microsoft.base.road&zoom={zoom}&x={x}&y={y}&subscription-key=Your_Key

In the above URL template,

* {zoom} - It represents the zoom level of the map.
* {x} - It represents the horizontal position of the tile.
* {y} - It represents the vertical position of the tile. 

These placeholders are replaced by **level**, **tileX**, and **tileY**, respectively, to fetch the correct map tile. 

>You can refer this documentation [link](https://learn.microsoft.com/en-us/rest/api/maps/render/get-map-tile?view=rest-maps-2024-04-01&tabs=HTTP) for the latest URL template for Azure Maps.

The subscription_key is required and must be included in the URL to authenticate and access the map tiles. Follow the steps in this [link](https://docs.microsoft.com/en-us/azure/search/search-security-api-keys) to generate an API key, and then added the key to the URL.

>Refer to [Azure Maps Licensing](https://azure.microsoft.com/en-in/support/legal/).

You can customize various tile types in Azure Maps by modifying the **tilesetId** value in the URL. In the example below, the **microsoft.base.road** tile type is specified in the URL, and these tile images can be displayed in the Syncfusion Maps Component. To explore the available tile types in Azure Maps by the following link below.

https://learn.microsoft.com/en-us/rest/api/maps/render/get-map-tile?view=rest-maps-2023-06-01&tabs=HTTP#tilesetid
 
>The Syncfusion Maps only support displaying maps with raster images in **PNG** or **JPG** formats.

{% if page.publishingplatform == "aspnet-core" %}

In the following example, the Azure Maps can be rendered using the [urlTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_UrlTemplate) property with the tile server URL provided by online map providers.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/azure/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Azure.cs" %}
{% include code-snippet/maps/map-providers/azure/azure.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

In the following example, the Azure Maps can be rendered using the [UrlTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_UrlTemplate) property with the tile server URL provided by online map providers.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/azure/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Azure.cs" %}
{% include code-snippet/maps/map-providers/azure/azure.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Azure Maps](../images/MapProviders/Azure-maps/azure-maps-.PNG)

## Enabling zooming and panning

The Azure Maps layer can be zoomed and panned. Zooming helps to get a closer look at a particular area on a map for in-depth analysis. Panning helps to move a map around to focus the targeted area.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/azurezoom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="AzureZoom.cs" %}
{% include code-snippet/maps/map-providers/azurezoom/azurezoom.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/azurezoom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="AzureZoom.cs" %}
{% include code-snippet/maps/map-providers/azurezoom/azurezoom.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Azure Maps with Zooming and Panning](../images/MapProviders/Azure-maps/azure-maps--zooming.PNG)

## Adding markers and navigation line

{% if page.publishingplatform == "aspnet-core" %}

Markers can be added to the layers of Azure Maps by setting the corresponding location's coordinates of latitude and longitude using [MarkerSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_MarkerSettings). Navigation lines can be added on top of the Azure Maps layer for highlighting a path among various places by setting the corresponding location's coordinates of latitude and longitude in the [NavigationLineSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_NavigationLineSettings).

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/azuremarker/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="AzureMarker.cs" %}
{% include code-snippet/maps/map-providers/azuremarker/azuremarker.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

Markers can be added to the layers of Azure Maps by setting the corresponding location's coordinates of latitude and longitude using [MarkerSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_MarkerSettings). Navigation lines can be added on top of the Azure Maps layer for highlighting a path among various places by setting the corresponding location's coordinates of latitude and longitude in the [NavigationLineSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_NavigationLineSettings).

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/azuremarker/razor %}
{% endhighlight %}
{% highlight c# tabtitle="AzureMarker.cs" %}
{% include code-snippet/maps/map-providers/azuremarker/azuremarker.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Azure Maps with Markers and Navigation Line](../images/MapProviders/Azure-maps/azure-maps--marker-and-line.PNG)

## Adding sublayer

{% if page.publishingplatform == "aspnet-core" %}

Any GeoJSON shape can be rendered as a sublayer on top of the Azure Maps layer for highlighting a particular continent or country in Azure Maps by adding another layer and specifying the [Type](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_Type) property of Maps layer to **SubLayer**.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/azuresublayer/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="AzureSubLayer.cs" %}
{% include code-snippet/maps/map-providers/azuresublayer/azuresublayer.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

Any GeoJSON shape can be rendered as a sublayer on top of the Azure Maps layer for highlighting a particular continent or country in Azure Maps by adding another layer and specifying the [Type](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_Type) property of Maps layer to **SubLayer**.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/azuresublayer/razor %}
{% endhighlight %}
{% highlight c# tabtitle="AzureSubLayer.cs" %}
{% include code-snippet/maps/map-providers/azuresublayer/azuresublayer.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Azure Maps with Sublayer](../images/MapProviders/Azure-maps/azure-maps-sublayer.PNG)

## Enabling legend

{% if page.publishingplatform == "aspnet-core" %}

The legend can be added to the tile Maps by setting the [Visible](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLegendSettings.html#Syncfusion_EJ2_Maps_MapsLegendSettings_Visible) property of [LegendSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.Maps.html#Syncfusion_EJ2_Maps_Maps_LegendSettings) to **true**.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/azurelegend/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="AzureLegend.cs" %}
{% include code-snippet/maps/map-providers/azurelegend/azurelegend.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

The legend can be added to the tile Maps by setting the [Visible](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLegendSettings.html#Syncfusion_EJ2_Maps_MapsLegendSettings_Visible) property of [LegendSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.Maps.html#Syncfusion_EJ2_Maps_Maps_LegendSettings) to **true**.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/azurelegend/razor %}
{% endhighlight %}
{% highlight c# tabtitle="AzureLegend.cs" %}
{% include code-snippet/maps/map-providers/azurelegend/azurelegend.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Azure Maps with Legend](../images/MapProviders/Azure-maps/azure-maps-legend.PNG)
