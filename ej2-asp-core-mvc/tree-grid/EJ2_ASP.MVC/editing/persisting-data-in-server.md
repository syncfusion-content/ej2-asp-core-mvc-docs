---
layout: post
title: Persisting Data in Server in ##Platform_Name## Tree Grid Component | Syncfusion
description: Learn here all about Persisting Data in Server in Syncfusion ##Platform_Name## Tree Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Persisting Data in Server
publishingplatform: ##Platform_Name##
documentation: ug
---


# Persisting Data in Server

Edited data can be persisted in the database using the RESTful web services.

All the CRUD operations in the treegrid are done through **DataManager**. The **DataManager** has an option to bind all the CRUD related data in server-side.

> For your information, the ODataAdaptor persists data in the server as per OData protocol.

In the following section, we have explained how to perform CRUD operation in server-side using the **UrlAdaptor** and **RemoteSave Adaptor**.

## URL adaptor

You can use the **UrlAdaptor** of **DataManager** when binding data source from remote data.
In the initial load of grid, data are fetched from remote data and bound to the grid using **url** property of **DataManager**.
You can map The CRUD operation in grid can be mapped to server-side Controller actions using the properties **InsertUrl**, **RemoveUrl**, **UpdateUrl** and **BatchUrl**.

The following code example describes the above behavior.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/editing/urladaptor/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="UrladaptorMVC.cs" %}
{% include code-snippet/tree-grid/editing/urladaptor/urladaptorMVC.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/editing/urladaptor/razor %}
{% endhighlight %}
{% highlight c# tabtitle="UrladaptorMVC.cs" %}
{% include code-snippet/tree-grid/editing/urladaptor/urladaptorMVC.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Also, when using the **UrlAdaptor**, you need to return the data as JSON from the controller action and the JSON object must contain a property as **result** with dataSource as its value and one more property **count** with the dataSource total records count as its value.

## Insert record

Using the **InsertUrl** property, you can specify the controller action mapping URL to perform insert operation on the server-side.

The following code example describes the above behavior.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/editing/urladaptor/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="InsertMVC.cs" %}
{% include code-snippet/tree-grid/editing/urladaptor/insertMVC.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/editing/urladaptor/razor %}
{% endhighlight %}
{% highlight c# tabtitle="InsertMVC.cs" %}
{% include code-snippet/tree-grid/editing/urladaptor/insertMVC.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



The newly added record details are bound to the **value** parameter and **relationalKey** contains primaryKey value of an selected record helps to find out the position of newly added record. Please refer to the following screenshot.

![Insert](images/insert.PNG)

## Update record

Using the **UpdateUrl** property, the controller action mapping URL can be specified to perform save/update operation on the server-side.

The following code example describes the previous behavior.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/editing/urladaptor/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="UpdateMVC.cs" %}
{% include code-snippet/tree-grid/editing/urladaptor/updateMVC.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/editing/urladaptor/razor %}
{% endhighlight %}
{% highlight c# tabtitle="UpdateMVC.cs" %}
{% include code-snippet/tree-grid/editing/urladaptor/updateMVC.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



The updated record details are bound to the **value** parameter. Please refer to the following screenshot.

![Update](images/update.PNG)

## Delete record

Using the **RemoveUrl** and **BatchUrl** property, the controller action mapping URL can be specified to perform delete operation on the server-side.

The following code example describes the previous behavior.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/editing/urladaptor/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="DeleteMVC.cs" %}
{% include code-snippet/tree-grid/editing/urladaptor/deleteMVC.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/editing/urladaptor/razor %}
{% endhighlight %}
{% highlight c# tabtitle="DeleteMVC.cs" %}
{% include code-snippet/tree-grid/editing/urladaptor/deleteMVC.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



The deleted record primary key value is bound to the **key** parameter. Please refer to the following screenshot.

![Delete](images/delete.PNG)

While delete parent record, the parent and child records is bound to the **deleted** parameter. Please refer to the following screenshot.

![Remove](images/remove.PNG)

## Remote save adaptor

You may need to perform all Tree Grid Actions in client-side except the CRUD operations, that should be interacted with server-side to persist data. It can be achieved in TreeGrid by using **RemoteSaveAdaptor**.

Datasource must be set to **json** property and set **RemoteSaveAdaptor** to the **adaptor** property. CRUD operations can be mapped to server-side using **updateUrl**, **insertUrl**, **removeUrl** and **batchUrl** properties.

You can use the following code example to use **RemoteSaveAdaptor** in TreeGrid.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/editing/remotesaveadaptor/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CrudMVC.cs" %}
{% include code-snippet/tree-grid/editing/remotesaveadaptor/crudMVC.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/editing/remotesaveadaptor/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CrudMVC.cs" %}
{% include code-snippet/tree-grid/editing/remotesaveadaptor/crudMVC.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You can refer to our [`ASP.NET MVC Tree Grid`](https://www.syncfusion.com/aspnet-mvc-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our [`ASP.NET MVC Tree Grid example`](https://ej2.syncfusion.com/aspnetmvc/TreeGrid/Overview#/material) to knows how to present and manipulate data.