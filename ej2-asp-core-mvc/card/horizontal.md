---
layout: post
title: Horizontal in ##Platform_Name## Card Component
description: Learn here all about Horizontal in Syncfusion ##Platform_Name## Card component and more.
platform: ej2-asp-core-mvc
control: Horizontal
publishingplatform: ##Platform_Name##
documentation: ug
---


# Horizontal Card

By default, all the card elements are aligned vertically one after the other as in the DOM. You can achieve the element to align horizontally as well by adding the class `e-card-horizontal` in the root card element.

## Stacked cards

* An horizontally aligned card can push a specific column to align vertical using `e-card-stacked` class. This will align the stacked section vertically aligned differentiating from horizontal layout.

Class   | Description
------------ | -------------
`e-card-horizontal` | To align card elements horizontally.
`e-card-stacked` | To align elements vertically within the horizontal layout.

```html
        <div tabindex="0" class="e-card e-card-horizontal">
            <img src="code1.png" alt="Sample">   --> Aligned in horizontal
            <div class="e-card-stacked">         --> Aligned in horizontal
               // Inside the element all are aligned vertical directions
            </div>
        </div>
```

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/card/card-horizontal/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/card/card-horizontal/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/card/card-horizontal/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/card/card-horizontal/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![CSS Card Control with horizontal structure](./images/card-horizontal.PNG)