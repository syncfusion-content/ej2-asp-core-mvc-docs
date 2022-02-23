---
title: "ASP.NET MVC Getting Started For Badge"
component: "Badge"
description: "ASP.NET MVC getting started with Badge, a pure CSS component."
---

# Getting Started

This section briefly explains about how to render `Badge` component in your ASP.NET MVC application. You can
refer [ASP.NET MVC Getting Started documentation](../getting-started/) page for introduction part
of the system requirements and configure the common specifications.

> Starting with `v16.2.0.x`, if you reference Syncfusion assemblies from trial setup or from the NuGet feed, you also have to include a license key in your projects. Please refer to this [link](https://help.syncfusion.com/common/essential-studio/licensing/license-key) to know about registering Syncfusion license key in your ASP .NET MVC application to use our components.

## Adding Badge component to the Application

Since the `Badge` is a CSS component there is no need to html tag helper, the component is added by using CSS
classes. Add the below code to your `index.cshtml` page which is present under `Views/Home` folder.

```html
<h1>Badge Component <span class="e-badge">New</span></h1>
```

After successful compilation of your application, simply press `F5` to run the application.

The following example shows a basic Badge.

{% aspTab template="badge/getting-started/mvc", sourceFiles="HomeController.cs" %}

{% endaspTab %}

Output be like the below.

![Badge Sample](./images/badge.PNG)

## See Also

[Types of Badge](./types)