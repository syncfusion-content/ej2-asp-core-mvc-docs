---
layout: post
title: Variants in ##Platform_Name## Message | Syncfusion
description: Choose Syncfusion ##Platform_Name## Message variants (Text, Outlined, Filled) using the variant property to control the message visual style.
platform: ej2-asp-core-mvc
control: Message
publishingplatform: ##Platform_Name##
documentation: ug
---

# Variants in ##Platform_Name## Message

The Message has predefined appearance variants for different visual representations. The variants of the message can be changed based on the [Variant](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Notifications.Message.html#Syncfusion_EJ2_Notifications_Message_Variant) property.

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