---
layout: post
title: Remote Data in ##Platform_Name## Tree Grid Component | Syncfusion
description: Learn here all about Remote Data in Syncfusion ##Platform_Name## Tree Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Remote Data
publishingplatform: ##Platform_Name##
documentation: ug
---

# Remote Data in ##Platform_Name## Tree Grid Component

To bind remote data to TreeGrid component, assign service data as an instance of **DataManager** to the [`dataSource`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~DataSource.html) property. To interact with remote data source,  provide the endpoint **url** and define the [`hasChildMapping`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~HasChildMapping.html) property of treegrid.

The [`hasChildMapping`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~HasChildMapping.html) property maps the field name in data source, that denotes whether current record holds any child records. This is useful internally to show expand icon while binding child data on demand.

The TreeGrid provides **Load on Demand** support for rendering remote data. The Load on demand is considered in TreeGrid for the following actions.

* Expanding root nodes.
* Navigating pages, with paging enabled in TreeGrid.

When load on demand is enabled, all the root nodes are rendered in collapsed state at initial load.

When load on demand support is enabled in TreeGrid with paging, the current or active page’s root node alone will be rendered in collapsed state. On expanding the root node, the child nodes will be loaded from the remote server.

When a root node is expanded, its child nodes are rendered and are cached locally, such that on consecutive expand/collapse actions on root node, the child nodes are loaded from the cache instead from the remote server.

Similarly, if the user navigates to a new page, the root nodes of that specific page, will be rendered with request to the remote server.

>Remote Data Binding supports only Self-Referential Data and by default the `pageSizeMode` for Remote Data is `Root` mode. i.e only root node’s count will be shown in pager while using Remote Data

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/data-binding-core/remote-data/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Remote.cs" %}
{% include code-snippet/tree-grid/data-binding-core/remote-data/remote.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Remote.cs" %}
{% include code-snippet/tree-grid/data-binding-core/remote-data/remote.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> By default, **DataManager** uses **ODataAdaptor** for remote data-binding.
> Based on the RESTful web services, set the corresponding adaptor to DataManager. Refer [`here`](https://ej2.syncfusion.com/documentation/data/adaptors/?no-cache=1) for more details.
> Filtering and searching server-side data operations are not supported in load on demand

## LoadChildOnDemand

While binding remote data to Tree Grid component, by default Tree Grid renders parent rows in collapsed state. Tree Grid provides option to load the child records also during the initial rendering itself for remote data binding by setting [`loadChildOnDemand`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_LoadChildOnDemand) as true.

When [`loadChildOnDemand`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_LoadChildOnDemand) is enabled parent records are rendered in expanded state.

The following code example describes the behavior of the LoadChildOnDemand feature of Tree Grid.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/data-binding-core/load-child-onDemand/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="LoadChildOnDemand.cs" %}
{% include code-snippet/tree-grid/data-binding-core/load-child-onDemand/loadChildOnDemand.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="LoadChildOnDemand.cs" %}
{% include code-snippet/tree-grid/data-binding-core/load-child-onDemand/loadChildOnDemand.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> Also while using **LoadChildOnDemand** we need to handle the child records on server end and it is applicable to CRUD operations also.

## Offline mode

On remote data binding, all treegrid actions such as paging, loading child on-demand, will be processed on server-side. To avoid postback, set the treegrid to load all data on initialization and make the actions process in client-side. To enable this behavior, use the **offline** property of **DataManager**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/data-binding-core/offline-data/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Offline.cs" %}
{% include code-snippet/tree-grid/data-binding-core/offline-data/offline.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Offline.cs" %}
{% include code-snippet/tree-grid/data-binding-core/offline-data/offline.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Custom adaptor

You can create your own adaptor by extending the built-in adaptors. The following demonstrates custom adaptor approach and how to add a serial number for the records by overriding the built-in response processing using the **processResponse** method of the **ODataAdaptor**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/data-binding-core/custom-adaptor/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom.cs" %}
{% include code-snippet/tree-grid/data-binding-core/custom-adaptor/custom.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Custom.cs" %}
{% include code-snippet/tree-grid/data-binding-core/custom-adaptor/custom.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Sending additional parameters to the server

To add a custom parameter to the data request, use the **addParams** method of **Query** class. Assign the Query object with additional parameters to the treegrid [`query`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~Query.html) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/data-binding-core/addparams/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Addparam.cs" %}
{% include code-snippet/tree-grid/data-binding-core/addparams/addparam.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Addparam.cs" %}
{% include code-snippet/tree-grid/data-binding-core/addparams/addparam.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Handling HTTP error

During server interaction from the treegrid, some server-side exceptions may occur, and you can acquire those error messages or exception details
in client-side using the [`actionFailure`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~ActionFailure.html) event.

The argument passed to the [`actionFailure`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~ActionFailure.html) event contains the error details returned from the server.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/data-binding-core/action-failure/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Failure.cs" %}
{% include code-snippet/tree-grid/data-binding-core/action-failure/failure.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Failure.cs" %}
{% include code-snippet/tree-grid/data-binding-core/action-failure/failure.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> The [`actionFailure`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~ActionFailure.html) event will be triggered not only for the server errors, but also when there is an exception while processing the treegrid actions.
> You can refer to our  [`ASP.NET Core Tree Grid`](https://www.syncfusion.com/aspnet-core-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our ASP.NET Core Tree Grid example [`ASP.NET Core Tree Grid example`](https://ej2.syncfusion.com/aspnetcore/TreeGrid/Overview#/material) to knows how to present and manipulate data.