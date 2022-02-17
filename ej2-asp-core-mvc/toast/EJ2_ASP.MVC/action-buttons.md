---
layout: post
title: Action Buttons in ##Platform_Name## Toast Component
description: Learn here all about Action Buttons in Syncfusion ##Platform_Name## Toast component and more.
platform: ej2-asp-core-mvc
control: Action Buttons
publishingplatform: ##Platform_Name##
documentation: ug
---


# Action Buttons

You can include action buttons to the toast control by adding the [`Buttons`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Notifications.Toast.html#Syncfusion_EJ2_Notifications_Toast_Buttons) property. The collection of Syncfusion ASP.NET MVC button models can be bound to the `model` property inside the `Buttons` property. You can also include the click event callback function for each button.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/toast/actionButton/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/toast/actionButton/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/toast/actionButton/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/toast/actionButton/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![Toast control with action buttons support](./images/toast-action.PNG)

## See Also

* [How to add dynamic template](./how-to/add-dynamic-template/)