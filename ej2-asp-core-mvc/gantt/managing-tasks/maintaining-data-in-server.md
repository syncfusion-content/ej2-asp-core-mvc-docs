---
layout: post
title: Maintaining data in server in Syncfusion ##Platform_Name## Gantt Component
description: Learn here all about Maintaining data in server in Syncfusion ##Platform_Name## Gantt component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Managing Tasks
publishingplatform: ##Platform_Name##
documentation: ug
---


# Maintaining data in server

All the modified data in Gantt control can be maintained in the database using RESTful web services.

All the CRUD operations in the gantt are done through DataManager. The DataManager has an option to bind all the CRUD related data in server-side.

In the below section, we have explained how to get the edited data details on the server-side using the `UrlAdaptor`.

## URL Adaptor

In Gantt, we can fetch data from SQL database using `ADO.NET` Entity Data Model and update the changes on CRUD action to the server by using `DataManager` support. To communicate with the remote data we are using `UrlAdaptor` of DataManager property to call the server method and get back resultant data in JSON format. We can know more about `UrlAdaptor` from [`here`](https://ej2.syncfusion.com/javascript/documentation/data/adaptors/?no-cache=1).

N> Refer the [link](https://docs.microsoft.com/en-us/aspnet/mvc/overview/older-versions-1/models-data/creating-model-classes-with-the-entity-framework-cs) to create the `ADO.NET` Entity Data Model in Visual studio,

We can define data source for Gantt as instance of DataManager using `url` property of DataManager. Check the below code snippet to assign data source to Gantt.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/urlAdaptor/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="UrlAdaptor.cs" %}
{% include code-snippet/gantt/editing/urlAdaptor/UrlAdaptor.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/urlAdaptor/razor %}
{% endhighlight %}
{% highlight c# tabtitle="UrlAdaptor.cs" %}
{% include code-snippet/gantt/editing/urlAdaptor/UrlAdaptor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



We can also do CRUD operations over Gantt data and save the changes to database. By using `BatchUrl` property of DataManager, we can communicate with the controller method to update the data source on CRUD operation. In gantt CRUD actions on task are dependent with other tasks. For example on editing the child record on chart side, corresponding parent item also will get affect and predecessor dependency task as well get affected. So in Gantt all the CRUD operations are considered to be batch editing where you will get all the affected records as collection. Check the below code snippet to assign controller method to this property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/batchUrl/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="UrlAdaptor.cs" %}
{% include code-snippet/gantt/editing/batchUrl/UrlAdaptor.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/batchUrl/razor %}
{% endhighlight %}
{% highlight c# tabtitle="UrlAdaptor.cs" %}
{% include code-snippet/gantt/editing/batchUrl/UrlAdaptor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



This server method will be triggered for all the CRUD operations like adding, editing and deleting actions. We can handle those each operations separately inside this method with corresponding data received in this method argument. Also, when using the `UrlAdaptor`, you need to return the data as JSON from the controller action and the JSON object must contain a property as result with dataSource as its value and one more property count with the dataSource total records count as its value.

## Insert action

Using the `added` argument of the `BatchUrl` method we can insert the newly added row to database and return the same to client side. Find the below code example for details.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/adding/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="UrlAdaptor.cs" %}
{% include code-snippet/gantt/editing/adding/UrlAdaptor.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/adding/razor %}
{% endhighlight %}
{% highlight c# tabtitle="UrlAdaptor.cs" %}
{% include code-snippet/gantt/editing/adding/UrlAdaptor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Editing action

Using the `changed` argument of the `BatchUrl` method we can update the modified records to database and return the same to client side. Find the below code example for details.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/editingData/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="UrlAdaptor.cs" %}
{% include code-snippet/gantt/editing/editingData/UrlAdaptor.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/editingData/razor %}
{% endhighlight %}
{% highlight c# tabtitle="UrlAdaptor.cs" %}
{% include code-snippet/gantt/editing/editingData/UrlAdaptor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Delete action

Using the `deleted` argument of the `BatchUrl` method we can remove the deleted records from database and return the same to client side. on deleting the record we need to remove its corresponding child records as well if it exist from the data base. Find the below code example for details.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/deleting/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="UrlAdaptor.cs" %}
{% include code-snippet/gantt/editing/deleting/UrlAdaptor.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/deleting/razor %}
{% endhighlight %}
{% highlight c# tabtitle="UrlAdaptor.cs" %}
{% include code-snippet/gantt/editing/deleting/UrlAdaptor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



N> You can find the full sample at our [GitHub repository](https://github.com/SyncfusionExamples/EJ2-Gantt-MVC-CRUD-URL-ADAPTOR).