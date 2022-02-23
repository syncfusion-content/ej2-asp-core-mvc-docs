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

{% aspTab template="file-manager/filemanager-in-ie", sourceFiles="HomeController_core.cs,HomeController_mvc.cs,Layout.cshtml,Layout_mvc.cshtml" %}

{% endaspTab %}

Output be like the below.

![FileManager largeicons view](./../images/large_icons.PNG)
