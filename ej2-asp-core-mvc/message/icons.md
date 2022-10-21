---
layout: post
title: Icons with ##Platform_Name## Message Control | Syncfusion
description: Checkout and learn about icons with ##Platform_Name## Message control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Message
publishingplatform: ##Platform_Name##
documentation: ug
---

# Icons in Message control

This section explains how to show or hide the close icon and add the custom severity icon to the message.

## Close icon

The message can be rendered with or without the close icon. The close icon is used to hide the message, either by manually clicking the close icon or through keyboard interaction.

By default, the close icon is not rendered in the message. To show the close icon, set the `showCloseIcon` property to `true`.

In the following example, the messages are rendered with the close icon.

The following example demonstrates the message with close icon.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/message/close-icon/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/message/close-icon/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/message/close-icon/razor %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![ASP.NET MVC Message Control Close Icon](images/message-close-icon.png)

## Custom icon

By default, the severity icons can be displayed according to the severity type to make the user more understandable by visual information rather than text. If the user wants to customize these icons, then it can be achieved through `cssClass` property.

The following example demonstrates how the default message is rendered with a custom severity icon and custom appearance.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/message/custom-icon/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/message/custom-icon/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/message/custom-icon/razor %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Message Control Custom Icon](images/message-custom-icon.png)
