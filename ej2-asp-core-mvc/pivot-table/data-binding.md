---
layout: post
title: Data Binding in ##Platform_Name## Pivot Table Component
description: Learn here all about Data Binding in Syncfusion ##Platform_Name## Pivot Table component and more.
platform: ej2-asp-core-mvc
control: Data Binding
publishingplatform: ##Platform_Name##
documentation: ug
---


# Data Binding

The pivot table uses `DataManager`, which supports both RESTful JSON data service binding and local JavaScript object array binding. The [`DataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettingsBuilder.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettingsBuilder_DataSource_System_Action_Syncfusion_EJ2_DataManagerBuilder__) property can be assigned either with the instance of `DataManager` or list of objects. It supports two kinds of data binding method:

* Local data
* Remote data

## Local Data

To bind local data to the pivot table, user can assign a list of object to the [`DataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettingsBuilder.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettingsBuilder_DataSource_System_Action_Syncfusion_EJ2_DataManagerBuilder__) property under [`PivotViewDataSourceSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettingsBuilder.html) class. The list data source can also be provided as an instance of the `DataManager` class.

> By default, `DataManager` uses `JsonAdaptor` for local data-binding.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/data-binding/local-data/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Localdata.cs" %}
{% include code-snippet/pivot-table/data-binding/local-data/localdata.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/data-binding/local-data/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Localdata.cs" %}
{% include code-snippet/pivot-table/data-binding/local-data/localdata.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Remote Data

To interact with remote data source, provide the endpoint `Url` within `DataManager`. By default, `DataManager` uses `ODataAdaptor` for remote data-binding.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/data-binding/remote-data/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Remotedata.cs" %}
{% include code-snippet/pivot-table/data-binding/remote-data/remotedata.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/data-binding/remote-data/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Remotedata.cs" %}
{% include code-snippet/pivot-table/data-binding/remote-data/remotedata.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Binding with OData services

OData is a standardized protocol for creating and consuming data. User can retrieve data from OData service using the `DataManager` class. Refer to the following code example for remote data binding using OData service.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/data-binding/odata/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Odata.cs" %}
{% include code-snippet/pivot-table/data-binding/odata/odata.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/data-binding/odata/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Odata.cs" %}
{% include code-snippet/pivot-table/data-binding/odata/odata.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Binding with OData V4 services

The OData V4 is an improved version of OData protocols, and the `DataManager` class can be used to retrieve and consume OData V4 services. For more details on OData V4 services, refer to the [OData documentation](http://docs.oasis-open.org/odata/odata/v4.0/errata03/os/complete/part1-protocol/odata-v4.0-errata03-os-part1-protocol-complete.html#_Toc453752197). To bind OData V4 service, use the [`ODataV4Adaptor`](https://ej2.syncfusion.com/documentation/data/adaptors/#odatav4-adaptor).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/data-binding/odatav4/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Odatav4.cs" %}
{% include code-snippet/pivot-table/data-binding/odatav4/odatav4.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/data-binding/odatav4/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Odatav4.cs" %}
{% include code-snippet/pivot-table/data-binding/odatav4/odatav4.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Web API

User can use `WebApiAdaptor` to bind pivot table with Web API created using OData endpoint.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/data-binding/webapi/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Web-api.cs" %}
{% include code-snippet/pivot-table/data-binding/webapi/web-api.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/data-binding/webapi/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Web-api.cs" %}
{% include code-snippet/pivot-table/data-binding/webapi/web-api.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Values in row axis

By default, the value fields are plotted in column axis. To plot those fields in row axis, use the `valueAxis` property by setting its value as `row`. By default, it holds the value `column`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/data-binding/values-in-row/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Valuesinrow.cs" %}
{% include code-snippet/pivot-table/data-binding/values-in-row/valuesinrow.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/data-binding/values-in-row/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Valuesinrow.cs" %}
{% include code-snippet/pivot-table/data-binding/values-in-row/valuesinrow.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![output](images/valueaxis.png)

## Show 'no data' items

By default, the pivot table only shows the field item if it has data in its row or column combination. To show all items that do not have data in row and column combination in the pivot table, use the [`ShowNoDataItems`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewRow.html#Syncfusion_EJ2_PivotView_PivotViewRow_ShowNoDataItems) property by settings its value to **true** for the desired fields. In the following code sample, rows of the "Country" and "State" fields do not have data in all combination with "Date" column field.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/data-binding/no-data/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Nodata.cs" %}
{% include code-snippet/pivot-table/data-binding/no-data/nodata.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/data-binding/no-data/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Nodata.cs" %}
{% include code-snippet/pivot-table/data-binding/no-data/nodata.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![output](images/nodata.png)

## Always shows the value headers

To show the value header always in pivot table even it holding a single value, use the [`AlwaysShowValueHeader`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_AlwaysShowValueHeader) property by settings its value as **true**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/data-binding/single-calculation-header/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Single-calculation-header.cs" %}
{% include code-snippet/pivot-table/data-binding/single-calculation-header/single-calculation-header.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/data-binding/single-calculation-header/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Single-calculation-header.cs" %}
{% include code-snippet/pivot-table/data-binding/single-calculation-header/single-calculation-header.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![output](images/valuesheader.png)

## Customize empty value cells

User can show custom string in empty value cells using the [`EmptyCellsTextContent`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_EmptyCellsTextContent) property in [`PivotViewDataSourceSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html) class of the pivot table. Since the property is of string data type, user can fill empty value cells with any value like "0", "-", "*", "(blank)", etc. Its common for all value fields and can be configured through code behind.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/data-binding/empty-cells/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Empty-cells.cs" %}
{% include code-snippet/pivot-table/data-binding/empty-cells/empty-cells.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/data-binding/empty-cells/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Empty-cells.cs" %}
{% include code-snippet/pivot-table/data-binding/empty-cells/empty-cells.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![output](images/emptyvalues.png)

## See Also

* [Aggregation](./aggregation)
* [Show/Hide Totals](./summary-customization)
* [Customize number, date, and time values](./how-to/customize-number-date-and-time-values)