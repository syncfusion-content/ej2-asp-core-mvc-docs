---
layout: post
title: Positioning in ASP.NET Core Predefined Dialogs | Syncfusion
description: Checkout and learn about Positioning in ASP.NET Core Predefined Dialogs of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Positioning
publishingplatform: ASP.NET Core
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

![ASP.NET Core Predefined Dialogs alert position Dialog](./images/alert-position.png)

**Confirm**

![ASP.NET Core Predefined Dialogs confirm position Dialog](./images/confirm-position.png)

**Prompt**

![ASP.NET Core Predefined Dialogs prompt position Dialog](./images/prompt-position.png)