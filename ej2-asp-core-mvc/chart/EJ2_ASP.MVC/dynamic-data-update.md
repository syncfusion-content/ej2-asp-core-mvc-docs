---
layout: post
title: Dynamic data update in ##Platform_Name## Syncfusion Chart Component
description: Learn here all about dynamic data update in Syncfusion ##Platform_Name## Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Dynamic Data Update
publishingplatform: ##Platform_Name##
documentation: ug
---


# Dynamic data update in ##Platform_Name## Chart Component

The ##Platform_Name## Chart component provides methods to dynamically modify data without requiring a full chart refresh. This enables real-time data visualization, interactive features, and responsive user experiences. Common scenarios include adding sensor readings, removing outdated data points, replacing entire datasets, and enabling click-based data manipulation.

## Adding a new data point
 
Use the `AddPoint` method to dynamically append a new data point to a series. This is useful for real-time data streams, user interactions, or incremental data loading. The method accepts the following parameters:
 
* **Data point** (required): The new data object to append to the series (must match the datasource structure)
* **Animation duration** (optional): Duration in milliseconds for the entry animation

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/dynamic-update/add-point/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Add-point.cs" %}
{% include code-snippet/chart/dynamic-update/add-point/add-point.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/dynamic-update/add-point/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Add-point.cs" %}
{% include code-snippet/chart/dynamic-update/add-point/add-point.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Removing an existing data point

Use the `RemovePoint` method to dynamically delete a data point from a series by its index. This is useful for filtering data, removing outliers, or responding to user actions. The method accepts the following parameters:
 
* **Point index** (required): The zero-based index of the data point to remove
* **Animation duration** (optional): Duration in milliseconds for the exit animation

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/dynamic-update/remove-point/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Remove-point.cs" %}
{% include code-snippet/chart/dynamic-update/remove-point/remove-point.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/dynamic-update/remove-point/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Remove-point.cs" %}
{% include code-snippet/chart/dynamic-update/remove-point/remove-point.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Replacing entire data points

Use the `SetData` method to replace all data points in a series with a new dataset. This is useful for category switching, time range changes, or complete data refreshes. The method accepts the following parameters:
 
* **New data source** (required): The complete new dataset array to display
* **Animation duration** (optional): Duration in milliseconds for the transition animation

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/dynamic-update/set-data/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Set-data.cs" %}
{% include code-snippet/chart/dynamic-update/set-data/set-data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/dynamic-update/set-data/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Set-data.cs" %}
{% include code-snippet/chart/dynamic-update/set-data/set-data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Click to add or remove a data point

Enable users to add or remove data points by clicking on the chart. Listen to the `ChartMouseClick` event to capture click coordinates and point information. When a user clicks within the chart area, extract the x and y axis values from the event arguments. If the location is empty, use `AddPoint` to add a new data point at those coordinates. If a user clicks on an existing data point, identify its index and use `RemovePoint` to delete it. This creates an intuitive interface for data exploration and editing.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/dynamic-update/click-add-point/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Click-add-point.cs" %}
{% include code-snippet/chart/dynamic-update/click-add-point/click-add-point.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/dynamic-update/click-add-point/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Click-add-point.cs" %}
{% include code-snippet/chart/dynamic-update/click-add-point/click-add-point.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


