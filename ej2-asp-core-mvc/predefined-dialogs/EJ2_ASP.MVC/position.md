---
layout: post
title: Positioning in ASP.NET MVC Predefined Dialogs | Syncfusion
description: Checkout and learn about Positioning in ASP.NET MVC Predefined Dialogs of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Positioning
publishingplatform: ejmvc
documentation: ug
---

# Positioning in Predefined Dialogs in Blazor

Customize the dialog position by using the `position` property. The position can be represented with specific `X` and `Y` values.

* The `Position.X` can be configured with a left, center, right or offset value. By default, the value is set as `center`.
* The `Position.Y` can be configured with a top, center, bottom or offset value. By default, the value is set as `center`.

Use the following code snippet for **alert.cshtml**, **confirm.cshtml** and **prompt.cshtml** to customize the position. Here, customized the dialog position as X= "top" and Y= "center".

**Alert**

{% tabs %}
{% highlight razor tabtitle="Alert.cshtml" %}
{% include code-snippet/predefined-dialogs/position/alert/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/predefined-dialogs/position/alert/controller.cs %}
{% endhighlight %}
{% endtabs %}

**Confirm**

{% tabs %}
{% highlight razor tabtitle="Confirm.cshtml" %}
{% include code-snippet/predefined-dialogs/position/confirm/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/predefined-dialogs/position/confirm/controller.cs %}
{% endhighlight %}
{% endtabs %}

**Prompt**

{% tabs %}
{% highlight razor tabtitle="Prompt.cshtml" %}
{% include code-snippet/predefined-dialogs/position/prompt/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/predefined-dialogs/position/prompt/controller.cs %}
{% endhighlight %}
{% endtabs %}

**Results from the code snippet**

**Alert**

![ASP.NET MVC Predefinded Dialogs alert position](./images/alert-position.png)

**Confirm**

![ASP.NET MVC Predefinded Dialogs confirm position](./images/confirm-position.png)

**Prompt**

![ASP.NET MVC Predefinded Dialogs prompt position](./images/prompt-position.png)