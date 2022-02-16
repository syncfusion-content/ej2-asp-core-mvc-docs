---
layout: post
title: Underline A Character In A Text in ##Platform_Name## Split Button Component
description: Learn here all about Underline A Character In A Text in Syncfusion ##Platform_Name## Split Button component and more.
platform: ej2-asp-core-mvc
control: Underline A Character In A Text
publishingplatform: ##Platform_Name##
documentation: ug
---


# Underline a character in a text

To underline a particular character in a text, it can be handled in [`beforeItemRender`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.SplitButton.html#Syncfusion_EJ2_SplitButtons_SplitButton_BeforeItemRender) event by
adding `<u>` tag in between the text and given as innerHTML in `li` rendering.

In the following example, `C` is underlined in the text `Copy`:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/split-button/underline/demo/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Underline.cs" %}
{% include code-snippet/split-button/underline/demo/underline.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/split-button/underline/demo/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Underline.cs" %}
{% include code-snippet/split-button/underline/demo/underline.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

