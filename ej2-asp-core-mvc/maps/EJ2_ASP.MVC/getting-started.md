---
layout: post
title: Getting Started with ##Platform_Name## Maps Component
description: Checkout and learn about getting started with ##Platform_Name## Maps component of Syncfusion, and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---

# Getting Started

You can explore some useful features in the Maps component using the following video.

{% youtube "https://www.youtube.com/watch?v=kwE6ikF7QYQ" %}

## Using Visual Studio 2019

### Getting Started with ASP.NET MVC 5 Web Application

#### Prerequisites

To get started with ASP.NET MVC 5 application, ensure that the following software are installed on the machine.

* .NET Framework 4.5 and above
* ASP.NET MVC 5
* Visual Studio 2019

#### Create ASP.NET MVC web application

**Step 1:** Choose **File > New > Project** in the Visual Studio.

    ![new project in aspnetmvc 2019](../maps/images/new-mvc-project-vs2019.png)

**Step 2:** Select **ASP.NET Web Application (.NET Framework)** in **Create a new project** dialog box.

    ![aspnetmvc5 project template 2019](../maps/images/aspnetmvc-templatevs2019.png)
  
**Step 3:** Change the application name, and then click **Create** button in the **Configure your new project** dialog box.

    > In the ASP.NET MVC application, Essential JS2 supports .NET Framework 4.5 and above. For Syncfusion ASP.NET MVC, the minimum target framework is 4.5. (Essential JS2).

    ![aspnetmvc5 new project Template 2019](../maps/images/aspnetmvc5-new-project-templatevs2019.png)

**Step 4:** Choose **MVC** and then click **Create** button in the **Create a new ASP.NET web application** dialog box. Now, the MVC web application project is created with default ASP.NET MVC template.

    ![aspnetmvc5 web application template 2019](../maps/images/aspnetmvc-config-template-vs2019.png)

#### Configure Essential JS2 in the application

**Step 1:** Right-click the project name in the **Solution Explorer** and select **Manage NuGet Packages** option in the menu.

    ![aspnetmvc5 manage nuget packages 2019](../maps/images/aspnetmvc5-manage-nuget-2019.png)

**Step 2:** Search the **Syncfusion EJ2 MVC5** keyword in the **Browse** tab of the **Nuget Package Manager** and install [Syncfusion.EJ2.MVC5](https://www.nuget.org/packages/Syncfusion.EJ2.MVC5/) NuGet package in the application.

    > Refer to [this article](./../nuget-packages/) to learn more details about installing Essential JS2 NuGet packages in various OS environment.

    ![aspnetmvc5 install nuget package 2019](../maps/images/aspnetmvc5-nuget-vs2019.png)

    The Essential JS2 MVC5 NuGet package will be included in the project, after the installation process is completed.

    > The Syncfusion.EJ2.MVC5 NuGet package has dependencies, [`Newtonsoft.Json`](https://www.nuget.org/packages/Newtonsoft.Json/) for JSON serialization, [`Syncfusion.Licensing`](https://www.nuget.org/packages/Syncfusion.Licensing/) for validating Syncfusion license key and [`Syncfusion.EJ2.JavaScript`](https://www.nuget.org/packages/Syncfusion.EJ2.JavaScript/).

**Step 3:** Open **~/Views/Web.config** file and add the `Syncfusion.EJ2` namespace reference to the `<system.web.webPages.razor>` element and `Syncfusion.EJ2` assembly reference to `<system.web>` element.

    ```html
    <configuration>
        ....
        ....
        <system.web.webPages.razor>
            ....
            ....
            <pages pageBaseType="System.Web.Mvc.WebViewPage">
                <namespaces>
                    ....
                    ....
                    <add namespace="Syncfusion.EJ2"/>
                </namespaces>
            </pages>
        </system.web.webPages.razor>
        ....
        ....
        <system.web>
            <compilation>
                <assemblies>
                    ....
                    ....
                    <add assembly="Syncfusion.EJ2, Culture=neutral" />
                </assemblies>
            </compilation>
        </system.web>
    </configuration>
    ```

**Step 4:** Add the desired stylesheet and the script(**ej2.min.js**) of the Syncfusion controls in the `<head>` of **~/Views/Shared/_Layout.cshtml** layout page. The client-side resources can be added through [CDN](https://ej2.syncfusion.com/documentation/deployment/#cdn). They are also available in the application from the installed `Syncfusion.EJ2.JavaScript` package. The stylesheets are available in **~/Content/ej2/** folder path and the **ej2.min.js** script file is available in **~/Scripts/ej2/** folder path.

    ```html
    <head>
        ....
        ....

        <!-- Syncfusion Essential JS2 Styles -->
        <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/material.css" />

        <!-- Syncfusion Essential JS2 Scripts -->
        <script src="https://cdn.syncfusion.com/ej2/dist/ej2.min.js"></script>
    </head>
    ```

**Step 5:** Add the Essential JS2 script manager at the end of `<body>` in the **~/Views/Shared/_Layout.cshtml** layout page.

    ```html
    <body>
        ....
        ....
        <!-- Syncfusion Essential JS2 ScriptManager -->
        @Html.EJS().ScriptManager()
    </body>
    ```
**Step 6:** To initialize the Maps, add the following code to your **Index.cshtml** view page, which is located in the **~/Views/Home** folder path.

```cs

<h2> Essential JS2 for ASP.NET MVC Maps </h2>

 @Html.EJS().Maps("container").Layers(layer => { layer.ShapeData(ViewBag.shapeData).Add(); }).Render();

```

**Step 7:** Place the **WorldMap.json** file in **App_Data** folder of the project. Read the content in **WorldMap.json** file in the code behind and assign the deserialized object to the `shapeData` property of the Maps control using the **ViewBag** object in **HomeController.cs** as shown below.

```cs

    public ActionResult Index()
    {
        ViewBag.shapeData = this.GetWorldMap();
        return View();
    }

    public object GetWorldMap()
    {
        string allText = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/WorldMap.json"));
        return JsonConvert.DeserializeObject(allText, typeof(object));
    }

```

> The `shapeData` in the `ViewBag` object is already assigned to the Maps component in Step 6.

**Step 8:** Run the application and the Essential JS2 Maps component will render in the web browser.

![ASP.NET MVC - Essential JS2 Maps](../maps/images/aspnetmvc-maps.png)

## Using Visual Studio 2017

### Getting Started with ASP.NET MVC 5 Web Application

#### Prerequisites

To get started with the ASP.NET MVC application, ensure that the following software are installed on the computer.

1. .NET Framework 4.5 and above
2. ASP.NET MVC 4 or ASP.NET MVC 5
3. Visual Studio 2017

## Preparing ASP.NET MVC application

The steps to create an ASP.NET MVC application are as follows.

**Step 1:** Click **Create a new project** in Visual Studio 2017 and the popup window below will appear. Click the **OK** button after selecting the **ASP.NET Web Application(.NET Framework)** template. You can also change the name of the project.

![MVC Project Template](../maps/images/mvc-template.PNG)

**Step 2:** Following the previous step, the popup window shown below will appear. Select **MVC** project template in this window. Now the project will be created successfully.

![MVC Project Template](../maps/images/MVC.PNG)

**Step 3:** After you have created your project, use **NuGet Package Manager** to install the **Syncfusion.EJ2.MVC5** package. Right click on the project name in the **Solution Explorer**. Select the **Manage NuGet packages** from the menu.

![Solution Explorer](../images/solution-Explorer.png)

The **Syncfusion.EJ2.MVC5** package should be installed in the application from the **Browse** tab in the **NuGet Package Manager**.

![Nuget Package Manager](../maps/images/mvc-nuget.PNG)

This package will be included in the project once the installation is complete.

> We need to install **NewtonSoft.JSON** as dependency since **Syncfusion.EJ2.MVC5** package is dependent on **NewtonSoft.JSON** package.

**Step 4:** Open **~/Views/Web.config** file. Include the **Syncfusion.EJ2** namespace as reference in the `<system.web.webPages.razor>` element and `Syncfusion.EJ2` assembly reference to `<system.web>` element.

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

**Step 4:** Add client-side resources through [CDN](http://ej2.syncfusion.com/documentation/base/deployment.html?lang=typescript#cdn) in the layout page **_Layout.cshtml.** which is located in the **~/Views/Shared** folder path.

```cs
@* Syncfusion Essential JS2 Scripts *@
<script src="https://cdn.syncfusion.com/ej2/dist/ej2.min.js"></script>

```

**Step 5:** The script manager and namespace should be added to the **_Layout.cshtml** layout page.

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

**Step 6:** To initialize the Maps, add the following code to your **Index.cshtml** view page, which is located in the **~/Views/Home** folder path.

```cs

<h2> Essential JS2 for ASP.NET MVC Maps </h2>

 @Html.EJS().Maps("container").Layers(layer => { layer.ShapeData(ViewBag.shapeData).Add(); }).Render();

```

**Step 7:** Place the **WorldMap.json** file in **App_Data** folder. Read the content in **WorldMap.json** file in the code behind and assign the deserialized object to the `shapeData` property of the Maps control using the **ViewBag** object in **HomeController.cs** as shown below.

```cs

    public ActionResult Index()
    {
        ViewBag.shapeData = this.GetWorldMap();
        return View();
    }

    public object GetWorldMap()
    {
        string allText = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/WorldMap.json"));
        return JsonConvert.DeserializeObject(allText, typeof(object));
    }

```

> The `shapeData` in the `ViewBag` object is already assigned to the Maps component in Step 6.

**Step 8** Run the application and the Essential JS2 Maps component will render in the web browser.

![ASP.NET MVC - Essential JS2 Maps](../maps/images/aspnetmvc-maps.png)
