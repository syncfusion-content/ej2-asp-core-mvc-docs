---
title: "Slider ASP.NET Core Getting Started"
component: "Slider"
description: "ASP.NET Core getting started with Slider control."
---

# Getting Started

  This section briefly explains about how to render Slider control in your ASP.NET Core application. You can refer [ASP.NET Core Getting Started documentation](../getting-started) page for introduction part of the system requirements and configure the common specifications.

  > Starting with `v16.2.0.x`, if you reference Syncfusion assemblies from trial setup or from the NuGet feed, you also have to include a license key in your projects. Please refer to this [link](https://help.syncfusion.com/common/essential-studio/licensing/license-key) to know about registering Syncfusion license key in your ASP .NET Core application to use our controls.

## Adding Slider control to the Application

Slider control can be rendered with the help of `ejs-slider` tag helper. Add the below code to your `index.cshtml` page which is present under `Views/Home` folder

```cs

<ejs-slider id="default" value="40" type="MinRange" ></ejs-slider>

```

## Run the application

 After successful compilation of your application, simply press `F5` to run the application.

 The following example shows a default rendering of Slider.

{% aspTab template="slider/getting-started/core", sourceFiles="HomeController.cs" %}

{% endaspTab %}

Output be like the below.

![Slider Sample](./images/slider.PNG)

## See Also

[Slider Types](./types)

[Slider Formatting](./format)

[Orientation Slider](./orientation)

[Ticks in Slider](./ticks)

[Tooltip in Slider](./tooltip)