---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Getting Started of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started

This section briefly explains about how to include a simple SplitButton in your ASP.NET MVC application. You can refer [ASP.NET MVC Getting Started documentation](../getting-started) page for introduction part of the system requirements and configure the common specifications.

## Add SplitButton to the project

We are going to render `SplitButton` component in **Index.cshtml** page.

{% aspTab template="split-button/getting-started/demo" %}

{% endaspTab %}

`ViewBag.items` variable is used for bounding the `items` property in view page.

## Bind dataSource

Populate the action items in `SplitButton` by using the `items` property. Here, the JSON values are passed to the
SplitButton component are generated in `HomeController.cs` and assigned to `ViewBag` variable.

```cs
public ActionResult Index()
        {
            // Define the array of JSON
            List<object> items = new List<object>();
            items.Add(new
            {
                text = "Cut"
            });
            items.Add(new
            {
                text = "Copy"
            });
            items.Add(new
            {
                text = "Paste"
            });
            ViewBag.items = items;
            return View();
        }

```

Output be like the below.

![SplitButton Sample](./images/split-button.PNG)

## Run the application

 After successful compilation of your application, simply press `F5` to run the application.

 The following example shows a basic SplitButton.

{% aspTab template="split-button/getting-started/demo", sourceFiles="default.cs" %}

{% endaspTab %}

## See Also

* [SplitButton with icons](./icons#splitbutton-icons)