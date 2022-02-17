---
layout: post
title: Data Binding in ##Platform_Name## In Place Editor Component
description: Learn here all about Data Binding in Syncfusion ##Platform_Name## In Place Editor component and more.
platform: ej2-asp-core-mvc
control: Data Binding
publishingplatform: ##Platform_Name##
documentation: ug
---


# Data Binding

The Syncfusion ASP.NET MVC controls load the data either from local data sources or remote data services using the `dataSource` property and it supports the data type of an array or `DataManager`. Also supports different kind of data services such as OData, OData V4, Web API, and data formats such as XML, JSON, JSONP with the help of `DataManager` adaptors.

## Local

To bind local data to the Syncfusion ASP.NET MVC controls, you can assign a JavaScript array of object or string to the `dataSource` property. The local data source can also be provided as an instance of the `DataManager`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/in-place-editor/data/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/in-place-editor/data/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/in-place-editor/data/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/in-place-editor/data/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



The output will be as follows.

![data](./images/data.PNG)

## Remote

To bind remote data to the Syncfusion ASP.NET MVC control, assign service data as an instance of `DataManager` to the `dataSource` property. To interact with remote data source, provide the endpoint URL.

### OData V4

The OData V4 is an improved version of OData protocols, and the `DataManager` can also retrieve and consume OData V4 services. To fetch data from the server by using `DataManager` with the adaptor property configure as `ODataV4Adaptor`.

In the following sample, In-place Editor renders a `DropDownList` control and its `dataSource` property configured for fetching a data from the server by using `ODataV4Adaptor` with `DataManager`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/in-place-editor/odata/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/in-place-editor/odata/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/in-place-editor/odata/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/in-place-editor/odata/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



The output will be as follows.

![odata](./images/odata.png)

### Web API

Data can fetch from the server by using `DataManager` with the adaptor property configure as WebApiAdaptor.

In the following sample, In-place Editor render a `DropDownList` control and its `dataSource` property configured for fetching a data from the server by using `WebApiAdaptor` with `DataManager`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/in-place-editor/webapi/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/in-place-editor/webapi/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/in-place-editor/webapi/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/in-place-editor/webapi/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



The output will be as follows.

![webapi](./images/webapi.png)