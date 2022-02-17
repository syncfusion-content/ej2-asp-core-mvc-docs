---
layout: post
title: Data Binding in ##Platform_Name## Spreadsheet Component
description: Learn here all about Data Binding in Syncfusion ##Platform_Name## Spreadsheet component and more.
platform: ej2-asp-core-mvc
control: Data Binding
publishingplatform: ##Platform_Name##
documentation: ug
---


# Data Binding

The Spreadsheet uses [`DataManager`](../data), which supports both RESTful JSON data services and local JavaScript object array binding to a range. The `dataSource` property can be assigned either with the instance of [`DataManager`](../data) or JavaScript object array collection.

> To bind data to a cell, use `cell data binding` support.

## Local data

To bind local data to the Spreadsheet, you can assign a JavaScript object array to the `dataSource` property.

Refer to the following code example for local data binding.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/local-data-binding/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="LocalDataController.cs" %}
{% include code-snippet/spreadsheet/local-data-binding/localDataController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/local-data-binding/razor %}
{% endhighlight %}
{% highlight c# tabtitle="LocalDataController.cs" %}
{% include code-snippet/spreadsheet/local-data-binding/localDataController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> The local data source can also be provided as an instance of the [`DataManager`](../data). By default, [`DataManager`](../data) uses [`JsonAdaptor`](../data/adaptors/#json-adaptor) for local data-binding.

## Remote data

To bind remote data to the Spreadsheet control, assign service data as an instance of [`DataManager`](../data) to the `dataSource` property. To interact with remote data source, provide the service endpoint `url`.

Refer to the following code example for remote data binding.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/remote-data-binding/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="RemoteDataController.cs" %}
{% include code-snippet/spreadsheet/remote-data-binding/remoteDataController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/remote-data-binding/razor %}
{% endhighlight %}
{% highlight c# tabtitle="RemoteDataController.cs" %}
{% include code-snippet/spreadsheet/remote-data-binding/remoteDataController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> By default, `DataManager` uses **ODataAdaptor** for remote data-binding.

### Binding with OData services

`OData` is a standardized protocol for creating and consuming data. You can retrieve data from OData service using the DataManager. Refer to the following code example for remote Data binding using OData service.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/odata-adaptor/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ODataController.cs" %}
{% include code-snippet/spreadsheet/odata-adaptor/oDataController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/odata-adaptor/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ODataController.cs" %}
{% include code-snippet/spreadsheet/odata-adaptor/oDataController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Web API

You can use WebApiAdaptor to bind spreadsheet with Web API created using OData endpoint.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/webapi-adaptor/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="WebApiController.cs" %}
{% include code-snippet/spreadsheet/webapi-adaptor/webApiController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/webapi-adaptor/razor %}
{% endhighlight %}
{% highlight c# tabtitle="WebApiController.cs" %}
{% include code-snippet/spreadsheet/webapi-adaptor/webApiController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Cell data binding

The Spreadsheet control can bind the data to individual cell in a sheet . To achive this you can use the
`value` property.

Refer to the following code example for cell data binding.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/cell-data-binding/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CellDataController.cs" %}
{% include code-snippet/spreadsheet/cell-data-binding/cellDataController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/cell-data-binding/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CellDataController.cs" %}
{% include code-snippet/spreadsheet/cell-data-binding/cellDataController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> The cell data binding also supports formula, style, number format, and more.

## Dynamic data binding and Datasource change event

You can dynamically change the datasource of the spreadsheet by changing the `dataSource` property of the `range` object of the `sheet`. The `dataSourceChanged` event handler will be triggered when editing, inserting, and deleting a row in the datasource range. This event will be triggered with a parameter named `action` which indicates the `edit`, `add` and `delete` actions for the respective ones.

The following table defines the arguments of the `dataSourceChanged` event.

| Property | Type | Description |
|-----|-----|-------|
| action | string | Indicates the type of action such as `edit`, `add`, and `delete` performed in the datasource range. |
| data | object[] | Modified data for `edit` action; New data for `add` action; Deleted data for `delete` action. |
| rangeIndex | number | Specifies the range index of the datasource. |
| sheetIndex | number | Specifies the sheet index of the datasource. |

> For `add` action, the value for all the fields will be `null` in the data. In the case that you do not want the primary key field to be null which needs to be updated in the backend service, you can use `edit` action after updating the primary key field to update in the backend service. <br><br>
> For inserting a row at the end of the datasource range, you should insert a row below at the end of the range to trigger the `dataSourceChanged` event with action `add`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/dynamic-data-binding/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="DynamicDataController.cs" %}
{% include code-snippet/spreadsheet/dynamic-data-binding/dynamicDataController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/dynamic-data-binding/razor %}
{% endhighlight %}
{% highlight c# tabtitle="DynamicDataController.cs" %}
{% include code-snippet/spreadsheet/dynamic-data-binding/dynamicDataController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [Filtering](./filter)
* [Sorting](./sort)
* [Hyperlink](./link)
* [`Collaborative Editing`](use-cases/collaborative-editing)