---
layout: post
title: Customize The Ui Appearance Of The Control in ##Platform_Name## Maskedtextbox Component
description: Learn here all about Customize The Ui Appearance Of The Control in Syncfusion ##Platform_Name## Maskedtextbox component and more.
platform: ej2-asp-core-mvc
control: Customize The Ui Appearance Of The Control
publishingplatform: ##Platform_Name##
documentation: ug
---

# Customize the UI appearance of the control

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