---
layout: post
title: Customize The Textbox Background Color And Text Color in ##Platform_Name## Textbox Component
description: Learn here all about Customize The Textbox Background Color And Text Color in Syncfusion ##Platform_Name## Textbox component and more.
platform: ej2-asp-core-mvc
control: Customize The Textbox Background Color And Text Color
publishingplatform: ##Platform_Name##
documentation: ug
---


# Customize the textbox background-color and text-color

You can customize the textbox styles such as background-color, text-color and border-color by overriding its default styles.

> To change the styles of the `floating label`, you must override the style to the input element.

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

