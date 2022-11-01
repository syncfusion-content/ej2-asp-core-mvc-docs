---
layout: post
title: Positioning in ##Platform_Name## Predefined Dialogs | Syncfusion
description: Checkout and learn about Positioning in ##Platform_Name## Predefined Dialogs of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Positioning
publishingplatform: ##Platform_Name##
documentation: ug
---

# Positioning in Predefined Dialogs in Blazor

Customize the dialog position by using the `position` property. The position can be represented with specific `X` and `Y` values.

* The `Position.X` can be configured with a left, center, right or offset value. By default, the value is set as `center`.
* The `Position.Y` can be configured with a top, center, bottom or offset value. By default, the value is set as `center`.

Use the following code snippet for **Alert.cshtml**, **Confirm.cshtml** and **Prompt.cshtml** to customize the position. Here, customized the dialog position as X= "top" and Y= "center".

{% tabs %}

{% highlight cshtml tabtitle="Alert.cshtml" %}
{% include code-snippet/predefined-dialogs/position/alert/tagHelper %}
{% endhighlight %}

{% highlight cshtml tabtitle="Confirm.cshtml" %}
{% include code-snippet/predefined-dialogs/position/confirm/tagHelper %}
{% endhighlight %}

{% highlight cshtml tabtitle="Prompt.cshtml" %}
{% include code-snippet/predefined-dialogs/position/prompt/tagHelper %}
{% endhighlight %}

{% endtabs %}

**Results from the code snippet**

**Alert**

![ASP.NET Core Predfined Dialogs Alert position Dialog](./images/asp-core-mvc-predefinded-dialogs-alert-position.png)

**Confirm**

![ASP.NET Core Predfined Dialogs Confirm position Dialog](./images/asp-core-mvc-predefinded-dialogs-confirm-position.png)

**Prompt**

![ASP.NET Core Predfined Dialogs Prompt position Dialog](./images/asp-core-mvc-predefinded-dialogs-prompt-position.png)