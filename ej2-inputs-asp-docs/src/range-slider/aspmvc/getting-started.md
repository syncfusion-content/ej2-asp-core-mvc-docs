---
title: "Slider ASP.NET MVC Getting Started"
component: "Slider"
description: "ASP.NET MVC getting started with Slider control."
---

# Getting Started

This section briefly explains about how to render Slider control in your ASP.NET MVC application. You can refer [ASP.NET MVC Getting Started documentation](../getting-started) page for introduction part of the system requirements and configure the common specifications.

> Starting with `v16.2.0.x`, if you reference Syncfusion assemblies from trial setup or from the NuGet feed, you also have to include a license key in your projects. Please refer to this [link](https://help.syncfusion.com/common/essential-studio/licensing/license-key) to know about registering Syncfusion license key in your ASP .NET MVC application to use our controls.

## Adding Slider controls to the Application

Slider controls can be rendered with the help of `@Html.EJS().Slider` tag helper. Add the below code to your `index.cshtml` page which is present under `Views/Home` folder.

```cs

@Html.EJS().Slider("slider").Type(SliderType.MinRange).Value(40).Render()

```

## Run the application

 After successful compilation of your application, simply press `F5` to run the application.

 The following example shows a default rendering of Slider.

{% aspTab template="slider/getting-started/mvc", sourceFiles="HomeController.cs" %}

{% endaspTab %}

Output be like the below.

![Slider Sample](./images/slider.PNG)

## See Also

[Slider Types](./types)

[Slider Formatting](./format)

[Orientation Slider](./orientation)

[Ticks in Slider](./ticks)

[Tooltip in Slider](./tooltip)