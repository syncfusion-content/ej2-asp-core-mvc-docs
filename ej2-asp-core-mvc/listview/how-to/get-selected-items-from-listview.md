---
layout: post
title: Get selected items From ListView in ##Platform_Name## ListView Control | Syncfusion
description: Learn here all about Get selected items From ListView in Syncfusion ##Platform_Name## ListView control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Get selected items From ListView
publishingplatform: ##Platform_Name##
documentation: ug
---

# Get selected items from ListView

Single or many items can be selected by users in the ListView control. An API is used to get selected items from the list items. This is called as the [`getSelectedItems`](https://ej2.syncfusion.com/documentation/api/list-view/#getselecteditems) method.

| Method | Usage |
|------------|-------------------|
**getSelectedItems** | This is used to get the details of the currently selected item from the list items. It returns the [`SelectedItem`](https://ej2.syncfusion.com/documentation/api/list-view/selectedItem/) or [`SelectedCollection`](https://ej2.syncfusion.com/documentation/api/list-view/selectedCollection/) depending on the selection mode.

The `getSelectedItems` method returns the following items from the selected list items.

| Return type | Purpose |
|------------|-------------------|
| text | Returns the text of selected item lists |
| data | Returns the whole data of selected list items, i.e., returns the fields data of selected li.|
| item | Returns the collections of list items |

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/listview/selectedItem/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="List.cs" %}
{% include code-snippet/listview/selectedItem/list.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/listview/selectedItem/razor %}
{% endhighlight %}
{% highlight c# tabtitle="List.cs" %}
{% include code-snippet/listview/selectedItem/list.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


