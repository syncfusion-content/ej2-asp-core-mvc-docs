---
layout: post
title: Map Providers in ##Platform_Name## Maps Component
description: Learn here all about Map Providers in Syncfusion ##Platform_Name## Maps component and more.
platform: ej2-asp-core-mvc
control: Map Providers
publishingplatform: ##Platform_Name##
documentation: ug
---

# Map Providers

Maps component supports map providers such as OpenStreetMap that can be added to any layers in maps.

## Open Street Map

OpenStreetMap(OSM) is a online map provider. The OpenStreetMap allows you to view, edit and use geographical data in a collaborative way from any place on the Earth. One of the most important features in Maps component is the built-in online map provider support. By using this feature, you can render OpenStreetMap in the maps component. This provides the ability to visualize street map tiles without using any external shape files.

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



## Bing Maps

Bing Maps is a online map provider for accessing the external geospatial imagery services for deep-zoom satellite view which is supported in the Maps component. This provides the ability to visualize satellite, aerial, and street maps without using any external shape files.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/bing/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Bing.cs" %}
{% include code-snippet/maps/map-providers/bing/bing.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/bing/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Bing.cs" %}
{% include code-snippet/maps/map-providers/bing/bing.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

