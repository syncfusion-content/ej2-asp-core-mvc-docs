---
layout: post
title: Data binding in ASP.NET Core Mention control | Syncfusion
description: Learn here all about Data Binding in Syncfusion ASP.NET Core Mention control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Data binding
publishingplatform: aspnet-core
documentation: ug
---

# Working with Data in Mention

The Mention loads the data either from local data source or remote data services using the [dataSource](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.Mention.html#Syncfusion_EJ2_DropDowns_Mention_DataSource) property. It supports the data type of either `array` or `DataManager`.

The Mention also supports different kinds of data services such as OData V4 and Web API, and data formats such as XML, JSON, and JSONP with the help of `DataManager` adaptors.

| Fields | Type | Description |
|------|------|-------------|
| text |  `string` | Specifies the display text of each list item. |
| value |  `number or string` | Specifies the hidden data value mapped to each list item that should contain a unique value. |
| groupBy |  `string` | Specifies the category under which the list item has to be grouped. |
| iconCss |  `string` | Specifies the icon class of each list item. |

N> When binding complex data to the Mention, fields should be mapped correctly. Otherwise, the selected item remains undefined.

## Binding local data

Local data can be represented in three ways as described in the following.

### Array of simple data

The Mention has provided support to load an array of primitive data such as strings and numbers. Here, both the value and text fields act the same.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/mention/working-with-data/arrayof-simple-data/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Mention array of simple data](./images/mention-simple-data.png)

### Array of JSON data

The Mention can generate its list of items through an array of JSON data. Therefore the appropriate columns should be mapped to the [fields](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.Mention.html#Syncfusion_EJ2_DropDowns_Mention_Fields) property.

In the following example, `ID` column and `Game` column from complex data have been mapped to the `value` field and `text` field, respectively.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/mention/working-with-data/arrayof-json-data/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Mention array of json data](./images/mention-json-data.png)

### Array of complex data

The Mention can generate its list items through an array of complex data. For this, the appropriate columns should be mapped to the [fields](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.Mention.html#Syncfusion_EJ2_DropDowns_Mention_Fields) property.

In the following example, `Code.ID` and `Country.Name` columns from the complex data have been mapped to the `value` and `text` fields respectively.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/mention/working-with-data/complex-data/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/mention/working-with-data/complex-data/Complex.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Mention array of complex data](./images/mention-complex-data.png)

## Binding remote data

The Mention supports retrieval of data from remote data services with the help of `DataManager` control. The [query](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.Mention.html#Syncfusion_EJ2_DropDowns_Mention_Query) property is used to fetch the data from the database and bind it to the Mention control.

### OData v4 adaptor - Binding OData v4 service

The ODataV4 is an improved version of OData protocols, and the `DataManager` can also retrieve and consume OData v4 services. For more details on OData v4 services, refer to the [odata documentation](http://docs.oasis-open.org/odata/odata/v4.0/errata03/os/complete/part1-protocol/odata-v4.0-errata03-os-part1-protocol-complete.html#_Toc453752197). To bind OData v4 service, use the `ODataV4Adaptor`.

The following sample displays the first 6 contacts from `Customers` table of the `Northwind` Data Service.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/mention/working-with-data/odata-v4-adaptor/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Mention odata v4 adaptor](./images/mention-odata-adaptor.png)

### Web API adaptor

You can use `WebApiAdaptor` to bind mention with Web API created using OData endpoint.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/mention/working-with-data/web-api/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Mention web api adaptor](./images/mention-web-adaptor.png)

## See also

* [Customization](./customization)
* [How to perform filtering](./filtering-data)
