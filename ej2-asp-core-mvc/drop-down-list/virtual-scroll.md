---
layout: post
title: Virtualization in ##Platform_Name## DropDown List Component | Syncfusion
description: Learn here all about Virtualization in Syncfusion ##Platform_Name## DropDown List component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Virtualization
publishingplatform: ##Platform_Name##
documentation: ug
---


# Virtualization in DropDown List

Dropdown list virtualization is a technique used to efficiently render extensive lists of items while minimizing the impact on performance. This method is particularly advantageous when dealing with large datasets because it ensures that only a fixed number of DOM (Document Object Model) elements are created. When scrolling through the list, existing DOM elements are reused to display relevant data instead of generating new elements for each item. This recycling process is managed internally.
 
During virtual scrolling, the data retrieved from the data source depends on the popup height and the calculation of the list item height. Enabling the [enableVirtualization](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.dropdowns.dropdownlist.html#Syncfusion_EJ2_DropDowns_DropDownList_EnableVirtualization) option in a dropdown list activates this virtualization technique.
 
When fetching data from the data source, the [actionBegin](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.dropdowns.dropdownlist.html#Syncfusion_EJ2_DropDowns_DropDownList_ActionBegin) event is triggered before data retrieval begins. Then, the [actionComplete](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.dropdowns.dropdownlist.html#Syncfusion_EJ2_DropDowns_DropDownList_ActionComplete) event is triggered once the data is successfully fetched.

Furthermore, Incremental Search is supported with virtualization in the DropDownList component. When a key is typed, the focus is moved to the respective element, and the value is updated in the component in the open popup state. In the closed popup state, the respective value is updated in the component based on the typed key. The Incremental Search functionality is well-suited for scenarios involving remote data binding.

When the enableVirtualization property is enabled, the `skip` and `take` properties provided by the user within the Query class at the initial state or during the `actionBegin` or `actionComplete` events will not be considered, since it is internally managed and calculated based on certain dimensions with respect to the popup height.

## Binding local data

The DropDownList can generate its list items through an array of complex data. For this, the appropriate columns should be mapped to the [fields](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.DropDownList~fields.html) property. When using virtual scrolling, the list updates based on the scroll offset value, triggering a request to fetch more data from the server. As the data is being fetched, the `actionBegin` event occurs before the data retrieval starts. Once the data retrieval is successful, the `actionComplete` event is triggered, indicating that the data fetch process is complete.

In the following example, `id` column and `text` column from complex data have been mapped to the `value` field and `text` field, respectively.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/virtual-scroll/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="virtualscroll.cs" %}
{% include code-snippet/dropdownlist/virtual-scroll/virtualscroll.cs %}
{% endhighlight %}
{% endtabs %} 

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/virtual-scroll/razor %}
{% endhighlight %} 
{% highlight c# tabtitle="virtualscroll.cs" %}
{% include code-snippet/dropdownlist/virtual-scroll/virtualscroll.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Binding remote data

The DropDownList supports retrieval of data from remote data services with the help of `DataManager` component. When using remote data, it initially fetches all the data from the server, triggering the `actionBegin` and `actionComplete` events, and then stores the data locally. During virtual scrolling, additional data is retrieved from the locally stored data, triggering the `actionBegin` and `actionComplete` events at that time as well.

The following sample displays the OrderId from the `Orders` Data Service.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/virtual-scroll-remote/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="virtualscroll.cs" %}
{% include code-snippet/dropdownlist/virtual-scroll-remote/virtualscroll.cs %}
{% endhighlight %}
{% endtabs %} 

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/virtual-scroll-remote/razor %}
{% endhighlight %} 
{% highlight c# tabtitle="virtualscroll.cs" %}
{% include code-snippet/dropdownlist/virtual-scroll-remote/virtualscroll.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Grouping

The DropDownList component supports grouping with Virtualization. It allows you to organize elements into groups based on different categories. Each item in the list can be classified using the [groupBy](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.DropDownListFieldSettings~GroupBy.html) field in the data table. After grouping, virtualization works similarly to local data binding, providing a seamless user experience. When the data source is bound to remote data, an initial request is made to retrieve all data for the purpose of grouping. Subsequently, the grouped data works in the same way as local data binding on virtualization. 

The following sample shows the example for Grouping with Virtualization.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/virtual-scroll-group/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="virtualscroll.cs" %}
{% include code-snippet/dropdownlist/virtual-scroll-group/virtualscroll.cs %}
{% endhighlight %}
{% endtabs %} 

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/virtual-scroll-group/razor %}
{% endhighlight %} 
{% highlight c# tabtitle="virtualscroll.cs" %}
{% include code-snippet/dropdownlist/virtual-scroll-group/virtualscroll.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Filtering with Virtualization

The DropDownList component supports Filtering with Virtualization. The DropDownList includes a built-in feature that enables data filtering when the [allowFiltering](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.DropDownListBuilder~AllowFiltering.html) option is enabled. In the context of Virtual Scrolling, the filtering process operates in response to the typed characters. Specifically, the DropDownList sends a request to the server, utilizing the full data source, to achieve filtering. Before initiating the request, an action event is triggered. Upon successful retrieval of data from the server, an action complete event is triggered. The initial data is loaded when the popup is opened. Whether the filter list has a selection or not, the popup closes.

The following sample shows the example for Filtering with Virtualization.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/virtual-scroll-filter/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="virtualscroll.cs" %}
{% include code-snippet/dropdownlist/virtual-scroll-filter/virtualscroll.cs %}
{% endhighlight %}
{% endtabs %} 

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/virtual-scroll-filter/razor %}
{% endhighlight %} 
{% highlight c# tabtitle="virtualscroll.cs" %}
{% include code-snippet/dropdownlist/virtual-scroll-filter/virtualscroll.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}