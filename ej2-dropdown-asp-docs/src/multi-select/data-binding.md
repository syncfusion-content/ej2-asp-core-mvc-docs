---
title: "Multiselect Data binding"
component: "MultiSelect"
description: "This section for Syncfusion ASP.NET multiselect control shows how to bind with local data source and how to fetch data from remote data service."
---

# Data Binding

The MultiSelect loads the data either from local data sources or
remote data services using the [dataSource](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.MultiSelect~DataSource.html) property. It supports the data type of `array` or [DataManager](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DataManager_members.html).

The MultiSelect also supports different kinds of data services such as OData, OData V4, and Web API, and data formats such as XML, JSON, and JSONP with the help of [DataManager](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DataManager_members.html) adaptors.

| Fields | Type | Description |
|------|------|-------------|
| text |  `string` | Specifies the display text of each list item. |
| value |  `number or string` | Specifies the hidden data value mapped to each list item that should contain a unique value. |
| groupBy |  `string` | Specifies the category under which the list item has to be grouped. |
| iconCss |  `string` | Specifies the icon class of each list item. |

> When binding complex data to the MultiSelect, fields should be mapped correctly. Otherwise, the selected item remains undefined.

## Binding local data

Local data can be represented in two ways as described below.

### 1. Array of string

The MultiSelect has support to load array of primitive data such as strings and numbers. Here, both value and text field act the same.

{% aspTab template="multiselect/data-binding/arrayofstrings", sourceFiles="arrayofstrings.cs" %}

{% endaspTab %}

### 2. Array of object

The MultiSelect can generate its list items through an array of complex data. For this,
the appropriate columns should be mapped to the [fields](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.MultiSelect~fields.html) property.

In the following example, `Id` column and `Game` column from complex data have been mapped to the `value` field and `text` field, respectively.

{% aspTab template="multiselect/data-binding/arrayofobjects", sourceFiles="arrayofobjects.cs,GameList.cs" %}

{% endaspTab %}

### 3. Array of complex object

The MultiSelect can generate its list items through an array of complex data. For this,
the appropriate columns should be mapped to the [`fields`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.MultiSelect~fields.html) property.

In the following example, `Code.Id` column and `Country.CountryId` column from complex data have been mapped to the `value` field and `text` field, respectively.

{% aspTab template="multiselect/data-binding/complexdata", sourceFiles="complexdata.cs,Complex.cs" %}

{% endaspTab %}

## Binding remote data

The MultiSelect supports retrieval of data from remote data services with the help of `DataManager` control. The `Query` property is used to fetch
data from the database and bind it to the MultiSelect.

The following sample displays the first 6 contacts from “Customers” table of the `Northwind` Data Service.

{% aspTab template="multiselect/data-binding/remotedata", sourceFiles="remotedata.cs" %}

{% endaspTab %}

### Bind to URL Adaptor

The MultiSelect supports retrieval of data from URL adaptor.

{% aspTab template="multiselect/data-binding/urladaptor", sourceFiles="urldata.cs" %}

{% endaspTab %}

### Web API Adaptor

Use the `WebApiAdaptor` to bind MultiSelect with Web API created using OData.

{% aspTab template="multiselect/data-binding/webapi", sourceFiles="webapi.cs" %}

{% endaspTab %}

### Binding with OData services

`OData` is a standardized protocol for creating and consuming data. You can retrieve data from OData service using the DataManager.

The following example for remote data binding using OData service.

{% aspTab template="multiselect/data-binding/odata", sourceFiles="odata.cs" %}

{% endaspTab %}

### Offline mode

To avoid post back for every action, set the MultiSelect to load all data on initialization and make the actions process in client-side. To enable this behavior, use the `Offline` property of `DataManager`.

The following example for remote data binding and enabled offline mode.

{% aspTab template="multiselect/data-binding/offline", sourceFiles="offline.cs" %}

{% endaspTab %}

## See Also

* [How to load data using template](./templates/#item-template)
* [How to group the data using header](./grouping/)
* [How to filter the bound data](./filtering/)
