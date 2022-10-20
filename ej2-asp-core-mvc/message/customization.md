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

The Message control allows you to customize the content display positions and its appearance. This section explains the details about changing the content alignments and border styles for messages.

## Content alignment

Normally, the message content is aligned to the **left**. The Message control allows to align the message content in **center** or **right** through the built-in classes `e-content-center` and `e-content-right`.

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

To customize the Message control's appearance, add the custom class to the message through `cssClass` property. This custom class will be added to the root element. Based on this custom class, the user can override the styles of the message at the application level.

The following example shows the rounded and squared appearance of the message, which can be achieved through adding the `cssClass` property.

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

The Essential JS 2 Message has the following predefined classes that can be defined in the HTML elements, which renders the message without any script reference.

| Class | Description |
| -------- | -------- |
| e-message | Represents the message wrapper. |
| e-msg-icon | Represents the severity type icon. |
| e-msg-content | Represents the message content. |
| e-msg-close-icon | Represents the close icon. |
| e-info | Represents the information message. |
| e-success | Represents the success message. |
| e-warning | Represents the warning message. |
| e-error | Represents the error message. |
| e-content-center | Aligns the message content to the center. |
| e-content-right | Aligns the message content to the right. |

The following example shows the message which renders without any script reference.

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