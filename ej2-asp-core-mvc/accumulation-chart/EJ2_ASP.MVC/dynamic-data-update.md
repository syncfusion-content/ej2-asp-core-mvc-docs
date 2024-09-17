---
layout: post
title: Dynamic data update in ##Platform_Name## Syncfusion Accumulation Chart Component
description: Learn here all about dynamic data update in Syncfusion ##Platform_Name## Accumulation Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Dynamic Data Update
publishingplatform: ##Platform_Name##
documentation: ug
---


# Dynamic data update in ##Platform_Name## Accumulation Chart Component

## Adding a new data point

The `AddPoint` method is used to dynamically add a new data point to the accumulation chart series. This method is particularly useful when you want to update the chart with a new data point without having to refresh the entire accumulation chart. This method takes two parameters:

* The first parameter is the new data point to add to your existing data source.
* The optional second parameter specifies the animation duration for adding the new data point.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/dynamic-update/add-point/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Add-point.cs" %}
{% include code-snippet/chart/accumulation-charts/dynamic-update/add-point/add-point.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/dynamic-update/add-point/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Add-point.cs" %}
{% include code-snippet/chart/accumulation-charts/dynamic-update/add-point/add-point.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Removing an existing data point

The `RemovePoint` method is used to dynamically remove a data point from the accumulation chart series. This method is particularly useful when you want to update the accumulation chart by removing an existing data point without having to refresh the entire accumulation chart. This method takes two parameters:

* The first parameter is the index of the data point that needs to be removed from the existing data source.
* The optional second parameter specifies the animation duration for removing the data point.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/dynamic-update/remove-point/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Remove-point.cs" %}
{% include code-snippet/chart/accumulation-charts/dynamic-update/remove-point/remove-point.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/dynamic-update/remove-point/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Remove-point.cs" %}
{% include code-snippet/chart/accumulation-charts/dynamic-update/remove-point/remove-point.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Replacing entire data points

To replace the existing data source in the accumulation chart with a new data source, you can simply use the `SetData` method. This method allows you to replace the existing data points in the accumulation chart series with a new set of data points, enabling you to easily update the accumulation chart with new information. This method takes two parameters:

* The first parameter is the new set of data points to be updated.
* The optional second parameter specifies the animation duration for updating the new data source.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/dynamic-update/set-data/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Set-data.cs" %}
{% include code-snippet/chart/accumulation-charts/dynamic-update/set-data/set-data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/dynamic-update/set-data/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Set-data.cs" %}
{% include code-snippet/chart/accumulation-charts/dynamic-update/set-data/set-data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


