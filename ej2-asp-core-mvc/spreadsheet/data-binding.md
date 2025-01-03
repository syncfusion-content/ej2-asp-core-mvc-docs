---
layout: post
title: Data Binding in ##Platform_Name## Spreadsheet Control | Syncfusion
description: Learn here all about Data Binding in Syncfusion ##Platform_Name## Spreadsheet component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Data Binding
publishingplatform: ##Platform_Name##
documentation: ug
---


# Data Binding in Spreadsheet Control

The Spreadsheet uses `DataManager`, which supports both RESTful JSON data services and local JavaScript object array binding to a range. The `dataSource` property can be assigned either with the instance of `DataManager` or JavaScript object array collection.

N> To bind data to a cell, use `cell data binding` support.

## Local data

To bind local data to the Spreadsheet, you can assign a JavaScript object array to the `dataSource` property.

Refer to the following code example for local data binding.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/local-data-binding/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="LocalDataController.cs" %}
{% include code-snippet/spreadsheet/local-data-binding/Core/localDataController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/local-data-binding/razor %}
{% endhighlight %}
{% highlight c# tabtitle="LocalDataController.cs" %}
{% include code-snippet/spreadsheet/local-data-binding/MVC/localDataController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}




N> The local data source can also be provided as an instance of the `DataManager`. By default, `DataManager` uses `JsonAdaptor` for local data-binding.

### Customizing column data mapping

By default, when a data source is bound to a sheet, columns are auto-assigned from the data source fields sequentially. This means that the first field in the data source is assigned to Column A, the second to Column B, and so on, sequentially. However, now you can customize the column assignments by specifying the appropriate field names in the desired order using the `fieldsOrder` property.

> You can customize the mapping of column data only in the local data binding support.

The following code example demonstrates how to customize the mapping of column data:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/field-mapping/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="FieldMappingController.cs" %}
{% include code-snippet/spreadsheet/field-mapping/Core/fieldMappingController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/field-mapping/razor %}
{% endhighlight %}
{% highlight c# tabtitle="FieldMappingController.cs" %}
{% include code-snippet/spreadsheet/field-mapping/MVC/fieldMappingController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Remote data

To bind remote data to the Spreadsheet control, assign service data as an instance of `DataManager` to the `dataSource` property. To interact with remote data source, provide the service endpoint `url`.

Refer to the following code example for remote data binding.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/remote-data-binding/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="RemoteDataController.cs" %}
{% include code-snippet/spreadsheet/remote-data-binding/Core/remoteDataController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/remote-data-binding/razor %}
{% endhighlight %}
{% highlight c# tabtitle="RemoteDataController.cs" %}
{% include code-snippet/spreadsheet/remote-data-binding/MVC/remoteDataController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



N> By default, `DataManager` uses **ODataAdaptor** for remote data-binding.

### Binding with OData services

`OData` is a standardized protocol for creating and consuming data. You can retrieve data from OData service using the DataManager. Refer to the following code example for remote Data binding using OData service.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/odata-adaptor/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ODataController.cs" %}
{% include code-snippet/spreadsheet/odata-adaptor/Core/oDataController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/odata-adaptor/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ODataController.cs" %}
{% include code-snippet/spreadsheet/odata-adaptor/MVC/oDataController.cs %}
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
{% include code-snippet/spreadsheet/webapi-adaptor/Core/webApiController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/webapi-adaptor/razor %}
{% endhighlight %}
{% highlight c# tabtitle="WebApiController.cs" %}
{% include code-snippet/spreadsheet/webapi-adaptor/MVC/webApiController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Cell data binding

The Spreadsheet control can bind the data to individual cell in a sheet . To achive this you can use the `value` property.

Refer to the following code example for cell data binding.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/cell-data-binding/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CellDataController.cs" %}
{% include code-snippet/spreadsheet/cell-data-binding/Core/cellDataController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/cell-data-binding/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CellDataController.cs" %}
{% include code-snippet/spreadsheet/cell-data-binding/MVC/cellDataController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



N> The cell data binding also supports formula, style, number format, and more.

## Dynamic data binding and Datasource change event

You can dynamically change the datasource of the spreadsheet by changing the `dataSource` property of the `range` object of the `sheet`. The `dataSourceChanged` event handler will be triggered when editing, inserting, and deleting a row in the datasource range. This event will be triggered with a parameter named `action` which indicates the `edit`, `add` and `delete` actions for the respective ones.

The following table defines the arguments of the `dataSourceChanged` event.

| Property | Type | Description |
|-----|-----|-------|
| action | string | Indicates the type of action such as `edit`, `add`, and `delete` performed in the datasource range. |
| data | object[] | Modified data for `edit` action; New data for `add` action; Deleted data for `delete` action. |
| rangeIndex | number | Specifies the range index of the datasource. |
| sheetIndex | number | Specifies the sheet index of the datasource. |

N> For `add` action, the value for all the fields will be `null` in the data. In the case that you do not want the primary key field to be null which needs to be updated in the backend service, you can use `edit` action after updating the primary key field to update in the backend service. <br><br>
<br/> For inserting a row at the end of the datasource range, you should insert a row below at the end of the range to trigger the `dataSourceChanged` event with action `add`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/dynamic-data-binding/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="DynamicDataController.cs" %}
{% include code-snippet/spreadsheet/dynamic-data-binding/Core/dynamicDataController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/dynamic-data-binding/razor %}
{% endhighlight %}
{% highlight c# tabtitle="DynamicDataController.cs" %}
{% include code-snippet/spreadsheet/dynamic-data-binding/MVC/dynamicDataController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Dynamic data binding using updateRange method

The `updateRange` method allows you to dynamically update the `dataSource` in a spreadsheet without manually iterating through each cell. This method is especially useful for efficiently applying bulk updates to a specific range within the spreadsheet.

To use the `updateRange` method, provide the new `dataSource` and specify the starting cell for the update using the `startCell` property of the `RangeModel`. Additionally, set the `sheetIndex` to target the appropriate sheet for the update.

The following code example demonstrates how to dynamically update data using the `updateRange` method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/dynamic-data-binding-cs2/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="UpdateRangeController.cs" %}
{% include code-snippet/spreadsheet/dynamic-data-binding-cs2/Core/updateRangeController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/dynamic-data-binding-cs2/razor %}
{% endhighlight %}
{% highlight c# tabtitle="UpdateRangeController.cs" %}
{% include code-snippet/spreadsheet/dynamic-data-binding-cs2/MVC/updateRangeController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## See Also

* [Filtering](filter)
* [Sorting](sort)
* [Hyperlink](link)