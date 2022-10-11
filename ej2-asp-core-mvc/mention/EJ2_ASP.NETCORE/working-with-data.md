---
layout: post
title: Data binding in ##Platform_Name## Mention Component
description: Learn here all about how to bind with local datasource and how to fetch data from remote data using the service in Syncfusion ##Platform_Name## Mention component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Data binding
publishingplatform: ##Platform_Name##
documentation: ug
---

# Working with Data

The Mention loads the data either from local datasource or remote data services using the [dataSource](../api/mention/#datasource) property. It supports the data type of `array` or `DataManager`.

The Mention also supports different kinds of data services such as OData V4 and Web API, and data formats such as XML, JSON, and JSONP with the help of `DataManager` adaptors.

| Fields | Type | Description |
|------|------|-------------|
| text |  `string` | Specifies the display text of each list item. |
| value |  `number or string` | Specifies the hidden data value mapped to each list item that should contain a unique value. |
| groupBy |  `string` | Specifies the category under which the list item has to be grouped. |
| iconCss |  `string` | Specifies the icon class of each list item. |

> When binding complex data to the Mention, fields should be mapped correctly. Otherwise, the selected item remains undefined.

## Binding local data

Local data can be represented in three ways as described below.

### 1. Array of simple data

The Mention has support to load array of primitive data such as strings and numbers. Here, both value and text field act the same.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/mention/working-with-data/arrayof-simple-data/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/mention/working-with-data/arrayof-simple-data/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/mention/working-with-data/arrayof-simple-data/simpleData.cs %}
{% endtabs %}
{% endif %}


### 2. Array of JSON data

The Mention can generate its list items through an array of complex data. For this, the appropriate columns should be mapped to the [fields](../api/mention/#fields) property.

In the following example, `Id` column and `Game` column from complex data have been mapped to the `value` field and `text` field, respectively.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/mention/working-with-data/arrayof-json-data/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/mention/working-with-data/arrayof-json-data/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/mention/working-with-data/arrayof-json-data/jsonData.cs %}
{% endtabs %}
{% endif %}

### 3. Array of Complex data

The Mention can generate its list items through an array of complex data. For this, the appropriate columns should be mapped to the [fields](../api/mention/#fields) property.

In the following example, `Code.Id` column and `Country.Name` column from complex data have been mapped to the `value` field and `text` field, respectively.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/mention/working-with-data/complexdata/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Complex.cs" %}
{% include code-snippet/mention/working-with-data/complexdata/Complex.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/mention/working-with-data/complexdata/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Complex.cs" %}
{% include code-snippet/mention/working-with-data/complexdata/Complex.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


## Binding remote data

The Mention supports retrieval of data from remote data services with the help of `DataManager` control. The [Query](../api/mention/#query) property is used to fetch the data from the database and bind it to the Mention control.

### OData v4 adaptor - Binding OData v4 service

The ODataV4 is an improved version of OData protocols, and the `DataManager` can also retrieve and consume OData v4 services. For more details on OData v4 services, refer to the [odata documentation](http://docs.oasis-open.org/odata/odata/v4.0/errata03/os/complete/part1-protocol/odata-v4.0-errata03-os-part1-protocol-complete.html#_Toc453752197). To bind OData v4 service, use the `ODataV4Adaptor`.

The following sample displays the first 6 contacts from `Customers` table of the `Northwind` Data Service.


{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/mention/working-with-data/odata-v4-adaptor/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/mention/working-with-data/odata-v4-adaptor/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Complexdata.cs" %}
{% include code-snippet/mention/working-with-data/odata-v4-adaptor/v4-adaptor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


### Web API adaptor

You can use `WebApiAdaptor` to bind mention with Web API created using OData endpoint.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/mention/working-with-data/web-api/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/mention/working-with-data/web-api/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Complexdata.cs" %}
{% include code-snippet/mention/working-with-data/web-api/web-api.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


## See Also

* [Customization](./customization)
* [How to perform filtering](./filtering-data)