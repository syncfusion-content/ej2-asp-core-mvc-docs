---
layout: post
title: Icons with ##Platform_Name## Message Control | Syncfusion
description: Checkout and learn about icons with ##Platform_Name## Message control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Message
publishingplatform: ##Platform_Name##
documentation: ug
---

# Icons

The Message has an option to customize the appearance with icons. This section explains about the custom and close icon of the message.

## Close icon

The Message can be rendered with and without the close icon. The close icon is used to hide the message. If the user want to hide the messages after reading it, it can be achieved through these close icon.

To show the close icon in the message, set the `showCloseIcon` property to `true` to make it visible.

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

By default, the severity icons can be displayed according to the severity type to make the user more understandable by visual information better than text. If the user wants to customize these icons, then it can be achieved through `cssClass` property.

The following example demonstrates the default message is rendered with a custom severity icon and custom appearance.

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
