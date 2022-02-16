---
layout: post
title: Getting Started with ##Platform_Name## Sparkline Component
description: Checkout and learn about getting started with ##Platform_Name## Sparkline component of Syncfusion, and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started

## Prerequisites

To get start with ASP.NET MVC application, need to ensure the following software to be installed on the machine.

1. .Net Framework 4.5 and above.
2. ASP.NET MVC 4 or ASP.NET MVC 5
3. Visual Studio

## Preparing ASP.NET MVC application

The following steps to create ASP.NET MVC Application.

**Step 1:** Create ASP.NET MVC Application with default template project in Visual Studio.

![Default Template](./images/default-template.png)

**Step 2:** Once your project created. We need to add Syncfusion EJ2 package into your application by using `NuGet Package Manager`.

Open the `NuGet` package manager.

![Solution Explorer](./images/solution-Explorer.png)

Install the **Syncfusion.EJ2.MVC4** package to the application.

![Nuget Demo](./images/nuget-demo.png)

After installation complete, this will be included in the project. You can refer it from the Project Assembly Reference.

> We need to install **NewtonSoft.JSON** as a dependency, since **Syncfusion.EJ2** dependent to `NewtonSoft.JSON` package.

**Step 3:** Add Syncfusion.EJ2 namespace reference in `Web.Config`.

```javascript

<namespaces>
    <add namespace="Syncfusion.EJ2"/>
</namespaces>

```

```javascript

<system.web>
    <compilation>
      <assemblies>
        <add assembly="Syncfusion.EJ2, Version=15.3400.0.27, Culture=neutral, PublicKeyToken=31BF3856AD364E35"  />
      </assemblies>
    </compilation>
  </system.web>

```

**Step 4:** Add client side resources through [`CDN`](http://ej2.syncfusion.com/documentation/base/deployment.html?lang=typescript#cdn) or local [`package`](https://www.npmjs.com/package/@syncfusion/ej2) in the layout page **_Layout.cshtml.**

```cs
@* Syncfusion Essential JS 2 Scripts *@
<script src="https://cdn.syncfusion.com/ej2/dist/ej2.min.js"></script>

```

**Step 5:** Add Script Manager and namespace in layout page **_Layout.cshtml.**

```cs

@using Syncfusion.EJ2;

    . . .
    . . .
<body>
    . . .
    . . .
    @Html.EJS().ScriptManager()
</body>

```

**Step 6:** Now, we can add Syncfusion Essential JS 2 for ASP.Net Core components in any page you want.

We are going to render `Sparkline` component in **Index.cshtml** page.

```cs

<h2> Essential JS 2 for ASP.NET MVC Sparkline </h2>

 @Html.EJS().Sparkline("spark").DataSource(ViewBag.data).XName("xval").YName("yval").Render()
```

[`HomeController.cs`]

```javascript
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EJ2_Core_Application.Models;
using Newtonsoft.Json;

namespace EJ2_Core_Application.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.data = DataSource.GetData();
            return View();
        }
       public class DataSource
        {
            public int x;
            public string xval;
            public double yval;
            public static List<DataSource>GetData()
            {
                List<DataSource> data1 = new List<DataSource>();
                data1.Add(new DataSource() { x = 0, xval = "2005", yval = 20090440 });
                data1.Add(new DataSource() { x = 1, xval = "2006", yval = 20264080 });
                data1.Add(new DataSource() { x = 2, xval = "2007", yval = 20434180 });
                data1.Add(new DataSource() { x = 3, xval = "2008", yval = 21007310 });
                data1.Add(new DataSource() { x = 4, xval = "2009", yval = 21262640 });
                data1.Add(new DataSource() { x = 5, xval = "2010", yval = 21515750 });
                data1.Add(new DataSource() { x = 6, xval = "2011", yval = 21766710 });
                data1.Add(new DataSource() { x = 7, xval = "2012", yval = 22015580 });
                data1.Add(new DataSource() { x = 8, xval = "2013", yval = 22262500 });
                data1.Add(new DataSource() { x = 9, xval = "2014", yval = 22507620 });
                return data1;
            }
        }
    }
}
```