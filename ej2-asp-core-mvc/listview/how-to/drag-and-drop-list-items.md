---
layout: post
title: Drag And Drop List Items in ##Platform_Name## Listview Component
description: Learn here all about Drag And Drop List Items in Syncfusion ##Platform_Name## Listview component and more.
platform: ej2-asp-core-mvc
control: Drag And Drop List Items
publishingplatform: ##Platform_Name##
documentation: ug
---

# Drag and Drop List Items

In ListView component, we don't have drag and drop support. But we can achieve this requirement using [`TreeView`](https://ej2.syncfusion.com/aspnetcore/documentation/treeview/getting-started/) component with ListView appearance.

Drag and Drop in TreeView component was enabled by setting [`allowDragAndDrop`](https://ej2.syncfusion.com/documentation/api/treeview#allowdraganddrop) to `true`.

```typescript

@Html.EJS().TreeView("element").Fields(ViewBag.TreeViewFields).AllowDragAndDrop(true).Render()

```

The TreeView component is used to represent hierarchical data in a tree like structure. So, list items in TreeView can be dropped to child of target element. we can prevent this behaviour by cancelling the [`nodeDragStop`](https://ej2.syncfusion.com/documentation/api/treeview#nodedragstop) and [`nodeDragging`](https://ej2.syncfusion.com/documentation/api/treeview#nodedragging) events.

```typescript

@Html.EJS().TreeView("element").Fields(ViewBag.TreeViewFields).AllowDragAndDrop(true).NodeDragging("onDragStop").NodeDragStop("onDragStop").Render()

function onDragStop(args) {
    //Block the Child Drop operation in TreeView
   var  draggingItem = document.getElementsByClassName("e-drop-in");
    if (draggingItem.length == 1) {
        draggingItem[0].classList.add('e-no-drop');
        args.cancel = true;
    }
}

```

In the below sample, we have rendered draggable list items.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/listview/treeview/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="List.cs" %}
{% include code-snippet/listview/treeview/list.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/listview/treeview/razor %}
{% endhighlight %}
{% highlight c# tabtitle="List.cs" %}
{% include code-snippet/listview/treeview/list.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

