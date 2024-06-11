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

## Adding a new data point

The `AddPoint` method is used to dynamically add a new data point to the chart series. This method is particularly useful when you want to update the chart with a new data point without having to refresh the entire chart. This method takes two parameters:
 
* The first parameter is the new data point to add to your existing data source.
* The optional second parameter specifies the animation duration for adding the new data point.

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

The `RemovePoint` method is used to dynamically remove a data point from the chart series. This method is particularly useful when you want to update the chart by removing an existing data point without having to refresh the entire chart. This method takes two parameters:
 
* The first parameter is the index of the data point that needs to be removed from the existing data source.
* The optional second parameter specifies the animation duration for removing the data point.

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

To replace the existing data source in the chart with a new data source, you can simply use the `SetData` method. This method allows you to replace the existing data points in the chart series with a new set of data points, enabling you to easily update the chart with new information. This method takes two parameters:
 
* The first parameter is the new set of data points to be updated.
* The optional second parameter specifies the animation duration for updating the new data source.

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

You can use mouse or touch events to dynamically add or remove data points from an existing data source by clicking on the appropriate position within the chart area. To add a new data point to the existing data source, click anywhere in the chart area, retrieve the x-axis and y-axis information of the clicked location from the `ChartMouseClick` event arguments. Then, utilize the `AddPoint` method to add a new data point to the existing data source.

To remove a data point from the existing data source, simply click on the desired data point. To achieve this, first, verify whether the clicked data point obtained from `ChartMouseClick` already exists in the data source. If it does, remove it by utilizing the `RemovePoint` method based on its index.

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


