---
layout: post
title: Working with data in ##Platform_Name## Syncfusion Chart Component
description: Learn here all about Working with data in Syncfusion ##Platform_Name## Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Working with data
publishingplatform: ##Platform_Name##
documentation: ug
---


<!-- markdownlint-disable MD036 -->

# Working with data in ##Platform_Name## Chart Component

The ##Platform_Name## Chart component supports multiple data binding approaches to suit different application scenarios. Data can be bound from local JSON arrays, dynamically loaded on demand with lazy loading, or fetched from remote services using various adaptor patterns. This guide covers all available data binding methods, helping you choose the right approach for your use case based on data size, performance requirements, and backend architecture.

## Choosing a data binding approach

| Method | Best For | Advantages | Considerations |
|--------|----------|------------|-----------------|
| **Local data** | Small to medium datasets | Simple setup, no network latency, instant rendering | All data must be in memory |
| **Common datasource** | Multiple series sharing data | Reduces redundancy, single update point | Limited to data common across series |
| **Lazy loading** | Large datasets with scrolling | Loads only visible data, better performance | Requires server-side pagination |
| **Remote data (OData/WebAPI)** | Backend-driven data | Scalable, centralized data management, real-time updates | Network latency, requires service setup |
| **Offline mode** | Data caching with client-side actions | Eliminates repeated requests, faster interactions | Initial load time, memory constraints |

## Local data

Bind simple JSON data to the chart using the [`DataSource`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_DataSource) property in the series configuration. Map the JSON fields to the [`XName`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_XName) and [`YName`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_YName) properties to specify which data fields represent the x and y axis values.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/working-data/local-data/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Local-data.cs" %}
{% include code-snippet/chart/axis/working-data/local-data/local-data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/working-data/local-data/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Local-data.cs" %}
{% include code-snippet/chart/axis/working-data/local-data/local-data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Common datasource

You can also bind a JSON data common to all series using [`DataSource`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_DataSource) property in chart.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/working-data/common-data/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Common-data.cs" %}
{% include code-snippet/chart/axis/working-data/common-data/common-data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/working-data/common-data/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Common-data.cs" %}
{% include code-snippet/chart/axis/working-data/common-data/common-data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Remote data

Bind remote data from a web service by using the `DataManager` class. The DataManager simplifies communication with REST APIs, OData services, and custom web endpoints. It requires minimal configuration—typically just the service URL and an appropriate adaptor—then handles all request/response processing. Assign the DataManager instance to the [`DataSource`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_DataSource) property in the series, and map the response fields to [`XName`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_XName) and [`YName`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_YName). Use the optional [`Query`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Query) property to filter, sort, or paginate data on the server.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/working-data/remote-data/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Remote-data.cs" %}
{% include code-snippet/chart/axis/working-data/remote-data/remote-data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/working-data/remote-data/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Remote-data.cs" %}
{% include code-snippet/chart/axis/working-data/remote-data/remote-data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Binding data using ODataAdaptor

[`OData`](http://www.odata.org/documentation/odata-version-3-0/) is a standardized protocol for creating and consuming data via REST APIs. Use the ODataAdaptor with DataManager to retrieve data from OData services. The adaptor automatically constructs the correct query syntax and handles standard OData conventions.

**Example use case:** Querying a product sales service that implements OData v3.0 filtering, sorting, and pagination.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/working-data/odata-adaptor/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Odata-adaptor.cs" %}
{% include code-snippet/chart/axis/working-data/odata-adaptor/odata-adaptor.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/working-data/odata-adaptor/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Odata-adaptor.cs" %}
{% include code-snippet/chart/axis/working-data/odata-adaptor/odata-adaptor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Binding data using ODataV4Adaptor

ODataV4 is an improved and more standardized version of the OData protocol, with enhanced query capabilities and better JSON support. Use the ODataV4Adaptor to consume ODataV4 services. For more information on ODataV4 specifications, refer to the [`odata documentation`](http://docs.oasis-open.org/odata/odata/v4.0/errata03/os/complete/part1-protocol/odata-v4.0-errata03-os-part1-protocol-complete.html#_Toc453752197).

**When to use ODataV4Adaptor:** If your backend service implements OData v4.0, prefer this adaptor over the older ODataAdaptor for better compliance and features.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/working-data/odatav4-adaptor/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Odatav4-adaptor.cs" %}
{% include code-snippet/chart/axis/working-data/odatav4-adaptor/odatav4-adaptor.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/working-data/odatav4-adaptor/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Odatav4-adaptor.cs" %}
{% include code-snippet/chart/axis/working-data/odatav4-adaptor/odatav4-adaptor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Web API adaptor

Use the WebApiAdaptor to consume custom REST APIs that follow a standard response format. This adaptor is ideal for backends that do not implement OData but provide REST endpoints returning JSON data.

**Expected response format:**

The Web API must return a JSON object with two properties:
- `Items`: Array of data objects for the chart
- `Count`: Total number of records (useful for pagination)

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/working-data/web-adaptor/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Web-adaptor.cs" %}
{% include code-snippet/chart/axis/working-data/web-adaptor/web-adaptor.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/working-data/web-adaptor/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Web-adaptor.cs" %}
{% include code-snippet/chart/axis/working-data/web-adaptor/web-adaptor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

**Example response:**

The Web API should structure its response as shown below. The `Items` array contains the actual data records, and `Count` indicates the total available records (supporting server-side pagination).

```
{
    Items: [{..}, {..}, {..}, ...],
    Count: 830
}
```



## Custom adaptor

Create a custom adaptor by extending one of the built-in adaptors (typically ODataAdaptor) to add custom logic for request/response handling. Override the `processResponse` method to transform or enrich the response data. Common use cases include adding serial numbers, reformatting dates, or adding computed fields before the chart renders the data.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/working-data/custom-adaptor/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-adaptor.cs" %}
{% include code-snippet/chart/axis/working-data/custom-adaptor/custom-adaptor.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/working-data/custom-adaptor/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-adaptor.cs" %}
{% include code-snippet/chart/axis/working-data/custom-adaptor/custom-adaptor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Offline mode

When using remote data binding, all filtering, sorting, and pagination normally happen on the server. To improve responsiveness and reduce server load, enable offline mode: the chart loads all data once during initialization, then handles all interactions client-side. Set the `offline` property of DataManager to `true` to activate this behavior.

**Use offline mode when:**
- Your dataset is relatively small (fits comfortably in browser memory)
- You want instant filtering and sorting without server round-trips
- Network latency is a significant usability concern
- You prefer to minimize server requests during user interactions

**Caution:** Offline mode loads the entire dataset at once, which may impact initial load time and memory usage for large datasets.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/working-data/offline-mode/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Offline-mode.cs" %}
{% include code-snippet/chart/axis/working-data/offline-mode/offline-mode.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/working-data/offline-mode/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Offline-mode.cs" %}
{% include code-snippet/chart/axis/working-data/offline-mode/offline-mode.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Empty points

Data points with `null` or `undefined` values are treated as empty points. Empty data points are skipped and not rendered in the chart. When using the `points` property to define individual data items, customize empty points with the `EmptyPointSettings` property in the series configuration. By default, empty points create a gap in the series line or bar.

**Default behavior:** Empty points use the `Gap` mode, which leaves a blank space in the chart visualization.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/working-data/empty-points/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Empty-points.cs" %}
{% include code-snippet/chart/axis/working-data/empty-points/empty-points.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/working-data/empty-points/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Empty-points.cs" %}
{% include code-snippet/chart/axis/working-data/empty-points/empty-points.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Lazy loading

Lazy loading enables on-demand data retrieval, loading only the data required for the currently visible range. The chart fires the `scrollEnd` event when the user scrolls near the edge of the visible data range. In this event handler, retrieve the minimum and maximum values from the scrolled axis, request the corresponding data from your server, and append it to the chart. This approach is ideal for large datasets that would be expensive to load entirely into memory.

**How lazy loading works:**
1. User scrolls the chart to view a different data range
2. `scrollEnd` event fires with current axis range information
3. Fetch the corresponding data from your server
4. Append new data to the existing dataset
5. Chart automatically re-renders with the updated data

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/working-data/lazy-loading/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Local-data.cs" %}
{% include code-snippet/chart/axis/working-data/lazy-loading/local-data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/working-data/lazy-loading/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Local-data.cs" %}
{% include code-snippet/chart/axis/working-data/lazy-loading/local-data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


**Customizing empty point**

Assign a specific color to empty points by setting the `Fill` property in the `EmptyPointSettings` object. This allows you to visually distinguish empty data points from regular data in your chart.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/working-data/custom-emptypoint/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-emptypoint.cs" %}
{% include code-snippet/chart/axis/working-data/custom-emptypoint/custom-emptypoint.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/working-data/custom-emptypoint/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-emptypoint.cs" %}
{% include code-snippet/chart/axis/working-data/custom-emptypoint/custom-emptypoint.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Handling No Data

{% if page.publishingplatform == "aspnet-core" %}

When the chart has no data available to render, use the `NoDataTemplate` property to display a custom layout within the chart area. This template can include messages, images, icons, or interactive elements (such as a load button) to guide the user. The template maintains design consistency and improves user experience when data is unavailable. Once data becomes available, the chart automatically updates and replaces the template with the visualization.


{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/working-data/no-data-template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="No-data-template.cs" %}
{% include code-snippet/chart/axis/working-data/no-data-template/no-data-template.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

When the chart has no data available to render, use the `NoDataTemplate` property to display a custom layout within the chart area. This template can include messages, images, icons, or interactive elements (such as a load button) to guide the user. The template maintains design consistency and improves user experience when data is unavailable. Once data becomes available, the chart automatically updates and replaces the template with the visualization.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/working-data/no-data-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="No-data-template.cs" %}
{% include code-snippet/chart/axis/working-data/no-data-template/no-data-template.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![ASP.NET MVC Chart Control](images/nodatatemplate-chart.png)