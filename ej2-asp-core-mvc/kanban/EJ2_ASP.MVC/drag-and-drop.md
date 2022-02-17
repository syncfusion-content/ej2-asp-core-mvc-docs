---
layout: post
title: Drag And Drop in ##Platform_Name## Kanban Component
description: Learn here all about Drag And Drop in Syncfusion ##Platform_Name## Kanban component and more.
platform: ej2-asp-core-mvc
control: Drag And Drop
publishingplatform: ##Platform_Name##
documentation: ug
---


# Drag and drop

All cards can be dragged and dropped across the columns or within the columns or swimlane row or kanban to an external source and vice versa.

The following drag and drop types are available in the Kanban board.

* Internal drag and drop
    * Column drag and drop
    * Swimlane drag and drop
* External drag and drop
    * Kanban to Kanban
    * Kanban to External source and vice versa.

> Dropped card position varies based on the `SortSettings` property.

## Internal drag and drop

Allows the user to drag and drop the cards within the kanban board. Based on this, we can categorize into two ways.

* Column drag and drop
* Swimlane drag and drop

### Column drag and drop

By default, all cards can be dragged and dropped across the columns and within the columns. You cannot drag and drop the cards when disabling the `AllowDragAndDrop` property.

> You can prevent the drag or drop behavior of the particular column by disabling the `AllowDrag` or `AllowDrop` property.
> You can also control the flow of transition cards between the columns by using the `TransitionColumns` property.

In the following example, disable the drag and drop behavior on the Kanban board.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/kanban/drag-and-drop/drag-and-drop/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Datasource.cs" %}
{% include code-snippet/kanban/drag-and-drop/drag-and-drop/datasource.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/kanban/drag-and-drop/drag-and-drop/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Datasource.cs" %}
{% include code-snippet/kanban/drag-and-drop/drag-and-drop/datasource.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Swimlane drag and drop

By default, Swimlane allows drag and drop across the columns within the swimlane row. Kanban does not allow dragging the cards across the swimlane rows.

Enabling the `DragAndDrop` property allows you to drag the cards across the swimlane rows, which is specified inside the `SwimlaneSettings` property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/kanban/drag-and-drop/swimlane-drag-and-drop/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Datasource.cs" %}
{% include code-snippet/kanban/drag-and-drop/swimlane-drag-and-drop/datasource.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/kanban/drag-and-drop/swimlane-drag-and-drop/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Datasource.cs" %}
{% include code-snippet/kanban/drag-and-drop/swimlane-drag-and-drop/datasource.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## External drag and drop

Allows the user to drag and drop the cards from one kanban to another kanban or Kanban to an external source and vice versa.

### Kanban to kanban

Drag and drop the card from one kanban to another kanban and vice versa. This can be achieved by specifying the `ExternalDropId` property which is used to specify the id of the dropped kanban element and the `DragStop` event which is used to delete the card on dragged Kanban and add the card on dropped Kanban using the `deleteCard` and `addCard` public methods.

> Before adding a card to dropped kanban, you can manually change the card data `HeaderField` when the same card data `HeaderField` is dropped to another Kanban.

In the following example, Drag the card from one Kanban and drop it into another kanban using the `DragStop` event. In this event, remove the card from the dragged Kanban by using the `deleteCard` public method and add the card to the dropped Kanban by using the `addCard` public method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/kanban/drag-and-drop/kanban-to-kanban/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Datasource.cs" %}
{% include code-snippet/kanban/drag-and-drop/kanban-to-kanban/datasource.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/kanban/drag-and-drop/kanban-to-kanban/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Datasource.cs" %}
{% include code-snippet/kanban/drag-and-drop/kanban-to-kanban/datasource.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Treeview to Kanban

Drag the card from the Kanban board and drop it to the Treeview component and vice versa.

In the following sample, remove the data from the Kanban board using the `deleteCard` public method and add to the Treeview component using the `addNodes` public method at Kanban `DragStop` event when dragging the card and dropping it to the Treeview component. Remove the data from Treeview using the `removeNodes` public method and add to Kanban board using the `openDialog` public method when dragging the list from the Treeview component and dropping it to the kanban board.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/kanban/drag-and-drop/kanban-to-treeview/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Datasource.cs" %}
{% include code-snippet/kanban/drag-and-drop/kanban-to-treeview/datasource.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/kanban/drag-and-drop/kanban-to-treeview/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Datasource.cs" %}
{% include code-snippet/kanban/drag-and-drop/kanban-to-treeview/datasource.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Schedule to Kanban

Drag the card from the Kanban board and drop it to the Schedule component and vice versa.

In the following sample, remove the data from the Kanban board using the `deleteCard` public method and add to the schedule component using the `addNodes` public method at Kanban `DragStop` event when dragging the card and dropping it to the Treeview component. Remove the data from Treeview using the `removeNodes` public method and add to Kanban board using the `addCard` public method when dragging the list from the Treeview component and dropping it to the kanban board.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/kanban/drag-and-drop/kanban-to-schedule/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Datasource.cs" %}
{% include code-snippet/kanban/drag-and-drop/kanban-to-schedule/datasource.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/kanban/drag-and-drop/kanban-to-schedule/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Datasource.cs" %}
{% include code-snippet/kanban/drag-and-drop/kanban-to-schedule/datasource.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


