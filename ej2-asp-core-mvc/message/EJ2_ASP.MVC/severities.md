---
layout: post
title: Severities in ##Platform_Name## Message | Syncfusion
description: Render Syncfusion ##Platform_Name## Message by severity levels (None, Success, Info, Warning, Error) using the severity property for color-coded contexts.
platform: ej2-asp-core-mvc
control: Message
publishingplatform: ##Platform_Name##
documentation: ug
---

# Severities in ##Platform_Name## Message

The severity denotes the importance and context of the message to the user. The message contains different severity types. Use the [Severity](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Notifications.Message.html#Syncfusion_EJ2_Notifications_Message_Severity) property to display the messages with different severity levels.

The available severity types are **Normal**, **Success**, **Info**, **Warning** and **Error**. The default severity type for messages is **Normal**.

The following example demonstrates the severity of the messages.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/message/severity/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/message/severity/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/message/severity/razor %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Message Control Severity Icon](images/message-severity-icon.png)
