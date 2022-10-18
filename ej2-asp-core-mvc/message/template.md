---
layout: post
title: Template with ##Platform_Name## Message Control | Syncfusion
description: Checkout and learn about template with ##Platform_Name## Message control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Message
publishingplatform: ##Platform_Name##
documentation: ug
---

# Template

The Message supports templates that makes you to customize the content with a custom structure. The content can be a string, paragraph, or any other HTML element.

In the below sample, the Message component content is customized with HTML elements and Syncfusion Buttons.

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