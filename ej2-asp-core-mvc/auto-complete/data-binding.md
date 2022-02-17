---
layout: post
title: Data Binding in ##Platform_Name## Auto Complete Component
description: Learn here all about Data Binding in Syncfusion ##Platform_Name## Auto Complete component and more.
platform: ej2-asp-core-mvc
control: Data Binding
publishingplatform: ##Platform_Name##
documentation: ug
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

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/data-binding/arrayofstrings/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Arrayofstrings.cs" %}
{% include code-snippet/autocomplete/data-binding/arrayofstrings/arrayofstrings.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/data-binding/arrayofstrings/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Arrayofstrings.cs" %}
{% include code-snippet/autocomplete/data-binding/arrayofstrings/arrayofstrings.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Array of object

The AutoComplete can generate its list items through an array of complex data. For this,
the appropriate columns should be mapped to the [fields](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.AutoCompleteBuilder~Fields.html) property.

In the following example, `Name` column from complex data have been mapped to the `value` field.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/data-binding/arrayofobjects/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Arrayofobjects.cs" %}
{% include code-snippet/autocomplete/data-binding/arrayofobjects/arrayofobjects.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/data-binding/arrayofobjects/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Arrayofobjects.cs" %}
{% include code-snippet/autocomplete/data-binding/arrayofobjects/arrayofobjects.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Array of complex object

The AutoComplete can generate its list items through an array of complex data. For this,
the appropriate columns should be mapped to the [fields](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.AutoCompleteBuilder~Fields.html) property.

In the following example, `Country.CountryId` column from complex data have been mapped to the `value` field.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/data-binding/complexdata/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Complex.cs" %}
{% include code-snippet/autocomplete/data-binding/complexdata/Complex.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/data-binding/complexdata/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Complex.cs" %}
{% include code-snippet/autocomplete/data-binding/complexdata/Complex.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Bind to remote data

The AutoComplete supports retrieval of data from remote data services with the help of
[DataManager](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DataManager_members.html) control. The [Query](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.AutoComplete~Query.html)
property is used to fetch data from the database and bind it to the AutoComplete.

The following sample displays the first 6 contacts from the `Customers` table of the `Northwind` data service.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/data-binding/remotedata/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Remotedata.cs" %}
{% include code-snippet/autocomplete/data-binding/remotedata/remotedata.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/data-binding/remotedata/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Remotedata.cs" %}
{% include code-snippet/autocomplete/data-binding/remotedata/remotedata.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Bind to URL Adaptor

The AutoComplete supports retrieval of data from URL adaptor.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/data-binding/urladaptor/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Urldata.cs" %}
{% include code-snippet/autocomplete/data-binding/urladaptor/urldata.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/data-binding/urladaptor/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Urldata.cs" %}
{% include code-snippet/autocomplete/data-binding/urladaptor/urldata.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Web API Adaptor

Use the `WebApiAdaptor` to bind autocomplete with Web API created using OData.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/data-binding/webapi/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Webapi.cs" %}
{% include code-snippet/autocomplete/data-binding/webapi/webapi.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/data-binding/webapi/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Webapi.cs" %}
{% include code-snippet/autocomplete/data-binding/webapi/webapi.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Binding with OData services

`OData` is a standardized protocol for creating and consuming data. You can retrieve data from OData service using the DataManager.

The following example for remote data binding using OData service.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/data-binding/odata/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Odata.cs" %}
{% include code-snippet/autocomplete/data-binding/odata/odata.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/data-binding/odata/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Odata.cs" %}
{% include code-snippet/autocomplete/data-binding/odata/odata.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Offline mode

To avoid post back for every action, set the autocomplete to load all data on initialization and make the actions process in client-side. To enable this behavior, use the `Offline` property of `DataManager`.

The following example for remote data binding and enabled offline mode.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/data-binding/offline/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Offline.cs" %}
{% include code-snippet/autocomplete/data-binding/offline/offline.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/data-binding/offline/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Offline.cs" %}
{% include code-snippet/autocomplete/data-binding/offline/offline.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [How to load data using template](./templates/#item-template)
* [How to group the data using header](./grouping/)
* [How to filter the bound data](./filtering/)
