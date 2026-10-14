---
layout: post
title: Draw a Signature in ##Platform_Name## Signature | Syncfusion
description: Learn how to draw text-based signatures in the Syncfusion ##Platform_Name## Signature component using different font families and font sizes.
platform: ej2-asp-core-mvc
control: Draw a Signature
publishingplatform: ##Platform_Name##
documentation: ug
---

# Draw a Signature in ##Platform_Name## Signature

## Draw

The `draw` method is used to drawn a text as signature with different font families like Arial, Serif, with different font sizes. It accepts text, font family, font size as its parameters. The default font family is “Arial”, and the default font size is “30”.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/signature/draw/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/signature/draw/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/signature/draw/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/signature/draw/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Output be like the below.

![Signature Sample](./images/draw.PNG)