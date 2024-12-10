---
layout: post
title: Markers in Syncfusion ##Platform_Name## Maps Component
description: Learn here all about Markers in Syncfusion ##Platform_Name## Maps component of Syncfusion Essential JS 2 and more.
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

### Setting different sizes for markers individually

The size of the markers in a marker group can be customized using the `WidthValuePath` and `HeightValuePath` properties, which allow the user to change the width and height of the markers based on values from the given data source. Bind the data source to the `DataSource`property of the markerSettings, and specify the field names containing the width and height values in the data source for the `WidthValuePath` and `HeightValuePath` properties.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/markers/marker-size-customization/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Marker-valuepath.cs" %}
{% include code-snippet/maps/markers/marker-size-customization/marker-size-customization.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/markers/marker-size-customization/razor %}
{% endhighlight %}
{% highlight c# tabtitle="MarkerSize-customization.cs" %}
{% include code-snippet/maps/markers/marker-size-customization/marker-size-customization.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Maps with Different Marker Size for Individual Markers](./images/Marker/different-size-for-individual-marker.PNG)

## Repositioning the marker using drag and drop

{% if page.publishingplatform == "aspnet-core" %}

The markers on the map can be dragged and dropped to change their position. To enable marker drag and drop, set the [enableDrag](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsMarker.html#Syncfusion_EJ2_Maps_MapsMarker_EnableDrag) property to **true** in the [markerSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsMarker.html) property.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/markers/marker-draganddrop/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Marker-draganddrop.cs" %}
{% include code-snippet/maps/markers/marker-draganddrop/marker-draganddrop.cs %}
{% endhighlight %}
{% endtabs %}

![Marker with drag and drop functionality](./images/Marker/marker-drag-and-drop.gif)

The data of the drag and dropped marker in the marker data source can be customized using the [markerDragStart](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.Maps.html#Syncfusion_EJ2_Maps_Maps_MarkerDragStart) and [markerDragEnd](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.Maps.html#Syncfusion_EJ2_Maps_Maps_MarkerDragEnd) events. When you change the appropriate marker data, the tooltip and legend item text of that marker are automatically updated. The following properties are available in the event argument of the marker drag events.

|   Argument Name      |   Description                               |
|----------------------| --------------------------------------------|
|   dataIndex          |   It represents the index of the data of the dragged marker in the marker data source.                          |
|   latitude           |   It represents the latitude coordinate point of the dragged marker.                                            |
|   longitude          |   It represents the longitude coordinate point for the dragged marker.                                          |
|   markerIndex        |   It represents the index of the marker setting.                                                                |
|   layerIndex         |   It represents the index of the layer in which the marker belongs.                                             |
|   name               |   It represents the name of the event.                                                                          |
|   x                  |   It represents the horizontal location of the mouse pointer on the map when the drag action is performed.      |
|   y                  |   It represents the vertical location of the mouse pointer on the map when the drag action is performed.        |

The following example shows how to use marker drag events to customize the data of the drag and dropped marker in the marker data source.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/markers/marker-dragevents/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Marker-dragevents.cs" %}
{% include code-snippet/maps/markers/marker-dragevents/marker-dragevents.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

The markers on the map can be dragged and dropped to change their position. To enable marker drag and drop, set the [EnableDrag](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsMarker.html#Syncfusion_EJ2_Maps_MapsMarker_EnableDrag) property to **true** in the [MarkerSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsMarker.html) property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/markers/marker-draganddrop/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Marker-draganddrop.cs" %}
{% include code-snippet/maps/markers/marker-draganddrop/marker-draganddrop.cs %}
{% endhighlight %}
{% endtabs %}

![Marker with drag and drop functionality](./images/Marker/marker-drag-and-drop.gif)

The data of the drag and dropped marker in the marker data source can be customized using the [MarkerDragStart](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.Maps.html#Syncfusion_EJ2_Maps_Maps_MarkerDragStart) and [MarkerDragEnd](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.Maps.html#Syncfusion_EJ2_Maps_Maps_MarkerDragEnd) events. When you change the appropriate marker data, the tooltip and legend item text of that marker are automatically updated. The following properties are available in the event argument of the marker drag events.

|   Argument Name      |   Description                               |
|----------------------| --------------------------------------------|
|   dataIndex          |   It represents the index of the data of the dragged marker in the marker data source.                          |
|   latitude           |   It represents the latitude coordinate point of the dragged marker.                                            |
|   longitude          |   It represents the longitude coordinate point for the dragged marker.                                          |
|   markerIndex        |   It represents the index of the marker setting.                                                                |
|   layerIndex         |   It represents the index of the layer in which the marker belongs.                                             |
|   name               |   It represents the name of the event.                                                                          |
|   x                  |   It represents the horizontal location of the mouse pointer on the map when the drag action is performed.      |
|   y                  |   It represents the vertical location of the mouse pointer on the map when the drag action is performed.        |

The following example shows how to use marker drag events to customize the data of the drag and dropped marker in the marker data source.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/markers/marker-dragevents/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Marker-dragevents.cs" %}
{% include code-snippet/maps/markers/marker-dragevents/marker-dragevents.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Marker customization using marker drag events](./images/Marker/marker-drag-events.gif)

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

To enable clustering for markers within a layer, set the `AllowClustering` property of `MapsMarkerClusterSettings` in the `MapsLayers` to **true**. Customization of clustering can be done using the `MapsMarkerClusterSettings` property.

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

### Customization of marker cluster

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

### Expanding the marker cluster

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

### Clustering markers within each marker group

Marker clustering can be enabled for each marker group in the map by using the `ClusterSettings` property within the `MarkerSettings` property in the `MapsLayers`. This allows for individual customization of clusters for each marker group which group markers that are located near each other to reduce clutter and improve readability. When the `AllowClustering` property is set to **true**, the markers within each group are clustered and visually represented as separate clusters. As users zoom in, the clusters expand to reveal individual markers, enabling more detailed exploration. Clusters can also be expanded manually by setting the `AllowClusterExpand` property to **true**. The appearance of the clusters and their expansion behavior can be customized using the `ClusterSettings` property, similar to the `MapsMarkerClusterSettings` property, as explained in the sections above.

NOTE: When the `ClusterSettings` property is enabled for an individual marker group, the `MapsMarkerClusterSettings` property within the layers becomes ineffective.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/markers/marker-clustering/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Marker-clusters.cs" %}
{% include code-snippet/maps/markers/marker-clustering/marker-clustering.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/markers/marker-clustering/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Marker-clustering.cs" %}
{% include code-snippet/maps/markers/marker-clustering/marker-clustering.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Maps with Marker Clustering for Specfic Marker Group](./images/Marker/marker-clustering-for-specfic-marker-group.PNG)

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