---
layout: post
title: Customize Button Appearance in ##Platform_Name## Button Component
description: Learn here all about Customize Button Appearance in Syncfusion ##Platform_Name## Button component and more.
platform: ej2-asp-core-mvc
control: Customize Button Appearance
publishingplatform: ##Platform_Name##
documentation: ug
---


# Customize Button Appearance

You can customize the appearance of the Button by using the Cascading Style Sheets (CSS). Define the CSS according to
your requirement, and assign the class name to the [`cssClass`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.Button.html#Syncfusion_EJ2_Buttons_Button_CssClass)
property. In the following code snippet the background color, text color, height, width, and sharp corner of the Button
can be customized through the `e-custom` class for all states (hover, focus, and active).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/button/howto/custom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custombutton.cs" %}
{% include code-snippet/button/howto/custom/custombutton.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/button/howto/custom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custombutton.cs" %}
{% include code-snippet/button/howto/custom/custombutton.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

