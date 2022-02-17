---
layout: post
title: Customize The Ui Appearance Of The Control in ##Platform_Name## Numerictextbox Component
description: Learn here all about Customize The Ui Appearance Of The Control in Syncfusion ##Platform_Name## Numerictextbox component and more.
platform: ej2-asp-core-mvc
control: Customize The Ui Appearance Of The Control
publishingplatform: ##Platform_Name##
documentation: ug
---

# Customize the UI appearance of the control

You can change the appearance of the NumericTextBox by adding custom `cssClass` to the control and enabling styles. Refer to the following example to change the appearance of the NumericTextBox.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/numeric-textbox/how-to/customCss/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CustomCss.cs" %}
{% include code-snippet/numeric-textbox/how-to/customCss/customCss.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/numeric-textbox/how-to/customCss/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CustomCss.cs" %}
{% include code-snippet/numeric-textbox/how-to/customCss/customCss.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![NumericTextBox Sample](../images/appearance.png)