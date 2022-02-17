---
layout: post
title: Prevent Opening Of The Dialog in ##Platform_Name## Dialog Component
description: Learn here all about Prevent Opening Of The Dialog in Syncfusion ##Platform_Name## Dialog component and more.
platform: ej2-asp-core-mvc
control: Prevent Opening Of The Dialog
publishingplatform: ##Platform_Name##
documentation: ug
---


# Prevent opening of the Dialog

You can prevent opening of the dialog by setting the [`beforeOpen`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_BeforeOpen) event argument cancel value to true.
In the following sample, the success dialog is opened when you enter the username value with minimum 4 characters. Otherwise, it will not be opened.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dialog/how-to/dialog-check/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/dialog/how-to/dialog-check/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dialog/how-to/dialog-check/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/dialog/how-to/dialog-check/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

