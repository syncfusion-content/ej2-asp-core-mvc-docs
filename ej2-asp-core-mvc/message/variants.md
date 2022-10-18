---
layout: post
title: Variants with ##Platform_Name## Message Control | Syncfusion
description: Checkout and learn about variants with ##Platform_Name## Message control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Message
publishingplatform: ##Platform_Name##
documentation: ug
---

# Variants

The Message has predefined appearance variants for different visual representations. It can be displayed with different appearances based on the `variant` property.

The available variants are **Text**, **Outlined** and **Filled**. The default variant type for message is **Text**.
* **Text** - The severity is differentiated using a text color and a light background color.
* **Outlined** - The severity is differentiated using a text color and a border without background.
* **Filled** - The severity is differentiated using a text color and a dark background color.

The following example demonstrates the default message with different variant types.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/message/variants/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/message/variants/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/message/variants/razor %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Message Control Variants](images/message-variants.png)