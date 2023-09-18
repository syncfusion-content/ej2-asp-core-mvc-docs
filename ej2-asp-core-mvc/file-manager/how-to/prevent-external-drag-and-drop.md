---
layout: post
title: Prevent external drag and drop in ##Platform_Name## File Manager Component
description: Learn here all about Render Filemanager In Internet Explorer in Syncfusion ##Platform_Name## File Manager component of syncfusion and more.
platform: ej2-asp-core-mvc
control: Prevent external drag and drop
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to prevent external drag and drop

In the Blazor FileManager component, external drag and drop of files or folders can be prevented by utilizing the [`created`](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.filemanager.filemanager.html#Syncfusion_EJ2_FileManager_FileManager_Created) event and by utilizing Uploader component instances, specifically the `uploadObj’s`, and configuring the `uploadObj's` `dropArea` as null.

The following example demonstrates how to prevent external drag and drop functionality within the File Manager component.

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
{% include code-snippet/file-manager/external-drag-and-drop/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Layout_mvc.cshtml" %}
{% include code-snippet/file-manager/external-drag-and-drop/HomeController_core.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/file-manager/external-drag-and-drop/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Layout_mvc.cshtml" %}
{% include code-snippet/file-manager/external-drag-and-drop/HomeController_mvc.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![FileManager largeicons view](./../images/external_drag_and_drop.gif)
