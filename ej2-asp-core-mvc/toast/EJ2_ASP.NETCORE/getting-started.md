---
layout: post
title: Getting Started with ##Platform_Name## Toast Component
description: Checkout and learn about getting started with ##Platform_Name## Toast component of Syncfusion, and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started

This section briefly explains about how to render Toast control in your ASP.NET Core application. You can refer [ASP.NET Core Getting Started documentation](../getting-started) page for introduction part of the system requirements and configure the common specifications.

## Adding Toast control to the Application

* Now open your view page to render Toast control.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/toast/getting-started/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/toast/getting-started/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/toast/getting-started/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/toast/getting-started/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![Toast control](./images/toast.png)

## See Also

* [How to close the toast with click/tap](./how-to/close-the-toast-with-click-tap/)

* [How to prevent duplicate toast display](./how-to/prevent-duplicate-toast-display/)

* [How to show different types of toast](./how-to/show-different-types-of-toast/)