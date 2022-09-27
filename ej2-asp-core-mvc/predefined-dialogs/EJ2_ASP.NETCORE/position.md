---
layout: post
title: Positioning in ##Platform_Name## Predefined Dialogs Control
description: Checkout and learn about Positioning in ##Platform_Name## Predefined Dialogs of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Positioning
publishingplatform: ##Platform_Name##
documentation: ug
---

# Positioning in Predefined Dialogs in Blazor

Customize the dialog position by using the `position` property. The position can be represented with specific `X` and `Y` values.

* The `Position.X` can be configured with a left, center, right, or offset value. By default, the value is set as `center`.
* The `Position.Y` can be configured with a top, center, bottom, or offset value. By default, the value is set as `center`.

Use the following code snippet for **alert.cshtml**, **confirm.cshtml** and **prompt.cshtml** to customize the position. Here, customized the dialog position as X= "top" and Y= "center".

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}

{% highlight cshtml tabtitle="Alert.cshtml" %}
{% include_relative code-snippet/predefined-dialogs/position/alert/tagHelper %}
{% endhighlight %}

{% highlight cshtml tabtitle="Confirm.cshtml" %}
{% include_relative code-snippet/predefined-dialogs/position/confirm/tagHelper %}
{% endhighlight %}

{% highlight cshtml tabtitle="Prompt.cshtml" %}
{% include_relative code-snippet/predefined-dialogs/position/prompt/tagHelper %}
{% endhighlight %}

{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

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
{% endif %}
**Results from the code snippet**

**Alert**

![Alert position Dialog](../images/alert-position.png)

**Confirm**

![Confirm position Dialog](../images/confirm-position.png)

**Prompt**

![Prompt position Dialog](../images/prompt-position.png)