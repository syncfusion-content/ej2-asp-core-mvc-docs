---
layout: post
title: Customize Radiobutton Appearance in ##Platform_Name## Radio Button Component
description: Learn here all about Customize Radiobutton Appearance in Syncfusion ##Platform_Name## Radio Button component and more.
platform: ej2-asp-core-mvc
control: Customize Radiobutton Appearance
publishingplatform: ##Platform_Name##
documentation: ug
---


# Customize RadioButton Appearance

You can customize the appearance of the RadioButton component by using the CSS rules.
Define own CSS rules according to your requirement and assign the class name to the [`cssClass`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.RadioButton.html#Syncfusion_EJ2_Buttons_RadioButton_CssClass) property.

The background and border color of the RadioButton is customized through the custom classes to create the primary, success, info, warning, and danger type of RadioButton.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/radio-button/howto/custom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom.cs" %}
{% include code-snippet/radio-button/howto/custom/custom.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/radio-button/howto/custom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom.cs" %}
{% include code-snippet/radio-button/howto/custom/custom.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

