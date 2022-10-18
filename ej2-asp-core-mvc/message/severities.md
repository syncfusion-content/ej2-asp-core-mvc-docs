---
layout: post
title: Severities with ##Platform_Name## Message Control | Syncfusion
description: Checkout and learn about severities with ##Platform_Name## Message control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Message
publishingplatform: ##Platform_Name##
documentation: ug
---

# Severities

This section explains the message with different severity types. The user can displays messages with different severity levels to denote the importance and context of the message based on the `severity` property.

The available severity types are **Normal**, **Success**, **Info**, **Warning** and **Error**. The default severity type for message is **Normal**.

The following example demonstrates the messages with different severity types.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/message/severity-icon/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/message/severity-icon/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/message/severity-icon/razor %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Message Control Severity Icon](images/message-severity-icon.png)

By default, severity icons can be displayed according to the severity type to make the user more understandable by visual information better than text. If the user does not wants to show the severity icons, it can be removed by setting `false` to `showIcon` property.

The following example demonstrates the different severity messages without the severity icons.

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

![Message Control Severity](images/message-severity.png)