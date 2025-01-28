---
layout: post
title: Google Maps in Syncfusion ##Platform_Name## Syncfusion Maps Component
description: Learn here all about displaying Google Maps in the Syncfusion ##Platform_Name## Maps component and much more details.
platform: ej2-asp-core-mvc
control: Google Maps
publishingplatform: ##Platform_Name##
documentation: ug
---

# Google Maps in ##Platform_Name## Maps Component

{% if page.publishingplatform == "aspnet-core" %}

Google Maps is an online maps provider owned by Google. It provides map tile images based on user requests. The Syncfusion Maps component combines these images into a single view to display the map. You can display Google Maps by specifying their tile service URL in the [urlTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_UrlTemplate) property.

{% elsif page.publishingplatform == "aspnet-mvc" %}

Google Maps is an online maps provider owned by Google. It provides map tile images based on user requests. The Syncfusion Maps component combines these images into a single view to display the map. You can display Google Maps by specifying their tile service URL in the [UrlTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_UrlTemplate) property.

{% endif %}

## Displaying Google Maps

The Google Map tile service can be accessed using the following URL:
https://tile.googleapis.com/v1/2dtiles/z/x/y?session=YOUR_SESSION_TOKEN&key=YOUR_API_KEY

In the above URL template,

* {z} - It represents the zoom level of the map. 
* {x} - It represents the horizontal position of the tile.
* {y} - It represents the vertical position of the tile. 

These placeholders are replaced by **level**, **tileX**, and **tileY**, respectively, to retrieve the correct map tile.

N> You can refer this documentation [link](https://developers.google.com/maps/documentation/tile/roadmap) for the latest URL template for Google Maps.

Below are the outlined steps to integrate Google Maps tiles into the Syncfusion Maps Component.

1. Generate an API key from the Google Cloud Platform.
2. Generate a session token to retrieve Google Map tiles.
3. Initialize the Syncfusion Maps component using the Google Maps tile service URL, including the generated session token and API key.

{% if page.publishingplatform == "aspnet-core" %}

Here's a step-by-step explanation of how to integrate Google Maps tiles into the Syncfusion Maps component using the provided code:

**STEP 1**: Generate an API key from the Google Cloud Platform by enabling the necessary APIs, such as the Google Maps Tile API and Google Maps API. This key is crucial for authentication and must be included in every API call. Follow the steps in [link](https://developers.google.com/maps/documentation/tile/get-api-key) to generate an API key.

**STEP 2**: The **fetchSessionToken** function generates a session token, which is needed to retrieve Google Map tiles, by sending a POST request to the **createSession** endpoint of the Google Maps Tile API.

{% tabs %}
{% highlight cshtml tabtitle="SessionToken" %}

const apiKey = "Your_Key";

async function fetchSessionToken(apiKey) {
    try {
        // Send a POST request to fetch session token
        const response = await fetch(
            `https://tile.googleapis.com/v1/createSession?key=${apiKey}`,
            {
                method: "POST",
                headers: {
                    "Content-Type": "application/json",
                },
                body: JSON.stringify({
                    mapType: "roadmap",
                    language: "en-US",
                    region: "US",
                }),
            }
        );

        // Check for response status
        if (!response.ok) {
            const errorData = await response.json();
            throw new Error(
                `Error generating session token: ${errorData.error.message}`
            );
        }

        // Return the session token
        const data = await response.json();
        return data.session;
    } catch (error) {
        console.error("Error fetching session token:", error.message);
        throw error;
    }
}

{% endhighlight %}
{% endtabs %}

**STEP 3**: To initialize the Syncfusion Maps component, create a function called **initializeMap** that invokes the **fetchSessionToken** function. Once the session token is retrieved, both the session token and the API key are appended to the URL in the `urlTemplate` property of the Maps component to authenticate and access the map tiles. This process ensures that the map tiles are accessed securely and correctly, allowing the Syncfusion Maps component to display the map with the appropriate data. The **initializeMap** function must be called to render the Maps component.

{% tabs %}
{% highlight cshtml tabtitle="SetUrlTemplate" %}

async function initializeMap() {
    try {
        // Fetch session token
        const sessionToken = await fetchSessionToken(apiKey);

        // Update the URL template
        const maps = document.getElementById('maps').ej2_instances[0];
        maps.layers[0].urlTemplate = `https://tile.googleapis.com/v1/2dtiles/level/tileX/tileY?session=${sessionToken}&key=${apiKey}`;
    } catch (error) {
        console.error("Failed to initialize the map:", error.message);
    }
}

{% endhighlight %}
{% endtabs %}

In the following example, Google Maps can be displayed using the [UrlTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_UrlTemplate) property with its tile server URL.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/google-maps/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="GoogleMaps.cs" %}
{% include code-snippet/maps/map-providers/google-maps/google-maps.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

Here's a step-by-step explanation of how to integrate Google Maps tiles into the Syncfusion Maps component using the provided code:

**STEP 1**: Generate an API key from the Google Cloud Platform by enabling the necessary APIs, such as the Google Maps Tile API and Google Maps API. This key is crucial for authentication and must be included in every API call. Follow the steps in [this link](https://developers.google.com/maps/documentation/tile/get-api-key) to generate an API key.

**STEP 2**: The **fetchSessionToken** function generates a session token, which is needed to retrieve Google Map tiles, by sending a POST request to the **createSession** endpoint of the Google Maps Tile API.

{% tabs %}
{% highlight cshtml tabtitle="SessionToken" %}

    async function fetchSessionToken(apiKey) {
        try {
            // Send a POST request to fetch session token
            const response = await fetch(
                `https://tile.googleapis.com/v1/createSession?key=${apiKey}`,
                {
                    method: "POST",
                    headers: {
                        "Content-Type": "application/json",
                    },
                    body: JSON.stringify({
                        mapType: "roadmap",
                        language: "en-US",
                        region: "US",
                    }),
                }
            );
    
            // Check for response status
            if (!response.ok) {
                const errorData = await response.json();
                throw new Error(
                    `Error generating session token: ${errorData.error.message}`
                );
            }
    
            // Return the session token
            const data = await response.json();
            return data.session;
        } catch (error) {
            console.error("Error fetching session token:", error.message);
            throw error;
        }
    }

{% endhighlight %}
{% endtabs %}

**STEP 3**: To initialize the Syncfusion Maps component, create a function called **initializeMap** that invokes the **fetchSessionToken** function. Once the session token is retrieved, both the session token and the API key are appended to the URL in the `urlTemplate` property of the Maps component to authenticate and access the map tiles. This process ensures that the map tiles are accessed securely and correctly, allowing the Syncfusion Maps component to display the map with the appropriate data. The **initializeMap** function must be called to render the Maps component.

{% tabs %}
{% highlight cshtml tabtitle="SetUrlTemplate" %}
    
    async function initializeMap() {
        try {
            // Fetch session token
            const sessionToken = await fetchSessionToken(apiKey);
    
            // Update the URL template
            const maps = document.getElementById('maps').ej2_instances[0];
            maps.layers[0].urlTemplate = `https://tile.googleapis.com/v1/2dtiles/level/tileX/tileY?session=${sessionToken}&key=${apiKey}`;
        } catch (error) {
            console.error("Failed to initialize the map:", error.message);
        }
    }

{% endhighlight %}
{% endtabs %}

In the following example, Google Maps can be displayed using the [urlTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_UrlTemplate) property with its tile server URL.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/google-maps/razor %}
{% endhighlight %}
{% highlight c# tabtitle="GoogleMaps.cs" %}
{% include code-snippet/maps/map-providers/google-maps/google-maps.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Google Maps](../images/MapProviders/Google-maps/google-maps.png)

## Enabling zooming and panning

The Google Maps layer can be zoomed and panned. Zooming helps to get a closer look at a particular area on a map for in-depth analysis. Panning helps to move a map around to focus the targeted area.

N> You can refer to the method for obtaining the session token can be explained in the above section **Displaying Google Maps**, which can be included in the URL below to render tile images from Google Maps.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/google-maps-zoom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="GoogleMapsZoom.cs" %}
{% include code-snippet/maps/map-providers/google-maps-zoom/google-maps-zoom.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/google-maps-zoom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="GoogleMapsZoom.cs" %}
{% include code-snippet/maps/map-providers/google-maps-zoom/google-maps-zoom.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Google Maps with Zooming and Panning](../images/MapProviders/Google-maps/google-maps-zooming.png)

## Adding markers and navigation line

{% if page.publishingplatform == "aspnet-core" %}

Markers can be added to the layers of Google Maps by setting the corresponding location's coordinates of latitude and longitude using [MarkerSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_MarkerSettings). Navigation lines can be added on top of the Google Maps layer for highlighting a path among various places by setting the corresponding location's coordinates of latitude and longitude in the [NavigationLineSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_NavigationLineSettings).

N> You can refer to the method for obtaining the session token can be explained in the above section **Displaying Google Maps**, which can be included in the URL below to render tile images from Google Maps.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/google-maps-marker/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="GoogleMapsMarker.cs" %}
{% include code-snippet/maps/map-providers/google-maps-marker/google-maps-marker.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

Markers can be added to the layers of Google Maps by setting the corresponding location's coordinates of latitude and longitude using [MarkerSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_MarkerSettings). Navigation lines can be added on top of the Google Maps layer for highlighting a path among various places by setting the corresponding location's coordinates of latitude and longitude in the [NavigationLineSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_NavigationLineSettings).

N> You can refer to the method for obtaining the session token can be explained in the above section **Displaying Google Maps**, which can be included in the URL below to render tile images from Google Maps.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/google-maps-marker/razor %}
{% endhighlight %}
{% highlight c# tabtitle="GoogleMapsMarker.cs" %}
{% include code-snippet/maps/map-providers/google-maps-marker/google-maps-marker.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Google Maps with Markers and Navigation Line](../images/MapProviders/Google-maps/google-maps-marker-and-line.png)

## Adding sublayer

{% if page.publishingplatform == "aspnet-core" %}

Any GeoJSON shape can be rendered as a sublayer on top of the Google Maps layer for highlighting a particular continent or country in Google Maps by adding another layer and specifying the [Type](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_Type) property of Maps layer to **SubLayer**.

N> You can refer to the method for obtaining the session token can be explained in the above section **Displaying Google Maps**, which can be included in the URL below to render tile images from Google Maps.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/google-maps-sublayer/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="GoogleMapsSubLayer.cs" %}
{% include code-snippet/maps/map-providers/google-maps-sublayer/google-maps-sublayer.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

Any GeoJSON shape can be rendered as a sublayer on top of the Google Maps layer for highlighting a particular continent or country in Google Maps by adding another layer and specifying the [Type](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_Type) property of Maps layer to **SubLayer**.

N> You can refer to the method for obtaining the session token can be explained in the above section **Displaying Google Maps**, which can be included in the URL below to render tile images from Google Maps.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/google-maps-sublayer/razor %}
{% endhighlight %}
{% highlight c# tabtitle="GoogleMapsSubLayer.cs" %}
{% include code-snippet/maps/map-providers/google-maps-sublayer/google-maps-sublayer.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Google Maps with Sublayer](../images/MapProviders/Google-maps/google-maps-sublayer.png)

## Enabling legend

{% if page.publishingplatform == "aspnet-core" %}

The legend can be added to the tile Maps by setting the [Visible](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLegendSettings.html#Syncfusion_EJ2_Maps_MapsLegendSettings_Visible) property of [LegendSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.Maps.html#Syncfusion_EJ2_Maps_Maps_LegendSettings) to **true**.

N> You can refer to the method for obtaining the session token can be explained in the above section **Displaying Google Maps**, which can be included in the URL below to render tile images from Google Maps.

In the example below, the legend is added to the markers on the Google Maps layer.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/google-maps-legend/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="GoogleMapsLegend.cs" %}
{% include code-snippet/maps/map-providers/google-maps-legend/google-maps-legend.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

The legend can be added to the tile Maps by setting the [Visible](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLegendSettings.html#Syncfusion_EJ2_Maps_MapsLegendSettings_Visible) property of [LegendSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.Maps.html#Syncfusion_EJ2_Maps_Maps_LegendSettings) to **true**.

N> You can refer to the method for obtaining the session token can be explained in the above section **Displaying Google Maps**, which can be included in the URL below to render tile images from Google Maps.

In the example below, the legend is added to the markers on the Google Maps layer.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/map-providers/google-maps-legend/razor %}
{% endhighlight %}
{% highlight c# tabtitle="GoogleMapsLegend.cs" %}
{% include code-snippet/maps/map-providers/google-maps-legend/google-maps-legend.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Google Maps with Legend](../images/MapProviders/Google-maps/google-maps-legend.png)
