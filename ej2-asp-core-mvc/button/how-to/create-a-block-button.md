---
layout: post
title: Create A Block Button in ##Platform_Name## Button Control | Syncfusion
description: Learn here all about how to create a Block Button in Syncfusion ##Platform_Name## Button control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Create A Block Button
publishingplatform: ##Platform_Name##
documentation: ug
---


# Create a Block Button

You can customize a Button into a Block Button that will span the entire width of its parent element. To create a Block Button, set the [cssClass](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.Button.html#Syncfusion_EJ2_Buttons_Button_CssClass) property to `e-block`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/button/howto/block-button/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/button/howto/block-button/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Blockbutton.cs" %}
{% include code-snippet/button/howto/block-button/blockbutton.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-UG-Examples/tree/main/Button/ButtonHowToSample).