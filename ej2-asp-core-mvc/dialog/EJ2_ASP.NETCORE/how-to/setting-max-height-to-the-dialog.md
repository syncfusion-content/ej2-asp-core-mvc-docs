---
layout: post
title: Set max height of Dialog in ##Platform_Name##| Syncfusion
description: Set the maxHeight of the Syncfusion ##Platform_Name## Dialog in the beforeOpen event so the popup respects a custom maximum height.
platform: ej2-asp-core-mvc
control: Dialog
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to set the max height of the Dialog in ASP.NET CORE Dialog

By default, the `maxHeight` for the Dialog is calculated based on the target. If the target is not specified externally, the Dialog considers the body as the target and will calculate the `maxHeight` based on it. You can also set the `maxHeight` of the Dialog in the [`beforeOpen`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_BeforeOpen) event.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dialog/how-to/max-height/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/dialog/how-to/max-height/controller.cs %}
{% endhighlight %}
{% endtabs %}
