---
layout: post
title: CDN fallback in ASP.NET Core | Syncfusion
description: Learn here about content delivery network (CDN) fallback handling in ASP.NET Core app.
platform: ej2-asp-core-mvc
control: Common
publishingplatform: ##Platform_Name##
documentation: ug
---

# CDN fallback in ASP.NET Core application

This section provides information about how to refer fallback scripts and style sheet from [CRG](./custom-resource-generator) and [Theme Studio](../../appearance/theme-studio) when CDN is not available in ASP.NET Core application.

## ASP.NET Core App

CDN links can be down by connection issues or some other problems. This will cause the site looks broken. Follow the below steps to resolve these issues in the ASP.NET Core application. 

### Style Sheet Fallback

If you are using CDN for style sheet references then you have to add style sheet fallback from [Theme Studio](../../appearance/theme-studio) by using the [link tag helper](https://docs.microsoft.com/en-us/aspnet/core/mvc/views/tag-helpers/built-in/link-tag-helper). Syncfusion theme provides the `e-control` class. You can check the style from provided class by using link tag helper property inside the `<head>` of **~/Pages/Shared/_Layout.cshtml** file as follows,

{% tabs %}
{% highlight cshtml tabtitle="~/_Layout.cshtml" %}

<head>
    ...
    <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/bootstrap5.css"
    asp-fallback-href="~/styles/bootstrap5.css"
    asp-fallback-test-class="e-control"
    asp-fallback-test-property="font-size"
    asp-fallback-test-value="12px" />
</head>

{% endhighlight %}
{% endtabs %}

### Script Fallback

You can check the Syncfusion ASP.NET Core object for script fallback by using [script tag helper](https://docs.microsoft.com/en-us/aspnet/core/mvc/views/tag-helpers/built-in/script-tag-helper?view=aspnetcore-6.0) and refer scripts externally from [CRG](./custom-resource-generator) inside the `<head>` of **~/Pages/Shared/_Layout.cshtml** file in ASP.NET Core app as in the below code.

{% tabs %}
{% highlight cshtml tabtitle="~/_Layout.cshtml" %}

<head>
    ...
    <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/dist/ej2.min.js"
    asp-fallback-src="~/scripts/ej2.min.js" asp-fallback-test="window.ejs"></script>
</head>

{% endhighlight %}
{% endtabs %}
