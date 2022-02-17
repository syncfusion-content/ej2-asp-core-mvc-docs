---
layout: post
title: Drag And Drop in ##Platform_Name## List Box Component
description: Learn here all about Drag And Drop in Syncfusion ##Platform_Name## List Box component and more.
platform: ej2-asp-core-mvc
control: Drag And Drop
publishingplatform: ##Platform_Name##
documentation: ug
---


# Drag and drop

The ListBox has support to drag an item or a group of selected items and drop it within the same list box or into another list box.

The elements can be customized on drag and drop by using the following events,

| Events | Description |
|------|------|
| [`dragStart`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.ListBox~DragStart.html) | Triggers when the selected element is being dragged. |
| [`drag`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.ListBox~Drag.html) | Triggers when the selected element is being dragged. |
| [`drop`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.ListBox~Drop.html) | Triggers when the selected element is being dropped. |

## Single listbox

To drag and drop an item or group of item within the list box can be achieved by setting [`allowDragAndDrop`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.ListBox~AllowDragAndDrop.html) property as `true`.

The following sample illustrates how to drag and drop an item within the same list box by enabling `allowDragAndDrop` property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/listbox/drag-drop/single/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Dragdrop.cs" %}
{% include code-snippet/listbox/drag-drop/single/dragdrop.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/listbox/drag-drop/single/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Dragdrop.cs" %}
{% include code-snippet/listbox/drag-drop/single/dragdrop.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Multiple listbox

To drag and drop an item or group of item between two list boxes can be achieved by setting `allowDragAndDrop` property as `true` and [`scope`](../api/list-box/#scope) property should be set to both the list boxes.

In the following sample, the `allowDragAndDrop` property is set as `true` and `scope` is set as `combined-list` to enable drop and drop in both list boxes.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/listbox/drag-drop/multiple/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Dragdrop.cs" %}
{% include code-snippet/listbox/drag-drop/multiple/dragdrop.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/listbox/drag-drop/multiple/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Dragdrop.cs" %}
{% include code-snippet/listbox/drag-drop/multiple/dragdrop.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

