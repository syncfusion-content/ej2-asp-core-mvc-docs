---
layout: post
title: Customize UI in ##Platform_Name## Numeric TextBox | Syncfusion
description: Learn how to customize the UI appearance of ##Platform_Name## Numeric TextBox using custom CSS classes and styling options.
platform: ej2-asp-core-mvc
control: Customize The Ui Appearance Of The Control
publishingplatform: ##Platform_Name##
documentation: ug
---

# Customize the UI Appearance of ##Platform_Name## NumericTextBox

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