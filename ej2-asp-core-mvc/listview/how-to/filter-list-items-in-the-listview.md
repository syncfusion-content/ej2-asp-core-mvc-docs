---
layout: post
title: Filter list items In The ListView in ##Platform_Name## ListView Control | Syncfusion
description: Learn here all about Filter list items In The ListView in Syncfusion ##Platform_Name## ListView control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Filter list items In The ListView
publishingplatform: ##Platform_Name##
documentation: ug
---

# Filter list items in the ListView

The filtered data can be displayed in the ListView control depending upon on user inputs using the [`DataManager`](https://ej2.syncfusion.com/documentation/data/getting-started/). Refer to the following steps to render the ListView with filtered data.

* Render a textbox to get input for filtering data.

* Render ListView with [`dataSource`](https://ej2.syncfusion.com/documentation/api/list-view/#datasource), and set the [`sortOrder`](https://ej2.syncfusion.com/documentation/api/list-view/#sortorder) property.

* Bind the `keyup` event for textbox to perform filtering operation. To filter list data, pass the list data source to the `DataManager`, manipulate the data using the [`executeLocal`](https://ej2.syncfusion.com/documentation/api/data/query/#executelocal) method, and then update filtered data as ListView dataSource.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/listview/filter/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="List.cs" %}
{% include code-snippet/listview/filter/list.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/listview/filter/razor %}
{% endhighlight %}
{% highlight c# tabtitle="List.cs" %}
{% include code-snippet/listview/filter/list.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



N> In this demo, data has been filtered with starting character of the list items. You can also filter list items with ending character by passing the `endswith` in [where](https://ej2.syncfusion.com/documentation/api/data/query/#where) clause instead of `startswith`.