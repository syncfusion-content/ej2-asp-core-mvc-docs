---
title: "Data Binding"
component: "In-place Editor"
description: "Learn how to bind local and remote data for dependent controls of the Syncfusion ASP.NET MVC In-place Editor control."
---

# Data Binding

The Syncfusion ASP.NET MVC controls load the data either from local data sources or remote data services using the `dataSource` property and it supports the data type of an array or `DataManager`. Also supports different kind of data services such as OData, OData V4, Web API, and data formats such as XML, JSON, JSONP with the help of `DataManager` adaptors.

## Local

To bind local data to the Syncfusion ASP.NET MVC controls, you can assign a JavaScript array of object or string to the `dataSource` property. The local data source can also be provided as an instance of the `DataManager`.

{% aspTab template="in-place-editor/data", sourceFiles="controller.cs" %}

{% endaspTab %}

The output will be as follows.

![data](./images/data.PNG)

## Remote

To bind remote data to the Syncfusion ASP.NET MVC control, assign service data as an instance of `DataManager` to the `dataSource` property. To interact with remote data source, provide the endpoint URL.

### OData V4

The OData V4 is an improved version of OData protocols, and the `DataManager` can also retrieve and consume OData V4 services. To fetch data from the server by using `DataManager` with the adaptor property configure as `ODataV4Adaptor`.

In the following sample, In-place Editor renders a `DropDownList` control and its `dataSource` property configured for fetching a data from the server by using `ODataV4Adaptor` with `DataManager`.

{% aspTab template="in-place-editor/odata", sourceFiles="controller.cs" %}

{% endaspTab %}

The output will be as follows.

![odata](./images/odata.png)

### Web API

Data can fetch from the server by using `DataManager` with the adaptor property configure as WebApiAdaptor.

In the following sample, In-place Editor render a `DropDownList` control and its `dataSource` property configured for fetching a data from the server by using `WebApiAdaptor` with `DataManager`.

{% aspTab template="in-place-editor/webapi", sourceFiles="controller.cs" %}

{% endaspTab %}

The output will be as follows.

![webapi](./images/webapi.png)