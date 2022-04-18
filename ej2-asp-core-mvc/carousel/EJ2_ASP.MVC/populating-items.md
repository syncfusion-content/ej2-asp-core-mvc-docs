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
* Populating Items using data source

## Populating items using carousel item

When rendering the Carousel component using items binding, you can assign templates for each item separately or assign a common template to each item. You can also customize the slide transition interval for each item separately. The following example code depicts the functionality as item property binding.

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

## Populating Items using data source

When rendering the Carousel component using data binding, you can assign a common template only for all items using the `ItemTemplate` property. You cannot set the interval for each item. The following example code depicts the functionality as data binding.

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

The Carousel items will be populated from the first index of the Carousel items and can be customized using the following ways,

* Select an item using the property.
* Select an item using the method.

### Select an item using the property

Using the `SelectedIndex` property of the Carousel component, you can set the slide to be populated at the time of initial rendering else you can switch to the particular slide item.

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

Using the `prev` or `next` public method of the Carousel component, you can switch the current populating slide to a previous or next slide.

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
