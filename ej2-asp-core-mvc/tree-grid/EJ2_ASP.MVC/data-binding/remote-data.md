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

To bind remote data to TreeGrid component, assign service data as an instance of **DataManager** to the [`DataSource`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridBuilder~DataSource.html) property. To interact with remote data source,  provide the endpoint **url** and define the [`HasChildMapping`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridBuilder~HasChildMapping.html) property of treegrid.

The [`HasChildMapping`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridBuilder~HasChildMapping.html) property maps the field name in data source, that denotes whether current record holds any child records. This is useful internally to show expand icon while binding child data on demand.

The TreeGrid provides **Load on Demand** support for rendering remote data. The Load on demand is considered in TreeGrid for the following actions.

* Expanding root nodes.
* Navigating pages, with paging enabled in TreeGrid.

When load on demand is enabled, all the root nodes are rendered in collapsed state at initial load.

When load on demand support is enabled in TreeGrid with paging, the current or active page’s root node alone will be rendered in collapsed state. On expanding the root node, the child nodes will be loaded from the remote server.

When a root node is expanded, its child nodes are rendered and are cached locally, such that on consecutive expand/collapse actions on root node, the child nodes are loaded from the cache instead from the remote server.

Similarly, if the user navigates to a new page, the root nodes of that specific page, will be rendered with request to the remote server.

N>Remote Data Binding supports only Self-Referential Data and by default the `pageSizeMode` for Remote Data is `Root` mode. i.e only root node’s count will be shown in pager while using Remote Data

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="Remote-data.cs" %}
{% include code-snippet/tree-grid/data-binding-mvc/remote-data/remote-data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/data-binding-mvc/remote-data/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Remote-data.cs" %}
{% include code-snippet/tree-grid/data-binding-mvc/remote-data/remote-data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



N> By default, **DataManager** uses **ODataAdaptor** for remote data-binding.
<br/> Based on the RESTful web services, set the corresponding adaptor to DataManager. Refer [`here`](https://ej2.syncfusion.com/documentation/data/adaptors/?no-cache=1) for more details.
<br/> Filtering and searching server-side data operations are not supported in load on demand

## LoadChildOnDemand

While binding remote data to Tree Grid component, by default Tree Grid renders parent rows in collapsed state. Tree Grid provides option to load the child records also during the initial rendering itself for remote data binding by setting [`LoadChildOnDemand`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_LoadChildOnDemand) as true.

When [`LoadChildOnDemand`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_LoadChildOnDemand) is enabled parent records are rendered in expanded state.

The following code example describes the behavior of the LoadChildOnDemand feature of Tree Grid.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="LoadChildOnDemand.cs" %}
{% include code-snippet/tree-grid/data-binding-mvc/load-child-onDemand/loadChildOnDemand.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/data-binding-mvc/load-child-onDemand/razor %}
{% endhighlight %}
{% highlight c# tabtitle="LoadChildOnDemand.cs" %}
{% include code-snippet/tree-grid/data-binding-mvc/load-child-onDemand/loadChildOnDemand.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



N> Also while using **LoadChildOnDemand** we need to handle the child records on server end and it is applicable for CRUD operations also.

## Offline mode

On remote data binding, all treegrid actions such as paging, loading child on-demand, will be processed on server-side. To avoid postback, set the treegrid to load all data on initialization and make the actions process in client-side. To enable this behavior, use the **offline** property of **DataManager**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="Offline.cs" %}
{% include code-snippet/tree-grid/data-binding-mvc/offline/offline.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/data-binding-mvc/offline/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Offline.cs" %}
{% include code-snippet/tree-grid/data-binding-mvc/offline/offline.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Custom adaptor

You can create your own adaptor by extending the built-in adaptors. The following demonstrates custom adaptor approach and how to add a serial number for the records by overriding the built-in response processing using the **processResponse** method of the **ODataAdaptor**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="Customadaptor.cs" %}
{% include code-snippet/tree-grid/data-binding-mvc/customadaptor/customadaptor.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/data-binding-mvc/customadaptor/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Customadaptor.cs" %}
{% include code-snippet/tree-grid/data-binding-mvc/customadaptor/customadaptor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Sending additional parameters to the server

To add a custom parameter to the data request, use the **addParams** method of [`Query`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~Query.html) property. Assign the Query object with additional parameters to the treegrid [`Query`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~Query.html) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="Param.cs" %}
{% include code-snippet/tree-grid/data-binding-mvc/param/param.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/data-binding-mvc/param/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Param.cs" %}
{% include code-snippet/tree-grid/data-binding-mvc/param/param.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Handling HTTP error

During server interaction from the treegrid, some server-side exceptions may occur, and you can acquire those error messages or exception details
in client-side using the [`ActionFailure`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~ActionFailure.html) event.

The argument passed to the [`ActionFailure`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~ActionFailure.html) event contains the error details returned from the server.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="Http-error.cs" %}
{% include code-snippet/tree-grid/data-binding-mvc/http-error/http-error.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/data-binding-mvc/http-error/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Http-error.cs" %}
{% include code-snippet/tree-grid/data-binding-mvc/http-error/http-error.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}




N> The [`ActionFailure`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~ActionFailure.html) event will be triggered not only for the server errors, but also when there is an exception while processing the treegrid actions.
<br/> You can refer to our [`ASP.NET MVC Tree Grid`](https://www.syncfusion.com/aspnet-mvc-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our [`ASP.NET MVC Tree Grid example`](https://ej2.syncfusion.com/aspnetmvc/TreeGrid/Overview#/material) to knows how to present and manipulate data.

> The [`ActionFailure`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~ActionFailure.html) event will be triggered not only for the server errors, but also when there is an exception while processing the treegrid actions.
> You can refer to our [`ASP.NET MVC Tree Grid`](https://www.syncfusion.com/aspnet-mvc-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our [`ASP.NET MVC Tree Grid example`](https://ej2.syncfusion.com/aspnetmvc/TreeGrid/Overview#/material) to knows how to present and manipulate data.



## Load on demand with virtualization

While binding remote data to Tree Grid component, by default Tree Grid renders parent rows in collapsed state. When expanding the root node, the child nodes will be loaded from the remote server.

When using virtualization with remote data binding, it helps you to improve the tree grid performance while loading a large set of data by setting [`EnableVirtualization`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_EnableVirtualization) as true. The Tree Grid UI virtualization allows it to render only rows and columns visible within the view-port without buffering the entire datasource.

The [`HasChildMapping`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_HasChildMapping) property maps the field name in data source, that denotes whether current record holds any child records. This is useful internally to show expand icon while binding child data on demand.



{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="LazyLoading.cs" %}
{% include code-snippet/tree-grid/data-binding-mvc/lazy-loading/lazyLoading.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/data-binding-mvc/lazy-loading/razor %}
{% endhighlight %}
{% highlight c# tabtitle="LazyLoading.cs" %}
{% include code-snippet/tree-grid/data-binding-mvc/lazy-loading/lazyLoading.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Load parent rows in expanded state with virtualization

Tree Grid provides an option to load the child records in the initial rendering itself for remote data binding by setting the [`LoadChildOnDemand`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_LoadChildOnDemand) as true. When the `LoadChildOnDemand` is enabled, parent records are rendered in expanded state.

When using virtualization with `LoadChildOnDemand` , it helps you to improve the tree grid performance while loading the child records during the initial rendering for remote data binding by setting [`EnableVirtualization`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_EnableVirtualization) as true and `LoadChildOnDemand` as true.


{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="LoadChildOnDemand.cs" %}
{% include code-snippet/tree-grid/data-binding-mvc/load-child-ondemand-virtualization/loadChildOnDemand.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/data-binding-mvc/load-child-ondemand-virtualization/razor %}
{% endhighlight %}
{% highlight c# tabtitle="LoadChildOnDemand.cs" %}
{% include code-snippet/tree-grid/data-binding-mvc/load-child-ondemand-virtualization/loadChildOnDemand.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



