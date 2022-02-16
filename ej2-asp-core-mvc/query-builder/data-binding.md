---
layout: post
title: Data Binding in ##Platform_Name## Query Builder Component
description: Learn here all about Data Binding in Syncfusion ##Platform_Name## Query Builder component and more.
platform: ej2-asp-core-mvc
control: Data Binding
publishingplatform: ##Platform_Name##
documentation: ug
---


# Data binding

The Query Builder uses `DataManager` to bind the data source, which supports both RESTful JSON data services binding and local JavaScript object array binding. The `DataSource` property can be assigned either with the instance of `DataManager` or JavaScript object array collection. It supports two kinds of data binding method.

* Local data
* Remote data

## Local Data

To bind local data to the query builder, you can assign the `DataSource` property with a JavaScript object array. The local data source can also be provided as an instance of the `DataManager`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/query-builder/getting-started/demo/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/query-builder/getting-started/demo/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/query-builder/getting-started/demo/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/query-builder/getting-started/demo/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> By default, DataManager uses JsonAdaptor for local data-binding.

## Remote data

To bind remote  data to the query builder, assign service data as an instance of  `DataManager` to the [`dataSource`](https://ej2.syncfusion.com/documentation/api/query-builder/#datasource) property. To interact with remote data source, provide the endpoint `url`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/query-builder/data-binding/Remote-data/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Remotedata.cs" %}
{% include code-snippet/query-builder/data-binding/Remote-data/remotedata.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/query-builder/data-binding/Remote-data/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Remotedata.cs" %}
{% include code-snippet/query-builder/data-binding/Remote-data/remotedata.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> By default, `DataManager` uses `ODataAdaptor` for remote data-binding.

### Binding with OData services

[`OData`](https://www.odata.org/documentation/odata-version-3-0/) is a standardized protocol for creating and consuming data. You can retrieve data from OData service using the DataManager. Refer to the following code example for remote Data binding using OData service.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/query-builder/data-binding/odata/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Odata.cs" %}
{% include code-snippet/query-builder/data-binding/odata/odata.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/query-builder/data-binding/odata/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Odata.cs" %}
{% include code-snippet/query-builder/data-binding/odata/odata.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Binding with ODatav4 services

The ODatav4 is an improved version of OData protocols, and the `DataManager` can also retrieve and consume ODatav4 services. For more details on ODatav4 services, refer to the [`odata documentation`](http://docs.oasis-open.org/odata/odata/v4.0/errata03/os/complete/part1-protocol/odata-v4.0-errata03-os-part1-protocol-complete.html#_Toc453752197). To bind ODatav4 service, use the `ODataV4Adaptor`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/query-builder/data-binding/odatav4/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Odatav4.cs" %}
{% include code-snippet/query-builder/data-binding/odatav4/odatav4.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/query-builder/data-binding/odatav4/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Odatav4.cs" %}
{% include code-snippet/query-builder/data-binding/odatav4/odatav4.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Web API

You can use `WebApiAdaptor` to bind query builder with Web API created using OData endpoint.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/query-builder/data-binding/web-api/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Webapi.cs" %}
{% include code-snippet/query-builder/data-binding/web-api/webapi.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/query-builder/data-binding/web-api/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Webapi.cs" %}
{% include code-snippet/query-builder/data-binding/web-api/webapi.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Url adaptor

You can use the UrlAdaptor of DataManager when binding data source from remote data. In the initial load of querybuilder, data are fetched from remote data and bound to the querybuilder using url property of DataManager.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/query-builder/data-binding/url-data/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Url-data.cs" %}
{% include code-snippet/query-builder/data-binding/url-data/url-data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/query-builder/data-binding/url-data/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Url-data.cs" %}
{% include code-snippet/query-builder/data-binding/url-data/url-data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Support with Data Manager

You can use the created conditions in DataManager through the `getPredicate` method, which results the filtered records.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/query-builder/data-binding/data-manager/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/query-builder/data-binding/data-manager/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/query-builder/data-binding/data-manager/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/query-builder/data-binding/data-manager/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Grid Integration with QueryBuilder

This section explains how to integrate Grid with QueryBuilder. We have used `UrlAdaptor` to load dataSource to Grid, and the dataSource property is optional for QueryBuilder. So, you can create QueryBuilder with only columns. QueryBuilder interacts with Grid through the `Query` property of a Grid. You can get the query from QueryBuilder and update the Grid Query property in the `ruleChange` event of QueryBuilder. The `UrlAdaptor` works based on the on-demand concept, it will load only current page records from the server and request the next page records when navigating to the next page. Also, we have sent the request to the server for every action performed in the Grid.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/query-builder/data-binding/grid-integration/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/query-builder/data-binding/grid-integration/HomeController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/query-builder/data-binding/grid-integration/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/query-builder/data-binding/grid-integration/HomeController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

