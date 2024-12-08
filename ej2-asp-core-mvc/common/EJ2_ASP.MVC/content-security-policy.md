---
layout: post
title: Content Security Policy in ##Platform_Name## Common Control | Syncfusion
description: Learn here all about Content Security Policy in Syncfusion ##Platform_Name## Common control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Common
publishingplatform: ##Platform_Name##
documentation: ug
---

# Content Security Policy

Content Security Policy (CSP) is a security feature implemented by web browsers that helps to protect against attacks such as cross-site scripting (XSS) and data injection. It limits the sources from which content can be loaded on a web page.

To enable strict [Content Security Policy (CSP)](https://csp.withgoogle.com/docs/strict-csp.html), certain browser features are disabled by default. In order to use Syncfusion<sup style="font-size:70%">&reg;</sup> controls with strict CSP mode, it is essential to include following directives in the CSP meta tag.

* Syncfusion<sup style="font-size:70%">&reg;</sup> controls are rendered with calculated **inline styles** and **base64** font icons, which are blocked on a strict CSP-enabled site. To allow them, add the [`style-src 'self' 'unsafe-inline';`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Content-Security-Policy/style-src) and [`font-src 'self' data:;`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Content-Security-Policy/font-src) directives in the meta tag as follows.

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}

<meta http-equiv="Content-Security-Policy" content="default-src 'self';
    script-src 'self' 'unsafe-inline'  https://cdn.syncfusion.com;
    style-src 'self' 'unsafe-inline';
    font-src 'self'  data:;" />

{% endhighlight %}
{% endtabs %}

* Syncfusion<sup style="font-size:70%">&reg;</sup> **material** and **tailwind** built-in themes contain a reference to the [`Roboto’s external font`](https://fonts.googleapis.com/css?family=Roboto:400,500), which is also blocked. To allow them, add the [`external font`](https://fonts.googleapis.com/css?family=Roboto:400,500) reference to the [`style-src`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Content-Security-Policy/style-src) and [`font-src`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Content-Security-Policy/font-src) directives in the above meta tag.

The resultant meta tag is included within the `<head>` tag and resolves the CSP violation on the application's side when utilizing Syncfusion<sup style="font-size:70%">&reg;</sup> controls with material and tailwind themes.

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}

<head>
    ...
    <meta http-equiv="Content-Security-Policy" content="default-src 'self';
    script-src 'self' 'unsafe-inline'  https://cdn.syncfusion.com;
    style-src 'self' https://fonts.googleapis.com/ 'unsafe-inline';
    font-src 'self' https://fonts.googleapis.com/ https://fonts.gstatic.com/ data:;" />
</head>

{% endhighlight %}
{% endtabs %}

N> The `unsafe-eval` directive needs to be added in `script-src` for controls which uses the templates.

