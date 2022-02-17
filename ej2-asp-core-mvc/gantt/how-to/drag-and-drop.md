---
layout: post
title: Drag And Drop in ##Platform_Name## Gantt Component
description: Learn here all about Drag And Drop in Syncfusion ##Platform_Name## Gantt component and more.
platform: ej2-asp-core-mvc
control: Drag And Drop
publishingplatform: ##Platform_Name##
documentation: ug
---


# Drag and Drop the Record from another component to Gantt

In Gantt, it is possible to drag a record from another component and drop it in Gantt chart with updating the Gantt record. Here, dragging an item from `TreeView` component to Gantt and that item is updated as a resource for the Gantt record, we can achieve this, by using [`nodeDragStop`](../../api/treeview/#nodedragstop) event of `TreeView` control.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/how-to/draganddrop/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Draganddrop.cs" %}
{% include code-snippet/gantt/how-to/draganddrop/draganddrop.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/how-to/draganddrop/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Draganddrop.cs" %}
{% include code-snippet/gantt/how-to/draganddrop/draganddrop.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



The following screenshot shows dropping record from another component in to Gantt, and **Rose Fuller** is added as resource for the task **Develop floor plan estimation**.

![Dropping Record](../images/dropping.png)