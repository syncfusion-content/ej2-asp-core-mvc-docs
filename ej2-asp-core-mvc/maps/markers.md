---
layout: post
title: Markers in ##Platform_Name## Maps Component
description: Learn here all about Markers in Syncfusion ##Platform_Name## Maps component and more.
platform: ej2-asp-core-mvc
control: Markers
publishingplatform: ##Platform_Name##
documentation: ug
---

# Markers

Markers are notes that are used to leave a message on the Maps. It indicates or marks a specific location with desired symbols on the Maps. It can be enabled by setting the `Visible` property of the `MapsMarker` to **true**.

## Adding marker

To add the markers, the `DataSource` property of the `MapsMarker` has a list of objects that contains the data for markers. Using this property, any number of markers can be added to the layers of the Maps. By default, it displays the markers based on the specified latitude and longitude in the given data source. Each data source object contains the following list of properties.

* latitude - The latitude point which determines the X location of the marker.
* longitude - The longitude point which determines the Y location of the marker.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/markers/marker-adding/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Marker-adding.cs" %}
{% include code-snippet/maps/markers/marker-adding/marker-adding.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/markers/marker-adding/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Marker-adding.cs" %}
{% include code-snippet/maps/markers/marker-adding/marker-adding.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Adding marker](./images/Marker/marker-adding.PNG)

## Adding marker template

The Marker can be added as a template in the Maps component. The `Template` property of the `MapsMarker` is used to set the HTML element or id of an element as a template.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/markers/marker-label/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Marker-label.cs" %}
{% include code-snippet/maps/markers/marker-label/marker-label.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/markers/marker-label/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Marker-label.cs" %}
{% include code-snippet/maps/markers/marker-label/marker-label.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Adding marker template](./images/Marker/marker-template.PNG)

## Customization

The following properties are available in `MapsMarker` class to customize the Markers of the Maps component.

* `Border` - To customize the color, width and opacity of the border for the markers in Maps.
* `Fill` - To apply the color for markers in Maps.
* `DashArray` - To define the pattern of dashes and gaps that is applied to the outline of the markers in Maps.
* `Height` - To customize the height of the markers in Maps.
* `Width` - To customize the width of the markers in Maps.
* `Offset` - To customize the position of the markers in Maps.
* `Opacity` - To customize the transparency of the markers in Maps.
* `AnimationDelay` - To change the time delay in the transition for markers.
* `AnimationDuration` - To change the time duration of animation for markers.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/markers/marker-customization/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Marker-customization.cs" %}
{% include code-snippet/maps/markers/marker-customization/marker-customization.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/markers/marker-customization/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Marker-customization.cs" %}
{% include code-snippet/maps/markers/marker-customization/marker-customization.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Customization](./images/Marker/marker-customization.PNG)

## Marker shapes

The Maps component supports the following marker shapes. To set the shape of the marker, the `Shape` property in `MapsMarker` is used.

* Balloon
* Circle
* Cross
* Diamond
* Image
* Rectangle
* Start
* Triangle
* VerticalLine
* HorizontalLine

### Rendering marker shape as image

To render a marker as an image in Maps, set the `Shape` property of `MapsMarker` as **Image** and specify the path of the image to `ImageUrl` property. There is another way to render a marker as an image using the `ImageUrlValuePath` property of the `MapsMarker`. Bind the field name that contains the path of the image in the data source to the `ImageUrlValuePath` property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/markers/marker-image/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Marker-image.cs" %}
{% include code-snippet/maps/markers/marker-image/marker-image.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/markers/marker-image/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Marker-image.cs" %}
{% include code-snippet/maps/markers/marker-image/marker-image.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Rendering Marker shape as image](./images/Marker/marker-image.PNG)

## Multiple marker groups

Multiple groups of markers can be added in the Maps by adding multiple `MapsMarker` in the `MapsMarkers` and customization for the markers can be done with the `MapsMarker`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/markers/marker-group/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Marker-group.cs" %}
{% include code-snippet/maps/markers/marker-group/marker-group.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/markers/marker-group/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Marker-group.cs" %}
{% include code-snippet/maps/markers/marker-group/marker-group.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Multiple marker groups](./images/Marker/marker-group.PNG)

## Customize marker shapes from data source

### Bind different colors and shapes to the marker from data source

Using the `ShapeValuePath` and `ColorValuePath` properties, the color and shape of the marker can be applied from the given data source. Bind the data source to the `DataSource` property of the `MapsMarker` class and set the field names that contains the shape and color values in the data source to the `ShapeValuePath` and `ColorValuePath` properties.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/markers/shape/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Shape.cs" %}
{% include code-snippet/maps/markers/shape/shape.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/markers/shape/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Shape.cs" %}
{% include code-snippet/maps/markers/shape/shape.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Bind different colors and shapes to the marker from data source](./images/Marker/marker-DS.PNG)

### Setting value path from the data source

The latitude and longitude values are used to determine the location of each marker in the Maps. The `LatitudeValuePath` and `LongitudeValuePath` properties are used to specify the value path that presents in the data source of the marker. In the following example, the field name from the data source is set to the `LatitudeValuePath` and `LongitudeValuePath` properties.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/markers/marker-valuepath/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Marker-valuepath.cs" %}
{% include code-snippet/maps/markers/marker-valuepath/marker-valuepath.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/markers/marker-valuepath/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Marker-valuepath.cs" %}
{% include code-snippet/maps/markers/marker-valuepath/marker-valuepath.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Setting value path from the data source](./images/Marker/marker-adding.PNG)

## Marker zooming

The Maps can be initially scaled to the center value based on the marker distance. This can be achieved by setting the `ShouldZoomInitially` property in `MapsZoomSettings` as **true**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/markers/marker-zoom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Marker-zoom.cs" %}
{% include code-snippet/maps/markers/marker-zoom/marker-zoom.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/markers/marker-zoom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Marker-zoom.cs" %}
{% include code-snippet/maps/markers/marker-zoom/marker-zoom.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Marker zooming](./images/Marker/marker-zoom.PNG)

## Marker clustering

Maps provide support to cluster the markers when they overlap each other. The number on a cluster indicates how many overlapped markers it contains. If zooming is performed on any of the cluster locations in Maps, the number on the cluster will decrease, and the individual markers will be seen on the map. When zooming out, the overlapping marker will increase. So that it can cluster again and increase the count over the cluster.

To enable clustering in markers, set the `AllowClustering` property of `MapsMarkerClusterSettings` as **true** and customization of clustering can be done with the `MapsMarkerClusterSettings`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/markers/marker-cluster/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Marker-cluster.cs" %}
{% include code-snippet/maps/markers/marker-cluster/marker-cluster.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/markers/marker-cluster/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Marker-cluster.cs" %}
{% include code-snippet/maps/markers/marker-cluster/marker-cluster.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Marker clustering](./images/Marker/marker-cluster.PNG)

## Customization of marker cluster

The following properties are available to customize the marker clustering in the Maps component.

* `Border` - To customize the color, width and opacity of the border of cluster in Maps.
* `ConnectorLineSettings` - To customize the connector line in cluster separating the markers.
* `DashArray` - To customize the dash array for the marker cluster in Maps.
* `Fill` - Applies the color of the cluster in Maps.
* `Height` - To customize the height of the marker cluster in Maps.
* `ImageUrl` - To customize the URL path for the marker cluster when the cluster shape is set as image in Maps.
* `LabelStyle` - To customize the text in marker cluster.
* `Offset` - To customize the offset position for the marker cluster in Maps.
* `Opacity` - To customize the opacity of the marker cluster.
* `Shape` - To customize the shape for the cluster of markers.
* `Width` - To customize the width of the marker cluster in Maps.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/markers/cluster-customization/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Cluster-customization.cs" %}
{% include code-snippet/maps/markers/cluster-customization/cluster-customization.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/markers/cluster-customization/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Cluster-customization.cs" %}
{% include code-snippet/maps/markers/cluster-customization/cluster-customization.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Customization of marker cluster](./images/Marker/cluster-customization.PNG)

## Expanding the marker cluster

The cluster is formed by grouping an identical and non-identical marker from the surrounding area. By clicking on the cluster and setting the `AllowClusterExpand` property in `MapsMarkerClusterSettings` as **true** to expand the identical markers. If zooming is performed in any of the locations of the cluster, the number on the cluster will decrease and the overlapping marker will be split into an individual marker on the map. When performing zoom out, it will increase the marker count and then cluster it again.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/markers/cluster/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Cluster.cs" %}
{% include code-snippet/maps/markers/cluster/cluster.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/markers/cluster/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Cluster.cs" %}
{% include code-snippet/maps/markers/cluster/cluster.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Marker cluster expand](./images/Marker/cluster-expand.PNG)

## Tooltip for marker

Tooltip is used to display more information about a marker on mouse over or touch end event. This can be enabled separately for marker by setting the `Visible` property of `MapsTooltipSettings` to **true**. The `ValuePath` property in the `MapsTooltipSettings` takes the field name that presents in dataSource and displays that value as tooltip text.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/markers/marker-tooltip/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Marker-tooltip.cs" %}
{% include code-snippet/maps/markers/marker-tooltip/marker-tooltip.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/markers/marker-tooltip/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Marker-tooltip.cs" %}
{% include code-snippet/maps/markers/marker-tooltip/marker-tooltip.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Maps with marker Tooltip](./images/Marker/MarkerTooltip.png)