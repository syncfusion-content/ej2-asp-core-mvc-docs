---
title: "Autocomplete Data binding"
component: "AutoComplete"
description: "This section for Essential JS2 Syncfusion ASP.NET autocomplete control shows how to bind with local data source and how to fetch data from remote data service."
---

# Data binding

The AutoComplete loads the data either from local data sources or remote data services using the [dataSource](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.AutoCompleteBuilder~DataSource.html) property. It supports the data type of array or [DataManager](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DataManager_members.html).

The AutoComplete also supports different kind of data services such as OData, OData V4, Web API and data formats such as XML, JSON, JSONP with the help of DataManager Adaptors.

| Fields | Type | Description |
|------|------|-------------|
| value |  `number or string` | Specifies the hidden data value mapped to each list item that should contain a unique value. |
| groupBy |  `string` | Specifies the category under which the list item has to be grouped. |
| iconCss |  `string` | Specifies the icon class of each list item. |

>While binding complex data to AutoComplete, fields should be mapped correctly. Otherwise, the selected
item remains undefined.

## Bind to local data

Local data can be represented in two ways as described below.

### Array of string

The AutoComplete has support to load array of primitive data such as strings and numbers.

{% aspTab template="autocomplete/data-binding/arrayofstrings", sourceFiles="arrayofstrings.cs" %}

{% endaspTab %}

### Array of object

The AutoComplete can generate its list items through an array of complex data. For this,
the appropriate columns should be mapped to the [fields](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.AutoCompleteBuilder~Fields.html) property.

In the following example, `Name` column from complex data have been mapped to the `value` field.

{% aspTab template="autocomplete/data-binding/arrayofobjects", sourceFiles="Countries.cs,arrayofobjects.cs" %}

{% endaspTab %}

### Array of complex object

The AutoComplete can generate its list items through an array of complex data. For this,
the appropriate columns should be mapped to the [fields](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.AutoCompleteBuilder~Fields.html) property.

In the following example, `Country.CountryId` column from complex data have been mapped to the `value` field.

{% aspTab template="autocomplete/data-binding/complexdata", sourceFiles="complexdata.cs,Complex.cs" %}

{% endaspTab %}

## Bind to remote data

The AutoComplete supports retrieval of data from remote data services with the help of
[DataManager](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DataManager_members.html) control. The [Query](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.AutoComplete~Query.html)
property is used to fetch data from the database and bind it to the AutoComplete.

The following sample displays the first 6 contacts from the `Customers` table of the `Northwind` data service.

{% aspTab template="autocomplete/data-binding/remotedata", sourceFiles="remotedata.cs" %}

{% endaspTab %}

### Bind to URL Adaptor

The AutoComplete supports retrieval of data from URL adaptor.

{% aspTab template="autocomplete/data-binding/urladaptor", sourceFiles="urldata.cs" %}

{% endaspTab %}

### Web API Adaptor

Use the `WebApiAdaptor` to bind autocomplete with Web API created using OData.

{% aspTab template="autocomplete/data-binding/webapi", sourceFiles="webapi.cs" %}

{% endaspTab %}

### Binding with OData services

`OData` is a standardized protocol for creating and consuming data. You can retrieve data from OData service using the DataManager.

The following example for remote data binding using OData service.

{% aspTab template="autocomplete/data-binding/odata", sourceFiles="odata.cs" %}

{% endaspTab %}

### Offline mode

To avoid post back for every action, set the autocomplete to load all data on initialization and make the actions process in client-side. To enable this behavior, use the `Offline` property of `DataManager`.

The following example for remote data binding and enabled offline mode.

{% aspTab template="autocomplete/data-binding/offline", sourceFiles="offline.cs" %}

{% endaspTab %}

## See Also

* [How to load data using template](./templates/#item-template)
* [How to group the data using header](./grouping/)
* [How to filter the bound data](./filtering/)
