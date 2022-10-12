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

Azure Maps is yet another online Maps provider, owned by Microsoft. As like OSM and Bing Maps, it provides Maps tile images based on our requests and combines those images into a single one to display Maps area.

## Adding Azure Maps

{% if page.publishingplatform == "aspnet-core" %}

The Azure Maps can be rendered using the [`UrlTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_UrlTemplate) property with the tile server URL provided by online map providers. In the meantime, a subscription key is required for Azure Maps. Follow the steps in this [`link`](https://docs.microsoft.com/en-us/azure/search/search-security-api-keys) to generate an API key, and then added the key to the URL.

>Refer to [Azure Maps Licensing](https://azure.microsoft.com/en-in/support/legal/).

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/azure/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Azure.cs" %}
{% include code-snippet/maps/map-providers/azure/azure.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

The Azure Maps can be rendered using the [`UrlTemplate`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_UrlTemplate) property with the tile server URL provided by online map providers. In the meantime, a subscription key is required for Azure Maps. Follow the steps in this [`link`](https://docs.microsoft.com/en-us/azure/search/search-security-api-keys) to generate an API key, and then added the key to the URL.

>Refer to [Azure Maps Licensing](https://azure.microsoft.com/en-in/support/legal/).

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/azure/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Azure.cs" %}
{% include code-snippet/maps/map-providers/azure/azure.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Azure Maps](../images/MapProviders/azure-maps.PNG)

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

![Azure Maps with Zooming](../images/MapProviders/azure-maps-zooming.PNG)

## Adding markers and navigation line

{% if page.publishingplatform == "aspnet-core" %}

Markers can be added to the layers of Azure Maps by setting the corresponding location's coordinates of latitude and longitude using [`MarkerSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_MarkerSettings). Navigation lines can be added on top of the Azure Maps layer for highlighting a path among various places by setting the corresponding location's coordinates of latitude and longitude in the [`NavigationLineSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_NavigationLineSettings).

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/azuremarker/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="AzureMarker.cs" %}
{% include code-snippet/maps/map-providers/azuremarker/azuremarker.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

Markers can be added to the layers of Azure Maps by setting the corresponding location's coordinates of latitude and longitude using [`MarkerSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_MarkerSettings). Navigation lines can be added on top of the Azure Maps layer for highlighting a path among various places by setting the corresponding location's coordinates of latitude and longitude in the [`NavigationLineSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_NavigationLineSettings).

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/azuremarker/razor %}
{% endhighlight %}
{% highlight c# tabtitle="AzureMarker.cs" %}
{% include code-snippet/maps/map-providers/azuremarker/azuremarker.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Azure Maps with Markers and Navigation Line](../images/MapProviders/azure-maps-marker-and-line.PNG)

## Adding sublayer

{% if page.publishingplatform == "aspnet-core" %}

Any GeoJSON shape can be rendered as a sublayer on top of the Azure Maps layer for highlighting a particular continent or country in Azure Maps by adding another layer and specifying the [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_Type) property of Maps layer to **SubLayer**.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/azuresublayer/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="AzureSubLayer.cs" %}
{% include code-snippet/maps/map-providers/azuresublayer/azuresublayer.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

Any GeoJSON shape can be rendered as a sublayer on top of the Azure Maps layer for highlighting a particular continent or country in Azure Maps by adding another layer and specifying the [`Type`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_Type) property of Maps layer to **SubLayer**.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/azuresublayer/razor %}
{% endhighlight %}
{% highlight c# tabtitle="AzureSubLayer.cs" %}
{% include code-snippet/maps/map-providers/azuresublayer/azuresublayer.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Azure Maps with Sublayer](../images/MapProviders/azure-map-sublayer.PNG)

## Enabling legend

{% if page.publishingplatform == "aspnet-core" %}

The legend can be added to the tile Maps by setting the [`Visible`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLegendSettings.html#Syncfusion_EJ2_Maps_MapsLegendSettings_Visible) property of [`LegendSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.Maps.html#Syncfusion_EJ2_Maps_Maps_LegendSettings) to **true**.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/azurelegend/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="AzureLegend.cs" %}
{% include code-snippet/maps/map-providers/azurelegend/azurelegend.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

The legend can be added to the tile Maps by setting the [`Visible`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLegendSettings.html#Syncfusion_EJ2_Maps_MapsLegendSettings_Visible) property of [`LegendSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.Maps.html#Syncfusion_EJ2_Maps_Maps_LegendSettings) to **true**.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/azurelegend/razor %}
{% endhighlight %}
{% highlight c# tabtitle="AzureLegend.cs" %}
{% include code-snippet/maps/map-providers/azurelegend/azurelegend.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Azure Maps with Legend](../images/MapProviders/azure-map-legend.PNG)
