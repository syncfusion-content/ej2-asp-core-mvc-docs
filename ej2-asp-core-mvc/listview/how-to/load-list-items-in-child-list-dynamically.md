---
layout: post
title: Load List Items In Child List Dynamically in ##Platform_Name## Listview Component
description: Learn here all about Load List Items In Child List Dynamically in Syncfusion ##Platform_Name## Listview component and more.
platform: ej2-asp-core-mvc
control: Load List Items In Child List Dynamically
publishingplatform: ##Platform_Name##
documentation: ug
---

# Load List Items in child list dynamically

To load list items in child list dynamically, push the new list item data into the existing
[`dataSource`](https://ej2.syncfusion.com/documentation/api/list-view/#datasource) using
the [`select`](https://ej2.syncfusion.com/documentation/api/list-view/#select) event.

Refer to the following steps to load list item into the child list:

1. Initially, render the ListView with the required data source.

2. Bind the [`select`](https://ej2.syncfusion.com/documentation/api/list-view/#select) event that
triggers selecting list item in the ListView component. By using the select event, you can push the new list item to the child
list of the data source on specifying its item index. Item index can be obtained from the
[`SelectEventArgs`](https://ej2.syncfusion.com/documentation/api/list-view/selectEventArgs/) of the
select event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/listview/child-list/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="List.cs" %}
{% include code-snippet/listview/child-list/list.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/listview/child-list/razor %}
{% endhighlight %}
{% highlight c# tabtitle="List.cs" %}
{% include code-snippet/listview/child-list/list.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

