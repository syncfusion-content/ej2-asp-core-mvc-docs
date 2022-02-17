---
layout: post
title: Toast Services in ##Platform_Name## Toast Component
description: Learn here all about Toast Services in Syncfusion ##Platform_Name## Toast component and more.
platform: ej2-asp-core-mvc
control: Toast Services
publishingplatform: ##Platform_Name##
documentation: ug
---


# Toast Utility Services

The Toast component provides a built-in utility function to render the toast with minimal code. The utility function will render the toast without the need of rendering the container element in the DOM where the toast is appended. So that, the toast can now be rendered on the go. The following are the option to render the toast using the utility function.

## Show Toast with predefined types

The Toast component support 4 types of predefined toast with essential colors for various situations which can be shown using the `ToastUtility.show` by just defining the type of the toast without defining any class names. The following options are used as an argument on calling the utility function for predefined types:

| Options   | Description |
|-----------|-------------|
| [content](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Notifications.Toast.html#Syncfusion_EJ2_Notifications_Toast_Content) | Specifies the content that can be displayed on the Toast. |
| type | Specifies the type of the predefined Toasts. The 4 types of predefined toasts are `Information`, `Success`, `Error`, `Warning` |
| [timeOut](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Notifications.Toast.html#Syncfusion_EJ2_Notifications_Toast_TimeOut) | Specifies the Toast display time duration on the page in milliseconds. Once the time expires, Toast message will be removed. Setting 0 as a time out value displays the Toast on the page until the user closes it manually. |

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/toast/toastTypeUtility/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/toast/toastTypeUtility/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/toast/toastTypeUtility/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/toast/toastTypeUtility/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Show Toast with ToastModel

The utility function can be called using the [ToastModel](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Notifications.Toast.html#Syncfusion_EJ2_Notifications_Toast_ToastModel) as argument to show the toast where all the properties in the `ToastModel` like any events, position, close icon, action buttons, etc. can be used in the `ToastUtility.show`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/toast/toastModelUtility/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/toast/toastModelUtility/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/toast/toastModelUtility/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/toast/toastModelUtility/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


