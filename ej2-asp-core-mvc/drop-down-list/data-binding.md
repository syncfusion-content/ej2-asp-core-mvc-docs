---
layout: post
title: Data Binding in ##Platform_Name## Drop Down List Component
description: Learn here all about Data Binding in Syncfusion ##Platform_Name## Drop Down List component and more.
platform: ej2-asp-core-mvc
control: Data Binding
publishingplatform: ##Platform_Name##
documentation: ug
---


# Data Binding

The DropDownList loads the data either from local data sources or
remote data services using the [dataSource](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.DropDownList~DataSource.html) property. It supports
the data type of `array` or [DataManager](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DataManager_members.html).

The DropDownList also supports different kinds of data services such as OData, OData V4, and Web API, and data formats such as XML, JSON, and JSONP with the help of [DataManager](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DataManager_members.html) adaptors.

| Fields | Type | Description |
|------|------|-------------|
| text |  `string` | Specifies the display text of each list item. |
| value |  `number or string` | Specifies the hidden data value mapped to each list item that should contain a unique value. |
| groupBy |  `string` | Specifies the category under which the list item has to be grouped. |
| iconCss |  `string` | Specifies the icon class of each list item. |

> When binding complex data to the DropDownList, fields should be mapped correctly. Otherwise, the selected item remains undefined.

## Binding local data

Local data can be represented in two ways as described below.

### 1. Array of simple data

The DropDownList has support to load array of primitive data such as strings and numbers. Here, both value and text field act the same.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/data-binding/arrayofstrings/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Arrayofstrings.cs" %}
{% include code-snippet/dropdownlist/data-binding/arrayofstrings/arrayofstrings.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/data-binding/arrayofstrings/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Arrayofstrings.cs" %}
{% include code-snippet/dropdownlist/data-binding/arrayofstrings/arrayofstrings.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### 2. Array of JSON data

The DropDownList can generate its list items through an array of complex data. For this,
the appropriate columns should be mapped to the [fields](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.DropDownList~fields.html) property.

In the following example, `Vegetable` column from complex data have been mapped to the `value` field.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/data-binding/arrayofobjects/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Vegetables.cs" %}
{% include code-snippet/dropdownlist/data-binding/arrayofobjects/Vegetables.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/data-binding/arrayofobjects/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Vegetables.cs" %}
{% include code-snippet/dropdownlist/data-binding/arrayofobjects/Vegetables.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### 3. Array of Complex data

The DropDownList can generate its list items through an array of complex data. For this,
the appropriate columns should be mapped to the [fields](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.DropDownList~fields.html) property.

In the following example, `Code.Id` column and `Country.CountrtyId` column from complex data have been mapped to the `value` field and `text` field, respectively.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/data-binding/complexdata/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Complex.cs" %}
{% include code-snippet/dropdownlist/data-binding/complexdata/Complex.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/data-binding/complexdata/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Complex.cs" %}
{% include code-snippet/dropdownlist/data-binding/complexdata/Complex.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Binding remote data

The DropDownList supports retrieval of data from remote data services with the help of [DataManager](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DataManager_members.html) control. The [`Query`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.DropDownList~Query.html) property is used to fetch
data from the database and bind it to the DropDownList.

The following sample displays the first 6 contacts from **Customers** table of the `Northwind` Data Service.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/data-binding/remotedata/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Remotedata.cs" %}
{% include code-snippet/dropdownlist/data-binding/remotedata/remotedata.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/data-binding/remotedata/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Remotedata.cs" %}
{% include code-snippet/dropdownlist/data-binding/remotedata/remotedata.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Bind to URL Adaptor

The DropDownList supports retrieval of data from URL adaptor.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/data-binding/urladaptor/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Urldata.cs" %}
{% include code-snippet/dropdownlist/data-binding/urladaptor/urldata.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/data-binding/urladaptor/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Urldata.cs" %}
{% include code-snippet/dropdownlist/data-binding/urladaptor/urldata.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Web API Adaptor

Use the `WebApiAdaptor` to bind DropDownList with Web API created using OData.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/data-binding/webapi/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Webapi.cs" %}
{% include code-snippet/dropdownlist/data-binding/webapi/webapi.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/data-binding/webapi/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Webapi.cs" %}
{% include code-snippet/dropdownlist/data-binding/webapi/webapi.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Binding with OData services

`OData` is a standardized protocol for creating and consuming data. You can retrieve data from OData service using the DataManager.

The following example for remote data binding using OData service.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/data-binding/odata/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Odata.cs" %}
{% include code-snippet/dropdownlist/data-binding/odata/odata.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/data-binding/odata/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Odata.cs" %}
{% include code-snippet/dropdownlist/data-binding/odata/odata.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Offline mode

To avoid post back for every action, set the DropDownList to load all data on initialization and make the actions process in client-side. To enable this behavior, use the `Offline` property of `DataManager`.

The following example for remote data binding and enabled offline mode.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/data-binding/offline/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Offline.cs" %}
{% include code-snippet/dropdownlist/data-binding/offline/offline.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/data-binding/offline/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Offline.cs" %}
{% include code-snippet/dropdownlist/data-binding/offline/offline.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [How to load data using template](./templates/#item-template)
* [How to group the data using header](./grouping)
* [How to filter the bound data](./filtering)
* [How to get the count of the data when using remote data](./how-to/remote-data-bind)
* [How to acheive cascading](./how-to/cascading/)
* [How to add item in between the options](./how-to/add-item/)
* [How to remove an item](./how-to/remove-item/)
* [How to preselect the items in dropdownlist](./how-to/multiple-cascading/)