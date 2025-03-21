---
layout: post
title: Data Binding in ##Platform_Name## TreeView Control | Syncfusion
description: Learn here all about Data Binding in Syncfusion ##Platform_Name## TreeView control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: TreeView
publishingplatform: ##Platform_Name##
documentation: ug
---


# Data Binding in TreeView Control

The TreeView control provides the option to load data either from local data sources or from remote data services. This can be done through the `dataSource` property that is a member of the `fields` property. The `dataSource` property supports array of JavaScript objects and [`DataManager`](https://ej2.syncfusion.com/documentation/api/data/dataManager/). It also supports different kinds of data services such as OData, OData V4, Web API, URL, and JSON with the help of `DataManager` adaptors.

TreeView has `load on demand` (Lazy load) enabled by default. It reduces the bandwidth size when consuming huge data. It initially loads first-level nodes, and when a parent node is expanded, it loads the child nodes based on the `parentID/child` member.

By default, the `loadOnDemand` is set to true. By disabling this property, all the tree nodes are rendered at the beginning.

You can use the `dataBound` event to perform actions. This event will be triggered once the data source is populated in the TreeView.

## Local data

To bind local data to the TreeView, you can assign a JavaScript object array to the `dataSource` property. The TreeView control requires three fields (**ID**, **text**, and **parentID**) to render a local data source. When mapper fields are not specified, it takes the default values as the mapping fields. Local data source can also be provided as an instance of the `DataManager`. It supports two kinds of local data binding methods.

* Hierarchical data

* Self-referential data

### Hierarchical data

TreeView can be populated with hierarchical data source that contains nested array of JSON objects. You can directly assign hierarchical data to the `dataSource` property, and map all the field members with corresponding keys from the hierarchical data to `fields` property. 

In the following example, **code**, **name**, and **countries** columns from hierarchical data have been mapped to **id**, **text**, and **child** fields, respectively.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/treeview/binding-data/hierarchical/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Hierarchical.cs" %}
{% include code-snippet/treeview/binding-data/hierarchical/hierarchical.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/treeview/binding-data/hierarchical/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Hierarchical.cs" %}
{% include code-snippet/treeview/binding-data/hierarchical/hierarchical.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Self-referential data

TreeView can be populated from self-referential data structure that contains array of JSON objects with `parentID` mapping. 

You can directly assign self-referential data to the `dataSource` property, and map all the field members with corresponding keys from self-referential data to `fields` property. 

To render the root level nodes, specify the parentID as null or no need to specify the parentID in `dataSource`.

In the following example, **id**, **pid**, **hasChild**, and **name** columns from self-referential data have been mapped to **id**, **parentID**, **hasChildren**, and **text** fields, respectively.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/treeview/binding-data/self-referential/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/treeview/binding-data/self-referential/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Selfreferential.cs" %}
{% include code-snippet/treeview/binding-data/self-referential/selfreferential.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Remote data

TreeView can also be populated from a remote data service with the help of the `DataManager` control and `Query` property. 

It supports different kinds of data services such as OData, OData V4, Web API, URL, and JSON with the help of `DataManager` adaptors. 

You can assign service data as an instance of `DataManager` to the `dataSource` property. To interact with remote data source, you have to provide the endpoint `url`.

The `DataManager` that acts as an interface between the service endpoint and the TreeView requires the following information to interact with service endpoint properly.

* `DataManager->url`: Defines the service endpoint to fetch data.

* `DataManager->adaptor`: Defines the adaptor option. By default, ODataAdaptor is used for remote binding.

Adaptor is responsible for processing response and request from/to the service endpoint. The `@syncfusion/ej2-data` package provides some predefined adaptors  designed to interact with service endpoints. They are,

* `UrlAdaptor`: Used to interact with remote services. This is the base adaptor for all remote based adaptors.

* `ODataAdaptor`: Used to interact with OData endpoints.

* `ODataV4Adaptor`: Used to interact with OData V4 endpoints.

* `WebApiAdaptor`: Used to interact with Web API created under OData standards.

* `WebMethodAdaptor`: Used to interact with web methods.

In the following example, `ODataV4Adaptor` is  used to fetch data from remote services. The **EmployeeID**, **FirstName**, and **EmployeeID** columns from Employees table have been mapped to **id**, **text**, and **hasChildren** fields respectively for first level nodes. 

The **OrderID**, **EmployeeID**, and **ShipName** columns from orders table have been mapped to **id**, **parentID**, and **text** fields respectively for second level nodes.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/treeview/binding-data/remote-data/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Remotedata.cs" %}
{% include code-snippet/treeview/binding-data/remote-data/remotedata.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/treeview/binding-data/remote-data/razor %}
{% endhighlight %}
{% highlight c# tabtitle="remotedata_mvc.cs" %}
{% include code-snippet/treeview/binding-data/remote-data/remotedata-mvc.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


