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

Content Security Policy (CSP) is a security feature implemented by web browsers to protect against attacks such as cross-site scripting (XSS) and data injection. It limits the sources from which content can be loaded on a web page. To enable strict Content Security Policy (CSP), certain browser features are disabled by default. To use Syncfusion<sup style="font-size:70%">&reg;</sup> controls with strict CSP mode, it is essential to include the following directives:

`nonce` attribute is used in CSP to validate requests and prevent attackers from injecting JavaScript code into a web application.


## Steps to Create and Include the Nonce Attribute in an ASP.NET Core Application

* Generate the `nonce` attribute value by adding the below code in **Program.cs** file.

* Syncfusion<sup style="font-size:70%">&reg;</sup> material and tailwind built-in themes contain a reference to the Roboto’s external font, which is also blocked. To allow them, add the external font reference to the `style-src` and `font-src` directives in the above meta tag.

{% tabs %}
{% highlight c# tabtitle="Program.cs" %}

using System.Security.Cryptography;

...
app.Use(async (context, next) =>
{
    RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
    byte[] nonceBytes = new byte[32];
    rng.GetBytes(nonceBytes);
    string nonceValue = Convert.ToBase64String(nonceBytes);
    context.Items.Add("ScriptNonce", nonceValue);
    context.Response.Headers.Add("Content-Security-Policy", string.Format(
    "script-src 'self' 'nonce-{0}' https://cdn.syncfusion.com;" +
    "style-src-elem 'self' 'unsafe-inline' https://cdn.syncfusion.com https://fonts.googleapis.com;" +
    "font-src 'self' data: https://fonts.gstatic.com;" +
    "object-src 'none';", nonceValue));
    await next();
});


{% endhighlight %}
{% endtabs %}

* Open **_Layout.cshtml** file and add `nonce` attribute in the client side resources like below,

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}
<head>
    ...
    <!-- Syncfusion ASP.NET Core controls scripts -->
    <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/dist/ej2.min.js" nonce="@Context.Items["ScriptNonce"]"></script>
</head>
{% endhighlight %}
{% endtabs %}

* Set `add-nonce` for `ejs-scripts` while registering the script manager at the end of `<body>` of **_Layout.cshtml** file as follows,

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}
<body>
    ...
    <!-- Syncfusion ASP.NET Core Script Manager -->
    <ejs-scripts add-nonce="@Context.Items["ScriptNonce"]"></ejs-scripts>
</body>
{% endhighlight %}
{% endtabs %}

N> The `unsafe-eval` directive needs to be added in `script-src` for controls which uses the templates.

* Run the application then see the DOM, `nonce` attribute is added in script tag and it's value hidden for security purpose.



