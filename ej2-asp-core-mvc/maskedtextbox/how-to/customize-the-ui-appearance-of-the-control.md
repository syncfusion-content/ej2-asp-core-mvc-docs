---
layout: post
title: How to customize UI appearance of ##Platform_Name## MaskedTextBox | Syncfusion
description: Customize Syncfusion ##Platform_Name## MaskedTextBox appearance using the cssClass property for wrapper, focus ring, success, warning, and error CSS class variants.
platform: ej2-asp-core-mvc
control: Customize The Ui Appearance Of The Control
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to customize UI appearance in ##Platform_Name## MaskedTextBox

The appearance of the MaskedTextBox can be changed by adding custom `cssClass` to the control and enabling styles.
Refer to the following example to change the appearance of the MaskedTextBox.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maskedtextbox/customcss/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CustomCss.cs" %}
{% include code-snippet/maskedtextbox/customcss/customCss.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maskedtextbox/customcss/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CustomCss.cs" %}
{% include code-snippet/maskedtextbox/customcss/customCss.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![MaskedTextBox Sample](../images/customCss.png)