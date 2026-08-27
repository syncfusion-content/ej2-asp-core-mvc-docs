---
layout: post
title: Prevent closing of modal dialog | Syncfusion
description: Prevent closing of the modal Syncfusion ##Platform_Name## Dialog by setting the BeforeClose event argument cancel value to true, e.g. for validation.
platform: ej2-asp-core-mvc
control: Prevent Closing Of Modal Dialog
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to prevent closing of a modal Dialog in ASP.NET MVC

You can prevent closing of modal dialog by setting the [`BeforeClose`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_BeforeClose) event argument cancel value to true. In the following sample, the Dialog closes when you enter a username with a minimum of 4 characters. Otherwise, it will not be closed.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dialog/how-to/validation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/dialog/how-to/validation/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dialog/how-to/validation/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/dialog/how-to/validation/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

