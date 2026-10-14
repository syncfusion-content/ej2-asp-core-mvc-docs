---
layout: post
title: Data Binding in ##Platform_Name## MultiSelect | Syncfusion
description: Bind Syncfusion ##Platform_Name## MultiSelect to local arrays or remote data services using the dataSource property and DataManager with OData and Web API.
platform: ej2-asp-core-mvc
control: Data Binding
publishingplatform: ##Platform_Name##
documentation: ug
---


# Data Binding in ##Platform_Name## MultiSelect

The MultiSelect loads data either from local data sources or remote data services using the [dataSource](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.MultiSelect.html#Syncfusion_EJ2_DropDowns_MultiSelect_DataSource) property. It accepts data of type `array` or [DataManager](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.Data.html).

The MultiSelect also supports different kinds of data services such as OData, OData V4, and Web API, and data formats such as XML, JSON, and JSONP with the help of [DataManager](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.Data.html) adaptors.

| Field | Type | Description |
| --- | --- | --- |
| text | `string` | Specifies the display text of each list item. |
| value | `number or string` | Specifies the hidden data value mapped to each list item; it should contain a unique value. |
| groupBy | `string` | Specifies the category under which the list item is grouped. |
| iconCss | `string` | Specifies the icon class of each list item. |

N> When binding complex data to the MultiSelect, fields must be mapped correctly. Otherwise, the selected item is undefined.

## Binding local data

Local data can be represented in one of the following ways.

### 1. Array of strings

The MultiSelect supports loading an array of primitive data such as strings and numbers. Here, both the value and text fields act the same.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multiselect/data-binding/arrayofstrings/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Arrayofstrings.cs" %}
{% include code-snippet/multiselect/data-binding/arrayofstrings/arrayofstrings.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multiselect/data-binding/arrayofstrings/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Arrayofstrings.cs" %}
{% include code-snippet/multiselect/data-binding/arrayofstrings/arrayofstrings.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### 2. Array of objects

The MultiSelect can generate its list items from an array of complex data. For this, the appropriate columns must be mapped to the [fields](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.MultiSelect.html#Syncfusion_EJ2_DropDowns_MultiSelect_Fields) property.

In the following example, the `Id` and `Game` columns from the complex data are mapped to the `value` and `text` fields, respectively.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multiselect/data-binding/arrayofobjects/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="GameList.cs" %}
{% include code-snippet/multiselect/data-binding/arrayofobjects/GameList.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multiselect/data-binding/arrayofobjects/razor %}
{% endhighlight %}
{% highlight c# tabtitle="GameList.cs" %}
{% include code-snippet/multiselect/data-binding/arrayofobjects/GameList.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### 3. Array of complex objects

The MultiSelect can generate its list items from an array of complex data with nested objects. For this, the appropriate columns must be mapped to the [`fields`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.MultiSelect.html#Syncfusion_EJ2_DropDowns_MultiSelect_Fields) property using dot notation.

In the following example, the `Code.Id` and `Country.CountryId` columns from the complex data are mapped to the `value` and `text` fields, respectively.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multiselect/data-binding/complexdata/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Complex.cs" %}
{% include code-snippet/multiselect/data-binding/complexdata/Complex.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multiselect/data-binding/complexdata/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Complex.cs" %}
{% include code-snippet/multiselect/data-binding/complexdata/Complex.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Binding remote data

The MultiSelect supports retrieval of data from remote data services with the help of the `DataManager` control. The [Query](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.MultiSelect.html#Syncfusion_EJ2_DropDowns_MultiSelect_Query) property is used to fetch data from the data source and bind it to the MultiSelect.

The following sample displays the first 6 contacts from the **Customers** table of the `Northwind` data service.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multiselect/data-binding/remotedata/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Remotedata.cs" %}
{% include code-snippet/multiselect/data-binding/remotedata/remotedata.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multiselect/data-binding/remotedata/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Remotedata.cs" %}
{% include code-snippet/multiselect/data-binding/remotedata/remotedata.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Bind to URL adaptor

The MultiSelect supports retrieval of data through the `UrlAdaptor`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multiselect/data-binding/urladaptor/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Urldata.cs" %}
{% include code-snippet/multiselect/data-binding/urladaptor/urldata.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multiselect/data-binding/urladaptor/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Urldata.cs" %}
{% include code-snippet/multiselect/data-binding/urladaptor/urldata.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Web API adaptor

Use the `WebApiAdaptor` to bind the MultiSelect to a Web API created using OData.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multiselect/data-binding/webapi/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Webapi.cs" %}
{% include code-snippet/multiselect/data-binding/webapi/webapi.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multiselect/data-binding/webapi/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Webapi.cs" %}
{% include code-snippet/multiselect/data-binding/webapi/webapi.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Binding with OData services

`OData` is a standardized protocol for creating and consuming data. You can retrieve data from an OData service using the `DataManager`.

The following example shows remote data binding using an OData service.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multiselect/data-binding/odata/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Odata.cs" %}
{% include code-snippet/multiselect/data-binding/odata/odata.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multiselect/data-binding/odata/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Odata.cs" %}
{% include code-snippet/multiselect/data-binding/odata/odata.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Offline mode

To avoid a postback for every action, set the MultiSelect to load all data on initialization and process actions on the client. To enable this behavior, use the `Offline` property of `DataManager`.

The following example shows remote data binding with offline mode enabled.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multiselect/data-binding/offline/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Offline.cs" %}
{% include code-snippet/multiselect/data-binding/offline/offline.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multiselect/data-binding/offline/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Offline.cs" %}
{% include code-snippet/multiselect/data-binding/offline/offline.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See also

* [How to load data using a template](https://ej2.syncfusion.com/aspnetmvc/documentation/multi-select/templates#item-template)
* [How to group the data using a header](https://ej2.syncfusion.com/aspnetmvc/documentation/multi-select/grouping)
* [How to filter the bound data](https://ej2.syncfusion.com/aspnetmvc/documentation/multi-select/templates)
