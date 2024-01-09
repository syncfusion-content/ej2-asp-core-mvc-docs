---
layout: post
title: Working with data source in ##Platform_Name## 3D Chart Component
description: Learn here all about working with data source in Syncfusion ##Platform_Name## 3D Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Working With Data
publishingplatform: ##Platform_Name##
documentation: ug
---

# Working with data in ##Platform_Name## 3D Chart Component

## Local data

A simple JSON data can be bound to the 3D chart using [`DataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart3DSeries.html#Syncfusion_EJ2_Charts_Chart3DSeries_DataSource) property in series. Now map the fields in JSON to [`XName`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart3DSeries.html#Syncfusion_EJ2_Charts_Chart3DSeries_XName) and [`YName`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart3DSeries.html#Syncfusion_EJ2_Charts_Chart3DSeries_YName) properties.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/working-data/local-data/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Local-data.cs" %}
{% include code-snippet/3d-chart/series/working-data/local-data/local-data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/working-data/local-data/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Local-data.cs" %}
{% include code-snippet/3d-chart/series/working-data/local-data/local-data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Remote data

The remote data can be bound to the 3D chart using the `DataManager`. The `DataManager` requires minimal information like web service URL, adaptor and cross domain to interact with service endpoint properly. Assign the instance of the `DataManager` to the [`DataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart3DSeries.html#Syncfusion_EJ2_Charts_Chart3DSeries_DataSource) property in series and map the fields of data to [`XName`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart3DSeries.html#Syncfusion_EJ2_Charts_Chart3DSeries_XName) and [`YName`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart3DSeries.html#Syncfusion_EJ2_Charts_Chart3DSeries_YName) properties. You can also use the [`Query`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart3DSeries.html#Syncfusion_EJ2_Charts_Chart3DSeries_Query) property of the series to filter the data.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/working-data/remote-data/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Remote-data.cs" %}
{% include code-snippet/3d-chart/series/working-data/remote-data/remote-data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/working-data/remote-data/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Remote-data.cs" %}
{% include code-snippet/3d-chart/series/working-data/remote-data/remote-data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Binding data using ODataAdaptor

`OData` is a standardized protocol for creating and consuming data. You can retrieve data from OData service using the `DataManager`. Refer to the following code example for remote Data binding using OData service.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/working-data/adaptor/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Adaptor.cs" %}
{% include code-snippet/3d-chart/series/working-data/adaptor/adaptor.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/working-data/adaptor/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Adaptor.cs" %}
{% include code-snippet/3d-chart/series/working-data/adaptor/adaptor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Empty points

The data points that uses the `null` or `undefined` as value are considered as empty points. The empty data points are ignored and is not plotted in the chart. When the data is provided by using the points property, by using [`EmptyPointSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart3DSeries.html#Syncfusion_EJ2_Charts_Chart3DSeries_EmptyPointSettings) property in series, the empty can be customized. The default [`Mode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart3DEmptyPointSettings.html#Syncfusion_EJ2_Charts_Chart3DEmptyPointSettings_Mode) of the empty point is **Gap**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/working-data/empty-points/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Empty-points.cs" %}
{% include code-snippet/3d-chart/series/working-data/empty-points/empty-points.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/working-data/empty-points/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Empty-points.cs" %}
{% include code-snippet/3d-chart/series/working-data/empty-points/empty-points.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Customizing empty point**

The specific color for empty point can be set by the [`Fill`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart3DEmptyPointSettings.html#Syncfusion_EJ2_Charts_Chart3DEmptyPointSettings_Fill) property in [`EmptyPointSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart3DSeries.html#Syncfusion_EJ2_Charts_Chart3DSeries_EmptyPointSettings).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/working-data/custom-emptypoint/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-emptypoint.cs" %}
{% include code-snippet/3d-chart/series/working-data/custom-emptypoint/custom-emptypoint.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/working-data/custom-emptypoint/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-emptypoint.cs" %}
{% include code-snippet/3d-chart/series/working-data/custom-emptypoint/custom-emptypoint.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

