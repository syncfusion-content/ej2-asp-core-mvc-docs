---
layout: post
title: Customize TextBox Background and Text Colors - ##Platform_Name## | Syncfusion
description: Customize the Syncfusion ##Platform_Name## TextBox background color, text color, and border color by overriding the default CSS styles.
platform: ej2-asp-core-mvc
control: Customize The Textbox Background Color And Text Color
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to customize background and text colors in ##Platform_Name## TextBox

You can customize the textbox styles such as background-color, text-color and border-color by overriding its default styles.

N> To change the styles of the `floating label`, you must override the style to the input element.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/textbox/how-to/textbox-customize/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Textbox-customize.cs" %}
{% include code-snippet/textbox/how-to/textbox-customize/textbox-customize.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/textbox/how-to/textbox-customize/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Textbox-customize.cs" %}
{% include code-snippet/textbox/how-to/textbox-customize/textbox-customize.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

