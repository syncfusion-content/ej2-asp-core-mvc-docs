---
layout: post
title: How to underline a character in item text in ##Platform_Name## DropDownButton | Syncfusion
description: Underline a specific character in the Syncfusion ##Platform_Name## DropDownButton item text by adding a u tag in the beforeItemRender event innerHTML.
platform: ej2-asp-core-mvc
control: Underline A Character In The Item Text
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to underline a character in item text in ##Platform_Name## DropDownButton

Underline a particular character in a text can be handled in [`beforeItemRender`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.DropDownButton.html#Syncfusion_EJ2_SplitButtons_DropDownButton_BeforeItemRender) event by adding `<u>` tag in between the text and given as innerHTML in `li` rendering.

In the following example, `C` is underlined in the text `Copy`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdownbutton/underline/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Underline.cs" %}
{% include code-snippet/dropdownbutton/underline/underline.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdownbutton/underline/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Underline.cs" %}
{% include code-snippet/dropdownbutton/underline/underline.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

