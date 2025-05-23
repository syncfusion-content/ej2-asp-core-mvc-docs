---
layout: post
title: Template with ##Platform_Name## Message Control | Syncfusion
description: Checkout and learn about template with ##Platform_Name## Message control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Message
publishingplatform: ##Platform_Name##
documentation: ug
---

# Template in Message control

The message supports templates that allow you to customize the content with a custom structure. The content can be a string, paragraph, or any other HTML element. The template can be rendered through the `content` property or added directly to the `<e-content-template>` tag.

In the following sample, the Message control content is customized with HTML elements and Syncfusion<sup style="font-size:70%">&reg;</sup> Button controls, which are directly added to the [content](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Notifications.Message.html#Syncfusion_EJ2_Notifications_Message_Content) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/message/template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/message/template/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/message/template/razor %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Message Control Template](images/message-template.png)