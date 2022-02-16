---
layout: post
title: Show Different Types Of Toast in ##Platform_Name## Toast Component
description: Learn here all about Show Different Types Of Toast in Syncfusion ##Platform_Name## Toast component and more.
platform: ej2-asp-core-mvc
control: Show Different Types Of Toast
publishingplatform: ##Platform_Name##
documentation: ug
---


# Show different types of toast

The Syncfusion ASP.NET Core toast has the following predefined styles that can be defined using the [`cssClass`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Notifications.Toast.html#Syncfusion_EJ2_Notifications_Toast_CssClass) property for achieving different types of toast:

| Class | Description |
| -------- | -------- |
| e-toast-success | Represents a positive toast |
| e-toast-info | Represents an informative toast |
| e-toast-warning | Represents a toast with caution |
| e-toast-danger | Represents a negative toast |

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/toast/types/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/toast/types/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/toast/types/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/toast/types/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

