---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Add Link To A Button of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Add Link To A Button
publishingplatform: ##Platform_Name##
documentation: ug
---


# Add link to a Button

The appearance of the Button can be changed like a hyperlink by `e-link` class using [`cssClass`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.Button.html#Syncfusion_EJ2_Buttons_Button_CssClass)
property and link navigation can be handled in Button click event.

In the following example, link is added in Button click event by using `window.open()` method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/button/howto/link/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Link.cs" %}
{% include code-snippet/button/howto/link/link.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/button/howto/link/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Link.cs" %}
{% include code-snippet/button/howto/link/link.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

