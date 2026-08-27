---
layout: post
title: Prevent closing of modal Dialog in ##Platform_Name## | Syncfusion
description: Prevent closing of the modal Syncfusion ##Platform_Name## Dialog by setting the cancel argument of the beforeClose event to true, e.g. for validation.
platform: ej2-asp-core-mvc
control: Prevent Closing of Modal Dialog
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to prevent closing of a modal Dialog in ASP.NET CORE Dialog

You can prevent closing of a modal dialog by setting the `cancel` argument of the [`beforeClose`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_BeforeClose) event to `true`. In the following sample, the Dialog is closed when you enter the username value with minimum 4 characters. Otherwise, it will not be closed.

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

