---
layout: post
title: Drag And Drop in ##Platform_Name## List Box Control | Syncfusion
description: Learn here all about Drag And Drop in Syncfusion ##Platform_Name## List Box control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Drag And Drop
publishingplatform: ##Platform_Name##
documentation: ug
---


# Drag and drop in ListBox Control

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

{% if page.publishingplatform == "aspnet-core" %}

To drag and drop an item or group of item between two list boxes can be achieved by setting `allowDragAndDrop` property as `true` and [`scope`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.ListBox.html#Syncfusion_EJ2_DropDowns_ListBox_Scope) property should be set to both the list boxes.

{% elsif page.publishingplatform == "aspnet-mvc" %}

To drag and drop an item or group of item between two list boxes can be achieved by setting `allowDragAndDrop` property as `true` and [`scope`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.ListBox.html#Syncfusion_EJ2_DropDowns_ListBox_Scope) property should be set to both the list boxes.

{% endif %}

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

## Dual ListBox with drag and drop

{% if page.publishingplatform == "aspnet-core" %}

The toolbar and drag and drop actions between two listboxes can be enabled by setting a listbox unique id and the same [`scope`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.ListBox.html#Syncfusion_EJ2_DropDowns_ListBox_Scope) property value.

{% elsif page.publishingplatform == "aspnet-mvc" %}

The toolbar and drag and drop actions between two listboxes can be enabled by setting a listbox unique id and the same [`scope`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.ListBox.html#Syncfusion_EJ2_DropDowns_ListBox_Scope) property value.

{% endif %}

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/listbox/drag-drop/dual-drag/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Dragdrop.cs" %}
{% include code-snippet/listbox/drag-drop/dual-drag/dualdraglistbox.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/listbox/drag-drop/dual-drag/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Dragdrop.cs" %}
{% include code-snippet/listbox/drag-drop/dual-drag/dualdraglistbox.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}