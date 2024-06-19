---
layout: post
title: Virtualization in ##Platform_Name## MultiColumn Combobox Control | Syncfusion
description: Checkout and learn about Virtualization in Syncfusion ##Platform_Name## MultiColumn Combobox control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Virtualization
publishingplatform: ##Platform_Name##
documentation: ug
---

# Virtualization in ##Platform_Name## MultiColumn Combobox control

MultiColumn ComboBox virtualization is a technique used to efficiently render extensive lists of items while minimizing the impact on performance. This method is particularly advantageous when dealing with large datasets because it ensures that only a fixed number of DOM (Document Object Model) elements are created. When scrolling through the list, existing DOM elements are reused to display relevant data instead of generating new elements for each item. This recycling process is managed internally.

Enabling the [EnableVirtualization](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.MultiColumnComboBox.MultiColumnComboBox.html#Syncfusion_EJ2_MultiColumnComboBox_MultiColumnComboBox_EnableVirtualization) property option in a MultiColumn ComboBox activates this virtualization technique.

## Binding local data

The MultiColumn Combobox can generate its list items through an object arrays of data. For this, the appropriate columns should be mapped to the `Fields` property. When using virtual scrolling, the list updates based on the scroll offset value, triggering a request to fetch more data from the server.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multicolumn-combobox/virtualization/localdata/razor %}
{% endhighlight %}
{% highlight c# tabtitle="LocalData.cs" %}
{% include code-snippet/multicolumn-combobox/virtualization/localdata/localdata.cs %}
{% endhighlight %}
{% endtabs %}

![SortOrder](images/sortorder.png)

## Binding remote data

The MultiColumn Combobox supports retrieval of data from remote data services with the help of DataManager component. When using remote data, it initially fetches all the data from the server and then stores the data locally. During virtual scrolling, additional data is retrieved from the locally stored data.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multicolumn-combobox/virtualization/remotedata/razor %}
{% endhighlight %}
{% highlight c# tabtitle="RemoteData.cs" %}
{% include code-snippet/multicolumn-combobox/virtualization/remotedata/remotedata.cs %}
{% endhighlight %}
{% endtabs %}

![SortOrder](images/sortorder.png)