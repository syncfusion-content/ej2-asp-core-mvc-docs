---
layout: post
title: Virtualization in ##Platform_Name## MultiSelect | Syncfusion
description: Enable Syncfusion ##Platform_Name## MultiSelect UI virtualization to render only visible items from large datasets via virtual scroll item count and height.
platform: ej2-asp-core-mvc
control: Virtualization
publishingplatform: ##Platform_Name##
documentation: ug
---


# Virtualization in ##Platform_Name## MultiSelect

MultiSelect Dropdown virtualization efficiently renders large lists of items while minimizing the impact on performance. This is particularly advantageous for large datasets because it ensures that only a fixed number of DOM (Document Object Model) elements are created. When scrolling through the list, existing DOM elements are reused to display relevant data instead of generating new elements for each item. This recycling is managed internally.

During virtual scrolling, the data retrieved from the data source depends on the popup height and the calculated list item height. Enable the [enableVirtualization](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.dropdowns.multiselect.html#Syncfusion_EJ2_DropDowns_MultiSelect_EnableVirtualization) option in a MultiSelect Dropdown to activate this virtualization technique.

When fetching data from the data source, the [actionBegin](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.dropdowns.multiselect.html#Syncfusion_EJ2_DropDowns_MultiSelect_ActionBegin) event is triggered before data retrieval begins. The [actionComplete](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.dropdowns.multiselect.html#Syncfusion_EJ2_DropDowns_MultiSelect_ActionComplete) event is triggered once the data is successfully fetched.

Furthermore, Incremental Search is supported with virtualization in the MultiSelect control. When a key is typed while the popup is open, focus moves to the matching element. In the closed popup state, the popup opens and focus moves to the matching element based on the typed key. The Incremental Search functionality is well-suited for scenarios involving remote data binding.

## Binding local data

The MultiSelect can generate its list items from an array of complex data. For this, the appropriate columns must be mapped to the [fields](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.dropdowns.multiselect.html#Syncfusion_EJ2_DropDowns_MultiSelect_Fields) property. When using virtual scrolling, the list updates based on the scroll offset value, triggering a request to fetch more data from the server.

In the following example, the `id` and `text` columns from the complex data are mapped to the `value` and `text` fields, respectively.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multiselect/virtual-scroll/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="virtualscroll.cs" %}
{% include code-snippet/multiselect/virtual-scroll/virtualscroll.cs %}
{% endhighlight %}
{% endtabs %} 

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multiselect/virtual-scroll/razor %}
{% endhighlight %} 
{% highlight c# tabtitle="virtualscroll.cs" %}
{% include code-snippet/multiselect/virtual-scroll/virtualscroll.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Binding remote data

The MultiSelect supports the retrieval of data from remote data services with the help of the `DataManager` control, triggering the `actionBegin` and `actionComplete` events, and then updating the list data. During virtual scrolling, additional data is retrieved from the server, triggering the `actionBegin` and `actionComplete` events at that time as well.

The following sample displays the OrderId from the `Orders` Data Service.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multiselect/virtual-scroll-remote/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="virtualscroll.cs" %}
{% include code-snippet/multiselect/virtual-scroll-remote/virtualscroll.cs %}
{% endhighlight %}
{% endtabs %} 

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multiselect/virtual-scroll-remote/razor %}
{% endhighlight %} 
{% highlight c# tabtitle="virtualscroll.cs" %}
{% include code-snippet/multiselect/virtual-scroll-remote/virtualscroll.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Customizing item count in virtualization

When `enableVirtualization` is enabled, the `take` value provided in the `Query` parameter at the initial state or in the `actionBegin` event is considered. Internally, the MultiSelect calculates the items that fit on the current page (about twice the popup's height). If the user-provided `take` value is less than the minimum number of items that fit into the popup, the user-provided `take` value is ignored.

The following sample shows the example for customizing the item count in virtualization.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multiselect/virtual-scroll-items/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="virtualscroll.cs" %}
{% include code-snippet/multiselect/virtual-scroll-items/virtualscroll.cs %}
{% endhighlight %}
{% endtabs %} 

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multiselect/virtual-scroll-items/razor %}
{% endhighlight %} 
{% highlight c# tabtitle="virtualscroll.cs" %}
{% include code-snippet/multiselect/virtual-scroll-items/virtualscroll.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Grouping with virtualization

The MultiSelect control supports grouping with virtualization. It allows you to organize elements into groups based on different categories. Each item in the list can be classified using the [groupBy](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.dropdowns.multiselect.html#Syncfusion_EJ2_DropDowns_MultiSelect_Fields) field in the data table. After grouping, virtualization works similarly to local data binding, providing a seamless user experience. When the data source is bound to remote data, an initial request is made to retrieve all data for the purpose of grouping. Subsequently, the grouped data works in the same way as local data binding on virtualization.

The following sample shows the example for grouping with virtualization. 

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multiselect/virtual-scroll-group/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="virtualscroll.cs" %}
{% include code-snippet/multiselect/virtual-scroll-group/virtualscroll.cs %}
{% endhighlight %}
{% endtabs %} 

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multiselect/virtual-scroll-group/razor %}
{% endhighlight %} 
{% highlight c# tabtitle="virtualscroll.cs" %}
{% include code-snippet/multiselect/virtual-scroll-group/virtualscroll.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Filtering with virtualization

The MultiSelect control supports filtering with virtualization. The MultiSelect includes a built-in feature that enables data filtering when the [allowFiltering](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.dropdowns.multiselect.html#Syncfusion_EJ2_DropDowns_MultiSelect_AllowFiltering) option is enabled. In the context of virtual scrolling, the filtering process operates in response to the typed characters: the MultiSelect sends a request to the server, using the full data source, to apply the filter. Before initiating the request, an [actionBegin](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.MultiSelect.html#Syncfusion_EJ2_DropDowns_MultiSelect_ActionBegin) event is triggered. Upon successful retrieval of data from the server, an [actionComplete](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.MultiSelect.html#Syncfusion_EJ2_DropDowns_MultiSelect_ActionComplete) event is triggered. The initial data is loaded when the popup is opened. Whether the filter list has a selection or not, the popup closes.

The following sample shows the example for filtering with virtualization.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multiselect/virtual-scroll-filter/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="virtualscroll.cs" %}
{% include code-snippet/multiselect/virtual-scroll-filter/virtualscroll.cs %}
{% endhighlight %}
{% endtabs %} 

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multiselect/virtual-scroll-filter/razor %}
{% endhighlight %} 
{% highlight c# tabtitle="virtualscroll.cs" %}
{% include code-snippet/multiselect/virtual-scroll-filter/virtualscroll.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Checkbox with virtualization

The MultiSelect control supports checkbox selection with virtualization. The MultiSelect comes with integrated functionality that allows for the selection of multiple values using checkboxes when the [mode](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.dropdowns.multiselect.html#Syncfusion_EJ2_DropDowns_MultiSelect_Mode) property is configured to `CheckBox`. In the context of virtual scrolling, the checkbox is rendered with each list element. Based on the checkbox selection and unselection, the control `value` property is updated with the respective values.

The following sample shows the example for checkbox with virtualization.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multiselect/virtual-scroll-check/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="virtualscroll.cs" %}
{% include code-snippet/multiselect/virtual-scroll-check/virtualscroll.cs %}
{% endhighlight %}
{% endtabs %} 

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multiselect/virtual-scroll-check/razor %}
{% endhighlight %} 
{% highlight c# tabtitle="virtualscroll.cs" %}
{% include code-snippet/multiselect/virtual-scroll-check/virtualscroll.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Custom value with virtualization

The MultiSelect control supports custom value with virtualization. When the [allowCustomValue](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.dropdowns.multiselect.html#Syncfusion_EJ2_DropDowns_MultiSelect_AllowCustomValue) property is enabled, the MultiSelect enables users to include a new option that is not currently available in the control value. Upon selecting this newly added custom value, the MultiSelect triggers the [customValueSelection](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.dropdowns.multiselect.html#Syncfusion_EJ2_DropDowns_MultiSelect_CustomValueSelection) event and the custom value is added to the end of the complete list.

The following sample shows the example for custom value with virtualization.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multiselect/virtual-scroll-custom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="virtualscroll.cs" %}
{% include code-snippet/multiselect/virtual-scroll-custom/virtualscroll.cs %}
{% endhighlight %}
{% endtabs %} 

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multiselect/virtual-scroll-custom/razor %}
{% endhighlight %} 
{% highlight c# tabtitle="virtualscroll.cs" %}
{% include code-snippet/multiselect/virtual-scroll-custom/virtualscroll.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


## Preselect values with virtualization

The MultiSelect control extends its support for preselected values with virtualization. When binding values from local or remote data to the MultiSelect control, the corresponding data value is fetched from the server and promptly updated within the control. Moreover, when binding a custom value to the control, the value is updated within the control, and the bound custom value is seamlessly appended to the end of the complete list.

The following sample shows the example for preselect values with virtualization.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multiselect/virtual-scroll-preselect/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="virtualscroll.cs" %}
{% include code-snippet/multiselect/virtual-scroll-preselect/virtualscroll.cs %}
{% endhighlight %}
{% endtabs %} 

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multiselect/virtual-scroll-preselect/razor %}
{% endhighlight %} 
{% highlight c# tabtitle="virtualscroll.cs" %}
{% include code-snippet/multiselect/virtual-scroll-preselect/virtualscroll.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}