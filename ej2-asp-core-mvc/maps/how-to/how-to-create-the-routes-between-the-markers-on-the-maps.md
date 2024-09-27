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

The Syncfusion Maps Component supports plotting routes between two locations(source and destination) using navigation line feature. Markers can be placed at these locations to visually indicate the source and destination, making it easier to view the path between them on the Maps.

Below are the outlined steps to create a route using coordinates obtained from an external source.

1. Initialize the Google Maps Directions Service.
2. Create input fields for source and destination.
3. Fetch the coordinates from the Google API.
4. Plot markers on the map at the specified locations.
5. Generate and visualize the route between the source and destination.
6. Customize the travel mode direction services in the Google Map.

Similarly, you can retrieve the coordinates from other services and integrate them into the Maps.

## Initialize the Google Maps Directions Service

To access the Google Maps service, you need to include the script in your HTML page, using your generated API key as shown below:

[**_Layout.cshtml**]
```
    <script src="https://maps.googleapis.com/maps/api/js?key=Your_Key&callback=initMap&v=weekly" defer>
    </script>

```
After including the script, you should call the initMap() method initially to initialize the Google Maps services.

[**Index.cshtml**]
```
    document.addEventListener('DOMContentLoaded', function () {
        initMap();
    });

```
## Create input fields for source and destination

To create input fields for source and destination, design text boxes where users can enter the starting point and endpoint for a route. The **source** textbox is for the user to specify where the journey begins, while the **destination** textbox is for indicating where it should end. This allows users to easily provide location information. Additionally, button is included to generate routes on the maps based on their input.

## Fetch coordinates from Google API

To obtain the geographic coordinates (latitude and longitude) from the Google Directions API, send a request to the API with the specified address to retrieve the corresponding coordinates. These coordinates can then be used to add markers and navigation lines, enabling to create a route on the map.

## Plot markers on the Map

To plot markers on the map, use the retrieved geographic coordinates to place the markers at the source and destination locations, allowing users to easily identify the points along the route.

## Generate and visualize the route

To generate and visualize the route, use the geographic coordinates obtained from the Google Directions API to draw a navigation line between the source and destination markers on the map, providing a clear representation of the path for users to follow.

## Customize the travel mode direction services in the Google Map

You can retrieve the coordinates from various directions services by selecting a specific travel mode, such as **DRIVING**, **WALKING**, **BICYCLING**, or **TRANSIT**. The **DRIVING** is the default travel mode for these services. You can also refer to the [Google Maps link](https://developers.google.com/maps/documentation/javascript/directions#TravelModes) for additional information on various travel modes.

In the following example, we demonstrate how to fetch the coordinates from the Google Directions API and displaying the results on the Maps.

{% if page.publishingplatform == "aspnet-core" %}

Please refer the sample in the [github](https://github.com/SyncfusionExamples/How-to-create-a-route-between-the-markers-on-the-Core-Maps-from-the-external-source/tree/master)

{% elsif page.publishingplatform == "aspnet-mvc" %}

Please refer the sample in the [github](https://github.com/SyncfusionExamples/How-to-create-a-route-between-the-markers-on-the-MVC-Maps-from-the-external-source/tree/master)

{% endif %}