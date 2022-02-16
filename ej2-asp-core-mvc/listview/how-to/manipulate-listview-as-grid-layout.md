---
layout: post
title: Manipulate Listview As Grid Layout in ##Platform_Name## Listview Component
description: Learn here all about Manipulate Listview As Grid Layout in Syncfusion ##Platform_Name## Listview component and more.
platform: ej2-asp-core-mvc
control: Manipulate Listview As Grid Layout
publishingplatform: ##Platform_Name##
documentation: ug
---

# Manipulate ListView as Grid Layout

In Listview, list items can be rendered in grid layout with following data manipulations.

* Add Item

* Remove Item

* Sort Items

* Filter Items

## Grid Layout

In this section, we will discuss about rendering of list items in grid layout.

* Initialize and render ListView with dataSource which will render list items in list layout.

* Now, add the below CSS to list item. This will make list items to render in grid layout

```css

#element .e-list-item {
        height: 100px;
        width: 100px;
        float: left;
}

```

In the below sample, we have rendered List items in grid layout.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/listview/grid-layout/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="List.cs" %}
{% include code-snippet/listview/grid-layout/list.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/listview/grid-layout/razor %}
{% endhighlight %}
{% highlight c# tabtitle="List.cs" %}
{% include code-snippet/listview/grid-layout/list.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Data manipulation

In this section, we will discuss about ListView data manipulations.

## Add Item

We can add list item using [`addItem`](https://ej2.syncfusion.com/documentation/api/list-view/#additem) API. This will accept array of data as argument.

```typescript

 listViewInstance.addItem([{text: 'Apricot', id: '32'}]);

```

In the below sample, you can add new fruit item by clicking add button which will open dialog box with fruit name and image URL text box. After entering the item details, click the add button. This will add your new fruit item.

## Remove item

We can remove list item using [`removeItem`](https://ej2.syncfusion.com/documentation/api/list-view/#removeitem) API. This will accept fields with `id` or list item element as argument.

```typescript

 listViewInstance.removeItem({id: '32'});

```

In the below sample, you can remove fruit by hovering the fruit item which will show delete button and click that delete button to delete that fruit from your list.

## Sort Items

Listview can be sorted either in Ascending or Descending order. To enable sorting in your ListView, set [`sortOrder`](https://ej2.syncfusion.com/documentation/api/list-view/#sortorder) as `Ascending` or `Descending`.

```typescript

@Html.EJS().ListView("element").SortOrder(SortOrder.Ascending).Render()

```

We can also set sorting after component initialization.

```typescript

listViewInstance.sortOrder = 'Ascending'

```

In the below sample, we have sorted fruits in `Ascending` order. To sort it in descending, click on sort order icon and vice versa.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/listview/data/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="List.cs" %}
{% include code-snippet/listview/data/list.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/listview/data/razor %}
{% endhighlight %}
{% highlight c# tabtitle="List.cs" %}
{% include code-snippet/listview/data/list.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


