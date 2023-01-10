---
layout: post
title: Swimlane and Grouping of Cards in Syncfusion ##Platform_Name## Kanban Component
description: Learn here all about Swimlane in Syncfusion ##Platform_Name## Kanban component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Swimlane
publishingplatform: ##Platform_Name##
documentation: ug
---


# Swimlane in ASP.NET MVC Kanban control

Swimlanes are horizontal categorizations of cards on the Kanban board.  It is used for grouping of cards, which brings transparency to the workflow process.

## Render swimlane row

Cards can be grouped based on `KeyField` and displayed in rows, which are separated by columns. It is mandatory to define the `KeyField` that is mapped from the datasource for rendering swimlane rows in the Kanban board.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/kanban/swimlane/swimlane-row/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Datasource.cs" %}
{% include code-snippet/kanban/swimlane/swimlane-row/datasource.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/kanban/swimlane/swimlane-row/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/kanban/swimlane/swimlane-row/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Datasource.cs" %}
{% include code-snippet/kanban/swimlane/swimlane-row/datasource.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/kanban/swimlane/swimlane-row/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![kanban](./images/swimlane-row.PNG)

## Custom row text

Customize the swimlane row header text by using the `TextField` property mapped from datasource.

> It is not mandatory to define the `TextField` to `SwimlaneSettings`. It will automatically consider the `KeyField` to swimlane row header text.
> If the mapping `TextField` key is not present in the datasource, it will consider the swimlane `KeyField` as swimlane row header text.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/kanban/swimlane/custom-row/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Datasource.cs" %}
{% include code-snippet/kanban/swimlane/custom-row/datasource.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/kanban/swimlane/custom-row/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/kanban/swimlane/custom-row/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Datasource.cs" %}
{% include code-snippet/kanban/swimlane/custom-row/datasource.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/kanban/swimlane/custom-row/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Template

You can customize the Kanban swimlane row by using the `Template` property, which is specified within the `SwimlaneSettings` property. In this demo, the swimlane header is customized with HTML element.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/kanban/swimlane/template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Datasource.cs" %}
{% include code-snippet/kanban/swimlane/template/datasource.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/kanban/swimlane/template/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/kanban/swimlane/template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Datasource.cs" %}
{% include code-snippet/kanban/swimlane/template/datasource.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/kanban/swimlane/template/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![kanban](./images/template.PNG)

## Sorting

Swimlane rows are rendered on descending order when using the `SortBy` property set to `Descending` order. By default, swimlane rows are rendered by **Ascending** order.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/kanban/swimlane/sorting/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Datasource.cs" %}
{% include code-snippet/kanban/swimlane/sorting/datasource.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/kanban/swimlane/sorting/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/kanban/swimlane/sorting/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Datasource.cs" %}
{% include code-snippet/kanban/swimlane/sorting/datasource.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/kanban/swimlane/sorting/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![kanban](./images/sorting.PNG)

## Drag-and-drop

By default, The Kanban does not allow dragging the cards across the swimlane rows. Enabling the `DragAndDrop` property allows you to drag the cards across the swimlane rows, which is specified inside `SwimlaneSettings` property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/kanban/swimlane/drag-and-drop/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Datasource.cs" %}
{% include code-snippet/kanban/swimlane/drag-and-drop/datasource.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/kanban/swimlane/drag-and-drop/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/kanban/swimlane/drag-and-drop/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Datasource.cs" %}
{% include code-snippet/kanban/swimlane/drag-and-drop/datasource.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/kanban/swimlane/drag-and-drop/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Create empty row

You can render the empty swimlane row by enabling the `ShowEmptyRow` property. If mapping `KeyField` does not have cards, empty swimlane row will be rendered.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/kanban/swimlane/empty-row/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Datasource.cs" %}
{% include code-snippet/kanban/swimlane/empty-row/datasource.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/kanban/swimlane/empty-row/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/kanban/swimlane/empty-row/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Datasource.cs" %}
{% include code-snippet/kanban/swimlane/empty-row/datasource.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/kanban/swimlane/empty-row/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![kanban](./images/empty-row.PNG)

## Calculate cards count

Users can show or hide the cards count by swimlane row in header when enabling the `ShowItemCount` property, which is enabled by default on the Kanban board.

> Provided localization support for **Items** text.

In below demo, disabled on `ShowItemCount` property on rendering swimlane row without total count.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/kanban/swimlane/cards-count/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Datasource.cs" %}
{% include code-snippet/kanban/swimlane/cards-count/datasource.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/kanban/swimlane/cards-count/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/kanban/swimlane/cards-count/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Datasource.cs" %}
{% include code-snippet/kanban/swimlane/cards-count/datasource.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/kanban/swimlane/cards-count/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![kanban](./images/cards-count.PNG)

## Enable frozen rows

Frozen rows provide an option to make the current swimlane row header text always visible on top of the content while scrolling the Kanban content. The swimlane header text will be changed dynamically, when you scroll to another swimlane row.

By default, the `EnableFrozenRows` property is set as `false`. If you wish to show the swimlane frozen rows, you can enable the `EnableFrozenRows` property.

> This feature support only when using Kanban content scrolling.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/kanban/swimlane/frozen-rows/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Datasource.cs" %}
{% include code-snippet/kanban/swimlane/frozen-rows/datasource.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/kanban/swimlane/frozen-rows/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/kanban/swimlane/frozen-rows/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Datasource.cs" %}
{% include code-snippet/kanban/swimlane/frozen-rows/datasource.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/kanban/swimlane/frozen-rows/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![kanban](./images/frozen-rows.png)
