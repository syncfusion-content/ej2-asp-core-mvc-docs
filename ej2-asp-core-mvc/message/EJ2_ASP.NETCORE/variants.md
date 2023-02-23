---
layout: post
title: Variants with ##Platform_Name## Message Control | Syncfusion
description: Checkout and learn about variants with ##Platform_Name## Message control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Message
publishingplatform: ##Platform_Name##
documentation: ug
---

# Variants in Message control

The Message has predefined appearance variants for different visual representations. The variants of the message can be changed based on the [`variant`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Notifications.Message.html#Syncfusion_EJ2_Notifications_Message_Variant) property.

The available variants are **Text**, **Outlined** and **Filled**. The default variant type for messages is **Text**.
* **Text** - The severity is differentiated using a text color and a light background color.
* **Outlined** - The severity is differentiated using a text color and a border without a background.
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

![Message Filled Variant](images/variants-filled.png)

![Message Outlined Variant](images/variants-outlined.png)

![Message Text Variant](images/variants-text.png)