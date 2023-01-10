---
layout: post
title: Card Image in ##Platform_Name## Card Control | Syncfusion
description: Learn here all about Card Image in Syncfusion ##Platform_Name## Card control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Card Image
publishingplatform: ##Platform_Name##
documentation: ug
---


# Images and Divider in Card Control

## Images

The Card supports to include images within the elements, you can add image as direct element anywhere inside card root by adding the `e-card-image` class to `div` element. Using the class defined, you can write CSS styles to load images to that element.

> By default, card images occupies full width of its parent element.

```html
    <div class = "e-card">
        <div class="e-card-image">
        </div>
    </div>
```

### Title

Card image is supported to include a title or caption for the image. By default, Title is placed over the image on left-bottom position with overlay.

```html
    <div class = "e-card">
        <div class="e-card-image">
            <div class="e-card-title"></div>
        </div>
    </div>
```

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/card/card-img/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/card/card-img/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/card/card-img/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


![CSS Card Control with images and divider](./images/card-image.PNG)

## Divider

Divider used to separate the elements inside the card. You can add divider inside the card elements to separate it.

* Place the `div` element with `e-card-separator` class inside the card element for adding a divider.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/card/card-sep/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/card/card-sep/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/card/card-sep/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


![CSS Card Control with images and divider](./images/card-divider.PNG)

> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-UG-Examples/tree/main/Card/CardUGSample).

## See also

* [How to customize the card image title position](./how-to/customize-the-card-image-title-position)