<!-- markdownlint-disable MD024 -->
# Getting Started with Essential JS 2 for ASP.NET Core

This article provides a step-by-step introduction to configure Essential JS 2 setup, build and publish a simple .NET Core web application using the [Visual Studio](https://visualstudio.microsoft.com/downloads/).

> Starting with v16.2.0.x, if you reference to Syncfusion assemblies from trial setup or NuGet feed, you should include a license key in your projects. Refer to this [link](https://help.syncfusion.com/common/essential-studio/licensing/license-key) to learn about registering Syncfusion license key in your ASP.NET Core application to use the components.

## Using Visual Studio 2019

### Getting Started with ASP.NET Core 5.x

#### Prerequisites

The official prerequisites to create and run an ASP.NET Core 5.x application on windows environment are described in the [.NET Core documentation website](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-5.0&tabs=visual-studio#prerequisites).

#### Create ASP.NET Core web application

1. Open the Visual Studio and click the **File** menu and select **New -> Project** option.

    ![new project in aspnetcore5.x razor](images/new-project-19.png)

2. Select **ASP.NET Core Web Application** templates in visual studio 2019.

    ![aspnetcore5.x project template](images/aspnetcore-template.png)

3. Change the Application name and then click **Create**.

    ![aspnetcore5.x project template](images/aspnetcore5x-application-name.png)

4. Choose .NET Core with ASP.NET Core 5.0 and select **ASP.NET Core Web App (Model-View-Controller)**, and then click **Create**. The web application project is now created with default ASP.NET Core template.

    ![aspnetcore5.x razor web application template](images/aspnetcore5x-netcore-razor.png)

#### Configure Essential JS 2 in the application

1. Add the [`Syncfusion.EJ2.AspNet.Core`](https://www.nuget.org/packages/Syncfusion.EJ2.AspNet.Core/) NuGet package to the new application by using the Nuget Packge Manager. Right-click the project and select the **Manage Nuget Packages...**.

    > Refer to [this article](../nuget-packages) to learn more details about installing Essential JS 2 NuGet packages in various OS environment.

    ![aspnetcore5.x razor manage nuget packages](images/aspnetcore5x-razor-manage-nuget.png)

2. Search the `Syncfusion.EJ2.AspNet.Core` keyword in the **Browser** tab and install **Syncfusion.EJ2.AspNet.Core** NuGet package in the application.

    ![aspnetcore5.x razor install nuget packages](images/aspnetcore5x-nuget-package.png)

    The Essential JS 2 package will be included in the project, after the installation process is completed.

    > **Note:** The Syncfusion.EJ2.AspNet.Core NuGet package has dependencies, [`Newtonsoft.Json`](https://www.nuget.org/packages/Newtonsoft.Json/) for JSON serialization and [`Syncfusion.Licensing`](https://www.nuget.org/packages/Syncfusion.Licensing/) for validating Syncfusion license key.

3. Open `~/Views/_ViewImports.cshtml` file and import the `Syncfusion.EJ2` TagHelper.

    ```html
    @addTagHelper *, Syncfusion.EJ2
    ```
4. Add the client-side resources through [CDN](https://ej2.syncfusion.com/documentation/base/deployment.html?lang=typescript#cdn) or [local npm package](https://www.npmjs.com/package/@syncfusion/ej2) in the `<head>` element of `~/Views/Shared/_Layout.cshtml` layout page.

    ```html
    <head>
        ....
        ....

        <!-- Syncfusion Essential JS 2 Styles -->
        <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/material.css" />

        <!-- Syncfusion Essential JS 2 Scripts -->
        <script src="https://cdn.syncfusion.com/ej2/dist/ej2.min.js"></script>
    </head>
    ```

5. Add the Essential JS 2 Script Manager at the end of `<body>` element in the `~/Views/Shared/_Layout.cshtml` layout page.

    ```html
    <body>
        ....
        ....
        <!-- Syncfusion Essential JS 2 ScriptManager -->
        <ejs-scripts></ejs-scripts>
    </body>
    ```

6. Now, you can add the Syncfusion Essential JS 2 components in any web page (`cshtml`) in the `Home` folder.

    For example, the calendar component is added to the `~/Views/Home/Index.cshtml` page.

    ```html
    <div>
        <ejs-calendar id="calendar"></ejs-calendar>
    </div>
    ```

7. Run the application. The Essential JS 2 calendar component will render in the web browser.

   ![aspnetcore5.x calendar component output](images/aspnetcore-calendar.png)

### Getting Started with ASP.NET Core 3.x

#### Prerequisites

The official prerequisites to create and run an ASP.NET Core 3.x application on windows environment are described in the [.NET Core documentation website](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-3.1&tabs=visual-studio#prerequisites-1).

#### Create ASP.NET Core web application

1. Open the Visual Studio and click the **File** menu and select **New -> Project** option.

    ![new project in aspnetcore3.x razor](images/new-project-19.png)

2. Select **ASP.NET Core Web Application** templates in visual studio 2019.

    ![aspnetcore3.x project template](images/aspnetcore-template.png)

3. Change the Application name and then click **Create**.

    ![aspnetcore3.x project template](images/aspnetcore3x-application-name.png)

4. Choose .NET Core with ASP.NET Core 3.1 and select **Web Application (Model-View-Controller)**, and then click **Create**. The web application project is now created with default ASP.NET Core template.

    ![aspnetcore3.x razor web application template](images/aspnetcore3x-netcore-razor.png)

#### Configure Essential JS 2 in the application

1. Add the [`Syncfusion.EJ2.AspNet.Core`](https://www.nuget.org/packages/Syncfusion.EJ2.AspNet.Core/) NuGet package to the new application by using the Nuget Packge Manager. Right-click the project and select the **Manage Nuget Packages...**.

    > Refer to [this article](../nuget-packages) to learn more details about installing Essential JS 2 NuGet packages in various OS environment.

    ![aspnetcore3.x razor manage nuget packages](images/aspnetcore3x-razor-manage-nuget.png)

2. Search the `Syncfusion.EJ2.AspNet.Core` keyword in the **Browser** tab and install **Syncfusion.EJ2.AspNet.Core** NuGet package in the application.

    ![aspnetcore3.x razor install nuget packages](images/aspnetcore3x-nuget-package.png)

    The Essential JS 2 package will be included in the project, after the installation process is completed.

    > **Note:** The Syncfusion.EJ2.AspNet.Core NuGet package has dependencies, [`Newtonsoft.Json`](https://www.nuget.org/packages/Newtonsoft.Json/) for JSON serialization and [`Syncfusion.Licensing`](https://www.nuget.org/packages/Syncfusion.Licensing/) for validating Syncfusion license key.

3. Open `~/Views/_ViewImports.cshtml` file and import the `Syncfusion.EJ2` TagHelper.

    ```html
    @addTagHelper *, Syncfusion.EJ2
    ```
4. Add the client-side resources through [CDN](https://ej2.syncfusion.com/documentation/base/deployment.html?lang=typescript#cdn) or [local npm package](https://www.npmjs.com/package/@syncfusion/ej2) in the `<head>` element of `~/Views/Shared/_Layout.cshtml` layout page.

    ```html
    <head>
        ....
        ....

        <!-- Syncfusion Essential JS 2 Styles -->
        <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/material.css" />

        <!-- Syncfusion Essential JS 2 Scripts -->
        <script src="https://cdn.syncfusion.com/ej2/dist/ej2.min.js"></script>
    </head>
    ```

5. Add the Essential JS 2 Script Manager at the end of `<body>` element in the `~/Views/Shared/_Layout.cshtml` layout page.

    ```html
    <body>
        ....
        ....
        <!-- Syncfusion Essential JS 2 ScriptManager -->
        <ejs-scripts></ejs-scripts>
    </body>
    ```

6. Now, you can add the Syncfusion Essential JS 2 components in any web page (`cshtml`) in the `Home` folder.

    For example, the calendar component is added to the `~/Views/Home/Index.cshtml` page.

    ```html
    <div>
        <ejs-calendar id="calendar"></ejs-calendar>
    </div>
    ```

7. Run the application. The Essential JS 2 calendar component will render in the web browser.

   ![aspnetcore3.x calendar component output](images/aspnetcore-calendar.png)


## Using Visual Studio 2017

### Getting Started with ASP.NET Core 2.x

#### Prerequisites

The official prerequisites to create and run an ASP.NET Core 2.x application on Windows environment are described in the [.NET Core documentation website](https://docs.microsoft.com/en-us/dotnet/core/windows-prerequisites?tabs=netcore2x).

#### Create ASP.NET Core web application

1. Choose **File > New > Project...** in the Visual Studio menu bar.

    ![new project in aspnetcore2.x](images/new-project.png)

2. Select **Installed > Visual C# > .NET Core** and choose the required **.NET Framework** in the drop-down.

3. Select **ASP.NET Core Web Application** and change the application name, and then click **OK**.

    > The Essential JS 2 supports 4.5+ .NET Framework in the ASP.NET Core application. i.e. The minimum target framework is 4.5 for Syncfusion ASP.NET Core (Essential JS 2).

    ![aspnetcore2.x project template](images/aspnetcore2x-template.png)

4. Choose **.NET Core** with **ASP.NET Core 2.0** and select **Web Application(Model-View-Controller)**, and then click **OK**. The web application project is now created with default ASP.NET Core template.

    ![aspnetcore2.x web application template](images/aspnetcore2x-netcore.png)

#### Configure Essential JS 2 in the application

1. Add the [`Syncfusion.EJ2.AspNet.Core`](https://www.nuget.org/packages/Syncfusion.EJ2.AspNet.Core/) NuGet package to the new application by using the Nuget Package Manager. Right-click the project and select **Manage NuGet Packages...**.

    > Refer to [this article](../nuget-packages) to learn more details about installing Essential JS 2 NuGet packages in various OS environment.

    ![aspnetcore2.x manage nuget packages](images/aspnetcore2x-manage-nuget.png)

2. Search the `Syncfusion.EJ2.AspNet` keyword in the **Browse** tab and install **Syncfusion.EJ2.AspNet.Core** NuGet package in the application.

    ![aspnetcore2.x install nuget packages](images/aspnetcore-nuget-package.png)

    The Essential JS 2 package will be included in the project, after the installation process is completed.

    > **Note:** The Syncfusion.EJ2.AspNet.Core NuGet package has dependencies, [`Newtonsoft.Json`](https://www.nuget.org/packages/Newtonsoft.Json/) for JSON serialization and [`Syncfusion.Licensing`](https://www.nuget.org/packages/Syncfusion.Licensing/) for validating Syncfusion license key.

3. Open `~/Views/_ViewImports.cshtml` file and import the `Syncfusion.EJ2` package.

    ```html
    @addTagHelper *, Syncfusion.EJ2
    ```

4. Add the client-side resources through [CDN](https://ej2.syncfusion.com/documentation/deployment/#cdn) or [local npm package](https://www.npmjs.com/package/@syncfusion/ej2) in the `<head>` element of the `~/Views/Shared/_Layout.cshtml` layout page.

    ```html
    <head>
        ....
        ....

        <!-- Syncfusion Essential JS 2 Styles -->
        <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/material.css" />

        <!-- Syncfusion Essential JS 2 Scripts -->
        <script src="https://cdn.syncfusion.com/ej2/dist/ej2.min.js"></script>
    </head>
    ```

5. Add the Essential JS 2 Script Manager at the end of `<body>` element in the `~/Views/Shared/_Layout.cshtml` layout page.

    ```html
    <body>
        ....
        ....
        <!-- Syncfusion Essential JS 2 ScriptManager -->
        <ejs-scripts></ejs-scripts>
    </body>
    ```

6. Now, add the Syncfusion Essential JS 2 components in any web page (`cshtml`) in the `Views` folder.

    For example, the calendar component is added in the `~/Views/Home/Index.cshtml` page.

    ```html
    <div>
        <ejs-calendar id="calendar"></ejs-calendar>
    </div>
    ```

7. Run the application. The Essential JS 2 calendar component will render in the web browser.

    ![aspnetcore2.x calendar component output](images/aspnetcore-calendar.png)

### Getting started with ASP.NET Core 1.x

#### Prerequisites

The official prerequisites to create and run an ASP.NET Core 1.x application on Windows environment are described in the [.NET Core documentation website](https://docs.microsoft.com/en-us/dotnet/core/windows-prerequisites?tabs=netcore1x).

#### Create ASP.NET core web application

1. Choose **File > New > Project...** in the Visual Studio menu bar.

    ![new project in aspnetcore1.x](images/new-project.png)

2. Select **Installed > Visual C# > .NET Core** and choose the required **.NET Framework** in the drop-down.

3. Select **ASP.NET Core Web Application** and change the application name and then click **OK**.

    > The Essential JS 2 supports 4.5+ .NET Framework in the ASP.NET Core application. i.e. The minimum target framework is 4.5 for Syncfusion ASP.NET Core (Essential JS 2).

    ![aspnetcore1.x project template](images/aspnetcore1x-template.png)

4. Choose **.NET Core** with *ASP.NET Core 1.0* and select **Web Application(Model-View-Controller)**, and then click **OK**. Now, the web application project is created with default ASP.NET Core template.

    ![aspnetcore1.x web application template](images/aspnetcore1x-netcore.png)

#### Configure Essential JS 2 in the application

1. Add the [`Syncfusion.EJ2.AspNet.Core`](https://www.nuget.org/packages/Syncfusion.EJ2.AspNet.Core/) NuGet package to the new web application by using the Nuget Package Manager. Right-click the project and select **Manage NuGet Packages...**.

    > Refer to [this article](../nuget-packages) to learn more details about installing Essential JS 2 NuGet packages in various OS environment.

    ![aspnetcore1.x manage nuget packages](images/aspnetcore1x-manage-nuget.png)

2. Search the `Syncfusion EJ2.AspNet` keyword in the **Browse** tab and install **Syncfusion.EJ2.AspNet.Core** NuGet package in the application.

    ![aspnetcore1.x install nuget packages](images/aspnetcore-nuget-package.png)

    The Essential JS 2 package will be included in the project, after the installation process is completed.

    > **Note:** The Syncfusion.EJ2.AspNet.Core NuGet package has dependencies, [`Newtonsoft.Json`](https://www.nuget.org/packages/Newtonsoft.Json/) for JSON serialization and [`Syncfusion.Licensing`](https://www.nuget.org/packages/Syncfusion.Licensing/) for validating Syncfusion license key.

3. Open the `~/Views/_ViewImports.cshtml` file and import the `Syncfusion.EJ2` package.

    ```html
    @addTagHelper *, Syncfusion.EJ2
    ```

4. Add the client-side resources through [CDN](https://ej2.syncfusion.com/documentation/deployment/#cdn) or [local npm package](https://www.npmjs.com/package/@syncfusion/ej2) in the `<head>` element of `~/Views/Shared/_Layout.cshtml` layout page.

    ```html
    <head>
        ....
        ....

        <!-- Syncfusion Essential JS 2 Styles -->
        <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/material.css" />

        <!-- Syncfusion Essential JS 2 Scripts -->
        <script src="https://cdn.syncfusion.com/ej2/dist/ej2.min.js"></script>
    </head>
    ```

5. Add the Essential JS 2 Script Manager at the end of `<body>` element in the `~/Views/Shared/_Layout.cshtml` layout page.

    ```html
    <body>
        ....
        ....
        <!-- Syncfusion Essential JS 2 ScriptManager -->
        <ejs-scripts></ejs-scripts>
    </body>
    ```

6. Now, add the Syncfusion Essential JS 2 components in any web page (`cshtml`) in the `Views` folder.

    For example, add the calendar component in the `~/Views/Home/Index.cshtml` page.

    ```html
    <div>
        <ejs-calendar id="calendar"></ejs-calendar>
    </div>
    ```

7. Run the application. The Essential JS 2 calendar component will render in the web browser.

    ![aspnetcore1.x calendar component output](images/aspnetcore-calendar.png)