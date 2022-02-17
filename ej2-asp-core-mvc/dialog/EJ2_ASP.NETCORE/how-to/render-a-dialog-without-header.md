---
layout: post
title: Render A Dialog Without Header in ##Platform_Name## Dialog Component
description: Learn here all about Render A Dialog Without Header in Syncfusion ##Platform_Name## Dialog component and more.
platform: ej2-asp-core-mvc
control: Render A Dialog Without Header
publishingplatform: ##Platform_Name##
documentation: ug
---


# Render a Dialog without header

The dialog can be rendered without header by setting the [`header`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_Header) property value as empty string or null.  By default, dialog is rendered without header.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dialog/how-to/header/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/dialog/how-to/header/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dialog/how-to/header/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/dialog/how-to/header/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

