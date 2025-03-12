---
layout: post
title: Drag And Drop list items in ##Platform_Name## ListView Control | Syncfusion
description: Learn here all about Drag And Drop list items in Syncfusion ##Platform_Name## ListView control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Drag And Drop list items
publishingplatform: ##Platform_Name##
documentation: ug
---

# Drag and Drop list items

In ListView control, we don't have drag and drop support. But we can achieve this requirement using [`TreeView`](https://ej2.syncfusion.com/aspnetcore/documentation/treeview/getting-started/) control with ListView appearance.

Drag and Drop in TreeView control was enabled by setting [`allowDragAndDrop`](https://ej2.syncfusion.com/documentation/api/treeview#allowdraganddrop) to `true`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

<ejs-treeview id="element"  allowDragAndDrop="true" >
    <e-treeview-fields dataSource="ViewBag.dataSource" id="id" text="text"></e-treeview-fields>
</ejs-treeview>

{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}

@Html.EJS().TreeView("element").Fields(ViewBag.TreeViewFields).AllowDragAndDrop(true).Render()

{% endhighlight %}
{% endtabs %}
{% endif %}

The TreeView control is used to represent hierarchical data in a tree like structure. So, list items in TreeView can be dropped to child of target element. we can prevent this behaviour by cancelling the [`nodeDragStop`](https://ej2.syncfusion.com/documentation/api/treeview#nodedragstop) and [`nodeDragging`](https://ej2.syncfusion.com/documentation/api/treeview#nodedragging) events.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

<ejs-treeview id="element"  allowDragAndDrop="true" nodeDragging="onDragStop" nodeDragStop="onDragStop">
    <e-treeview-fields dataSource="ViewBag.dataSource" id="id" text="text"></e-treeview-fields>
</ejs-treeview>

function onDragStop(args) {
    //Block the Child Drop operation in TreeView
   var  draggingItem = document.getElementsByClassName("e-drop-in");
    if (draggingItem.length == 1) {
        draggingItem[0].classList.add('e-no-drop');
        args.cancel = true;
    }
}

{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}

@Html.EJS().TreeView("element").Fields(ViewBag.TreeViewFields).AllowDragAndDrop(true).NodeDragging("onDragStop").NodeDragStop("onDragStop").Render()

function onDragStop(args) {
    //Block the Child Drop operation in TreeView
   var  draggingItem = document.getElementsByClassName("e-drop-in");
    if (draggingItem.length == 1) {
        draggingItem[0].classList.add('e-no-drop');
        args.cancel = true;
    }
}

{% endhighlight %}
{% endtabs %}
{% endif %}

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

