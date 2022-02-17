---
layout: post
title: Compatible With Essentialjs1 in ##Platform_Name## Common Component
description: Learn here all about Compatible With Essentialjs1 in Syncfusion ##Platform_Name## Common component and more.
platform: ej2-asp-core-mvc
control: Compatible With Essentialjs1
publishingplatform: ##Platform_Name##
documentation: ug
---

# Compatibility with Syncfusion ASP.NET MVC (Essential JS 1)

This documentation explains how to render  Essential JS 1 and Essential JS 2 Syncfusion components in a single page.

## Adding application

You can create Essential JS 1 and Essential JS 2 controls using the following links:

Getting started for [`EJ2 ASPMVC control`](https://ej2.syncfusion.com/aspnetmvc/documentation/grid/getting-started-mvc/)

Getting started for [`EJ1 ASPMVC control`](https://help.syncfusion.com/aspnetmvc/grid/getting-started)

## Style compatibility

Add compatibility styles. Essential JS 1 and Essential JS 2 controls have compatibility styles that do not affect each other.

```html
<head>
    @* Syncfusion Essential JS 1 Styles *@
    @Styles.Render("https://cdn.syncfusion.com/16.1.0.24/js/web/bootstrap-theme/ej.web.all.compatibility.min.css")

    @* Syncfusion Essential JS 2 Styles *@
    @Styles.Render("https://cdn.syncfusion.com/ej2/styles/compatibility/material.css")
</head>
```

## Script compatibility

Add scripts for Essential JS 1 and Essential JS 2 as shown in the following codes

```html
@* Syncfusion Essential JS 1 Scripts *@
<script src="http://cdn.syncfusion.com/js/assets/external/jquery3.3.1.min.js"></script>
<script src="http://cdn.syncfusion.com/js/assets/external/jsrender.min.js"></script>
<script src="http://cdn.syncfusion.com/16.3.0.21/js/web/ej.web.all.min.js"></script>

@* Syncfusion Essential JS 2 Scripts *@
<script src="https://cdn.syncfusion.com/ej2/dist/ej2.min.js"></script>
```

> If you do not add ej1 script before ej2 script, it will throw script error.

## Adding compatibility

To add compatibility, use the following code in the _Layout.cshtml page. Since EJ1 and EJ2 controls have same library names to perform different actions, conflicts may occur when you refer these both controls in same application. To overcome this, extend these libraries in ej namespace.

```html
<script>
    var dataCopy = Object.assign({}, ej.data);
    $.extend(ej, Syncfusion);
    $.extend(ej.data, dataCopy);
</script>
```

## Adding script manager

Define script manager for both Essential JS 1 and Essential JS 2:

```html
@Html.EJ().ScriptManager()
@Html.EJS().ScriptManager()
```

The following code illustrates the final view of layout page.

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
     
    @Html.EJ().ScriptManager()
    @Html.EJS().ScriptManager()

    <div class="container body-content">
        @RenderBody()
    </div>

</body>
</html>
```

## Declare Essential JS 1 and Essential JS 2 controls

Essential JS 1 and Essential JS 2 controls have already been initialized via getting started. If you want change control, you can initialize using the following code.

```html

<h2> Essential JS 1 - Grid Control</h2>

    @(Html.EJ().Grid<object>("FlatGrid")
                            .Datasource((IEnumerable<object>)ViewBag.gridData)
                            .AllowPaging().PageSettings(page => page.PageSize(4))
                            .Columns(col =>

                            {
                                col.Field("OrderID").HeaderText("Order ID").TextAlign(TextAlign.Right).Width(75).Add();

                                col.Field("CustomerID").HeaderText("CustomerID").Width(80).Add();
                               col.Field("ShipName").HeaderText("ShipName").Width(100).Add();
                                col.Field("ShipCity").HeaderText("ShipCity").Width(100).Add();

                                col.Field("Freight").Format("{0:c3}").HeaderText("Freight").Width(80).TextAlign(TextAlign.Right).Add();
                            })
    )

<h2> Essential JS 2 - Grid Component </h2>

   @Html.EJS().Grid("Grid").DataSource((IEnumerable<object>)ViewBag.gridData).Columns(col =>
    {     col.Field("OrderID").HeaderText("OrderID").Width("120").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).Add();

col.Field("CustomerID").HeaderText("Customer Name").Width("150").Add();
        col.Field("OrderDate").HeaderText("OrderDate").Width("130").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).Format("yMd").Add();

col.Field("ShipCountry").HeaderText("Ship Country").Width("120").Add();

    }).AllowPaging().PageSettings(page => page.PageSize(4).PageSizes(true)).Render()

```

## Sample

https://github.com/SyncfusionExamples/ej2-aspmvc-ej1compatibility
