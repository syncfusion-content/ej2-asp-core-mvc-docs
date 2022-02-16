---
layout: post
title: Customize Progress Bar Theme And Sizing in ##Platform_Name## Toast Component
description: Learn here all about Customize Progress Bar Theme And Sizing in Syncfusion ##Platform_Name## Toast component and more.
platform: ej2-asp-core-mvc
control: Customize Progress Bar Theme And Sizing
publishingplatform: ##Platform_Name##
documentation: ug
---


# Customize progress bar theme and sizing

By default, the progress bar appears based on the theme stylings and dimensions. You can customize the progress bar stylings using custom CSS or event functions.

The following sample demonstrates customizing the progress bar stylings using the [`BeforeOpen`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Notifications.Toast.html#Syncfusion_EJ2_Notifications_Toast_BeforeOpen) event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/toast/sizing/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/toast/sizing/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/toast/sizing/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/toast/sizing/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


