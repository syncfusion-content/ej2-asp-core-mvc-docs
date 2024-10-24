---
layout: post
title: Sizing in ##Platform_Name## Textbox Component
description: Learn here all about Sizing in Syncfusion ##Platform_Name## Textbox component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Sizing
publishingplatform: ##Platform_Name##
documentation: ug
---


# Sizing in ASP.NET Core TextBox component

You can render the TextBox in three different sizes.

Property   | Description
------------ | -------------
  Normal     | By default, the TextBox is rendered with normal size.
  Small      | You need to add `e-small` class to the [cssClass](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.TextBox.html#Syncfusion_EJ2_Inputs_TextBox_CssClass) property to render the TextBox in smaller size.
  Bigger     | You need to add `e-bigger` class to the [cssClass](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.TextBox.html#Syncfusion_EJ2_Inputs_TextBox_CssClass) property to render the TextBox in bigger size.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/textbox/sizing/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Sizing.cs" %}
{% include code-snippet/textbox/sizing/sizing.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/textbox/sizing/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Sizing.cs" %}
{% include code-snippet/textbox/sizing/sizing.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

