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

This section briefly explains about how to include a simple Chip in your ASP.NET MVC application. You can refer [ASP.NET MVC Getting Started documentation](../getting-started) page for introduction part of the system requirements and configure the common specifications.

## Add Chip to the project

We are going to render `Chip` control in **Index.cshtml** page.

```html

 @Html.EJS().ChipList("chip").Text("Janet Leverling").Render()

```

## Run the application

 After successful compilation of your application, simply press `F5` to run the application.

 The following example shows a default rendering of Chip.

{% aspTab template="chips/getting-started/demo", sourceFiles="default.cs" %}

{% endaspTab %}

Output be like the below.

![Chip Sample](./images/chip.png)
