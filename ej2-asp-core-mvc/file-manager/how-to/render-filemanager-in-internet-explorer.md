---
layout: post
title: Render File Manager In IE ##Platform_Name## File Manager Control | Syncfusion
description: Learn here all about Render File Manager In Internet Explorer in Syncfusion ##Platform_Name## File Manager control of syncfusion and more.
platform: ej2-asp-core-mvc
control: Render File Manager In Internet Explorer
publishingplatform: ##Platform_Name##
documentation: ug
---

# Render FileManager in Internet Explorer

In the Internet Explorer browser, ES6 promise polyfills are required to run the File Manager control. Click this  [`link`](https://ej2.syncfusion.com/aspnetcore/documentation/browser/?no-cache=1) to learn more about the EJ2 components' browser compatibility.

To render the File Manager control in the Internet Explorer browser, add the ES6 promise polyfill script above the Syncfusion<sup style="font-size:70%">&reg;</sup> Essential<sup style="font-size:70%">&reg;</sup> JS 2 Scripts in the `layout` page.

  ```html
     <head>
        <!-- ES6 Promise polyfill  -->
        <script src="https://cdn.polyfill.io/v2/polyfill.min.js"></script>
        <!-- Syncfusion Essential JS 2 Scripts -->
        <script src="https://cdn.syncfusion.com/ej2/dist/ej2.min.js"></script>
     </head>
   ```

After adding the script file in the `layout` page, render the File Manager control. The following example shows how to render the File Manager in IE browser.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/file-manager/filemanager-in-ie/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController_core.cshtml" %}
{% include code-snippet/file-manager/filemanager-in-ie/HomeController_core.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/file-manager/filemanager-in-ie/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Layout_mvc.cshtml" %}
{% include code-snippet/file-manager/filemanager-in-ie/Layout_mvc.cshtml %}
{% endhighlight %}
{% endtabs %}
{% endif %}



The output will look like the image below.

![FileManager largeicons view](./../images/large_icons.PNG)
