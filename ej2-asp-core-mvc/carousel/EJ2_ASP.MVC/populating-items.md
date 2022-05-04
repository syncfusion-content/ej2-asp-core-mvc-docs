---
layout: post
title: Populating items in ##Platform_Name## Carousel Control
description: Checkout and learn about populating items in ##Platform_Name## Carousel control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Populating Items
publishingplatform: ##Platform_Name##
documentation: ug
---

# Populating Items

In the Carousel, slides can be rendered in two ways as follows,

* Populating items using carousel item
* Populating items using data source

## Populating items using carousel item

When rendering the Carousel component using items binding, you can assign templates for each item separately or assign a common template to each item. You can also customize the slide transition interval for each item separately. The following example code depicts the functionality as item property binding.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/carousel/populating-items/carousel-item/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/carousel/populating-items/carousel-item/carousel-item.cs %}
{% endhighlight %}
{% endtabs %}

## Populating items using data source

When rendering the Carousel component using data binding, you can assign a common template only for all items using the [ItemTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Carousel.html#Syncfusion_EJ2_Navigations_Carousel_ItemTemplate) property. You cannot set the interval for each item. The following example code depicts the functionality as data binding.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/carousel/populating-items/item-datasource/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/carousel/populating-items/item-datasource/item-datasource.cs %}
{% endhighlight %}
{% endtabs %}

## Selection

The Carousel items will be populated from the first index of the Carousel items and can be customized using the following ways,

* Select an item using the property.
* Select an item using the method.

### Select an item using the property

Using the [SelectedIndex](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Carousel.html#Syncfusion_EJ2_Navigations_Carousel_SelectedIndex) property of the Carousel component, you can set the slide to be populated at the time of initial rendering else you can switch to the particular slide item.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/carousel/populating-items/select-item/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/carousel/populating-items/select-item/select-item.cs %}
{% endhighlight %}
{% endtabs %}

### Select an item using the method

Using the `prev` or `next` public method of the Carousel component, you can switch the current populating slide to a previous or next slide.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/carousel/populating-items/select-item-method/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/carousel/populating-items/select-item-method/select-item-method.cs %}
{% endhighlight %}
{% endtabs %}
