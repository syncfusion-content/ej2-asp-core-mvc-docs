---
layout: post
title: Add And Remove List Items From Listview in ##Platform_Name## Listview Component
description: Learn here all about Add And Remove List Items From Listview in Syncfusion ##Platform_Name## Listview component and more.
platform: ej2-asp-core-mvc
control: Add And Remove List Items From Listview
publishingplatform: ##Platform_Name##
documentation: ug
---

# Add and Remove List Items from the ListView

You can add or remove list items from the ListView component using the
[`addItem`](https://ej2.syncfusion.com/documentation/api/list-view/#additem) and
[`removeItem`](https://ej2.syncfusion.com/documentation/api/list-view/#removeitem) methods.
Refer to the following steps to add or remove a list item.

* Render the ListView with data source, and use the
[template](https://ej2.syncfusion.com/documentation/api/list-view/#template) property to append the delete icon
for each list item. Also, bind the click event for the delete icon using the
[actionComplete](https://ej2.syncfusion.com/documentation/api/list-view/#actioncomplete) handler.

* Render the Add Item button, and bind the click event. On the click event handler, pass data with random id to
the [`addItem`](https://ej2.syncfusion.com/documentation/api/list-view/#additem) method to add a
new list item on clicking the Add Item button.

* Bind the click handler to the delete icon created in step 1. Within the click event, remove the list item by passing the
delete icon list item to
[`removeItem`](https://ej2.syncfusion.com/documentation/api/list-view/#removeitem) method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/listview/add-item/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="List.cs" %}
{% include code-snippet/listview/add-item/list.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/listview/add-item/razor %}
{% endhighlight %}
{% highlight c# tabtitle="List.cs" %}
{% include code-snippet/listview/add-item/list.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

