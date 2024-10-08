---
layout: post
title: How to create the routes in Syncfusion ##Platform_Name## Maps Component
description: Learn here all about creating the routes between the markers in Syncfusion ##Platform_Name## Maps component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Maps
publishingplatform: ##Platform_Name##
documentation: ug
---

# Creating routes between the markers in the ##Platform_Name## Maps Component

The Syncfusion Maps component supports plotting routes between two locations (source and destination) using the navigation line feature. Markers can be placed at these locations to visually indicate the source and destination, making it easier to view the path between them on the map.

The data for navigation routes must be retrieved from an external source, such as the Google Maps Directions API. Below are the outlined steps to create a route using the coordinates obtained from the Google Maps Directions API.

1. Initialize the Google Maps Directions API.
2. Create input fields for the source and destination.
3. Fetch the coordinates from the Google Maps Directions API.
4. Plot markers on the map at the specified locations.
5. Generate and visualize the route between the source and destination.

Similarly, you can retrieve coordinates from other services and integrate them into the Maps.

## Initialize the Google Maps Directions API

To access the Google Maps Directions API, include the following script file in your HTML page and add your generated API key to the URL of the script.

```
    <script src="https://maps.googleapis.com/maps/api/js?key=Your_Key&callback=initMap&v=weekly" defer>
    </script>

```

## Create Input Fields for Source and Destination

To obtain the source and destination from the user, create two input fields as text boxes. Additionally, include a button to generate routes on the map based on their input. When the user provides addresses in the input fields, you can geocode the addresses to get the corresponding coordinates, add markers to the map at those locations, and draw the route between them will be explained in detail in the topics below.

## Fetch coordinates from Google API

To obtain the geographic coordinates (latitude and longitude) from the Google Directions API, send a request to the API with the specified address to retrieve the corresponding coordinates. These coordinates can then be used to add markers and navigation lines, allowing you to create a route on the map.

{% if page.publishingplatform == "aspnet-core" %}

<script>
    var source;
    var destination;
    document.addEventListener('DOMContentLoaded', function () {
        initMap();
    });
    function initMap() {
        const directionsService = new google.maps.DirectionsService();
        const onButtonClick = function () {
            source = document.getElementById('input').value.toLowerCase();
            destination = document.getElementById('output').value.toLowerCase();
            if (
                source !== null &&
                source !== '' &&
                destination !== null &&
                destination !== ''
            ) {
                calculateAndDisplayRoute(directionsService);
            }
        };
        document.getElementById('route').addEventListener('click', onButtonClick);
    }
    function calculateAndDisplayRoute(directionsService) {
        directionsService
            .route({
                origin: {
                    query: source,
                },
                destination: {
                    query: destination,
                },
                travelMode: google.maps.TravelMode.DRIVING,
            })
            .then((response) => {
                maps.ej2_instances[0].zoomSettings.shouldZoomInitially = true;
                var markers = maps.ej2_instances[0].layers[0].markerSettings;
                markers[0].dataSource = [];
                markers[0].dataSource.push({
                    latitude: response.routes[0].legs[0].start_location.lat(),
                    longitude: response.routes[0].legs[0].start_location.lng(),
                });
                markers[0].dataSource.push({
                    latitude: response.routes[0].legs[0].end_location.lat(),
                    longitude: response.routes[0].legs[0].end_location.lng(),
                });
                var navigationlines = maps.ej2_instances[0].layers[0].navigationLineSettings;
                var latLngs = response.routes[0].overview_path;
                var latitudes = [];
                var longitudes = [];
                for (var i = 0; i < latLngs.length; i++) {
                    latitudes.push(latLngs[i].lat());
                    longitudes.push(latLngs[i].lng());
                }
                navigationlines[0].latitude = latitudes;
                navigationlines[0].longitude = longitudes;
            })
            .catch((e) => window.alert('Directions request failed due to ' + status));
    }
</script>

{% elsif page.publishingplatform == "aspnet-mvc" %}

```
<script>
    var source;
    var destination;
    document.addEventListener('DOMContentLoaded', function () {
        initMap();
    });
    function initMap() {
        const directionsService = new google.maps.DirectionsService();
        const onButtonClick = function () {
            source = document.getElementById('input').value.toLowerCase();
            destination = document.getElementById('output').value.toLowerCase();
            if (
                source !== null &&
                source !== '' &&
                destination !== null &&
                destination !== ''
            ) {
                calculateAndDisplayRoute(directionsService);
            }
        };
        document.getElementById('route').addEventListener('click', onButtonClick);
    }
    function calculateAndDisplayRoute(directionsService) {
        directionsService
            .route({
                origin: {
                    query: source,
                },
                destination: {
                    query: destination,
                },
                travelMode: google.maps.TravelMode.DRIVING,
            })
            .then((response) => {
                maps.ej2_instances[0].zoomSettings.shouldZoomInitially = true;
                var markers = maps.ej2_instances[0].layers[0].markerSettings;
                markers[0].dataSource = [];
                markers[0].dataSource.push({
                    latitude: response.routes[0].legs[0].start_location.lat(),
                    longitude: response.routes[0].legs[0].start_location.lng(),
                });
                markers[0].dataSource.push({
                    latitude: response.routes[0].legs[0].end_location.lat(),
                    longitude: response.routes[0].legs[0].end_location.lng(),
                });
                var navigationlines = maps.ej2_instances[0].layers[0].navigationLineSettings;
                var latLngs = response.routes[0].overview_path;
                var latitudes = [];
                var longitudes = [];
                for (var i = 0; i < latLngs.length; i++) {
                    latitudes.push(latLngs[i].lat());
                    longitudes.push(latLngs[i].lng());
                }
                navigationlines[0].latitude = latitudes;
                navigationlines[0].longitude = longitudes;
            })
            .catch((e) => window.alert('Directions request failed due to ' + status));
    }
</script>
```


{% endif %}

### Customize the travel mode direction services in the Google Map

You can retrieve coordinates based on different travel modes, such as DRIVING, WALKING, BICYCLING, or TRANSIT, using the Google Maps Directions API. DRIVING is the default travel mode for these services. For additional information on various travel modes, you can refer to the [link](https://developers.google.com/maps/documentation/javascript/directions#TravelModes).

## Plot markers on the Map

To plot markers on the map, use the retrieved geographic coordinates to place the markers at the source and destination locations. This allows users to easily identify the key points along the route.

{% if page.publishingplatform == "aspnet-core" %}

```
       var markers = maps.ej2_instances[0].layers[0].markerSettings;
       markers[0].dataSource = [];
       markers[0].dataSource.push({
          latitude: response.routes[0].legs[0].start_location.lat(),
          longitude: response.routes[0].legs[0].start_location.lng(),
       });
       markers[0].dataSource.push({
          latitude: response.routes[0].legs[0].end_location.lat(),
          longitude: response.routes[0].legs[0].end_location.lng(),
       });
```

{% elsif page.publishingplatform == "aspnet-mvc" %}

```
       var markers = maps.ej2_instances[0].layers[0].markerSettings;
       markers[0].dataSource = [];
       markers[0].dataSource.push({
           latitude: response.routes[0].legs[0].start_location.lat(),
           longitude: response.routes[0].legs[0].start_location.lng(),
       });
       markers[0].dataSource.push({
       latitude: response.routes[0].legs[0].end_location.lat(),
       longitude: response.routes[0].legs[0].end_location.lng(),
       });
```

{% endif %}

## Generate and visualize the route

To generate and visualize the route, use the geographic coordinates obtained from the Google Directions API to draw a navigation line between the source and destination markers on the map. This provides a clear representation of the path for users to follow.

{% if page.publishingplatform == "aspnet-core" %}

```
        var navigationlines = maps.ej2_instances[0].layers[0].navigationLineSettings;
        var latLngs = response.routes[0].overview_path;
        var latitudes = [];
        var longitudes = [];
        for (var i = 0; i < latLngs.length; i++) {
            latitudes.push(latLngs[i].lat());
            longitudes.push(latLngs[i].lng());
        }
        navigationlines[0].latitude = latitudes;
        navigationlines[0].longitude = longitudes;
```

{% elsif page.publishingplatform == "aspnet-mvc" %}

```
          var navigationlines = maps.ej2_instances[0].layers[0].navigationLineSettings;
          var latLngs = response.routes[0].overview_path;
          var latitudes = [];
          var longitudes = [];
          for (var i = 0; i < latLngs.length; i++) {
              latitudes.push(latLngs[i].lat());
              longitudes.push(latLngs[i].lng());
          }
          navigationlines[0].latitude = latitudes;
          navigationlines[0].longitude = longitudes;
```

{% endif %}

You can find a demonstration of integrating the Google Maps Directions API with the Syncfusion Maps component to render navigation routes below.

{% if page.publishingplatform == "aspnet-core" %}

[Sample in the GitHub](https://github.com/SyncfusionExamples/How-to-create-a-route-between-the-markers-on-the-Core-Maps-from-the-external-source/tree/master)

{% elsif page.publishingplatform == "aspnet-mvc" %}

[Sample in the GitHub](https://github.com/SyncfusionExamples/How-to-create-a-route-between-the-markers-on-the-MVC-Maps-from-the-external-source/tree/master)

{% endif %}
