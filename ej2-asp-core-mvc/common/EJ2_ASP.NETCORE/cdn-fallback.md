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

> Alternately, fallback links can be provided using [script fallback](#script-fallback) and [style sheet fallback](#style-sheet-fallback) in ASP.NET Core app.

## Script Fallback

You can check the Syncfusion ASP.NET Core object for script fallback whether scripts are loaded or not. If it's not loaded, create a script tag and refer scripts externally using [CRG](./custom-resource-generator) inside the `<head>` of **~/Pages/Shared/_Layout.cshtml** file in ASP.NET Core app as in the below code.

{% tabs %}
{% highlight cshtml tabtitle="~/index.html" %}

<head>
    ...
    <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/dist/ej2.min.js"></script>
    <script>
    if (typeof(window.ejs) != "object") { // the Syncfusion ASP.NET Core object is not present
        var fallbackScript = document.createElement("script");
        fallbackScript.setAttribute("src", "/scripts/ej2.min.js"); // Path to external scripts
        document.getElementsByTagName("head")[0].appendChild(fallbackScript);
    }
    </script>
</head>

{% endhighlight %}
{% endtabs %}

## Style Sheet Fallback

You can refer the theme style sheet inside the `<head>` of **~/Pages/Shared/_Layout.cshtml** file and downloaded style from [Theme Studio](../../appearance/theme-studio) as fallback style sheet in ASP.NET Core app like below. 

{% tabs %}
{% highlight cshtml tabtitle="~/index.html" %}

<head>
    ...
    <link href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/bootstrap5.css" rel="stylesheet" />
</head>

<body>
    ...
    <script>
    function cdnScriptTest() {
        var testElem = document.createElement("div");
        testElem.className = "e-control"; // Syncfusion themes provides the e-control class
        document.body.appendChild(testElem);
        var testFontSize = window.getComputedStyle(testElem).getPropertyValue("font-size");
        if (testFontSize !== "12px") {
            // CDN failed
            var fallbackStyle = document.createElement("link");
            fallbackStyle.setAttribute("rel", "stylesheet");
            fallbackStyle.setAttribute("type", "text/css");
            fallbackStyle.setAttribute("href", "/styles/bootstrap5.css"); // Path to external styles
            document.getElementsByTagName("head")[0].appendChild(fallbackStyle);
            }
            document.body.removeChild(testElem);
        }
        cdnScriptTest();
    </script>
</body>

{% endhighlight %}
{% endtabs %}
