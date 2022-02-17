---
layout: post
title: Prevent Closing Of Modal Dialog in ##Platform_Name## Dialog Component
description: Learn here all about Prevent Closing Of Modal Dialog in Syncfusion ##Platform_Name## Dialog component and more.
platform: ej2-asp-core-mvc
control: Prevent Closing Of Modal Dialog
publishingplatform: ##Platform_Name##
documentation: ug
---


# Prevent closing of modal Dialog

You can prevent closing of modal dialog by setting the [`beforeClose`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_BeforeClose) event argument cancel value to true.
In the following sample, the dialog is closed when you enter the username value with minimum 4 characters. Otherwise, it will not be closed.

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

