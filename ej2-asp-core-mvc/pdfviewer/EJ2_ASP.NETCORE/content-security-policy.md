---
layout: post
title: Content Security Policy with EJ2 ASP.NET Core PDF Viewer | Syncfusion
description: Learn here all about Content Security Policy in ASP.NET CORE PDF Viewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: CSP
publishingplatform: ##Platform_Name##
documentation: ug
---

# Content Security Policy

Content Security Policy (CSP) is a security feature implemented by web browsers that helps to protect against attacks such as cross-site scripting (XSS) and data injection. It limits the sources from which content can be loaded on a web page.

To enable strict [Content Security Policy (CSP)](https://csp.withgoogle.com/docs/strict-csp.html), certain browser features are disabled by default. In order to use Syncfusion PDF Viewer control with strict CSP mode, it is essential to include following directives in the CSP meta tag.

* Syncfusion PDF Viewer control are rendered with calculated **inline styles** and **base64** font icons, which are blocked on a strict CSP-enabled site. To allow them, add the [`style-src 'self' 'wasm-unsafe-eval' blob:;` ](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Content-Security-Policy/style-src) and [`font-src 'self' data:;`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Content-Security-Policy/font-src) directives in the meta tag as follows.

{% tabs %}
{% highlight razor tabtitle="HTML" %}

<meta http-equiv="Content-Security-Policy" content="default-src 'self';
    style-src 'self' https://fonts.googleapis.com/ blob:;
    font-src 'self' https://fonts.googleapis.com/ https://fonts.gstatic.com/ data:;" />

{% endhighlight %}
{% endtabs %}

* Syncfusion **material** and **tailwind** built-in themes contain a reference to the [`Roboto’s external font`](https://fonts.googleapis.com/css?family=Roboto:400,500), which is also blocked. To allow them, add the [`external font`](https://fonts.googleapis.com/css?family=Roboto:400,500) reference to the [`style-src`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Content-Security-Policy/style-src) and [`font-src`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Content-Security-Policy/font-src) directives in the above meta tag.

The resultant meta tag is included within the `<head>` tag and resolves the CSP violation on the application's side when utilizing Syncfusion PDF Viewer control with material and tailwind themes.

{% tabs %}
{% highlight razor tabtitle="HTML" %}

<head>
    ...
    <meta http-equiv="Content-Security-Policy" content="default-src 'self';
    style-src 'self' https://fonts.googleapis.com/ blob:;
    font-src 'self' https://fonts.googleapis.com/ https://fonts.gstatic.com/ data:;" />
</head>

{% endhighlight %}
{% endtabs %}

* Syncfusion PDF Viewer control when images are added as **blob** and **base64**, which are blocked on a strict CSP-enabled site.To overcome this restriction, it is necessary to add the img-src data: directive in the meta tag. To allow them, add the  [`style-src  'self' blob:;`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Content-Security-Policy/style-src) and [`img-src 'self' data:;`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Content-Security-Policy/img-src) directives as follows.

{% tabs %}
{% highlight razor tabtitle="HTML" %}
<head>
    <meta http-equiv="Content-Security-Policy" content="default-src 'self';
    script-src 'self' 'wasm-unsafe-eval' blob:;
    font-src 'self' https://fonts.googleapis.com/ https://fonts.gstatic.com/ data:;
    style-src 'self' https://fonts.googleapis.com/ blob:;
    img-src 'self' data:"/>
</head>
{% endhighlight %}
{% endtabs %}

* Syncfusion PDF Viewer control when **web worker** and   is used, which is blocked on a strict CSP-enabled site. To allow them, add the [`worker-src`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Content-Security-Policy/worker-src) and [`connect-src`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Content-Security-Policy/connect-src) directives in the above meta tag as follows.

{% tabs %}
{% highlight razor tabtitle="HTML" %}
<head>
 <meta http-equiv="Content-Security-Policy" content="default-src 'self';
    script-src 'self' 'wasm-unsafe-eval' blob:;
    worker-src 'self' blob:;
    connect-src 'self' data:;
    style-src 'self' https://fonts.googleapis.com/ blob:;
    font-src 'self' https://fonts.googleapis.com/ https://fonts.gstatic.com/ data:;
    img-src 'self' data: blob:;" />
</head>
{% endhighlight %}
{% endtabs %}

N> In accordance with the latest security practices, the Syncfusion PDF Viewer control now recommends using `wasm-unsafe-eval` in the Content Security Policy (CSP) settings to enhance the security of WebAssembly operations. This change ensures a safer execution environment while maintaining the necessary functionality. Make sure to update your CSP meta tags to reflect this change for optimal security compliance.

### Please find the usage of each directives:

| Directive                          | Usage                                                                                                                                                                                                                  |
|------------------------------------|------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| `default-src 'none';`              | Sets the default policy for loading resources. `'self'` means only allow resources from the same origin (same domain).                                                                                                 |
| `script-src 'self' 'wasm-unsafe-eval' blob:;` | Defines where JavaScript (and WebAssembly) code can come from. `'self'` allows scripts from the same origin. `'wasm-unsafe-eval'` allows compilation of WebAssembly using JS eval()-like functions (security-sensitive). `blob:` allows loading scripts from Blob URLs. |
| `worker-src 'self' blob:;`         | Controls where workers can be loaded from. `'self'` allows same-origin workers. `blob:` allows blob-based workers, common in PDF viewers and heavy JS applications.                                                     |
| `connect-src 'self';`              | Controls where the application can make network requests, such as `fetch()`, XHR, and WebSockets. `'self'` restricts this to the same origin.                                                                          |
| `style-src 'self' blob:;`          | Defines the sources for stylesheets. `'self'` restricts to the same origin. `blob:` allows dynamically generated styles, which might be necessary for apps with dynamically generated CSS.                               |
| `font-src 'self' data:`            | Controls where fonts can be loaded from. `'self'` allows local fonts. `data:` allows inline fonts (base64 embedded), and the URLs allow loading from external font CDN.                                                 |
| `img-src 'self' data:;`            | Controls where images can be loaded from. `'self'` restricts to the same origin. `data:` allows inline images (base64).                                                                                                 |

[View sample in GitHub](https://github.com/SyncfusionExamples/asp-core-pdf-viewer-examples/tree/master)