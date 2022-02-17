---
layout: post
title: Get Selected Items From Listview in ##Platform_Name## Listview Component
description: Learn here all about Get Selected Items From Listview in Syncfusion ##Platform_Name## Listview component and more.
platform: ej2-asp-core-mvc
control: Get Selected Items From Listview
publishingplatform: ##Platform_Name##
documentation: ug
---

# Get selected items from ListView

Single or many items can be selected by users in the ListView component. An API is used to get selected items from the
list items. This is called as the
[`getSelectedItems`](https://ej2.syncfusion.com/documentation/api/list-view/#getselecteditems)
method.

**`getSelectedItems` method**

This is used to get the details of the currently selected item from the list items. It returns the
[`SelectedItem`](https://ej2.syncfusion.com/documentation/api/list-view/selectedItem/) |
[`SelectedCollection`](https://ej2.syncfusion.com/documentation/api/list-view/selectedCollection/)

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


