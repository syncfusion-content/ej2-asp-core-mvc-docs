---
layout: post
title: Virtualization in ##Platform_Name## Combo Box Control | Syncfusion
description: Learn here all about Virtualization in Syncfusion ##Platform_Name## Combo Box control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Virtualization
publishingplatform: ##Platform_Name##
documentation: ug
---


# Virtualization in ComboBox Component 

ComboBox virtualization is a technique used to efficiently render extensive lists of items while minimizing the impact on performance. This method is particularly advantageous when dealing with large datasets because it ensures that only a fixed number of DOM (Document Object Model) elements are created. When scrolling through the list, existing DOM elements are reused to display relevant data instead of generating new elements for each item. This recycling process is managed internally.
 
During virtual scrolling, the data retrieved from the data source depends on the popup height and the calculation of the list item height. Enabling the [enableVirtualization](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.dropdowns.combobox.html#Syncfusion_EJ2_DropDowns_ComboBox_EnableVirtualization) option in a ComboBox activates this virtualization technique.
 
When fetching data from the data source, the [actionBegin](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.dropdowns.combobox.html#Syncfusion_EJ2_DropDowns_ComboBox_ActionBegin) event is triggered before data retrieval begins. Then, the [actionComplete](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.dropdowns.combobox.html#Syncfusion_EJ2_DropDowns_ComboBox_ActionComplete) event is triggered once the data is successfully fetched.


## Binding local data

Local data can be represented in two ways as described below.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/combobox/virtual-scroll/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/combobox/virtual-scroll/razor %}
{% endhighlight %}
{% highlight c# tabtitle="virtualscroll.cs" %}
{% include code-snippet/combobox/virtual-scroll/virtualscroll.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Binding remote data

Remote data can be represented in two ways as described below.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/combobox/virtual-scroll-remote/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/combobox/virtual-scroll-remote/razor %}
{% endhighlight %}
{% highlight c# tabtitle="virtualscroll.cs" %}
{% include code-snippet/combobox/virtual-scroll-remote/virtualscroll.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Grouping

Local data can be represented in two ways as described below.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/combobox/virtual-scroll-group/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/combobox/virtual-scroll-group/razor %}
{% endhighlight %}
{% highlight c# tabtitle="virtualscroll.cs" %}
{% include code-snippet/combobox/virtual-scroll-group/virtualscroll.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}