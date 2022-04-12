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

    1. Populating items using Carousel Item
    2. Populating Items using Data Source

## Populating items using Carousel Item

Using Items binding rendering, we can assign templates for each item separately or assign a common template to each item. We can also customize the slide transition interval for each item separately. The following example code depicts the functionality as item property binding.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/carousel/populating-items/carousel-item/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/carousel/populating-items/carousel-item/carousel-item.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/carousel/populating-items/carousel-item/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/carousel/populating-items/carousel-item/carousel-item.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Populating Items using Data Source

Using Data binding rendering, we can assign a common template only for all items using the `itemTemplate` property. We cannot set the interval for each item. The following example code depicts the functionality as data binding.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/carousel/populating-items/item-datasource/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/carousel/populating-items/item-datasource/item-datasource.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/carousel/populating-items/item-datasource/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/carousel/populating-items/item-datasource/item-datasource.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Selection

The Carousel items will be populated from the first index of the Carousel items and can be able customized using the following ways,

    1. Select an item using the property.
    2. Select an item using the method.

### Select an item using the property

Using the `selectedIndex` property of the Carousel component. We can able to set the slide to be populated at the time of initial rendering else we can be able to switch to the particular slide item.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/carousel/populating-items/select-item/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/carousel/populating-items/select-item/select-item.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/carousel/populating-items/select-item/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/carousel/populating-items/select-item/select-item.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Select an item using the method

Using the `previous` or `next` public method of the Carousel component. We can able to switch the current populating slide as a previous or next slide.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/carousel/populating-items/select-item-method/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/carousel/populating-items/select-item-method/select-item-method.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/carousel/populating-items/select-item-method/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/carousel/populating-items/select-item-method/select-item-method.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}
