---
layout: post
title: Render Filemanager In Internet Explorer in ##Platform_Name## File Manager Component
description: Learn here all about Render Filemanager In Internet Explorer in Syncfusion ##Platform_Name## File Manager component and more.
platform: ej2-asp-core-mvc
control: Render Filemanager In Internet Explorer
publishingplatform: ##Platform_Name##
documentation: ug
---

# Render FileManager in Internet Explorer

In the Internet Explorer browser, ES6 promise polyfills are required to run the file manager component. Click this  [`link`](https://ej2.syncfusion.com/aspnetcore/documentation/browser/?no-cache=1) to learn more about the EJ2 components browser compatibility.

To render the file manager component in Internet Explorer browser, add the ES6 promise polyfill script above the Syncfusion Essential JS 2 Scripts in `layout` page.

  ```html
     <head>
        <!-- ES6 Promise polyfill  -->
        <script src="https://cdn.polyfill.io/v2/polyfill.min.js"></script>
        <!-- Syncfusion Essential JS 2 Scripts -->
        <script src="https://cdn.syncfusion.com/ej2/dist/ej2.min.js"></script>
     </head>
   ```

After adding the script file in `layout` page, render the file manager component. The following example shows how to render the file manager in IE browser.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/file-manager/filemanager-in-ie/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Layout_mvc.cshtml" %}
{% include code-snippet/file-manager/filemanager-in-ie/Layout_mvc.cshtml %}
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



Output be like the below.

![FileManager largeicons view](./../images/large_icons.PNG)
