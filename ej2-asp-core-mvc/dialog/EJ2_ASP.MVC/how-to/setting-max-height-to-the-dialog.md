---
layout: post
title: How to set max height of the Dialog in ##Platform_Name## | Syncfusion
description: Set the maxHeight of the Syncfusion ASP.NET MVC Dialog in the beforeOpen event so the popup respects a custom maximum height.
platform: ej2-asp-core-mvc
control: Dialog
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to set max height of the Dialog in ##Platform_Name##

By default, the `maxHeight` for the Dialog is calculated based on the target element. If the target is not specified externally, the Dialog considers the body as the target and will calculate the `maxHeight` based on it. You can set a custom `maxHeight` for the Dialog in the [`BeforeOpen`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_BeforeOpen) event.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dialog/how-to/max-height/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/dialog/how-to/max-height/controller.cs %}
{% endhighlight %}
{% endtabs %}
