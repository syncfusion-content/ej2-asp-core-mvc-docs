---
layout: post
title: Populating items in Syncfusion ##Platform_Name## Carousel Control | Syncfusion
description: Checkout and learn about populating items in ##Platform_Name## Carousel control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Populating Items
publishingplatform: ##Platform_Name##
documentation: ug
---

# Populating Items in ##Platform_Name## Carousel control

In the Carousel, slides can be rendered in two ways as follows,

* Populating items using carousel item
* Populating items using data source

## Populating items using carousel item

When rendering the Carousel component using items binding, you can assign templates for each item separately or assign a common template to each item. You can also customize the slide transition interval for each item separately. The following example code depicts the functionality as item property binding.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/carousel/populating-items/carousel-item/tagHelper %}
{% endhighlight %}
{% endtabs %}

## Populating items using data source

When rendering the Carousel component using data binding, you can assign a common template only for all items using the [itemTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Carousel.html#Syncfusion_EJ2_Navigations_Carousel_ItemTemplate) property. You cannot set the interval for each item. The following example code depicts the functionality as data binding.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/carousel/populating-items/item-datasource/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
public class CarouselDataBinding
{
    public int Id { get; set; }
    public string Title { get; set; }
}
{% endhighlight %}
{% endtabs %}

## Selection

The Carousel items will be populated from the first index of the Carousel items and can be customized using the following ways,

* Select an item using the property.
* Select an item using the method.

### Select an item using the property

Using the [selectedIndex](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Carousel.html#Syncfusion_EJ2_Navigations_Carousel_SelectedIndex) property of the Carousel component, you can set the slide to be populated at the time of initial rendering else you can switch to the particular slide item.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/carousel/populating-items/select-item/tagHelper %}
{% endhighlight %}
{% endtabs %}

![Carousel selected slide](images/selected_index.png)

### Select an item using the method

Using the `prev` or `next` public method of the Carousel component, you can switch the current populating slide to a previous or next slide.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/carousel/populating-items/select-item-method/tagHelper %}
{% endhighlight %}
{% endtabs %}

## Partial visible slides

The Carousel component supports to show one complete slide and a partial view of adjacent (previous and next) slides at the same time. You can enable or disable the partial slides using the [`partialVisible`](../api/carousel/#partialVisible) property.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/carousel/populating-items/partial-visible/tagHelper %}
{% endhighlight %}
{% endtabs %}

![Carousel](./images/partial-visible.jpg)

N> Slide animation only applicable if the `partialVisible` is enabled.

The last slide will be displayed as a partial slide at the initial rendering when the [`loop`](../api/carousel/#loop) and `partialVisible` properties are enabled.

The previous slide is not displayed at the initial rendering when the `loop` is disabled.

The following example code depicts the functionality of `partialVisible` and without `loop` functionalities.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/carousel/populating-items/partial-visible/without-loop/tagHelper %}
{% endhighlight %}
{% endtabs %}

![Carousel](./images/without-loop.jpg)

## See also

* [Customizing partial slides size](./styles-and-appearance/#customizing-partial-slides-size)

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-UG-Examples/tree/main/Carousel/CarouselUGSample).