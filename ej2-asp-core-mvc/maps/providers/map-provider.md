---
layout: post
title: Map Provider in ##Platform_Name## Maps Component
description: Learn here all about Map Provider in Syncfusion ##Platform_Name## Maps component and more.
platform: ej2-asp-core-mvc
control: Map Provider
publishingplatform: ##Platform_Name##
documentation: ug
---

# OpenStreetMaps

The OpenStreetMap (OSM) is the online Maps provider built by a community of developers; it is free to use under an open license. It allows to view geographical data in a collaborative way from anywhere on the earth. The OSM Maps provides small tile images based on our requests and combines those images into a single image to display the Maps area in the Maps component.

## Adding OpenStreetMap

The OSM Maps can be rendered using by setting the [`layerType`](../api/maps/layerSettingsModel/#layertype) property value as **OSM**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/osm/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Osm.cs" %}
{% include code-snippet/maps/map-providers/osm/osm.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/osm/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Osm.cs" %}
{% include code-snippet/maps/map-providers/osm/osm.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Changing the tile server of the OpenStreetMap

The OSM tile server can be changed by setting the tile URL in the `UrlTemplate` property. For more details about the OSM tile server, refer [here](https://wiki.openstreetmap.org/wiki/Tiles).

## Zooming and Panning

The OSM Maps layer can be zoomed and panned. Zooming helps to get a closer look at a particular area on a Maps for in-depth analysis. Panning helps to move a Maps around to focus the targeted area.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/osmzoom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Osmzoom.cs" %}
{% include code-snippet/maps/map-providers/osmzoom/osmzoom.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/osmzoom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Osmzoom.cs" %}
{% include code-snippet/maps/map-providers/osmzoom/osmzoom.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Adding markers and navigation line

Markers can be added to the layers of OSM Maps by setting the corresponding location's coordinates of latitude and longitude using `MarkerSettings`. Navigation lines can be added on top of an OSM Maps layer for highlighting a path among various places by setting the corresponding location's coordinates of latitude and longitude in the `NavigationLineSettings`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/osmmarker/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Osmmarker.cs" %}
{% include code-snippet/maps/map-providers/osmmarker/osmmarker.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/osmmarker/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Osmmarker.cs" %}
{% include code-snippet/maps/map-providers/osmmarker/osmmarker.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Sublayer

Any GeoJSON shape can be rendered as a sublayer on top of the OSM Maps layer for highlighting a particular continent or country in OSM Maps by adding another layer and specifying the `Type` property of Maps layer to **SubLayer**.