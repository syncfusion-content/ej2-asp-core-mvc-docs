---
title: "DropDownButton Getting Started"
component: "DropDownButton"
description: "This section helps to learn how to create the dropdownbutton in ASP.NET Core application with its basic features in step-by-step procedure."
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
