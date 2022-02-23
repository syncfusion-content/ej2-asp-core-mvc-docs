---
title: "Render both EJ1 and EJ2 Grids in same application"
component: "Grid"
description: "Learn how to render both EJ1 and EJ2 Grids in same application"
---

# Render both EJ1 and EJ2 Grids in same application

To achieve this requirement, you need to use the below code in **_Layout.cshtml** page. Because EJ1 and EJ2 has same library names to perform the different actions. So conflicts may occur when we refer this both controls in same application. To overcome this we need to extend this libraries in ej namespace.

```javascript
<script>
    var dataCopy = Object.assign({}, ej.data);
    $.extend(ej, Syncfusion);
    $.extend(ej.data, dataCopy);
</script>
```

The Layout page looks like

```html
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    @* Syncfusion Essential JS 1 Styles *@
    @Styles.Render("http://cdn.syncfusion.com/16.3.0.21/js/web/flat-azure/ej.web.all.min.css")
    @* Syncfusion Essential JS 2 Styles *@
    @Styles.Render("https://cdn.syncfusion.com/ej2/styles/compatibility/material.css")
</head>

<body>
    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @Scripts.Render("~/Scripts/jsrender.min.js")
    @* Syncfusion Essential JS 1 Scripts *@
    @Scripts.Render("~/Scripts/ej/web/ej.web.all.min.js")
    @* Syncfusion Essential JS 2 Scripts *@
    @Scripts.Render("~/Scripts/ej2/ej2.min.js")
    @RenderSection("scripts", required: false)

    <script>
        var dataCopy = Object.assign({}, ej.data);
        $.extend(ej, Syncfusion);
        $.extend(ej.data, dataCopy);
    </script>

    <div class="container body-content">
        @RenderBody()
    </div>

    @Html.EJ().ScriptManager()
    @Html.EJS().ScriptManager()
</body>
</html>
```