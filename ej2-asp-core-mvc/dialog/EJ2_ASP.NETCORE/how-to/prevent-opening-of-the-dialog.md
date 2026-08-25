---
layout: post
title: Prevent Dialog opening in ##Platform_Name##| Syncfusion
description: Prevent the Syncfusion ##Platform_Name## Dialog from opening by setting the BeforeOpen event argument cancel value to true, e.g. for form validation.
platform: ej2-asp-core-mvc
control: Prevent Opening Of The Dialog
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to prevent opening of the Dialog in ##Platform_Name## Dialog

You can prevent opening of the Dialog by setting the `cancel` argument of the [`beforeOpen`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_BeforeOpen) event to `true`. In the following sample, the Dialog opens only when you enter a username with a minimum of 4 characters and a non-empty password. Otherwise, it will not be opened.

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

