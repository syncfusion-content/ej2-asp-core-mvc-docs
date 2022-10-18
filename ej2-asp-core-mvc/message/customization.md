---
layout: post
title: Customization with ##Platform_Name## Message Control | Syncfusion
description: Checkout and learn about customization with ##Platform_Name## Message control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Message
publishingplatform: ##Platform_Name##
documentation: ug
---

# Customization

The Message can also be customized with its content positions and it appearance.

## Content alignment

The Message content has an different types of alignments such as **Left**, **Right** and **Center**. By default, the message content is aligned to the left. If the user wants to align the content in **Center** or **Right** for their readability, it can be achieved through the built-in classes `e-content-center` and `e-content-right`.

The following example demonstrates the message with different content alignments.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/message/content-alignment/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/message/content-alignment/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/message/content-alignment/razor %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![ASP.NET MVC Message Content Alignment](images/message-content-alignment.png)

## Rounded and Square

The following example show the rounded and squared appearance of the message which can be achieved through adding the `cssClass` and customizing the border styles.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/message/custom-apearance/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/message/custom-apearance/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/message/custom-aapearance/razor %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Message Custom Appearance](images/message-rounded-square.png)

## CSS Message

The Essential JS 2 Message has the following predefined classes that can be defined in the HTML elements which renders the message without any script reference.

| Class | Description |
| -------- | -------- |
| e-message | Used to represent the message styles. |
| e-msg-icon | Used to represent severity type and icon. |
| e-msg-content |  Used to represent the message content. |

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/message/css-message/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/message/css-message/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/message/css-message/razor %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Message Control](images/message-default.png)