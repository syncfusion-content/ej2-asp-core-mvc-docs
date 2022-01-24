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

This section briefly explains about how to create a simple DropDownButton in your ASP.NET Core application. You can refer [ASP.NET Core Getting Started documentation](../getting-started) page for introduction part of the system requirements and configure the common specifications.

## Add DropDownButton to the project

To create DropDownButton add the `ejs-dropdownbutton` tag with id attribute as `element` in your **Index.cshtml** page.

{% aspTab template="dropdownbutton/getting-started/demo" %}

{% endaspTab %}

`ViewBag.items` variable is used for bounding the `items` property in view page.

## Bind dataSource

Populate the action items in `SplitButton` by using the `items` property. Here, the JSON values are passed to the
DropDownButton component are generated in `default.cs` and assigned to `ViewBag` variable.

```cs
public IActionResult Index()
{
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

![DropDownButton Sample](./images/drop-down-button.PNG)

## Run the application

 After successful compilation of your application, simply press `F5` to run the application.

 The following example shows a basic DropDownButton.

{% aspTab template="dropdownbutton/getting-started/demo", sourceFiles="default.cs" %}

{% endaspTab %}
