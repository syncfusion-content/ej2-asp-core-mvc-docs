---
layout: post
title: Action Buttons in ##Platform_Name## Card Component
description: Learn here all about Action Buttons in Syncfusion ##Platform_Name## Card component and more.
platform: ej2-asp-core-mvc
control: Action Buttons
publishingplatform: ##Platform_Name##
documentation: ug
---


# Action Buttons

You can include Action buttons within the Card and customize them. Action button is a `div` element with `e-card-actions` class followed by button tag or anchor tag within the card root element.

* For adding action buttons you can create button or anchor tag with `e-card-btn` class within the card action element.

```html
    <div class = "e-card">
        <div class="e-card-actions">
            <button class="e-card-btn"></button>
            <a href="#"></a>
        </div>
    </div>
```

## Vertical

By default, action buttons positioned in horizontal alignment , and also it can be aligned to show in vertical alignment by adding `e-card-vertical` class.

```html
    <div class = "e-card">
        <div class="e-card-actions e-card-vertical">
            <button class="e-card-btn">More</button>
            <a href="#">Share</a>
        </div>
    </div>
```

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/card/card-action-btn/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/card/card-action-btn/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/card/card-action-btn/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/card/card-action-btn/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![CSS Card Control with action buttons](./images/card-action.PNG)

## See Also

* [How to integrate other component inside the card](./how-to/integrate-other-component-inside-the-card)